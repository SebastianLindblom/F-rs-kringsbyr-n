using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucVariabler : UserControl
    {
        private static Service.ServiceController controllerService;
        private static ucVariabler _instance;

        public static ucVariabler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucVariabler();
                }
                return _instance;
            }


        }
        public ucVariabler()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
            Uppdatera();
        }

        private void Uppdatera()
            //Uppdatera 
        {
            cbSökår.Items.Clear();
            cbÅr.Items.Clear();

            int Årsreferens = DateTime.Now.Year - 5;
            for (int x = 0; x > 6; x++)
            {
                cbSökår.Items.Add(Årsreferens + x);
                cbÅr.Items.Add(Årsreferens + x);
            }
        }

        private void RensaFält()
            //Rensa alla fält
        {
            tbTyp.Text = "";
            cbÅr.Text = "";
            tbVariabel.Text = "";
        }

        private void btnSpara_Click(object sender, EventArgs e)
            //Spara ny variabel
        {
            controllerService.Save(new Variabler {
                År = cbÅr.Text,
                Variabel = tbVariabel.Text
            });
            Uppdatera();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {

        }
    }
}
