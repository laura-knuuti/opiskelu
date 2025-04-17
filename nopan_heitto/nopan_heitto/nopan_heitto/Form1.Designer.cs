namespace nopan_heitto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.heittoBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nopan heitto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = ((System.Drawing.Image)(resources.GetObject("noppa01PB.Image")));
            this.noppa01PB.Location = new System.Drawing.Point(166, 121);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(154, 135);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 1;
            this.noppa01PB.TabStop = false;
            this.noppa01PB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = ((System.Drawing.Image)(resources.GetObject("noppa02PB.Image")));
            this.noppa02PB.Location = new System.Drawing.Point(437, 121);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(134, 135);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 2;
            this.noppa02PB.TabStop = false;
            // 
            // heittoBT
            // 
            this.heittoBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heittoBT.Location = new System.Drawing.Point(298, 324);
            this.heittoBT.Name = "heittoBT";
            this.heittoBT.Size = new System.Drawing.Size(155, 51);
            this.heittoBT.TabIndex = 3;
            this.heittoBT.Text = "Heitä";
            this.heittoBT.UseVisualStyleBackColor = true;
            this.heittoBT.Click += new System.EventHandler(this.heittoBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.heittoBT);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button heittoBT;
    }
}