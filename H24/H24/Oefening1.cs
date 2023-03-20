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
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        private void tblKlantenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKlantenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsOefening1);

        }

        DataView dtvNamen;

        private void Oefening1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsOefening1.tblKlanten' table. You can move, or remove it, as needed.
            this.tblKlantenTableAdapter.Fill(this.dtsOefening1.tblKlanten);

            // DataView opvullen met DefaultView: 
            dtvNamen = dtsOefening1.tblKlanten.DefaultView;

            // Sort instellen:
            dtvNamen.Sort = "Naam ASC";

            // Datasource instellen:
            tblKlantenBindingSource.DataSource = dtvNamen;
        }

        private void straatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void klantnummerLabel_Click(object sender, EventArgs e)
        {

        }

        private void naamLabel_Click(object sender, EventArgs e)
        {

        }

        private void naamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void straatLabel_Click(object sender, EventArgs e)
        {

        }

        private void klantnummerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void postnrLabel_Click(object sender, EventArgs e)
        {

        }

        private void postnrTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            // Eerst gaan we tekst opvangen: 
            string strZoekTekst = txtNaam.Text;

            //indiend deze leeg is, zouden we kunnen returnen:
            if (strZoekTekst == string.Empty)
            {
                //Dit werkt beter maar is niet verplicht
                return;
            }

            // Nu gaan we checken welke index ons product heeft: 
            int intIndexOfName = dtvNamen.Find(strZoekTekst);

            // Dan kijken we of deze tekst bestaat of niet: 
            if (intIndexOfName== -1)
            {
                MessageBox.Show("Klantnaam niet gevonden!");
            }
            else
            {
                // Hier gaan we de positie van de bindingsource wijzigen. Dit zorgt ervoor dat ons product zichtbaar wordt: 
                tblKlantenBindingSource.Position = intIndexOfName;
            }
        }
    }
}
