using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<F, T> //İstediğimizi buraya yazabiliriz
    {
        F[] filmler;
        T[] items;
        public MyDictionary()//Constructor-Class'ı new'lersen burası çalışıyor
        {
            filmler = new F[0];
            items = new T[0];
        }

        public void Add(F film, T item)
        {
            F[] tempFilm = filmler; //geçici olarak referans numarasını burada tutturuyoruz
            T[] tempArray = items;//geçici olarak referans numarasını burada tutturuyoruz

            filmler = new F[filmler.Length + 1]; //yukarıdakini yapmasaydık önceki verilerim kaybolacaktı
            items = new T[items.Length + 1];//yukarıdakini yapmasaydık önceki verilerim kaybolacaktı

            for (int i = 0; i < tempArray.Length; i++)//geçici emanet olarak verdiğim elemanları geri alacağım
            {
               filmler[i] = tempFilm[i];
                items[i] = tempArray[i];
            }

            filmler[filmler.Length - 1] = film;
            items[items.Length - 1] = item;//burada add'le gelen yeni elemanı boş kısma ekliyoruz(getiriyoruz)
            //length -1 toplam eleman sayısından 1 eksik yani index değeri

            Console.WriteLine("Film: " +film + " Türü: " + item);

        }
    }
}
