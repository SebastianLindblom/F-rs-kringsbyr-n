using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Försäkringsbyrån
{
    using Service;
    public partial class Inloggning : Form
    {
        
        public Inloggning()
        {
            InitializeComponent();
            txbLös.PasswordChar = '*';
        }

        // Knapp event för inloggning
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "Bearbetar...";
            if(User.login(txbAnvändarnamn.Text, txbLös.Text))
            {
                new Huvudmeny().Show(); // visa Menyn
                this.Hide();
            }

            else MessageBoxesClass.InloggningError();
            btnLogin.Text = "Login";
        }

        // stäng av applikationen
         private void btnStängav_Click(object sender, EventArgs e) 
        {
            Application.ExitThread();
            
        }

        private void txbLös_TextChanged(object sender, EventArgs e)
         {

         }

        private void btnSkipLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "Bearbetar...";
            if (User.login("skip", txbLös.Text))
            {
                new Huvudmeny().Show(); // visa Menyn
                this.Hide();
            }
            btnLogin.Text = "Login";
        }

    }

       
    }

