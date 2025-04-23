using MySql.Data.MySqlClient;
using System.Data;


namespace hotelli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //kirjautumispainike, identiteetti unohtui...
        private void button1_Click(object sender, EventArgs e)
        {
            Yhdista tietokantaan = new Yhdista();

            // luodaan muuttujia yhdist�mist� varten (DataTable = System.Data)
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            //tehd��n kysely
            //SELECT = valitaan kent�t, FROM = taulun nimi WHERE = ehto
            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @kn AND Salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            //lis�t��n lomakkeelta muuttujiin @kn ja @ss tiedot
            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = salasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            //tarkistetaan onko k�ytt�j�nimi tietokannassa, eli jos rivi tulee yhdistelm� olemassa

            if (taulu.Rows.Count > 0)
            {
                //piilotetaan lomake ja avataan p��ikkuna
                this.Hide();
                Paaikkuna plomake = new Paaikkuna();
                plomake.Show();

            }
            //Muussa tapauksessa tarkistetaan, onko jompikumpi kentt� tyhj�
            else
            {
                if (kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Sy�t� k�ytt�j�nimesi kirjautuaksesi", "K�ytt�j�nimi on tyhj�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Sy�t� salasana kirjautuaksesi", "Salasana on tyhj�", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //kent�t on t�ytetty, mutta yhdistelm�� ei l�ydy
                else
                {
                    MessageBox.Show("K�ytt�j�nime� tai salasanaa ei l�ydy", "Tietoja ei l�ydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}