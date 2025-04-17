namespace Autokululaskuri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lainaTB = new TextBox();
            label1 = new Label();
            nesteetTB = new TextBox();
            vakuutusTB = new TextBox();
            pesutTB = new TextBox();
            huollotTB = new TextBox();
            renkaatTB = new TextBox();
            lainaLB = new Label();
            nesteLB = new Label();
            vakuutusLB = new Label();
            muutLB = new Label();
            muutTB = new TextBox();
            polttonesteLB = new Label();
            pesutLB = new Label();
            polttonesteTB = new TextBox();
            huollotLB = new Label();
            renkaatLB = new Label();
            kilmoetritLB = new Label();
            yhteensaLB = new Label();
            label2 = new Label();
            kmCB = new ComboBox();
            SuspendLayout();
            // 
            // lainaTB
            // 
            lainaTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lainaTB.Location = new Point(666, 365);
            lainaTB.Name = "lainaTB";
            lainaTB.Size = new Size(217, 45);
            lainaTB.TabIndex = 0;
            lainaTB.TextChanged += lainaTXT_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(708, 128);
            label1.Name = "label1";
            label1.Size = new Size(781, 96);
            label1.TabIndex = 1;
            label1.Text = "Auton kustannuslaskuri";
            // 
            // nesteetTB
            // 
            nesteetTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nesteetTB.Location = new Point(666, 455);
            nesteetTB.Name = "nesteetTB";
            nesteetTB.Size = new Size(217, 45);
            nesteetTB.TabIndex = 2;
            // 
            // vakuutusTB
            // 
            vakuutusTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vakuutusTB.Location = new Point(666, 554);
            vakuutusTB.Name = "vakuutusTB";
            vakuutusTB.Size = new Size(217, 45);
            vakuutusTB.TabIndex = 3;
            // 
            // pesutTB
            // 
            pesutTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesutTB.Location = new Point(1448, 361);
            pesutTB.Name = "pesutTB";
            pesutTB.Size = new Size(230, 45);
            pesutTB.TabIndex = 4;
            // 
            // huollotTB
            // 
            huollotTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            huollotTB.Location = new Point(1448, 455);
            huollotTB.Name = "huollotTB";
            huollotTB.Size = new Size(230, 45);
            huollotTB.TabIndex = 5;
            // 
            // renkaatTB
            // 
            renkaatTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renkaatTB.Location = new Point(1448, 550);
            renkaatTB.Name = "renkaatTB";
            renkaatTB.Size = new Size(230, 45);
            renkaatTB.TabIndex = 6;
            // 
            // lainaLB
            // 
            lainaLB.AutoSize = true;
            lainaLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lainaLB.Location = new Point(221, 365);
            lainaLB.Name = "lainaLB";
            lainaLB.Size = new Size(421, 49);
            lainaLB.TabIndex = 7;
            lainaLB.Text = "Lainan lyhennys korkoineen";
            lainaLB.Click += label2_Click;
            // 
            // nesteLB
            // 
            nesteLB.AutoSize = true;
            nesteLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nesteLB.Location = new Point(221, 455);
            nesteLB.Name = "nesteLB";
            nesteLB.Size = new Size(351, 49);
            nesteLB.TabIndex = 8;
            nesteLB.Text = "Lisättävät nesteet yms.";
            // 
            // vakuutusLB
            // 
            vakuutusLB.AutoSize = true;
            vakuutusLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vakuutusLB.Location = new Point(221, 553);
            vakuutusLB.Name = "vakuutusLB";
            vakuutusLB.Size = new Size(255, 49);
            vakuutusLB.TabIndex = 9;
            vakuutusLB.Text = "Vakuutusmaksut";
            // 
            // muutLB
            // 
            muutLB.AutoSize = true;
            muutLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            muutLB.Location = new Point(221, 652);
            muutLB.Name = "muutLB";
            muutLB.Size = new Size(179, 49);
            muutLB.TabIndex = 10;
            muutLB.Text = "Muut kulut";
            // 
            // muutTB
            // 
            muutTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            muutTB.Location = new Point(666, 652);
            muutTB.Name = "muutTB";
            muutTB.Size = new Size(217, 45);
            muutTB.TabIndex = 11;
            // 
            // polttonesteLB
            // 
            polttonesteLB.AutoSize = true;
            polttonesteLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            polttonesteLB.Location = new Point(221, 755);
            polttonesteLB.Name = "polttonesteLB";
            polttonesteLB.Size = new Size(182, 49);
            polttonesteLB.TabIndex = 12;
            polttonesteLB.Text = "Polttoneste";
            polttonesteLB.Click += label2_Click_1;
            // 
            // pesutLB
            // 
            pesutLB.AutoSize = true;
            pesutLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesutLB.Location = new Point(1133, 361);
            pesutLB.Name = "pesutLB";
            pesutLB.Size = new Size(99, 49);
            pesutLB.TabIndex = 13;
            pesutLB.Text = "Pesut";
            pesutLB.Click += label3_Click;
            // 
            // polttonesteTB
            // 
            polttonesteTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            polttonesteTB.Location = new Point(666, 755);
            polttonesteTB.Name = "polttonesteTB";
            polttonesteTB.Size = new Size(217, 45);
            polttonesteTB.TabIndex = 15;
            // 
            // huollotLB
            // 
            huollotLB.AutoSize = true;
            huollotLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            huollotLB.Location = new Point(1133, 451);
            huollotLB.Name = "huollotLB";
            huollotLB.Size = new Size(123, 49);
            huollotLB.TabIndex = 16;
            huollotLB.Text = "Huollot";
            // 
            // renkaatLB
            // 
            renkaatLB.AutoSize = true;
            renkaatLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renkaatLB.Location = new Point(1133, 549);
            renkaatLB.Name = "renkaatLB";
            renkaatLB.Size = new Size(138, 49);
            renkaatLB.TabIndex = 17;
            renkaatLB.Text = "Renkaat";
            // 
            // kilmoetritLB
            // 
            kilmoetritLB.AutoSize = true;
            kilmoetritLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kilmoetritLB.Location = new Point(1133, 648);
            kilmoetritLB.Name = "kilmoetritLB";
            kilmoetritLB.Size = new Size(251, 49);
            kilmoetritLB.TabIndex = 18;
            kilmoetritLB.Text = "Kilometrit/vuosi";
            // 
            // yhteensaLB
            // 
            yhteensaLB.AutoSize = true;
            yhteensaLB.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yhteensaLB.Location = new Point(221, 874);
            yhteensaLB.Name = "yhteensaLB";
            yhteensaLB.Size = new Size(530, 49);
            yhteensaLB.TabIndex = 20;
            yhteensaLB.Text = "Kustannukset kilometriä kohti ovat:";
            yhteensaLB.Visible = false;
            yhteensaLB.Click += label2_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(800, 874);
            label2.Name = "label2";
            label2.Size = new Size(0, 49);
            label2.TabIndex = 21;
            // 
            // kmCB
            // 
            kmCB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kmCB.FormattingEnabled = true;
            kmCB.Items.AddRange(new object[] { "1000", "5000", "10000", "15000", "20000", "25000", "30000", "35000", "40000", "45000", "50000", "55000", "60000", "65000", "70000", "75000", "80000", "85000", "90000", "95000", "100000" });
            kmCB.Location = new Point(1448, 652);
            kmCB.Name = "kmCB";
            kmCB.Size = new Size(230, 46);
            kmCB.TabIndex = 23;
            kmCB.SelectedIndexChanged += kmCB_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2274, 1387);
            Controls.Add(kmCB);
            Controls.Add(label2);
            Controls.Add(yhteensaLB);
            Controls.Add(kilmoetritLB);
            Controls.Add(renkaatLB);
            Controls.Add(huollotLB);
            Controls.Add(polttonesteTB);
            Controls.Add(pesutLB);
            Controls.Add(polttonesteLB);
            Controls.Add(muutTB);
            Controls.Add(muutLB);
            Controls.Add(vakuutusLB);
            Controls.Add(nesteLB);
            Controls.Add(lainaLB);
            Controls.Add(renkaatTB);
            Controls.Add(huollotTB);
            Controls.Add(pesutTB);
            Controls.Add(vakuutusTB);
            Controls.Add(nesteetTB);
            Controls.Add(label1);
            Controls.Add(lainaTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lainaTB;
        private Label label1;
        private TextBox nesteetTB;
        private TextBox vakuutusTB;
        private TextBox pesutTB;
        private TextBox huollotTB;
        private TextBox renkaatTB;
        private Label lainaLB;
        private Label nesteLB;
        private Label vakuutusLB;
        private Label muutLB;
        private TextBox muutTB;
        private Label polttonesteLB;
        private Label pesutLB;
        private TextBox polttonesteTB;
        private Label huollotLB;
        private Label renkaatLB;
        private Label kilmoetritLB;
        private Label yhteensaLB;
        private Label label2;
        private ComboBox kmCB;
    }
}
