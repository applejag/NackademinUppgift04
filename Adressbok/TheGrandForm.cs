using System;
using System.Linq;
using System.Windows.Forms;
using Adressbok.Models;

namespace Adressbok
{
	public partial class TheGrandForm : Form
	{
		private Person currentPerson = null;
		
		public TheGrandForm()
		{
			InitializeComponent();
			PersonChanged();

			contactTypeComboBox.DataSource = Enum.GetValues(typeof(Person.ContactType));

			searchContactTypeBoxes.DataSource = Enum.GetValues(typeof(Person.ContactType));
			for (int i = 0; i < searchContactTypeBoxes.Items.Count; i++)
				searchContactTypeBoxes.SetItemChecked(i, true);

			searchOrderByComboBox.DataSource = new[]
			{
				new OrderByItem {Name="Name", Column = "kontakt_namn"},
				new OrderByItem {Name="E-mail", Column = "epost_adress"},
				new OrderByItem {Name="Contact type", Column = "kontakt_typ"},
			};

			searchOrderByComboBox.SelectedIndex = 0;
		}

		private void TheGrandForm_Load(object sender, EventArgs e)
		{
			PerformSearch();
		}

		private void PerformSearch()
		{
			listBoxPersons.Items.Clear();

			string search = searchTextBox.Text;
			Person.ContactType[] types = searchContactTypeBoxes.CheckedItems
				.Cast<Person.ContactType>()
				.ToArray();

			bool searchEmail = searchEmailBox.Checked;
			bool searchAddresses = searchAddressesBox.Checked;
			bool searchTelephones = searchTelephonesBox.Checked;

			bool searchOrderByAscending = searchOrderByAscendingBox.Checked;
			var searchOrderByItem = (OrderByItem)searchOrderByComboBox.SelectedItem;
			string searchOrderByQuery = searchOrderByItem.Column + (searchOrderByAscending ? " ASC" : " DESC");

			Person[] searchResult = Person.SelectSearch(search, types, searchEmail, searchAddresses, searchTelephones, searchOrderByQuery);
			if (searchResult != null)
			{
				listBoxPersons.Items.AddRange(searchResult);
			}
			else
			{
				MessageBox.Show("Something went wrong during the search.\n\nProbably an error in the SQL command ¯\\_(ツ)_/¯", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void OpenPersonFromList()
		{
			if (!(listBoxPersons.SelectedItem is Person person)) return;

			currentPerson = person;
			PersonChanged();
		}

		private void PersonChanged()
		{
			bool exists = currentPerson != null;

			contactNameTextBox.Text = currentPerson?.PersonName ?? string.Empty;
			contactEmailTextBox.Text = currentPerson?.PersonEmail ?? string.Empty;
			contactTypeComboBox.SelectedItem = currentPerson?.PersonType ?? Person.ContactType.Personal;

			contactTelephoneListBox.Items.Clear();
			contactTelephoneListBox.ClearSelected();
			if (exists)
				contactTelephoneListBox.Items.AddRange(Telephone.SelectFromPersonID(currentPerson.PersonID));
			contactTelephoneListBox.Enabled = exists;
			contactTelephoneAddButton.Enabled = false;
			contactTelephoneRemoveButton.Enabled = false;
			contactTelephoneTextBox.Text = string.Empty;
			contactTelephoneTextBox.Enabled = exists;
			labelTelephone.Enabled = exists;

			contactAddressListBox.Items.Clear();
			contactAddressListBox.ClearSelected();
			if (exists)
				contactAddressListBox.Items.AddRange(Address.SelectFromPersonID(currentPerson.PersonID));
			contactAddressListBox.Enabled = exists;
			contactAddressAddButton.Enabled = false;
			contactAddressRemoveButton.Enabled = false;
			contactAddressStreetTextBox.Text = string.Empty;
			contactAddressStreetTextBox.Enabled = exists;
			contactAddressCityTextBox.Text = string.Empty;
			contactAddressCityTextBox.Enabled = exists;
			contactAddressPostCodeTextBox.Text = string.Empty;
			contactAddressPostCodeTextBox.Enabled = exists;
			labelAddress.Enabled =
			labelAddressCity.Enabled =
			labelAddressPostCode.Enabled =
			labelAddressStreet.Enabled = exists;

			contactSaveButton.Enabled = exists;
			contactDeleteButton.Enabled = exists;
		}

		private void buttonShowAll_Click(object sender, EventArgs e)
		{
			PerformSearch();
		}

		private void listBoxPersons_DoubleClick(object sender, EventArgs e)
		{
			OpenPersonFromList();
		}

		private void buttonOpenContact_Click(object sender, EventArgs e)
		{
			OpenPersonFromList();
		}

		private void CheckIfDeselect(object sender, MouseEventArgs e)
		{
			if (!(sender is ListBox listBox)) return;

			// Deselect if clicked outside
			bool anyClicked = false;

			for (int i = 0; i < listBox.Items.Count; i++)
			{
				if (listBox.GetItemRectangle(i).Contains(e.Location))
				{
					anyClicked = true;
					break;
				}
			}

			if (!anyClicked)
			{
				listBox.ClearSelected();
			}
		}

		private void KeyPress_TelephoneNumber(object sender, KeyPressEventArgs e)
		{
			const string valid = "0123456789+-() ";

			if (!char.IsControl(e.KeyChar) && valid.IndexOf(e.KeyChar) == -1)
				e.Handled = true;
		}

		private void KeyPress_AddressPostCode(object sender, KeyPressEventArgs e)
		{
			const string valid = "0123456789 ";

			if (!char.IsControl(e.KeyChar) && valid.IndexOf(e.KeyChar) == -1)
				// Discard
				e.Handled = true;
		}

		private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonOpenContact.Enabled = listBoxPersons.SelectedItem is Person;
		}

		private void contactTelephoneListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			contactTelephoneRemoveButton.Enabled = contactTelephoneListBox.SelectedItem is Telephone;
		}

		private void contactAddressListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			contactAddressRemoveButton.Enabled = contactAddressListBox.SelectedItem is Address;
		}

