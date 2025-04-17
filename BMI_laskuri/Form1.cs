using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0;
            double pituus = 0;
            paino = double.Parse(painoTB.Text);
            pituus = double.Parse(pituusTB.Text);
            double BMI = Math.Round(paino / (pituus * pituus)); //Math.Round pyöristää lähimpään kokonaislukuun
            if (BMI < 18.5)
            {
                vastausLB.Text = "Painoindeksisi on " + BMI.ToString("F2") + " Alipaino"; // F2 rajoittaa desimaalit kahteen
                vastausLB.ForeColor = Color.DeepSkyBlue;
            }
            
            else if (BMI >= 18.5 && BMI < 25)
            {
                vastausLB.Text = "Painoindeksisi on " + BMI.ToString("F2") + " Normaalipaino";
                vastausLB.ForeColor = Color.SpringGreen;
            }
            else if (BMI >= 25 && BMI < 40)
            {
                vastausLB.Text = "Painoindeksisi on " + BMI.ToString("F2") + "  Ylipaino";
                vastausLB.ForeColor = Color.Orange;
            }
            else
            {
                vastausLB.Text = "Painoindeksisi on " + BMI.ToString("F2") + "  Huomattava ylipaino";
                vastausLB.ForeColor = Color.Red;
            }
            vastausLB.Visible = true;
        }
    }
}
