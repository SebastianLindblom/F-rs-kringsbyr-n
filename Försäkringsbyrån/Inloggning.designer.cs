namespace Försäkringsbyrån
{
    partial class Inloggning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inloggning));
            this.btnStängav = new System.Windows.Forms.Button();
            this.txbLös = new System.Windows.Forms.TextBox();
            this.txbAnvändarnamn = new System.Windows.Forms.TextBox();
            this.lbAnvändarnamn = new System.Windows.Forms.Label();
            this.lbLös = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSkipLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStängav
            // 
            this.btnStängav.BackColor = System.Drawing.Color.White;
            this.btnStängav.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStängav.Location = new System.Drawing.Point(11, 508);
            this.btnStängav.Name = "btnStängav";
            this.btnStängav.Size = new System.Drawing.Size(87, 24);
            this.btnStängav.TabIndex = 59;
            this.btnStängav.Text = "Stäng av";
            this.btnStängav.UseVisualStyleBackColor = false;
            this.btnStängav.Click += new System.EventHandler(this.btnStängav_Click);
            // 
            // txbLös
            // 
            this.txbLös.BackColor = System.Drawing.Color.DimGray;
            this.txbLös.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLös.ForeColor = System.Drawing.Color.SkyBlue;
            this.txbLös.Location = new System.Drawing.Point(94, 54);
            this.txbLös.Name = "txbLös";
            this.txbLös.Size = new System.Drawing.Size(162, 20);
            this.txbLös.TabIndex = 57;
            this.txbLös.TextChanged += new System.EventHandler(this.txbLös_TextChanged);
            // 
            // txbAnvändarnamn
            // 
            this.txbAnvändarnamn.BackColor = System.Drawing.Color.DimGray;
            this.txbAnvändarnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnvändarnamn.ForeColor = System.Drawing.Color.SkyBlue;
            this.txbAnvändarnamn.Location = new System.Drawing.Point(94, 18);
            this.txbAnvändarnamn.Name = "txbAnvändarnamn";
            this.txbAnvändarnamn.Size = new System.Drawing.Size(162, 20);
            this.txbAnvändarnamn.TabIndex = 56;
            // 
            // lbAnvändarnamn
            // 
            this.lbAnvändarnamn.AutoSize = true;
            this.lbAnvändarnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnvändarnamn.ForeColor = System.Drawing.Color.White;
            this.lbAnvändarnamn.Location = new System.Drawing.Point(8, 20);
            this.lbAnvändarnamn.Name = "lbAnvändarnamn";
            this.lbAnvändarnamn.Size = new System.Drawing.Size(79, 13);
            this.lbAnvändarnamn.TabIndex = 55;
            this.lbAnvändarnamn.Text = "Användarnamn";
            // 
            // lbLös
            // 
            this.lbLös.AutoSize = true;
            this.lbLös.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLös.ForeColor = System.Drawing.Color.White;
            this.lbLös.Location = new System.Drawing.Point(37, 57);
            this.lbLös.Name = "lbLös";
            this.lbLös.Size = new System.Drawing.Size(51, 13);
            this.lbLös.TabIndex = 54;
            this.lbLös.Text = "Lösenord";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(156, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 24);
            this.btnLogin.TabIndex = 61;
            this.btnLogin.Text = "Logga in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSkipLogin
            // 
            this.btnSkipLogin.BackColor = System.Drawing.Color.White;
            this.btnSkipLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSkipLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipLogin.Location = new System.Drawing.Point(107, 508);
            this.btnSkipLogin.Name = "btnSkipLogin";
            this.btnSkipLogin.Size = new System.Drawing.Size(149, 24);
            this.btnSkipLogin.TabIndex = 62;
            this.btnSkipLogin.Text = "Hoppa över inloggningen";
            this.btnSkipLogin.UseVisualStyleBackColor = false;
            this.btnSkipLogin.Click += new System.EventHandler(this.btnSkipLogin_Click);
            // 
            // Inloggning
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnStängav;
            this.ClientSize = new System.Drawing.Size(268, 544);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbLös);
            this.Controls.Add(this.btnSkipLogin);
            this.Controls.Add(this.txbAnvändarnamn);
            this.Controls.Add(this.btnStängav);
            this.Controls.Add(this.lbAnvändarnamn);
            this.Controls.Add(this.lbLös);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inloggning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggning";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStängav;
        private System.Windows.Forms.TextBox txbLös;
        private System.Windows.Forms.TextBox txbAnvändarnamn;
        private System.Windows.Forms.Label lbAnvändarnamn;
        private System.Windows.Forms.Label lbLös;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSkipLogin;
    }
}