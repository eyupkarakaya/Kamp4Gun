using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Eyüp";
            musteri1.MusteriSoyadı = "Karakaya";
            musteri1.MusteriYas = 25;
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Gamze";
            musteri2.MusteriSoyadı = "Tekin";
            musteri2.MusteriYas = 24;
            musteri2.Cinsiyet = "Kadın";

            Musteri musteri3= new Musteri();
            musteri3.MusteriAdi = "Merve";
            musteri3.MusteriSoyadı = "Akın";
            musteri3.MusteriYas = 35;
            musteri3.Cinsiyet = "Kadın";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("---------------Müşteri eklendi-------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("--------------Müşteri listesi---------------");
            musteriManager.Listesi(musteri1);
            Console.WriteLine("----------------------------------------------");
            musteriManager.Listesi(musteri2);
            Console.WriteLine("----------------------------------------------");
            musteriManager.Listesi(musteri3);

            Console.WriteLine("-----------Müşteriler siliniyor------------");
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
        }
    }
}
