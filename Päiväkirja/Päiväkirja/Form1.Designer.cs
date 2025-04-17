namespace Päiväkirja
{
    partial class paivakirjaForm
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
            this.syottoTB = new System.Windows.Forms.TextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syottoTB
            // 
            this.syottoTB.Location = new System.Drawing.Point(34, 26);
            this.syottoTB.Multiline = true;
            this.syottoTB.Name = "syottoTB";
            this.syottoTB.Size = new System.Drawing.Size(718, 272);
            this.syottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            this.TallennaBT.BackColor = System.Drawing.Color.Violet;
            this.TallennaBT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TallennaBT.ForeColor = System.Drawing.Color.GhostWhite;
            this.TallennaBT.Location = new System.Drawing.Point(327, 322);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(155, 61);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = false;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // paivakirjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.syottoTB);
            this.Name = "paivakirjaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox syottoTB;
        private Button TallennaBT;
    }
}