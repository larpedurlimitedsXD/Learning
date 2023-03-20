using H24.dtsProducten2TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H24
{
    public partial class frmProducten2 : Form
    {
        public frmProducten2()
        {
            InitializeComponent();
        }

        private void tblProductenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsProducten2);

        }

        private void frmProducten2_Load(object sender, EventArgs e)
        {
            dtsProducten2TableAdapters.tblLeveranciersTableAdapter dtaLeverancier = new tblLeveranciersTableAdapter();
            dtaLeverancier.Fill(dtsProducten2.tblLeveranciers);

            this.tblProductenTableAdapter.Fill(dtsProducten2.tblProducten);

            VulProducten();

        }

        private void tblProductenBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tblProductenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbLeveranciers.SelectedIndex == -1)
            {
                return;
            }

            VulProducten();
        } 

        private void VulProducten()
        {

        }

    }
}
