using System;


namespace MetinSifreleme
{
    static class Program
    {

        static void Main()
        {
            // adana
            string decrypted="", encyrpted = "";
            Console.Write("Şifrelenecek Metni Giriniz   :");
            string txt = Console.ReadLine();
            string[] harfler = {" ", "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z", "q", "x", "w" };
            string[] sifreli = {"\"", "#", "%", "(", "^", "*", "-", "&", "=", "~", "!", ">", "<", "|", "[", "{", "]", "}", "€", "¨", ",", ";", ",", "/", "@", "é", "â", "æ", "ñ", "¥", "Σ", "√", "ù" };

            for (int i = 0; i < txt.Length; i++)
            {
                for (int j = 0; j < harfler.Length; j++)
                {
                    if (txt[i].ToString() == harfler[j])
                    {
                        encyrpted += sifreli[j];
                        break;
                    }
                }

            }
            Console.WriteLine("\r\n\r\n   Şifreli : " + encyrpted+"\r\n\r\n");

            for (int i = 0; i < encyrpted.Length; i++)
            {
                for (int j = 0; j < sifreli.Length; j++)
                {
                    if (encyrpted[i].ToString() == sifreli[j])
                    {
                        decrypted += harfler[j];
                        break;
                    }
                }

            }
            Console.WriteLine("\r\n\r\n   Şifresiz : " + decrypted + "\r\n\r\n");
            Console.ReadKey();

        }
    }
}
