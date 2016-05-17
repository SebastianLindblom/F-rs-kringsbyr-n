using System;
using System.Windows.Forms;


namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucTillval : UserControl
    {
        private static Service.ServiceController controllerService;
        private static ucTillval _instance;
        public static ucTillval Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucTillval();
                }
                return _instance;
            }
        }

        public ucTillval()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
            Uppdatera();
        }

        private void Uppdatera()
        {
            // Uppdatera 
            cbTillvalDatumSök.DataSource = null;
            cbTillvalsDatum.DataSource = null;

            DGVTillvalBelopp.DataSource = null;
            DGVTillvalVariabler.DataSource = null;
            DGVTillvalsvariabler.DataSource = null;

            foreach (Tillval tv in controllerService.Get_Tillval_GetAll()) if (!cbTillvalDatumSök.Items.Contains(tv.Datum)) cbTillvalDatumSök.Items.Add(tv.Datum);
            cbTillvalDatumSök.Items.Add(" ");

            int Årsreferens = DateTime.Now.Year - 4;
            for (int x = 0; x < 5; x++) { cbTillvalsDatum.Items.Add(Årsreferens + x); }

            DGVTillvalBelopp.DataSource = controllerService.Get_Tillval_GetAll();
            DGVTillvalVariabler.DataSource = controllerService.Get_TillvalsVariabler_GetAll();
            DGVTillvalsvariabler.DataSource = controllerService.Get_TillvalsVariabler_GetAll();
            DöljKolumner();
        }
        private void DöljKolumner()
        {
            DGVTillvalBelopp.Columns[0].Visible = false;
            DGVTillvalVariabler.Columns[0].Visible = false;
            DGVTillvalsvariabler.Columns[0].Visible = false;
        }

        private void RensaFält()
        // Rensa alla fält
        {
            tbTillvalsTyp.Text = "";
            cbTillvalsDatum.Text = "";
            tbTillvalsGrundbelopp.Text = "";
            tbTillvalsVariabel.Text = "";
        }

        private void btnAvbrytTillval_Click(object sender, EventArgs e)
        {
            RensaFält();
        }
        private void btnTillvalSpara_Click(object sender, EventArgs e)
        {
            TillvalsVariabler variabel = controllerService.Get_TillvalsVariabler_With_Datum_Variabel(tbTillvalsDatum.Text, tbTillvalsVariabel.Text);
            if (variabel == null)
            {
                controllerService.Save(new TillvalsVariabler { Datum = tbTillvalsDatum.Text, Variabeln = tbTillvalsVariabel.Text });
                variabel = controllerService.Get_TillvalsVariabler_With_Datum_Variabel(tbTillvalsDatum.Text, tbTillvalsVariabel.Text);
            }


            Tillval tillval = new Tillval
            {
                Typ = tbTillvalsTyp.Text,
                Belopp = tbTillvalsGrundbelopp.Text,
                Datum = tbTillvalsDatum.Text,
                VariabelId = variabel.Id
            };


            controllerService.Save(tillval);
            Uppdatera();
        }

        private void DGVTillvalBelopp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Lägga till värden i datagridviewn 
            tbTillvalsTyp.Text = DGVTillvalBelopp.SelectedRows[0].Cells[1].Value.ToString();
            tbTillvalsGrundbelopp.Text = DGVTillvalBelopp.SelectedRows[0].Cells[2].Value.ToString();
            tbTillvalsDatum.Text = DGVTillvalBelopp.SelectedRows[0].Cells[3].Value.ToString();
            try { tbTillvalsVariabel.Text = DGVTillvalBelopp.SelectedRows[0].Cells[4].Value.ToString(); }
            catch (Exception ex) { throw ex; }
        }

        private void DGVTillvalVariabler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //Lägg till tillvalsvariabel och datum i gridviewn         
        {
            tbTillvalsVariabel.Text = DGVTillvalVariabler.SelectedRows[0].Cells[2].Value.ToString();
            tbTillvalsDatum.Text = DGVTillvalVariabler.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void cbTillvalsDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTillvalsDatum.Text = cbTillvalsDatum.Text;
        }

        //Ta bort tillval
        private void btnTillvalTaBort_Click(object sender, EventArgs e)
        {
            controllerService.Remove(controllerService.Get_Tillval_With_Typ_Datum_Belopp(tbTillvalsTyp.Text, tbTillvalsDatum.Text, tbTillvalsGrundbelopp.Text));
            Uppdatera();
        }

        //Spara tillval
        private void btnTillvalsvariablerSpara_Click(object sender, EventArgs e)
        {
            controllerService.Save(new TillvalsVariabler { Datum = tbTillvalsvariablerDatum.Text, Variabeln = tbTillvalsvariablerVariabeln.Text});
            Uppdatera();
        }

        //Ta bort tillvalsvariabler
        private void btnTillvalsvariablerTaBort_Click(object sender, EventArgs e)
        {
            controllerService.Remove(controllerService.Get_TillvalsVariabler_With_Datum_Variabel(tbTillvalsvariablerDatum.Text, tbTillvalsvariablerVariabeln.Text));
            Uppdatera();
        }

        private void DGVTillvalsvariabler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbTillvalsvariablerDatum.Text = DGVTillvalsvariabler.SelectedRows[0].Cells[1].Value.ToString();
            tbTillvalsvariablerVariabeln.Text = DGVTillvalsvariabler.SelectedRows[0].Cells[2].Value.ToString();
        }

    }
}
