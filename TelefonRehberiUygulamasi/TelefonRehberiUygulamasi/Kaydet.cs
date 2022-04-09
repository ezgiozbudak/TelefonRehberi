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
        }


        
    }
}
