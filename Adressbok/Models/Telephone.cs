using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Telephone
	{
		internal const string table = "Telefon";

		public int TelephoneID { get; }
		public string TelephoneNumber { get; set; }
		public int PersonID { get; }

		public Telephone(int id, string number, int personId)
		{
			TelephoneID = id;
			TelephoneNumber = number;
			PersonID = personId;
		}

		public bool Delete()
		{
			const string query = "DELETE FROM " + table + " WHERE adress_id=@id";

			SqlParameter[] parameters = {
				new SqlParameter("@id", TelephoneID),
			};

			using (var data = new DataAccess())
				return data.ExecuteNonQuery(query, parameters) >= 1;
		}

		public static Telephone Create(string number, int personId)
		{
			const string query = "INSERT INTO " + table + " (telefon_nr, kontakt_id) OUTPUT INSERTED.telefon_id VALUES (@number, @personId)";

			SqlParameter[] parameters = {
				new SqlParameter("@number", number ?? string.Empty),
				new SqlParameter("@personId", personId),
			};

			using (var data = new DataAccess())
			{
				int id = (int)data.ExecuteScalar(query, parameters);
				return new Telephone(id, number, personId);
			}
		}

		public static Telephone[] SelectFromPersonID(int personId)
		{
			const string query = "SELECT * FROM " + table + " WHERE kontakt_id=@personId";

			SqlParameter[] parameters = {
				new SqlParameter("@personId", personId),
			};

			using (var data = new DataAccess())
				return data.ExecuteSelectCommand(query, parameters).Rows
					.Cast<DataRow>()
					.Select(FromDataRow)
					.ToArray();
		}


		public static Telephone FromDataRow(DataRow row)
		{
			var id = (int)row["telefon_id"];
			var number = (string)row["telefon_nr"];
			var personId = (int)row["kontakt_id"];

			return new Telephone(id, number, personId);
		}

		public override string ToString()
		{
			return TelephoneNumber;
		}
	}
}