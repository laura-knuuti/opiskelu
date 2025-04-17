using System.Diagnostics.Eventing.Reader;

namespace roomalaiset_numerot
{
    public partial class RoNuForm : Form
    {
        public RoNuForm()
        {
            InitializeComponent();
        }

        private void RoNuLB_Click(object sender, EventArgs e)
        {

        }

        private void muutaBT_Click(object sender, EventArgs e)
        {
            {

                int luku1, luku2, luku3, luku4;
                string vastaus = "";
                if (numeroTB.Text.Length == 4) //jos on tuhatluku

                {
                    luku1 = int.Parse(numeroTB.Text.Substring(0, 1)); //tuhannet
                    luku2 = int.Parse(numeroTB.Text.Substring(1, 1)); //sadat
                    luku3 = int.Parse(numeroTB.Text.Substring(2, 1)); //kymmenet
                    luku4 = int.Parse(numeroTB.Text.Substring(3, 1)); //ykköset
                    /*
                    if (luku1 % 3 == 0)

                    {
                        vastaus += "MMM";
                    }
                    else if (luku1 % 2 == 0)
                    {
                        vastaus += "MM";
                    }
                    else if (luku1 % 1 == 0)
                    {
                        vastaus += "M";
                    }
                    else
                    {
                        vastaus = "";
                    }
                    vastaus += sataset(luku2, vastaus);
                    vastaus += kymmenet(luku3, vastaus);
                    vastaus += ykkoset(luku4, vastaus);*/
                        
                        // tuhannet
                        if (luku1 == 1) vastaus += "M";
                        else if (luku1 == 2) vastaus += "MM";
                        else if (luku1 == 3) vastaus += "MMM";

                    vastaus += sataset(luku2);
                    vastaus += kymmenet(luku3);
                    vastaus += ykkoset(luku4);
                }


                    else if (numeroTB.Text.Length == 3) //jos on sataluku
                    {
                        luku2 = int.Parse(numeroTB.Text.Substring(0, 1)); //sadat
                        luku3 = int.Parse(numeroTB.Text.Substring(1, 1)); //kymmenet
                        luku4 = int.Parse(numeroTB.Text.Substring(2, 1)); //ykköset
                        vastaus += sataset(luku2);
                        vastaus += kymmenet(luku3);
                        vastaus += ykkoset(luku4);
            }
                    else if (numeroTB.Text.Length == 2) //jos on kymmenluku
                    {
                        luku3 = int.Parse(numeroTB.Text.Substring(0, 1)); //kymmenet
                        luku4 = int.Parse(numeroTB.Text.Substring(1, 1)); //ykköset
                        vastaus += kymmenet(luku3);
                        vastaus += ykkoset(luku4);
                    }
                    else if (numeroTB.Text.Length == 1  ) //jos on ykkösluku
                    {
                        luku4 = int.Parse(numeroTB.Text.Substring(0, 1)); //ykköset
                        vastaus += ykkoset(luku4);
                    }
                    numeroLB.Text = vastaus;
                    numeroLB.Visible = true;
                }
            }

        private string sataset(int luku2)
        {
            switch (luku2)
            {
                case 1: return "C";
                case 2: return "CC";
                case 3: return "CCC";
                case 4: return "CD";
                case 5: return "D";
                case 6: return "DC";
                case 7: return "DCC";
                case 8: return "DCCC";
                case 9: return "CM";
                default: return "";
            }
        }
        private string kymmenet(int luku3)
        {
            switch (luku3)
            {
                case 1: return "X";
                case 2: return "XX";
                case 3: return "XXX";
                case 4: return "XL";
                case 5: return "L";
                case 6: return "LX";
                case 7: return "LXX";
                case 8: return "LXXX";
                case 9: return "XC";
                default: return "";
            }
        }
        private string ykkoset(int luku4)
        {
          switch (luku4)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                default: return "";
            }

        }
    }
}
