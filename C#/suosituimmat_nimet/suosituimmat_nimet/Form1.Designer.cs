namespace suosituimmat_nimet
{
    partial class nimiForm
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
            this.nimiLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nimiLB
            // 
            this.nimiLB.AutoSize = true;
            this.nimiLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nimiLB.Location = new System.Drawing.Point(81, 73);
            this.nimiLB.Name = "nimiLB";
            this.nimiLB.Size = new System.Drawing.Size(639, 25);
            this.nimiLB.TabIndex = 0;
            this.nimiLB.Text = "Anna nimesi, niin tarkastan onko se 50 suosituimman nimen joukossa: ";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(136, 288);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(65, 25);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // nimiTB
            // 
            this.nimiTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nimiTB.Location = new System.Drawing.Point(270, 127);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(218, 33);
            this.nimiTB.TabIndex = 2;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.BackColor = System.Drawing.Color.DodgerBlue;
            this.tarkastaBT.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tarkastaBT.ForeColor = System.Drawing.Color.MintCream;
            this.tarkastaBT.Location = new System.Drawing.Point(303, 198);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(149, 39);
            this.tarkastaBT.TabIndex = 3;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = false;
            this.tarkastaBT.Click += new System.EventHandler(this.tarkastaBT_Click);
            // 
            // nimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarkastaBT);
            this.Controls.Add(this.nimiTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.nimiLB);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "nimiForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nimiLB;
        private Label vastausLB;
        private TextBox nimiTB;
        private Button tarkastaBT;
    }
}