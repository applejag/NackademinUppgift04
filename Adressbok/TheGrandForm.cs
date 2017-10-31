using System;
using System.Linq;
using System.Windows.Forms;
using Adressbok.Models;

namespace Adressbok
{
	public partial class TheGrandForm : Form
	{
		public TheGrandForm()
		{
			InitializeComponent();
		}

		private void TheGrandForm_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonShowAll_Click(object sender, EventArgs e)
		{
			listBoxPersons.Items.Clear();
			listBoxPersons.Items.AddRange(Person.SelectAll());
		}
	}
}
