namespace muistio
{
    partial class tietoa
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
            this.madebyLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // madebyLB
            // 
            this.madebyLB.AutoSize = true;
            this.madebyLB.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.madebyLB.Location = new System.Drawing.Point(226, 190);
            this.madebyLB.Name = "madebyLB";
            this.madebyLB.Size = new System.Drawing.Size(340, 45);
            this.madebyLB.TabIndex = 0;
            this.madebyLB.Text = "made by Laura Knuuti";
            // 
            // tietoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.madebyLB);
            this.Name = "tietoa";
            this.Text = "tietoa";
            this.Load += new System.EventHandler(this.tietoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label madebyLB;
    }
}