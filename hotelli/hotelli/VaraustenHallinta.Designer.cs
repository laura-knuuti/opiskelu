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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            varausnroTB = new TextBox();
            asiakasnroTB = new TextBox();
            huonetyyppiCB = new ComboBox();
            huonenroTB = new ComboBox();
            varausBT = new Button();
            sisaanCB = new ComboBox();
            comboBox1 = new ComboBox();
            muokkaaBT = new Button();
            poistaBT = new Button();
            tyhjennaBT = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(16, 51);
            label1.Name = "label1";
            label1.Size = new Size(159, 38);
            label1.TabIndex = 1;
            label1.Text = "Varaus nro:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(sisaanCB);
            groupBox1.Controls.Add(huonenroTB);
            groupBox1.Controls.Add(huonetyyppiCB);
            groupBox1.Controls.Add(asiakasnroTB);
            groupBox1.Controls.Add(varausnroTB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 468);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(170, 38);
            label2.TabIndex = 2;
            label2.Text = "Asiakas nro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkCyan;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Khaki;
            label3.Location = new Point(13, 167);
            label3.Name = "label3";
            label3.Size = new Size(188, 38);
            label3.TabIndex = 3;
            label3.Text = "Huonetyyppi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(13, 222);
            label4.Name = "label4";
            label4.Size = new Size(191, 38);
            label4.TabIndex = 4;
            label4.Text = "Huoneen nro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkCyan;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(16, 282);
            label5.Name = "label5";
            label5.Size = new Size(104, 38);
            label5.TabIndex = 5;
            label5.Text = "Sisään:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkCyan;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(16, 343);
            label6.Name = "label6";
            label6.Size = new Size(80, 38);
            label6.TabIndex = 6;
            label6.Text = "Ulos:";
            // 
            // varausnroTB
            // 
            varausnroTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            varausnroTB.Location = new Point(242, 44);
            varausnroTB.Name = "varausnroTB";
            varausnroTB.Size = new Size(340, 45);
            varausnroTB.TabIndex = 7;
            // 
            // asiakasnroTB
            // 
            asiakasnroTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            asiakasnroTB.Location = new Point(242, 101);
            asiakasnroTB.Name = "asiakasnroTB";
            asiakasnroTB.Size = new Size(341, 45);
            asiakasnroTB.TabIndex = 8;
            // 
            // huonetyyppiCB
            // 
            huonetyyppiCB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            huonetyyppiCB.FormattingEnabled = true;
            huonetyyppiCB.Location = new Point(242, 159);
            huonetyyppiCB.Name = "huonetyyppiCB";
            huonetyyppiCB.Size = new Size(341, 46);
            huonetyyppiCB.TabIndex = 9;
            // 
            // huonenroTB
            // 
            huonenroTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            huonenroTB.FormattingEnabled = true;
            huonenroTB.Location = new Point(241, 219);
            huonenroTB.Name = "huonenroTB";
            huonenroTB.Size = new Size(341, 46);
            huonenroTB.TabIndex = 10;
            // 
            // varausBT
            // 
            varausBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            varausBT.Location = new Point(24, 617);
            varausBT.Name = "varausBT";
            varausBT.Size = new Size(178, 59);
            varausBT.TabIndex = 11;
            varausBT.Text = "Lisää varaus";
            varausBT.UseVisualStyleBackColor = true;
            // 
            // sisaanCB
            // 
            sisaanCB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sisaanCB.FormattingEnabled = true;
            sisaanCB.Location = new Point(242, 279);
            sisaanCB.Name = "sisaanCB";
            sisaanCB.Size = new Size(341, 46);
            sisaanCB.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 343);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(341, 46);
            comboBox1.TabIndex = 13;
            // 
            // muokkaaBT
            // 
            muokkaaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            muokkaaBT.Location = new Point(240, 617);
            muokkaaBT.Name = "muokkaaBT";
            muokkaaBT.Size = new Size(178, 59);
            muokkaaBT.TabIndex = 12;
            muokkaaBT.Text = "Muokkaa";
            muokkaaBT.UseVisualStyleBackColor = true;
            // 
            // poistaBT
            // 
            poistaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            poistaBT.Location = new Point(457, 617);
            poistaBT.Name = "poistaBT";
            poistaBT.Size = new Size(178, 59);
            poistaBT.TabIndex = 13;
            poistaBT.Text = "Poista";
            poistaBT.UseVisualStyleBackColor = true;
            // 
            // tyhjennaBT
            // 
            tyhjennaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tyhjennaBT.Location = new Point(365, 710);
            tyhjennaBT.Name = "tyhjennaBT";
            tyhjennaBT.Size = new Size(270, 59);
            tyhjennaBT.TabIndex = 14;
            tyhjennaBT.Text = "Tyhjennä kentät";
            tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(684, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(748, 700);
            dataGridView1.TabIndex = 15;
            // 
            // VaraustenHallinta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1536, 832);
            Controls.Add(dataGridView1);
            Controls.Add(tyhjennaBT);
            Controls.Add(poistaBT);
            Controls.Add(muokkaaBT);
            Controls.Add(groupBox1);
            Controls.Add(otsikkoLB);
            Controls.Add(varausBT);
            ForeColor = SystemColors.ControlText;
            Name = "VaraustenHallinta";
            Text = "VaraustenHallinta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ComboBox huonenroTB;
        private ComboBox huonetyyppiCB;
        private TextBox asiakasnroTB;
        private ComboBox comboBox1;
        private ComboBox sisaanCB;
        private Button varausBT;
        private Button muokkaaBT;
        private Button poistaBT;
        private Button tyhjennaBT;
        private DataGridView dataGridView1;
    }
}