namespace _10_kysymystä
{

    //määritellään muuttujat ja taulukot
    //oikeatVastaukset sisältää oikeat vastaukset kysymyksiin, ensimmäinen tyhjänä koska laskuri alkaa nollasta
    //vastaukset = taulukko johon vastaukset tallennetaan
    //laskuri pitää kirjaa montako kysymystä on vastattu ja kasvaa yhdellä aina kun kysymykseen on vastattu
    public partial class lomake_form : Form

    {
        int laskuri = 0; //
        int oikein = 0;
        string[] vastaukset = new string[11];
        string[] oikeatVastaukset = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };


        /* liittää eventhandlerit radiobuttonien "checked-change" tapahtumalle (eli aina kun valitaan nappi, kutsutaan
        "radiobutton_CheckedChange") joka käsittelee tapahtuman */
        public lomake_form()
        {
            InitializeComponent();
            vastaus_a.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastaus_b.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastaus_c.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastaus_d.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
        
        private void radioButton_CheckedChanged(object sender, EventArgs e) //"kuuntelee" painiketta
        {
            if (sender is RadioButton && laskuri < 10) //tarkistaa että kohde on radiobutton ja käyttäjä ei ole vastannut kaikkiin 10 kysymykseen
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text; //tallentaa vastauksen kohteeseen taulukkoon "vastaukset"
                laskuri++;                               //kasvatetaan yhdellä eli siirrytään seuraavan kysymykseen
                kysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:"; //päivitetään näyttämään käyttäjälle minkä kysymyksen vastaus ollaan antamassa
            }
            else
            {
                vastausLB.Text = "";
                vastaus_a.Enabled = false;
                vastaus_b.Enabled = false;
                vastaus_c.Enabled = false;
                vastaus_d.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }

                }
                vastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                vastausLB.Visible = true;
            }
            TyhjaaVastaus();
         }

        //jos vastaus on 10 tai enemmän, kaikki radiobuttonit estetään ja ohjelma laskee kuinka monta vastausta on annettu
        private void TyhjaaVastaus()
        {
            if (vastaus_a.Checked == true)
            {
                vastaus_a.Checked = false;
                laskuri--;
            }
            if (vastaus_b.Checked == true)
            {
                vastaus_b.Checked = false;
                laskuri--;
            }
            if (vastaus_c.Checked == true)
            {
                vastaus_c.Checked = false;
                laskuri--;
            }
            if (vastaus_d.Checked == true)
            {
                vastaus_d.Checked = false;
                laskuri--;
            }

        }
    }
}