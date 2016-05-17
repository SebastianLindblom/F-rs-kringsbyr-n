using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucAnsökning : UserControl
    {
        private static Service.ServiceController controllerService;
        private static ucAnsökning _instance;

        public static ucAnsökning Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAnsökning();
                return _instance;
            }
        }

        public ucAnsökning()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();

            // begränsa format av textboxarna
            tbPrivatFörsäkringstagarePersonNr.MaxLength = 12;
            tbÖvrigFörsäkradesId.MaxLength = 12;
            tbPrivatFörsäkradesPersonNr.MaxLength = 12;
            tbFöretagOrgNr.MaxLength = 12;
            tbÖvrigFörsäkringstagarensId.MaxLength = 12;

            Uppdatera();
        }

        private void Uppdatera()
        {
            cbPrivatAgenturNrPers.DataSource = null;
            cbPrivatFörsäkringtypPers.DataSource = null;
            DGVPrivatAnsökningensTillval.DataSource = null;

            foreach (Anställd a in controllerService.Get_Anställd_GetAll()) { if (a.Agenturnummer != null && !cbPrivatAgenturNrPers.Items.Contains(a.Agenturnummer)) { cbPrivatAgenturNrPers.Items.Add(a.Agenturnummer); } }
            foreach (GrundbeloppAckvärde ga in controllerService.Get_GrundbeloppAckvärde_GetAll())
            {
                if (!cbPrivatFörsäkringtypPers.Items.Contains(ga.typavförsäkring)) cbPrivatFörsäkringtypPers.Items.Add(ga.typavförsäkring);
            }
            foreach (Livsförsäkringar liv in controllerService.Get_Livsförsäkringar_GetAll())
            {
                if (!cbPrivatFörsäkringtypPers.Items.Contains(liv.Typ)) cbPrivatFörsäkringtypPers.Items.Add(liv.Typ);
            }

            UppdateraTillval();

        }
        /// <summary>
        /// Update combobox for grundbelopp on interface for privata ansökningar
        /// </summary>
        private void UppdateraFörsäkringsbelopp()
        {
            cbPrivatGrundbelopp.DataSource = null;

            if (tbPrivatAnkomstÅr.Text != "") cbPrivatGrundbelopp.DataSource = controllerService.Get_GrundbeloppAckvärde_With_År_Typ(tbPrivatAnkomstÅr.Text, cbPrivatFörsäkringtypPers.Text);

            cbPrivatGrundbelopp.Text = "";
        }

        // knapp event för att spara personansökning
        private void btnSparaPersAnsök_Click(object sender, EventArgs e)
        {
            AnsökningPrivat ansökning = new AnsökningPrivat
            {
                Löpnummer = tbPrivatFörsäkringsLöpPers.Text,
                försäkringensNr = tbPrivatFörsäkringsNrPers.Text,
                ankomstdatum = string.Concat(tbPrivatAnkomstÅr.Text, cbPrivatAnkomstMånad.Text, cbPrivatAnkomstDag.Text),
                betalningsForm = cbPrivatBetalFormPers.Text,
                betaldatum = string.Concat(tbPrivatDatumÅr.Text, cbPrivatDatumMånad.Text, cbPrivatDatumDag.Text),

                Tillvalsbelopp = tbPrivatTillvalbelopp.Text,
            };

            GrundbeloppAckvärde grundbeloppackvärde = controllerService.Get_GrundbeloppAckvärde_With_Belopp_Typ(cbPrivatGrundbelopp.Text, cbPrivatFörsäkringtypPers.Text);
            if (grundbeloppackvärde != null) ansökning.GrundbeloppAckvärdesId = grundbeloppackvärde.Id;

            FörsäkringstagarePrivat försäkringstagare = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbPrivatFörsäkringstagarePersonNr.Text);
            if (försäkringstagare != null) ansökning.FörsäkringstagarensPersonnummer = försäkringstagare.Personnummer;

            Anställd anställd = controllerService.Get_Anställd_With_Agenturnummer(cbPrivatAgenturNrPers.Text);
            if (anställd != null) ansökning.AnställdId = anställd.Id;


            controllerService.Save(ansökning);

            FörsäkringstagarePrivat försäkrades = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbPrivatFörsäkradesPersonNr.Text);
            if (försäkrades != null)
            {
                ansökning = controllerService.Get_AnsökningPrivat_With_Löpnummer(ansökning.Löpnummer);
                if (ansökning != null) controllerService.Save(new Försäkrad { Id_AnsökningPrivat = ansökning.Id, KundPersonnummer = försäkrades.Personnummer });
            }
            Uppdatera();
        }


        // Hämta lista för gridview
        private void cbSök2Typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFörsäkringarTypAvSök.Items.Clear();
            if (cbSök2Typ.Text == "Privat")
            {
                if (!cbFörsäkringarTypAvSök.Items.Contains("Personnummer")) cbFörsäkringarTypAvSök.Items.Add("Personnummer");
                if (!cbFörsäkringarTypAvSök.Items.Contains("Efternamn")) cbFörsäkringarTypAvSök.Items.Add("Efternamn");
                DGVFörsäkringarStor.DataSource = controllerService.Get_AnsökningPrivat_GetAll();
                DGVFörsäkringarVald.DataSource = controllerService.Get_AnsökningPrivat_GetAll();
            }
            if (cbSök2Typ.Text == "Företag")
            {
                cbFörsäkringarTypAvSök.Items.Clear();
                if (!cbFörsäkringarTypAvSök.Items.Contains("Organisationsnummer")) cbFörsäkringarTypAvSök.Items.Add("Organisationsnamn");
                if (!cbFörsäkringarTypAvSök.Items.Contains("Företagsnamn")) cbFörsäkringarTypAvSök.Items.Add("Företagsnamn");

                DGVFörsäkringarStor.DataSource = controllerService.Get_AnsökningFöretag_GetAll();
            }
            if (cbSök2Typ.Text == "Övrig")
            {
                cbFörsäkringarTypAvSök.Items.Clear();
                DGVFörsäkringarStor.DataSource = controllerService.Get_AnsökningÖvrig_GetAll();
            }
        }

        // Hämta rad från tabellen för företag (gridview)
        private void btnAnsHmtRadF_Click(object sender, EventArgs e)
        {


        }

        // Hämta rad från tabellen för privatperson (gridview)
        private void btnAnsHmtRadP_Click(object sender, EventArgs e)
        {



        }
        // övrig ansökning är inte fullt utvecklad ännu
        private void btnSparaAnsökÖvr_Click(object sender, EventArgs e)
        {

            AnsökningÖvrig ansökning = new AnsökningÖvrig
            {
                Löpnummer = tbÖvrigFörsäkringsLöpNrÖvr.Text,
                Försäkringsnummer = tbÖvrigFörsäkringsNrÖvr.Text,
                Betalningsform = cbPrivatBetalFormPers.Text,
                Tabell = tbÖvrigTabellÖvr.Text,
                Premie = tbÖvrigPremieÖvr.Text,
                Betaldatum = string.Concat(tbPrivatDatumÅr.Text, cbPrivatDatumMånad.Text, cbPrivatDatumDag.Text)

                /*
                Försäkringstagarens efternamn alt. företagsnamn (sökbar)
                Eventuellt Försäkringstagarens förnamn
                Försäkringstagarens personnummer alt företagets organisationsnummer (sökbar)
                Försäkringstagarens alt. företagets gatuadress
                Försäkringstagarens alt. företagets postnummer
                Försäkringstagarens alt. företagets postadress
                Eventuellt rikt- och telefonnummer till försäkringstagare alt. företag
                Eventuellt e-mail till försäkringstagare alt företag
 
                Försäkrades efternamn (standard försäkringstagarens efternamn, men ska kunna ändras) (sökbar)
                Försäkrades förnamn (standard försäkringstagarens förnamn, men ska kunna ändras) (sökbar)
                Försäkrades personnummer (standard försäkringstagarens personnummer, men ska kunna ändras) (sökbar)
                
                En av fyra valbara betalningsformer (helår, halvår, kvartal eller månad)
                Tabell (alfanumerisk) (ex. R65T10)
                Premie
                Agenturnummer
                */
            };

            FörsäkringstagarePrivat privatFörsäkringstagare = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbÖvrigFörsäkringstagarensId.Text);
            if (privatFörsäkringstagare == null)
            {
                FörsäkringstagareFöretag företagFörsäkringstagare = controllerService.Get_FörsäkringstagareFöretag_With_Organisationsnummer(tbÖvrigFörsäkringstagarensId.Text);

                controllerService.Get_FörsäkringstagareFöretag_With_Organisationsnummer(tbÖvrigFörsäkringstagarensId.Text);
                if (företagFörsäkringstagare != null) ansökning.Organisationsnummer = företagFörsäkringstagare.Organisationsnummer;
            }
            else if (privatFörsäkringstagare != null) ansökning.FörsäkringstagarensPersonnummer = privatFörsäkringstagare.Personnummer;


            Anställd anställd = controllerService.Get_Anställd_With_Agenturnummer(cbPrivatAgenturNrPers.Text);
            if (anställd != null) ansökning.AnställdId = anställd.Id;


            controllerService.Save(ansökning);

            //TODO: Ska den försäkrade sparas till en övrig ansökan?
            /*
            FörsäkringstagarePerson försäkrades = serviceController.Get_FörsäkringstagarePrivat_With_Personnummer(tbPrivatFörsäkradesPersonNr.Text);
            if (försäkrades != null)
            {
                ansökning = serviceController.Get_AnsökningÖvrig_With_Löpnummer(ansökning.Löpnummer);
                if (ansökning != null) serviceController.Save(new Försäkrad {  = ansökning.Id, KundPersonnummer = försäkrades.ftPersonNr });
            }
            */
        }

        private void btnAvbrytPersAnsök_Click(object sender, EventArgs e)
        {
            RensaPrivatAnsökningsfält();

        }
        private void RensaPrivatAnsökningsfält()
        {
            //Rensar boxarna
            tbPrivatFörsäkringstagarePersonNr.Text = "";
            tbPrivatFörsäkradesPersonNr.Text = "";

            cbPrivatFörsäkringtypPers.Text = "";
            tbPrivatFörsäkringsNrPers.Text = "";

            cbPrivatBetalFormPers.Text = "";
            cbPrivatAgenturNrPers.Text = "";
            tbPrivatFörsäkringsLöpPers.Text = "";
        }

        private void btnAvbrytAnsökFör_Click(object sender, EventArgs e)
        {
            //Rensar boxarna
            tbFöretagOrgNr.Text = "";
            tbFöretagFöretagsnamn.Text = "";
            tbFöretagKontaktFörnamn.Text = "";
            tbFöretagKontaktEfternamn.Text = "";
            cbFöretagFörsäkringstypFör.Text = "";
            tbFöretagFörsäkringsNrFör.Text = "";
            //dateTimePickerBegynnelsedatum.Text = "";
            //dateTimePicker2Förfallodag.Text = "";
            //dtpAnkomst.Text = "";
            cbFöretagBetalperiodFör.Text = "";
            //dtpBetald.Text = "";
            cbFöretagAgenturNrFör.Text = "";
            tbFöretagFörsäkLöpNrFör.Text = "";
            tbFöretagFörsäkringsbolagFör.Text = "";
            tbFöretagPremieFör.Text = "";
            tbFöretagEvProvFör.Text = "";
            cbPrivatGrundbelopp.Text = "";

            tbPrivatTillvalbelopp.Text = "";

            tbFöretagAnteckning.Text = "";
        }

        private void btnAvbrytAnsökÖvr_Click(object sender, EventArgs e)
        {
            //Rensar boxarna
            tbÖvrigFörsäkringstagarensId.Text = "";
            tbFörsäkringstagareEfternamnÖvr.Text = "";
            tbFörsäkringstagareFörnamnÖvr.Text = "";
            tbFöretagsnamnÖvr.Text = "";
            tbÖvrigFörsäkradesId.Text = "";
            tbFörsäkradEfternamnÖvr.Text = "";
            tbFörsäkradFörnamnÖvr.Text = "";

            tbÖvrigFörsäkringsNrÖvr.Text = "";

            cbÖvrigBetalformÖvr.Text = "";

            cbÖvrigAgenturNrÖvr.Text = "";
            tbÖvrigFörsäkringsLöpNrÖvr.Text = "";
            tbÖvrigFörsäkringsBolagÖvr.Text = "";
            tbÖvrigPremieÖvr.Text = "";
            tbÖvrigEvProvÖvr.Text = "";
            tbÖvrigTabellÖvr.Text = "";
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.') ;
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void btnSök2Sök_Click(object sender, EventArgs e) // söka på identifikationsnummer
        {
            if (cbSök2Typ.Text.ToLower() == "privat")
            {
                if (cbFörsäkringarTypAvSök.Text.ToLower() == "personnummer")
                {
                    DGVFörsäkringarVald.DataSource
                    = controllerService.Get_AnsökningPrivat_With_FörsäkringstagarensPersonnummer(tbFörsäkringarSökord.Text);
                }
                else if (cbFörsäkringarTypAvSök.Text.ToLower() == "efternamn")
                {
                    DGVFörsäkringarStor.DataSource
                    = controllerService.Get_AnsökningPrivat_With_FörsäkringstagarensEfternamn(tbFörsäkringarSökord.Text);
                }
            }
            if (cbSök2Typ.Text.ToLower() == "företag")
            {
                if (cbFörsäkringarTypAvSök.Text.ToLower() == "organisationsnummer" && tbFörsäkringarSökord.Text != "")
                {
                    DGVFörsäkringarStor.DataSource
                 = controllerService.Get_AnsökningFöretag_With_Organisationnummer(tbFörsäkringarSökord.Text);
                }
                else if (cbFörsäkringarTypAvSök.Text.ToLower() == "företagsnamn" && tbFörsäkringarSökord.Text != "")
                {
                    DGVFörsäkringarStor.DataSource
                   = controllerService.Get_AnsökningFöretag_With_Företagsnamn(tbFörsäkringarSökord.Text);

                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cbSök2Typ.Text == "Privat")
            {
                DGVFörsäkringarVald.DataSource = controllerService.Get_AnsökningPrivat_With_Löpnummer(DGVFörsäkringarStor.SelectedRows[0].Cells[1].Value.ToString());
                DGVFörsäkringarFörsäkringstagare.DataSource = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(DGVFörsäkringarStor.SelectedRows[0].Cells[8].Value.ToString());
                DGVFörsäkringarFörsäkrad.DataSource = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(DGVFörsäkringarStor.SelectedRows[0].Cells[10].Value.ToString());
            }
            else if (cbSök2Typ.Text == "Företag")
            {
                DGVFörsäkringarVald.DataSource = controllerService.Get_AnsökningFöretag_With_Löpnummer(DGVFörsäkringarStor.SelectedRows[0].Cells[1].Value.ToString());
                DGVFörsäkringarFörsäkringstagare.DataSource = controllerService.Get_AnsökningFöretag_With_Organisationnummer(DGVFörsäkringarStor.SelectedRows[0].Cells[4].Value.ToString());
                DGVFörsäkringarFörsäkrad.DataSource = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DGVFörsäkringarVald.RowCount != 0)
            {
                tbPrivatFörsäkringstagarePersonNr.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[8].Value.ToString();
                tbPrivatFörsäkradesPersonNr.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[10].Value.ToString();

                tbPrivatFörsäkringsLöpPers.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[1].Value.ToString();
                tbPrivatFörsäkringsNrPers.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[2].Value.ToString();

                //Ankomstdatum
                string[] temp = controllerService.DateSq(DGVFörsäkringarVald.SelectedRows[0].Cells[3].Value.ToString());

                tbPrivatAnkomstÅr.Text = temp[0];
                cbPrivatAnkomstMånad.Text = temp[1];
                cbPrivatAnkomstMånad.Text = temp[2];
                cbPrivatBetalFormPers.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[4].Value.ToString();

                temp = controllerService.DateSq(DGVFörsäkringarVald.SelectedRows[0].Cells[5].Value.ToString());
                tbPrivatDatumÅr.Text = temp[0];
                cbPrivatDatumMånad.Text = temp[1];
                cbPrivatDatumDag.Text = temp[2];

                cbPrivatFörsäkringtypPers.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[6].Value.ToString();
                cbPrivatGrundbelopp.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[7].Value.ToString();

                cbPrivatAgenturNrPers.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[11].Value.ToString();

                // tillval
                tbPrivatTillvalbelopp.Text = DGVFörsäkringarVald.SelectedRows[0].Cells[13].Value.ToString();
            }
            if (cbSök2Typ.Text == "Privat") tabControl1.SelectedIndex = 1;

            UppdateraTillval();
        }


        /// <summary>
        /// Remove Privat Ansökning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrivatTabort_Click(object sender, EventArgs e)
        {
            // ta bort ansökning privat och rensa fält
            AnsökningPrivat ansökning = controllerService.Get_AnsökningPrivat_With_Löpnummer(tbPrivatFörsäkringsLöpPers.Text);
            if(ansökning!= null)controllerService.Remove(ansökning);
            Uppdatera();
            RensaPrivatAnsökningsfält();
        }

        private void tbPrivatFörsäkringstagarePersonNr_TextChanged(object sender, EventArgs e)
        {
            FörsäkringstagarePrivat person = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbPrivatFörsäkradesPersonNr.Text);
            if (person != null)
            {
                tbPrivatFörsäkringstagareFörnamn.Text = person.förnamn;
                tbPrivatFörsäkringstagarensEfternamn.Text = person.efternamn;
            }
            else
            {
                tbPrivatFörsäkringstagareFörnamn.Text = "";
                tbPrivatFörsäkringstagarensEfternamn.Text = "";
            }
        }

        private void tbPrivatFörsäkradesPersonNr_TextChanged(object sender, EventArgs e)
        {
            FörsäkringstagarePrivat person = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbPrivatFörsäkradesPersonNr.Text);
            if (person != null)
            {
                tbPrivatFörsäkradesFörnamn.Text = person.förnamn;
                tbPrivatFörsäkradesEfternamn.Text = person.efternamn;
            }

            else
            {
                tbPrivatFörsäkradesFörnamn.Text = "";
                tbPrivatFörsäkradesEfternamn.Text = "";
            }
        }

        private void tbOrgNr_TextChanged(object sender, EventArgs e)
        {

            FörsäkringstagareFöretag företag = controllerService.Get_FörsäkringstagareFöretag_With_Organisationsnummer(tbFöretagOrgNr.Text);
            if (företag != null)
            {
                tbFöretagFöretagsnamn.Text = företag.Företagsnamn;
                tbFöretagKontaktFörnamn.Text = företag.ktFörnamn;
                tbFöretagKontaktEfternamn.Text = företag.ktEfternamn;
                btnFöretagSpara.Enabled = true;
            }
            else
            {
                tbFöretagFöretagsnamn.Text = "";
                tbFöretagKontaktFörnamn.Text = "";
                tbFöretagKontaktEfternamn.Text = "";
                btnFöretagSpara.Enabled = false;
            }
        }

        private void btnSparaAnsökFör_Click(object sender, EventArgs e)
        {
            AnsökningFöretag ansökning = new AnsökningFöretag
            {
                Löpnummer = tbFöretagFörsäkLöpNrFör.Text,
                Försäkringsnummer = tbFöretagFörsäkringsNrFör.Text,
                Betalddatum = string.Concat(cbFöretagBetaldatumÅr.Text, cbFöretagBetaldatumMånad.Text, cbFöretagBetaldatumDag.Text),
                Försäkringsbolag = tbFöretagFörsäkringsbolagFör.Text,
                Försäkringstyp = cbFöretagFörsäkringstypFör.Text,
                Begynnelsedatum = string.Concat(cbFöretagBegynnelsedatumÅr.Text, cbFöretagBegynnelsedatumMånad.Text, cbFöretagBegynnelsedatumDag.Text),
                förfallodag = string.Concat(cbFöretagFörfallodagÅr.Text, cbFöretagFörfallodagMånad.Text, cbFöretagFörfallodagDag.Text),
                Betalningsperiod = cbFöretagBetalperiodFör.Text,
                Premie = tbFöretagPremieFör.Text,
                Anteckning = tbFöretagAnteckning.Text
            };

            FörsäkringstagareFöretag försäkringstagare = controllerService.Get_FörsäkringstagareFöretag_With_Organisationsnummer(tbFöretagOrgNr.Text);
            if (försäkringstagare != null) ansökning.KundensOrganisationsnummer = försäkringstagare.Organisationsnummer;

            Anställd anställd = controllerService.Get_Anställd_With_Agenturnummer(cbPrivatAgenturNrPers.Text);
            if (anställd != null) ansökning.AnställdId = anställd.Id;

            controllerService.Save(ansökning);
        }

        private void cbPrivatFörsäkringtypPers_SelectedIndexChanged(object sender, EventArgs e) { UppdateraFörsäkringsbelopp(); }

        private void btnPrivatLäggtillTillval_Click(object sender, EventArgs e)
        {
            if (DGVPrivatTillval.SelectedRows.Count > 0)
            {
                AnsökningPrivat ansökning = controllerService.Get_AnsökningPrivat_With_Löpnummer(tbPrivatFörsäkringsLöpPers.Text);

                AnsökningensTillval ansökningstillval = new AnsökningensTillval
                {
                    AnsökningPrivatId = ansökning.Id,
                    TillvalId = System.Convert.ToInt32(DGVPrivatTillval.SelectedRows[0].Cells[0].Value)
                };
                controllerService.Save(ansökningstillval);

                UppdateraTillval();

            }
        }
        private void UppdateraTillval()
        {
            DGVPrivatAnsökningensTillval.DataSource = null;
            DGVPrivatTillval.DataSource = null;


            DGVPrivatAnsökningensTillval.DataSource = controllerService.Get_AnsökningensTillval_With_Löpnummer(tbPrivatFörsäkringsLöpPers.Text);
            DGVPrivatTillval.DataSource = controllerService.Get_Tillval_With_Datum(tbPrivatAnkomstÅr.Text); // x => x.Datum.Substring(0, 4).Equals

            DGVPrivatTillval.Columns[0].Visible = false;
        }

        private void tbPrivatFörsäkringsLöpPers_TextChanged(object sender, EventArgs e)
        {
            UppdateraTillval();
        }

        private void btnPrivatTabortTillval_Click(object sender, EventArgs e)
        {
            if (DGVPrivatAnsökningensTillval.SelectedRows.Count > 0)
            {
                AnsökningensTillval ansökningenstillval = controllerService.Get_AnsökningensTillval_With_Id(System.Convert.ToInt32(DGVPrivatAnsökningensTillval.SelectedRows[0].Cells[0].Value));
                controllerService.Remove(ansökningenstillval);
                UppdateraTillval();
            }
        }
        private void tbPrivatAnkomstÅr_TextChanged(object sender, EventArgs e)
        {
            UppdateraTillval();
            Uppdatera();
            UppdateraFörsäkringsbelopp();
        }

        private void btnTaBortAnsökFör_Click(object sender, EventArgs e)
        {
            controllerService.Remove(controllerService.Get_AnsökningFöretag_With_Löpnummer(tbFöretagFörsäkLöpNrFör.Text));
            Uppdatera();

        }

    }
}