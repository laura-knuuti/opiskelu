namespace hotelli
{
    partial class VaraustenHallinta
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
<<<<<<< HEAD
            otsikkoLB = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ulosDTP = new DateTimePicker();
            sisaanDTP = new DateTimePicker();
            asiakasCB = new ComboBox();
            huonenroCB = new ComboBox();
            huonetyyppiCB = new ComboBox();
            varausnroTB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            varausBT = new Button();
            muokkaaBT = new Button();
            poistaBT = new Button();
            tyhjennaBT = new Button();
            varausDG = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)varausDG).BeginInit();
            SuspendLayout();
            // 
            // otsikkoLB
            // 
            otsikkoLB.AutoSize = true;
            otsikkoLB.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            otsikkoLB.ForeColor = Color.Khaki;
            otsikkoLB.Location = new Point(109, 23);
            otsikkoLB.Name = "otsikkoLB";
            otsikkoLB.Size = new Size(435, 65);
            otsikkoLB.TabIndex = 0;
            otsikkoLB.Text = "Varausten hallinta";
            otsikkoLB.Click += otsikkoLB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(159, 38);
            label1.TabIndex = 1;
            label1.Text = "Varaus nro:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ulosDTP);
            groupBox1.Controls.Add(sisaanDTP);
            groupBox1.Controls.Add(asiakasCB);
            groupBox1.Controls.Add(huonenroCB);
            groupBox1.Controls.Add(huonetyyppiCB);
            groupBox1.Controls.Add(varausnroTB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 468);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // ulosDTP
            // 
            ulosDTP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ulosDTP.Location = new Point(243, 357);
            ulosDTP.Margin = new Padding(4, 5, 4, 5);
            ulosDTP.Name = "ulosDTP";
            ulosDTP.Size = new Size(340, 33);
            ulosDTP.TabIndex = 16;
            ulosDTP.ValueChanged += ulosDTP_ValueChanged;
            // 
            // sisaanDTP
            // 
            sisaanDTP.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sisaanDTP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sisaanDTP.Location = new Point(243, 298);
            sisaanDTP.Margin = new Padding(4, 5, 4, 5);
            sisaanDTP.Name = "sisaanDTP";
            sisaanDTP.Size = new Size(340, 33);
            sisaanDTP.TabIndex = 15;
            // 
            // asiakasCB
            // 
            asiakasCB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            asiakasCB.FormattingEnabled = true;
            asiakasCB.Location = new Point(241, 112);
            asiakasCB.Margin = new Padding(4, 5, 4, 5);
            asiakasCB.Name = "asiakasCB";
            asiakasCB.Size = new Size(341, 48);
            asiakasCB.TabIndex = 14;
            // 
            // huonenroCB
            // 
            huonenroCB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            huonenroCB.FormattingEnabled = true;
            huonenroCB.Location = new Point(241, 233);
            huonenroCB.Name = "huonenroCB";
            huonenroCB.Size = new Size(341, 46);
            huonenroCB.TabIndex = 10;
            // 
            // huonetyyppiCB
            // 
            huonetyyppiCB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            huonetyyppiCB.FormattingEnabled = true;
            huonetyyppiCB.Location = new Point(241, 172);
            huonetyyppiCB.Name = "huonetyyppiCB";
            huonetyyppiCB.Size = new Size(341, 46);
            huonetyyppiCB.TabIndex = 9;
            huonetyyppiCB.SelectedIndexChanged += huonetyyppiCB_SelectedIndexChanged;
            // 
            // varausnroTB
            // 
            varausnroTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            varausnroTB.Location = new Point(243, 52);
            varausnroTB.Name = "varausnroTB";
            varausnroTB.Size = new Size(340, 45);
            varausnroTB.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkCyan;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(36, 357);
            label6.Name = "label6";
            label6.Size = new Size(80, 38);
            label6.TabIndex = 6;
            label6.Text = "Ulos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkCyan;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(36, 295);
            label5.Name = "label5";
            label5.Size = new Size(104, 38);
            label5.TabIndex = 5;
            label5.Text = "Sisään:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(36, 233);
            label4.Name = "label4";
            label4.Size = new Size(191, 38);
            label4.TabIndex = 4;
            label4.Text = "Huoneen nro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkCyan;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Khaki;
            label3.Location = new Point(36, 172);
            label3.Name = "label3";
            label3.Size = new Size(188, 38);
            label3.TabIndex = 3;
            label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(36, 112);
            label2.Name = "label2";
            label2.Size = new Size(170, 38);
            label2.TabIndex = 2;
            label2.Text = "Asiakas nro:";
            // 
            // varausBT
            // 
            varausBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            varausBT.Location = new Point(24, 617);
            varausBT.Name = "varausBT";
            varausBT.Size = new Size(179, 58);
            varausBT.TabIndex = 11;
            varausBT.Text = "Lisää varaus";
            varausBT.UseVisualStyleBackColor = true;
            varausBT.Click += varausBT_Click;
            // 
            // muokkaaBT
            // 
            muokkaaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            muokkaaBT.Location = new Point(240, 617);
            muokkaaBT.Name = "muokkaaBT";
            muokkaaBT.Size = new Size(179, 58);
            muokkaaBT.TabIndex = 12;
            muokkaaBT.Text = "Muokkaa";
            muokkaaBT.UseVisualStyleBackColor = true;
            muokkaaBT.Click += muokkaaBT_Click;
            // 
            // poistaBT
            // 
            poistaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            poistaBT.Location = new Point(457, 617);
            poistaBT.Name = "poistaBT";
            poistaBT.Size = new Size(179, 58);
            poistaBT.TabIndex = 13;
            poistaBT.Text = "Poista";
            poistaBT.UseVisualStyleBackColor = true;
            poistaBT.Click += poistaBT_Click;
            // 
            // tyhjennaBT
            // 
            tyhjennaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tyhjennaBT.Location = new Point(366, 710);
            tyhjennaBT.Name = "tyhjennaBT";
            tyhjennaBT.Size = new Size(270, 58);
            tyhjennaBT.TabIndex = 14;
            tyhjennaBT.Text = "Tyhjennä kentät";
            tyhjennaBT.UseVisualStyleBackColor = true;
            tyhjennaBT.Click += tyhjennaBT_Click;
            // 
            // varausDG
            // 
            varausDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            varausDG.Location = new Point(684, 57);
            varausDG.Name = "varausDG";
            varausDG.RowHeadersWidth = 62;
            varausDG.RowTemplate.Height = 33;
            varausDG.Size = new Size(749, 700);
            varausDG.TabIndex = 15;
            varausDG.CellClick += varausDG_CellClick;
            varausDG.CellContentClick += varausDG_CellContentClick;
            // 
            // VaraustenHallinta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1536, 832);
            Controls.Add(varausDG);
            Controls.Add(tyhjennaBT);
            Controls.Add(poistaBT);
            Controls.Add(muokkaaBT);
            Controls.Add(groupBox1);
            Controls.Add(otsikkoLB);
            Controls.Add(varausBT);
            ForeColor = SystemColors.ControlText;
            Name = "VaraustenHallinta";
            Text = "VaraustenHallinta";
            Load += VaraustenHallinta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)varausDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
