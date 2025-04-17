using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Eramake;
using Google.Protobuf.WellKnownTypes;
using System.Linq.Expressions;


namespace hotelli
{
    class Varaus
    {

        Yhdista yhteys = new Yhdista();


        //haetaan kaikki varaukset
        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT = FROM huonekategoria", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT = FROM varaukset", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;

        }


        public bool lisaaVaraus(int hnro, int anro, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `varaukset`" +
            "(HuoneenNro, AsiakasId, Sisaan, Ulos) " +
            "VALUES (@hno, @aid, @sis, @ulo); ";

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = anro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }
        }
        public bool muokkaaVarausta(int hnro, int asid, DateTime sisaan, DateTime ulos, int vara)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `varaukset` SET `HuoneenNro` = @hnro," +
<<<<<<< HEAD
                "`AsiakasId` = @aid, `Sisaan` = @sis, `Ulos` = @ulo WHERE VarausId = @vid";
=======
                "`AsiakasId` = @aid, `Sisaan` = @sis, `Ulos` = @ulo" +
             "WHERE VarausId = @vid";
>>>>>>> ac8d35c9fd774df789e711954dd4290568ec6c38
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hnro", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = asid;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
<<<<<<< HEAD
            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = vara;
=======
            komento.Parameters.Add("@ulo", MySqlDbType.Int32).Value = vara;
>>>>>>> ac8d35c9fd774df789e711954dd4290568ec6c38

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool poistaVaraus(String varausnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM varaukset WHERE VarausId = @vno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@vno", MySqlDbType.VarChar).Value = varausnro;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
<<<<<<< HEAD

        //funktion kutsussa annetaan valittu sisääntulo ja uloslähtö sekä huoneen numero
        public bool tarkistaPaiva(DateTime sis, DateTime ulo, int huone)
        {
            //Tehdään listat jo varatuille ajoille - yksi sisäänkirjautumista ja toinen uloskirjautumista varten
            List<DateTime> inside = new List<DateTime>();
            List<DateTime> outside = new List<DateTime>();
            //Tehdään muuttuja, joka palautetaan lopussa
            bool onValissa = true;
            //Otetaan yhteyttä tietokantaan
            MySqlCommand komento = new MySqlCommand();
            //Haetaan tietokannasta ne tiedot, jotka vastaavat annettua huonetta
            String kysely = "Select * FROM varaukset WHERE HuoneenNro = @hnro";

            using (MySqlConnection connection = new MySqlConnection(yhteys.yhteyslause()))
            using (MySqlCommand command = new MySqlCommand(kysely, connection))
            {
                command.Parameters.Add("@hnro", MySqlDbType.Int32).Value = huone;
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            inside.Add(reader.GetDateTime(3));
                            outside.Add(reader.GetDateTime(4));
                        }
                        reader.Close();
                    }
                }
            }
            for (int i = 0; i < inside.Count; i++)
            {
                if (inside[1] <= sis && sis <= outside[i])
                {
                    i = inside.Count;
                    onValissa = false;
                }
                else
                {
                    onValissa = true;
                }
            }
            return onValissa;
        }
=======
>>>>>>> ac8d35c9fd774df789e711954dd4290568ec6c38
    }
}
