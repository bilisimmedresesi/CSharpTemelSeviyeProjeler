using System;
using System.Collections.Generic;
using System.Text;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            If_Ornegi();
            //IfElse_ElseIf_Ornegi();
            //IfElse_Ornegi();
            //Switch_Ornegi();
            //Ternary_Ornegi(); 
            //Go_To_Ornegi();
           
        }

        static void If_Ornegi()
        {
            int aboneSayisi = 100;
            if (aboneSayisi == 100)
                Console.WriteLine("Tebrikler C# Kitabý kazandýnýz :) \r\n");

            Console.WriteLine(" - Kursumuza hoþgeldiniz - ");
            Console.ReadLine();
        }


        static void Ternary_Ornegi()
        {
            int bakiye = 50;
            string bakiyeMesaji = bakiye < 100 ? "Yetersiz Bakiye" : " Ödeme Ýçin Teþekkürler";
            Console.WriteLine(bakiyeMesaji);
            Console.ReadLine();
        }

        static void IfElse_Ornegi()
        {
            string cinsiyet = "Erkek";
            if (cinsiyet == "Erkek")
            {
                Console.WriteLine("Erkek - Tebrikler 'Futbol Topu' kazandýnýz :) ");
            }
            else
                Console.WriteLine("Kýz - Tebrikler 'Oyuncak Bebek' kazandýnýz :)");
            Console.ReadLine();
        }

        static void Go_To_Ornegi()
        {
            int a = 0;
        basagit:
            a++;
            if (a < 5)
            {
                Console.WriteLine(a + ".Kez Çalýþtý");
                goto basagit;
            }
            Console.ReadLine();
        }

        static void IfElse_ElseIf_Ornegi()
        {
            int para = 600000;
            if (para >= 1000000)
            {
                Console.WriteLine(para + " ile 'Ferrari' alýnabilir");
            }
            else if (para >= 500000)
            {
                Console.WriteLine(para + " ile 'BMW' alýnabilir ");
            }
            else
                Console.WriteLine(para + " ile Hacý Murat alýnabilir :)");
            Console.ReadLine();
        }

        static void Switch_Ornegi()
        {
            int deger = 0;
            switch (deger)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("Ýki");
                    break;
                default:
                    Console.WriteLine("Deðer girilmedi");
                    break;
            }

        }

    }
}