=======
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ulosDTP = new System.Windows.Forms.DateTimePicker();
            this.sisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.asiakasCB = new System.Windows.Forms.ComboBox();
            this.huonenroCB = new System.Windows.Forms.ComboBox();
            this.huonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.varausnroTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.varausBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.varausDG = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausDG)).BeginInit();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.ForeColor = System.Drawing.Color.Khaki;
            this.otsikkoLB.Location = new System.Drawing.Point(76, 14);
            this.otsikkoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(287, 45);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Varausten hallinta";
            this.otsikkoLB.Click += new System.EventHandler(this.otsikkoLB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varaus nro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ulosDTP);
            this.groupBox1.Controls.Add(this.sisaanDTP);
            this.groupBox1.Controls.Add(this.asiakasCB);
            this.groupBox1.Controls.Add(this.huonenroCB);
            this.groupBox1.Controls.Add(this.huonetyyppiCB);
            this.groupBox1.Controls.Add(this.varausnroTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(439, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ulosDTP
            // 
            this.ulosDTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ulosDTP.Location = new System.Drawing.Point(170, 214);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(239, 25);
            this.ulosDTP.TabIndex = 16;
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sisaanDTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sisaanDTP.Location = new System.Drawing.Point(170, 179);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(239, 25);
            this.sisaanDTP.TabIndex = 15;
            // 
            // asiakasCB
            // 
            this.asiakasCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asiakasCB.FormattingEnabled = true;
            this.asiakasCB.Location = new System.Drawing.Point(169, 67);
            this.asiakasCB.Name = "asiakasCB";
            this.asiakasCB.Size = new System.Drawing.Size(240, 33);
            this.asiakasCB.TabIndex = 14;
            // 
            // huonenroCB
            // 
            this.huonenroCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huonenroCB.FormattingEnabled = true;
            this.huonenroCB.Location = new System.Drawing.Point(169, 140);
            this.huonenroCB.Margin = new System.Windows.Forms.Padding(2);
            this.huonenroCB.Name = "huonenroCB";
            this.huonenroCB.Size = new System.Drawing.Size(240, 33);
            this.huonenroCB.TabIndex = 10;
            // 
            // huonetyyppiCB
            // 
            this.huonetyyppiCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huonetyyppiCB.FormattingEnabled = true;
            this.huonetyyppiCB.Location = new System.Drawing.Point(169, 103);
            this.huonetyyppiCB.Margin = new System.Windows.Forms.Padding(2);
            this.huonetyyppiCB.Name = "huonetyyppiCB";
            this.huonetyyppiCB.Size = new System.Drawing.Size(240, 33);
            this.huonetyyppiCB.TabIndex = 9;
            this.huonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.huonetyyppiCB_SelectedIndexChanged);
            // 
            // varausnroTB
            // 
            this.varausnroTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varausnroTB.Location = new System.Drawing.Point(170, 31);
            this.varausnroTB.Margin = new System.Windows.Forms.Padding(2);
            this.varausnroTB.Name = "varausnroTB";
            this.varausnroTB.Size = new System.Drawing.Size(239, 32);
            this.varausnroTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ulos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(25, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sisään:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huoneen nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asiakas nro:";
            // 
            // varausBT
            // 
            this.varausBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.varausBT.Location = new System.Drawing.Point(17, 370);
            this.varausBT.Margin = new System.Windows.Forms.Padding(2);
            this.varausBT.Name = "varausBT";
            this.varausBT.Size = new System.Drawing.Size(125, 35);
            this.varausBT.TabIndex = 11;
            this.varausBT.Text = "Lisää varaus";
            this.varausBT.UseVisualStyleBackColor = true;
            this.varausBT.Click += new System.EventHandler(this.varausBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.muokkaaBT.Location = new System.Drawing.Point(168, 370);
            this.muokkaaBT.Margin = new System.Windows.Forms.Padding(2);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(125, 35);
            this.muokkaaBT.TabIndex = 12;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poistaBT.Location = new System.Drawing.Point(320, 370);
            this.poistaBT.Margin = new System.Windows.Forms.Padding(2);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(125, 35);
            this.poistaBT.TabIndex = 13;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tyhjennaBT.Location = new System.Drawing.Point(256, 426);
            this.tyhjennaBT.Margin = new System.Windows.Forms.Padding(2);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(189, 35);
            this.tyhjennaBT.TabIndex = 14;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // varausDG
            // 
            this.varausDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varausDG.Location = new System.Drawing.Point(479, 34);
            this.varausDG.Margin = new System.Windows.Forms.Padding(2);
            this.varausDG.Name = "varausDG";
            this.varausDG.RowHeadersWidth = 62;
            this.varausDG.RowTemplate.Height = 33;
            this.varausDG.Size = new System.Drawing.Size(524, 420);
            this.varausDG.TabIndex = 15;
            this.varausDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausDG_CellClick);
            this.varausDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausDG_CellContentClick);
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1075, 499);
            this.Controls.Add(this.varausDG);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.otsikkoLB);
            this.Controls.Add(this.varausBT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VaraustenHallinta";
            this.Text = "VaraustenHallinta";
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> ac8d35c9fd774df789e711954dd4290568ec6c38

        }

        #endregion

        private Label otsikkoLB;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox varausnroTB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox huonenroCB;
        private ComboBox huonetyyppiCB;
        private Button varausBT;
        private Button muokkaaBT;
        private Button poistaBT;
        private Button tyhjennaBT;
        private DataGridView varausDG;
        private ComboBox asiakasCB;
        private DateTimePicker ulosDTP;
        private DateTimePicker sisaanDTP;
    }
}