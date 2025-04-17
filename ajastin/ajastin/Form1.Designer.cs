namespace ajastin
{
    partial class ajastinForm
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
            components = new System.ComponentModel.Container();
            startBT = new Button();
            stopBT = new Button();
            ajastinLB = new Label();
            minLB = new Label();
            sekLB = new Label();
            minCB = new ComboBox();
            sekCB = new ComboBox();
            ajastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // startBT
            // 
            startBT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startBT.Location = new Point(137, 400);
            startBT.Name = "startBT";
            startBT.Size = new Size(173, 79);
            startBT.TabIndex = 0;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // stopBT
            // 
            stopBT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            stopBT.Location = new Point(399, 400);
            stopBT.Name = "stopBT";
            stopBT.Size = new Size(173, 79);
            stopBT.TabIndex = 1;
            stopBT.Text = "Stop";
            stopBT.UseVisualStyleBackColor = true;
            stopBT.Click += stopBT_Click;
            // 
            // ajastinLB
            // 
            ajastinLB.AutoSize = true;
            ajastinLB.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            ajastinLB.Location = new Point(148, 184);
            ajastinLB.Name = "ajastinLB";
            ajastinLB.Size = new Size(435, 191);
            ajastinLB.TabIndex = 2;
            ajastinLB.Text = "00:00";
            // 
            // minLB
            // 
            minLB.AutoSize = true;
            minLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            minLB.Location = new Point(169, 56);
            minLB.Name = "minLB";
            minLB.Size = new Size(141, 45);
            minLB.TabIndex = 3;
            minLB.Text = "Minuutit";
            // 
            // sekLB
            // 
            sekLB.AutoSize = true;
            sekLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sekLB.Location = new Point(409, 56);
            sekLB.Name = "sekLB";
            sekLB.Size = new Size(143, 45);
            sekLB.TabIndex = 4;
            sekLB.Text = "Sekunnit";
            // 
            // minCB
            // 
            minCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            minCB.FormattingEnabled = true;
            minCB.Location = new Point(148, 128);
            minCB.Name = "minCB";
            minCB.Size = new Size(182, 53);
            minCB.TabIndex = 5;
            // 
            // sekCB
            // 
            sekCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sekCB.FormattingEnabled = true;
            sekCB.Location = new Point(390, 128);
            sekCB.Name = "sekCB";
            sekCB.Size = new Size(182, 53);
            sekCB.TabIndex = 6;
            // 
            // ajastinTM
            // 
            ajastinTM.Interval = 1000;
            ajastinTM.Tick += ajastinTM_Tick;
            // 
            // ajastinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 543);
            Controls.Add(sekCB);
            Controls.Add(minCB);
            Controls.Add(sekLB);
            Controls.Add(minLB);
            Controls.Add(ajastinLB);
            Controls.Add(stopBT);
            Controls.Add(startBT);
            Name = "ajastinForm";
            Text = "Form1";
            Load += ajastinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBT;
        private Button stopBT;
        private Label ajastinLB;
        private Label minLB;
        private Label sekLB;
        private ComboBox minCB;
        private ComboBox sekCB;
        private System.Windows.Forms.Timer ajastinTM;
    }
}
