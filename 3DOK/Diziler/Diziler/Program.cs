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
            //TEK BOYUTLU D�Z�LER
            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Sal�";
            gunler[2] = "�ar�amba";
            gunler[3] = "Per�embe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            //VEYA

            string[] gunler_ikinci_tanim_sekli = new string[] { "Pazartesi", "Sal�", "�ar�amba", "Per�embe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine("G�nler:" + gunler[i]);
                Console.WriteLine("  G�nler Tan�m 2 :" + gunler_ikinci_tanim_sekli[i]);
            }
            Console.ReadLine();
        }
        static void CokBoyutluDiziler()   //�OK BOYUTLU D�Z�LER
        {
            //	Ad�	Soyad�	Baba Ad�
            string[,] kisiler = new string[2, 3];
            kisiler[0, 0] = "Hasan";
            kisiler[0, 1] = "�al��kan";
            kisiler[0, 2] = "Ahmet";
            kisiler[1, 0] = "Ali";
            kisiler[1, 1] = "Veli";
            kisiler[1, 2] = "Mehmet";
            Console.WriteLine("Ad�     |Soyad�    |Baba Ad�");
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
