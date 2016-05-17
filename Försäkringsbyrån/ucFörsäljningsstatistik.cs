using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucFörsäljningsstatistik : UserControl
    {

        private static Service.ServiceController controllerService;
        private static ucFörsäljningsstatistik _instance;

        public static ucFörsäljningsstatistik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFörsäljningsstatistik();
                }
                return _instance;
            }
        }


        public ucFörsäljningsstatistik()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
            Uppdatera();
        }

        private void Uppdatera() //metod för & uppdatera statistik
        {
            cbÅrsöversiktÅr.DataSource = null;
            cbMånadsöversiktAnställda.DataSource = null;

            if (Service.User.Permission.Contains("a"))
            {
                foreach (Anställd a in controllerService.Get_Anställd_GetAll())
                {
                    if (cbMånadsöversiktAnställda.Items.Contains(a.Användarnamn)) cbMånadsöversiktAnställda.Items.Add(a.Användarnamn);
                    if (cbÅrsöversiktAnställd.Items.Contains(a.Användarnamn)) cbÅrsöversiktAnställd.Items.Add(a.Användarnamn);
                }
            }
            else
            {
                cbMånadsöversiktAnställda.Items.Add(Service.User.Username);
                cbMånadsöversiktAnställda.Text = Service.User.Username;
            }
            int Årsreferens = DateTime.Now.Year - 4;
            for (int x = 0; x < 5; x++)
            {
                if (!cbÅrsöversiktÅr.Items.Contains(Årsreferens + x)) cbÅrsöversiktÅr.Items.Add(Årsreferens + x);
                if(!cbMånadsöversiktÅr.Items.Contains(Årsreferens + x)) cbMånadsöversiktÅr.Items.Add(Årsreferens + x);
            }
        }

        private void btnAvbrytVisaStatisitk_Click(object sender, EventArgs e)
        {
            // Rensa fält 
            cbMånadsöversiktAnställda.Text = "";
            cbMånadsöversiktÅr.Text = "";
            cbMånadsöversiktMånad.Text = "";
            tbMånadsöversiktSjukOlycksfallBarn.Text = "";
            tbMånadsöversiktSjukOlycksfallVuxen.Text = "";
            tbMånadsöversiktLivsförsäkring.Text = "";
            tbMånadsöversiktÖvrigPersförsäkringsVuxen.Text = "";
            tbMånadsöversiktFöretagsförsäkring.Text = "";
            tbMånadsöversiktTotalAckvärdeSOB.Text = "";
            tbMånadsöversiktTotalAckvärdeSOV.Text = "";
            tbMånadsöversiktTotalAckvärdeLIV.Text = "";
        }

        private void btnÅrsöversiktExportera_Click(object sender, EventArgs e)
        {
            controllerService.Export_YearlyReport(cbÅrsöversiktÅr.Text);
        }

        private void btnMånadsöversiktVisa_Click(object sender, EventArgs e)
        {
            // Visar månadsstatestikens 
            string[] Månadsstatistik = controllerService.Get_MonthlySales(cbMånadsöversiktAnställda.Text, cbMånadsöversiktÅr.Text, cbMånadsöversiktMånad.Text);

            tbMånadsöversiktSjukOlycksfallBarn.Text = Månadsstatistik[0];
            tbMånadsöversiktSjukOlycksfallVuxen.Text = Månadsstatistik[1];
            tbMånadsöversiktLivsförsäkring.Text = Månadsstatistik[2];
            tbMånadsöversiktÖvrigPersförsäkringsVuxen.Text = Månadsstatistik[3];
            tbMånadsöversiktFöretagsförsäkring.Text = Månadsstatistik[4];

            tbMånadsöversiktTotalAckvärdeSOB.Text = Månadsstatistik[5];
            tbMånadsöversiktTotalAckvärdeSOV.Text = Månadsstatistik[6];
            tbMånadsöversiktTotalAckvärdeLIV.Text = Månadsstatistik[7];

        }
    }


}
