namespace Försäkringsbyrån
{
    partial class ucBehörighet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbRoll = new System.Windows.Forms.TextBox();
            this.tbOmråde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOmråde = new System.Windows.Forms.Label();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSparaAnv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 250);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tbRoll
            // 
            this.tbRoll.Location = new System.Drawing.Point(281, 80);
            this.tbRoll.Name = "tbRoll";
            this.tbRoll.Size = new System.Drawing.Size(165, 20);
            this.tbRoll.TabIndex = 5;
            // 
            // tbOmråde
            // 
            this.tbOmråde.Location = new System.Drawing.Point(281, 131);
            this.tbOmråde.Name = "tbOmråde";
            this.tbOmråde.Size = new System.Drawing.Size(165, 20);
            this.tbOmråde.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Befattning";
            // 
            // lbOmråde
            // 
            this.lbOmråde.AutoSize = true;
            this.lbOmråde.Location = new System.Drawing.Point(278, 115);
            this.lbOmråde.Name = "lbOmråde";
            this.lbOmråde.Size = new System.Drawing.Size(44, 13);
            this.lbOmråde.TabIndex = 8;
            this.lbOmråde.Text = "Område";
            // 
            // btnTaBort
            // 
            this.btnTaBort.BackColor = System.Drawing.Color.Firebrick;
            this.btnTaBort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaBort.Location = new System.Drawing.Point(280, 168);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(120, 30);
            this.btnTaBort.TabIndex = 293;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = false;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 294;
            this.label12.Text = "Behörigheter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSparaAnv);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.tbRoll);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbOmråde);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnTaBort);
            this.panel2.Controls.Add(this.lbOmråde);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 694);
            this.panel2.TabIndex = 295;
            // 
            // btnSparaAnv
            // 
            this.btnSparaAnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSparaAnv.Location = new System.Drawing.Point(406, 168);
            this.btnSparaAnv.Name = "btnSparaAnv";
            this.btnSparaAnv.Size = new System.Drawing.Size(120, 30);
            this.btnSparaAnv.TabIndex = 295;
            this.btnSparaAnv.Text = "Spara";
            this.btnSparaAnv.UseVisualStyleBackColor = true;
            this.btnSparaAnv.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // ucBehörighet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "ucBehörighet";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbRoll;
        private System.Windows.Forms.TextBox tbOmråde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOmråde;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSparaAnv;
    }
}
