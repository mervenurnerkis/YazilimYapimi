using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiProject
{
    class AdminEkrani : Kullanici
    {
        
        public static List<Nesne> OnayAlacakUrunler()
        {
            List<Nesne> liste = new List<Nesne>();
            foreach (Kullanici kullanici in GirilenVeriler.uyeler)
            {
                foreach (Nesne nesne in kullanici.Mahsul)
                {
                    if (!nesne.Onay)
                    {
                        liste.Add(nesne);
                    }
                }
            }
            return liste;
        }
        public AdminEkrani(string kullaniciAdi,
            string sifre, string tC, string ad, 
            string soyad, string telefon, string email, 
            string adres) : base(kullaniciAdi, sifre, tC, ad, soyad,
                  telefon, email, adres)
        {

        }
    }
}
