using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Muista nämä
using MySql.Data.MySqlClient;
using System.Data;


//Class joka yhdistää SQL-tietokantaan

namespace hotelli
{
    internal class Yhdista
    {
        //datasource + port = sijainti + portti database = käytettävä tietokanta
        //Vältä "tosihommissa" oletuksia eli salasana = root ja password = tyhjä...
      private readonly MySqlConnection yhteys = new MySqlConnection  ("datasource=localhost; port=3306; username=root; password=; database=hotelli");

        public MySqlConnection OtaYhteys()
        {
            return yhteys;
        }

        //funktio yhteyden avaamista varten
    public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        //funktio yhteyden sulkemista varten
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
            yhteys.Close();
            }
        }

        public string yhteyslause()
        {
            return yhteys.ConnectionString;
        }
    }
}
