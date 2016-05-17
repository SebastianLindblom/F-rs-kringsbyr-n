using System;
using System.Windows.Forms;


namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucFörsäkringstyper : UserControl
    {
        private static Service.ServiceController controllerService;
        private static ucFörsäkringstyper _instance;

        public static ucFörsäkringstyper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFörsäkringstyper();
                }
                return _instance;
            }
        }

        public ucFörsäkringstyper()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();
            Uppdatera();
        }
        private void Uppdatera()
        //Uppdatera
        {
            cbSökår.Items.Clear();
            DGVGrundbeloppackvärde.DataSource = null;
            DGVLivsförsäkringarBelopp.DataSource = null;
            DGVLivförsäkringarVariabler.DataSource = null;
            DGVVariablel.DataSource = null;

            foreach (GrundbeloppAckvärde ga in controllerService.Get_GrundbeloppAckvärde_GetAll())
                if (!cbSökår.Items.Contains(ga.År)) cbSökår.Items.Add(ga.År);

            cbSökår.Items.Add(""); // empty option

            foreach (Livsförsäkringar lf in controllerService.Get_Livsförsäkringar_GetAll())
                if (!cbLivsförsäkringDatumSök.Items.Contains(lf.Datum)) cbLivsförsäkringDatumSök.Items.Add((lf.Datum + "indexable").Substring(0, 4));

            cbLivsförsäkringDatumSök.Items.Add(""); // empty option


            DGVGrundbeloppackvärde.DataSource = controllerService.Get_GrundbeloppAckvärde_GetAll();
            DGVLivsförsäkringarBelopp.DataSource = controllerService.Get_Livsförsäkringar_GetAll();
            DGVLivförsäkringarVariabler.DataSource = controllerService.Get_LivsförsäkringVariabler_GetAll();
            DGVVariablel.DataSource = controllerService.Get_LivsförsäkringVariabler_GetAll();

            DöljKolumner();
        }
        private void DöljKolumner()
        {
            //Dölj kolumner
            DGVGrundbeloppackvärde.Columns[0].Visible = false;
            DGVGrundbeloppackvärde.Columns[5].Visible = false;
            DGVGrundbeloppackvärde.Columns[6].Visible = false;
            DGVGrundbeloppackvärde.Columns[7].Visible = false;

            DGVLivsförsäkringarBelopp.Columns[0].Visible = false;
            DGVLivförsäkringarVariabler.Columns[0].Visible = false;
        }

        private void Fyll(string[] array)
        {
            //fyll boxarna
            cbFörsäkringstyp.Text = array[0];
            cbGrundbeloppAckvärdeÅr.Text = array[1];
            tbGrundbeloppAckvärdeBelopp.Text = array[2];
            tbGrundbeloppAckvärdeVärde.Text = array[3];
        }
        private void Fyll()
        {
            //Fyll datagridviewn med värden
            cbFörsäkringstyp.Text = DGVGrundbeloppackvärde.SelectedRows[0].Cells[1].Value.ToString();
            tbGrundbeloppAckvärdeBelopp.Text = DGVGrundbeloppackvärde.SelectedRows[0].Cells[2].Value.ToString();
            cbGrundbeloppAckvärdeÅr.Text = DGVGrundbeloppackvärde.SelectedRows[0].Cells[3].Value.ToString();
            tbGrundbeloppAckvärdeVärde.Text = DGVGrundbeloppackvärde.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void RensaFält()
        {
            //Rensa fält
            cbGrundbeloppAckvärdeÅr.Text = "";
            cbFörsäkringstyp.Text = "";
            tbGrundbeloppAckvärdeBelopp.Text = "";
            tbGrundbeloppAckvärdeVärde.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSparaGrundbelopp_Click_1(object sender, EventArgs e)
        {
            controllerService.Save(new GrundbeloppAckvärde
            {

                typavförsäkring = cbFörsäkringstyp.Text,
                grundbelopp_ = tbGrundbeloppAckvärdeBelopp.Text,
                År = cbGrundbeloppAckvärdeÅr.Text,
                ackvärde = tbGrundbeloppAckvärdeVärde.Text
            });

            //Spara grundbeloppet
            Uppdatera();

        }

        private void btnAvbrytGrundbelopp_Click_1(object sender, EventArgs e)
        {
            //Rensa alla fält
            RensaFält();
        }

        private void btnTabort_Click(object sender, EventArgs e)
        {
            controllerService.Remove(new GrundbeloppAckvärde() { Id = int.Parse(DGVGrundbeloppackvärde.SelectedRows[0].Cells[0].Value.ToString()) });
            //Ta bort grundbelopp och ackvärde
            Uppdatera();
            RensaFält();

        }

        private void cbSökår_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSökår.Text != null && controllerService.Get_GrundbeloppAckvärde_GetAll() != null)
            {
                if (cbSökår.Text == "") DGVGrundbeloppackvärde.DataSource = controllerService.Get_GrundbeloppAckvärde_GetAll();
                else
                {
                    DGVGrundbeloppackvärde.DataSource = controllerService.Get_GrundbeloppAckvärde_With_År(cbSökår.Text);
                    DöljKolumner();
                }
                if (DGVGrundbeloppackvärde.DataSource == null)
                {
                    MessageBoxesClass.HittadeInte("år");
                    Uppdatera();
                }
            }
            else Uppdatera();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGVGrundbeloppackvärde.SelectedRows != null) Fyll();
        }

        private void btnLivsförsäkringSpara_Click(object sender, EventArgs e)
        {
            Variabler variabel = controllerService.Get_LivsförsäkringVariabler_With_Datum_Variabel(tbLivsförsäkringDatum.Text, tbLivsförsäkringVariabel.Text);
            if (variabel == null)
            {
                controllerService.Save(new Variabler { År = tbLivsförsäkringDatum.Text, Variabel = tbLivsförsäkringVariabel.Text });
                variabel = controllerService.Get_LivsförsäkringVariabler_With_Datum_Variabel(tbLivsförsäkringDatum.Text, tbLivsförsäkringVariabel.Text);
            }
            controllerService.Save(new Livsförsäkringar
            {
                Typ = tbLivsförsäkringTyp.Text,
                Datum = tbLivsförsäkringDatum.Text,
                Grundbelopp = tbLivsförsäkringGrundbelopp.Text,
                VariabelId = variabel.Id
            });
            //Spara livförsäkring
            Uppdatera();
        }

        private void btnLivsförsäkringTaBort_Click(object sender, EventArgs e)
        {
            controllerService.Remove(controllerService.Get_Livsförsäkringar_With_Typ_Datum_Belopp(tbLivsförsäkringTyp.Text, tbLivsförsäkringDatum.Text, tbLivsförsäkringGrundbelopp.Text));
            //Ta bort livförsäkring
            Uppdatera();
        }

        private void cbLivsförsäkringDatumSök_SelectedIndexChanged(object sender, EventArgs e)
        {
         //TODO:är detta nödvändigt?   if (cbLivsförsäkringDatumSök.Text != null && BL.Dreamhome.Controller.Instance.ILivsförsäkringar() != null)   {
                if (cbLivsförsäkringDatumSök.Text == "") DGVLivsförsäkringarBelopp.DataSource = controllerService.Get_Livsförsäkringar_GetAll();
                else
                {
                    DGVLivsförsäkringarBelopp.DataSource = controllerService.Get_Livsförsäkringar_With_Datum(cbLivsförsäkringDatumSök.Text);
                    DöljKolumner();
                }
                if (DGVLivsförsäkringarBelopp.DataSource == null || DGVLivförsäkringarVariabler.RowCount < 1)
                {
                MessageBoxesClass.HittadeInte("år");
                    Uppdatera();
                }
            //}
            else Uppdatera();
        }

        private void DGVLivförsäkringarVariabler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Fyll datagridviewn med livförsäkringarvariabler 
            tbLivsförsäkringVariabel.Text = DGVLivförsäkringarVariabler.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DGVVariablel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Fyll datagridviewn med variabel
            tbVariabelDatum.Text = DGVVariablel.SelectedRows[0].Cells[1].Value.ToString();
            tbVariabelVariabeln.Text = DGVVariablel.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnVariabelSpara_Click(object sender, EventArgs e)
        {
            controllerService.Save(new Variabler {
                År = tbVariabelDatum.Text,
                Variabel = tbVariabelVariabeln.Text
            });
            Uppdatera();
        }

        private void btnVariabelTaBort_Click(object sender, EventArgs e)
        {
            controllerService.Remove(controllerService.Get_LivsförsäkringVariabler_With_Datum_Variabel(tbVariabelDatum.Text, tbVariabelVariabeln.Text));
            Uppdatera();
        }

        private void DGVLivsförsäkringarBelopp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Fyll datagridviewn med värden
            tbLivsförsäkringTyp.Text = DGVLivsförsäkringarBelopp.SelectedRows[0].Cells[1].Value.ToString();
            tbLivsförsäkringDatum.Text = DGVLivsförsäkringarBelopp.SelectedRows[0].Cells[2].Value.ToString();
            tbLivsförsäkringGrundbelopp.Text = DGVLivsförsäkringarBelopp.SelectedRows[0].Cells[3].Value.ToString();
            if (DGVLivsförsäkringarBelopp.SelectedRows[0].Cells[4].Value != null) tbLivsförsäkringVariabel.Text = DGVLivsförsäkringarBelopp.SelectedRows[0].Cells[4].Value.ToString();
            else tbLivsförsäkringVariabel.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}