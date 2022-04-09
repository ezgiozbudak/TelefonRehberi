using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
    public class Kisiler
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int numara { get; set; }

        public Kisiler(string isim, string soyisim, int numara)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.numara = numara;
        }

        public Kisiler()
        {

        }
        public List<Kisiler> KisiListesi;

        public void kisiListesi()
        {
            KisiListesi = new List<Kisiler>();
            KisiListesi.Add(new Kisiler("Can", "Yılmaz", 1112233));
            KisiListesi.Add(new Kisiler("Eda", "Büyük", 2223311));
            KisiListesi.Add(new Kisiler("Ecem", "Sevgi", 1114422));
            KisiListesi.Add(new Kisiler("Ali", "Derin", 2224455));
            KisiListesi.Add(new Kisiler("Seren", "Bulut", 1115566));
        }

        public void ListeYaz()
        {
            foreach (var item in KisiListesi)
            {
                Console.WriteLine("İsim :" + item.isim + "\nSoyisim:" + item.soyisim + "\nNumara:" + item.numara);
            }
        }
    }
}
