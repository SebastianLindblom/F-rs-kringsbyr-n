using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using ClassLibrary;
    public partial class ucBehörighet : UserControl
    {
        private static Service.ServiceController controllerService;


        private static ucBehörighet _instance;

        public static ucBehörighet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucBehörighet();
                }
                return _instance;
            }
        }
        public ucBehörighet()
        {
            InitializeComponent();
            controllerService = new Service.ServiceController();

            Uppdatera();
        }

        public void Uppdatera()
        {
            // uppdaterar tabellen
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controllerService.Get_Behörigheter_GetAll();
            dataGridView1.Columns[2].Visible = false;
        }
        private void RensaFält()
        {
            // Rensa samtliga fält
            tbRoll.Text = "";
            tbOmråde.Text = "";
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            controllerService.Save(new Behörighet
            {
                roll = tbRoll.Text,
                område = tbOmråde.Text
            });
            
            Uppdatera();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             // tabell med värden
            tbRoll.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbOmråde.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnTaBort_Click_1(object sender, EventArgs e)
        {
            // ta bort, uppdatera och rensa fält
            controllerService.Remove(new Behörighet() { roll = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() });
                Uppdatera();
                RensaFält();
            
        }
    }
}
