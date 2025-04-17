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
    }
}
