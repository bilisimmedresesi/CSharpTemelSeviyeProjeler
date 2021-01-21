using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiYazi
{
    public partial class SayiYazi : Form
    {


        public SayiYazi()
        {
            InitializeComponent();
        }
       
        private void btnHesapla_Click(object sender, EventArgs e)
        {// 1  500  123
            string[] birlerDizisi = new string[] { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlarDizisi = new string[] { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] basamaklarDizisi = new string[] { "", "Yüz", "Bin", "Milyon", "Milyar", "Trilyon", "Katrilyon", "Kentrilyon" };
            int basamak = 0;
            string sonuc = "";
            for (int i = txtSayi.Text.Length; i > 0; i=i-3)
            {
                basamak++;
                int okunacak = i / 3 >= 1 ? 3 : i % 3;
                string okunanVeri = txtSayi.Text.Substring(i - okunacak, okunacak);
                int sayi1 = okunanVeri.Length > 0 ? Convert.ToInt32(okunanVeri[0].ToString()) : 0;
                int sayi2 = okunanVeri.Length > 1 ? Convert.ToInt32(okunanVeri[1].ToString()) : 0;
                int sayi3 = okunanVeri.Length > 2 ? Convert.ToInt32(okunanVeri[2].ToString()) : 0;
                int sayisalDeger = Convert.ToInt32(okunanVeri);
                string yuzlukBasamak = sayisalDeger > 99 ? basamaklarDizisi[1] : "";
                string basamakYaziyla = sayisalDeger > 0 && basamak > 1 ? basamaklarDizisi[basamak] : "";
                if (okunanVeri.Length == 3)
                    sonuc = "-" + birlerDizisi[sayi1] + yuzlukBasamak + onlarDizisi[sayi2] + birlerDizisi[sayi3] + basamakYaziyla + sonuc;
                else if (okunanVeri.Length == 2)
                    sonuc = onlarDizisi[sayi1] + birlerDizisi[sayi2] + basamakYaziyla + sonuc;
                else
                    sonuc = (birlerDizisi[sayi1] + basamakYaziyla + sonuc).Replace("BirBin","Bin");
            }
            label1.Text = sonuc.Replace("BirYüz", "Yüz");
        }
    }
}
