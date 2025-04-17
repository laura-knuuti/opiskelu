using System.Diagnostics;

namespace sekuntikello
{
    public partial class secForm : Form
    {
        private Stopwatch sekkari = new Stopwatch();

        public secForm()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void kelloLB_Click(object sender, EventArgs e)
        {

        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            //Tämä ei toiminut, mahdollisesti koska 7.0 doc? ChatGPT osasi auttaa.
            /*
            kelloLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff }", sekkari.Elapsed);
            */
            
            TimeSpan aika = sekkari.Elapsed;
            kelloLB.Text = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}",
                                         aika.Hours, aika.Minutes, aika.Seconds, aika.Milliseconds);

        }
    }
}