namespace roomalaiset_numerot
{
    partial class RoNuForm
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
            RoNuLB = new Label();
            numeroTB = new TextBox();
            RoNuLB2 = new Label();
            numeroLB = new Label();
            muutaBT = new Button();
            SuspendLayout();
            // 
            // RoNuLB
            // 
            RoNuLB.AutoSize = true;
            RoNuLB.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            RoNuLB.ForeColor = Color.CornflowerBlue;
            RoNuLB.Location = new Point(436, 83);
            RoNuLB.Name = "RoNuLB";
            RoNuLB.Size = new Size(784, 116);
            RoNuLB.TabIndex = 0;
            RoNuLB.Text = "Roomalaiset Numerot";
            RoNuLB.Click += RoNuLB_Click;
            // 
            // numeroTB
            // 
            numeroTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numeroTB.Location = new Point(591, 333);
            numeroTB.Name = "numeroTB";
            numeroTB.Size = new Size(418, 50);
            numeroTB.TabIndex = 1;
            // 
            // RoNuLB2
            // 
            RoNuLB2.AutoSize = true;
            RoNuLB2.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RoNuLB2.Location = new Point(295, 232);
            RoNuLB2.Name = "RoNuLB2";
            RoNuLB2.Size = new Size(1077, 38);
            RoNuLB2.TabIndex = 2;
            RoNuLB2.Text = "Anna luku 1-3999 väliltä, niin näytän sen roomalaisina numeroina";
            // 
            // numeroLB
            // 
            numeroLB.AutoSize = true;
            numeroLB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numeroLB.Location = new Point(311, 615);
            numeroLB.Name = "numeroLB";
            numeroLB.Size = new Size(115, 48);
            numeroLB.TabIndex = 3;
            numeroLB.Text = "label1";
            numeroLB.Visible = false;
            // 
            // muutaBT
            // 
            muutaBT.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            muutaBT.Location = new Point(698, 445);
            muutaBT.Name = "muutaBT";
            muutaBT.Size = new Size(183, 82);
            muutaBT.TabIndex = 4;
            muutaBT.Text = "Muuta";
            muutaBT.UseVisualStyleBackColor = true;
            muutaBT.Click += muutaBT_Click;
            // 
            // RoNuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 843);
            Controls.Add(muutaBT);
            Controls.Add(numeroLB);
            Controls.Add(RoNuLB2);
            Controls.Add(numeroTB);
            Controls.Add(RoNuLB);
            Name = "RoNuForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoNuLB;
        private TextBox numeroTB;
        private Label RoNuLB2;
        private Label numeroLB;
        private Button muutaBT;
    }
}
