namespace Adressbok
{
	partial class TheGrandForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBoxPersons = new System.Windows.Forms.ListBox();
			this.contactCreateButton = new System.Windows.Forms.Button();
			this.contactSaveButton = new System.Windows.Forms.Button();
			this.contactDeleteButton = new System.Windows.Forms.Button();
			this.buttonShowAll = new System.Windows.Forms.Button();
			this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.contactTypeComboBox = new System.Windows.Forms.ComboBox();
			this.contactNameTextBox = new System.Windows.Forms.TextBox();
			this.contactEmailTextBox = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.buttonOpenContact = new System.Windows.Forms.Button();
			this.labelAddressPostCode = new System.Windows.Forms.Label();
			this.labelAddressCity = new System.Windows.Forms.Label();
			this.labelAddressStreet = new System.Windows.Forms.Label();
			this.contactAddressPostCodeTextBox = new System.Windows.Forms.TextBox();
			this.contactAddressCityTextBox = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.contactAddressRemoveButton = new System.Windows.Forms.Button();
			this.contactAddressAddButton = new System.Windows.Forms.Button();
			this.contactAddressStreetTextBox = new System.Windows.Forms.TextBox();
			this.contactAddressListBox = new System.Windows.Forms.ListBox();
			this.labelTelephone = new System.Windows.Forms.Label();
			this.contactTelephoneRemoveButton = new System.Windows.Forms.Button();
			this.contactTelephoneAddButton = new System.Windows.Forms.Button();
			this.contactTelephoneTextBox = new System.Windows.Forms.TextBox();
			this.contactTelephoneListBox = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxPersons
			// 
			this.listBoxPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxPersons.IntegralHeight = false;
			this.listBoxPersons.Location = new System.Drawing.Point(15, 227);
			this.listBoxPersons.Name = "listBoxPersons";
			this.listBoxPersons.Size = new System.Drawing.Size(227, 204);
			this.listBoxPersons.TabIndex = 0;
			this.listBoxPersons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckIfDeselect);
			this.listBoxPersons.SelectedIndexChanged += new System.EventHandler(this.listBoxPersons_SelectedIndexChanged);
			this.listBoxPersons.DoubleClick += new System.EventHandler(this.listBoxPersons_DoubleClick);
			// 
			// contactCreateButton
			// 
			this.contactCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.contactCreateButton.Enabled = false;
			this.contactCreateButton.Location = new System.Drawing.Point(172, 133);
			this.contactCreateButton.Name = "contactCreateButton";
			this.contactCreateButton.Size = new System.Drawing.Size(75, 23);
			this.contactCreateButton.TabIndex = 1;
			this.contactCreateButton.Text = "Create";
			this.contactCreateButton.UseVisualStyleBackColor = true;
			this.contactCreateButton.Click += new System.EventHandler(this.contactCreateButton_Click);
			// 
			// contactSaveButton
			// 
			this.contactSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.contactSaveButton.Enabled = false;
			this.contactSaveButton.Location = new System.Drawing.Point(91, 133);
			this.contactSaveButton.Name = "contactSaveButton";
			this.contactSaveButton.Size = new System.Drawing.Size(75, 23);
			this.contactSaveButton.TabIndex = 2;
			this.contactSaveButton.Text = "Save";
			this.contactSaveButton.UseVisualStyleBackColor = true;
			this.contactSaveButton.Click += new System.EventHandler(this.contactSaveButton_Click);
			// 
			// contactDeleteButton
			// 
			this.contactDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.contactDeleteButton.Enabled = false;
			this.contactDeleteButton.Location = new System.Drawing.Point(10, 133);
			this.contactDeleteButton.Name = "contactDeleteButton";
			this.contactDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.contactDeleteButton.TabIndex = 3;
			this.contactDeleteButton.Text = "Delete";
			this.contactDeleteButton.UseVisualStyleBackColor = true;
			this.contactDeleteButton.Click += new System.EventHandler(this.contactDeleteButton_Click);
			// 
			// buttonShowAll
			// 
			this.buttonShowAll.Location = new System.Drawing.Point(15, 198);
			this.buttonShowAll.Name = "buttonShowAll";
			this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
			this.buttonShowAll.TabIndex = 4;
			this.buttonShowAll.Text = "Show all";
			this.buttonShowAll.UseVisualStyleBackColor = true;
			this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
			// 
			// pictureBoxProfilePicture
			// 
			this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxProfilePicture.Image = global::Adressbok.Properties.Resources.pp;
			this.pictureBoxProfilePicture.Location = new System.Drawing.Point(9, 12);
			this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
			this.pictureBoxProfilePicture.Size = new System.Drawing.Size(115, 115);
			this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxProfilePicture.TabIndex = 5;
			this.pictureBoxProfilePicture.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(130, 12);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 6;
			this.labelName.Text = "Name";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(130, 51);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(35, 13);
			this.labelEmail.TabIndex = 7;
			this.labelEmail.Text = "E-mail";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(130, 90);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(67, 13);
			this.labelType.TabIndex = 8;
			this.labelType.Text = "Contact type";
			// 
			// contactTypeComboBox
			// 
			this.contactTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.contactTypeComboBox.FormattingEnabled = true;
			this.contactTypeComboBox.Items.AddRange(new object[] {
            "Personal contact",
            "Work contact",
            "Other contact"});
			this.contactTypeComboBox.Location = new System.Drawing.Point(130, 106);
			this.contactTypeComboBox.Name = "contactTypeComboBox";
			this.contactTypeComboBox.Size = new System.Drawing.Size(117, 21);
			this.contactTypeComboBox.TabIndex = 9;
			// 
			// contactNameTextBox
			// 
			this.contactNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactNameTextBox.Location = new System.Drawing.Point(130, 28);
			this.contactNameTextBox.MaxLength = 255;
			this.contactNameTextBox.Name = "contactNameTextBox";
			this.contactNameTextBox.Size = new System.Drawing.Size(117, 20);
			this.contactNameTextBox.TabIndex = 10;
			this.contactNameTextBox.TextChanged += new System.EventHandler(this.UpdatePersonCreateButtonEnableness);
			// 
			// contactEmailTextBox
			// 
			this.contactEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactEmailTextBox.Location = new System.Drawing.Point(130, 67);
			this.contactEmailTextBox.MaxLength = 255;
			this.contactEmailTextBox.Name = "contactEmailTextBox";
			this.contactEmailTextBox.Size = new System.Drawing.Size(117, 20);
			this.contactEmailTextBox.TabIndex = 11;
			this.contactEmailTextBox.TextChanged += new System.EventHandler(this.UpdatePersonCreateButtonEnableness);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.buttonOpenContact);
			this.splitContainer1.Panel1.Controls.Add(this.buttonShowAll);
			this.splitContainer1.Panel1.Controls.Add(this.listBoxPersons);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(12, 12, 6, 12);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.labelAddressPostCode);
			this.splitContainer1.Panel2.Controls.Add(this.labelAddressCity);
			this.splitContainer1.Panel2.Controls.Add(this.labelAddressStreet);
			this.splitContainer1.Panel2.Controls.Add(this.contactAddressPostCodeTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.contactAddressCityTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.labelAddress);
			this.splitContainer1.Panel2.Controls.Add(this.contactAddressRemoveButton);
			this.splitContainer1.Panel2.Controls.Add(this.contactAddressAddButton);
			this.splitContainer1.Panel2.Controls.Add(this.contactAddressStreetTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.contactAddressListBox);
			this.splitContainer1.Panel2.Controls.Add(this.labelTelephone);
			this.splitContainer1.Panel2.Controls.Add(this.contactTelephoneRemoveButton);
			this.splitContainer1.Panel2.Controls.Add(this.contactTelephoneAddButton);
			this.splitContainer1.Panel2.Controls.Add(this.contactTelephoneTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.contactTelephoneListBox);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBoxProfilePicture);
			this.splitContainer1.Panel2.Controls.Add(this.contactCreateButton);
			this.splitContainer1.Panel2.Controls.Add(this.contactSaveButton);
			this.splitContainer1.Panel2.Controls.Add(this.contactDeleteButton);
			this.splitContainer1.Panel2.Controls.Add(this.labelType);
			this.splitContainer1.Panel2.Controls.Add(this.contactTypeComboBox);
			this.splitContainer1.Panel2.Controls.Add(this.labelEmail);
			this.splitContainer1.Panel2.Controls.Add(this.contactEmailTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.labelName);
			this.splitContainer1.Panel2.Controls.Add(this.contactNameTextBox);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6, 12, 12, 12);
			this.splitContainer1.Size = new System.Drawing.Size(514, 443);
			this.splitContainer1.SplitterDistance = 251;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 12;
			// 
			// buttonOpenContact
			// 
			this.buttonOpenContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOpenContact.Enabled = false;
			this.buttonOpenContact.Location = new System.Drawing.Point(167, 198);
			this.buttonOpenContact.Name = "buttonOpenContact";
			this.buttonOpenContact.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenContact.TabIndex = 5;
			this.buttonOpenContact.Text = "Open >>";
			this.buttonOpenContact.UseVisualStyleBackColor = true;
			this.buttonOpenContact.Click += new System.EventHandler(this.buttonOpenContact_Click);
			// 
			// labelAddressPostCode
			// 
			this.labelAddressPostCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAddressPostCode.AutoSize = true;
			this.labelAddressPostCode.Location = new System.Drawing.Point(13, 352);
			this.labelAddressPostCode.Name = "labelAddressPostCode";
			this.labelAddressPostCode.Size = new System.Drawing.Size(55, 13);
			this.labelAddressPostCode.TabIndex = 26;
			this.labelAddressPostCode.Text = "Post code";
			// 
			// labelAddressCity
			// 
			this.labelAddressCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAddressCity.AutoSize = true;
			this.labelAddressCity.Location = new System.Drawing.Point(13, 326);
			this.labelAddressCity.Name = "labelAddressCity";
			this.labelAddressCity.Size = new System.Drawing.Size(24, 13);
			this.labelAddressCity.TabIndex = 25;
			this.labelAddressCity.Text = "City";
			// 
			// labelAddressStreet
			// 
			this.labelAddressStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAddressStreet.AutoSize = true;
			this.labelAddressStreet.Location = new System.Drawing.Point(13, 300);
			this.labelAddressStreet.Name = "labelAddressStreet";
			this.labelAddressStreet.Size = new System.Drawing.Size(35, 13);
			this.labelAddressStreet.TabIndex = 24;
			this.labelAddressStreet.Text = "Street";
			// 
			// contactAddressPostCodeTextBox
			// 
			this.contactAddressPostCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactAddressPostCodeTextBox.Location = new System.Drawing.Point(74, 349);
			this.contactAddressPostCodeTextBox.MaxLength = 255;
			this.contactAddressPostCodeTextBox.Name = "contactAddressPostCodeTextBox";
			this.contactAddressPostCodeTextBox.Size = new System.Drawing.Size(111, 20);
			this.contactAddressPostCodeTextBox.TabIndex = 23;
			this.contactAddressPostCodeTextBox.TextChanged += new System.EventHandler(this.UpdateAddressAddButtonEnableness);
			this.contactAddressPostCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_AddressPostCode);
			// 
			// contactAddressCityTextBox
			// 
			this.contactAddressCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactAddressCityTextBox.Location = new System.Drawing.Point(74, 323);
			this.contactAddressCityTextBox.MaxLength = 255;
			this.contactAddressCityTextBox.Name = "contactAddressCityTextBox";
			this.contactAddressCityTextBox.Size = new System.Drawing.Size(173, 20);
			this.contactAddressCityTextBox.TabIndex = 22;
			this.contactAddressCityTextBox.TextChanged += new System.EventHandler(this.UpdateAddressAddButtonEnableness);
			// 
			// labelAddress
			// 
			this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(9, 281);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(39, 13);
			this.labelAddress.TabIndex = 21;
			this.labelAddress.Text = "Adress";
			// 
			// contactAddressRemoveButton
			// 
			this.contactAddressRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.contactAddressRemoveButton.Enabled = false;
			this.contactAddressRemoveButton.Location = new System.Drawing.Point(222, 349);
			this.contactAddressRemoveButton.Name = "contactAddressRemoveButton";
			this.contactAddressRemoveButton.Size = new System.Drawing.Size(25, 20);
			this.contactAddressRemoveButton.TabIndex = 20;
			this.contactAddressRemoveButton.Text = "-";
			this.contactAddressRemoveButton.UseVisualStyleBackColor = true;
			this.contactAddressRemoveButton.Click += new System.EventHandler(this.contactAddressRemoveButton_Click);
			// 
			// contactAddressAddButton
			// 
			this.contactAddressAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.contactAddressAddButton.Location = new System.Drawing.Point(191, 349);
			this.contactAddressAddButton.Name = "contactAddressAddButton";
			this.contactAddressAddButton.Size = new System.Drawing.Size(25, 20);
			this.contactAddressAddButton.TabIndex = 19;
			this.contactAddressAddButton.Text = "+";
			this.contactAddressAddButton.UseVisualStyleBackColor = true;
			this.contactAddressAddButton.Click += new System.EventHandler(this.contactAddressAddButton_Click);
			// 
			// contactAddressStreetTextBox
			// 
			this.contactAddressStreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactAddressStreetTextBox.Location = new System.Drawing.Point(74, 297);
			this.contactAddressStreetTextBox.MaxLength = 255;
			this.contactAddressStreetTextBox.Name = "contactAddressStreetTextBox";
			this.contactAddressStreetTextBox.Size = new System.Drawing.Size(173, 20);
			this.contactAddressStreetTextBox.TabIndex = 18;
			this.contactAddressStreetTextBox.TextChanged += new System.EventHandler(this.UpdateAddressAddButtonEnableness);
			// 
			// contactAddressListBox
			// 
			this.contactAddressListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactAddressListBox.FormattingEnabled = true;
			this.contactAddressListBox.Location = new System.Drawing.Point(9, 375);
			this.contactAddressListBox.Name = "contactAddressListBox";
			this.contactAddressListBox.Size = new System.Drawing.Size(238, 56);
			this.contactAddressListBox.Sorted = true;
			this.contactAddressListBox.TabIndex = 17;
			this.contactAddressListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckIfDeselect);
			this.contactAddressListBox.SelectedIndexChanged += new System.EventHandler(this.contactAddressListBox_SelectedIndexChanged);
			// 
			// labelTelephone
			// 
			this.labelTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTelephone.AutoSize = true;
			this.labelTelephone.Location = new System.Drawing.Point(9, 168);
			this.labelTelephone.Name = "labelTelephone";
			this.labelTelephone.Size = new System.Drawing.Size(101, 13);
			this.labelTelephone.TabIndex = 16;
			this.labelTelephone.Text = "Telephone numbers";
			// 
			// contactTelephoneRemoveButton
			// 
			this.contactTelephoneRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.contactTelephoneRemoveButton.Enabled = false;
			this.contactTelephoneRemoveButton.Location = new System.Drawing.Point(222, 183);
			this.contactTelephoneRemoveButton.Name = "contactTelephoneRemoveButton";
			this.contactTelephoneRemoveButton.Size = new System.Drawing.Size(25, 21);
			this.contactTelephoneRemoveButton.TabIndex = 15;
			this.contactTelephoneRemoveButton.Text = "-";
			this.contactTelephoneRemoveButton.UseVisualStyleBackColor = true;
			this.contactTelephoneRemoveButton.Click += new System.EventHandler(this.contactTelephoneRemoveButton_Click);
			// 
			// contactTelephoneAddButton
			// 
			this.contactTelephoneAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.contactTelephoneAddButton.Location = new System.Drawing.Point(191, 183);
			this.contactTelephoneAddButton.Name = "contactTelephoneAddButton";
			this.contactTelephoneAddButton.Size = new System.Drawing.Size(25, 21);
			this.contactTelephoneAddButton.TabIndex = 14;
			this.contactTelephoneAddButton.Text = "+";
			this.contactTelephoneAddButton.UseVisualStyleBackColor = true;
			this.contactTelephoneAddButton.Click += new System.EventHandler(this.contactTelephoneAddButton_Click);
			// 
			// contactTelephoneTextBox
			// 
			this.contactTelephoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactTelephoneTextBox.Location = new System.Drawing.Point(9, 183);
			this.contactTelephoneTextBox.MaxLength = 255;
			this.contactTelephoneTextBox.Name = "contactTelephoneTextBox";
			this.contactTelephoneTextBox.Size = new System.Drawing.Size(176, 20);
			this.contactTelephoneTextBox.TabIndex = 13;
			this.contactTelephoneTextBox.TextChanged += new System.EventHandler(this.contactTelephoneTextBox_TextChanged);
			this.contactTelephoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_TelephoneNumber);
			// 
			// contactTelephoneListBox
			// 
			this.contactTelephoneListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactTelephoneListBox.FormattingEnabled = true;
			this.contactTelephoneListBox.Location = new System.Drawing.Point(9, 210);
			this.contactTelephoneListBox.Name = "contactTelephoneListBox";
			this.contactTelephoneListBox.Size = new System.Drawing.Size(238, 56);
			this.contactTelephoneListBox.Sorted = true;
			this.contactTelephoneListBox.TabIndex = 12;
			this.contactTelephoneListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckIfDeselect);
			this.contactTelephoneListBox.SelectedIndexChanged += new System.EventHandler(this.contactTelephoneListBox_SelectedIndexChanged);
			// 
			// TheGrandForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 443);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(530, 482);
			this.Name = "TheGrandForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.TheGrandForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxPersons;
		private System.Windows.Forms.Button contactCreateButton;
		private System.Windows.Forms.Button contactSaveButton;
		private System.Windows.Forms.Button contactDeleteButton;
		private System.Windows.Forms.Button buttonShowAll;
		private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox contactTypeComboBox;
		private System.Windows.Forms.TextBox contactNameTextBox;
		private System.Windows.Forms.TextBox contactEmailTextBox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox contactTelephoneListBox;
		private System.Windows.Forms.TextBox contactTelephoneTextBox;
		private System.Windows.Forms.Button contactTelephoneRemoveButton;
		private System.Windows.Forms.Button contactTelephoneAddButton;
		private System.Windows.Forms.Label labelTelephone;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.Button contactAddressRemoveButton;
		private System.Windows.Forms.Button contactAddressAddButton;
		private System.Windows.Forms.TextBox contactAddressStreetTextBox;
		private System.Windows.Forms.ListBox contactAddressListBox;
		private System.Windows.Forms.Button buttonOpenContact;
		private System.Windows.Forms.TextBox contactAddressPostCodeTextBox;
		private System.Windows.Forms.TextBox contactAddressCityTextBox;
		private System.Windows.Forms.Label labelAddressPostCode;
		private System.Windows.Forms.Label labelAddressCity;
		private System.Windows.Forms.Label labelAddressStreet;
	}
}

