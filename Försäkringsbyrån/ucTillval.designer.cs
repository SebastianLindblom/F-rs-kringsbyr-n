namespace Försäkringsbyrån
{
    partial class ucTillval
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TV = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.cbTillvalsDatum = new System.Windows.Forms.ComboBox();
            this.tbTillvalsVariabel = new System.Windows.Forms.TextBox();
            this.lbTillvalsVariabel = new System.Windows.Forms.Label();
            this.tbTillvalsDatum = new System.Windows.Forms.TextBox();
            this.lbLivsförsäkringDatum = new System.Windows.Forms.Label();
            this.tbTillvalsTyp = new System.Windows.Forms.TextBox();
            this.btnTillvalTaBort = new System.Windows.Forms.Button();
            this.tbTillvalsGrundbelopp = new System.Windows.Forms.TextBox();
            this.lbTillvalsTyp = new System.Windows.Forms.Label();
            this.lbLivsförsäkringBelopp = new System.Windows.Forms.Label();
            this.btnAvbrytTillval = new System.Windows.Forms.Button();
            this.DGVTillvalBelopp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVTillvalVariabler = new System.Windows.Forms.DataGridView();
            this.cbTillvalDatumSök = new System.Windows.Forms.ComboBox();
            this.btnTillvalSpara = new System.Windows.Forms.Button();
            this.lbTillvalDatumSök = new System.Windows.Forms.Label();
            this.TVV = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTillvalsvariablerSpara = new System.Windows.Forms.Button();
            this.tbTillvalsvariablerVariabeln = new System.Windows.Forms.TextBox();
            this.lbTillvalsvariablerVariabel = new System.Windows.Forms.Label();
            this.DGVTillvalsvariabler = new System.Windows.Forms.DataGridView();
            this.btnTillvalsvariablerTaBort = new System.Windows.Forms.Button();
            this.tbTillvalsvariablerDatum = new System.Windows.Forms.TextBox();
            this.lbTillvalsvariablerDatum = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TV.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTillvalBelopp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTillvalVariabler)).BeginInit();
            this.TVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTillvalsvariabler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TV);
            this.tabControl1.Controls.Add(this.TVV);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 696);
            this.tabControl1.TabIndex = 302;
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.Color.White;
            this.TV.Controls.Add(this.panel2);
            this.TV.Controls.Add(this.btnAvbrytTillval);
            this.TV.Controls.Add(this.DGVTillvalBelopp);
            this.TV.Controls.Add(this.label1);
            this.TV.Controls.Add(this.DGVTillvalVariabler);
            this.TV.Controls.Add(this.cbTillvalDatumSök);
            this.TV.Controls.Add(this.btnTillvalSpara);
            this.TV.Controls.Add(this.lbTillvalDatumSök);
            this.TV.Location = new System.Drawing.Point(4, 22);
            this.TV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TV.Name = "TV";
            this.TV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TV.Size = new System.Drawing.Size(888, 670);
            this.TV.TabIndex = 0;
            this.TV.Text = "Tillval";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.cbTillvalsDatum);
            this.panel2.Controls.Add(this.tbTillvalsVariabel);
            this.panel2.Controls.Add(this.lbTillvalsVariabel);
            this.panel2.Controls.Add(this.tbTillvalsDatum);
            this.panel2.Controls.Add(this.lbLivsförsäkringDatum);
            this.panel2.Controls.Add(this.tbTillvalsTyp);
            this.panel2.Controls.Add(this.btnTillvalTaBort);
            this.panel2.Controls.Add(this.tbTillvalsGrundbelopp);
            this.panel2.Controls.Add(this.lbTillvalsTyp);
            this.panel2.Controls.Add(this.lbLivsförsäkringBelopp);
            this.panel2.Location = new System.Drawing.Point(10, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 335);
            this.panel2.TabIndex = 302;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 13);
            this.label29.TabIndex = 310;
            this.label29.Text = "Fyll i uppgifter";
            // 
            // cbTillvalsDatum
            // 
            this.cbTillvalsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTillvalsDatum.FormattingEnabled = true;
            this.cbTillvalsDatum.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbTillvalsDatum.Location = new System.Drawing.Point(228, 124);
            this.cbTillvalsDatum.Name = "cbTillvalsDatum";
            this.cbTillvalsDatum.Size = new System.Drawing.Size(100, 21);
            this.cbTillvalsDatum.TabIndex = 298;
            this.cbTillvalsDatum.SelectedIndexChanged += new System.EventHandler(this.cbTillvalsDatum_SelectedIndexChanged);
            // 
            // tbTillvalsVariabel
            // 
            this.tbTillvalsVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTillvalsVariabel.Location = new System.Drawing.Point(123, 201);
            this.tbTillvalsVariabel.Name = "tbTillvalsVariabel";
            this.tbTillvalsVariabel.Size = new System.Drawing.Size(100, 20);
            this.tbTillvalsVariabel.TabIndex = 300;
            // 
            // lbTillvalsVariabel
            // 
            this.lbTillvalsVariabel.AutoSize = true;
            this.lbTillvalsVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTillvalsVariabel.Location = new System.Drawing.Point(42, 203);
            this.lbTillvalsVariabel.Name = "lbTillvalsVariabel";
            this.lbTillvalsVariabel.Size = new System.Drawing.Size(45, 13);
            this.lbTillvalsVariabel.TabIndex = 300;
            this.lbTillvalsVariabel.Text = "Variabel";
            // 
            // tbTillvalsDatum
            // 
            this.tbTillvalsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTillvalsDatum.Location = new System.Drawing.Point(123, 124);
            this.tbTillvalsDatum.Name = "tbTillvalsDatum";
            this.tbTillvalsDatum.Size = new System.Drawing.Size(100, 20);
            this.tbTillvalsDatum.TabIndex = 297;
            // 
            // lbLivsförsäkringDatum
            // 
            this.lbLivsförsäkringDatum.AutoSize = true;
            this.lbLivsförsäkringDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivsförsäkringDatum.Location = new System.Drawing.Point(42, 127);
            this.lbLivsförsäkringDatum.Name = "lbLivsförsäkringDatum";
            this.lbLivsförsäkringDatum.Size = new System.Drawing.Size(38, 13);
            this.lbLivsförsäkringDatum.TabIndex = 298;
            this.lbLivsförsäkringDatum.Text = "Datum";
            // 
            // tbTillvalsTyp
            // 
            this.tbTillvalsTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTillvalsTyp.Location = new System.Drawing.Point(123, 82);
            this.tbTillvalsTyp.Name = "tbTillvalsTyp";
            this.tbTillvalsTyp.Size = new System.Drawing.Size(100, 20);
            this.tbTillvalsTyp.TabIndex = 296;
            // 
            // btnTillvalTaBort
            // 
            this.btnTillvalTaBort.BackColor = System.Drawing.Color.Firebrick;
            this.btnTillvalTaBort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTillvalTaBort.Location = new System.Drawing.Point(228, 300);
            this.btnTillvalTaBort.Name = "btnTillvalTaBort";
            this.btnTillvalTaBort.Size = new System.Drawing.Size(120, 30);
            this.btnTillvalTaBort.TabIndex = 301;
            this.btnTillvalTaBort.Text = "Ta bort";
            this.btnTillvalTaBort.UseVisualStyleBackColor = false;
            this.btnTillvalTaBort.Click += new System.EventHandler(this.btnTillvalTaBort_Click);
            // 
            // tbTillvalsGrundbelopp
            // 
            this.tbTillvalsGrundbelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTillvalsGrundbelopp.Location = new System.Drawing.Point(123, 163);
            this.tbTillvalsGrundbelopp.Name = "tbTillvalsGrundbelopp";
            this.tbTillvalsGrundbelopp.Size = new System.Drawing.Size(100, 20);
            this.tbTillvalsGrundbelopp.TabIndex = 299;
            // 
            // lbTillvalsTyp
            // 
            this.lbTillvalsTyp.AutoSize = true;
            this.lbTillvalsTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTillvalsTyp.Location = new System.Drawing.Point(42, 85);
            this.lbTillvalsTyp.Name = "lbTillvalsTyp";
            this.lbTillvalsTyp.Size = new System.Drawing.Size(53, 13);
            this.lbTillvalsTyp.TabIndex = 252;
            this.lbTillvalsTyp.Text = "Tillvalstyp";
            // 
            // lbLivsförsäkringBelopp
            // 
            this.lbLivsförsäkringBelopp.AutoSize = true;
            this.lbLivsförsäkringBelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivsförsäkringBelopp.Location = new System.Drawing.Point(42, 166);
            this.lbLivsförsäkringBelopp.Name = "lbLivsförsäkringBelopp";
            this.lbLivsförsäkringBelopp.Size = new System.Drawing.Size(68, 13);
            this.lbLivsförsäkringBelopp.TabIndex = 199;
            this.lbLivsförsäkringBelopp.Text = "Grundbelopp";
            // 
            // btnAvbrytTillval
            // 
            this.btnAvbrytTillval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvbrytTillval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvbrytTillval.Location = new System.Drawing.Point(505, 439);
            this.btnAvbrytTillval.Name = "btnAvbrytTillval";
            this.btnAvbrytTillval.Size = new System.Drawing.Size(120, 30);
            this.btnAvbrytTillval.TabIndex = 305;
            this.btnAvbrytTillval.Text = "Rensa alla fält";
            this.btnAvbrytTillval.UseVisualStyleBackColor = true;
            this.btnAvbrytTillval.Click += new System.EventHandler(this.btnAvbrytTillval_Click);
            // 
            // DGVTillvalBelopp
            // 
            this.DGVTillvalBelopp.BackgroundColor = System.Drawing.Color.White;
            this.DGVTillvalBelopp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTillvalBelopp.Location = new System.Drawing.Point(379, 99);
            this.DGVTillvalBelopp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVTillvalBelopp.Name = "DGVTillvalBelopp";
            this.DGVTillvalBelopp.RowTemplate.Height = 24;
            this.DGVTillvalBelopp.Size = new System.Drawing.Size(277, 335);
            this.DGVTillvalBelopp.TabIndex = 309;
            this.DGVTillvalBelopp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVTillvalBelopp_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 256;
            this.label1.Text = "Lägg till eller redigera tillval";
            // 
            // DGVTillvalVariabler
            // 
            this.DGVTillvalVariabler.BackgroundColor = System.Drawing.Color.White;
            this.DGVTillvalVariabler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTillvalVariabler.Location = new System.Drawing.Point(672, 98);
            this.DGVTillvalVariabler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVTillvalVariabler.Name = "DGVTillvalVariabler";
            this.DGVTillvalVariabler.RowTemplate.Height = 24;
            this.DGVTillvalVariabler.Size = new System.Drawing.Size(184, 336);
            this.DGVTillvalVariabler.TabIndex = 308;
            this.DGVTillvalVariabler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVTillvalVariabler_RowHeaderMouseClick);
            // 
            // cbTillvalDatumSök
            // 
            this.cbTillvalDatumSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTillvalDatumSök.FormattingEnabled = true;
            this.cbTillvalDatumSök.Location = new System.Drawing.Point(421, 73);
            this.cbTillvalDatumSök.Name = "cbTillvalDatumSök";
            this.cbTillvalDatumSök.Size = new System.Drawing.Size(100, 21);
            this.cbTillvalDatumSök.TabIndex = 303;
            // 
            // btnTillvalSpara
            // 
            this.btnTillvalSpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTillvalSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillvalSpara.Location = new System.Drawing.Point(379, 439);
            this.btnTillvalSpara.Name = "btnTillvalSpara";
            this.btnTillvalSpara.Size = new System.Drawing.Size(120, 30);
            this.btnTillvalSpara.TabIndex = 304;
            this.btnTillvalSpara.Text = "Spara";
            this.btnTillvalSpara.UseVisualStyleBackColor = true;
            this.btnTillvalSpara.Click += new System.EventHandler(this.btnTillvalSpara_Click);
            // 
            // lbTillvalDatumSök
            // 
            this.lbTillvalDatumSök.AutoSize = true;
            this.lbTillvalDatumSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTillvalDatumSök.Location = new System.Drawing.Point(378, 79);
            this.lbTillvalDatumSök.Name = "lbTillvalDatumSök";
            this.lbTillvalDatumSök.Size = new System.Drawing.Size(38, 13);
            this.lbTillvalDatumSök.TabIndex = 305;
            this.lbTillvalDatumSök.Text = "Datum";
            // 
            // TVV
            // 
            this.TVV.BackColor = System.Drawing.Color.White;
            this.TVV.Controls.Add(this.label2);
            this.TVV.Controls.Add(this.btnTillvalsvariablerSpara);
            this.TVV.Controls.Add(this.tbTillvalsvariablerVariabeln);
            this.TVV.Controls.Add(this.lbTillvalsvariablerVariabel);
            this.TVV.Controls.Add(this.DGVTillvalsvariabler);
            this.TVV.Controls.Add(this.btnTillvalsvariablerTaBort);
            this.TVV.Controls.Add(this.tbTillvalsvariablerDatum);
            this.TVV.Controls.Add(this.lbTillvalsvariablerDatum);
            this.TVV.Location = new System.Drawing.Point(4, 22);
            this.TVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TVV.Name = "TVV";
            this.TVV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TVV.Size = new System.Drawing.Size(876, 540);
            this.TVV.TabIndex = 1;
            this.TVV.Text = "Tillvalsvariabler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 311;
            this.label2.Text = "Tillvalsvariabler";
            // 
            // btnTillvalsvariablerSpara
            // 
            this.btnTillvalsvariablerSpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTillvalsvariablerSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillvalsvariablerSpara.Location = new System.Drawing.Point(231, 466);
            this.btnTillvalsvariablerSpara.Name = "btnTillvalsvariablerSpara";
            this.btnTillvalsvariablerSpara.Size = new System.Drawing.Size(120, 30);
            this.btnTillvalsvariablerSpara.TabIndex = 307;
            this.btnTillvalsvariablerSpara.Text = "Spara";
            this.btnTillvalsvariablerSpara.UseVisualStyleBackColor = true;
            this.btnTillvalsvariablerSpara.Click += new System.EventHandler(this.btnTillvalsvariablerSpara_Click);
            // 
            // tbTillvalsvariablerVariabeln
            // 
            this.tbTillvalsvariablerVariabeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTillvalsvariablerVariabeln.Location = new System.Drawing.Point(21, 179);
            this.tbTillvalsvariablerVariabeln.Name = "tbTillvalsvariablerVariabeln";
            this.tbTillvalsvariablerVariabeln.Size = new System.Drawing.Size(165, 20);
            this.tbTillvalsvariablerVariabeln.TabIndex = 305;
            // 
            // lbTillvalsvariablerVariabel
            // 
            this.lbTillvalsvariablerVariabel.AutoSize = true;
            this.lbTillvalsvariablerVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTillvalsvariablerVariabel.Location = new System.Drawing.Point(18, 163);
            this.lbTillvalsvariablerVariabel.Name = "lbTillvalsvariablerVariabel";
            this.lbTillvalsvariablerVariabel.Size = new System.Drawing.Size(45, 13);
            this.lbTillvalsvariablerVariabel.TabIndex = 309;
            this.lbTillvalsvariablerVariabel.Text = "Variabel";
            // 
            // DGVTillvalsvariabler
            // 
            this.DGVTillvalsvariabler.BackgroundColor = System.Drawing.Color.White;
            this.DGVTillvalsvariabler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTillvalsvariabler.Location = new System.Drawing.Point(231, 131);
            this.DGVTillvalsvariabler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVTillvalsvariabler.Name = "DGVTillvalsvariabler";
            this.DGVTillvalsvariabler.RowTemplate.Height = 24;
            this.DGVTillvalsvariabler.Size = new System.Drawing.Size(346, 331);
            this.DGVTillvalsvariabler.TabIndex = 308;
            this.DGVTillvalsvariabler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVTillvalsvariabler_RowHeaderMouseClick);
            // 
            // btnTillvalsvariablerTaBort
            // 
            this.btnTillvalsvariablerTaBort.BackColor = System.Drawing.Color.Firebrick;
            this.btnTillvalsvariablerTaBort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTillvalsvariablerTaBort.Location = new System.Drawing.Point(63, 226);
            this.btnTillvalsvariablerTaBort.Name = "btnTillvalsvariablerTaBort";
            this.btnTillvalsvariablerTaBort.Size = new System.Drawing.Size(122, 30);
            this.btnTillvalsvariablerTaBort.TabIndex = 306;
            this.btnTillvalsvariablerTaBort.Text = "Ta bort";
            this.btnTillvalsvariablerTaBort.UseVisualStyleBackColor = false;
            this.btnTillvalsvariablerTaBort.Click += new System.EventHandler(this.btnTillvalsvariablerTaBort_Click);
            // 
            // tbTillvalsvariablerDatum
            // 
            this.tbTillvalsvariablerDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTillvalsvariablerDatum.Location = new System.Drawing.Point(21, 131);
            this.tbTillvalsvariablerDatum.Name = "tbTillvalsvariablerDatum";
            this.tbTillvalsvariablerDatum.Size = new System.Drawing.Size(165, 20);
            this.tbTillvalsvariablerDatum.TabIndex = 304;
            // 
            // lbTillvalsvariablerDatum
            // 
            this.lbTillvalsvariablerDatum.AutoSize = true;
            this.lbTillvalsvariablerDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTillvalsvariablerDatum.Location = new System.Drawing.Point(18, 115);
            this.lbTillvalsvariablerDatum.Name = "lbTillvalsvariablerDatum";
            this.lbTillvalsvariablerDatum.Size = new System.Drawing.Size(38, 13);
            this.lbTillvalsvariablerDatum.TabIndex = 305;
            this.lbTillvalsvariablerDatum.Text = "Datum";
            // 
            // ucTillval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "ucTillval";
            this.Size = new System.Drawing.Size(900, 700);
            this.tabControl1.ResumeLayout(false);
            this.TV.ResumeLayout(false);
            this.TV.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTillvalBelopp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTillvalVariabler)).EndInit();
            this.TVV.ResumeLayout(false);
            this.TVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTillvalsvariabler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTillvalsDatum;
        private System.Windows.Forms.TextBox tbTillvalsVariabel;
        private System.Windows.Forms.Label lbTillvalsVariabel;
        private System.Windows.Forms.TextBox tbTillvalsDatum;
        private System.Windows.Forms.Label lbLivsförsäkringDatum;
        private System.Windows.Forms.TextBox tbTillvalsTyp;
        private System.Windows.Forms.Button btnTillvalTaBort;
        private System.Windows.Forms.TextBox tbTillvalsGrundbelopp;
        private System.Windows.Forms.Label lbTillvalsTyp;
        private System.Windows.Forms.Label lbLivsförsäkringBelopp;
        private System.Windows.Forms.Button btnAvbrytTillval;
        private System.Windows.Forms.DataGridView DGVTillvalBelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVTillvalVariabler;
        private System.Windows.Forms.ComboBox cbTillvalDatumSök;
        private System.Windows.Forms.Button btnTillvalSpara;
        private System.Windows.Forms.Label lbTillvalDatumSök;
        private System.Windows.Forms.TabPage TVV;
        private System.Windows.Forms.Button btnTillvalsvariablerSpara;
        private System.Windows.Forms.TextBox tbTillvalsvariablerVariabeln;
        private System.Windows.Forms.Label lbTillvalsvariablerVariabel;
        private System.Windows.Forms.DataGridView DGVTillvalsvariabler;
        private System.Windows.Forms.Button btnTillvalsvariablerTaBort;
        private System.Windows.Forms.TextBox tbTillvalsvariablerDatum;
        private System.Windows.Forms.Label lbTillvalsvariablerDatum;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label2;

    }
}
