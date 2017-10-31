using System;
using System.Linq;
using System.Windows.Forms;

namespace Adressbok
{
	public partial class Form1 : Form
	{
		public enum KontaktTyper : short
		{
			PersonligKontakt = 0,
			JobbKontakt = 1,
			ÖvrigKontakt = 2,
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			kontakttypDataGridViewTextBoxColumn.DefaultCellStyle.NullValue = "0";
			SetComboboxToEnumThingieMcGig(kontakttypDataGridViewComboBoxColumn);

			// TODO: This line of code loads data into the 'adressbok2DataSet.Kontakt' table. You can move, or remove it, as needed.
			this.kontaktTableAdapter.Fill(this.adressbok2DataSet.Kontakt);
		}

		private static void SetComboboxToEnumThingieMcGig(DataGridViewComboBoxColumn column)
		{
			column.ValueType = typeof(string);
			column.ValueMember = "Value";
			column.DisplayMember = "Display";
			column.DataSource = Enum.GetValues(typeof(KontaktTyper))
				.OfType<KontaktTyper>()
				.Select(value => new {Display = value.ToString(), Value = ((short)value).ToString()})
				.ToList();

			//column.DefaultCellStyle.NullValue =
			//	new { Display = default(KontaktTyper).ToString(), Value = ((short)default(KontaktTyper)).ToString() };
		}

		private void myDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= myDataGridView.RowCount) return;

			DataGridViewTextBoxColumn txtcol = kontakttypDataGridViewTextBoxColumn;
			DataGridViewComboBoxColumn boxcol = kontakttypDataGridViewComboBoxColumn;
			if (e.ColumnIndex == boxcol.Index)
			{
				DataGridViewCell txtcell = myDataGridView[txtcol.Index, e.RowIndex];
				DataGridViewCell boxcell = myDataGridView[boxcol.Index, e.RowIndex];
				txtcell.Value = boxcell.Value;
			}
		}

		private void myDataGridView_CurrentCellChanged(object sender, EventArgs e)
		{

		}
	}
}
