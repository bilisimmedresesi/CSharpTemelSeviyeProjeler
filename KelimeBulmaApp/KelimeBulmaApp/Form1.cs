using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeBulmaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            rcMetin.SelectAll();
            rcMetin.SelectionBackColor = Color.White;
            string text = rcMetin.Text;
            string bulunacakKarakter = txtBulKarakter.Text;
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == bulunacakKarakter)
                {
                    rcMetin.Select(i, 1);
                    rcMetin.SelectionBackColor = Color.Lime;
                    counter++;
                }
            }
            MessageBox.Show(counter + " Adet Bulundu.");
        }
    }
}
