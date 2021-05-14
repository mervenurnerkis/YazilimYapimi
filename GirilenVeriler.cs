using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiProject
{
    class GirilenVeriler
    {
        public static List<Kullanici> uyeler = new List<Kullanici>();
        
        public static Kullanici kullaniciAra(string kullaniciadi)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi == kullaniciadi)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static bool UyeVarmi(string TC,string Kullaniciadi)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.TC==TC||kullanici.KullaniciAdi==Kullaniciadi)
                {
                    return true;
                }
            }
            return false;
        }
        public static AdminEkrani yonetici = new AdminEkrani("admin", "admin", "admin", "admin", "admin", "admin", "admin", "admin");
        public static Kullanici Login(string nickname, string parola)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi == nickname && kullanici.Parola == parola)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static bool SignUp(Kullanici uye)
        {
            if (UyeVarmi(uye.TC,uye.KullaniciAdi)==false&&uyeler.Contains(uye)==false)
            {
                uyeler.Add(uye);
                return true;
            }
            return false;
        }

        public static List<Talepler> UrunTalepleri = new List<Talepler>();
        public static List<Talepler> KullaniciTalepleri(Kullanici kullanici)
        {
            List<Talepler> talepler = new List<Talepler>();
            foreach (Talepler talep in UrunTalepleri)
            {
                if (talep.Alici==kullanici)
                {
                    talepler.Add(talep);
                }
            }
            return talepler;
        }
       
        
        public static void TalepKontrol()
        {
            List<Talepler> hazirTalepler = new List<Talepler>();
            foreach (Talepler talep in UrunTalepleri)
            {
                Nesne alinacakNesne = UcuzUrunNesneBul(talep.Urun);
                if (alinacakNesne!=null)
                {
                    talep.AlimiGerceklestir(alinacakNesne);
                    if (talep.hazirMi())
                    {
                        hazirTalepler.Add(talep);
                    }
                }
            }
            foreach (Talepler talep1 in hazirTalepler)
            {
                UrunTalepleri.Remove(talep1);
            }
            NesneSil();
        }

        public static List<IslemDetaylari> Islemler = new List<IslemDetaylari>();
        public static void NesneSil()
        {
            List<Nesne> silinecekNesne = new List<Nesne>();
            foreach (Kullanici kullanici in uyeler)
            {
                silinecekNesne = new List<Nesne>();
                foreach (Nesne nesne in kullanici.Mahsul)
                {
                    if (nesne.Miktar == 0&&nesne.Onay)
                    {
                        silinecekNesne.Add(nesne);
                    }
                }
                foreach (Nesne silinecek in silinecekNesne)
                {
                    kullanici.Mahsul.Remove(silinecek);
                }
            }

        }
        public static Nesne UcuzUrunNesneBul(string isim)
        {
            Nesne UcuzUrun = null;
            foreach (Kullanici kullanici in uyeler)
            {
                foreach (Nesne nesne in kullanici.Mahsul)
                {
                    if (nesne.Ad == isim && nesne.Onay)
                    {
                        if (UcuzUrun == null)
                        {
                            UcuzUrun = nesne;
                        }
                        else if (nesne.Fiyat > UcuzUrun.Fiyat)
                        {
                            UcuzUrun = nesne;
                        }
                    }
                }
            }
            return UcuzUrun;
        }
    }
}
