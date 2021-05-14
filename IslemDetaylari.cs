using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiProject
{
    class IslemDetaylari
    {
        private DateTime tarih;
        private string bilgi;
        private string tutar;
        private string alicikalan;
        private string birimfiyat;

        public IslemDetaylari(string detay, string tutar, string alicikalan, string birimfiyat)
        {
            TarihSaat = DateTime.Now;
            Bilgi = bilgi;
            Tutar = tutar;
            Alicikalan = alicikalan;
            Birimfiyat = birimfiyat;
        }

        public DateTime TarihSaat { get => tarih; set => tarih = value; }
        public string Bilgi { get => bilgi; set => bilgi = value; }
        public string Tutar { get => tutar; set => tutar = value; }
        public string Alicikalan { get => alicikalan; set => alicikalan = value; }
        public string Birimfiyat { get => birimfiyat; set => birimfiyat = value; }
    }
}
