using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Yeni müşteri eklerken verilecek id'yi belirlemek için size adlı bir değişken oluşturur
        int size = 0;

        //Müşterilerin tutulacağı liste oluşturulur
        List<Musteri> musteriListesi = new List<Musteri>();

        //Müşteri ekler bunun için ad ve soyad'a ihtiyaç duyar
        public void MusteriEkle(string ad, string soyad)
        {
            //Her eklenen müşteri için size bir atar
            size++;

            //size kaç ise id buna eşitlenir
            int id = size;

            //Müşteri sınıfından bir nesne oluşturulur
            Musteri musteri = new Musteri(id, ad, soyad);

            //Oluşturulan müşteri listeye eklenir
            musteriListesi.Add(musteri);           
        }

        //Müşterileri listeler
        public void MusteriListele()
        {
            Console.WriteLine("\nID\tAD\tSOYAD");
            Console.WriteLine("--------------------------");
            foreach (Musteri musteri in musteriListesi)
            {
                Console.WriteLine(musteri.id + "\t" + musteri.ad + "\t" + musteri.soyad);
            }
        }


        //Verilen id'ye sahip müşteriyi siler
        public void MusteriSil(int id)
        {   
            //Verilen id'ye sahip müşteri aranır
            foreach (Musteri musteri in musteriListesi)
            {
                if (musteri.id == id)
                {
                    //Müşteri silir
                    musteriListesi.Remove(musteri);
                    break;
                }
                //Bir kere kullanılan id'nin bir daha kullanılmasını istemedim bu yüzden bunun için
                //yapılan bir işlem yok. 
            }
        }

        public void MusteriAdedi()
        {
            Console.WriteLine("\nGüncel müşteri adedi " + (musteriListesi.Count + 1));
        }
    }
}
