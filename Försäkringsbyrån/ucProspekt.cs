using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    public partial class ucProspekt : UserControl
    {

        private static Service.ServiceController controllerService;
        private static ucProspekt _instance;

        public static ucProspekt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucProspekt();
                }
                return _instance;
            }
        }

        public ucProspekt()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
        }
        /// <summary>
        /// Skriver ut kundprospekt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkrivutKp_Click(object sender, EventArgs e)
        {
            controllerService.Export_Prospect();
        }
    }
}
