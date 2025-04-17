namespace oppilaitosten_tiedot
{
    partial class avainhloForm
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
            this.avainhloLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.postinroLB = new System.Windows.Forms.Label();
            this.PTpaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.osastoLB = new System.Windows.Forms.Label();
            this.sahkopostiLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // avainhloLB
            // 
            this.avainhloLB.AutoSize = true;
            this.avainhloLB.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avainhloLB.Location = new System.Drawing.Point(166, 9);
            this.avainhloLB.Name = "avainhloLB";
            this.avainhloLB.Size = new System.Drawing.Size(443, 47);
            this.avainhloLB.TabIndex = 0;
            this.avainhloLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse oppilaitos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(442, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valitse vastuuhenkilö:";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(117, 144);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(191, 33);
            this.oppilaitosCB.TabIndex = 3;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(442, 144);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(193, 33);
            this.vastuuhloCB.TabIndex = 4;
            this.vastuuhloCB.SelectedIndexChanged += new System.EventHandler(this.vastuuhloCB_SelectedIndexChanged);
            //this.vastuuhloCB.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osoiteLB.Location = new System.Drawing.Point(117, 209);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(66, 25);
            this.osoiteLB.TabIndex = 5;
            this.osoiteLB.Text = "Osoite";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titteliLB.Location = new System.Drawing.Point(442, 209);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(59, 25);
            this.titteliLB.TabIndex = 6;
            this.titteliLB.Text = "Titteli";
            // 
            // postinroLB
            // 
            this.postinroLB.AutoSize = true;
            this.postinroLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postinroLB.Location = new System.Drawing.Point(117, 243);
            this.postinroLB.Name = "postinroLB";
            this.postinroLB.Size = new System.Drawing.Size(118, 25);
            this.postinroLB.TabIndex = 7;
            this.postinroLB.Text = "Postinumero";
            // 
            // PTpaikkaLB
            // 
            this.PTpaikkaLB.AutoSize = true;
            this.PTpaikkaLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PTpaikkaLB.Location = new System.Drawing.Point(117, 280);
            this.PTpaikkaLB.Name = "PTpaikkaLB";
            this.PTpaikkaLB.Size = new System.Drawing.Size(149, 25);
            this.PTpaikkaLB.TabIndex = 8;
            this.PTpaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puhelinLB.Location = new System.Drawing.Point(117, 316);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(142, 25);
            this.puhelinLB.TabIndex = 9;
            this.puhelinLB.Text = "Puhelinnumero";
            // 
            // osastoLB
            // 
            this.osastoLB.AutoSize = true;
            this.osastoLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osastoLB.Location = new System.Drawing.Point(442, 243);
            this.osastoLB.Name = "osastoLB";
            this.osastoLB.Size = new System.Drawing.Size(69, 25);
            this.osastoLB.TabIndex = 10;
            this.osastoLB.Text = "Osasto";
            // 
            // sahkopostiLB
            // 
            this.sahkopostiLB.AutoSize = true;
            this.sahkopostiLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sahkopostiLB.Location = new System.Drawing.Point(442, 280);
            this.sahkopostiLB.Name = "sahkopostiLB";
            this.sahkopostiLB.Size = new System.Drawing.Size(104, 25);
            this.sahkopostiLB.TabIndex = 11;
            this.sahkopostiLB.Text = "Sähköposti";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puhLB.Location = new System.Drawing.Point(442, 316);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(76, 25);
            this.puhLB.TabIndex = 12;
            this.puhLB.Text = "Puhelin";
            // 
            // avainhloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.sahkopostiLB);
            this.Controls.Add(this.osastoLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.PTpaikkaLB);
            this.Controls.Add(this.postinroLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.osoiteLB);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avainhloLB);
            this.Name = "avainhloForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.avainhloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label avainhloLB;
        private Label label1;
        private Label label2;
        private ComboBox oppilaitosCB;
        private ComboBox comboBox1;
        private Label osoiteLB;
        private Label titteliLB;
        private Label postinroLB;
        private Label PTpaikkaLB;
        private Label puhelinLB;
        private Label osastoLB;
        private Label sahkopostiLB;
        private Label puhLB;
        private ComboBox vastuuhloCB;
    }
}