namespace harjoitus3
{
    public partial class yksinkertainen_nelilaskin : Form
    {
        public yksinkertainen_nelilaskin()
        {
            InitializeComponent();
        }

        private void LaskeLB_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(Luku1TB.Text);
            float luku2 = float.Parse(Luku2TB.Text);
            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;
            {
                switch(merkki)
                {
                    case "+":
                        vastaus = luku1 + luku2;
                            break;
                    case "-":
                        vastaus = luku1 - luku2;
                            break;
                    case "*":
                        vastaus = luku1 * luku2;
                            break;
                    case "/":
                        vastaus = luku1 / luku2;
                            break;
                    default:
                        VastausLB.Text = "Tapahtui virhe!";
                        break;

                }
                VastausLB.Text = Convert.ToString(vastaus);
                VastausLB.Visible = true;

            }
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {
        }

        private void Luku1TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}