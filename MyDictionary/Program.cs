using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> filmler = new MyDictionary<string, string>();

            filmler.Add("Hızlı ve Öfkeli", "Aksiyon");
            filmler.Add("Avatar", "BilimKurgu");
            filmler.Add("Bitirim İkili", "Komedi");

        }
    }
}
