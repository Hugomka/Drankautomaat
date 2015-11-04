namespace Drankautomaat
{
    partial class Form1
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
            this.btnKoopDrank = new System.Windows.Forms.Button();
            this.lbDranken = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInworp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInworpTweeEuro = new System.Windows.Forms.Button();
            this.btnInworpEenVijfdeEuro = new System.Windows.Forms.Button();
            this.btnInworpHalveEuro = new System.Windows.Forms.Button();
            this.btnInworpEenEuro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDrankPrijs = new System.Windows.Forms.NumericUpDown();
            this.btnDrankToevoegen = new System.Windows.Forms.Button();
            this.nudDrankVoedingswaarde = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDrankMilliliter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDrankNaam = new System.Windows.Forms.TextBox();
            this.cbDrankSoort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVoorraadToevoegen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudVoorraadAantal = new System.Windows.Forms.NumericUpDown();
            this.lbVoorraad = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBekerToevoegen = new System.Windows.Forms.Button();
            this.chkBekerWarmeDrank = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudBekerMilliliter = new System.Windows.Forms.NumericUpDown();
            this.tbBekerNaam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExporteerLogbestand = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankPrijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankVoedingswaarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankMilliliter)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoorraadAantal)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBekerMilliliter)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKoopDrank
            // 
            this.btnKoopDrank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKoopDrank.Location = new System.Drawing.Point(160, 190);
            this.btnKoopDrank.Margin = new System.Windows.Forms.Padding(4);
            this.btnKoopDrank.Name = "btnKoopDrank";
            this.btnKoopDrank.Size = new System.Drawing.Size(127, 28);
            this.btnKoopDrank.TabIndex = 2;
            this.btnKoopDrank.Text = "Koop drank";
            this.btnKoopDrank.UseVisualStyleBackColor = true;
            this.btnKoopDrank.Click += new System.EventHandler(this.btnKoopDrank_Click);
            // 
            // lbDranken
            // 
            this.lbDranken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDranken.FormattingEnabled = true;
            this.lbDranken.ItemHeight = 16;
            this.lbDranken.Location = new System.Drawing.Point(20, 25);
            this.lbDranken.Margin = new System.Windows.Forms.Padding(4);
            this.lbDranken.Name = "lbDranken";
            this.lbDranken.Size = new System.Drawing.Size(265, 116);
            this.lbDranken.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblInworp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInworpTweeEuro);
            this.groupBox1.Controls.Add(this.btnInworpEenVijfdeEuro);
            this.groupBox1.Controls.Add(this.btnInworpHalveEuro);
            this.groupBox1.Controls.Add(this.btnInworpEenEuro);
            this.groupBox1.Controls.Add(this.lbDranken);
            this.groupBox1.Controls.Add(this.btnKoopDrank);
            this.groupBox1.Location = new System.Drawing.Point(379, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drank kopen";
            // 
            // lblInworp
            // 
            this.lblInworp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInworp.AutoSize = true;
            this.lblInworp.Location = new System.Drawing.Point(249, 160);
            this.lblInworp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInworp.Name = "lblInworp";
            this.lblInworp.Size = new System.Drawing.Size(36, 17);
            this.lblInworp.TabIndex = 7;
            this.lblInworp.Text = "0,00";
            this.lblInworp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inworp:";
            // 
            // btnInworpTweeEuro
            // 
            this.btnInworpTweeEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInworpTweeEuro.Location = new System.Drawing.Point(83, 190);
            this.btnInworpTweeEuro.Margin = new System.Windows.Forms.Padding(4);
            this.btnInworpTweeEuro.Name = "btnInworpTweeEuro";
            this.btnInworpTweeEuro.Size = new System.Drawing.Size(64, 28);
            this.btnInworpTweeEuro.TabIndex = 5;
            this.btnInworpTweeEuro.Text = "€ 2,00";
            this.btnInworpTweeEuro.UseVisualStyleBackColor = true;
            // 
            // btnInworpEenVijfdeEuro
            // 
            this.btnInworpEenVijfdeEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInworpEenVijfdeEuro.Location = new System.Drawing.Point(11, 154);
            this.btnInworpEenVijfdeEuro.Margin = new System.Windows.Forms.Padding(4);
            this.btnInworpEenVijfdeEuro.Name = "btnInworpEenVijfdeEuro";
            this.btnInworpEenVijfdeEuro.Size = new System.Drawing.Size(64, 28);
            this.btnInworpEenVijfdeEuro.TabIndex = 5;
            this.btnInworpEenVijfdeEuro.Text = "€ 0,20";
            this.btnInworpEenVijfdeEuro.UseVisualStyleBackColor = true;
            // 
            // btnInworpHalveEuro
            // 
            this.btnInworpHalveEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInworpHalveEuro.Location = new System.Drawing.Point(83, 154);
            this.btnInworpHalveEuro.Margin = new System.Windows.Forms.Padding(4);
            this.btnInworpHalveEuro.Name = "btnInworpHalveEuro";
            this.btnInworpHalveEuro.Size = new System.Drawing.Size(64, 28);
            this.btnInworpHalveEuro.TabIndex = 5;
            this.btnInworpHalveEuro.Text = "€ 0,50";
            this.btnInworpHalveEuro.UseVisualStyleBackColor = true;
            // 
            // btnInworpEenEuro
            // 
            this.btnInworpEenEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInworpEenEuro.Location = new System.Drawing.Point(11, 190);
            this.btnInworpEenEuro.Margin = new System.Windows.Forms.Padding(4);
            this.btnInworpEenEuro.Name = "btnInworpEenEuro";
            this.btnInworpEenEuro.Size = new System.Drawing.Size(64, 28);
            this.btnInworpEenEuro.TabIndex = 5;
            this.btnInworpEenEuro.Text = "€ 1,00";
            this.btnInworpEenEuro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudDrankPrijs);
            this.groupBox2.Controls.Add(this.btnDrankToevoegen);
            this.groupBox2.Controls.Add(this.nudDrankVoedingswaarde);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudDrankMilliliter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbDrankNaam);
            this.groupBox2.Controls.Add(this.cbDrankSoort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(343, 230);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nieuwe drank toevoegen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Verkoopprijs in €";
            // 
            // nudDrankPrijs
            // 
            this.nudDrankPrijs.DecimalPlaces = 2;
            this.nudDrankPrijs.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudDrankPrijs.Location = new System.Drawing.Point(201, 90);
            this.nudDrankPrijs.Margin = new System.Windows.Forms.Padding(4);
            this.nudDrankPrijs.Maximum = new decimal(new int[] {
            950,
            0,
            0,
            131072});
            this.nudDrankPrijs.Name = "nudDrankPrijs";
            this.nudDrankPrijs.Size = new System.Drawing.Size(127, 22);
            this.nudDrankPrijs.TabIndex = 9;
            this.nudDrankPrijs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnDrankToevoegen
            // 
            this.btnDrankToevoegen.Location = new System.Drawing.Point(201, 187);
            this.btnDrankToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrankToevoegen.Name = "btnDrankToevoegen";
            this.btnDrankToevoegen.Size = new System.Drawing.Size(127, 28);
            this.btnDrankToevoegen.TabIndex = 8;
            this.btnDrankToevoegen.Text = "Toevoegen";
            this.btnDrankToevoegen.UseVisualStyleBackColor = true;
            this.btnDrankToevoegen.Click += new System.EventHandler(this.btnDrankToevoegen_Click);
            // 
            // nudDrankVoedingswaarde
            // 
            this.nudDrankVoedingswaarde.Location = new System.Drawing.Point(201, 155);
            this.nudDrankVoedingswaarde.Margin = new System.Windows.Forms.Padding(4);
            this.nudDrankVoedingswaarde.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudDrankVoedingswaarde.Name = "nudDrankVoedingswaarde";
            this.nudDrankVoedingswaarde.Size = new System.Drawing.Size(127, 22);
            this.nudDrankVoedingswaarde.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "(Milli)gram suiker/cafeïne";
            // 
            // nudDrankMilliliter
            // 
            this.nudDrankMilliliter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDrankMilliliter.Location = new System.Drawing.Point(201, 122);
            this.nudDrankMilliliter.Margin = new System.Windows.Forms.Padding(4);
            this.nudDrankMilliliter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDrankMilliliter.Name = "nudDrankMilliliter";
            this.nudDrankMilliliter.Size = new System.Drawing.Size(127, 22);
            this.nudDrankMilliliter.TabIndex = 5;
            this.nudDrankMilliliter.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Milliliter per portie";
            // 
            // tbDrankNaam
            // 
            this.tbDrankNaam.Location = new System.Drawing.Point(201, 58);
            this.tbDrankNaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbDrankNaam.Name = "tbDrankNaam";
            this.tbDrankNaam.Size = new System.Drawing.Size(125, 22);
            this.tbDrankNaam.TabIndex = 3;
            // 
            // cbDrankSoort
            // 
            this.cbDrankSoort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrankSoort.FormattingEnabled = true;
            this.cbDrankSoort.Items.AddRange(new object[] {
            "Frisdrank",
            "Koffie",
            "Soep"});
            this.cbDrankSoort.Location = new System.Drawing.Point(201, 25);
            this.cbDrankSoort.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrankSoort.Name = "cbDrankSoort";
            this.cbDrankSoort.Size = new System.Drawing.Size(125, 24);
            this.cbDrankSoort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naam drank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soort drank";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnVoorraadToevoegen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudVoorraadAantal);
            this.groupBox3.Controls.Add(this.lbVoorraad);
            this.groupBox3.Location = new System.Drawing.Point(379, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(309, 230);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voorraad";
            // 
            // btnVoorraadToevoegen
            // 
            this.btnVoorraadToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoorraadToevoegen.Location = new System.Drawing.Point(160, 187);
            this.btnVoorraadToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoorraadToevoegen.Name = "btnVoorraadToevoegen";
            this.btnVoorraadToevoegen.Size = new System.Drawing.Size(127, 28);
            this.btnVoorraadToevoegen.TabIndex = 11;
            this.btnVoorraadToevoegen.Text = "Toevoegen";
            this.btnVoorraadToevoegen.UseVisualStyleBackColor = true;
            this.btnVoorraadToevoegen.Click += new System.EventHandler(this.btnVoorraadToevoegen_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Aantal";
            // 
            // nudVoorraadAantal
            // 
            this.nudVoorraadAantal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVoorraadAantal.Location = new System.Drawing.Point(220, 155);
            this.nudVoorraadAantal.Margin = new System.Windows.Forms.Padding(4);
            this.nudVoorraadAantal.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudVoorraadAantal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVoorraadAantal.Name = "nudVoorraadAantal";
            this.nudVoorraadAantal.Size = new System.Drawing.Size(67, 22);
            this.nudVoorraadAantal.TabIndex = 11;
            this.nudVoorraadAantal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbVoorraad
            // 
            this.lbVoorraad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVoorraad.FormattingEnabled = true;
            this.lbVoorraad.ItemHeight = 16;
            this.lbVoorraad.Location = new System.Drawing.Point(20, 25);
            this.lbVoorraad.Margin = new System.Windows.Forms.Padding(4);
            this.lbVoorraad.Name = "lbVoorraad";
            this.lbVoorraad.Size = new System.Drawing.Size(265, 116);
            this.lbVoorraad.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox4.Controls.Add(this.btnBekerToevoegen);
            this.groupBox4.Controls.Add(this.chkBekerWarmeDrank);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudBekerMilliliter);
            this.groupBox4.Controls.Add(this.tbBekerNaam);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(16, 252);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(343, 158);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nieuwe beker toevoegen";
            // 
            // btnBekerToevoegen
            // 
            this.btnBekerToevoegen.Location = new System.Drawing.Point(201, 114);
            this.btnBekerToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBekerToevoegen.Name = "btnBekerToevoegen";
            this.btnBekerToevoegen.Size = new System.Drawing.Size(127, 28);
            this.btnBekerToevoegen.TabIndex = 11;
            this.btnBekerToevoegen.Text = "Toevoegen";
            this.btnBekerToevoegen.UseVisualStyleBackColor = true;
            this.btnBekerToevoegen.Click += new System.EventHandler(this.btnBekerToevoegen_Click);
            // 
            // chkBekerWarmeDrank
            // 
            this.chkBekerWarmeDrank.AutoSize = true;
            this.chkBekerWarmeDrank.Location = new System.Drawing.Point(201, 90);
            this.chkBekerWarmeDrank.Margin = new System.Windows.Forms.Padding(4);
            this.chkBekerWarmeDrank.Name = "chkBekerWarmeDrank";
            this.chkBekerWarmeDrank.Size = new System.Drawing.Size(18, 17);
            this.chkBekerWarmeDrank.TabIndex = 9;
            this.chkBekerWarmeDrank.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Warme drank mogelijk";
            // 
            // nudBekerMilliliter
            // 
            this.nudBekerMilliliter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudBekerMilliliter.Location = new System.Drawing.Point(201, 57);
            this.nudBekerMilliliter.Margin = new System.Windows.Forms.Padding(4);
            this.nudBekerMilliliter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBekerMilliliter.Name = "nudBekerMilliliter";
            this.nudBekerMilliliter.Size = new System.Drawing.Size(127, 22);
            this.nudBekerMilliliter.TabIndex = 12;
            this.nudBekerMilliliter.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // tbBekerNaam
            // 
            this.tbBekerNaam.Location = new System.Drawing.Point(201, 25);
            this.tbBekerNaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbBekerNaam.Name = "tbBekerNaam";
            this.tbBekerNaam.Size = new System.Drawing.Size(125, 22);
            this.tbBekerNaam.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Capacitieit in milliliters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Naam beker";
            // 
            // btnExporteerLogbestand
            // 
            this.btnExporteerLogbestand.Location = new System.Drawing.Point(20, 25);
            this.btnExporteerLogbestand.Margin = new System.Windows.Forms.Padding(4);
            this.btnExporteerLogbestand.Name = "btnExporteerLogbestand";
            this.btnExporteerLogbestand.Size = new System.Drawing.Size(308, 28);
            this.btnExporteerLogbestand.TabIndex = 14;
            this.btnExporteerLogbestand.Text = "Exporteer logbestand";
            this.btnExporteerLogbestand.UseVisualStyleBackColor = true;
            this.btnExporteerLogbestand.Click += new System.EventHandler(this.btnExporteerLogbestand_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.btnExporteerLogbestand);
            this.groupBox5.Location = new System.Drawing.Point(16, 417);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(343, 65);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Overig";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 495);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(718, 531);
            this.Name = "Form1";
            this.Text = "NAAM STUDENT - Drankautomaat Proof of Concept";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankPrijs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankVoedingswaarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankMilliliter)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoorraadAantal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBekerMilliliter)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button btnKoopDrank;
        private System.Windows.Forms.ListBox lbDranken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudDrankVoedingswaarde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDrankMilliliter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDrankNaam;
        private System.Windows.Forms.ComboBox cbDrankSoort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDrankPrijs;
        private System.Windows.Forms.Button btnDrankToevoegen;
        private System.Windows.Forms.Button btnVoorraadToevoegen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudVoorraadAantal;
        private System.Windows.Forms.ListBox lbVoorraad;
        private System.Windows.Forms.Label lblInworp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInworpEenEuro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbBekerNaam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudBekerMilliliter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBekerToevoegen;
        private System.Windows.Forms.CheckBox chkBekerWarmeDrank;
        private System.Windows.Forms.Button btnExporteerLogbestand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnInworpTweeEuro;
        private System.Windows.Forms.Button btnInworpEenVijfdeEuro;
        private System.Windows.Forms.Button btnInworpHalveEuro;
    }
}

