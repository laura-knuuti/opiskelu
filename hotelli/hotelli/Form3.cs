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

    public partial class AsiakkaidenHallinta : Form
    {
        // olion/classin määritys
        Asiakas asiakas = new Asiakas();
        public AsiakkaidenHallinta()
        {
            InitializeComponent();
        }
        
        private void otsikkoLB_Click(object sender, EventArgs e)
        {

        }

        private void AsiakkaidenHallinta_Load(object sender, EventArgs e)
        {
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String osoite = lahiosoiteTB.Text;
            String pnro = postinumeroTB.Text;
            String ppaikka = postitoimipaikkaTB.Text;
            String ktunnus = kayttajatunnusTB.Text;

            //trim poistaa turhat välilyönnit
            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("")
            || ppaikka.Trim().Equals("") || ktunnus.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät: Etu- ja sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean
                muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, pnro, ppaikka, ktunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void asiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            etunimiTB.Text = asiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            sukunimiTB.Text = asiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            lahiosoiteTB.Text = asiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            postinumeroTB.Text = asiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            postitoimipaikkaTB.Text = asiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            kayttajatunnusTB.Text = asiakkaatDG.CurrentRow.Cells[5].Value.ToString();

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = kayttajatunnusTB.Text;
            if (asiakas.poistaAsiakas(ktunnus))
            {
                asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }
    }
}
