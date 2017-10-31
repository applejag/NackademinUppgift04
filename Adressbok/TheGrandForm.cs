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


		private void OpenPersonInForm()
		{
			if (!(listBoxPersons.SelectedItem is Person person)) return;

			contactNameTextBox.Text = person.PersonName;
			contactEmailTextBox.Text = person.PersonEmail;
			contactTypeComboBox.SelectedItem = person.PersonType;

			contactSaveButton.Enabled = true;
			contactDeleteButton.Enabled = true;
		}

		private void TheGrandForm_Load(object sender, EventArgs e)
		{
			contactTypeComboBox.DataSource = Enum.GetValues(typeof(Person.ContactType));
		}

		private void buttonShowAll_Click(object sender, EventArgs e)
		{
			listBoxPersons.Items.Clear();
			listBoxPersons.Items.AddRange(Person.SelectAll());
		}

		private void listBoxPersons_DoubleClick(object sender, EventArgs e)
		{
			OpenPersonInForm();
		}

		private void buttonOpenContact_Click(object sender, EventArgs e)
		{
			OpenPersonInForm();
		}

		private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonOpenContact.Enabled = listBoxPersons.SelectedItem is Person;
		}

		private void listBoxPersons_MouseClick(object sender, MouseEventArgs e)
		{
			// Deselect if clicked outside
			bool anyClicked = false;

			for (int i = 0; i < listBoxPersons.Items.Count; i++)
			{
				if (listBoxPersons.GetItemRectangle(i).Contains(e.Location))
				{
					anyClicked = true;
					break;
				}
			}

			if (!anyClicked)
			{
				listBoxPersons.ClearSelected();
			}
		}
	}
}
