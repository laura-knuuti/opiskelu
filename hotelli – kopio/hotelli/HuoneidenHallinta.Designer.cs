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
            this.huonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.huoneetDG = new System.Windows.Forms.DataGridView();
            this.huonenroTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.kylla_RB = new System.Windows.Forms.RadioButton();
            this.ei_RB = new System.Windows.Forms.RadioButton();
            this.huoneNro = new System.Windows.Forms.Label();
            this.huonetyyppi = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.vapaaLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.lisaahuoneBT = new System.Windows.Forms.Button();
            this.huoneidenhallintaLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // huonetyyppiCB
            // 
            this.huonetyyppiCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huonetyyppiCB.FormattingEnabled = true;
            this.huonetyyppiCB.Location = new System.Drawing.Point(210, 53);
            this.huonetyyppiCB.Name = "huonetyyppiCB";
            this.huonetyyppiCB.Size = new System.Drawing.Size(175, 33);
            this.huonetyyppiCB.TabIndex = 0;
            // 
            // huoneetDG
            // 
            this.huoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDG.Location = new System.Drawing.Point(432, 89);
            this.huoneetDG.Name = "huoneetDG";
            this.huoneetDG.RowTemplate.Height = 25;
            this.huoneetDG.Size = new System.Drawing.Size(293, 308);
            this.huoneetDG.TabIndex = 1;
            // 
            // huonenroTB
            // 
            this.huonenroTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huonenroTB.Location = new System.Drawing.Point(210, 17);
            this.huonenroTB.Name = "huonenroTB";
            this.huonenroTB.Size = new System.Drawing.Size(175, 33);
            this.huonenroTB.TabIndex = 2;
            this.huonenroTB.TextChanged += new System.EventHandler(this.huonenroTB_TextChanged);
            // 
            // puhelinTB
            // 
            this.puhelinTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puhelinTB.Location = new System.Drawing.Point(210, 92);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(175, 33);
            this.puhelinTB.TabIndex = 3;
            // 
            // kylla_RB
            // 
            this.kylla_RB.AutoSize = true;
            this.kylla_RB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kylla_RB.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.kylla_RB.Location = new System.Drawing.Point(210, 131);
            this.kylla_RB.Name = "kylla_RB";
            this.kylla_RB.Size = new System.Drawing.Size(71, 29);
            this.kylla_RB.TabIndex = 4;
            this.kylla_RB.TabStop = true;
            this.kylla_RB.Text = "Kyllä";
            this.kylla_RB.UseVisualStyleBackColor = true;
            // 
            // ei_RB
            // 
            this.ei_RB.AutoSize = true;
            this.ei_RB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ei_RB.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.ei_RB.Location = new System.Drawing.Point(340, 131);
            this.ei_RB.Name = "ei_RB";
            this.ei_RB.Size = new System.Drawing.Size(45, 29);
            this.ei_RB.TabIndex = 5;
            this.ei_RB.TabStop = true;
            this.ei_RB.Text = "Ei";
            this.ei_RB.UseVisualStyleBackColor = true;
            // 
            // huoneNro
            // 
            this.huoneNro.AutoSize = true;
            this.huoneNro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.huoneNro.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.huoneNro.Location = new System.Drawing.Point(6, 25);
            this.huoneNro.Name = "huoneNro";
            this.huoneNro.Size = new System.Drawing.Size(129, 25);
            this.huoneNro.TabIndex = 6;
            this.huoneNro.Text = "Huoneen nro:";
            // 
            // huonetyyppi
            // 
            this.huonetyyppi.AutoSize = true;
            this.huonetyyppi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.huonetyyppi.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.huonetyyppi.Location = new System.Drawing.Point(7, 56);
            this.huonetyyppi.Name = "huonetyyppi";
            this.huonetyyppi.Size = new System.Drawing.Size(128, 25);
            this.huonetyyppi.TabIndex = 7;
            this.huonetyyppi.Text = "Huonetyyppi:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.puhelinLB.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.puhelinLB.Location = new System.Drawing.Point(7, 92);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(81, 25);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "Puhelin:";
            // 
            // vapaaLB
            // 
            this.vapaaLB.AutoSize = true;
            this.vapaaLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vapaaLB.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.vapaaLB.Location = new System.Drawing.Point(7, 125);
            this.vapaaLB.Name = "vapaaLB";
            this.vapaaLB.Size = new System.Drawing.Size(69, 25);
            this.vapaaLB.TabIndex = 9;
            this.vapaaLB.Text = "Vapaa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tyhjennaBT);
            this.groupBox1.Controls.Add(this.poistaBT);
            this.groupBox1.Controls.Add(this.muokkaaBT);
            this.groupBox1.Controls.Add(this.lisaahuoneBT);
            this.groupBox1.Controls.Add(this.huonenroTB);
            this.groupBox1.Controls.Add(this.puhelinLB);
            this.groupBox1.Controls.Add(this.vapaaLB);
            this.groupBox1.Controls.Add(this.huonetyyppiCB);
            this.groupBox1.Controls.Add(this.puhelinTB);
            this.groupBox1.Controls.Add(this.huonetyyppi);
            this.groupBox1.Controls.Add(this.ei_RB);
            this.groupBox1.Controls.Add(this.huoneNro);
            this.groupBox1.Controls.Add(this.kylla_RB);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 308);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tyhjennaBT.Location = new System.Drawing.Point(273, 225);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(126, 31);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poistaBT.Location = new System.Drawing.Point(273, 188);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(126, 31);
            this.poistaBT.TabIndex = 12;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.muokkaaBT.Location = new System.Drawing.Point(141, 188);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(126, 31);
            this.muokkaaBT.TabIndex = 11;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // lisaahuoneBT
            // 
            this.lisaahuoneBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lisaahuoneBT.Location = new System.Drawing.Point(9, 188);
            this.lisaahuoneBT.Name = "lisaahuoneBT";
            this.lisaahuoneBT.Size = new System.Drawing.Size(126, 31);
            this.lisaahuoneBT.TabIndex = 10;
            this.lisaahuoneBT.Text = "Lisää uusi huone";
            this.lisaahuoneBT.UseVisualStyleBackColor = true;
            this.lisaahuoneBT.Click += new System.EventHandler(this.lisaahuoneBT_Click);
            // 
            // huoneidenhallintaLB
            // 
            this.huoneidenhallintaLB.AutoSize = true;
            this.huoneidenhallintaLB.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.huoneidenhallintaLB.ForeColor = System.Drawing.Color.LemonChiffon;
            this.huoneidenhallintaLB.Location = new System.Drawing.Point(207, 24);
            this.huoneidenhallintaLB.Name = "huoneidenhallintaLB";
            this.huoneidenhallintaLB.Size = new System.Drawing.Size(299, 32);
            this.huoneidenhallintaLB.TabIndex = 11;
            this.huoneidenhallintaLB.Text = "Huoneiden hallinta";
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(744, 436);
            this.Controls.Add(this.huoneidenhallintaLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.huoneetDG);
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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