		private void UpdateAddressAddButtonEnableness(object sender, EventArgs e)
		{
			contactAddressAddButton.Enabled = currentPerson != null
				&& !string.IsNullOrWhiteSpace(contactAddressStreetTextBox.Text)
				&& !string.IsNullOrWhiteSpace(contactAddressCityTextBox.Text)
				&& !string.IsNullOrWhiteSpace(contactAddressPostCodeTextBox.Text);
		}

		private void UpdatePersonCreateButtonEnableness(object sender, EventArgs e)
		{
			contactCreateButton.Enabled =
				!string.IsNullOrWhiteSpace(contactNameTextBox.Text)
				&& !string.IsNullOrWhiteSpace(contactEmailTextBox.Text);
			contactSaveButton.Enabled = currentPerson != null
				&& contactCreateButton.Enabled;
		}

		private void contactTelephoneTextBox_TextChanged(object sender, EventArgs e)
		{
			contactTelephoneAddButton.Enabled = currentPerson != null
				&& !string.IsNullOrWhiteSpace(contactTelephoneTextBox.Text);
		}

		private void contactTelephoneAddButton_Click(object sender, EventArgs e)
		{
			if (currentPerson == null) return;

			string number = contactTelephoneTextBox.Text;
			Telephone telephone = Telephone.Create(number, currentPerson.PersonID);

			if (telephone != null)
			{
				contactTelephoneListBox.Items.Add(telephone);

				contactTelephoneTextBox.Text = string.Empty;
			}
			else
			{
				MessageBox.Show("Something went wrong while creating telephone number...", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void contactTelephoneRemoveButton_Click(object sender, EventArgs e)
		{
			if (!(contactTelephoneListBox.SelectedItem is Telephone telephone)) return;

			telephone.Delete();
			contactTelephoneListBox.Items.Remove(telephone);
		}

		private void contactAddressAddButton_Click(object sender, EventArgs e)
		{
			if (currentPerson == null) return;

			string street = contactAddressStreetTextBox.Text;
			string postCodeString = contactAddressPostCodeTextBox.Text.Replace(" ", string.Empty);
			if (!int.TryParse(postCodeString, out int postCode)) postCode = 0;
			string text = contactAddressCityTextBox.Text;

			Address address = Address.Create(street, text, postCode, currentPerson.PersonID);
			if (address != null)
			{
				contactAddressListBox.Items.Add(address);

				contactAddressStreetTextBox.Text = string.Empty;
				contactAddressPostCodeTextBox.Text = string.Empty;
				contactAddressCityTextBox.Text = string.Empty;
			}
			else
			{
				MessageBox.Show("Something went wrong while creating address...", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void contactAddressRemoveButton_Click(object sender, EventArgs e)
		{
			if (!(contactAddressListBox.SelectedItem is Address address)) return;

			address.Delete();
			contactAddressListBox.Items.Remove(address);
		}

		private void contactDeleteButton_Click(object sender, EventArgs e)
		{
			if (currentPerson == null) return;

			listBoxPersons.Items.Remove(currentPerson);
			currentPerson.Delete();
			currentPerson = null;
			PersonChanged();
		}

		private void contactSaveButton_Click(object sender, EventArgs e)
		{
			if (currentPerson == null) return;

			currentPerson.PersonName = contactNameTextBox.Text;
			currentPerson.PersonEmail = contactEmailTextBox.Text;

			if (!currentPerson.Save())
				MessageBox.Show("Something went wrong while saving person...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void contactCreateButton_Click(object sender, EventArgs e)
		{
			string name = contactNameTextBox.Text;
			string email = contactEmailTextBox.Text;
			var type = (Person.ContactType)contactTypeComboBox.SelectedItem;

			Person person = Person.Create(name, type, email);
			if (person != null)
			{
				currentPerson = person;
				PersonChanged();
			}
			else
			{
				MessageBox.Show("Something went wrong while creating person...", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private struct OrderByItem
		{
			public string Name;
			public string Column;

			public override string ToString()
			{
				return Name;
			}
		}
	}
}
