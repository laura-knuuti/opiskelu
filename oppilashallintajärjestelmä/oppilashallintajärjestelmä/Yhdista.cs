using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace oppilashallintajärjestelmä
{
    internal class Yhdista
    {
<<<<<<< HEAD
        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =;  database = opiskelija");
=======
        public string yhteyslause()
        {
            return "datasource=localhost;port=3306;username=root;database=hotelli";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =;  database = hotelli");
>>>>>>> 8de8d1a07121ea64a1f86481f8ad3da6c2e43259

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        //funktio yhteyden avaamiseen
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        //funktio yhteyden sulkemiseen
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}