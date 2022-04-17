using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
    public class Islemler :Kisiler
    {
        
        public void KisiEkle(Islemler kisi)
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string Yenisim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string Yenisoyisim = Console.ReadLine();
            Console.WriteLine("Lütfen numara giriniz:");
            int Yeninumara = Int32.Parse(Console.ReadLine());

            kisi.KisiListesi.Add(new Kisiler(Yenisim, Yenisoyisim, Yeninumara));
            Console.WriteLine("Yeni kişi eklendi.");
        }

        public void ListedeAra(Islemler kisi)
        {
            int kontrol = 0;
            int index = -1;
            Console.WriteLine("İsim Giriniz:");
            string Isim = Console.ReadLine();
            Console.WriteLine("Soyisim Giriniz:");
            string Soyisim = Console.ReadLine();
            bool cevap = false;
            foreach (var item in KisiListesi)
            {
               
                if (item.isim == Isim && item.soyisim == Soyisim)
                {
                    index = kontrol;
                    Console.WriteLine("Silinecek Kisi:" + "\nİsim :" + item.isim + "\nSoyisim:" + item.soyisim + "\nNumara:" + item.numara);
                  
                }
                kontrol++;
            }

            Console.WriteLine("Silme işlemine devam etmek istiyor musunuz? Onaylıyorsanız True, onaylamıyorsanız false yazınız.");
            cevap = bool.Parse(Console.ReadLine());
            if (cevap == true) kisi.Sil(index, kisi);
            else Console.WriteLine("Silme işlemi sonlandırıldı");

        }

        public void Sil(int sayi,Islemler kisi)
        {
            if (sayi >= 0)
            {
                kisi.KisiListesi.RemoveAt(sayi);
                Console.WriteLine("Kişi Silindi");
            }
            else if (sayi < 0 )
            {
                Console.WriteLine("Kişi Bulunamadı.Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için: (1)\n* Yeniden denemek için: (2)");
                int secim = int.Parse(Console.ReadLine());
                kisi.Tekrar(secim, kisi);
            }

        }

        public void Tekrar(int secim, Islemler kisi)
        {
            if (secim == 1)
                Console.WriteLine("İşlem Sonlandırıldı.");
            if (secim == 2)
               kisi.ListedeAra(kisi);
        }

        public void Guncelle(Islemler kisi)
        {
            int kontrol = -1;
            Console.WriteLine("İsim Giriniz:");
            string Isim = Console.ReadLine();
            Console.WriteLine("Soyisim Giriniz:");
            string Soyisim = Console.ReadLine();
            int i = 0;
            int degisenNumara = 0;
            int indeks = -1;
            foreach (var item in kisi.KisiListesi)
            {

                if (item.isim == Isim && item.soyisim == Soyisim)
                {
                    kontrol++;
                    Console.WriteLine("Yeni numarayı giriniz:");
                    degisenNumara = Int32.Parse(Console.ReadLine());
                    indeks = i;
                   
                    Console.WriteLine("Numara güncellendi");

                }
                
                i++;


            }

            if(kontrol == -1)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Güncellemeyi sonlandırmak için: (1)\nYeniden denemek için: (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1) Console.WriteLine("Güncelleme sonlandırıldı");
                else kisi.Guncelle(kisi);
            }
            else
            {
                KisiListesi[indeks].numara = degisenNumara;
            }
        }
        public void islemsecimi(Islemler kisi)
        {
            int secim = 0;
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz. \n * ********************************************* \n İsim veya soyisime göre arama yapmak için: (1) \nTelefon numarasına göre arama yapmak için: (2)");
            secim = Int32.Parse(Console.ReadLine());
            if (secim == 1)
                Ara(kisi);
            else if (secim == 2) NumaraAra(kisi);
        }

        public void Ara(Islemler kisi)
        {
            Console.WriteLine("İsim veya Soyisim giriniz");
            string isim = Console.ReadLine();
            foreach(var item in KisiListesi)
            {
                if(item.isim == isim || item.soyisim == isim)
                {
                    Console.WriteLine("İsim:" + item.isim);
                    Console.WriteLine("Soyisim:" + item.soyisim);
                    Console.WriteLine("Numara:" + item.numara);
                }
            }
        }
        
        public void NumaraAra(Islemler kisi)
        {
            Console.WriteLine("Numara giriniz");
            int no = Int32.Parse(Console.ReadLine());
            foreach (var item in KisiListesi)
            {
                if (item.numara == no)
                {
                    Console.WriteLine("İsim:" + item.isim);
                    Console.WriteLine("Soyisim:" + item.soyisim);
                    Console.WriteLine("Numara:" + item.numara);
                }
            }

        }
    }
}
