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
    public partial class HuoneidenHallinta : Form
    {
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }

        Huone huone = new Huone();

        private void huonenroTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void HuoneidenHallinta_Load(object sender, EventArgs e)
        {
            huonetyyppiCB.DataSource = huone.huonetyyppilista();
            huonetyyppiCB.DisplayMember = "Huonetyyppi";
            huonetyyppiCB.ValueMember = "KategoriaId";

            huoneetDG.DataSource = huone.haeHuoneet();
        }

        private void lisaahuoneBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(huonenroTB.Text);
            int tyyppi = Convert.ToInt32(huonetyyppiCB.SelectedValue.ToString());
            String puhelin = puhelinTB.Text;
            if (huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            huonenroTB.Text = "";
            huonetyyppiCB.SelectedIndex = 0;
            puhelinTB.Text = "";
        }

        private void huoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huonenroTB.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();
            huonetyyppiCB.SelectedValue = huoneetDG.CurrentRow.Cells[1].Value.ToString();
            puhelinTB.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(huonetyyppiCB.SelectedValue.ToString());
            String puhelin = puhelinTB.Text;
            String vapaa = "";
            try
            {
                int numero = Convert.ToInt32(huonenroTB.Text);
                if (kylla_RB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }
                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pysty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            huoneetDG.DataSource = huone.haeHuoneet();

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = huonenroTB.Text;
                if (huone.poistaHuone(huonenro))
                {
                    huoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex.Message);
            }
        }
    }
}
