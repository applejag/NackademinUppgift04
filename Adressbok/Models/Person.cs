using System.Collections.Generic;
using System.Data;
using System.Linq;
using Adressbok.DAL;

namespace Adressbok.Models
{
	public class Person
	{
		public int PersonID { get; }
		public string PersonName { get; set; }
		public string PersonEmail { get; set; }
		public KontaktTyp PersonType { get; set; }

		public Person(int id, string name, KontaktTyp type, string email)
		{
			PersonID = id;
			PersonName = name;
			PersonType = type;
			PersonEmail = email;
		}

		public static Person FromDataRow(DataRow row)
		{
			var id = (int) row["kontakt_id"];
			var name = (string) row["kontakt_namn"];
			var type = (KontaktTyp) (byte) row["kontakt_typ"];
			var email = (string) row["epost_adress"];

			return new Person(id, name, type, email);
		}

		public static Person[] SelectAll()
		{
			using (var data = new DataAccess())
				return data.ExecuteSelectCommand("SELECT * FROM Person ORDER BY kontakt_namn").Rows
					.Cast<DataRow>()
					.Select(FromDataRow)
					.ToArray();
		}

		public enum KontaktTyp : byte
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