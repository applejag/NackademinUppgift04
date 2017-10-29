namespace Adressbok
{
	partial class ContactList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.personerGridView = new System.Windows.Forms.DataGridView();
			this.kontakt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kontakt_namn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.kontakt_typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.personerGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// personerGridView
			// 
			this.personerGridView.AllowUserToAddRows = false;
			this.personerGridView.AllowUserToDeleteRows = false;
			this.personerGridView.AllowUserToResizeRows = false;
			this.personerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.personerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.personerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kontakt_id,
            this.kontakt_namn,
            this.kontakt_typ});
			this.personerGridView.ImeMode = System.Windows.Forms.ImeMode.On;
			this.personerGridView.Location = new System.Drawing.Point(12, 115);
			this.personerGridView.MultiSelect = false;
			this.personerGridView.Name = "personerGridView";
			this.personerGridView.ReadOnly = true;
			this.personerGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.personerGridView.Size = new System.Drawing.Size(798, 267);
			this.personerGridView.TabIndex = 0;
			this.personerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personerGridView_CellContentClick);
			// 
			// kontakt_id
			// 
			this.kontakt_id.DataPropertyName = "kontakt_id";
			this.kontakt_id.HeaderText = "ID";
			this.kontakt_id.Name = "kontakt_id";
			this.kontakt_id.ReadOnly = true;
			this.kontakt_id.Visible = false;
			// 
			// kontakt_namn
			// 
			this.kontakt_namn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.kontakt_namn.DataPropertyName = "kontakt_namn";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.kontakt_namn.DefaultCellStyle = dataGridViewCellStyle1;
			this.kontakt_namn.HeaderText = "Namn";
			this.kontakt_namn.Name = "kontakt_namn";
			this.kontakt_namn.ReadOnly = true;
			this.kontakt_namn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.kontakt_namn.ToolTipText = "Kontaktpersonens namn";
			// 
			// kontakt_typ
			// 
			this.kontakt_typ.DataPropertyName = "kontakt_typ";
			this.kontakt_typ.HeaderText = "Typ";
			this.kontakt_typ.MaxInputLength = 1;
			this.kontakt_typ.Name = "kontakt_typ";
			this.kontakt_typ.ReadOnly = true;
			this.kontakt_typ.Visible = false;
			// 
			// ContactList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 394);
			this.Controls.Add(this.personerGridView);
			this.Name = "ContactList";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.ContactList_Load);
			((System.ComponentModel.ISupportInitialize)(this.personerGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView personerGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn kontakt_id;
		private System.Windows.Forms.DataGridViewButtonColumn kontakt_namn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kontakt_typ;
	}
}

