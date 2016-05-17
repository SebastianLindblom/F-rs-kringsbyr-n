using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucProvision : UserControl
    {


        private static Service.ServiceController controllerService;
        private static ucProvision _instance;

        public static ucProvision Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucProvision();
                }
                return _instance;
            }


        }

        public ucProvision()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
            Uppdatera();
        }

        private void Uppdatera()
        {
            foreach (Anställd a in controllerService.Get_Anställd_GetAll())
            {
               if(a.Användarnamn!=null) if (!cbAnställdAnställda.Items.Contains(a.Användarnamn)) cbAnställdAnställda.Items.Add(a.Användarnamn);
            }
            DatagridviewInteSorterad();
            DGVProvisionVärden.Columns[0].Visible = false;
        }
        private void DatagridviewInteSorterad()
        {
            DGVProvisionVärden.DataSource = null;
            DGVProvisionVärden.DataSource = controllerService.Get_Provisioner_GetAll();
        }

        private void RensaProvisionFält()
        // Rensa textboxar
        {
            tbProvisionProvisionsandelBarn.Text = "";
            tbProvisionProvisionsandelVuxen.Text = "";
            tbProvisionMinAckvärdeProvision.Text = "";
            tbProvisionMaxAckvärdeProvision.Text = "";
            tbProvisionÅr.Text = "";
        }

        // Knapp för att fylla atta textbox fält med en array av beräknade värden från säljarens teknade försäkringar
        private void btnVisaProvision_Click(object sender, EventArgs e)
        {
            FyllBeräknadProvision(controllerService.Get_MonthlyCommision(cbAnställdAnställda.Text, cbAnställdÅr.Text, cbAnställdMånad.Text));
        }
        private void FyllBeräknadProvision(string[] ProvisionFörAnställd)
        {
            if (ProvisionFörAnställd != null)
            {
                // Anställd
                tbAnställdFörnamn.Text = ProvisionFörAnställd[0];//fNamn
                tbAnställdEfternamn.Text = ProvisionFörAnställd[1];//eNamn 
                tbAnställdGatuadress.Text = ProvisionFörAnställd[2];//adress
                tbAnställdPostadress.Text = ProvisionFörAnställd[3];//postAdr

                tbAnställdSemesterersättningProv.Text = ProvisionFörAnställd[4];

                // Ansökningar
                tbAnställdBuAckvärde.Text = ProvisionFörAnställd[5];//buSumAck 
                tbAnställdVuAckvärde.Text = ProvisionFörAnställd[6];//vuSumAck 
                tbAnställdLivAckvärde.Text = ProvisionFörAnställd[7];//livSumAck
                tbAnställdProvÖvrigt.Text = ProvisionFörAnställd[8];//övrProv   

                // Provisionen
                tbAnställdProvSo.Text = ProvisionFörAnställd[9];//provSo 
                tbAnställdProvLiv.Text = ProvisionFörAnställd[10];//provLiv 

                tbAnställdSummaAckvärde.Text = ProvisionFörAnställd[11];//sumAck    
                tbAnställdSemesterers.Text = ProvisionFörAnställd[12]; // summa semester ers
                tbAnställdSummaProv.Text = ProvisionFörAnställd[13];//sumProv   
                tbAnställdPrelSkattProv.Text = ProvisionFörAnställd[14];//prelSkatt 
                tbAnställdAvgårSkatt.Text = ProvisionFörAnställd[15];//skattSum  
                tbAnställdInsättningBank.Text = ProvisionFörAnställd[16];//insättning
                tbAnställdAttBetala.Text = ProvisionFörAnställd[17];//utbetala  
            }
        }

        // Tilldela tabellen en källa med en lista av provision
        private void btnVisaProvVärden_Click(object sender, EventArgs e)
        {
            DGVProvisionVärden.DataSource = controllerService.Get_Provisioner_With_Year(cmbProvisionSökÅr.Text);
        }

        private void btnSparaProvisionsvärden_Click(object sender, EventArgs e)
        {
            controllerService.Save(new Provision {
            år =  tbProvisionÅr.Text,
            provisionsAndelBarn =  tbProvisionProvisionsandelBarn.Text,
             provisionsAndelVuxen=  tbProvisionProvisionsandelVuxen.Text,
            MinAck_värde =  tbProvisionMinAckvärdeProvision.Text,
             MaxAck_värde=  tbProvisionMaxAckvärdeProvision.Text
            });
            Uppdatera();
    }
        private void btnTabort_Click(object sender, EventArgs e)
        {
            controllerService.Remove(controllerService.Get_Provisioner_With_Year_Min_Max(tbProvisionÅr.Text, tbProvisionMinAckvärdeProvision.Text, tbProvisionMaxAckvärdeProvision.Text));
            Uppdatera();
            RensaProvisionFält();

        }
        //fyll gridview med värden
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGVProvisionVärden.DataSource != null)
            {
                tbProvisionÅr.Text = DGVProvisionVärden.SelectedRows[0].Cells[1].Value.ToString();
                tbProvisionProvisionsandelBarn.Text = DGVProvisionVärden.SelectedRows[0].Cells[2].Value.ToString();
                tbProvisionProvisionsandelVuxen.Text = DGVProvisionVärden.SelectedRows[0].Cells[3].Value.ToString();
                tbProvisionMinAckvärdeProvision.Text = DGVProvisionVärden.SelectedRows[0].Cells[4].Value.ToString();
                tbProvisionMaxAckvärdeProvision.Text = DGVProvisionVärden.SelectedRows[0].Cells[5].Value.ToString();


            }
        }

        private void cbAnställdAnställda_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        //Metod för att låsa möjligheten att skriva in bokstäver i ett fält för nummer
        private void Keypress_Num(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.') ;
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        //Metod för att låsa möjligheten att skriva in nummer i ett fält för bokstäver
        private void Keypress_Cha(object sender, KeyPressEventArgs e)
        {

        }
        /// <summary>
        /// print monthly commission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkrivUtProvision_Click(object sender, EventArgs e)
        {
            controllerService.Export_MonthlyCommision(tbAnställdFörnamn.Text, tbAnställdEfternamn.Text, tbAnställdGatuadress.Text, tbAnställdPostadress.Text, tbAnställdSemesterersättningProv.Text, tbAnställdBuAckvärde.Text, tbAnställdVuAckvärde.Text, tbAnställdLivAckvärde.Text, tbAnställdProvÖvrigt.Text, tbAnställdProvSo.Text, tbAnställdProvLiv.Text, tbAnställdSummaAckvärde.Text, tbAnställdSemesterers.Text, tbAnställdSummaProv.Text, tbAnställdPrelSkattProv.Text, tbAnställdAvgårSkatt.Text, tbAnställdInsättningBank.Text, tbAnställdAttBetala.Text);
        }
    }
}
