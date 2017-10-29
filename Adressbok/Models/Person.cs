using System.Data;
using System.Threading.Tasks;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Person
	{
		private const string _tableName = "Person";

		public int KontaktID { get; set; }
		public string KontaktNamn { get; set; }
		public Typ KontaktTyp { get; set; }

		public enum Typ : byte
		{
			PersonligKontakt = 0,
			JobbKontakt = 1,
			ÖvrigKontakt = 2,
		}

		public static async Task<DataTable> SelectAll()
		{
			const string commandText = "SELECT * FROM " + _tableName;

			return await DataAccess.ExecuteSelectCommandAsync(commandText);
		}

		public static Person ParseRow(DataRow row)
		{
			return new Person
			{
				KontaktID = (int)row["kontakt_id"],
				KontaktNamn = (string)row["kontakt_namn"],
				KontaktTyp = (Typ)(byte)row["kontakt_typ"],
			};
		}

	}
}