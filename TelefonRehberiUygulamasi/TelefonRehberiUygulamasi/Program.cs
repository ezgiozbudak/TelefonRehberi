using System;

namespace TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            Program a = new Program();
            a.Giris();
            int secilenSayi = a.SecimSayi();
            a.Secim(secilenSayi);
        }

        public void Giris()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz " +
            "\n*******************************************\n(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak﻿");
        }

        public int SecimSayi()
        {
            int sayi= 0;
            try
            {
                sayi = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen sayı giriniz!");
            }

            return sayi;
        }
       
        public void Secim(int sayi)
        {
            Islemler kisi = new Islemler();
            kisi.kisiListesi();
            switch (sayi)
            {
                case 1: kisi.KisiEkle(kisi);
                    break;
                case 2: 
                     kisi.ListedeAra(kisi);
                    break;
                case 3: kisi.Guncelle(kisi);
                    break;
                case 4: kisi.ListeYaz();
                    break;
                case 5:kisi.islemsecimi(kisi);
                    break;
            }

        }
    }
}
