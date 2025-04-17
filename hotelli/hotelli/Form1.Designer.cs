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
            button1.Location = new Point(423, 558);
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

        }

        #endregion

        private Button button1;
        private TextBox kayttajaTB;
        private TextBox salasanaTB;
        private Label kayttajaLB;
        private Label salasanaLB;
    }
}