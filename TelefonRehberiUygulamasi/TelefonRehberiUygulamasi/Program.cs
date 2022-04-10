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

            //Kisiler kisi = new Kisiler();
            //kisi.kisiListesi();
            //kisi.KisiListesi.RemoveAt(1);
            //foreach(var item in kisi.KisiListesi)
            //{
            //    Console.WriteLine(item.isim);
            //    Console.WriteLine(item.soyisim);
            //}
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
                case 1: kisi.KisiEkle();
                    break;
                case 2: 
                     kisi.ListedeAra(kisi);
                    break;
            }

        }
    }
}
