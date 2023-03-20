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
    public partial class Oefening2 : Form
    {
        public Oefening2()
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
        private void Oefening2_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eerst gaan we tekst opvangen: 
            string strZoekTekst = cbNaam.Text;

            //indiend deze leeg is, zouden we kunnen returnen:
            if (strZoekTekst == string.Empty)
            {
                //Dit werkt beter maar is niet verplicht
                return;
            }

            // Nu gaan we checken welke index ons product heeft: 
            int intIndexOfName = dtvNamen.Find(strZoekTekst);

            // Dan kijken we of deze tekst bestaat of niet: 
            if (intIndexOfName == -1)
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
