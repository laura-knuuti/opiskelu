using Eramake;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelli
{
    internal class Huone
    {
        Yhdista yhteys = new Yhdista();
        //Luodaan funktio huonetyyppien listaamiseksi

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoria", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;

        }

        //luodaan funktio huoneen lisäämiseksi
        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet" +
            "(HuoneenNro, Huonetyyppi, Puhelin, Vapaa) " +
            "VALUES (@hnro, @hty, @puh, @vap); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hnro", MySqlDbType.VarChar).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
                return true;
            }
        }

            //funktio huoneiden listaamiseksi
            public DataTable haeHuoneet()
            {
                MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.OtaYhteys());
                MySqlDataAdapter adapteri = new MySqlDataAdapter();
                DataTable taulu = new DataTable();

                adapteri.SelectCommand = komento;
                adapteri.Fill(taulu);
                return taulu;
            }

            //funktio huoneen muokkaamiseen

            public bool muokkaaHuonetta(int hnro, int htyyppi, String puh, String vapaa)
            {
                MySqlCommand komento = new MySqlCommand();
            //WHERE HuoneenNro = @hnro: päivittää vain sitä huonetta, jonka arvo on @hnro
            String paivityskysely = "UPDATE `huoneet` SET `Huonetyyppi` = @hty" +
                    "`Puhelin` = @puh, `Vapaa` = @vap WHERE `HuoneenNro` = @hnro";
                komento.CommandText = paivityskysely;
                komento.Connection = yhteys.OtaYhteys();
                komento.Parameters.Add("@hnro", MySqlDbType.VarChar).Value = hnro;
                komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htyyppi;
                komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
                komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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

            public bool poistaHuone(String hnro)
            {
                MySqlCommand komento = new MySqlCommand();
                String poistokysely = "DELETE FROM huoneet WHERE HuoneenNro = @hnro";
                komento.CommandText = poistokysely;
                komento.Connection = yhteys.OtaYhteys();
                komento.Parameters.Add("@hnro", MySqlDbType.VarChar).Value = hnro;


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
        //haetaan huoneet varauslomakkeelle merkityn huonetyypin mukaan
            public DataTable tyypillisetHuoneet(int htype)
            {
            MySqlCommand komento = new MySqlCommand();
<<<<<<< HEAD
            String lisayskysely = "SELECT * from huoneet WHERE Huonetyyppi = @hty AND Vapaa = 'Kyllä'";
=======
            String lisayskysely = "SELECT * from huoneet WHERE Huonetyyppi = @hty AND Vapaa = 'Kyllä";
>>>>>>> ac8d35c9fd774df789e711954dd4290568ec6c38
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htype;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
            }

            public bool vaihdaHuoneenVapaus(string vapaus, int huone)

            //vaihdetaan varaustilaa
        {
            if(vapaus == "Kyllä")
            {
                vapaus = "Ei";
            }
            else
            {
                vapaus = "Kyllä";
            }
            MySqlCommand komento = new MySqlCommand();
            //SET Vapaa = vaihdetaan sarakkeen Vapaa arvoksi @vap-arvo (@vap = "Kyllä" vapauttaa huoneen)
            //WHERE HuoneenNro = @hnro: päivittää vain sitä huonetta, jonka arvo on @hnro
            String paivityskysely = "UPDATE `huoneet` SET `Vapaa` = @vap WHERE HuoneenNro = @hnro";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hnro", MySqlDbType.Int32).Value = huone;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaus;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

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
        }
    }

