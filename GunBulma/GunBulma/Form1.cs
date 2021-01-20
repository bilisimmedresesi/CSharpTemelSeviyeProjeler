using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {


            //20 haziran 2021
            if (e.KeyCode == Keys.Return)
            {
                DateTime dt = dtTarih.Value;
                int[] dayOfMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                double gecenGun = ((dt.Year - 1) * 365 + (dt.Year / 4) - (dt.Year / 100 * 0.75)); // 01.01.0001 den  01.01.2021   

                for (int i = 0; i < dt.Month - 1; i++) // haziran 1 e kadar olan günü toplayacağım    6.ay
                {
                    gecenGun += dayOfMonth[i];

                    if (i == 1 && dt.Year % 4 == 0 && (dt.Year % 400 == 0 || dt.Year % 100 > 0))

                        gecenGun++; // toplandı

                }
                double toplam = (gecenGun + dt.Day - 1) - (dt.Year % 4 == 0 ? 1 : 0) + (dt.Year % 100 == 0 ? 1 : 0) - (dt.Year % 400 == 0 ? 1 : 0);
                int calc = (Convert.ToInt32(Math.Floor(toplam)) + 1) % 7;
                string gun = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)calc);

                lbResult.Text = toplam.ToString() + "   /  " + gun;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
