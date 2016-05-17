using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucFörsäkringstagare : UserControl
    {

        private static Service.ServiceController controllerService;
        private static ucFörsäkringstagare _instance;

        public static ucFörsäkringstagare Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFörsäkringstagare();
                }
                return _instance;
            }
        }

        public ucFörsäkringstagare()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
            Uppdatera();
        }

        private void Uppdatera()
        {
            // Uppdatera tabell
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controllerService.Get_FörsäkringstagarePrivat_GetAll();
            dataGridView2.DataSource = null;

            DGVFöretag.DataSource = null;
            DGVFöretag.DataSource = controllerService.Get_FörsäkringstagareFöretag_GetAll();
        }

        private void btnAutofyll_Click(object sender, EventArgs e) //hämtar objektets fullständiga info vid valt personNr
        {
            if (tbSökPersonnummer.Text != "" && tbSökPersonnummer.Text != null)
            {
                dataGridView2.DataSource = controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbSökPersonnummer.Text);
                if (dataGridView2.DataSource != null) Fyll_Privat();
                else MessageBoxesClass.HittadeInte("personnummer");
            }
            if (tbSökEfternamn.Text != "" && tbSökEfternamn.Text != null)
            {
                dataGridView1.DataSource = controllerService.Get_FörsäkringstagarePrivat_With_Efternamn(tbSökEfternamn.Text);
                if (dataGridView1.DataSource == null) MessageBoxesClass.HittadeInte("personnummer");
            }
            else Uppdatera();
        }
        private void Fyll_Privat()
        {
            FörsäkringstagarePrivat person = (FörsäkringstagarePrivat)dataGridView2.SelectedRows[0].DataBoundItem;
            tbPersonPersonnummer.Text = person.Personnummer;
            tbPersonFörnamn.Text = person.förnamn;
            tbPersonEfternamn.Text = person.efternamn;
            tbPersonStad.Text = person.postadress;
            tbPersonPostnummer.Text = person.postnummer;
            tbPersonTelefonnummerHem.Text = person.telefonnummerhem;
            tbPersonTelefonnummerArbete.Text = person.telefonnummerarb;
            tbPersonEmail.Text = person.mail;
        }

        private void Fyll_Företag()
        {

            FörsäkringstagareFöretag företag = (FörsäkringstagareFöretag)DGVFöretag.SelectedRows[0].DataBoundItem;
            tbFöretagOrgnaisationsnummer.Text = företag.Organisationsnummer;
            tbFöretagFöretagsnamn.Text = företag.Företagsnamn;
            tbFöretagKontaktpersonFörnamn.Text = företag.ktFörnamn;
            tbFöretagKontaktpersonEfternamn.Text = företag.ktEfternamn;
            tbFöretagGatauadress.Text = företag.gatuadress;
            tbFöretagPostadress.Text = företag.postadress;
            tbFöretagPostnummer.Text = företag.postnummer;
            tbFöretagTelefonnummer.Text = företag.telefonnummer;
            tbFöretagEmail.Text = företag.mail;
            tbFöretagFax.Text = företag.fax;
        }


        private void btnSparaPers_Click(object sender, EventArgs e)
        {
            if (tbPersonPersonnummer != null)
            {
                controllerService.Save(new FörsäkringstagarePrivat
                {
                    Personnummer = tbPersonPersonnummer.Text,
                    förnamn = tbPersonFörnamn.Text,
                    efternamn = tbPersonEfternamn.Text,
                    gatuadress = tbPersonAdress.Text,
                    postadress = tbPersonStad.Text,
                    postnummer = tbPersonPostnummer.Text,
                    telefonnummerhem = tbPersonTelefonnummerHem.Text,
                    telefonnummerarb = tbPersonTelefonnummerArbete.Text,
                    mail = tbPersonEmail.Text
                });

                Uppdatera();
            }
        }

        // spara företagskund
        private void btnSparaFöre_Click(object sender, EventArgs e)
        {
            if (tbFöretagOrgnaisationsnummer.Text != "")
            {

                controllerService.Save(new FörsäkringstagareFöretag
                {
                    Organisationsnummer = tbFöretagOrgnaisationsnummer.Text,
                    Företagsnamn = tbFöretagFöretagsnamn.Text,
                    ktFörnamn = tbFöretagKontaktpersonFörnamn.Text,
                    ktEfternamn = tbFöretagKontaktpersonEfternamn.Text,
                    gatuadress = tbFöretagGatauadress.Text,
                    postadress = tbFöretagPostadress.Text,
                    postnummer = tbFöretagPostnummer.Text,
                    telefonnummer = tbFöretagTelefonnummer.Text,
                    mail = tbFöretagEmail.Text,
                    fax = tbFöretagFax.Text
                });
                Uppdatera();

            }



            else
            {
                MessageBox.Show("Fyll i Organisationsnummer innan du sparar", "Det gick inte att spara",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RensaPrivatFält()
        {
            //Rensar boxarna
            tbPersonPersonnummer.Text = "";
            tbPersonEfternamn.Text = "";
            tbPersonFörnamn.Text = "";
            tbPersonAdress.Text = "";
            tbPersonPostnummer.Text = "";
            tbPersonStad.Text = "";
            tbPersonTelefonnummerHem.Text = "";
            tbPersonTelefonnummerArbete.Text = "";
            tbPersonEmail.Text = "";
        }
        private void RensaFöretagFält()
        {
            //Rensar boxarna
            tbFöretagOrgnaisationsnummer.Text = "";
            tbFöretagFöretagsnamn.Text = "";
            tbFöretagKontaktpersonFörnamn.Text = "";
            tbFöretagKontaktpersonEfternamn.Text = "";
            tbFöretagGatauadress.Text = "";
            tbFöretagPostadress.Text = "";
            tbFöretagPostnummer.Text = "";
            tbFöretagTelefonnummer.Text = "";
            tbFöretagEmail.Text = "";
            tbFöretagFax.Text = "";
        }

        private void btnAvbrytFöre_Click(object sender, EventArgs e) { RensaFöretagFält(); }

        private void btnAvbrytPers_Click(object sender, EventArgs e) { RensaPrivatFält(); }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.DataSource = new List<FörsäkringstagarePrivat> { controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) };
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) { if (dataGridView2.SelectedRows[0] != null) Fyll_Privat(); }

        private void btnTabort_Click(object sender, EventArgs e)
        // ta bort försäkringstagare privat
        {
            if (tbPersonPersonnummer.Text != "")
            {
                controllerService.Remove(controllerService.Get_FörsäkringstagarePrivat_With_Personnummer(tbPersonPersonnummer.Text));
                Uppdatera();
            }
            RensaPrivatFält();
        }

        private void DGVFöretag_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) { if (DGVFöretag.SelectedRows[0] != null) Fyll_Företag(); }

        private void btnFöretagTabort_Click(object sender, EventArgs e)
        {
            if (tbFöretagOrgnaisationsnummer.Text != "")
            {
                controllerService.Remove(controllerService.Get_FörsäkringstagareFöretag_With_Organisationsnummer(tbFöretagOrgnaisationsnummer.Text));
                Uppdatera();
                RensaPrivatFält();
            }
        }

    }
}