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
            this.label1 = new System.Windows.Forms.Label();
            this.textlb = new System.Windows.Forms.Label();
            this.nappi1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "l";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textlb
            // 
            this.textlb.AutoSize = true;
            this.textlb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textlb.Location = new System.Drawing.Point(377, 217);
            this.textlb.Name = "textlb";
            this.textlb.Size = new System.Drawing.Size(82, 37);
            this.textlb.TabIndex = 2;
            this.textlb.Text = "Teksti";
            // 
            // nappi1
            // 
            this.nappi1.Location = new System.Drawing.Point(384, 311);
            this.nappi1.Name = "nappi1";
            this.nappi1.Size = new System.Drawing.Size(75, 23);
            this.nappi1.TabIndex = 3;
            this.nappi1.Text = "Nappi";
            this.nappi1.UseVisualStyleBackColor = true;
            this.nappi1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nappi1);
            this.Controls.Add(this.textlb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "eryw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label textlb;
        private Button nappi1;
    }
}