namespace _10_kysymystä
{
    partial class lomake_form
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
            this.kysymysLB = new System.Windows.Forms.Label();
            this.vastaus_a = new System.Windows.Forms.RadioButton();
            this.vastaus_b = new System.Windows.Forms.RadioButton();
            this.vastaus_c = new System.Windows.Forms.RadioButton();
            this.vastaus_d = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dummyRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kysymysLB.Location = new System.Drawing.Point(56, 67);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(358, 30);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Vastaus ensimmäiseen kysymykseen: ";
            // 
            // vastaus_a
            // 
            this.vastaus_a.AutoSize = true;
            this.vastaus_a.Location = new System.Drawing.Point(54, 61);
            this.vastaus_a.Name = "vastaus_a";
            this.vastaus_a.Size = new System.Drawing.Size(33, 19);
            this.vastaus_a.TabIndex = 1;
            this.vastaus_a.TabStop = true;
            this.vastaus_a.Text = "A";
            this.vastaus_a.UseVisualStyleBackColor = true;
            this.vastaus_a.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // vastaus_b
            // 
            this.vastaus_b.AutoSize = true;
            this.vastaus_b.Location = new System.Drawing.Point(55, 86);
            this.vastaus_b.Name = "vastaus_b";
            this.vastaus_b.Size = new System.Drawing.Size(32, 19);
            this.vastaus_b.TabIndex = 2;
            this.vastaus_b.TabStop = true;
            this.vastaus_b.Text = "B";
            this.vastaus_b.UseVisualStyleBackColor = true;
            // 
            // vastaus_c
            // 
            this.vastaus_c.AutoSize = true;
            this.vastaus_c.Location = new System.Drawing.Point(55, 111);
            this.vastaus_c.Name = "vastaus_c";
            this.vastaus_c.Size = new System.Drawing.Size(33, 19);
            this.vastaus_c.TabIndex = 3;
            this.vastaus_c.TabStop = true;
            this.vastaus_c.Text = "C";
            this.vastaus_c.UseVisualStyleBackColor = true;
            // 
            // vastaus_d
            // 
            this.vastaus_d.AutoSize = true;
            this.vastaus_d.Location = new System.Drawing.Point(54, 136);
            this.vastaus_d.Name = "vastaus_d";
            this.vastaus_d.Size = new System.Drawing.Size(33, 19);
            this.vastaus_d.TabIndex = 4;
            this.vastaus_d.TabStop = true;
            this.vastaus_d.Text = "D";
            this.vastaus_d.UseVisualStyleBackColor = true;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(71, 225);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(88, 30);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "Vastaus:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dummyRB);
            this.groupBox1.Controls.Add(this.vastaus_a);
            this.groupBox1.Controls.Add(this.vastaus_b);
            this.groupBox1.Controls.Add(this.vastaus_c);
            this.groupBox1.Controls.Add(this.vastaus_d);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(485, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // dummyRB
            // 
            this.dummyRB.AutoSize = true;
            this.dummyRB.Location = new System.Drawing.Point(54, 36);
            this.dummyRB.Name = "dummyRB";
            this.dummyRB.Size = new System.Drawing.Size(31, 19);
            this.dummyRB.TabIndex = 6;
            this.dummyRB.TabStop = true;
            this.dummyRB.Text = "E";
            this.dummyRB.UseVisualStyleBackColor = true;
            this.dummyRB.Visible = false;
            // 
            // lomake_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.kysymysLB);
            this.Name = "lomake_form";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kysymysLB;
        private RadioButton vastaus_a;
        private RadioButton vastaus_b;
        private RadioButton vastaus_c;
        private RadioButton vastaus_d;
        private Label vastausRB;
        private Label vastausLB;
        private GroupBox groupBox1;
        private RadioButton dummyRB;
    }
}