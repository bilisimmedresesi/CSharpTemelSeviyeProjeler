using System;
using System.Collections.Generic;
using System.Text;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            TekBoyutluDiziler();
            CokBoyutluDiziler();
        }
        static void TekBoyutluDiziler()
        {
            //TEK BOYUTLU DÝZÝLER
            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salý";
            gunler[2] = "Çarþamba";
            gunler[3] = "Perþembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            //VEYA

            string[] gunler_ikinci_tanim_sekli = new string[] { "Pazartesi", "Salý", "Çarþamba", "Perþembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine("Günler:" + gunler[i]);
                Console.WriteLine("  Günler Taným 2 :" + gunler_ikinci_tanim_sekli[i]);
            }
            Console.ReadLine();
        }
        static void CokBoyutluDiziler()   //ÇOK BOYUTLU DÝZÝLER
        {
            //	Adý	Soyadý	Baba Adý
            string[,] kisiler = new string[2, 3];
            kisiler[0, 0] = "Hasan";
            kisiler[0, 1] = "Çalýþkan";
            kisiler[0, 2] = "Ahmet";
            kisiler[1, 0] = "Ali";
            kisiler[1, 1] = "Veli";
            kisiler[1, 2] = "Mehmet";
            Console.WriteLine("Adý     |Soyadý    |Baba Adý");
            Console.WriteLine("_______________________________________");
            for (int i = 0; i <  2; i++)
            {
                Console.Write((i + 1) + ".");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(kisiler[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
