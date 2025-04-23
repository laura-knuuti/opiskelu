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