namespace suosituimmat_nimet
{
    public partial class nimiForm : Form
    {
        public nimiForm()
        {
            InitializeComponent();
        }

        private void tarkastaBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = ""; //tyhjentää vastauskentän, että ohjelman voi suorittaa toistuvasti
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\laura.knuuti\\source\\Kevät2025\\Csharp\\C#\\suosituimmat_nimet\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\laura.knuuti\\source\\Kevät2025\\Csharp\\C#\\suosituimmat_nimet\\tytot.txt");
            string nimi = nimiTB.Text;
            int laskuriP = 1, laskuriT = 1;
            foreach (string poju in pojat)
            {
                if (nimi == poju)
                {
                    vastausLB.Text = "Nimesi on " + laskuriP + (". suosituin nimi poikien joukossa");
                    vastausLB.Visible = true;
                    return; //lopettaa etsimisen kun nimi löytyy
                }
                laskuriP++;
            }
            foreach (string typy in tytot)
            {
                if (nimi == typy)
                {
                    vastausLB.Text = "Nimesi on " + laskuriT + (". suosituin nimi tyttöjen joukossa");
                    vastausLB.Visible = true;
                    return;
                }
                laskuriT++;
            }
            if (vastausLB.Visible == false)
                {
                vastausLB.Text = "Nimesi ei ole 50 suosituimman nimen joukossa :(";
                vastausLB.Visible = true;
            }
        }
    }
 }
