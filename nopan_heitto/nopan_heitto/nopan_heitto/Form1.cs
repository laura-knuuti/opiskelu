namespace nopan_heitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void heittoBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
        }

        private void piirraNoppa(PictureBox noppaBox)

        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    noppaBox.Image = Properties.Resources.dice01;
                    break;

                case 2:
                    noppaBox.Image = Properties.Resources.dice02;
                    break;

                case 3:
                    noppaBox.Image = Properties.Resources.dice03;
                    break;

                case 4:
                    noppaBox.Image = Properties.Resources.dice04;
                    break;

                case 5:
                    noppaBox.Image = Properties.Resources.dice05;
                    break;

                case 6:
                    noppaBox.Image = Properties.Resources.dice06;
                    break;

            }

        }

    }

}