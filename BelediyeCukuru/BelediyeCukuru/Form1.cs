using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelediyeCukuru
{
    public partial class Form1 : Form
    {

        int[] dolular = new int[4];
        int deneme = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLevel11_Click(object sender, EventArgs e)
        {
            Check(1, 1);
        }

        private void btnLevel12_Click(object sender, EventArgs e)
        {
            Check(1, 2);
        }

        private void btnLevel13_Click(object sender, EventArgs e)
        {
            Check(1, 3);
        }

        private void btnLevel21_Click(object sender, EventArgs e)
        {
            Check(2, 1);
        }

        private void btnLevel22_Click(object sender, EventArgs e)
        {
            Check(2, 2);
        }

        private void btnLevel23_Click(object sender, EventArgs e)
        {
            Check(2, 3);
        }

        private void btnLevel31_Click(object sender, EventArgs e)
        {
            Check(3, 1);
        }

        private void btnLevel32_Click(object sender, EventArgs e)
        {
            Check(3, 2);
        }

        private void btnLevel33_Click(object sender, EventArgs e)
        {
            Check(3, 3);
        }

        private void btnLevel41_Click(object sender, EventArgs e)
        {
            Check(4, 1);
        }

        private void btnLevel42_Click(object sender, EventArgs e)
        {
            Check(4, 2);
        }

        private void btnLevel43_Click(object sender, EventArgs e)
        {
            Check(4, 3);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ButonlariHazirlaYeniden();
            deneme = 0;
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                dolular[i] = random.Next(2) + 1;
            }
        }

        private void Check(int asama, int tiklananKutuNo)
        {
            deneme++;
            if (asama == 1 && dolular[0] == tiklananKutuNo) // bildi ise
            {
                btnLevel11.Enabled = false;
                btnLevel12.Enabled = false;
                btnLevel13.Enabled = false;
                btnLevel21.Enabled = true;
                btnLevel22.Enabled = true;
                btnLevel23.Enabled = true;
                lbResult.Text = "Tebrikler 2.Aşamaya Geçtiniz";
            }
            else if (asama == 2 && dolular[1] == tiklananKutuNo)
            {
                btnLevel21.Enabled = false;
                btnLevel22.Enabled = false;
                btnLevel23.Enabled = false;
                btnLevel31.Enabled = true;
                btnLevel32.Enabled = true;
                btnLevel33.Enabled = true;
                lbResult.Text = "Tebrikler 3.Aşamaya Geçtiniz";
            }
            else if (asama == 3 && dolular[2] == tiklananKutuNo)
            {
                btnLevel31.Enabled = false;
                btnLevel32.Enabled = false;
                btnLevel33.Enabled = false;
                btnLevel41.Enabled = true;
                btnLevel42.Enabled = true;
                btnLevel43.Enabled = true;
                lbResult.Text = "Tebrikler 4.Aşamaya Geçtiniz";
            }
            else if (asama == 4 && dolular[3] == tiklananKutuNo)
            {
                btnLevel41.Enabled = false;
                btnLevel42.Enabled = false;
                btnLevel43.Enabled = false;
                lbResult.Text = "TEBRİKLER KAZANDINIZ . Deneme :" + deneme;
            }
            else
            {
                lbResult.Text = "Yanlış Tercih..Deneme : " + deneme;
                ButonlariHazirlaYeniden();
            }
        }

        void ButonlariHazirlaYeniden()
        {
            panel1.Enabled = true;
            btnLevel11.Enabled = true;
            btnLevel12.Enabled = true;
            btnLevel13.Enabled = true;

            btnLevel21.Enabled = false;
            btnLevel22.Enabled = false;
            btnLevel23.Enabled = false;

            btnLevel31.Enabled = false;
            btnLevel32.Enabled = false;
            btnLevel33.Enabled = false;

            btnLevel41.Enabled = false;
            btnLevel42.Enabled = false;
            btnLevel43.Enabled = false;

        }

    }
}
