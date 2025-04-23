using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelli
{
    public partial class VaraustenHallinta : Form
    {
        Huone huone = new Huone();
        Asiakas asiakas = new Asiakas();
        Varaus varaus = new Varaus();
        public VaraustenHallinta()
        {
            InitializeComponent();
        }
         
        private void VaraustenHallinta_Load(object sender, EventArgs e)
        {
            //haetaan listaus funktiosta huonetyyppilista
            //näytetään huonetyypin nimi (DisplayMember),
            //Mutta lähetetään eteenpäin KategoriaId (ValueMember)
            huonetyyppiCB.DataSource = huone.huonetyyppilista();
            huonetyyppiCB.DisplayMember = "Huonetyyppi";
            huonetyyppiCB.ValueMember = "KategoriaId";

            //haetaan listaus funktiosta asiakaslista
            //näytetään asiakkaan nimi (DisplayMember),
            //Mutta lähetetään eteenpäin KategoriaId (ValueMember)
            asiakasCB.DataSource = asiakas.haeAsiakkaat();
            asiakasCB.DisplayMember = "Kokonimi";
            asiakasCB.ValueMember = "AsiakasId";
            varausDG.DataSource = varaus.haeVaraukset();

        }

        private void varausBT_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(asiakasCB.SelectedValue.ToString());
            int huonenro = Convert.ToInt32(huonenroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(sisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(ulosDTP.Value);
            if (varaus.lisaaVaraus(huonenro, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (huone.vaihdaHuoneenVapaus("Kyllä", huonenro))
                {
                    MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
                }
                else
                {
                    MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
                }
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            varausDG.DataSource = varaus.haeVaraukset();
        }

        private void huonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //koska alin huonetyyppi = 1 ja index alkaa 0:sta, täytyy kasvattaa yhdellä
            int huonetp = huonetyyppiCB.SelectedIndex + 1;

            //haetaan huonenumerot huonetyypin perusteella
            huonenroCB.DataSource = huone.tyypillisetHuoneet(huonetp);
            huonenroCB.DisplayMember = "HuoneenNro";
            huonenroCB.ValueMember = "HuoneenNro";
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            int huone = Convert.ToInt32(huonenroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(asiakasCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(sisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(ulosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(varausnroTB.Text);
                if (varaus.muokkaaVarausta(huone, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            varausDG.DataSource = varaus.haeVaraukset();
        }

        private void varausDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void varausDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varausnroTB.Text = varausDG.CurrentRow.Cells[0].Value.ToString();
            asiakasCB.SelectedValue = varausDG.CurrentRow.Cells[2].Value.ToString();
            huonenroCB.SelectedValue = varausDG.CurrentRow.Cells[1].Value.ToString();
            sisaanDTP.Value = Convert.ToDateTime(varausDG.CurrentRow.Cells[3].Value);
            ulosDTP.Value = Convert.ToDateTime(varausDG.CurrentRow.Cells[4].Value);

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                int varausnro = Convert.ToInt32(varausnroTB.Text);
                /*int huonenro = huonenroCB.SelectedIndex;*/
                int huonenro = Convert.ToInt32(huonenroCB.SelectedValue);

                if (varaus.poistaVaraus(varausnro))
                {
                    varausDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    huone.vaihdaHuoneenVapaus("Ei", huonenro);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
            }
        }

        private void otsikkoLB_Click(object sender, EventArgs e)
        {

        }

        private void ulosDTP_ValueChanged(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(huonenroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(sisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(ulosDTP.Value);
            if (varaus.tarkistaPaiva(sisaankirjautuminen, uloskirjautuminen, huonenro))
            {

            }
            else MessageBox.Show("Tämä päivä on varattu tuossa huoneessa", "Päivämäärän tarkastus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //tyhjennaBT.PerformClick();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            varausnroTB.Text = "";
            asiakasCB.SelectedIndex = -1;
            huonetyyppiCB.SelectedIndex = -1;
            huonenroCB.SelectedIndex = -1;
            sisaanDTP.Value = DateTime.Now;
            ulosDTP.Value = DateTime.Now.AddDays(1);
        }
    }
}
