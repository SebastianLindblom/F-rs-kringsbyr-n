using System;
using System.Windows.Forms;

namespace Försäkringsbyrån
{
    using Service;
    public partial class Huvudmeny : Form
    {
        public Huvudmeny()
        { 
            InitializeComponent();
            lbInloggadsom.Text = "Inloggad som: " + User.Username ;
            DisableButtons();
        }

        private void Huvudmeny_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void DisableButtons()
        {
            string Område;
            if ((Område = User.Permission) == null) Område = "Inte Behörig Alls";
            
            if (!Område.Contains("1")) btnhmanv.Enabled = false;
            if (!Område.Contains("2")) btnBehörighet.Enabled = false;
            if (!Område.Contains("3")) btnhmFörsäkringstagare.Enabled = false;
            if (!Område.Contains("4")) btnhmAnsökning.Enabled = false;
            if (!Område.Contains("5")) btnhmskrvprosp.Enabled = false;
            if (!Område.Contains("6")) btnhmProvision.Enabled = false;
            if (!Område.Contains("7")) btnhmfs.Enabled = false;
            if (!Område.Contains("8")) btnhmFörsäkringstyper.Enabled = false;
            if (!Område.Contains("9")) btnhmtillv.Enabled = false;
        }


        /*    Knapp till Personal och Användare
        *      Öppnar instansen i panel på huvudmenyn  */
        private void btnhmanv_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucPersonalOchAnvändare.Instance))
            {
                panel1.Controls.Add(ucPersonalOchAnvändare.Instance);
                ucPersonalOchAnvändare.Instance.Dock = DockStyle.Fill;
                ucPersonalOchAnvändare.Instance.BringToFront();
            }
            else
            {
                ucPersonalOchAnvändare.Instance.BringToFront();
            }
        }
        private void btnBehörighet_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucBehörighet.Instance))
            {
                panel1.Controls.Add(ucBehörighet.Instance);
                ucBehörighet.Instance.Dock = DockStyle.Fill;
                ucBehörighet.Instance.BringToFront();
            }
            else
            {
                ucBehörighet.Instance.BringToFront();
            }
        }

        /*    Knapp till Försäljningsstatistik
       *      Öppnar instansen i panel på huvudmenyn  */
        private void btnhmfs_Click(object sender, EventArgs e)
        {
             if (!panel1.Contains(ucFörsäljningsstatistik.Instance))
            {
                if (ucFörsäljningsstatistik.Instance.IsDisposed == true) panel1.Controls.Remove(ucFörsäljningsstatistik.Instance);
                panel1.Controls.Add(ucFörsäljningsstatistik.Instance);
                ucFörsäljningsstatistik.Instance.Dock = DockStyle.Fill;
                ucFörsäljningsstatistik.Instance.BringToFront();
            }
            else
            {
                ucFörsäljningsstatistik.Instance.BringToFront();
            }
        }

    
        /*    Knapp till Grundbelopp och Ackvärde
       *      Öppnar instansen i panel på huvudmenyn  */
        private void btnhmgrakv_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucFörsäkringstyper.Instance))
            {
                panel1.Controls.Add(ucFörsäkringstyper.Instance);
                ucFörsäkringstyper.Instance.Dock = DockStyle.Fill;
                ucFörsäkringstyper.Instance.BringToFront();
            }
            else
            {
                ucFörsäkringstyper.Instance.BringToFront();
            }
        }

        /*    Knapp för att logga ut
      *      Öppnar instansen i panel på huvudmenyn  */
        private void btnhmlogut_Click(object sender, EventArgs e)
        {
          
            this.Close();
              
     
           Inloggning frmInloggning = new Inloggning();
          frmInloggning.ShowDialog();
        }

        /*    Knapp till att Skriva ut Prospekt
      *      Öppnar instansen i panel på huvudmenyn  */
        private void btnhmskrvprosp_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucProspekt.Instance))
            {
                panel1.Controls.Add(ucProspekt.Instance);
                ucProspekt.Instance.Dock = DockStyle.Fill;
                ucProspekt.Instance.BringToFront();
            }
            else
            {
                ucProspekt.Instance.BringToFront();
            }
        }

   

            /*    Knapp till Tillval
    *      Öppnar instansen i panel på huvudmenyn  */
        private void btnhmtillv_Click(object sender, EventArgs e)
        {            
            if (!panel1.Contains(ucTillval.Instance))
            {
                panel1.Controls.Add(ucTillval.Instance);
                ucTillval.Instance.Dock = DockStyle.Fill;
                ucTillval.Instance.BringToFront();
            }
            else
            {
                ucTillval.Instance.BringToFront();
            }
        }

        /*    Knapp för att stänga av
    *      Öppnar messagebox för att säkerställa avstängning av programmet, sedan stängs programmet av  */
        private void btnhmlogutstav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Är du säker på att du vill stänga av?", "Stäng av",
MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            
            
            lbInloggadsom.Text = "inte inloggad";

            Huvudmeny frmHuvudmeny = new Huvudmeny();
            Application.Exit();
        }

        private void Huvudmeny_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Är du säker på att du vill stänga av?", "Stäng av",
MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        private void btnhmAnsökning_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucAnsökning.Instance))
            {
                panel1.Controls.Add(ucAnsökning.Instance);
                ucAnsökning.Instance.Dock = DockStyle.Fill;
                ucAnsökning.Instance.BringToFront();
            }
            else
            {
                ucAnsökning.Instance.BringToFront();
            }
        }

        private void btnhmFörsäkringstagare_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucFörsäkringstagare.Instance))
            {
                panel1.Controls.Add(ucFörsäkringstagare.Instance);
                ucFörsäkringstagare.Instance.Dock = DockStyle.Fill;
                ucFörsäkringstagare.Instance.BringToFront();
            }
            else
            {
                ucFörsäkringstagare.Instance.BringToFront();
            }
        }

        private void btnhmProvision_Click(object sender, EventArgs e)
        {
            if (!panel1.Contains(ucProvision.Instance))
            {
                panel1.Controls.Add(ucProvision.Instance);
                ucProvision.Instance.Dock = DockStyle.Fill;
                ucProvision.Instance.BringToFront();
            }
            else
            {
                ucProvision.Instance.BringToFront();
            }
        }

        private void Huvudmeny_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
