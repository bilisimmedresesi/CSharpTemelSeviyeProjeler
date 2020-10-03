using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvCekilisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çekilişe girecek Kişi Sayısı Giriniz :");
            string okunanDeger= Console.ReadLine();
            int kisiSayisi = Convert.ToInt32(okunanDeger);
            string[] kisiler = new string[kisiSayisi];

            for (int i = 0; i < kisiSayisi; i++)
            {
                Console.WriteLine((i + 1) + ". Kişinin Adını Soyadını Giriniz");
                kisiler[i] = Console.ReadLine();
            }

            Console.WriteLine("Talihli Kişi Sayısı Giriniz :");
            string talihliStr = Console.ReadLine();
            int talihliSayisi = Convert.ToInt32(talihliStr);
            //Rastgele sayı tanımlamak için kullanılan sınıf / veri tipi
            Random rastgele = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < talihliSayisi; i++)
            {
                int rastlantiSayi= rastgele.Next(kisiSayisi - 1);
                Console.WriteLine("Tebrikler " + (i+1) + ". talihli : " + kisiler[rastlantiSayi]);
            }
            Console.ReadLine();
        }
    }
}
