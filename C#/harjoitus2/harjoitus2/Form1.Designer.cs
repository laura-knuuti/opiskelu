namespace harjoitus2
{
    partial class OtsikkoLB
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
            this.label1 = new System.Windows.Forms.Label();
            this.TulostusLB = new System.Windows.Forms.Label();
            this.ViestiTB = new System.Windows.Forms.TextBox();
            this.TulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            this.TulostusLB.AutoSize = true;
            this.TulostusLB.Location = new System.Drawing.Point(197, 278);
            this.TulostusLB.Name = "TulostusLB";
            this.TulostusLB.Size = new System.Drawing.Size(72, 33);
            this.TulostusLB.TabIndex = 1;
            this.TulostusLB.Text = "xxxx";
            this.TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            this.ViestiTB.Location = new System.Drawing.Point(495, 226);
            this.ViestiTB.Name = "ViestiTB";
            this.ViestiTB.Size = new System.Drawing.Size(353, 41);
            this.ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            this.TulostaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TulostaBT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TulostaBT.Location = new System.Drawing.Point(715, 278);
            this.TulostaBT.Name = "TulostaBT";
            this.TulostaBT.Size = new System.Drawing.Size(133, 38);
            this.TulostaBT.TabIndex = 3;
            this.TulostaBT.Text = "Tulosta teksti";
            this.TulostaBT.UseVisualStyleBackColor = true;
            this.TulostaBT.Click += new System.EventHandler(this.TulostaBT_Click);
            // 
            // OtsikkoLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1600, 990);
            this.Controls.Add(this.TulostaBT);
            this.Controls.Add(this.ViestiTB);
            this.Controls.Add(this.TulostusLB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "OtsikkoLB";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}