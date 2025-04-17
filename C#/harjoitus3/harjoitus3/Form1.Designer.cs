namespace harjoitus3
{
    partial class yksinkertainen_nelilaskin
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
            this.Luku1TB = new System.Windows.Forms.TextBox();
            this.Luku2TB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LaskeLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Luku1TB
            // 
            this.Luku1TB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Luku1TB.Location = new System.Drawing.Point(142, 117);
            this.Luku1TB.Name = "Luku1TB";
            this.Luku1TB.Size = new System.Drawing.Size(100, 35);
            this.Luku1TB.TabIndex = 0;
            this.Luku1TB.Text = "1";
            this.Luku1TB.TextChanged += new System.EventHandler(this.Luku1TB_TextChanged);
            // 
            // Luku2TB
            // 
            this.Luku2TB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Luku2TB.Location = new System.Drawing.Point(332, 117);
            this.Luku2TB.Name = "Luku2TB";
            this.Luku2TB.Size = new System.Drawing.Size(100, 35);
            this.Luku2TB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            " -",
            " *",
            " /"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(260, 117);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(52, 38);
            this.LaskutoimitusCB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(471, 120);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(25, 30);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "X";
            this.VastausLB.Click += new System.EventHandler(this.VastausLB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(438, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // LaskeLB
            // 
            this.LaskeLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeLB.Location = new System.Drawing.Point(518, 114);
            this.LaskeLB.Name = "LaskeLB";
            this.LaskeLB.Size = new System.Drawing.Size(75, 36);
            this.LaskeLB.TabIndex = 5;
            this.LaskeLB.Text = "Laske";
            this.LaskeLB.UseVisualStyleBackColor = true;
            this.LaskeLB.Click += new System.EventHandler(this.LaskeLB_Click);
            // 
            // yksinkertainen_nelilaskin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskeLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.Luku2TB);
            this.Controls.Add(this.Luku1TB);
            this.Name = "yksinkertainen_nelilaskin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Luku1TB;
        private TextBox Luku2TB;
        private ComboBox LaskutoimitusCB;
        private Label VastausLB;
        private Label label1;
        private Button LaskeLB;
    }
}