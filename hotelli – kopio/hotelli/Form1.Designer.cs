namespace hotelli
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
<<<<<<< HEAD
            button1 = new Button();
            kayttajaTB = new TextBox();
            salasanaTB = new TextBox();
            kayttajaLB = new Label();
            salasanaLB = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(340, 552);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(291, 78);
            button1.TabIndex = 0;
            button1.Text = "Kirjaudu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kayttajaTB
            // 
            kayttajaTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kayttajaTB.Location = new Point(456, 308);
            kayttajaTB.Margin = new Padding(4, 5, 4, 5);
            kayttajaTB.Name = "kayttajaTB";
            kayttajaTB.Size = new Size(390, 45);
            kayttajaTB.TabIndex = 1;
            // 
            // salasanaTB
            // 
            salasanaTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            salasanaTB.Location = new Point(456, 395);
            salasanaTB.Margin = new Padding(4, 5, 4, 5);
            salasanaTB.Name = "salasanaTB";
            salasanaTB.Size = new Size(390, 45);
            salasanaTB.TabIndex = 2;
            // 
            // kayttajaLB
            // 
            kayttajaLB.AutoSize = true;
            kayttajaLB.BackColor = Color.DarkCyan;
            kayttajaLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            kayttajaLB.ForeColor = Color.Khaki;
            kayttajaLB.Location = new Point(197, 313);
            kayttajaLB.Margin = new Padding(4, 0, 4, 0);
            kayttajaLB.Name = "kayttajaLB";
            kayttajaLB.Size = new Size(221, 40);
            kayttajaLB.TabIndex = 3;
            kayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // salasanaLB
            // 
            salasanaLB.AutoSize = true;
            salasanaLB.BackColor = Color.DarkCyan;
            salasanaLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            salasanaLB.ForeColor = Color.Khaki;
            salasanaLB.Location = new Point(197, 400);
            salasanaLB.Margin = new Padding(4, 0, 4, 0);
            salasanaLB.Name = "salasanaLB";
            salasanaLB.Size = new Size(138, 40);
            salasanaLB.TabIndex = 4;
            salasanaLB.Text = "Salasana:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(957, 750);
            Controls.Add(salasanaLB);
            Controls.Add(kayttajaLB);
            Controls.Add(salasanaTB);
            Controls.Add(kayttajaTB);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Kirjautumisikkuna";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
=======
            this.button1 = new System.Windows.Forms.Button();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(238, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kirjaudu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayttajaTB.Location = new System.Drawing.Point(319, 185);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(274, 33);
            this.kayttajaTB.TabIndex = 1;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaTB.Location = new System.Drawing.Point(319, 237);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(274, 33);
            this.salasanaTB.TabIndex = 2;
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.BackColor = System.Drawing.Color.DarkCyan;
            this.kayttajaLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayttajaLB.ForeColor = System.Drawing.Color.Khaki;
            this.kayttajaLB.Location = new System.Drawing.Point(138, 188);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(147, 25);
            this.kayttajaLB.TabIndex = 3;
            this.kayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.BackColor = System.Drawing.Color.DarkCyan;
            this.salasanaLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salasanaLB.ForeColor = System.Drawing.Color.Khaki;
            this.salasanaLB.Location = new System.Drawing.Point(138, 240);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(91, 25);
            this.salasanaLB.TabIndex = 4;
            this.salasanaLB.Text = "Salasana:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.salasanaLB);
            this.Controls.Add(this.kayttajaLB);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.kayttajaTB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Kirjautumisikkuna";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> ac8d35c9fd774df789e711954dd4290568ec6c38

        }

        #endregion

        private Button button1;
        private TextBox kayttajaTB;
        private TextBox salasanaTB;
        private Label kayttajaLB;
        private Label salasanaLB;
    }
}