namespace BMI_laskuri
{
    partial class Form1
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
            this.painoLB = new System.Windows.Forms.Label();
            this.pituusLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painoLB
            // 
            this.painoLB.AutoSize = true;
            this.painoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoLB.Location = new System.Drawing.Point(101, 141);
            this.painoLB.Name = "painoLB";
            this.painoLB.Size = new System.Drawing.Size(112, 24);
            this.painoLB.TabIndex = 0;
            this.painoLB.Text = "Anna paino:";
            // 
            // pituusLB
            // 
            this.pituusLB.AutoSize = true;
            this.pituusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusLB.Location = new System.Drawing.Point(101, 83);
            this.pituusLB.Name = "pituusLB";
            this.pituusLB.Size = new System.Drawing.Size(115, 24);
            this.pituusLB.TabIndex = 1;
            this.pituusLB.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoTB.Location = new System.Drawing.Point(257, 141);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 29);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusTB.Location = new System.Drawing.Point(257, 83);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 29);
            this.pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskeBT.Location = new System.Drawing.Point(487, 101);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(119, 36);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske painoindeksi";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.Location = new System.Drawing.Point(100, 232);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(187, 25);
            this.vastausLB.TabIndex = 5;
            this.vastausLB.Text = "Painoindeksisi on:";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 393);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituusLB);
            this.Controls.Add(this.painoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label painoLB;
        private System.Windows.Forms.Label pituusLB;
        private System.Windows.Forms.TextBox painoTB;
        private System.Windows.Forms.TextBox pituusTB;
        private System.Windows.Forms.Button laskeBT;
        private System.Windows.Forms.Label vastausLB;
    }
}

