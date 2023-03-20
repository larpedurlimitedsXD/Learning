namespace H24
{
    partial class frmProducten2
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
            this.tblProductenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsProducten2 = new H24.dtsProducten2();
            this.tblProductenTableAdapter = new H24.dtsProducten2TableAdapters.tblProductenTableAdapter();
            this.tableAdapterManager = new H24.dtsProducten2TableAdapters.TableAdapterManager();
            this.cbLeveranciers = new System.Windows.Forms.ComboBox();
            this.lblLeverancier = new System.Windows.Forms.Label();
            this.lblAantalTekst = new System.Windows.Forms.Label();
            this.lblAantalWaarde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducten2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProductenDataGridView
            // 
            this.tblProductenDataGridView.AutoGenerateColumns = false;
            this.tblProductenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tblProductenDataGridView.DataSource = this.tblProductenBindingSource;
            this.tblProductenDataGridView.Location = new System.Drawing.Point(12, 137);
            this.tblProductenDataGridView.Name = "tblProductenDataGridView";
            this.tblProductenDataGridView.Size = new System.Drawing.Size(597, 220);
            this.tblProductenDataGridView.TabIndex = 1;
            this.tblProductenDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProductenDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Productnummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Productnummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Leveranciersnummer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Leveranciersnummer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Productnaam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Productnaam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrijsPerEenheid";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrijsPerEenheid";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Voorraad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Voorraad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tblProductenBindingSource
            // 
            this.tblProductenBindingSource.DataMember = "tblProducten";
            this.tblProductenBindingSource.DataSource = this.dtsProducten2;
            // 
            // dtsProducten2
            // 
            this.dtsProducten2.DataSetName = "dtsProducten2";
            this.dtsProducten2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductenTableAdapter
            // 
            this.tblProductenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblLeveranciersTableAdapter = null;
            this.tableAdapterManager.tblProductenTableAdapter = this.tblProductenTableAdapter;
            this.tableAdapterManager.UpdateOrder = H24.dtsProducten2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbLeveranciers
            // 
            this.cbLeveranciers.DataSource = this.dtsProducten2;
            this.cbLeveranciers.DisplayMember = "tblLeveranciers.Bedrijf";
            this.cbLeveranciers.FormattingEnabled = true;
            this.cbLeveranciers.Location = new System.Drawing.Point(244, 12);
            this.cbLeveranciers.Name = "cbLeveranciers";
            this.cbLeveranciers.Size = new System.Drawing.Size(121, 21);
            this.cbLeveranciers.TabIndex = 2;
            this.cbLeveranciers.ValueMember = "tblLeveranciers.Leveranciersnummer";
            this.cbLeveranciers.SelectedIndexChanged += new System.EventHandler(this.cbLeveranciers_SelectedIndexChanged);
            // 
            // lblLeverancier
            // 
            this.lblLeverancier.AutoSize = true;
            this.lblLeverancier.Location = new System.Drawing.Point(12, 15);
            this.lblLeverancier.Name = "lblLeverancier";
            this.lblLeverancier.Size = new System.Drawing.Size(66, 13);
            this.lblLeverancier.TabIndex = 3;
            this.lblLeverancier.Text = "Leverancier:";
            // 
            // lblAantalTekst
            // 
            this.lblAantalTekst.AutoSize = true;
            this.lblAantalTekst.Location = new System.Drawing.Point(15, 48);
            this.lblAantalTekst.Name = "lblAantalTekst";
            this.lblAantalTekst.Size = new System.Drawing.Size(94, 13);
            this.lblAantalTekst.TabIndex = 4;
            this.lblAantalTekst.Text = "Aantal producten: ";
            // 
            // lblAantalWaarde
            // 
            this.lblAantalWaarde.AutoSize = true;
            this.lblAantalWaarde.Location = new System.Drawing.Point(244, 48);
            this.lblAantalWaarde.Name = "lblAantalWaarde";
            this.lblAantalWaarde.Size = new System.Drawing.Size(36, 13);
            this.lblAantalWaarde.TabIndex = 5;
            this.lblAantalWaarde.Text = "aantal";
            // 
            // frmProducten2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAantalWaarde);
            this.Controls.Add(this.lblAantalTekst);
            this.Controls.Add(this.lblLeverancier);
            this.Controls.Add(this.cbLeveranciers);
            this.Controls.Add(this.tblProductenDataGridView);
            this.Name = "frmProducten2";
            this.Text = "Producten2";
            this.Load += new System.EventHandler(this.frmProducten2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducten2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsProducten2 dtsProducten2;
        private System.Windows.Forms.BindingSource tblProductenBindingSource;
        private dtsProducten2TableAdapters.tblProductenTableAdapter tblProductenTableAdapter;
        private dtsProducten2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblProductenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbLeveranciers;
        private System.Windows.Forms.Label lblLeverancier;
        private System.Windows.Forms.Label lblAantalTekst;
        private System.Windows.Forms.Label lblAantalWaarde;
    }
}