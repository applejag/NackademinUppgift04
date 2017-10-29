using System.Data;
using System.Windows.Forms;
using Adressbok.Models;

namespace Adressbok
{
	public partial class ContactList : Form
	{
		public ContactList()
		{
			InitializeComponent();
		}

		private async void ContactList_Load(object sender, System.EventArgs e)
		{
			DataTable personer = await Person.SelectAll();
			personerGridView.DataSource = personer;
		}

		private void personerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var personer = (DataTable) personerGridView.DataSource;
			new ContactPage(personer, e.RowIndex).Show();
		}
	}
}
