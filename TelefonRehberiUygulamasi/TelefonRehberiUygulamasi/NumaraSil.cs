using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
    public class NumaraSil : Kisiler
    {
        public int ListedeAra(string Isim ,string Soyisim)
        {
            int kontrol = 0;
            int index = -1;
            foreach (var item in KisiListesi)
            {
                if (item.isim == Isim && item.soyisim == Soyisim)
                {
                   index = KisiListesi.IndexOf(item);
                   Console.WriteLine("Kisi:"+ "\nİsim :" + item.isim + "\nSoyisim:" + item.soyisim + "\nNumara:" + item.numara);
                   kontrol++;
                }
                else
                {

                }
            }
            return index;
        }

        public void Sil(int sayi)
        {
            if(sayi > 0 )
               KisiListesi.RemoveAt(sayi);
            else if(sayi<0 || sayi > KisiListesi.Count)
            {
                Console.WriteLine("Kişi Bulunamadı.");
            }
               
        }
    }
}
