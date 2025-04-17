namespace WinFormsApp1
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
            this.asteetLB = new System.Windows.Forms.Label();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muunnaLB = new System.Windows.Forms.Label();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // asteetLB
            // 
            this.asteetLB.AutoSize = true;
            this.asteetLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asteetLB.Location = new System.Drawing.Point(69, 80);
            this.asteetLB.Name = "asteetLB";
            this.asteetLB.Size = new System.Drawing.Size(115, 25);
            this.asteetLB.TabIndex = 0;
            this.asteetLB.Text = "Anna asteet:";
            // 
            // asteetTB
            // 
            this.asteetTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asteetTB.Location = new System.Drawing.Point(210, 72);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(100, 33);
            this.asteetTB.TabIndex = 1;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(69, 166);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(80, 25);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "Vastaus:";
            // 
            // muunnaLB
            // 
            this.muunnaLB.AutoSize = true;
            this.muunnaLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.muunnaLB.Location = new System.Drawing.Point(407, 75);
            this.muunnaLB.Name = "muunnaLB";
            this.muunnaLB.Size = new System.Drawing.Size(151, 25);
            this.muunnaLB.TabIndex = 6;
            this.muunnaLB.Text = "Miten muunnat?";
            // 
            // muunnaBT
            // 
            this.muunnaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.muunnaBT.Location = new System.Drawing.Point(264, 277);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(107, 51);
            this.muunnaBT.TabIndex = 7;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.celsiusRB.Location = new System.Drawing.Point(422, 134);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(89, 29);
            this.celsiusRB.TabIndex = 8;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius";
            this.celsiusRB.UseVisualStyleBackColor = true;
            this.celsiusRB.Visible = false;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FahrenheitRB.Location = new System.Drawing.Point(422, 172);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(119, 29);
            this.FahrenheitRB.TabIndex = 9;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 371);
            this.Controls.Add(this.FahrenheitRB);
            this.Controls.Add(this.celsiusRB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.muunnaLB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.asteetLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label asteetLB;
        private TextBox asteetTB;
        private Label vastausLB;
        private Label muunnaLB;
        private Button muunnaBT;
        private RadioButton celsiusRB;
        private RadioButton FahrenheitRB;
    }
}