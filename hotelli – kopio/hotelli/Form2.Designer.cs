namespace hotelli
{
    partial class Paaikkuna
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseAsiakkaitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseVarauksiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseHuoneitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotelli.Properties.Resources.hotel_room_vacation_travel_vacation_6fb43b_1024;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 538);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(421, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 85);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa hotellin hallintasivustolle.\r\nValitse valikosta, mitä haluat tehdä!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsiakkaitaToolStripMenuItem,
            this.hallitseVarauksiaToolStripMenuItem,
            this.hallitseHuoneitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            this.hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            this.hallitseAsiakkaitaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse asiakkaita";
            this.hallitseAsiakkaitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseAsiakkaitaToolStripMenuItem_Click);
            // 
            // hallitseVarauksiaToolStripMenuItem
            // 
            this.hallitseVarauksiaToolStripMenuItem.Name = "hallitseVarauksiaToolStripMenuItem";
            this.hallitseVarauksiaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hallitseVarauksiaToolStripMenuItem.Text = "Hallitse varauksia";
            this.hallitseVarauksiaToolStripMenuItem.Click += new System.EventHandler(this.hallitseVarauksiaToolStripMenuItem_Click);
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            this.hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            this.hallitseHuoneitaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.hallitseHuoneitaToolStripMenuItem.Text = "Hallitse huoneita";
            this.hallitseHuoneitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseHuoneitaToolStripMenuItem_Click);
            // 
            // Paaikkuna
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paaikkuna";
            this.Text = "Paaikkuna";
            this.Load += new System.EventHandler(this.Paaikkuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hallitseAsiakkaitaToolStripMenuItem;
        private ToolStripMenuItem hallitseVarauksiaToolStripMenuItem;
        private ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
    }
}