namespace Försäkringsbyrån
{
    partial class ucProspekt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkrivutKp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 255;
            this.label1.Text = "Utskrift av kundprospekt";
            // 
            // btnSkrivutKp
            // 
            this.btnSkrivutKp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkrivutKp.Location = new System.Drawing.Point(22, 71);
            this.btnSkrivutKp.Name = "btnSkrivutKp";
            this.btnSkrivutKp.Size = new System.Drawing.Size(179, 50);
            this.btnSkrivutKp.TabIndex = 253;
            this.btnSkrivutKp.Text = "Skriv ut alla kundprospekt";
            this.btnSkrivutKp.UseVisualStyleBackColor = true;
            this.btnSkrivutKp.Click += new System.EventHandler(this.btnSkrivutKp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSkrivutKp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 694);
            this.panel1.TabIndex = 256;
            // 
            // ucProspekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucProspekt";
            this.Size = new System.Drawing.Size(900, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkrivutKp;
        private System.Windows.Forms.Panel panel1;
    }
}
