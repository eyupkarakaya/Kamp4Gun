using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Hoşgeldiniz Sayın:"+musteri.MusteriAdi + " " + musteri.MusteriSoyadı);

            //Console.WriteLine("--------------------------------------------");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Güle güle sayın :" + musteri.MusteriAdi + " " + musteri.MusteriSoyadı);
            //Console.WriteLine("--------------------------------------------");
        }

        public void Listesi(Musteri musteri)
        {
            Console.WriteLine("İsmi :" + musteri.MusteriAdi);
            Console.WriteLine("Soyadı :" + musteri.MusteriSoyadı);
            Console.WriteLine("Yaşı :" + musteri.MusteriYas);
            Console.WriteLine("Cinsiyeti:" + musteri.Cinsiyet);
            //Console.WriteLine("--------------------------------------------");
        }


    }
}
