namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textlb.Text == "Heippa maailma!")
            {
                textlb.Text = "Jotain uutta tekstiä";
            }
            else
            {
                textlb.Text = "Heippa maailma!";
            }
        }
    }
}