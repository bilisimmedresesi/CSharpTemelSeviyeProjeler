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
                Console.WriteLine(i + ". Ki�inin y�z� 20 milyon resimle kar��la�t�r�ld� ");
            }
        }

        static void ForEach_Dongusu()
        {
            string[] mevsim = new string[] { "K��", "�lkBahar", "Yaz", "Sonbahar" };
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
                Console.WriteLine(ilNo + ". �l Taran�yor");
            }
            ucus = false;
            Console.WriteLine("G�rev bitti, kalk�� �ss�ne ini� yapt�m.");
        }

        static void While_Dongusu()
        {
            bool ucus = true;
            int ilNo = 0;

            while (ucus == true && ilNo < 6)
            {
                ilNo++;
                Console.WriteLine(ilNo + ". �l Taran�yor");
            }
            ucus = false;
            Console.WriteLine("G�rev bitti, kalk�� �ss�ne ini� yapt�m.");
        }
        static void Do_While_Dongusu()//En Az Bir kere �al���r !!!!
        {
            string sifre = "Bili�im Medresesi";
            string kullanicidanSifreAl = "";

            do
            {
                Console.WriteLine("�ifre Giriniz");
                kullanicidanSifreAl = Console.ReadLine();

            } while (sifre != kullanicidanSifreAl);

            Console.WriteLine("Ho�geldiniz");
        }

        static void Do_While_Dongusu_Break()//En Az Bir kere �al���r !!!!
        {
            string sifre = "Bili�im Medresesi";
            string kullanicidanSifreAl = "";
            int sayac = 0;
            do
            {
                sayac++;
                Console.WriteLine( sayac + ".Deneme  �ifre Giriniz : ");
                kullanicidanSifreAl = Console.ReadLine();
                if (sifre == kullanicidanSifreAl)
                {
                    Console.WriteLine("Ho�geldiniz");
                    return;
                }
                else if (sayac == 3)
                    break;
            } while (sifre != kullanicidanSifreAl);
            Console.WriteLine("Hesab�n�z Kilitlendi !!! 3 kez hatal� giri� denemesi");
        }
    }
}
