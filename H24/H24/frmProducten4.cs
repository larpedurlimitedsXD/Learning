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
    public partial class frmProducten4 : Form
    {
        public frmProducten4()
        {
            InitializeComponent();
        }

        private void tblProductenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsProducten4);

        }

        private void frmProducten4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsProducten4.tblProducten' table. You can move, or remove it, as needed.
            this.tblProductenTableAdapter.Fill(this.dtsProducten4.tblProducten);

        }
    }
}
