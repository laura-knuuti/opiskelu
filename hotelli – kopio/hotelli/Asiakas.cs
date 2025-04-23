using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//taas nämä
using MySql.Data.MySqlClient;
using System.Data;
//salasanaa varten
using Eramake;

namespace hotelli
{
    internal class Asiakas
    {
        Yhdista yhteys = new Yhdista();
        //Luodaan funktio, jonka avulla lisätään uusi asiakas

        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asiakkaat" +
            "(Kayttajanimi, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana) " +
            "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            if (kayttaja !="")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu",MySqlDbType.VarChar).Value = enimi.Substring(0,3).ToLower() + snimi.Substring(0,5).ToLower();
            }
            if(ssana !="")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(ssana);
            }
            else
            {
                string salasana = luoSalasana();
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());
                MessageBox.Show(luoSalasana());
            }

            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            { 
                return false; 
            }

        }

        //luodaan salasana

        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMOPQRSTUVWXYZ!?@#&%€$+-0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for (int i = 0; i < 10; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }

        //funktio asiakastietojen etsimiseen
        public DataTable haeAsiakkaat()
        {                                                  //CONCAT = yhdistää etunimen ja sukunimen yhdeksi (Kokonimi)
            MySqlCommand komento = new MySqlCommand("SELECT AsiakasId, CONCAT(Etunimi, ' ', Sukunimi) AS Kokonimi, Lahiosoite, Postinumero, Postitoimipaikka, Kayttajanimi FROM asiakkaat", yhteys.OtaYhteys());
            {
                MySqlDataAdapter adapteri = new MySqlDataAdapter();
                DataTable taulu = new DataTable();

                adapteri.SelectCommand = komento;
                adapteri.Fill(taulu);
                return taulu;
            }
        }

    //funktio asiakkaiden muokkaamiseen

    public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi` = @enm," +
                "`Sukunimi` = @snm, `Lahiosoite` = @oso, `Postinumero` = @pno, `Postitoimipaikka` = @ptp " +
                "WHERE Kayttajanimi = @ktu";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja;

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

        public bool poistaAsiakas(String kayttaja)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE Kayttajanimi = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja;


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
