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
    public partial class frmProducten : Form
    {
        public frmProducten()
        {
            InitializeComponent();
        }

        private void frmProducten_Load(object sender, EventArgs e)
        {

            //combobox opvullen met leveranciers

            //Niewe adapter maken om de leveranciers op te halen
            dtsProductenTableAdapters.tblLeveranciersTableAdapter dtsLeveranciers = new dtsProductenTableAdapters.tblLeveranciersTableAdapter();
            //Dan deze gebruiken om de tblLev te vullen van de datasat:
            dtsLeveranciers.Fill(dtsProducten.tblLeveranciers);

            //We vullen nu niet meer alle producten op in de page load

            VulProductenOp();

        }

        private void cbLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            VulProductenOp();
        }

        private void VulProductenOp()
        {
            //Eerst halen we de geselecteerde waarde op en zetten we het om in een integer
            int intLevNr = (int)cbLeveranciers.SelectedValue;

            //Daarna vullen we de producten op:
            this.tblProductenTableAdapter.FillByLeveranciersnummer(dtsProducten.tblProducten, intLevNr);
        }
    }
}
