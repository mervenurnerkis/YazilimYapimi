using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiProject
{
    public class Kullanici
    {
        
        private string ad;
        private string soyad;
        private string Tc;
        private string telefon;
        private string email;
        private string adres;

        private string kullaniciAdi;
        private string parola;
        
        private List<Nesne> mahsul;
        private double bakiye;
        private double bakiyeOnay;

        public void NesneEkle(Nesne nesne)
        {
            if (mahsul.Contains(nesne) == false)
            {
                mahsul.Add(nesne);
            }
        }
        public Kullanici(string kullaniciAdi, string parola, string Tc, string ad, string soyad, string telefon, string email, string adres)
        {
            KullaniciAdi = kullaniciAdi;
            Parola = parola;

            TC = Tc;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
            Adres = adres;

            Bakiye = 0;
            BakiyeOnay = 0;
            Mahsul = new List<Nesne>();
        }
        
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Parola { get => parola; set => parola = value; }
        public string TC { get => Tc; set => Tc = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        internal List<Nesne> Mahsul { get => mahsul; set => mahsul = value; }
        public double BakiyeOnay { get => bakiyeOnay; set => bakiyeOnay = value; }
    }
}
