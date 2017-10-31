namespace Adressbok
{
	partial class Form1
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
			this.myDataGridView = new System.Windows.Forms.DataGridView();
			this.kontaktBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.adressbok2DataSet = new Adressbok.Adressbok2DataSet();
			this.kontaktTableAdapter = new Adressbok.Adressbok2DataSetTableAdapters.KontaktTableAdapter();
			this.comboKontaktTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kontaktidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kontaktnamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kontakttypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kontakttypDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.epostadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressgataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresspostnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresspostortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kontaktBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adressbok2DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboKontaktTypBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// myDataGridView
			// 
			this.myDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myDataGridView.AutoGenerateColumns = false;
			this.myDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kontaktidDataGridViewTextBoxColumn,
            this.kontaktnamnDataGridViewTextBoxColumn,
            this.kontakttypDataGridViewTextBoxColumn,
            this.kontakttypDataGridViewComboBoxColumn,
            this.epostadressDataGridViewTextBoxColumn,
            this.telefonnrDataGridViewTextBoxColumn,
            this.adressgataDataGridViewTextBoxColumn,
            this.adresspostnrDataGridViewTextBoxColumn,
            this.adresspostortDataGridViewTextBoxColumn});
			this.myDataGridView.DataSource = this.kontaktBindingSource;
			this.myDataGridView.Location = new System.Drawing.Point(12, 108);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.Size = new System.Drawing.Size(662, 238);
			this.myDataGridView.TabIndex = 0;
			this.myDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellValueChanged);
			this.myDataGridView.CurrentCellChanged += new System.EventHandler(this.myDataGridView_CurrentCellChanged);
			this.myDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.myDataGridView_DataError);
			// 
			// kontaktBindingSource
			// 
			this.kontaktBindingSource.DataMember = "Kontakt";
			this.kontaktBindingSource.DataSource = this.adressbok2DataSet;
			// 
			// adressbok2DataSet
			// 
			this.adressbok2DataSet.DataSetName = "Adressbok2DataSet";
			this.adressbok2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// kontaktTableAdapter
			// 
			this.kontaktTableAdapter.ClearBeforeFill = true;
			// 
			// comboKontaktTypBindingSource
			// 
			this.comboKontaktTypBindingSource.DataSource = typeof(Adressbok.Models.ComboKontaktTyp);
			// 
			// kontaktidDataGridViewTextBoxColumn
			// 
			this.kontaktidDataGridViewTextBoxColumn.DataPropertyName = "kontakt_id";
			this.kontaktidDataGridViewTextBoxColumn.HeaderText = "ID";
			this.kontaktidDataGridViewTextBoxColumn.MaxInputLength = 255;
			this.kontaktidDataGridViewTextBoxColumn.Name = "kontaktidDataGridViewTextBoxColumn";
			this.kontaktidDataGridViewTextBoxColumn.ReadOnly = true;
			this.kontaktidDataGridViewTextBoxColumn.Visible = false;
			// 
			// kontaktnamnDataGridViewTextBoxColumn
			// 
			this.kontaktnamnDataGridViewTextBoxColumn.DataPropertyName = "kontakt_namn";
			this.kontaktnamnDataGridViewTextBoxColumn.HeaderText = "Namn";
			this.kontaktnamnDataGridViewTextBoxColumn.MaxInputLength = 255;
			this.kontaktnamnDataGridViewTextBoxColumn.Name = "kontaktnamnDataGridViewTextBoxColumn";
			// 
			// kontakttypDataGridViewTextBoxColumn
			// 
			this.kontakttypDataGridViewTextBoxColumn.DataPropertyName = "kontakt_typ";
			this.kontakttypDataGridViewTextBoxColumn.HeaderText = "Actual Typ";
			this.kontakttypDataGridViewTextBoxColumn.MaxInputLength = 1;
			this.kontakttypDataGridViewTextBoxColumn.Name = "kontakttypDataGridViewTextBoxColumn";
			this.kontakttypDataGridViewTextBoxColumn.ReadOnly = true;
			this.kontakttypDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.kontakttypDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// kontakttypDataGridViewComboBoxColumn
			// 
			this.kontakttypDataGridViewComboBoxColumn.HeaderText = "Typ";
			this.kontakttypDataGridViewComboBoxColumn.Name = "kontakttypDataGridViewComboBoxColumn";
			this.kontakttypDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.kontakttypDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// epostadressDataGridViewTextBoxColumn
			// 
			this.epostadressDataGridViewTextBoxColumn.DataPropertyName = "epost_adress";
			this.epostadressDataGridViewTextBoxColumn.HeaderText = "Epost";
			this.epostadressDataGridViewTextBoxColumn.MaxInputLength = 255;
			this.epostadressDataGridViewTextBoxColumn.Name = "epostadressDataGridViewTextBoxColumn";
			// 
			// telefonnrDataGridViewTextBoxColumn
			// 
			this.telefonnrDataGridViewTextBoxColumn.DataPropertyName = "telefon_nr";
			this.telefonnrDataGridViewTextBoxColumn.HeaderText = "Telefon";
			this.telefonnrDataGridViewTextBoxColumn.MaxInputLength = 255;
			this.telefonnrDataGridViewTextBoxColumn.Name = "telefonnrDataGridViewTextBoxColumn";
			// 
			// adressgataDataGridViewTextBoxColumn
			// 
			this.adressgataDataGridViewTextBoxColumn.DataPropertyName = "adress_gata";
			this.adressgataDataGridViewTextBoxColumn.HeaderText = "Gata";
			this.adressgataDataGridViewTextBoxColumn.MaxInputLength = 255;
			this.adressgataDataGridViewTextBoxColumn.Name = "adressgataDataGridViewTextBoxColumn";
			// 
			// adresspostnrDataGridViewTextBoxColumn
			// 
			this.adresspostnrDataGridViewTextBoxColumn.DataPropertyName = "adress_post_nr";
			this.adresspostnrDataGridViewTextBoxColumn.HeaderText = "Post nummer";
			this.adresspostnrDataGridViewTextBoxColumn.MaxInputLength = 6;
			this.adresspostnrDataGridViewTextBoxColumn.Name = "adresspostnrDataGridViewTextBoxColumn";
			// 
			// adresspostortDataGridViewTextBoxColumn
			// 
			this.adresspostortDataGridViewTextBoxColumn.DataPropertyName = "adress_post_ort";
			this.adresspostortDataGridViewTextBoxColumn.HeaderText = "Post ort";
			this.adresspostortDataGridViewTextBoxColumn.MaxInputLength = 255;
			this.adresspostortDataGridViewTextBoxColumn.Name = "adresspostortDataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 358);
			this.Controls.Add(this.myDataGridView);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kontaktBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adressbok2DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboKontaktTypBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView myDataGridView;
		private Adressbok2DataSet adressbok2DataSet;
		private System.Windows.Forms.BindingSource kontaktBindingSource;
		private Adressbok2DataSetTableAdapters.KontaktTableAdapter kontaktTableAdapter;
		private System.Windows.Forms.BindingSource comboKontaktTypBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn kontaktidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kontaktnamnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kontakttypDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn kontakttypDataGridViewComboBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn epostadressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonnrDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adressgataDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresspostnrDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresspostortDataGridViewTextBoxColumn;
	}
}

