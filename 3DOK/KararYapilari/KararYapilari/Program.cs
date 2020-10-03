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
                Console.WriteLine("Tebrikler C# Kitab� kazand�n�z :) \r\n");

            Console.WriteLine(" - Kursumuza ho�geldiniz - ");
            Console.ReadLine();
        }


        static void Ternary_Ornegi()
        {
            int bakiye = 50;
            string bakiyeMesaji = bakiye < 100 ? "Yetersiz Bakiye" : " �deme ��in Te�ekk�rler";
            Console.WriteLine(bakiyeMesaji);
            Console.ReadLine();
        }

        static void IfElse_Ornegi()
        {
            string cinsiyet = "Erkek";
            if (cinsiyet == "Erkek")
            {
                Console.WriteLine("Erkek - Tebrikler 'Futbol Topu' kazand�n�z :) ");
            }
            else
                Console.WriteLine("K�z - Tebrikler 'Oyuncak Bebek' kazand�n�z :)");
            Console.ReadLine();
        }

        static void Go_To_Ornegi()
        {
            int a = 0;
        basagit:
            a++;
            if (a < 5)
            {
                Console.WriteLine(a + ".Kez �al��t�");
                goto basagit;
            }
            Console.ReadLine();
        }

        static void IfElse_ElseIf_Ornegi()
        {
            int para = 600000;
            if (para >= 1000000)
            {
                Console.WriteLine(para + " ile 'Ferrari' al�nabilir");
            }
            else if (para >= 500000)
            {
                Console.WriteLine(para + " ile 'BMW' al�nabilir ");
            }
            else
                Console.WriteLine(para + " ile Hac� Murat al�nabilir :)");
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
                    Console.WriteLine("�ki");
                    break;
                default:
                    Console.WriteLine("De�er girilmedi");
                    break;
            }

        }

    }
}
