using System.Data;
using System.Threading.Tasks;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Telefon
	{
		private const string _tableName = "Telefon";

		public int TelefonID { get; set; }
		public string TelefonNummer { get; set; }
		public int KontaktID { get; set; }
		
		public static async Task<DataTable> SelectAll()
		{
			const string commandText = "SELECT * FROM " + _tableName;

			return await DataAccess.ExecuteSelectCommandAsync(commandText);
		}

		public static async Task<DataRow> SelectSingle(int telefon_id)
		{
			string commandText = $"SELECT TOP 1 * FROM {_tableName} WHERE telefon_id={telefon_id}";

			DataTable result = await DataAccess.ExecuteSelectCommandAsync(commandText);

			return result.Rows[0];
		}

		public static async Task<DataRowCollection> SelectFromPerson(int person_id)
		{
			string commandText = $"SELECT TOP 1 * FROM {_tableName} WHERE kontakt_id={person_id}";

			DataTable result = await DataAccess.ExecuteSelectCommandAsync(commandText);

			return result.Rows;
		}

		public void ApplyRow(DataRow row)
		{
			TelefonID = (int) row["telefon_id"];
			TelefonNummer = (string) row["telefon_nr"];
			KontaktID = (int) row["kontakt_id"];
		}

		public static Telefon ParseRow(DataRow row)
		{
			var tele = new Telefon();
			tele.ApplyRow(row);
			return tele;
		}
	}
}