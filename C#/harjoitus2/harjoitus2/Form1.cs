namespace harjoitus2
{
    public partial class OtsikkoLB : Form
    {
        public OtsikkoLB()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;

        }
    }
}