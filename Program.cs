using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MusteriManeger sınıfından bir nesne üretilir, bu nesne bir liste oluşturacaktır
            MusteriManager musteriler = new MusteriManager();


            //Listeye birkeç müşteri eklenir
            musteriler.MusteriEkle("Ali", "Garip");
            musteriler.MusteriEkle("Mahmut", "Abdi");
            musteriler.MusteriEkle("Ahmet", "Arabacı");
            musteriler.MusteriEkle("Anıl", "Gergin");

            //Kaç adet müşteri olduğunu yazar
            musteriler.MusteriAdedi();

            //Müşterileri listeler
            musteriler.MusteriListele();

            //id'si 1 olan müşteriyi siler
            musteriler.MusteriSil(1);

            //Müşterileri listeler
            musteriler.MusteriListele();

            //Yeni bir müşteri ekler
            musteriler.MusteriEkle("Ali", "Garip");

            //Müşterileri listeler
            musteriler.MusteriListele();

            //Kaç adet müşteri olduğunu yazar
            musteriler.MusteriAdedi();
        }
    }
}
