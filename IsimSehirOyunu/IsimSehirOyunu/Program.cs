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
            string[] esya = new string[] { "Buzdolabý", "Televizyon", "Masa", "Sandalye" };
            string[] isim = new string[5];
            isim[0] = "Erkan";
            isim[1] = "Samet";
            isim[2] = "Erhan";
            isim[3] = "Ertan";
            isim[4] = "Ersan";
            string[] sehir = new string[] { "Bursa", "Adana", "Mersin", "Afyon", "Kastamonu" };
            string[] hayvan = new string[] { "Tavþan", "Tavuk", "Hindi", "Köpek", "Kedi" };

            while (1 == 1) // sonsuz döngü
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Ýsim Þehir Oyununa Hoþgeldiniz");
                Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Oyun Türünü Seçiniz :");
                Console.WriteLine("\t 1-Ýsim");
                Console.WriteLine("\t 2-Þehir");
                Console.WriteLine("\t 3-Eþya");
                Console.WriteLine("\t 4-Hayvan");
                Console.Write("\r\n\r\n Seçiminiz:");

                try
                {
                    string sorulacakSoru = "";
                    string okunanVeri = Console.ReadLine();
                    Random rastgele = new Random();
                    if (okunanVeri.ToLower() == "çýkýþ" || okunanVeri.ToLower() == "exit")
                        goto cikis;

                    int secim = Convert.ToInt32(okunanVeri);

                    if (secim == 1)   // if (okunanVeri=="1")
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< ÝSÝM BÝLMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(isim.Length - 1);
                        sorulacakSoru = isim[rastgeleSayi];
                    }
                    else if (secim == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< ÞEHÝR BÝLMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(sehir.Length - 1);
                        sorulacakSoru = sehir[rastgeleSayi];
                    }
                    else if (secim == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< EÞYA BÝLMECE >>>>>>>>>");
                        int rastgeleSayi = rastgele.Next(esya.Length - 1);
                        sorulacakSoru = esya[rastgeleSayi];
                    }
                    else if (secim == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< HAYVAN BÝLMECE >>>>>>>>>");
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
                        Console.WriteLine("Oyunu Kaybettiniz :( Yeniden baþlamak için Enter tuþuna basýnýz");
                        Console.ReadLine();
                    }
                    else  
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  *** Tebrikler Bildiniz :) 100 puan *** \r\n\r\n Yeniden Baþlamak için ENTER'a basýnýz...");
                        Console.ReadLine();
                    }

                  
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Hatayý Gizledim");
                    // haber ver bir hata olduðunda

                }
            }

        cikis:
            Console.WriteLine("Güle Güle");
        }
    }
}
