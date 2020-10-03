using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            MetinTopla();
        }
        static void MetinTopla()
        {
            string kanaladi = "Bilişim Medresesi";
            string mesaj = " Abone ol ve çok daha ileri teknikleri sakın kaçırma";
            kanaladi += mesaj; //   kanaladi = kanaladi + mesaj;
            Console.WriteLine(kanaladi);
            Console.ReadLine();
        }

        static void Arttirma()
        {

            int a = 1;
            Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.ReadLine();


        }
        static void AtamaTopla()
        {
            int ab = 50; ab += 10; // ab = ab + 10;
            Console.WriteLine(ab);
            Console.ReadLine();
            return;
        }
        static void AtamaCikar()
        {
            int ab = 50; ab -= 10; // ab = ab - 10;
            Console.WriteLine(ab);
            Console.ReadLine();
            return;
        }
        static void AtamaBol()
        {
            int ab = 50; ab /= 10; // ab = ab / 10;
            Console.WriteLine(ab);
            Console.ReadLine();
            return;
        }
        static void AtamaCarp()
        {
            int ab = 50; ab *= 10; // ab = ab * 10;
            Console.WriteLine(ab);
            Console.ReadLine();
            return;
        }
        static void AtamaModAl()
        {
            int ab = 52; ab %= 10; // ab = ab % 10;
            Console.WriteLine(ab);
            Console.ReadLine();
            return;
        }


        static void Aritmetik()
        {
            Console.WriteLine("İlk sayıyı giriniz..");
            string ilksayiString = Console.ReadLine();
            int sayi1 = Convert.ToInt32(ilksayiString);
            Console.WriteLine("İkinci sayıyı giriniz..");
            string ikinciSayiString = Console.ReadLine();
            int sayi2 = Convert.ToInt32(ikinciSayiString);

            int toplam = sayi1 + sayi2;
            int cikar = sayi1 - sayi2;
            int bolum = sayi1 / sayi2;
            int carpim = sayi1 * sayi2;
            int modKalani = sayi1 % sayi2;

            double virgulluBolum = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);
            Console.WriteLine("Toplam =" + toplam.ToString());
            Console.WriteLine("Çıkarma =" + cikar);
            Console.WriteLine("Bölme =" + bolum);
            Console.WriteLine("Virgüllu =" + virgulluBolum);
            Console.WriteLine("Çarpım =" + carpim);
            Console.WriteLine("Mod Kalanı =" + modKalani);
            Console.ReadLine();
        }

        static void Esitlik()
        {

            bool esitmi1 = (1 == 1);
            bool esitDegilse = (1 != 1);
            bool buyuktur = (1 > 5);
            bool kucuktur = (6 < 5);
            bool kucukEsit = (5 <= 5);
            bool buyukEsit = (9 >= 9);
            Console.WriteLine("1 , 1 'e Eşit mi ? " + esitmi1);
            Console.WriteLine("1 , 1 'e Eşit Değil mi ? " + esitDegilse);
            Console.WriteLine("1, 5'ten büyük mü ? " + buyuktur);
            Console.WriteLine("6, 5'ten küçük mü ? " + kucuktur);
            Console.WriteLine("5 küçük veya Eşit mi 5 'e  ? " + kucukEsit);
            Console.WriteLine("9 büyük veya  Eşit mi 9'a ? " + buyukEsit);
            Console.ReadLine();
        }

        static void Oncelik()
        {

            int a = 5;
            int sonuc = (a * a) * a++ / 5 + 10;
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
        static void Mantiksal()
        {
            bool ve = (1 == 1) && "Bilişim" == "Bilisim Medresesi";
            bool veya = (5 == 4) || "Bilişim" == "Bilişim";
            //iki yanlış veya iki doğru OLMAZ.
            bool esitsizlik = (9 == 8) ^ (7 == 7);
            bool yanlisMi = !(7 == 8);

            Console.WriteLine("VE ? " + ve);
            Console.WriteLine("VEYA ?" + veya);
            Console.WriteLine("");
            Console.WriteLine("Farklı mı ?" + esitsizlik);
            Console.WriteLine(" Yanlış Mı ? " + yanlisMi);
            Console.ReadLine();
        }
    }
}
