using Microsoft.VisualBasic.ApplicationServices;

namespace Päiväkirja
{
    public partial class paivakirjaForm : Form
    {
        public paivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText(@"C:\\Users\\laura.knuuti\\source\\repos\\Kevät2025\\Päiväkirja\\paivakirja.txt");
            syottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += syottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            //estää ylikirjoittamisen ja sulkee tiedoston automaattisesti
            using (TextWriter text = new StreamWriter("C:\\Users\\laura.knuuti\\source\\repos\\Kevät2025\\Päiväkirja\\paivakirja.txt", true))
            {
                text.Write(teksti);
            }
            Application.Exit();//sulkee ohjelman
        }
    }
}