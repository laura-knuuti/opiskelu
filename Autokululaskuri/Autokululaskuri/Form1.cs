namespace Autokululaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lainaTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void kmCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, muut, polttoneste, pesut, huollot, renkaat, kilometrit, yhteensa;
            laina = double.Parse(lainaTB.Text);
            nesteet = double.Parse(nesteetTB.Text);
            vakuutus = double.Parse(vakuutusTB.Text);
            muut = double.Parse(muutTB.Text); 
            polttoneste = double.Parse(polttonesteTB.Text);
            pesut = double.Parse(pesutTB.Text);
            huollot = double.Parse(huollotTB.Text);
            renkaat = double.Parse(renkaatTB.Text);
            kilometrit = double.Parse(kmCB.Text);
            yhteensa = (laina + nesteet + vakuutus + muut + polttoneste + pesut + huollot + renkaat) / (kilometrit/12);
            yhteensaLB.Text = "Kustannukset kilometriä kohti ovat: " + yhteensa;
            yhteensaLB.Visible = true;
        }
    }
}
