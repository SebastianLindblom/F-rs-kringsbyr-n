using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using ClassLibrary;
    using Service;

    public partial class ucPersonalOchAnvändare : UserControl
    {
        private static ServiceController serviceController;
        private static ucPersonalOchAnvändare _instance;

        public static ucPersonalOchAnvändare Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPersonalOchAnvändare();
                    }
                return _instance;
            }
        }

        public ucPersonalOchAnvändare()
        {
            InitializeComponent();
            serviceController = new ServiceController();
            rensaPeronal();
            Uppdatera();
        }
        private void Uppdatera()
        {
            // Uppdatera användare


            ///<summary>
            ///Dropdown List of Användare
            /// </summary>
            cbSökAnvändare.Items.Clear();
            foreach (Anställd a in serviceController.Get_Anställd_GetAll())
            {
                if (a.Användarnamn != null) cbSökAnvändare.Items.Add(a.Användarnamn); // Helst visa Användarnamnet
                else if (a.Agenturnummer != null) cbSökAnvändare.Items.Add(a.Agenturnummer); // annars agenturnummret
                else cbSökAnvändare.Items.Add("Saknas värde"); // Om det inte finns något användarnamn eller agenturnummer funkar det fortfarande att söka om platsen för den anställde okuperas av något värde
            }

            ///<summary>
            ///Dropdown List of Arbetsroller (Behörighet)
            /// </summary>
            cbArbetsroll.Items.Clear();
            foreach (Behörighet b in serviceController.Get_Behörigheter_GetAll()) { cbArbetsroll.Items.Add(b.roll); }

            ///<summary>
            ///Datagridview of Semesterersättningar
            /// </summary>
            DGVSemesterersättningar.DataSource = null;
            DGVSemesterersättningar.DataSource = serviceController.Get_Semesterersättningar_GetAll();
            Döljkolumner();
        }
        private void Döljkolumner() { DGVSemesterersättningar.Columns[0].Visible = false; }


        /// <summary>
        /// spara Användare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSparaAnv_Click(object sender, EventArgs e)
        {
            if (tbPersonnummer.Text != "")
            {
                Anställd anställd = new Anställd
                {
                    Personnummer = tbPersonnummer.Text,
                    Efternamn = tbEfternamnAnv.Text,
                    Förnamn = tbFörnamnAnv.Text,
                    Gatuadress = tbGatuadressAnv.Text,
                    postnummer = tbPostNrAnv.Text,
                    Postadress = tbPostadressAnv.Text,
                    telefonnummer = tbTelefonNrAnv.Text,
                    mail = tbEmailAnv.Text,
                    Agenturnummer = tbAgenturNrAnv.Text,
                    skattesats = tbSkattesatsAnv.Text,
                    Användarnamn = tbAnvändarnamnAnv.Text,
                    lösenord = tbLösenAnv.Text
                };

                //TODO: Ska semesterersättning vara kopplad till enskild anställd? Semesterersättningar semesterersättning = serviceController.Find_Semesterersättning_From_Ersättning_Datum(tbSemesterersAnv.Text);
                Behörighet behörighet = serviceController.Get_Behörighet_With_Roll(cbArbetsroll.Text);

                // if (semesterersättning != null) anställd.SemesterersättningsId = semesterersättning.Id;
                if (behörighet != null) anställd.roll = behörighet.roll;

                serviceController.Save(anställd);
            }
           

        }

        /// <summary>
        /// Get Anställd with Användarnamn or Agenturnummer from the search combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHämtauppgAnvändare_Click(object sender, EventArgs e)
        {
            Anställd anställd = serviceController.Get_Anställd_With_Användarnamn_Agenturnummer(cbSökAnvändare.Text);

            if (anställd != null)
            {
                tbPersonnummer.Text = anställd.Personnummer;
                tbEfternamnAnv.Text = anställd.Efternamn;
                tbFörnamnAnv.Text = anställd.Förnamn;
                tbGatuadressAnv.Text = anställd.Gatuadress;
                tbPostNrAnv.Text = anställd.postnummer;
                tbPostadressAnv.Text = anställd.Postadress;
                tbTelefonNrAnv.Text = anställd.telefonnummer;
                tbEmailAnv.Text = anställd.mail;
                tbAgenturNrAnv.Text = anställd.Agenturnummer;
                tbSkattesatsAnv.Text = anställd.skattesats;
                tbAnvändarnamnAnv.Text = anställd.Användarnamn;
                tbLösenAnv.Text = anställd.lösenord;

                cbArbetsroll.Text = anställd.roll;

                //TODO: semesterersättning för anställd tbSemesterersAnv = 
            }
            else rensaPeronal();
            // TODO: Clean up old 
            /*
            List<string> AttributLista = BL.Dreamhome.Controller.Instance.GetAnställd(cbSökAnvändare.Text);
            tbPersonNrAnv.Text = AttributLista[0];
            tbFörnamnAnv.Text = AttributLista[1];
            tbEfternamnAnv.Text = AttributLista[2];
            tbGatuadressAnv.Text = AttributLista[3];
            tbPostadressAnv.Text = AttributLista[4];
            tbPostNrAnv.Text = AttributLista[5];
            tbTelefonNrAnv.Text = AttributLista[6];
            tbEmailAnv.Text = AttributLista[7];
            tbAnvändarnamnAnv.Text = AttributLista[8];
            tbLösenAnv.Text = AttributLista[9];
            tbAgenturNrAnv.Text = AttributLista[10];
            tbSkattesatsAnv.Text = AttributLista[11];
            tbSemesterersAnv.Text = AttributLista[12];
            cbArbetsroll.Text = AttributLista[13];
            */
        }

        /// <summary>
        /// Clear the interface
        /// </summary>
        private void rensaPeronal()
        {
            //Rensa textboxar
            tbAgenturNrAnv.Text = "";
            tbAnvändarnamnAnv.Text = "";
            cbArbetsroll.SelectedText = "";
            tbGatuadressAnv.Text = "";
            tbLösenAnv.Text = "";
            tbEmailAnv.Text = "";
            tbFörnamnAnv.Text = "";
            tbEfternamnAnv.Text = "";
            tbPersonnummer.Text = "";
            tbPostadressAnv.Text = "";
            tbPostNrAnv.Text = "";
            tbTelefonNrAnv.Text = "";
            tbSkattesatsAnv.Text = "";
            tbSemesterersAnv.Text = "";
            cbSökAnvändare.Text = "";
            cbArbetsroll.Text = "";
        }


        private void btnAvbrytAnv_Click(object sender, EventArgs e) { rensaPeronal(); }

        /// <summary>
        /// Remove anställd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTabort_Click(object sender, EventArgs e)
        {
            // Ta bort användare
            if (tbPersonnummer.Text != null) serviceController.Remove(serviceController.Get_Anställd_From_Personnummer(tbPersonnummer.Text));
            Uppdatera();
            rensaPeronal();
        }


        private void cbArbetsroll_DropDown(object sender, EventArgs e) { Uppdatera(); }


        // spara
        private void btnSemesterersättningarSpara_Click(object sender, EventArgs e)
        {
            serviceController.Save(new Semesterersättningar
            {
                Semesterersättning = tbSemesterersättningarErsättning.Text,
                Datum = tbSemesterersättningarDatum.Text
            });
            Uppdatera();
        }

        //ta bort
        private void btnSemesterersättningarTabort_Click(object sender, EventArgs e) {
           serviceController.Remove(serviceController.Get_Semesterersättning_With_Ersättning_Datum(tbSemesterersättningarErsättning.Text, tbSemesterersättningarDatum.Text));
            Uppdatera();
        }

        //Lägger till värden i tabellen i semesterersättningar 
        private void DGVSemesterersättningar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbSemesterersättningarDatum.Text = DGVSemesterersättningar.SelectedRows[0].Cells[1].Value.ToString();
            tbSemesterersättningarErsättning.Text = DGVSemesterersättningar.SelectedRows[0].Cells[2].Value.ToString();
        }

    }
}