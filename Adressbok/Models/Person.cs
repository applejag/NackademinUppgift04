using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Person
	{
		private const string _tableName = "Person";

		public int KontaktID { get; private set; }
		public string KontaktNamn { get; set; }
		public Typ KontaktTyp { get; set; }

		public List<Telefon> KontaktTelefon { get; set; }
		public List<Epost> KontaktEpost { get; set; }

		public Person()
		{
		}

		public Person(int id)
		{
			KontaktID = id;
			ApplyRow(SelectSingle(id).Result);
		}

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

		public static async Task<DataRow> SelectSingle(int person_id)
		{
			string commandText = $"SELECT TOP 1 * FROM {_tableName} WHERE kontakt_id={person_id}";

			DataTable result = await DataAccess.ExecuteSelectCommandAsync(commandText);

			return result.Rows[0];
		}

		public void FetchDependencies()
		{
			KontaktTelefon = Telefon.SelectFromPerson(KontaktID).Result.Cast<DataRow>().Select(Telefon.ParseRow).ToList();
			KontaktEpost = Epost.SelectFromPerson(KontaktID).Result.Cast<DataRow>().Select(Epost.ParseRow).ToList();
		}

		public void ApplyRow(DataRow row)
		{
			KontaktID = (int)row["kontakt_id"];
			KontaktNamn = (string) row["kontakt_namn"];
			KontaktTyp = (Typ) (byte) row["kontakt_typ"];
		}

		public static Person ParseRow(DataRow row)
		{
			var person = new Person();
			person.ApplyRow(row);
			return person;
		}

	}
}