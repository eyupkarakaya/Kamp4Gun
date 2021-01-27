using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Eyüp";
            musteri1.Soyadi = "Karakaya";
            musteri1.TcNo = "123456789";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id =2;
            musteri2.MusteriNo ="1453";
            musteri2.SirketNo = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            //Gerçek Müşteri- Tüzel Müşteri birbirini yerine kullanılmaz
            //SOLID


        }
    }
}
