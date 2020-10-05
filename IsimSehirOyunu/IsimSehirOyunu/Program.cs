using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace IsimSehirOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] esya = new string[] { "Buzdolab�", "Televizyon", "Masa", "Sandalye" };
            string[] isim = new string[5];
            isim[0] = "Erkan";
            isim[1] = "Samet";
            isim[2] = "Erhan";
            isim[3] = "Ertan";
            isim[4] = "Ersan";
            string[] sehir = new string[] { "Bursa", "Adana", "Mersin", "Afyon", "Kastamonu" };
            string[] hayvan = new string[] { "Tav�an", "Tavuk", "Hindi", "K�pek", "Kedi" };

            while (1 == 1) // sonsuz d�ng�
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("�sim �ehir Oyununa Ho�geldiniz");
                Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Oyun T�r�n� Se�iniz :");
                Console.WriteLine("\t 1-�sim");
                Console.WriteLine("\t 2-�ehir");
                Console.WriteLine("\t 3-E�ya");
                Console.WriteLine("\t 4-Hayvan");
                Console.Write("\r\n\r\n Se�iminiz:");

                try
                {
                    string sorulacakSoru = "";
                    string okunanVeri = Console.ReadLine();
                    Random rastgele = new Random();
                    if (okunanVeri.ToLower() == "��k��" || okunanVeri.ToLower() == "exit")
                        goto cikis;

                    int secim = Convert.ToInt32(okunanVeri);

                    if (secim == 1)   // if (okunanVeri=="1")
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< �S�M B�LMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(isim.Length - 1);
                        sorulacakSoru = isim[rastgeleSayi];
                    }
                    else if (secim == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< �EH�R B�LMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(sehir.Length - 1);
                        sorulacakSoru = sehir[rastgeleSayi];
                    }
                    else if (secim == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< E�YA B�LMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(esya.Length - 1);
                        sorulacakSoru = esya[rastgeleSayi];
                    }
                    else if (secim == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< HAYVAN B�LMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(hayvan.Length - 1);
                        sorulacakSoru = hayvan[rastgeleSayi];
                    }

                    Console.Write(sorulacakSoru.Substring(0, 1)); // E***N
                    for (int i = 1; i < sorulacakSoru.Length - 1; i++)

                        Console.Write("*");

                    Console.Write(sorulacakSoru.Substring(sorulacakSoru.Length - 1, 1));
                    int sayac = 0;
                    bool bildi = false;
                    do
                    {
                        sayac++;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\r\n\r\n " + sayac.ToString() + ". Tahmininizi Giriniz" );
                        string tahmin = Console.ReadLine();

                        if (sorulacakSoru == tahmin)
                        {
                            bildi = true; // dogru, evet 
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(">>> Tekrar Deneyin");
                        }

                    } while (sayac<3);

                    if (!bildi)
                    {
                        Console.WriteLine("Oyunu Kaybettiniz :( Yeniden ba�lamak i�in Enter tu�una bas�n�z");
                        Console.ReadLine();
                    }
                    else  
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  *** Tebrikler Bildiniz :) 100 puan *** \r\n\r\n Yeniden Ba�lamak i�in ENTER'a bas�n�z...");
                        Console.ReadLine();
                    }

                  
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Hatay� Gizledim");
                    // haber ver bir hata oldu�unda

                }
            }

        cikis:
            Console.WriteLine("G�le G�le");
        }
    }
}
