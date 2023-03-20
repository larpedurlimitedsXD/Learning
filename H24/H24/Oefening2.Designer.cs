namespace H24
{
    partial class Oefening2
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
            System.Windows.Forms.Label klantnummerLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label postnrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oefening2));
            this.dtsOefening1 = new H24.dtsOefening1();
            this.tblKlantenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKlantenTableAdapter = new H24.dtsOefening1TableAdapters.tblKlantenTableAdapter();
            this.tableAdapterManager = new H24.dtsOefening1TableAdapters.TableAdapterManager();
            this.tblKlantenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblKlantenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klantnummerTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.postnrTextBox = new System.Windows.Forms.TextBox();
            this.lblZoek = new System.Windows.Forms.Label();
            this.cbNaam = new System.Windows.Forms.ComboBox();
            klantnummerLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            postnrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsOefening1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingNavigator)).BeginInit();
            this.tblKlantenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // klantnummerLabel
            // 
            klantnummerLabel.AutoSize = true;
            klantnummerLabel.Location = new System.Drawing.Point(98, 95);
            klantnummerLabel.Name = "klantnummerLabel";
            klantnummerLabel.Size = new System.Drawing.Size(71, 13);
            klantnummerLabel.TabIndex = 1;
            klantnummerLabel.Text = "Klantnummer:";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(98, 121);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // straatLabel
            // 
            straatLabel.AutoSize = true;
            straatLabel.Location = new System.Drawing.Point(98, 147);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(38, 13);
            straatLabel.TabIndex = 5;
            straatLabel.Text = "Straat:";
            // 
            // postnrLabel
            // 
            postnrLabel.AutoSize = true;
            postnrLabel.Location = new System.Drawing.Point(98, 173);
            postnrLabel.Name = "postnrLabel";
            postnrLabel.Size = new System.Drawing.Size(40, 13);
            postnrLabel.TabIndex = 7;
            postnrLabel.Text = "Postnr:";
            // 
            // dtsOefening1
            // 
            this.dtsOefening1.DataSetName = "dtsOefening1";
            this.dtsOefening1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKlantenBindingSource
            // 
            this.tblKlantenBindingSource.DataMember = "tblKlanten";
            this.tblKlantenBindingSource.DataSource = this.dtsOefening1;
            // 
            // tblKlantenTableAdapter
            // 
            this.tblKlantenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblKlantenTableAdapter = this.tblKlantenTableAdapter;
            this.tableAdapterManager.UpdateOrder = H24.dtsOefening1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblKlantenBindingNavigator
            // 
            this.tblKlantenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblKlantenBindingNavigator.BindingSource = this.tblKlantenBindingSource;
            this.tblKlantenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblKlantenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblKlantenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblKlantenBindingNavigatorSaveItem});
            this.tblKlantenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblKlantenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblKlantenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblKlantenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblKlantenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblKlantenBindingNavigator.Name = "tblKlantenBindingNavigator";
            this.tblKlantenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblKlantenBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblKlantenBindingNavigator.TabIndex = 0;
            this.tblKlantenBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblKlantenBindingNavigatorSaveItem
            // 
            this.tblKlantenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblKlantenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblKlantenBindingNavigatorSaveItem.Image")));
            this.tblKlantenBindingNavigatorSaveItem.Name = "tblKlantenBindingNavigatorSaveItem";
            this.tblKlantenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblKlantenBindingNavigatorSaveItem.Text = "Save Data";
            this.tblKlantenBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblKlantenBindingNavigatorSaveItem_Click);
            // 
            // klantnummerTextBox
            // 
            this.klantnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Klantnummer", true));
            this.klantnummerTextBox.Location = new System.Drawing.Point(175, 92);
            this.klantnummerTextBox.Name = "klantnummerTextBox";
            this.klantnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.klantnummerTextBox.TabIndex = 2;
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(175, 118);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(100, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // straatTextBox
            // 
            this.straatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Straat", true));
            this.straatTextBox.Location = new System.Drawing.Point(175, 144);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(100, 20);
            this.straatTextBox.TabIndex = 6;
            // 
            // postnrTextBox
            // 
            this.postnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Postnr", true));
            this.postnrTextBox.Location = new System.Drawing.Point(175, 170);
            this.postnrTextBox.Name = "postnrTextBox";
            this.postnrTextBox.Size = new System.Drawing.Size(100, 20);
            this.postnrTextBox.TabIndex = 8;
            // 
            // lblZoek
            // 
            this.lblZoek.AutoSize = true;
            this.lblZoek.Location = new System.Drawing.Point(87, 50);
            this.lblZoek.Name = "lblZoek";
            this.lblZoek.Size = new System.Drawing.Size(82, 13);
            this.lblZoek.TabIndex = 10;
            this.lblZoek.Text = "Zoek op naam: ";
            // 
            // cbNaam
            // 
            this.cbNaam.DataSource = this.dtsOefening1;
            this.cbNaam.DisplayMember = "tblKlanten.Naam";
            this.cbNaam.FormattingEnabled = true;
            this.cbNaam.Location = new System.Drawing.Point(176, 50);
            this.cbNaam.Name = "cbNaam";
            this.cbNaam.Size = new System.Drawing.Size(121, 21);
            this.cbNaam.TabIndex = 11;
            this.cbNaam.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNaam);
            this.Controls.Add(this.lblZoek);
            this.Controls.Add(klantnummerLabel);
            this.Controls.Add(this.klantnummerTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.straatTextBox);
            this.Controls.Add(postnrLabel);
            this.Controls.Add(this.postnrTextBox);
            this.Controls.Add(this.tblKlantenBindingNavigator);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.Load += new System.EventHandler(this.Oefening2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsOefening1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingNavigator)).EndInit();
            this.tblKlantenBindingNavigator.ResumeLayout(false);
            this.tblKlantenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsOefening1 dtsOefening1;
        private System.Windows.Forms.BindingSource tblKlantenBindingSource;
        private dtsOefening1TableAdapters.tblKlantenTableAdapter tblKlantenTableAdapter;
        private dtsOefening1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblKlantenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblKlantenBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox klantnummerTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.TextBox postnrTextBox;
        private System.Windows.Forms.Label lblZoek;
        private System.Windows.Forms.ComboBox cbNaam;
    }
}