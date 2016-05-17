namespace Försäkringsbyrån
{
    partial class ucFörsäkringstyper
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
            this.SO = new System.Windows.Forms.TabPage();
            this.btnTabort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSökår = new System.Windows.Forms.ComboBox();
            this.DGVGrundbeloppackvärde = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.plGrundbelopp = new System.Windows.Forms.Panel();
            this.cbGrundbeloppAckvärdeÅr = new System.Windows.Forms.ComboBox();
            this.tbGrundbeloppAckvärdeBelopp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGrundbeloppAckvärdeVärde = new System.Windows.Forms.TextBox();
            this.cbFörsäkringstyp = new System.Windows.Forms.ComboBox();
            this.btnAvbrytGrundbelopp = new System.Windows.Forms.Button();
            this.btnSparaGrundbelopp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LIV = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVLivsförsäkringarBelopp = new System.Windows.Forms.DataGridView();
            this.DGVLivförsäkringarVariabler = new System.Windows.Forms.DataGridView();
            this.btnLivsförsäkringSpara = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbLivsförsäkringVariabel = new System.Windows.Forms.TextBox();
            this.lbLivsförsäkringVariabel = new System.Windows.Forms.Label();
            this.tbLivsförsäkringDatum = new System.Windows.Forms.TextBox();
            this.lbLivsförsäkringDatum = new System.Windows.Forms.Label();
            this.tbLivsförsäkringTyp = new System.Windows.Forms.TextBox();
            this.btnLivsförsäkringTaBort = new System.Windows.Forms.Button();
            this.tbLivsförsäkringGrundbelopp = new System.Windows.Forms.TextBox();
            this.lbLivsförsäkringTyp = new System.Windows.Forms.Label();
            this.lbLivsförsäkringBelopp = new System.Windows.Forms.Label();
            this.lbLivsförsäkringDatumSök = new System.Windows.Forms.Label();
            this.cbLivsförsäkringDatumSök = new System.Windows.Forms.ComboBox();
            this.VAR = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVariabelSpara = new System.Windows.Forms.Button();
            this.tbVariabelVariabeln = new System.Windows.Forms.TextBox();
            this.lbVariabelVariabel = new System.Windows.Forms.Label();
            this.DGVVariablel = new System.Windows.Forms.DataGridView();
            this.btnVariabelTaBort = new System.Windows.Forms.Button();
            this.tbVariabelDatum = new System.Windows.Forms.TextBox();
            this.lbVariabelDatum = new System.Windows.Forms.Label();
            this.SO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrundbeloppackvärde)).BeginInit();
            this.plGrundbelopp.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivsförsäkringarBelopp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivförsäkringarVariabler)).BeginInit();
            this.panel1.SuspendLayout();
            this.VAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVariablel)).BeginInit();
            this.SuspendLayout();
            // 
            // SO
            // 
            this.SO.BackColor = System.Drawing.Color.White;
            this.SO.Controls.Add(this.btnTabort);
            this.SO.Controls.Add(this.label5);
            this.SO.Controls.Add(this.cbSökår);
            this.SO.Controls.Add(this.DGVGrundbeloppackvärde);
            this.SO.Controls.Add(this.label4);
            this.SO.Controls.Add(this.plGrundbelopp);
            this.SO.Controls.Add(this.btnAvbrytGrundbelopp);
            this.SO.Controls.Add(this.btnSparaGrundbelopp);
            this.SO.Controls.Add(this.label1);
            this.SO.Location = new System.Drawing.Point(4, 25);
            this.SO.Name = "SO";
            this.SO.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.SO.Size = new System.Drawing.Size(888, 671);
            this.SO.TabIndex = 0;
            this.SO.Text = "Sjuk- och olycksfall";
            this.SO.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnTabort
            // 
            this.btnTabort.BackColor = System.Drawing.Color.Firebrick;
            this.btnTabort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTabort.Location = new System.Drawing.Point(237, 467);
            this.btnTabort.Name = "btnTabort";
            this.btnTabort.Size = new System.Drawing.Size(120, 30);
            this.btnTabort.TabIndex = 158;
            this.btnTabort.Text = "Ta bort";
            this.btnTabort.UseVisualStyleBackColor = false;
            this.btnTabort.Click += new System.EventHandler(this.btnTabort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 294;
            this.label5.Text = "År";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.cbSökår.Location = new System.Drawing.Point(407, 104);
            this.cbSökår.Name = "cbSökår";
            this.cbSökår.Size = new System.Drawing.Size(100, 21);
            this.cbSökår.TabIndex = 160;
            this.cbSökår.SelectedIndexChanged += new System.EventHandler(this.cbSökår_SelectedIndexChanged);
            // 
            // DGVGrundbeloppackvärde
            // 
            this.DGVGrundbeloppackvärde.BackgroundColor = System.Drawing.Color.White;
            this.DGVGrundbeloppackvärde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGrundbeloppackvärde.Location = new System.Drawing.Point(385, 130);
            this.DGVGrundbeloppackvärde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVGrundbeloppackvärde.Name = "DGVGrundbeloppackvärde";
            this.DGVGrundbeloppackvärde.RowTemplate.Height = 24;
            this.DGVGrundbeloppackvärde.Size = new System.Drawing.Size(346, 331);
            this.DGVGrundbeloppackvärde.TabIndex = 282;
            this.DGVGrundbeloppackvärde.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 281;
            this.label4.Text = "Fyll i uppgifter";
            // 
            // plGrundbelopp
            // 
            this.plGrundbelopp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plGrundbelopp.Controls.Add(this.cbGrundbeloppAckvärdeÅr);
            this.plGrundbelopp.Controls.Add(this.tbGrundbeloppAckvärdeBelopp);
            this.plGrundbelopp.Controls.Add(this.label2);
            this.plGrundbelopp.Controls.Add(this.label10);
            this.plGrundbelopp.Controls.Add(this.label8);
            this.plGrundbelopp.Controls.Add(this.label7);
            this.plGrundbelopp.Controls.Add(this.tbGrundbeloppAckvärdeVärde);
            this.plGrundbelopp.Controls.Add(this.cbFörsäkringstyp);
            this.plGrundbelopp.Location = new System.Drawing.Point(22, 130);
            this.plGrundbelopp.Name = "plGrundbelopp";
            this.plGrundbelopp.Size = new System.Drawing.Size(336, 331);
            this.plGrundbelopp.TabIndex = 159;
            // 
            // cbGrundbeloppAckvärdeÅr
            // 
            this.cbGrundbeloppAckvärdeÅr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrundbeloppAckvärdeÅr.FormattingEnabled = true;
            this.cbGrundbeloppAckvärdeÅr.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbGrundbeloppAckvärdeÅr.Location = new System.Drawing.Point(123, 113);
            this.cbGrundbeloppAckvärdeÅr.Name = "cbGrundbeloppAckvärdeÅr";
            this.cbGrundbeloppAckvärdeÅr.Size = new System.Drawing.Size(100, 21);
            this.cbGrundbeloppAckvärdeÅr.TabIndex = 155;
            // 
            // tbGrundbeloppAckvärdeBelopp
            // 
            this.tbGrundbeloppAckvärdeBelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrundbeloppAckvärdeBelopp.Location = new System.Drawing.Point(123, 149);
            this.tbGrundbeloppAckvärdeBelopp.Name = "tbGrundbeloppAckvärdeBelopp";
            this.tbGrundbeloppAckvärdeBelopp.Size = new System.Drawing.Size(100, 20);
            this.tbGrundbeloppAckvärdeBelopp.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 252;
            this.label2.Text = "Försäkringstyp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 197;
            this.label10.Text = "År";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 199;
            this.label8.Text = "Grundbelopp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 200;
            this.label7.Text = "Ack.Värde";
            // 
            // tbGrundbeloppAckvärdeVärde
            // 
            this.tbGrundbeloppAckvärdeVärde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrundbeloppAckvärdeVärde.Location = new System.Drawing.Point(123, 185);
            this.tbGrundbeloppAckvärdeVärde.Name = "tbGrundbeloppAckvärdeVärde";
            this.tbGrundbeloppAckvärdeVärde.Size = new System.Drawing.Size(100, 20);
            this.tbGrundbeloppAckvärdeVärde.TabIndex = 157;
            // 
            // cbFörsäkringstyp
            // 
            this.cbFörsäkringstyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFörsäkringstyp.FormattingEnabled = true;
            this.cbFörsäkringstyp.Items.AddRange(new object[] {
            "Sjuk- och olycksfall för barn (t.o.m. 17 år)",
            "Sjuk- och olycksfall för vuxen"});
            this.cbFörsäkringstyp.Location = new System.Drawing.Point(123, 76);
            this.cbFörsäkringstyp.Name = "cbFörsäkringstyp";
            this.cbFörsäkringstyp.Size = new System.Drawing.Size(183, 21);
            this.cbFörsäkringstyp.TabIndex = 154;
            // 
            // btnAvbrytGrundbelopp
            // 
            this.btnAvbrytGrundbelopp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvbrytGrundbelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvbrytGrundbelopp.Location = new System.Drawing.Point(512, 466);
            this.btnAvbrytGrundbelopp.Name = "btnAvbrytGrundbelopp";
            this.btnAvbrytGrundbelopp.Size = new System.Drawing.Size(120, 30);
            this.btnAvbrytGrundbelopp.TabIndex = 162;
            this.btnAvbrytGrundbelopp.Text = "Rensa alla fält";
            this.btnAvbrytGrundbelopp.UseVisualStyleBackColor = true;
            this.btnAvbrytGrundbelopp.Click += new System.EventHandler(this.btnAvbrytGrundbelopp_Click_1);
            // 
            // btnSparaGrundbelopp
            // 
            this.btnSparaGrundbelopp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSparaGrundbelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaGrundbelopp.Location = new System.Drawing.Point(386, 466);
            this.btnSparaGrundbelopp.Name = "btnSparaGrundbelopp";
            this.btnSparaGrundbelopp.Size = new System.Drawing.Size(120, 30);
            this.btnSparaGrundbelopp.TabIndex = 161;
            this.btnSparaGrundbelopp.Text = "Spara";
            this.btnSparaGrundbelopp.UseVisualStyleBackColor = true;
            this.btnSparaGrundbelopp.Click += new System.EventHandler(this.btnSparaGrundbelopp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 20);
            this.label1.TabIndex = 270;
            this.label1.Text = "Lägg till eller redigera Grundbelopp och Ack.värde";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SO);
            this.tabControl1.Controls.Add(this.LIV);
            this.tabControl1.Controls.Add(this.VAR);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // LIV
            // 
            this.LIV.Controls.Add(this.label9);
            this.LIV.Controls.Add(this.DGVLivsförsäkringarBelopp);
            this.LIV.Controls.Add(this.DGVLivförsäkringarVariabler);
            this.LIV.Controls.Add(this.btnLivsförsäkringSpara);
            this.LIV.Controls.Add(this.label6);
            this.LIV.Controls.Add(this.panel1);
            this.LIV.Controls.Add(this.lbLivsförsäkringDatumSök);
            this.LIV.Controls.Add(this.cbLivsförsäkringDatumSök);
            this.LIV.Location = new System.Drawing.Point(4, 25);
            this.LIV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LIV.Name = "LIV";
            this.LIV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LIV.Size = new System.Drawing.Size(888, 671);
            this.LIV.TabIndex = 2;
            this.LIV.Text = "Livsförsäkringar";
            this.LIV.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 303;
            this.label9.Text = "Livsförsäkring";
            // 
            // DGVLivsförsäkringarBelopp
            // 
            this.DGVLivsförsäkringarBelopp.BackgroundColor = System.Drawing.Color.White;
            this.DGVLivsförsäkringarBelopp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLivsförsäkringarBelopp.Location = new System.Drawing.Point(385, 83);
            this.DGVLivsförsäkringarBelopp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVLivsförsäkringarBelopp.Name = "DGVLivsförsäkringarBelopp";
            this.DGVLivsförsäkringarBelopp.RowTemplate.Height = 24;
            this.DGVLivsförsäkringarBelopp.Size = new System.Drawing.Size(277, 330);
            this.DGVLivsförsäkringarBelopp.TabIndex = 302;
            this.DGVLivsförsäkringarBelopp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVLivsförsäkringarBelopp_RowHeaderMouseClick);
            // 
            // DGVLivförsäkringarVariabler
            // 
            this.DGVLivförsäkringarVariabler.BackgroundColor = System.Drawing.Color.White;
            this.DGVLivförsäkringarVariabler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLivförsäkringarVariabler.Location = new System.Drawing.Point(678, 82);
            this.DGVLivförsäkringarVariabler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVLivförsäkringarVariabler.Name = "DGVLivförsäkringarVariabler";
            this.DGVLivförsäkringarVariabler.RowTemplate.Height = 24;
            this.DGVLivförsäkringarVariabler.Size = new System.Drawing.Size(206, 331);
            this.DGVLivförsäkringarVariabler.TabIndex = 301;
            this.DGVLivförsäkringarVariabler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVLivförsäkringarVariabler_RowHeaderMouseClick);
            // 
            // btnLivsförsäkringSpara
            // 
            this.btnLivsförsäkringSpara.BackColor = System.Drawing.Color.White;
            this.btnLivsförsäkringSpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivsförsäkringSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivsförsäkringSpara.Location = new System.Drawing.Point(542, 417);
            this.btnLivsförsäkringSpara.Name = "btnLivsförsäkringSpara";
            this.btnLivsförsäkringSpara.Size = new System.Drawing.Size(120, 30);
            this.btnLivsförsäkringSpara.TabIndex = 304;
            this.btnLivsförsäkringSpara.Text = "Spara";
            this.btnLivsförsäkringSpara.UseVisualStyleBackColor = false;
            this.btnLivsförsäkringSpara.Click += new System.EventHandler(this.btnLivsförsäkringSpara_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 296;
            this.label6.Text = "Fyll i uppgifter";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbLivsförsäkringVariabel);
            this.panel1.Controls.Add(this.lbLivsförsäkringVariabel);
            this.panel1.Controls.Add(this.tbLivsförsäkringDatum);
            this.panel1.Controls.Add(this.lbLivsförsäkringDatum);
            this.panel1.Controls.Add(this.tbLivsförsäkringTyp);
            this.panel1.Controls.Add(this.btnLivsförsäkringTaBort);
            this.panel1.Controls.Add(this.tbLivsförsäkringGrundbelopp);
            this.panel1.Controls.Add(this.lbLivsförsäkringTyp);
            this.panel1.Controls.Add(this.lbLivsförsäkringBelopp);
            this.panel1.Location = new System.Drawing.Point(22, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 331);
            this.panel1.TabIndex = 302;
            // 
            // tbLivsförsäkringVariabel
            // 
            this.tbLivsförsäkringVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLivsförsäkringVariabel.Location = new System.Drawing.Point(123, 201);
            this.tbLivsförsäkringVariabel.Name = "tbLivsförsäkringVariabel";
            this.tbLivsförsäkringVariabel.Size = new System.Drawing.Size(100, 20);
            this.tbLivsförsäkringVariabel.TabIndex = 300;
            // 
            // lbLivsförsäkringVariabel
            // 
            this.lbLivsförsäkringVariabel.AutoSize = true;
            this.lbLivsförsäkringVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivsförsäkringVariabel.Location = new System.Drawing.Point(42, 203);
            this.lbLivsförsäkringVariabel.Name = "lbLivsförsäkringVariabel";
            this.lbLivsförsäkringVariabel.Size = new System.Drawing.Size(45, 13);
            this.lbLivsförsäkringVariabel.TabIndex = 300;
            this.lbLivsförsäkringVariabel.Text = "Variabel";
            // 
            // tbLivsförsäkringDatum
            // 
            this.tbLivsförsäkringDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLivsförsäkringDatum.Location = new System.Drawing.Point(123, 124);
            this.tbLivsförsäkringDatum.Name = "tbLivsförsäkringDatum";
            this.tbLivsförsäkringDatum.Size = new System.Drawing.Size(100, 20);
            this.tbLivsförsäkringDatum.TabIndex = 297;
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
            // tbLivsförsäkringTyp
            // 
            this.tbLivsförsäkringTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLivsförsäkringTyp.Location = new System.Drawing.Point(123, 82);
            this.tbLivsförsäkringTyp.Name = "tbLivsförsäkringTyp";
            this.tbLivsförsäkringTyp.Size = new System.Drawing.Size(100, 20);
            this.tbLivsförsäkringTyp.TabIndex = 296;
            // 
            // btnLivsförsäkringTaBort
            // 
            this.btnLivsförsäkringTaBort.BackColor = System.Drawing.Color.Firebrick;
            this.btnLivsförsäkringTaBort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLivsförsäkringTaBort.Location = new System.Drawing.Point(211, 296);
            this.btnLivsförsäkringTaBort.Name = "btnLivsförsäkringTaBort";
            this.btnLivsförsäkringTaBort.Size = new System.Drawing.Size(120, 30);
            this.btnLivsförsäkringTaBort.TabIndex = 301;
            this.btnLivsförsäkringTaBort.Text = "Ta bort";
            this.btnLivsförsäkringTaBort.UseVisualStyleBackColor = false;
            this.btnLivsförsäkringTaBort.Click += new System.EventHandler(this.btnLivsförsäkringTaBort_Click);
            // 
            // tbLivsförsäkringGrundbelopp
            // 
            this.tbLivsförsäkringGrundbelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLivsförsäkringGrundbelopp.Location = new System.Drawing.Point(123, 163);
            this.tbLivsförsäkringGrundbelopp.Name = "tbLivsförsäkringGrundbelopp";
            this.tbLivsförsäkringGrundbelopp.Size = new System.Drawing.Size(100, 20);
            this.tbLivsförsäkringGrundbelopp.TabIndex = 299;
            // 
            // lbLivsförsäkringTyp
            // 
            this.lbLivsförsäkringTyp.AutoSize = true;
            this.lbLivsförsäkringTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivsförsäkringTyp.Location = new System.Drawing.Point(42, 85);
            this.lbLivsförsäkringTyp.Name = "lbLivsförsäkringTyp";
            this.lbLivsförsäkringTyp.Size = new System.Drawing.Size(75, 13);
            this.lbLivsförsäkringTyp.TabIndex = 252;
            this.lbLivsförsäkringTyp.Text = "Försäkringstyp";
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
            // lbLivsförsäkringDatumSök
            // 
            this.lbLivsförsäkringDatumSök.AutoSize = true;
            this.lbLivsförsäkringDatumSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivsförsäkringDatumSök.Location = new System.Drawing.Point(382, 63);
            this.lbLivsförsäkringDatumSök.Name = "lbLivsförsäkringDatumSök";
            this.lbLivsförsäkringDatumSök.Size = new System.Drawing.Size(38, 13);
            this.lbLivsförsäkringDatumSök.TabIndex = 298;
            this.lbLivsförsäkringDatumSök.Text = "Datum";
            // 
            // cbLivsförsäkringDatumSök
            // 
            this.cbLivsförsäkringDatumSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLivsförsäkringDatumSök.FormattingEnabled = true;
            this.cbLivsförsäkringDatumSök.Location = new System.Drawing.Point(425, 57);
            this.cbLivsförsäkringDatumSök.Name = "cbLivsförsäkringDatumSök";
            this.cbLivsförsäkringDatumSök.Size = new System.Drawing.Size(100, 21);
            this.cbLivsförsäkringDatumSök.TabIndex = 303;
            this.cbLivsförsäkringDatumSök.SelectedIndexChanged += new System.EventHandler(this.cbLivsförsäkringDatumSök_SelectedIndexChanged);
            // 
            // VAR
            // 
            this.VAR.Controls.Add(this.label3);
            this.VAR.Controls.Add(this.btnVariabelSpara);
            this.VAR.Controls.Add(this.tbVariabelVariabeln);
            this.VAR.Controls.Add(this.lbVariabelVariabel);
            this.VAR.Controls.Add(this.DGVVariablel);
            this.VAR.Controls.Add(this.btnVariabelTaBort);
            this.VAR.Controls.Add(this.tbVariabelDatum);
            this.VAR.Controls.Add(this.lbVariabelDatum);
            this.VAR.Location = new System.Drawing.Point(4, 25);
            this.VAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VAR.Name = "VAR";
            this.VAR.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VAR.Size = new System.Drawing.Size(888, 671);
            this.VAR.TabIndex = 3;
            this.VAR.Text = "Variabel";
            this.VAR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 304;
            this.label3.Text = "Variabel";
            // 
            // btnVariabelSpara
            // 
            this.btnVariabelSpara.BackColor = System.Drawing.Color.White;
            this.btnVariabelSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariabelSpara.Location = new System.Drawing.Point(231, 466);
            this.btnVariabelSpara.Name = "btnVariabelSpara";
            this.btnVariabelSpara.Size = new System.Drawing.Size(120, 30);
            this.btnVariabelSpara.TabIndex = 298;
            this.btnVariabelSpara.Text = "Spara";
            this.btnVariabelSpara.UseVisualStyleBackColor = false;
            this.btnVariabelSpara.Click += new System.EventHandler(this.btnVariabelSpara_Click);
            // 
            // tbVariabelVariabeln
            // 
            this.tbVariabelVariabeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVariabelVariabeln.Location = new System.Drawing.Point(22, 180);
            this.tbVariabelVariabeln.Name = "tbVariabelVariabeln";
            this.tbVariabelVariabeln.Size = new System.Drawing.Size(165, 20);
            this.tbVariabelVariabeln.TabIndex = 296;
            // 
            // lbVariabelVariabel
            // 
            this.lbVariabelVariabel.AutoSize = true;
            this.lbVariabelVariabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVariabelVariabel.Location = new System.Drawing.Point(19, 164);
            this.lbVariabelVariabel.Name = "lbVariabelVariabel";
            this.lbVariabelVariabel.Size = new System.Drawing.Size(45, 13);
            this.lbVariabelVariabel.TabIndex = 302;
            this.lbVariabelVariabel.Text = "Variabel";
            // 
            // DGVVariablel
            // 
            this.DGVVariablel.BackgroundColor = System.Drawing.Color.White;
            this.DGVVariablel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVariablel.Location = new System.Drawing.Point(231, 131);
            this.DGVVariablel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVVariablel.Name = "DGVVariablel";
            this.DGVVariablel.RowTemplate.Height = 24;
            this.DGVVariablel.Size = new System.Drawing.Size(346, 331);
            this.DGVVariablel.TabIndex = 299;
            this.DGVVariablel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVVariablel_RowHeaderMouseClick);
            // 
            // btnVariabelTaBort
            // 
            this.btnVariabelTaBort.BackColor = System.Drawing.Color.Firebrick;
            this.btnVariabelTaBort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVariabelTaBort.Location = new System.Drawing.Point(5, 431);
            this.btnVariabelTaBort.Name = "btnVariabelTaBort";
            this.btnVariabelTaBort.Size = new System.Drawing.Size(120, 30);
            this.btnVariabelTaBort.TabIndex = 297;
            this.btnVariabelTaBort.Text = "Ta bort";
            this.btnVariabelTaBort.UseVisualStyleBackColor = false;
            this.btnVariabelTaBort.Click += new System.EventHandler(this.btnVariabelTaBort_Click);
            // 
            // tbVariabelDatum
            // 
            this.tbVariabelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVariabelDatum.Location = new System.Drawing.Point(22, 132);
            this.tbVariabelDatum.Name = "tbVariabelDatum";
            this.tbVariabelDatum.Size = new System.Drawing.Size(165, 20);
            this.tbVariabelDatum.TabIndex = 295;
            // 
            // lbVariabelDatum
            // 
            this.lbVariabelDatum.AutoSize = true;
            this.lbVariabelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVariabelDatum.Location = new System.Drawing.Point(18, 115);
            this.lbVariabelDatum.Name = "lbVariabelDatum";
            this.lbVariabelDatum.Size = new System.Drawing.Size(38, 13);
            this.lbVariabelDatum.TabIndex = 296;
            this.lbVariabelDatum.Text = "Datum";
            // 
            // ucFörsäkringstyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "ucFörsäkringstyper";
            this.Size = new System.Drawing.Size(900, 700);
            this.SO.ResumeLayout(false);
            this.SO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrundbeloppackvärde)).EndInit();
            this.plGrundbelopp.ResumeLayout(false);
            this.plGrundbelopp.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.LIV.ResumeLayout(false);
            this.LIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivsförsäkringarBelopp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivförsäkringarVariabler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.VAR.ResumeLayout(false);
            this.VAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVariablel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage SO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSökår;
        private System.Windows.Forms.DataGridView DGVGrundbeloppackvärde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel plGrundbelopp;
        private System.Windows.Forms.Button btnTabort;
        private System.Windows.Forms.ComboBox cbGrundbeloppAckvärdeÅr;
        private System.Windows.Forms.TextBox tbGrundbeloppAckvärdeBelopp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGrundbeloppAckvärdeVärde;
        private System.Windows.Forms.ComboBox cbFörsäkringstyp;
        private System.Windows.Forms.Button btnAvbrytGrundbelopp;
        private System.Windows.Forms.Button btnSparaGrundbelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LIV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLivsförsäkringTaBort;
        private System.Windows.Forms.TextBox tbLivsförsäkringGrundbelopp;
        private System.Windows.Forms.Label lbLivsförsäkringTyp;
        private System.Windows.Forms.Label lbLivsförsäkringBelopp;
        private System.Windows.Forms.Label lbLivsförsäkringDatumSök;
        private System.Windows.Forms.ComboBox cbLivsförsäkringDatumSök;
        private System.Windows.Forms.TextBox tbLivsförsäkringDatum;
        private System.Windows.Forms.Label lbLivsförsäkringDatum;
        private System.Windows.Forms.TextBox tbLivsförsäkringTyp;
        private System.Windows.Forms.TextBox tbLivsförsäkringVariabel;
        private System.Windows.Forms.Label lbLivsförsäkringVariabel;
        private System.Windows.Forms.Button btnLivsförsäkringSpara;
        private System.Windows.Forms.DataGridView DGVLivförsäkringarVariabler;
        private System.Windows.Forms.TabPage VAR;
        private System.Windows.Forms.Button btnVariabelSpara;
        private System.Windows.Forms.TextBox tbVariabelVariabeln;
        private System.Windows.Forms.Label lbVariabelVariabel;
        private System.Windows.Forms.DataGridView DGVVariablel;
        private System.Windows.Forms.Button btnVariabelTaBort;
        private System.Windows.Forms.TextBox tbVariabelDatum;
        private System.Windows.Forms.Label lbVariabelDatum;
        private System.Windows.Forms.DataGridView DGVLivsförsäkringarBelopp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}
