using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiProject
{
    class Talepler
    {
        private Kullanici alici;
        private string urun;
        private int miktar;

        public Talepler(Kullanici alici, string urun, int miktar)
        {
            Alici = alici;
            Urun = urun;
            Miktar = miktar;
        }
        
        
        public Kullanici Alici { get => alici; set => alici = value; }
        public string Urun { get => urun; set => urun = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public void AlimiGerceklestir(Nesne urun)
        {
            IslemDetaylari islem;
            double baslangicBakiye = alici.Bakiye;
            int gecicimiktar = miktar;
            double toplamTutar = urun.Fiyat * miktar;
            if (urun.Miktar >= miktar && alici.Bakiye >= toplamTutar)
            {
                urun.Miktar -= miktar;
                miktar = 0;
                alici.Bakiye -= toplamTutar;
                alici.NesneEkle(urun);
                urun.Sahibi.Bakiye += toplamTutar;
            }
            else if (urun.Miktar >= miktar && alici.Bakiye <= toplamTutar)
            {
                int yeterliMiktar = (int)(alici.Bakiye / urun.Fiyat);
                toplamTutar = yeterliMiktar * urun.Fiyat;
                urun.Miktar -= yeterliMiktar;
                miktar -= yeterliMiktar;
                alici.Bakiye -= toplamTutar;
                urun.Sahibi.Bakiye += toplamTutar;
                Nesne yeniUrun = new Nesne(urun.Ad, yeterliMiktar, urun.Fiyat, alici);
                alici.NesneEkle(yeniUrun);
            }
            else
            {
                int yeterliMiktar = urun.Miktar;
                toplamTutar = yeterliMiktar * urun.Fiyat;
                alici.Bakiye -= toplamTutar;
                urun.Sahibi.Bakiye += toplamTutar;
                miktar -= urun.Miktar;
                Nesne yeniUrun = new Nesne(urun.Ad, yeterliMiktar, urun.Fiyat, alici);
                alici.NesneEkle(yeniUrun);
            }
            if (baslangicBakiye != alici.Bakiye)
            {
                islem = new IslemDetaylari(alici.Ad + " " + gecicimiktar + " kilo " + urun.Ad + " almak ister ise " + urun.Fiyat + " tl'den alım işlemi gerçekleşti",
                alici.Ad + " " + urun.Sahibi.Ad + "'in hesabına " + toplamTutar + " TL gönderdi.", alici.Ad + " " + alici.Bakiye + " tl parası kaldı",
                urun.Fiyat + " tl");
                GirilenVeriler.Islemler.Add(islem);
            }
        }
        public bool hazirMi()
        {
            return miktar == 0;
        }
    }
}
