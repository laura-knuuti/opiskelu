using System.Diagnostics;

namespace ajastin
{
    public partial class ajastinForm : Form
    {

        private int kokonaisaika;
        public ajastinForm()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            //lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTM.Enabled = true;

        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTM.Enabled = false;
            ajastinLB.Text = "00:00";

        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                ajastinLB.Text = minuutit.ToString("D2") + ":" + sekunnit.ToString("D2");
            }
            else
            {
                ajastinTM.Enabled = false;
                MessageBox.Show("Aika loppui!");
            }

        }

        private void ajastinForm_Load(object sender, EventArgs e)
        {
            stopBT.Enabled = false; //poistaa stop-buttonin käytöstä
            for (int i = 0; i < 60; i++)
            {
                minCB.Items.Add(i.ToString()); //lisää minuutteihin 0-59
                sekCB.Items.Add(i.ToString()); //lisää sekunteihin 0-59
            }
            minCB.SelectedIndex = 0; //oletusindeksi
            sekCB.SelectedIndex = 20;  //oletusindeksi
        }
    }
}
