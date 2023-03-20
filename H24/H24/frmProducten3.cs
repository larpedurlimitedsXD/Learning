using System;
using System.Data;
using System.Windows.Forms;

namespace H24
{
    public partial class frmProducten3 : Form
    {
        public frmProducten3()
        {
            InitializeComponent();
        }

        private void tblProductenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsProducten3);

        }

        //Dataview declareren: 
        DataView dtvProducten;

        private void frmProducten3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsProducten3.tblProducten' table. You can move, or remove it, as needed.
            this.tblProductenTableAdapter.Fill(this.dtsProducten3.tblProducten);

            // DataView opvullen met DefaultView: 
            dtvProducten = dtsProducten3.tblProducten.DefaultView;

            // Sort instellen:
            dtvProducten.Sort = "Productnaam ASC";

            // Datasource instellen:
            tblProductenBindingSource.DataSource = dtvProducten;
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            // Eerst gaan we tekst opvangen: 
            string strZoekTekst = txtZoek.Text;

            //indiend deze leeg is, zouden we kunnen returnen:
            if(strZoekTekst == string.Empty)
            {
                //Dit werkt beter maar is niet verplicht
                return;
            }

            // Nu gaan we checken welke index ons product heeft: 
            int intIndexOfProduct = dtvProducten.Find(strZoekTekst);

            // Dan kijken we of deze tekst bestaat of niet: 
            if (intIndexOfProduct == -1)
            {
                MessageBox.Show("Product niet gevonden!");
            }
            else
            {
                // Hier gaan we de positie van de bindingsource wijzigen. Dit zorgt ervoor dat ons product zichtbaar wordt: 
                tblProductenBindingSource.Position = intIndexOfProduct;
            }
        }
    }
}
