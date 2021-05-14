using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiProject
{
    public partial class YapilanIslemler : Form
    {
        public YapilanIslemler()
        {
            InitializeComponent();
        }

        private void Islemler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazilimYapimiDataSet.IslemDetaylari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.islemDetaylariTableAdapter.Fill(this.yazilimYapimiDataSet.IslemDetaylari);
            //this.İslemDetaylarıTableAdapter.Fill(this.yazilimYapimiDataSet.İslemDetayları);
            foreach (IslemDetaylari islem in GirilenVeriler.Islemler)
            {
                dataGridView1.Rows.Add(islem.TarihSaat, islem.Bilgi, islem.Tutar, islem.Alicikalan, islem.Birimfiyat);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.ShowDialog();
        }
    }
}
