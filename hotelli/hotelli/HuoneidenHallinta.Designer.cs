namespace hotelli
{
    partial class HuoneidenHallinta
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
            huonetyyppiCB = new ComboBox();
            huoneetDG = new DataGridView();
            huonenroTB = new TextBox();
            puhelinTB = new TextBox();
            kylla_RB = new RadioButton();
            ei_RB = new RadioButton();
            huoneNro = new Label();
            huonetyyppi = new Label();
            puhelinLB = new Label();
            vapaaLB = new Label();
            groupBox1 = new GroupBox();
            tyhjennaBT = new Button();
            poistaBT = new Button();
            muokkaaBT = new Button();
            lisaahuoneBT = new Button();
            huoneidenhallintaLB = new Label();
            ((System.ComponentModel.ISupportInitialize)huoneetDG).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // huonetyyppiCB
            // 
            huonetyyppiCB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            huonetyyppiCB.FormattingEnabled = true;
            huonetyyppiCB.Location = new Point(300, 88);
            huonetyyppiCB.Margin = new Padding(4, 5, 4, 5);
            huonetyyppiCB.Name = "huonetyyppiCB";
            huonetyyppiCB.Size = new Size(248, 48);
            huonetyyppiCB.TabIndex = 0;
            // 
            // huoneetDG
            // 
            huoneetDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            huoneetDG.Location = new Point(617, 148);
            huoneetDG.Margin = new Padding(4, 5, 4, 5);
            huoneetDG.Name = "huoneetDG";
            huoneetDG.RowHeadersWidth = 62;
            huoneetDG.RowTemplate.Height = 25;
            huoneetDG.Size = new Size(419, 513);
            huoneetDG.TabIndex = 1;
            // 
            // huonenroTB
            // 
            huonenroTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            huonenroTB.Location = new Point(300, 28);
            huonenroTB.Margin = new Padding(4, 5, 4, 5);
            huonenroTB.Name = "huonenroTB";
            huonenroTB.Size = new Size(248, 45);
            huonenroTB.TabIndex = 2;
            huonenroTB.TextChanged += huonenroTB_TextChanged;
            // 
            // puhelinTB
            // 
            puhelinTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            puhelinTB.Location = new Point(300, 153);
            puhelinTB.Margin = new Padding(4, 5, 4, 5);
            puhelinTB.Name = "puhelinTB";
            puhelinTB.Size = new Size(248, 45);
            puhelinTB.TabIndex = 3;
            // 
            // kylla_RB
            // 
            kylla_RB.AutoSize = true;
            kylla_RB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            kylla_RB.ForeColor = Color.PaleGoldenrod;
            kylla_RB.Location = new Point(300, 218);
            kylla_RB.Margin = new Padding(4, 5, 4, 5);
            kylla_RB.Name = "kylla_RB";
            kylla_RB.Size = new Size(105, 44);
            kylla_RB.TabIndex = 4;
            kylla_RB.TabStop = true;
            kylla_RB.Text = "Kyllä";
            kylla_RB.UseVisualStyleBackColor = true;
            // 
            // ei_RB
            // 
            ei_RB.AutoSize = true;
            ei_RB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ei_RB.ForeColor = Color.PaleGoldenrod;
            ei_RB.Location = new Point(486, 218);
            ei_RB.Margin = new Padding(4, 5, 4, 5);
            ei_RB.Name = "ei_RB";
            ei_RB.Size = new Size(65, 44);
            ei_RB.TabIndex = 5;
            ei_RB.TabStop = true;
            ei_RB.Text = "Ei";
            ei_RB.UseVisualStyleBackColor = true;
            // 
            // huoneNro
            // 
            huoneNro.AutoSize = true;
            huoneNro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            huoneNro.ForeColor = Color.PaleGoldenrod;
            huoneNro.Location = new Point(9, 42);
            huoneNro.Margin = new Padding(4, 0, 4, 0);
            huoneNro.Name = "huoneNro";
            huoneNro.Size = new Size(196, 40);
            huoneNro.TabIndex = 6;
            huoneNro.Text = "Huoneen nro:";
            // 
            // huonetyyppi
            // 
            huonetyyppi.AutoSize = true;
            huonetyyppi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            huonetyyppi.ForeColor = Color.PaleGoldenrod;
            huonetyyppi.Location = new Point(10, 93);
            huonetyyppi.Margin = new Padding(4, 0, 4, 0);
            huonetyyppi.Name = "huonetyyppi";
            huonetyyppi.Size = new Size(193, 40);
            huonetyyppi.TabIndex = 7;
            huonetyyppi.Text = "Huonetyyppi:";
            // 
            // puhelinLB
            // 
            puhelinLB.AutoSize = true;
            puhelinLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            puhelinLB.ForeColor = Color.PaleGoldenrod;
            puhelinLB.Location = new Point(10, 153);
            puhelinLB.Margin = new Padding(4, 0, 4, 0);
            puhelinLB.Name = "puhelinLB";
            puhelinLB.Size = new Size(123, 40);
            puhelinLB.TabIndex = 8;
            puhelinLB.Text = "Puhelin:";
            // 
            // vapaaLB
            // 
            vapaaLB.AutoSize = true;
            vapaaLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            vapaaLB.ForeColor = Color.PaleGoldenrod;
            vapaaLB.Location = new Point(10, 208);
            vapaaLB.Margin = new Padding(4, 0, 4, 0);
            vapaaLB.Name = "vapaaLB";
            vapaaLB.Size = new Size(103, 40);
            vapaaLB.TabIndex = 9;
            vapaaLB.Text = "Vapaa:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tyhjennaBT);
            groupBox1.Controls.Add(poistaBT);
            groupBox1.Controls.Add(muokkaaBT);
            groupBox1.Controls.Add(lisaahuoneBT);
            groupBox1.Controls.Add(huonenroTB);
            groupBox1.Controls.Add(puhelinLB);
            groupBox1.Controls.Add(vapaaLB);
            groupBox1.Controls.Add(huonetyyppiCB);
            groupBox1.Controls.Add(puhelinTB);
            groupBox1.Controls.Add(huonetyyppi);
            groupBox1.Controls.Add(ei_RB);
            groupBox1.Controls.Add(huoneNro);
            groupBox1.Controls.Add(kylla_RB);
            groupBox1.Location = new Point(17, 148);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(591, 513);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tyhjennaBT
            // 
            tyhjennaBT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tyhjennaBT.Location = new Point(390, 375);
            tyhjennaBT.Margin = new Padding(4, 5, 4, 5);
            tyhjennaBT.Name = "tyhjennaBT";
            tyhjennaBT.Size = new Size(180, 52);
            tyhjennaBT.TabIndex = 13;
            tyhjennaBT.Text = "Tyhjennä kentät";
            tyhjennaBT.UseVisualStyleBackColor = true;
            tyhjennaBT.Click += tyhjennaBT_Click;
            // 
            // poistaBT
            // 
            poistaBT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            poistaBT.Location = new Point(390, 313);
            poistaBT.Margin = new Padding(4, 5, 4, 5);
            poistaBT.Name = "poistaBT";
            poistaBT.Size = new Size(180, 52);
            poistaBT.TabIndex = 12;
            poistaBT.Text = "Poista";
            poistaBT.UseVisualStyleBackColor = true;
            poistaBT.Click += poistaBT_Click;
            // 
            // muokkaaBT
            // 
            muokkaaBT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            muokkaaBT.Location = new Point(201, 313);
            muokkaaBT.Margin = new Padding(4, 5, 4, 5);
            muokkaaBT.Name = "muokkaaBT";
            muokkaaBT.Size = new Size(180, 52);
            muokkaaBT.TabIndex = 11;
            muokkaaBT.Text = "Muokkaa";
            muokkaaBT.UseVisualStyleBackColor = true;
            muokkaaBT.Click += muokkaaBT_Click;
            // 
            // lisaahuoneBT
            // 
            lisaahuoneBT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lisaahuoneBT.Location = new Point(13, 313);
            lisaahuoneBT.Margin = new Padding(4, 5, 4, 5);
            lisaahuoneBT.Name = "lisaahuoneBT";
            lisaahuoneBT.Size = new Size(180, 52);
            lisaahuoneBT.TabIndex = 10;
            lisaahuoneBT.Text = "Lisää uusi huone";
            lisaahuoneBT.UseVisualStyleBackColor = true;
            lisaahuoneBT.Click += lisaahuoneBT_Click;
            // 
            // huoneidenhallintaLB
            // 
            huoneidenhallintaLB.AutoSize = true;
            huoneidenhallintaLB.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            huoneidenhallintaLB.ForeColor = Color.LemonChiffon;
            huoneidenhallintaLB.Location = new Point(296, 40);
            huoneidenhallintaLB.Margin = new Padding(4, 0, 4, 0);
            huoneidenhallintaLB.Name = "huoneidenhallintaLB";
            huoneidenhallintaLB.Size = new Size(455, 49);
            huoneidenhallintaLB.TabIndex = 11;
            huoneidenhallintaLB.Text = "Huoneiden hallinta";
            // 
            // HuoneidenHallinta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1063, 727);
            Controls.Add(huoneidenhallintaLB);
            Controls.Add(groupBox1);
            Controls.Add(huoneetDG);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HuoneidenHallinta";
            Text = "HuoneidenHallinta";
            Load += HuoneidenHallinta_Load;
            ((System.ComponentModel.ISupportInitialize)huoneetDG).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ComboBox huonetyyppiCB;
        private DataGridView huoneetDG;
        private TextBox huonenroTB;
        private TextBox puhelinTB;
        private RadioButton kylla_RB;
        private RadioButton ei_RB;
        private Label huoneNro;
        private Label huonetyyppi;
        private Label puhelinLB;
        private Label vapaaLB;
        private GroupBox groupBox1;
        private Button tyhjennaBT;
        private Button poistaBT;
        private Button muokkaaBT;
        private Button lisaahuoneBT;
        private Label huoneidenhallintaLB;
    }
}