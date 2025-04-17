namespace SalasananTarkistus
{
    partial class SalasanaForm
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
            this.Salasana = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.VirheViestiTB = new System.Windows.Forms.TextBox();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.Salasana.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salasana
            // 
            this.Salasana.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salasana.Controls.Add(this.TarkistaBT);
            this.Salasana.Controls.Add(this.VirheViestiTB);
            this.Salasana.Controls.Add(this.SalasanaTB);
            this.Salasana.Controls.Add(this.KayttajaTB);
            this.Salasana.Controls.Add(this.label2);
            this.Salasana.Controls.Add(this.label1);
            this.Salasana.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salasana.ForeColor = System.Drawing.Color.Gold;
            this.Salasana.Location = new System.Drawing.Point(12, 12);
            this.Salasana.Name = "Salasana";
            this.Salasana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Salasana.Size = new System.Drawing.Size(776, 316);
            this.Salasana.TabIndex = 0;
            this.Salasana.Paint += new System.Windows.Forms.PaintEventHandler(this.Salasana_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(375, 60);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(291, 39);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(375, 131);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(291, 39);
            this.SalasanaTB.TabIndex = 3;
            // 
            // VirheViestiTB
            // 
            this.VirheViestiTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VirheViestiTB.Location = new System.Drawing.Point(101, 205);
            this.VirheViestiTB.Name = "VirheViestiTB";
            this.VirheViestiTB.Size = new System.Drawing.Size(290, 33);
            this.VirheViestiTB.TabIndex = 4;
            this.VirheViestiTB.Text = "Väärä käyttäjätunnus tai salasana";
            this.VirheViestiTB.Visible = false;
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label3);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(795, 450);
            this.SalasanaOikeinPanel.TabIndex = 5;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivuilleni";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TarkistaBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TarkistaBT.Location = new System.Drawing.Point(462, 205);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(125, 49);
            this.TarkistaBT.TabIndex = 5;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = false;
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Controls.Add(this.Salasana);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.Salasana.ResumeLayout(false);
            this.Salasana.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Salasana;
        private Label label2;
        private Label label1;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private TextBox VirheViestiTB;
        private Panel SalasanaOikeinPanel;
        private Label label3;
        private Button TarkistaBT;
    }
}