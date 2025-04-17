using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace muistio
{

    public partial class muistioForm : Form
    {
        string tiedostoPolku;
        public muistioForm()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tekstiboksi.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                Tekstiboksi.Text = "";
            }
            else
            {
                Tekstiboksi.Text = "";
            }

        }
        public void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "TextDocument|*txt*|Rich Text Format|.rtf", ValidateNames = true, Multiselect = false })
            {

                if (atk.ShowDialog() == DialogResult.OK)
                {

                    tiedostoPolku = atk.FileName;
                    {
                        using (StreamReader vl = new StreamReader(atk.FileName))
                        {
                            tiedostoPolku = atk.FileName;
                            Task<string> teksti = vl.ReadToEndAsync();
                            Tekstiboksi.Rtf = teksti.Result;

                        }
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "TextDocument|*txt*|Rich Text Format|.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.Tekstiboksi.Rtf);
                        tiedosto.Close();
                    }
                }
            }

        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*txt*|Rich Text Format|.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(Tekstiboksi.Text);
                    }
                }
            }

        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Tämä homma ei ainakaan toimi?
            //tulostaa stringin/tekstin aloituskoordinaatteineen ja määrittelee fontin ominaisuudet
            /*e.Graphics.DrawString(Tekstiboksi.Text, Tekstiboksi.Font, Brushes.Black, 12, 10);*/
            Font printFont = Tekstiboksi.SelectionFont ?? Tekstiboksi.Font;//palauttaa oletusfontin jos fonttia ei löydy
            e.Graphics.DrawString(Tekstiboksi.Text, printFont, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.SelectAll();
        }

        private void leikkaaToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            Tekstiboksi.Cut();

        }
        private void Tekstiboksi_TextChanged(object sender, EventArgs e)
        {
            if (Tekstiboksi.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;

            }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinKorostusToolStripMenuItem.Checked = false;
                Tekstiboksi.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                Tekstiboksi.WordWrap = true;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Tekstiboksi.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekstiboksi.SelectionBackColor = Color.Yellow;
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }
    }

}