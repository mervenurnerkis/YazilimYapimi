using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    class BeklenilenIslem
    {
        private Kullanici alici;
        private int miktar;
        private string urun;
        
        

        public BeklenilenIslem(Kullanici alici, string urun, int miktar)
        {
            Alici = alici;
            Urunler = urun;
            Miktar = miktar;
        }
        public void SatinAlim(Urunler urun)
        {
            Islem islem;
            double ilkBakiye = alici.Bakiye;
            int degisenmiktar = miktar;
            double netTutar = urun.Fiyat * miktar;
            if (urun.Miktar>=miktar&&alici.Bakiye>=netTutar)
            {
                urun.Miktar -= miktar;
                miktar = 0;
                alici.Bakiye -= netTutar;
                alici.UrunEkle(urun);
                urun.Sahibi.Bakiye += netTutar;
            }
            else if (urun.Miktar>=miktar&&alici.Bakiye<=netTutar)
            {
                int yeterliAlimMiktari = (int)(alici.Bakiye / urun.Fiyat);
                netTutar = yeterliAlimMiktari * urun.Fiyat;
                urun.Miktar -= yeterliAlimMiktari;
                miktar -= yeterliAlimMiktari;
                alici.Bakiye -= netTutar;
                urun.Sahibi.Bakiye += netTutar;
                Urunler yeniUrun = new Urunler(urun.Ad, yeterliAlimMiktari, urun.Fiyat,alici);
                alici.UrunEkle(yeniUrun);
            }
            else
            {
                int yeterliAlimMiktari = urun.Miktar;
                netTutar = yeterliAlimMiktari * urun.Fiyat;
                alici.Bakiye -= netTutar;
                urun.Sahibi.Bakiye += netTutar;
                miktar -= urun.Miktar;
                Urunler yeniUrun = new Urunler(urun.Ad, yeterliAlimMiktari, urun.Fiyat,alici);
                alici.UrunEkle(yeniUrun);
            }
            if (ilkBakiye!=alici.Bakiye)
            {
                islem = new Islem(alici.Ad + " " + degisenmiktar + " kilo " + urun.Ad + " almak ister ise " + urun.Fiyat + " tl'den alım işlemi gerçekleşti",
                alici.Ad + " " + urun.Sahibi.Ad + "'in hesabına " + netTutar + " TL gönderdi.", alici.Ad + " " + alici.Bakiye + " tl parası kaldı",
                urun.Fiyat + " tl");
                Veriler.Islemler.Add(islem);
            }
        }
        
        public string Urunler { get => urun; set => urun = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public Kullanici Alici { get => alici; set => alici = value; }
        public bool İslemBitisi()
        {
            return miktar == 0;
        }
    }
}
