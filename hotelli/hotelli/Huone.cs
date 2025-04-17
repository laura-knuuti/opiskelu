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
                String paivityskysely = "UPDATE `huoneet` SET `Huonetyyppi` = @hty," +
                    "`Puhelin` = @puh, `Vapaa` = @vap, WHERE `HuoneenNro` = @hno`";
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
        }
    }

