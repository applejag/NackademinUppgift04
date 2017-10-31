using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Address
	{
		private const string table = "Adress";

		public int AddressID { get; }
		public string AddressStreet { get; set; }
		public string AddressCity { get; set; }
		public int AddressPostCode { get; set; }
		public int PersonID { get; }

		public Address(int id, string street, string city, int postCode, int personId)
		{
			AddressID = id;
			AddressStreet = street;
			AddressCity = city;
			AddressPostCode = postCode;
			PersonID = personId;
		}
		
		public bool Delete()
		{
			const string query = "DELETE FROM " + table + " WHERE adress_id=@id";

			SqlParameter[] parameters = {
				new SqlParameter("@id", AddressID),
			};

			using (var data = new DataAccess())
				return data.ExecuteNonQuery(query, parameters) >= 1;
		}

		public static Address Create(string street, string city, int postCode, int personId)
		{
			const string query = "INSERT INTO " + table + " (adress_gata, adress_post_ort, adress_post_nr, kontakt_id) OUTPUT INSERTED.adress_id VALUES (@street, @city, @postCode, @personId)";

			SqlParameter[] parameters = {
				new SqlParameter("@street", street ?? string.Empty),
				new SqlParameter("@city", city ?? string.Empty),
				new SqlParameter("@postCode", postCode),
				new SqlParameter("@personId", personId),
			};

			using (var data = new DataAccess())
			{
				int id = (int)data.ExecuteScalar(query, parameters);
				return new Address(id, street, city, postCode, personId);
			}
		}

		public static Address[] SelectFromPersonID(int personId)
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


		public static Address FromDataRow(DataRow row)
		{
			var id = (int)row["adress_id"];
			var street = (string)row["adress_gata"];
			var city = (string)row["adress_post_ort"];
			var postCode = (int)row["adress_post_nr"];
			var personId = (int)row["kontakt_id"];

			return new Address(id, street, city, postCode, personId);
		}

		public override string ToString()
		{
			return $"{AddressStreet}, {AddressCity} {AddressPostCode:## ###}";
		}
	}
}