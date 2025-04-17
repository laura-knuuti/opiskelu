namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = double.Parse(asteetTB.Text);
            if (celsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = vastaus + "Celsiusta";
                vastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked )
            {
                vastaus = (asteet - 32) / 1.8;
                vastausLB.Text = vastaus + "Fahrenheitia";
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "Virheellinen lukema"
                vastausLB.Visible = true;
            }

        }
    }
}