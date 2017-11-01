using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Person
	{
		internal const string table = "Person";

		public int PersonID { get; }
		public string PersonName { get; set; }
		public string PersonEmail { get; set; }
		public ContactType PersonType { get; set; }
		public IReadOnlyList<Telephone> Telephones => _telephones;
		public IReadOnlyList<Address> Addresses => _addresses;

		private readonly List<Telephone> _telephones;
		private readonly List<Address> _addresses;

		public Person(int id, string name, ContactType type, string email, Telephone[] telephones, Address[] addresses)
		{
			PersonID = id;
			PersonName = (name ?? string.Empty).Trim();
			PersonType = type;
			PersonEmail = (email ?? string.Empty).Trim();
			_telephones = new List<Telephone>(telephones);
			_addresses = new List<Address>(addresses);
		}

		public Person(int id, string name, ContactType type, string email)
			: this(id, name, type, email,
				  telephones: Telephone.SelectFromPersonID(id),
				  addresses: Address.SelectFromPersonID(id))
		{}

		public bool Save()
		{
			const string query = "UPDATE " + table + " SET kontakt_namn=@name, kontakt_typ=@type, epost_adress=@email WHERE kontakt_id=@id";

			SqlParameter[] parameters = {
				new SqlParameter("@id", PersonID), 
				new SqlParameter("@name", (PersonName ?? string.Empty).Trim()),
				new SqlParameter("@type", (short)PersonType),
				new SqlParameter("@email", (PersonEmail ?? string.Empty).Trim()),
			};

			using (var data = new DataAccess())
				return data.ExecuteNonQuery(query, parameters) >= 1;
		}

		public bool Delete()
		{
			const string query = "DELETE FROM " + table + " WHERE kontakt_id=@id";

			SqlParameter[] parameters = {
				new SqlParameter("@id", PersonID),
			};

			using (var data = new DataAccess())
				return data.ExecuteNonQuery(query, parameters) >= 1;
		}

		public static Person Create(string name, ContactType type, string email)
		{
			const string query = "INSERT INTO " + table + " (kontakt_namn, kontakt_typ, epost_adress) OUTPUT INSERTED.kontakt_id VALUES (@name, @type, @email)";

			SqlParameter[] parameters = {
				new SqlParameter("@name", (name ?? string.Empty).Trim()),
				new SqlParameter("@type", (short)type),
				new SqlParameter("@email", (email ?? string.Empty).Trim()),
			};

			using (var data = new DataAccess())
			{
				int id = (int)data.ExecuteScalar(query, parameters);
				return new Person(id, name, type, email);
			}
		}

		public static Person FromDataRow(DataRow row)
		{
			var id = (int)row["kontakt_id"];
			var name = (string)row["kontakt_namn"];
			var type = (ContactType)(byte)row["kontakt_typ"];
			var email = (string)row["epost_adress"];

			return new Person(id, name, type, email);
		}

		public static Person SelectFromID(int id)
		{
			const string query = "SELECT TOP 1 * FROM " + table + " WHERE kontakt_id=@id";

			SqlParameter[] parameters = {
				new SqlParameter("@id", id),
			};

			using (var data = new DataAccess())
			{
				DataRowCollection rows = data.ExecuteSelectCommand(query, parameters).Rows;

				return rows.Count == 0 ? null : FromDataRow(rows[0]);
			}
		}

		public static Person[] SelectAll()
		{
			const string query = "SELECT * FROM " + table + " ORDER BY kontakt_namn";

			using (var data = new DataAccess())
			{
				return data.ExecuteSelectCommand(query).Rows
					.Cast<DataRow>()
					.Select(FromDataRow)
					.ToArray();
			}
		}

		private static string ConstructSearchQuery(IEnumerable<ContactType> types, bool searchEmail, bool searchAddresses, bool searchTelephones, string orderBy)
		{
			string typesString = string.Join(", ", types.Select(t => (byte)t).Distinct());
			if (typesString.Length == 0)
				return null;

			const string search = "'%'+@search+'%'";
			var sb = new StringBuilder();

			sb.Append($"SELECT * FROM {table} WHERE" +
			          $" kontakt_typ IN ({typesString})" +
			          $" AND (kontakt_namn LIKE {search}");

			if (searchEmail)
			{
				sb.Append($"OR epost_adress LIKE {search}");
			}

			if (searchAddresses)
			{
				sb.Append($" OR (SELECT COUNT(*) FROM {Address.table} WHERE" +
							$" {Address.table}.kontakt_id={table}.kontakt_id" +
							$" AND (adress_gata LIKE {search}" +
								$" OR adress_post_nr LIKE {search}" +
								$" OR adress_post_ort LIKE {search})) > 0");
			}

			if (searchTelephones)
			{
				sb.Append($" OR (SELECT COUNT(*) FROM {Telephone.table} WHERE" +
							$" {Telephone.table}.kontakt_id={table}.kontakt_id" +
							$" AND (telefon_nr LIKE {search})) > 0");
			}

			sb.Append($") ORDER BY {orderBy ?? "kontakt_namn ASC"}");

			return sb.ToString();
		}

		public static Person[] SelectSearch(string search, IEnumerable<ContactType> types, bool searchEmail, bool searchAddresses, bool searchTelephones, string orderBy)
		{
			string query = ConstructSearchQuery(
				types: types,
				searchEmail: searchEmail,
				searchAddresses: searchAddresses,
				searchTelephones: searchTelephones,
				orderBy: orderBy);

			if (query == null)
				return new Person[0];

			SqlParameter[] parameters =
			{
				new SqlParameter("@search", search ?? string.Empty), 
			};

			using (var data = new DataAccess())
			{
				return data.ExecuteSelectCommand(query, parameters).Rows
					.Cast<DataRow>()
					.Select(FromDataRow)
					.ToArray();
			}
		}

		public enum ContactType : byte
		{
			Personal = 0,
			Work = 1,
			Other = 2,
		}

		public override string ToString()
		{
			var sb = new StringBuilder($"[{PersonType.ToString()[0]}] {PersonName ?? "/unnamed/"}");

			//if (!string.IsNullOrWhiteSpace(PersonEmail))
			//	sb.Append($" ({PersonEmail})");

			return sb.ToString();
		}
	}
}