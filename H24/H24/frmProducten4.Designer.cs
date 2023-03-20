namespace H24
{
    partial class frmProducten4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducten4));
            this.dtsProducten4 = new H24.dtsProducten4();
            this.tblProductenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductenTableAdapter = new H24.dtsProducten4TableAdapters.tblProductenTableAdapter();
            this.tableAdapterManager = new H24.dtsProducten4TableAdapters.TableAdapterManager();
            this.tblProductenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblProductenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblProductenDataGridView = new System.Windows.Forms.DataGridView();
            this.productnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijsPerEenheidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voorraadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waardeInventarisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducten4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingNavigator)).BeginInit();
            this.tblProductenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsProducten4
            // 
            this.dtsProducten4.DataSetName = "dtsProducten4";
            this.dtsProducten4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductenBindingSource
            // 
            this.tblProductenBindingSource.DataMember = "tblProducten";
            this.tblProductenBindingSource.DataSource = this.dtsProducten4;
            // 
            // tblProductenTableAdapter
            // 
            this.tblProductenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblProductenTableAdapter = this.tblProductenTableAdapter;
            this.tableAdapterManager.UpdateOrder = H24.dtsProducten4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblProductenBindingNavigator
            // 
            this.tblProductenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblProductenBindingNavigator.BindingSource = this.tblProductenBindingSource;
            this.tblProductenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProductenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblProductenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblProductenBindingNavigatorSaveItem});
            this.tblProductenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblProductenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblProductenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblProductenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblProductenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblProductenBindingNavigator.Name = "tblProductenBindingNavigator";
            this.tblProductenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblProductenBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblProductenBindingNavigator.TabIndex = 0;
            this.tblProductenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblProductenBindingNavigatorSaveItem
            // 
            this.tblProductenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblProductenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblProductenBindingNavigatorSaveItem.Image")));
            this.tblProductenBindingNavigatorSaveItem.Name = "tblProductenBindingNavigatorSaveItem";
            this.tblProductenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblProductenBindingNavigatorSaveItem.Text = "Save Data";
            this.tblProductenBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblProductenBindingNavigatorSaveItem_Click);
            // 
            // tblProductenDataGridView
            // 
            this.tblProductenDataGridView.AutoGenerateColumns = false;
            this.tblProductenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnummerDataGridViewTextBoxColumn,
            this.productnaamDataGridViewTextBoxColumn,
            this.prijsPerEenheidDataGridViewTextBoxColumn,
            this.voorraadDataGridViewTextBoxColumn,
            this.waardeInventarisDataGridViewTextBoxColumn});
            this.tblProductenDataGridView.DataSource = this.tblProductenBindingSource;
            this.tblProductenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProductenDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tblProductenDataGridView.Name = "tblProductenDataGridView";
            this.tblProductenDataGridView.Size = new System.Drawing.Size(800, 425);
            this.tblProductenDataGridView.TabIndex = 1;
            // 
            // productnummerDataGridViewTextBoxColumn
            // 
            this.productnummerDataGridViewTextBoxColumn.DataPropertyName = "Productnummer";
            this.productnummerDataGridViewTextBoxColumn.HeaderText = "Productnummer";
            this.productnummerDataGridViewTextBoxColumn.Name = "productnummerDataGridViewTextBoxColumn";
            this.productnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnaamDataGridViewTextBoxColumn
            // 
            this.productnaamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productnaamDataGridViewTextBoxColumn.DataPropertyName = "Productnaam";
            this.productnaamDataGridViewTextBoxColumn.HeaderText = "Productnaam";
            this.productnaamDataGridViewTextBoxColumn.Name = "productnaamDataGridViewTextBoxColumn";
            // 
            // prijsPerEenheidDataGridViewTextBoxColumn
            // 
            this.prijsPerEenheidDataGridViewTextBoxColumn.DataPropertyName = "PrijsPerEenheid";
            this.prijsPerEenheidDataGridViewTextBoxColumn.HeaderText = "PrijsPerEenheid";
            this.prijsPerEenheidDataGridViewTextBoxColumn.Name = "prijsPerEenheidDataGridViewTextBoxColumn";
            // 
            // voorraadDataGridViewTextBoxColumn
            // 
            this.voorraadDataGridViewTextBoxColumn.DataPropertyName = "Voorraad";
            this.voorraadDataGridViewTextBoxColumn.HeaderText = "Voorraad";
            this.voorraadDataGridViewTextBoxColumn.Name = "voorraadDataGridViewTextBoxColumn";
            // 
            // waardeInventarisDataGridViewTextBoxColumn
            // 
            this.waardeInventarisDataGridViewTextBoxColumn.DataPropertyName = "WaardeInventaris";
            this.waardeInventarisDataGridViewTextBoxColumn.HeaderText = "WaardeInventaris";
            this.waardeInventarisDataGridViewTextBoxColumn.Name = "waardeInventarisDataGridViewTextBoxColumn";
            this.waardeInventarisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmProducten4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblProductenDataGridView);
            this.Controls.Add(this.tblProductenBindingNavigator);
            this.Name = "frmProducten4";
            this.Text = "Producten";
            this.Load += new System.EventHandler(this.frmProducten4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducten4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingNavigator)).EndInit();
            this.tblProductenBindingNavigator.ResumeLayout(false);
            this.tblProductenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsProducten4 dtsProducten4;
        private System.Windows.Forms.BindingSource tblProductenBindingSource;
        private dtsProducten4TableAdapters.tblProductenTableAdapter tblProductenTableAdapter;
        private dtsProducten4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProductenBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblProductenBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblProductenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijsPerEenheidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voorraadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waardeInventarisDataGridViewTextBoxColumn;
    }
}