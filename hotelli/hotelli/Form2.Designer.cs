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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            hallitseAsiakkaitaToolStripMenuItem = new ToolStripMenuItem();
            hallitseVarauksiaToolStripMenuItem = new ToolStripMenuItem();
            hallitseHuoneitaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hotel_room_vacation_travel_vacation_6fb43b_1024;
            pictureBox1.Location = new Point(0, 38);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1146, 897);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(601, 72);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 142);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Wheat;
            label1.Location = new Point(26, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(499, 80);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa hotellin hallintasivustolle.\r\nValitse valikosta, mitä haluat tehdä!";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hallitseAsiakkaitaToolStripMenuItem, hallitseVarauksiaToolStripMenuItem, hallitseHuoneitaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1146, 35);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            hallitseAsiakkaitaToolStripMenuItem.Size = new Size(166, 29);
            hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse asiakkaita";
            hallitseAsiakkaitaToolStripMenuItem.Click += hallitseAsiakkaitaToolStripMenuItem_Click;
            // 
            // hallitseVarauksiaToolStripMenuItem
            // 
            hallitseVarauksiaToolStripMenuItem.Name = "hallitseVarauksiaToolStripMenuItem";
            hallitseVarauksiaToolStripMenuItem.Size = new Size(163, 29);
            hallitseVarauksiaToolStripMenuItem.Text = "Hallitse varauksia";
            hallitseVarauksiaToolStripMenuItem.Click += hallitseVarauksiaToolStripMenuItem_Click;
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            hallitseHuoneitaToolStripMenuItem.Size = new Size(159, 29);
            hallitseHuoneitaToolStripMenuItem.Text = "Hallitse huoneita";
            hallitseHuoneitaToolStripMenuItem.Click += hallitseHuoneitaToolStripMenuItem_Click;
            // 
            // Paaikkuna
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 933);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.No;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Paaikkuna";
            Text = "Paaikkuna";
            Load += Paaikkuna_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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