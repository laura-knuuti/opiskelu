using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oppilashallintajärjestelmä
{
    public partial class ohjFORM : Form
    {
        Opiskelija opiskelija = new Opiskelija();
        public ohjFORM()
        {
            InitializeComponent();
        }

        private void ohjFORM_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
=======
            tietotauluDT.DataSource = opiskelija.haeOpiskelijat();

>>>>>>> 8de8d1a07121ea64a1f86481f8ad3da6c2e43259
        }

        private void tyhjennaTB_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            IDTB.Text = "";
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            puhelinTB.Text = "";
            sahkopostiTB.Text = "";
            opiskelijanroTB.Text = "";
=======
            IDTB = "";
            etunimiTB = "";
            sukunimiTB = "";
            puhelinTB = "";
            sahkopostiTB = "";
            opiskelijanroTB = "";
>>>>>>> 8de8d1a07121ea64a1f86481f8ad3da6c2e43259
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
<<<<<<< HEAD
            {
=======
                    {
>>>>>>> 8de8d1a07121ea64a1f86481f8ad3da6c2e43259
                MessageBox.Show("Virhe - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
<<<<<<< HEAD
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            }
        }

        private void PäivitäBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int Onro = int.Parse(opiskelijanroTB.Text);
            int Oid = int.Parse(IDTB.Text);

            if (Oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || Onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät: ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(Oid, enimi, snimi, puhelin, email, Onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
    private void tietotauluDG_CellClick(object sender , DataGridViewCellEventArgs e)
        {
            tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            IDTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            etunimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sukunimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            sahkopostiTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijanroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IDTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaTB.PerformClick();
        }

        private void tietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            IDTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            etunimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sukunimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            sahkopostiTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijanroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
=======

            }
>>>>>>> 8de8d1a07121ea64a1f86481f8ad3da6c2e43259

        }
    }
}
