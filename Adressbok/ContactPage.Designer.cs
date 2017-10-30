namespace Adressbok
{
	partial class ContactPage
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
			this.components = new System.ComponentModel.Container();
			this.dataGridViewTelephone = new System.Windows.Forms.DataGridView();
			this.telefon_nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefon_kontakt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuTables = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridViewEmail = new System.Windows.Forms.DataGridView();
			this.epost_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.epost_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.epost_kontakt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.inputName = new System.Windows.Forms.TextBox();
			this.inputType = new System.Windows.Forms.ComboBox();
			this.comboKontaktTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewAddress = new System.Windows.Forms.DataGridView();
			this.adress_gata = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.post_nr = new System.Windows.Forms.DataGridViewButtonColumn();
			this.labelAddress = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelTelephone = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelephone)).BeginInit();
			this.contextMenuTables.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboKontaktTypBindingSource)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTelephone
			// 
			this.dataGridViewTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTelephone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTelephone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.telefon_nr,
            this.telefon_id,
            this.telefon_kontakt_id});
			this.dataGridViewTelephone.ContextMenuStrip = this.contextMenuTables;
			this.dataGridViewTelephone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTelephone.Location = new System.Drawing.Point(3, 203);
			this.dataGridViewTelephone.MultiSelect = false;
			this.dataGridViewTelephone.Name = "dataGridViewTelephone";
			this.dataGridViewTelephone.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewTelephone.Size = new System.Drawing.Size(325, 43);
			this.dataGridViewTelephone.TabIndex = 10;
			// 
			// telefon_nr
			// 
			this.telefon_nr.DataPropertyName = "TelefonNummer";
			this.telefon_nr.HeaderText = "Telephone";
			this.telefon_nr.MaxInputLength = 255;
			this.telefon_nr.Name = "telefon_nr";
			// 
			// telefon_id
			// 
			this.telefon_id.DataPropertyName = "TelefonID";
			this.telefon_id.HeaderText = "Telefon ID";
			this.telefon_id.Name = "telefon_id";
			this.telefon_id.Visible = false;
			// 
			// telefon_kontakt_id
			// 
			this.telefon_kontakt_id.DataPropertyName = "KontaktID";
			this.telefon_kontakt_id.HeaderText = "Kontakt ID";
			this.telefon_kontakt_id.Name = "telefon_kontakt_id";
			this.telefon_kontakt_id.Visible = false;
			// 
			// contextMenuTables
			// 
			this.contextMenuTables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
			this.contextMenuTables.Name = "contextMenuTables";
			this.contextMenuTables.Size = new System.Drawing.Size(153, 70);
			// 
			// addRowToolStripMenuItem
			// 
			this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
			this.addRowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addRowToolStripMenuItem.Text = "Add row";
			this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteRowToolStripMenuItem.Text = "Delete row";
			this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
			// 
			// dataGridViewEmail
			// 
			this.dataGridViewEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmail.ColumnHeadersVisible = false;
			this.dataGridViewEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.epost_adress,
            this.epost_id,
            this.epost_kontakt_id});
			this.dataGridViewEmail.ContextMenuStrip = this.contextMenuTables;
			this.dataGridViewEmail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewEmail.Location = new System.Drawing.Point(3, 159);
			this.dataGridViewEmail.MultiSelect = false;
			this.dataGridViewEmail.Name = "dataGridViewEmail";
			this.dataGridViewEmail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewEmail.Size = new System.Drawing.Size(325, 25);
			this.dataGridViewEmail.TabIndex = 11;
			this.dataGridViewEmail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ResizeGridViewToFullHeight);
			this.dataGridViewEmail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ResizeGridViewToFullHeight);
			// 
			// epost_adress
			// 
			this.epost_adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.epost_adress.DataPropertyName = "EpostAdress";
			this.epost_adress.HeaderText = "Email";
			this.epost_adress.MaxInputLength = 255;
			this.epost_adress.Name = "epost_adress";
			// 
			// epost_id
			// 
			this.epost_id.DataPropertyName = "EpostID";
			this.epost_id.HeaderText = "Email ID";
			this.epost_id.Name = "epost_id";
			this.epost_id.Visible = false;
			// 
			// epost_kontakt_id
			// 
			this.epost_kontakt_id.DataPropertyName = "KontaktID";
			this.epost_kontakt_id.HeaderText = "Kontakt ID";
			this.epost_kontakt_id.Name = "epost_kontakt_id";
			this.epost_kontakt_id.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::Adressbok.Properties.Resources.pp;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name";
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(374, 305);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// inputName
			// 
			this.inputName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputName.Location = new System.Drawing.Point(3, 16);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(325, 20);
			this.inputName.TabIndex = 4;
			// 
			// inputType
			// 
			this.inputType.DataSource = this.comboKontaktTypBindingSource;
			this.inputType.DisplayMember = "Text";
			this.inputType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputType.FormattingEnabled = true;
			this.inputType.Location = new System.Drawing.Point(3, 55);
			this.inputType.Name = "inputType";
			this.inputType.Size = new System.Drawing.Size(325, 21);
			this.inputType.TabIndex = 5;
			this.inputType.ValueMember = "Typ";
			// 
			// comboKontaktTypBindingSource
			// 
			this.comboKontaktTypBindingSource.DataSource = typeof(Adressbok.ContactPage.ComboKontaktTyp);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(190, 0);
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.inputType, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.inputName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewAddress, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelAddress, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelEmail, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelTelephone, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewTelephone, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewEmail, 0, 7);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 284);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Contact type";
			// 
			// dataGridViewAddress
			// 
			this.dataGridViewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adress_gata,
            this.post_nr});
			this.dataGridViewAddress.ContextMenuStrip = this.contextMenuTables;
			this.dataGridViewAddress.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewAddress.Location = new System.Drawing.Point(3, 95);
			this.dataGridViewAddress.MultiSelect = false;
			this.dataGridViewAddress.Name = "dataGridViewAddress";
			this.dataGridViewAddress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewAddress.Size = new System.Drawing.Size(325, 45);
			this.dataGridViewAddress.TabIndex = 6;
			this.dataGridViewAddress.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ResizeGridViewToFullHeight);
			this.dataGridViewAddress.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ResizeGridViewToFullHeight);
			// 
			// adress_gata
			// 
			this.adress_gata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.adress_gata.HeaderText = "Street";
			this.adress_gata.MaxInputLength = 255;
			this.adress_gata.Name = "adress_gata";
			this.adress_gata.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// post_nr
			// 
			this.post_nr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.post_nr.HeaderText = "Post code";
			this.post_nr.Name = "post_nr";
			this.post_nr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.post_nr.Text = "";
			this.post_nr.Width = 61;
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(3, 79);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(45, 13);
			this.labelAddress.TabIndex = 7;
			this.labelAddress.Text = "Address";
			// 
			// labelEmail
			// 
			this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(3, 143);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(325, 13);
			this.labelEmail.TabIndex = 8;
			this.labelEmail.Text = "Email";
			// 
			// labelTelephone
			// 
			this.labelTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTelephone.AutoSize = true;
			this.labelTelephone.Location = new System.Drawing.Point(3, 187);
			this.labelTelephone.Name = "labelTelephone";
			this.labelTelephone.Size = new System.Drawing.Size(325, 13);
			this.labelTelephone.TabIndex = 9;
			this.labelTelephone.Text = "Telephone";
			// 
			// ContactPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 340);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.pictureBox1);
			this.MinimumSize = new System.Drawing.Size(409, 195);
			this.Name = "ContactPage";
			this.Text = "ContactPage";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelephone)).EndInit();
			this.contextMenuTables.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboKontaktTypBindingSource)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.ComboBox inputType;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.DataGridView dataGridViewAddress;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelTelephone;
		private System.Windows.Forms.DataGridViewTextBoxColumn adress_gata;
		private System.Windows.Forms.DataGridViewButtonColumn post_nr;
		private System.Windows.Forms.DataGridView dataGridViewTelephone;
		private System.Windows.Forms.DataGridView dataGridViewEmail;
		private System.Windows.Forms.ContextMenuStrip contextMenuTables;
		private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefon_nr;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefon_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefon_kontakt_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn epost_adress;
		private System.Windows.Forms.DataGridViewTextBoxColumn epost_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn epost_kontakt_id;
		private System.Windows.Forms.BindingSource comboKontaktTypBindingSource;
	}
}