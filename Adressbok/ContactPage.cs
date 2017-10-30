using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adressbok.Models;

namespace Adressbok
{
	public partial class ContactPage : Form
	{
		private Person person;

		public ContactPage(DataTable personer, int row)
		{
			person = Person.ParseRow(personer.Rows[row]);
			person.FetchDependencies();

			InitializeComponent();

			inputName.Text = person.KontaktNamn;
			dataGridViewTelephone.DataSource = new BindingList<Telefon>(person.KontaktTelefon);
			dataGridViewEmail.DataSource = new BindingList<Epost>(person.KontaktEpost);

			inputType.DataSource = new[]
			{
				new ComboKontaktTyp("Personal contact", Person.Typ.PersonligKontakt),
				new ComboKontaktTyp("Work contact", Person.Typ.JobbKontakt),
				new ComboKontaktTyp("Other contact", Person.Typ.ÖvrigKontakt),
			};
			
			inputType.SelectedIndex = (int)person.KontaktTyp;
		}

		private void ResizeGridViewToFullHeight(object sender, object e)
		{
			if (!(sender is DataGridView dgv)) return;

			int height = dgv.ColumnHeadersVisible ? dgv.ColumnHeadersHeight : 0;

			foreach (DataGridViewRow dgvr in dgv.Rows)
				if (dgvr.Visible)
					height += dgvr.Height;

			dgv.Height = height;
		}


		public class ComboKontaktTyp
		{
			public Person.Typ Typ { get; set; }
			public string Text { get; set; }

			public ComboKontaktTyp(string text, Person.Typ typ)
			{
				Text = text;
				Typ = typ;
			}
		}

		private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!(sender is ToolStripItem item)) return;
			if (!(item.Owner is ContextMenuStrip menu)) return;
			if (!(menu.SourceControl is DataGridView dgv)) return;

			DataGridViewRow r = dgv.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
			DataGridViewCell x = dgv.SelectedCells.Cast<DataGridViewCell>().FirstOrDefault();
			int row = r?.Index ?? x?.RowIndex ?? -1;

			if (row != -1)
			{
				switch (dgv.DataSource)
				{
					case DataTable dt:
						dt.Rows[row].Delete();
						break;

					case IList tlist:
						tlist.RemoveAt(row);
						break;
				}
			}
		}

		private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!(sender is ToolStripItem item)) return;
			if (!(item.Owner is ContextMenuStrip menu)) return;
			if (!(menu.SourceControl is DataGridView dgv)) return;

			switch (dgv.DataSource)
			{
				case DataTable dt:
					dt.NewRow();
					break;
				case IList<Telefon> tlist:
					tlist.Add(new Telefon());
					break;
				case IList<Epost> elist:
					elist.Add(new Epost());
					break;
			}
		}
	}
}
