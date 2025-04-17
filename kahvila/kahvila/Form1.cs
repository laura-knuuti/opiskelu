namespace kahvila
{
<<<<<<< HEAD
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {

            //MeistaPL aloitussivuksi
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ruokalistaForm));
            vasenPL = new Panel();
            panel5 = new Panel();
            koriBT = new Button();
            panel4 = new Panel();
            meistaBT = new Button();
            panel3 = new Panel();
            herkutBT = new Button();
            panel2 = new Panel();
            juomatBT = new Button();
            panel1 = new Panel();
            button1 = new Button();
            meistaPL = new Panel();
            meistaLB = new Label();
            ruoatPL = new Panel();
            makeatLB = new Label();
            label3 = new Label();
            suolaisetLB = new Label();
            label2 = new Label();
            juomatPL = new Panel();
            label5 = new Label();
            label4 = new Label();
            kylmatLB = new Label();
            lampimatLB = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ylaPL = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            herkutPL = new Panel();
            label7 = new Label();
            label6 = new Label();
            muutLB = new Label();
            makeisetLB = new Label();
            koriPL = new Panel();
            label8 = new Label();
            vasenPL.SuspendLayout();
            meistaPL.SuspendLayout();
            ruoatPL.SuspendLayout();
            juomatPL.SuspendLayout();
            ylaPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            herkutPL.SuspendLayout();
            koriPL.SuspendLayout();
            SuspendLayout();
            // 
            // vasenPL
            // 
            vasenPL.BackColor = Color.FromArgb(62, 172, 64);
            vasenPL.Controls.Add(panel5);
            vasenPL.Controls.Add(koriBT);
            vasenPL.Controls.Add(panel4);
            vasenPL.Controls.Add(meistaBT);
            vasenPL.Controls.Add(panel3);
            vasenPL.Controls.Add(herkutBT);
            vasenPL.Controls.Add(panel2);
            vasenPL.Controls.Add(juomatBT);
            vasenPL.Controls.Add(panel1);
            vasenPL.Controls.Add(button1);
            vasenPL.Dock = DockStyle.Left;
            vasenPL.Location = new Point(0, 0);
            vasenPL.Name = "vasenPL";
            vasenPL.Size = new Size(211, 500);
            vasenPL.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(105, 218, 45);
            panel5.Location = new Point(12, 411);
            panel5.Name = "panel5";
            panel5.Size = new Size(15, 80);
            panel5.TabIndex = 10;
            // 
            // koriBT
            // 
            koriBT.FlatAppearance.BorderSize = 0;
            koriBT.FlatStyle = FlatStyle.Flat;
            koriBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            koriBT.ForeColor = Color.White;
            koriBT.Image = Properties.Resources.picnic_basket;
            koriBT.Location = new Point(8, 411);
            koriBT.Name = "koriBT";
            koriBT.Size = new Size(200, 80);
            koriBT.TabIndex = 9;
            koriBT.Text = "  Kori     ";
            koriBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            koriBT.UseVisualStyleBackColor = true;
            koriBT.Click += koriBT_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(105, 218, 45);
            panel4.Location = new Point(12, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 80);
            panel4.TabIndex = 8;
            // 
            // meistaBT
            // 
            meistaBT.FlatAppearance.BorderSize = 0;
            meistaBT.FlatStyle = FlatStyle.Flat;
            meistaBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            meistaBT.ForeColor = Color.White;
            meistaBT.Image = Properties.Resources.info;
            meistaBT.Location = new Point(0, 24);
            meistaBT.Name = "meistaBT";
            meistaBT.Size = new Size(200, 80);
            meistaBT.TabIndex = 7;
            meistaBT.Text = "  Meistä";
            meistaBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            meistaBT.UseVisualStyleBackColor = true;
            meistaBT.Click += meistaBT_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(105, 218, 45);
            panel3.Location = new Point(12, 307);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 80);
            panel3.TabIndex = 6;
            // 
            // herkutBT
            // 
            herkutBT.FlatAppearance.BorderSize = 0;
            herkutBT.FlatStyle = FlatStyle.Flat;
            herkutBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            herkutBT.ForeColor = Color.White;
            herkutBT.Image = Properties.Resources.desserts;
            herkutBT.Location = new Point(5, 307);
            herkutBT.Name = "herkutBT";
            herkutBT.Size = new Size(200, 80);
            herkutBT.TabIndex = 5;
            herkutBT.Text = "  Herkut  ";
            herkutBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            herkutBT.UseVisualStyleBackColor = true;
            herkutBT.Click += herkutBT_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(105, 218, 45);
            panel2.Location = new Point(12, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 80);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // juomatBT
            // 
            juomatBT.FlatAppearance.BorderSize = 0;
            juomatBT.FlatStyle = FlatStyle.Flat;
            juomatBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            juomatBT.ForeColor = Color.White;
            juomatBT.Image = Properties.Resources.coffee1;
            juomatBT.Location = new Point(8, 209);
            juomatBT.Name = "juomatBT";
            juomatBT.Size = new Size(200, 80);
            juomatBT.TabIndex = 3;
            juomatBT.Text = " Juomat";
            juomatBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            juomatBT.UseVisualStyleBackColor = true;
            juomatBT.Click += juomatBT_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 218, 45);
            panel1.Location = new Point(12, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 80);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.cutlery;
            button1.Location = new Point(0, 119);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 1;
            button1.Text = "  Ruoat  ";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // meistaPL
            // 
            meistaPL.Controls.Add(meistaLB);
            meistaPL.Dock = DockStyle.Fill;
            meistaPL.Location = new Point(211, 80);
            meistaPL.Name = "meistaPL";
            meistaPL.Size = new Size(889, 420);
            meistaPL.TabIndex = 0;
            // 
            // meistaLB
            // 
            meistaLB.AutoSize = true;
            meistaLB.Location = new Point(70, 60);
            meistaLB.Name = "meistaLB";
            meistaLB.Size = new Size(59, 25);
            meistaLB.TabIndex = 0;
            meistaLB.Text = "label2";
            // 
            // ruoatPL
            // 
            ruoatPL.Controls.Add(makeatLB);
            ruoatPL.Controls.Add(label3);
            ruoatPL.Controls.Add(suolaisetLB);
            ruoatPL.Controls.Add(label2);
            ruoatPL.Dock = DockStyle.Fill;
            ruoatPL.Location = new Point(211, 80);
            ruoatPL.Name = "ruoatPL";
            ruoatPL.Size = new Size(889, 420);
            ruoatPL.TabIndex = 0;
            // 
            // makeatLB
            // 
            makeatLB.AutoSize = true;
            makeatLB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            makeatLB.Location = new Point(498, 27);
            makeatLB.Name = "makeatLB";
            makeatLB.Size = new Size(108, 38);
            makeatLB.TabIndex = 1;
            makeatLB.Text = "Makeat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(487, 81);
            label3.Name = "label3";
            label3.Size = new Size(330, 128);
            label3.TabIndex = 3;
            label3.Text = "- voisilmäpulla             3,00 €\r\n- munkkipossu             3,00 €\r\n- porkkanakakkupala    4,00 €\r\n- mustikkapiirakkapala  3,00 €\r\n";
            // 
            // suolaisetLB
            // 
            suolaisetLB.AutoSize = true;
            suolaisetLB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            suolaisetLB.Location = new Point(23, 27);
            suolaisetLB.Name = "suolaisetLB";
            suolaisetLB.Size = new Size(128, 38);
            suolaisetLB.TabIndex = 0;
            suolaisetLB.Text = "Suolaiset";
            suolaisetLB.Click += suolaisetLB_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(280, 128);
            label2.TabIndex = 2;
            label2.Text = "- juustosämpylä    3,00 €\r\n- kinkkusämpylä    3,00 €\r\n- croissant             2,00 €\r\n- karjalanpiirakka   2,00 €\r\n";
            // 
            // juomatPL
            // 
            juomatPL.Controls.Add(label5);
            juomatPL.Controls.Add(label4);
            juomatPL.Controls.Add(kylmatLB);
            juomatPL.Controls.Add(lampimatLB);
            juomatPL.Dock = DockStyle.Fill;
            juomatPL.Location = new Point(211, 80);
            juomatPL.Name = "juomatPL";
            juomatPL.Size = new Size(889, 420);
            juomatPL.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(475, 95);
            label5.Name = "label5";
            label5.Size = new Size(281, 160);
            label5.TabIndex = 3;
            label5.Text = "- vesi                    0,20 €\r\n- porevesi             0,50 €\r\n- virvoitusjuomat   2,00 €\r\n- energiajuomat    3,00 €\r\n- tripit                   1,50 €";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 95);
            label4.Name = "label4";
            label4.Size = new Size(235, 160);
            label4.TabIndex = 2;
            label4.Text = "- kahvi            1,00 €\r\n- latte             2,00 €\r\n- cappucino    2,00 €\r\n- tee               1,00 €\r\n- kaakao         1,50 €";
            // 
            // kylmatLB
            // 
            kylmatLB.AutoSize = true;
            kylmatLB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            kylmatLB.Location = new Point(475, 39);
            kylmatLB.Name = "kylmatLB";
            kylmatLB.Size = new Size(100, 38);
            kylmatLB.TabIndex = 1;
            kylmatLB.Text = "Kylmät";
            // 
            // lampimatLB
            // 
            lampimatLB.AutoSize = true;
            lampimatLB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lampimatLB.Location = new Point(23, 38);
            lampimatLB.Name = "lampimatLB";
            lampimatLB.Size = new Size(138, 38);
            lampimatLB.TabIndex = 0;
            lampimatLB.Text = "Lämpimät";
            // 
            // ylaPL
            // 
            ylaPL.BackColor = Color.FromArgb(255, 153, 2);
            ylaPL.Controls.Add(pictureBox1);
            ylaPL.Controls.Add(label1);
            ylaPL.Dock = DockStyle.Top;
            ylaPL.Location = new Point(211, 0);
            ylaPL.Name = "ylaPL";
            ylaPL.Size = new Size(889, 80);
            ylaPL.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cook_hat;
            pictureBox1.Location = new Point(789, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 8);
            label1.Name = "label1";
            label1.Size = new Size(675, 63);
            label1.TabIndex = 0;
            label1.Text = "Keudan oppilaskunnan kahvila";
            label1.Click += label1_Click;
            // 
            // herkutPL
            // 
            herkutPL.Controls.Add(label7);
            herkutPL.Controls.Add(label6);
            herkutPL.Controls.Add(muutLB);
            herkutPL.Controls.Add(makeisetLB);
            herkutPL.Dock = DockStyle.Fill;
            herkutPL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            herkutPL.Location = new Point(211, 80);
            herkutPL.Name = "herkutPL";
            herkutPL.Size = new Size(889, 420);
            herkutPL.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 95);
            label7.Name = "label7";
            label7.Size = new Size(255, 192);
            label7.TabIndex = 3;
            label7.Text = "- Marjapiirakka  2,00 €\r\n- Omar              2,50 €\r\n- Gifflar kaneli   2,50 €\r\n- Gifflar vanilja   2,50 €\r\n- Gifflar omena  2,50 €\r\n- Gifflar manteli 2,50 €";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 101);
            label6.Name = "label6";
            label6.Size = new Size(405, 192);
            label6.TabIndex = 2;
            label6.Text = resources.GetString("label6.Text");
            // 
            // muutLB
            // 
            muutLB.AutoSize = true;
            muutLB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            muutLB.Location = new Point(498, 27);
            muutLB.Name = "muutLB";
            muutLB.Size = new Size(83, 38);
            muutLB.TabIndex = 1;
            muutLB.Text = "Muut";
            // 
            // makeisetLB
            // 
            makeisetLB.AutoSize = true;
            makeisetLB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            makeisetLB.Location = new Point(33, 39);
            makeisetLB.Name = "makeisetLB";
            makeisetLB.Size = new Size(128, 38);
            makeisetLB.TabIndex = 0;
            makeisetLB.Text = "Makeiset";
            // 
            // koriPL
            // 
            koriPL.Controls.Add(label8);
            koriPL.Dock = DockStyle.Fill;
            koriPL.Location = new Point(211, 80);
            koriPL.Name = "koriPL";
            koriPL.Size = new Size(889, 420);
            koriPL.TabIndex = 3;
            koriPL.Paint += koriPL_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(207, 101);
            label8.Name = "label8";
            label8.Size = new Size(461, 38);
            label8.TabIndex = 0;
            label8.Text = "Verkkokauppa avautuu myöhemmin";
            // 
            // ruokalistaForm
            // 
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1100, 500);
            Controls.Add(herkutPL);
            Controls.Add(juomatPL);
            Controls.Add(ruoatPL);
            Controls.Add(koriPL);
            Controls.Add(meistaPL);
            Controls.Add(ylaPL);
            Controls.Add(vasenPL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ruokalistaForm";
            Load += ruokalistaForm_Load;
            vasenPL.ResumeLayout(false);
            meistaPL.ResumeLayout(false);
            meistaPL.PerformLayout();
            ruoatPL.ResumeLayout(false);
            ruoatPL.PerformLayout();
            juomatPL.ResumeLayout(false);
            juomatPL.PerformLayout();
            ylaPL.ResumeLayout(false);
            ylaPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            herkutPL.ResumeLayout(false);
            herkutPL.PerformLayout();
            koriPL.ResumeLayout(false);
            koriPL.PerformLayout();
            ResumeLayout(false);

        }

        private void ylaPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ruoatbutton, identiteetti unohtui...
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;

        }

        private void koriPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12.30. \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "juomien lisäksi pientä purtavaa sekä virvokkeita ja makeisia. \n";
            meistaLB.Text += "Tervetuloa tutustumaan!";
            meistaLB.Font = new Font("Arial", 12);

        }

        private void suolaisetLB_Click(object sender, EventArgs e)
        {

        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;

        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;

        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;

        }
    }
}
=======
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> f26e103f67247c5f9c7fb11a1c765e528c52e2c0
