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

            // luodaan muuttujia yhdistämistä varten (DataTable = System.Data)
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            //tehdään kysely
            //SELECT = valitaan kentät, FROM = taulun nimi WHERE = ehto
            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @kn AND Salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            //lisätään lomakkeelta muuttujiin @kn ja @ss tiedot
            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = salasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            //tarkistetaan onko käyttäjänimi tietokannassa, eli jos rivi tulee yhdistelmä olemassa

            if (taulu.Rows.Count > 0)
            {
                //piilotetaan lomake ja avataan pääikkuna
                this.Hide();
                Paaikkuna plomake = new Paaikkuna();
                plomake.Show();

            }
            //Muussa tapauksessa tarkistetaan, onko jompikumpi kenttä tyhjä
            else
            {
                if (kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi kirjautuaksesi", "Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //kentät on täytetty, mutta yhdistelmää ei löydy
                else
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}