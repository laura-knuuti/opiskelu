namespace hotelli
{
    partial class AsiakkaidenHallinta
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
            groupBox1 = new GroupBox();
            tyhjennaBT = new Button();
            poistaBT = new Button();
            muokkaaBT = new Button();
            asiakasBT = new Button();
            salasanaTB = new TextBox();
            kayttajatunnusTB = new TextBox();
            postitoimipaikkaTB = new TextBox();
            postinumeroTB = new TextBox();
            lahiosoiteTB = new TextBox();
            sukunimiTB = new TextBox();
            etunimiTB = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            asiakkaatDG = new DataGridView();
            otsikkoLB = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)asiakkaatDG).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tyhjennaBT);
            groupBox1.Controls.Add(poistaBT);
            groupBox1.Controls.Add(muokkaaBT);
            groupBox1.Controls.Add(asiakasBT);
            groupBox1.Controls.Add(salasanaTB);
            groupBox1.Controls.Add(kayttajatunnusTB);
            groupBox1.Controls.Add(postitoimipaikkaTB);
            groupBox1.Controls.Add(postinumeroTB);
            groupBox1.Controls.Add(lahiosoiteTB);
            groupBox1.Controls.Add(sukunimiTB);
            groupBox1.Controls.Add(etunimiTB);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(70, 160);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(897, 843);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tyhjennaBT
            // 
            tyhjennaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tyhjennaBT.Location = new Point(341, 722);
            tyhjennaBT.Margin = new Padding(4, 5, 4, 5);
            tyhjennaBT.Name = "tyhjennaBT";
            tyhjennaBT.Size = new Size(173, 87);
            tyhjennaBT.TabIndex = 24;
            tyhjennaBT.Text = "Tyhjennä kentät";
            tyhjennaBT.UseVisualStyleBackColor = true;
            tyhjennaBT.Click += tyhjennaBT_Click;
            // 
            // poistaBT
            // 
            poistaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            poistaBT.Location = new Point(640, 625);
            poistaBT.Margin = new Padding(4, 5, 4, 5);
            poistaBT.Name = "poistaBT";
            poistaBT.Size = new Size(173, 52);
            poistaBT.TabIndex = 23;
            poistaBT.Text = "Poista";
            poistaBT.UseVisualStyleBackColor = true;
            poistaBT.Click += poistaBT_Click;
            // 
            // muokkaaBT
            // 
            muokkaaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            muokkaaBT.Location = new Point(341, 625);
            muokkaaBT.Margin = new Padding(4, 5, 4, 5);
            muokkaaBT.Name = "muokkaaBT";
            muokkaaBT.Size = new Size(173, 52);
            muokkaaBT.TabIndex = 22;
            muokkaaBT.Text = "Muokkaa";
            muokkaaBT.UseVisualStyleBackColor = true;
            muokkaaBT.Click += muokkaaBT_Click;
            // 
            // asiakasBT
            // 
            asiakasBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            asiakasBT.Location = new Point(40, 625);
            asiakasBT.Margin = new Padding(4, 5, 4, 5);
            asiakasBT.Name = "asiakasBT";
            asiakasBT.Size = new Size(173, 52);
            asiakasBT.TabIndex = 21;
            asiakasBT.Text = "Lisää asiakas";
            asiakasBT.UseVisualStyleBackColor = true;
            asiakasBT.Click += asiakasBT_Click;
            // 
            // salasanaTB
            // 
            salasanaTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            salasanaTB.Location = new Point(386, 507);
            salasanaTB.Margin = new Padding(4, 5, 4, 5);
            salasanaTB.Name = "salasanaTB";
            salasanaTB.Size = new Size(443, 45);
            salasanaTB.TabIndex = 20;
            salasanaTB.UseSystemPasswordChar = true;
            // 
            // kayttajatunnusTB
            // 
            kayttajatunnusTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kayttajatunnusTB.Location = new Point(386, 442);
            kayttajatunnusTB.Margin = new Padding(4, 5, 4, 5);
            kayttajatunnusTB.Name = "kayttajatunnusTB";
            kayttajatunnusTB.Size = new Size(443, 45);
            kayttajatunnusTB.TabIndex = 19;
            // 
            // postitoimipaikkaTB
            // 
            postitoimipaikkaTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            postitoimipaikkaTB.Location = new Point(386, 377);
            postitoimipaikkaTB.Margin = new Padding(4, 5, 4, 5);
            postitoimipaikkaTB.Name = "postitoimipaikkaTB";
            postitoimipaikkaTB.Size = new Size(443, 45);
            postitoimipaikkaTB.TabIndex = 18;
            // 
            // postinumeroTB
            // 
            postinumeroTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            postinumeroTB.Location = new Point(386, 313);
            postinumeroTB.Margin = new Padding(4, 5, 4, 5);
            postinumeroTB.Name = "postinumeroTB";
            postinumeroTB.Size = new Size(443, 45);
            postinumeroTB.TabIndex = 17;
            // 
            // lahiosoiteTB
            // 
            lahiosoiteTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lahiosoiteTB.Location = new Point(386, 248);
            lahiosoiteTB.Margin = new Padding(4, 5, 4, 5);
            lahiosoiteTB.Name = "lahiosoiteTB";
            lahiosoiteTB.Size = new Size(443, 45);
            lahiosoiteTB.TabIndex = 16;
            // 
            // sukunimiTB
            // 
            sukunimiTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sukunimiTB.Location = new Point(386, 183);
            sukunimiTB.Margin = new Padding(4, 5, 4, 5);
            sukunimiTB.Name = "sukunimiTB";
            sukunimiTB.Size = new Size(443, 45);
            sukunimiTB.TabIndex = 15;
            // 
            // etunimiTB
            // 
            etunimiTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            etunimiTB.Location = new Point(386, 118);
            etunimiTB.Margin = new Padding(4, 5, 4, 5);
            etunimiTB.Name = "etunimiTB";
            etunimiTB.Size = new Size(443, 45);
            etunimiTB.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Khaki;
            label14.Location = new Point(34, 512);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(138, 40);
            label14.TabIndex = 13;
            label14.Text = "Salasana:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Khaki;
            label13.Location = new Point(34, 447);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(221, 40);
            label13.TabIndex = 12;
            label13.Text = "Käyttäjätunnus:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Khaki;
            label12.Location = new Point(34, 382);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(242, 40);
            label12.TabIndex = 11;
            label12.Text = "Postitoimipaikka:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Khaki;
            label11.Location = new Point(34, 318);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(191, 40);
            label11.TabIndex = 10;
            label11.Text = "Postinumero:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Khaki;
            label10.Location = new Point(34, 253);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(158, 40);
            label10.TabIndex = 9;
            label10.Text = "Lähiosoite:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Khaki;
            label9.Location = new Point(34, 188);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(148, 40);
            label9.TabIndex = 8;
            label9.Text = "Sukunimi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Khaki;
            label8.Location = new Point(34, 123);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 40);
            label8.TabIndex = 7;
            label8.Text = "Etunimi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Khaki;
            label7.Location = new Point(34, 120);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 40);
            label7.TabIndex = 6;
            label7.Text = "Etunimi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(34, 120);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 40);
            label6.TabIndex = 5;
            label6.Text = "Etunimi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(34, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 40);
            label5.TabIndex = 4;
            label5.Text = "Etunimi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(34, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 40);
            label4.TabIndex = 3;
            label4.Text = "Etunimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Khaki;
            label3.Location = new Point(34, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 40);
            label3.TabIndex = 2;
            label3.Text = "Etunimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(34, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 0;
            label1.Text = "Etunimi:";
            // 
            // asiakkaatDG
            // 
            asiakkaatDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            asiakkaatDG.Location = new Point(976, 160);
            asiakkaatDG.Margin = new Padding(4, 5, 4, 5);
            asiakkaatDG.Name = "asiakkaatDG";
            asiakkaatDG.RowHeadersWidth = 62;
            asiakkaatDG.RowTemplate.Height = 25;
            asiakkaatDG.Size = new Size(1185, 843);
            asiakkaatDG.TabIndex = 21;
            // 
            // otsikkoLB
            // 
            otsikkoLB.AutoSize = true;
            otsikkoLB.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            otsikkoLB.ForeColor = Color.Khaki;
            otsikkoLB.Location = new Point(634, 42);
            otsikkoLB.Margin = new Padding(4, 0, 4, 0);
            otsikkoLB.Name = "otsikkoLB";
            otsikkoLB.Size = new Size(346, 48);
            otsikkoLB.TabIndex = 22;
            otsikkoLB.Text = "Asiakkaiden hallinta";
            otsikkoLB.Click += otsikkoLB_Click;
            // 
            // AsiakkaidenHallinta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(2252, 1097);
            Controls.Add(otsikkoLB);
            Controls.Add(asiakkaatDG);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AsiakkaidenHallinta";
            Text = "Asiakkaiden hallinta";
            Load += AsiakkaidenHallinta_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)asiakkaatDG).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox etunimiTB;
        private TextBox salasanaTB;
        private TextBox kayttajatunnusTB;
        private TextBox postitoimipaikkaTB;
        private TextBox postinumeroTB;
        private TextBox lahiosoiteTB;
        private TextBox sukunimiTB;
        private Button tyhjennaBT;
        private Button poistaBT;
        private Button muokkaaBT;
        private Button asiakasBT;
        private DataGridView asiakkaatDG;
        private Label otsikkoLB;
    }
}