using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.XPath;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Person
	{
		private const string table = "Person";

		public int PersonID { get; }
		public string PersonName { get; set; }
		public string PersonEmail { get; set; }
		public ContactType PersonType { get; set; }

		public Person(int id, string name, ContactType type, string email)
		{
			PersonID = id;
			PersonName = name;
			PersonType = type;
			PersonEmail = email;
		}

		public bool Save()
		{
			const string query = "UPDATE " + table + " SET kontakt_namn=@name, kontakt_typ=@type, epost_adress=@email";

			SqlParameter[] parameters = {
				new SqlParameter("@name", PersonName ?? string.Empty),
				new SqlParameter("@type", (short)PersonType),
				new SqlParameter("@email", PersonEmail ?? string.Empty),
			};

			using (var data = new DataAccess())
			{
				return data.ExecuteNonQuery(query, parameters) == 1;
			}
		}

		public static Person Create(string name, ContactType type, string email)
		{
			const string query = "INSERT INTO " + table + " (kontakt_namn, kontakt_typ, epost_adress) OUTPUT INSERTED.kontakt_id VALUES (@name, @type, @email)";

			SqlParameter[] parameters = {
				new SqlParameter("@name", name ?? string.Empty),
				new SqlParameter("@type", (short)type),
				new SqlParameter("@email", email ?? string.Empty),
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

		public enum ContactType : byte
		{
			Personal = 0,
			Work = 1,
			Other = 2,
		}

		public override string ToString()
		{
			return PersonName ?? string.Empty;
		}
	}
}