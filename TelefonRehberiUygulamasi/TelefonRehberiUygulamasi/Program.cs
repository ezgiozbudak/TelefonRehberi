using System;

namespace TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            Islemler kisi = new Islemler();
            kisi.kisiListesi();
            kisi.KisiEkle();           
            kisi.ListeYaz();

        }
    }
}
