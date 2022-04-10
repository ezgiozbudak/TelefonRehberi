using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
    public class Islemler :Kisiler
    {
        
        public void KisiEkle()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string Yenisim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string Yenisoyisim = Console.ReadLine();
            Console.WriteLine("Lütfen numara giriniz:");
            int Yeninumara = Int32.Parse(Console.ReadLine());

            KisiListesi.Add(new Kisiler(Yenisim, Yenisoyisim, Yeninumara));
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

        
    }
}
