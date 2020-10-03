using System;
using System.Collections.Generic;
using System.Text;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Do_While_Dongusu(); 
            Console.ReadLine();


        }


        static void For_Dongusu()
        {
            for (int i = 1; i <= 10; i++)
            {
                // ResimKarsilastir_Veritabanindan()
                Console.WriteLine(i + ". Kiþinin yüzü 20 milyon resimle karþýlaþtýrýldý ");
            }
        }

        static void ForEach_Dongusu()
        {
            string[] mevsim = new string[] { "Kýþ", "ÝlkBahar", "Yaz", "Sonbahar" };
            foreach (string var in mevsim)
            {
                Console.WriteLine(var);
            }
        }
        static void While_DongusuContinue()
        {
            bool ucus = true;
            int ilNo = 0;

            while (ucus == true && ilNo < 6)
            {
                ilNo++;
                if (ilNo == 3)
                    continue;
                Console.WriteLine(ilNo + ". Ýl Taranýyor");
            }
            ucus = false;
            Console.WriteLine("Görev bitti, kalkýþ üssüne iniþ yaptým.");
        }

        static void While_Dongusu()
        {
            bool ucus = true;
            int ilNo = 0;

            while (ucus == true && ilNo < 6)
            {
                ilNo++;
                Console.WriteLine(ilNo + ". Ýl Taranýyor");
            }
            ucus = false;
            Console.WriteLine("Görev bitti, kalkýþ üssüne iniþ yaptým.");
        }
        static void Do_While_Dongusu()//En Az Bir kere Çalýþýr !!!!
        {
            string sifre = "Biliþim Medresesi";
            string kullanicidanSifreAl = "";

            do
            {
                Console.WriteLine("Þifre Giriniz");
                kullanicidanSifreAl = Console.ReadLine();

            } while (sifre != kullanicidanSifreAl);

            Console.WriteLine("Hoþgeldiniz");
        }

        static void Do_While_Dongusu_Break()//En Az Bir kere Çalýþýr !!!!
        {
            string sifre = "Biliþim Medresesi";
            string kullanicidanSifreAl = "";
            int sayac = 0;
            do
            {
                sayac++;
                Console.WriteLine( sayac + ".Deneme  Þifre Giriniz : ");
                kullanicidanSifreAl = Console.ReadLine();
                if (sifre == kullanicidanSifreAl)
                {
                    Console.WriteLine("Hoþgeldiniz");
                    return;
                }
                else if (sayac == 3)
                    break;
            } while (sifre != kullanicidanSifreAl);
            Console.WriteLine("Hesabýnýz Kilitlendi !!! 3 kez hatalý giriþ denemesi");
        }
    }
}
