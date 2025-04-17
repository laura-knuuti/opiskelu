namespace sekuntikello
{
    partial class secForm
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
            this.components = new System.ComponentModel.Container();
            this.kelloLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kelloLB
            // 
            this.kelloLB.AutoSize = true;
            this.kelloLB.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kelloLB.Location = new System.Drawing.Point(170, 72);
            this.kelloLB.Name = "kelloLB";
            this.kelloLB.Size = new System.Drawing.Size(307, 65);
            this.kelloLB.TabIndex = 0;
            this.kelloLB.Text = "00:00:00:000";
            this.kelloLB.Click += new System.EventHandler(this.kelloLB_Click);
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBT.Location = new System.Drawing.Point(99, 191);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(116, 41);
            this.startBT.TabIndex = 1;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopBT.Location = new System.Drawing.Point(258, 191);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(116, 41);
            this.stopBT.TabIndex = 2;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBT.Location = new System.Drawing.Point(412, 191);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(116, 41);
            this.resetBT.TabIndex = 3;
            this.resetBT.Text = "Reset";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // ajastinTM
            // 
            this.ajastinTM.Enabled = true;
            this.ajastinTM.Tick += new System.EventHandler(this.ajastinTM_Tick);
            // 
            // secForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 335);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.kelloLB);
            this.Name = "secForm";
            this.Load += new System.EventHandler(this.kelloLB_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kelloLB;
        private Button startBT;
        private Button stopBT;
        private Button resetBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}