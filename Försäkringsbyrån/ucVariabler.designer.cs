namespace Försäkringsbyrån
{
    partial class ucVariabler
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbSökår = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTabort = new System.Windows.Forms.Button();
            this.cbÅr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTyp = new System.Windows.Forms.TextBox();
            this.tbVariabel = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 307;
            this.label5.Text = "År";
            // 
            // cbSökår
            // 
            this.cbSökår.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSökår.FormattingEnabled = true;
            this.cbSökår.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbSökår.Location = new System.Drawing.Point(283, 84);
            this.cbSökår.Name = "cbSökår";
            this.cbSökår.Size = new System.Drawing.Size(100, 21);
            this.cbSökår.TabIndex = 306;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(346, 331);
            this.dataGridView1.TabIndex = 305;
            // 
            // btnTabort
            // 
            this.btnTabort.BackColor = System.Drawing.Color.Firebrick;
            this.btnTabort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTabort.Location = new System.Drawing.Point(118, 378);
            this.btnTabort.Name = "btnTabort";
            this.btnTabort.Size = new System.Drawing.Size(122, 30);
            this.btnTabort.TabIndex = 304;
            this.btnTabort.Text = "Ta bort";
            this.btnTabort.UseVisualStyleBackColor = false;
            // 
            // cbÅr
            // 
            this.cbÅr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbÅr.FormattingEnabled = true;
            this.cbÅr.Items.AddRange(new object[] {
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cbÅr.Location = new System.Drawing.Point(17, 159);
            this.cbÅr.Name = "cbÅr";
            this.cbÅr.Size = new System.Drawing.Size(165, 21);
            this.cbÅr.TabIndex = 299;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 301;
            this.label6.Text = "Variabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 302;
            this.label10.Text = "År";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 303;
            this.label7.Text = "Typ av variabel";
            // 
            // tbTyp
            // 
            this.tbTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTyp.Location = new System.Drawing.Point(17, 110);
            this.tbTyp.Name = "tbTyp";
            this.tbTyp.Size = new System.Drawing.Size(165, 20);
            this.tbTyp.TabIndex = 300;
            // 
            // tbVariabel
            // 
            this.tbVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVariabel.Location = new System.Drawing.Point(17, 215);
            this.tbVariabel.Name = "tbVariabel";
            this.tbVariabel.Size = new System.Drawing.Size(165, 20);
            this.tbVariabel.TabIndex = 308;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvbryt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvbryt.Location = new System.Drawing.Point(381, 445);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(120, 30);
            this.btnAvbryt.TabIndex = 310;
            this.btnAvbryt.Text = "Rensa alla fält";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpara.Location = new System.Drawing.Point(258, 445);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(121, 30);
            this.btnSpara.TabIndex = 309;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAvbryt);
            this.panel2.Controls.Add(this.tbTyp);
            this.panel2.Controls.Add(this.btnSpara);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbVariabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbSökår);
            this.panel2.Controls.Add(this.cbÅr);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnTabort);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 694);
            this.panel2.TabIndex = 311;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 312;
            this.label2.Text = "Variabler";
            // 
            // ucVariabler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "ucVariabler";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSökår;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTabort;
        private System.Windows.Forms.ComboBox cbÅr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTyp;
        private System.Windows.Forms.TextBox tbVariabel;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}
