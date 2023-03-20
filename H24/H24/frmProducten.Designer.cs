namespace H24
{
    partial class frmProducten
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
            System.Windows.Forms.Label productnummerLabel;
            System.Windows.Forms.Label leveranciersnummerLabel;
            System.Windows.Forms.Label productnaamLabel;
            System.Windows.Forms.Label prijsPerEenheidLabel;
            System.Windows.Forms.Label voorraadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducten));
            this.dtsProducten = new H24.dtsProducten();
            this.tblProductenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductenTableAdapter = new H24.dtsProductenTableAdapters.tblProductenTableAdapter();
            this.tableAdapterManager = new H24.dtsProductenTableAdapters.TableAdapterManager();
            this.tblProductenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.productnummerTextBox = new System.Windows.Forms.TextBox();
            this.leveranciersnummerTextBox = new System.Windows.Forms.TextBox();
            this.productnaamTextBox = new System.Windows.Forms.TextBox();
            this.prijsPerEenheidTextBox = new System.Windows.Forms.TextBox();
            this.voorraadTextBox = new System.Windows.Forms.TextBox();
            this.cbLeveranciers = new System.Windows.Forms.ComboBox();
            productnummerLabel = new System.Windows.Forms.Label();
            leveranciersnummerLabel = new System.Windows.Forms.Label();
            productnaamLabel = new System.Windows.Forms.Label();
            prijsPerEenheidLabel = new System.Windows.Forms.Label();
            voorraadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingNavigator)).BeginInit();
            this.tblProductenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // productnummerLabel
            // 
            productnummerLabel.AutoSize = true;
            productnummerLabel.Location = new System.Drawing.Point(81, 103);
            productnummerLabel.Name = "productnummerLabel";
            productnummerLabel.Size = new System.Drawing.Size(84, 13);
            productnummerLabel.TabIndex = 1;
            productnummerLabel.Text = "Productnummer:";
            // 
            // leveranciersnummerLabel
            // 
            leveranciersnummerLabel.AutoSize = true;
            leveranciersnummerLabel.Location = new System.Drawing.Point(81, 129);
            leveranciersnummerLabel.Name = "leveranciersnummerLabel";
            leveranciersnummerLabel.Size = new System.Drawing.Size(108, 13);
            leveranciersnummerLabel.TabIndex = 3;
            leveranciersnummerLabel.Text = "Leveranciersnummer:";
            // 
            // productnaamLabel
            // 
            productnaamLabel.AutoSize = true;
            productnaamLabel.Location = new System.Drawing.Point(81, 155);
            productnaamLabel.Name = "productnaamLabel";
            productnaamLabel.Size = new System.Drawing.Size(73, 13);
            productnaamLabel.TabIndex = 5;
            productnaamLabel.Text = "Productnaam:";
            // 
            // prijsPerEenheidLabel
            // 
            prijsPerEenheidLabel.AutoSize = true;
            prijsPerEenheidLabel.Location = new System.Drawing.Point(81, 181);
            prijsPerEenheidLabel.Name = "prijsPerEenheidLabel";
            prijsPerEenheidLabel.Size = new System.Drawing.Size(90, 13);
            prijsPerEenheidLabel.TabIndex = 7;
            prijsPerEenheidLabel.Text = "Prijs Per Eenheid:";
            // 
            // voorraadLabel
            // 
            voorraadLabel.AutoSize = true;
            voorraadLabel.Location = new System.Drawing.Point(81, 207);
            voorraadLabel.Name = "voorraadLabel";
            voorraadLabel.Size = new System.Drawing.Size(53, 13);
            voorraadLabel.TabIndex = 9;
            voorraadLabel.Text = "Voorraad:";
            // 
            // dtsProducten
            // 
            this.dtsProducten.DataSetName = "dtsProducten";
            this.dtsProducten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductenBindingSource
            // 
            this.tblProductenBindingSource.DataMember = "tblProducten";
            this.tblProductenBindingSource.DataSource = this.dtsProducten;
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
            this.tableAdapterManager.UpdateOrder = H24.dtsProductenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblProductenBindingNavigator
            // 
            this.tblProductenBindingNavigator.AddNewItem = null;
            this.tblProductenBindingNavigator.BindingSource = this.tblProductenBindingSource;
            this.tblProductenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProductenBindingNavigator.DeleteItem = null;
            this.tblProductenBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblProductenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.tblProductenBindingNavigator.Location = new System.Drawing.Point(0, 425);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // productnummerTextBox
            // 
            this.productnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductenBindingSource, "Productnummer", true));
            this.productnummerTextBox.Location = new System.Drawing.Point(195, 100);
            this.productnummerTextBox.Name = "productnummerTextBox";
            this.productnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.productnummerTextBox.TabIndex = 2;
            // 
            // leveranciersnummerTextBox
            // 
            this.leveranciersnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductenBindingSource, "Leveranciersnummer", true));
            this.leveranciersnummerTextBox.Location = new System.Drawing.Point(195, 126);
            this.leveranciersnummerTextBox.Name = "leveranciersnummerTextBox";
            this.leveranciersnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.leveranciersnummerTextBox.TabIndex = 4;
            // 
            // productnaamTextBox
            // 
            this.productnaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductenBindingSource, "Productnaam", true));
            this.productnaamTextBox.Location = new System.Drawing.Point(195, 152);
            this.productnaamTextBox.Name = "productnaamTextBox";
            this.productnaamTextBox.Size = new System.Drawing.Size(100, 20);
            this.productnaamTextBox.TabIndex = 6;
            // 
            // prijsPerEenheidTextBox
            // 
            this.prijsPerEenheidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductenBindingSource, "PrijsPerEenheid", true));
            this.prijsPerEenheidTextBox.Location = new System.Drawing.Point(195, 178);
            this.prijsPerEenheidTextBox.Name = "prijsPerEenheidTextBox";
            this.prijsPerEenheidTextBox.Size = new System.Drawing.Size(100, 20);
            this.prijsPerEenheidTextBox.TabIndex = 8;
            // 
            // voorraadTextBox
            // 
            this.voorraadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductenBindingSource, "Voorraad", true));
            this.voorraadTextBox.Location = new System.Drawing.Point(195, 204);
            this.voorraadTextBox.Name = "voorraadTextBox";
            this.voorraadTextBox.Size = new System.Drawing.Size(100, 20);
            this.voorraadTextBox.TabIndex = 10;
            // 
            // cbLeveranciers
            // 
            this.cbLeveranciers.DataSource = this.dtsProducten;
            this.cbLeveranciers.DisplayMember = "tblLeveranciers.Bedrijf";
            this.cbLeveranciers.FormattingEnabled = true;
            this.cbLeveranciers.Location = new System.Drawing.Point(33, 12);
            this.cbLeveranciers.Name = "cbLeveranciers";
            this.cbLeveranciers.Size = new System.Drawing.Size(121, 21);
            this.cbLeveranciers.TabIndex = 11;
            this.cbLeveranciers.ValueMember = "tblLeveranciers.Leveranciersnummer";
            this.cbLeveranciers.SelectedIndexChanged += new System.EventHandler(this.cbLeveranciers_SelectedIndexChanged);
            // 
            // frmProducten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLeveranciers);
            this.Controls.Add(productnummerLabel);
            this.Controls.Add(this.productnummerTextBox);
            this.Controls.Add(leveranciersnummerLabel);
            this.Controls.Add(this.leveranciersnummerTextBox);
            this.Controls.Add(productnaamLabel);
            this.Controls.Add(this.productnaamTextBox);
            this.Controls.Add(prijsPerEenheidLabel);
            this.Controls.Add(this.prijsPerEenheidTextBox);
            this.Controls.Add(voorraadLabel);
            this.Controls.Add(this.voorraadTextBox);
            this.Controls.Add(this.tblProductenBindingNavigator);
            this.Name = "frmProducten";
            this.Text = "Producten";
            this.Load += new System.EventHandler(this.frmProducten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingNavigator)).EndInit();
            this.tblProductenBindingNavigator.ResumeLayout(false);
            this.tblProductenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsProducten dtsProducten;
        private System.Windows.Forms.BindingSource tblProductenBindingSource;
        private dtsProductenTableAdapters.tblProductenTableAdapter tblProductenTableAdapter;
        private dtsProductenTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProductenBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TextBox productnummerTextBox;
        private System.Windows.Forms.TextBox leveranciersnummerTextBox;
        private System.Windows.Forms.TextBox productnaamTextBox;
        private System.Windows.Forms.TextBox prijsPerEenheidTextBox;
        private System.Windows.Forms.TextBox voorraadTextBox;
        private System.Windows.Forms.ComboBox cbLeveranciers;
    }
}

