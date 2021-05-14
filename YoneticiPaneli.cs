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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new YapilanIslemler().ShowDialog();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TalepleriGuncelle();
        }
        void PanelGuncelle()
        {
            foreach (Kullanici kullanici in GirilenVeriler.uyeler)
            {
                listKullanicilar.Items.Add(kullanici.KullaniciAdi + " - " + kullanici.Ad + " " + kullanici.Soyad + " Bakiye: " + kullanici.Bakiye);
            }
        } 
        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazilimYapimiDataSet.listUrunTalep' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.listUrunTalepTableAdapter.Fill(this.yazilimYapimiDataSet.listUrunTalep);



            PanelGuncelle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listKullanicilar.SelectedIndex >= 0)
            {
                string nickName = listKullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici Secilen = GirilenVeriler.kullaniciAra(nickName);
                
                Secilen.Bakiye += Secilen.BakiyeOnay;
                Secilen.BakiyeOnay = 0;

            }
            TalepleriGuncelle();
        }
        void TalepleriGuncelle()
        {
            if (listKullanicilar.SelectedIndex >= 0)
            {
                string nickName = listKullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici Secilen = GirilenVeriler.kullaniciAra(nickName);
                
                lblTalep.Text = Secilen.BakiyeOnay.ToString() + " TL";
                
               
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listKullanicilar.SelectedIndex >= 0)
            {
                string nickName = listKullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici Secilen = GirilenVeriler.kullaniciAra(nickName);
                foreach (Nesne urun in Secilen.Mahsul)
                {
                    if (urun.Onay == false)
                    {
                        urun.Onay = true;
                    }
                }
            }
            TalepleriGuncelle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnİslemler_Click(object sender, EventArgs e)
        {
            YapilanIslemler yapilanIslemler = new YapilanIslemler();
            yapilanIslemler.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginEkrani loginEkrani = new LoginEkrani();
            loginEkrani.ShowDialog();
        }

        private void btnTalep_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Taleplerin hepsi başarılı bir şekilde onaylanmıştır.");
            
        }

        private void listUrunTalepBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnBakiyeOnay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Talep edilen bakiyeniz onaylanmıştır. Güle Güle kullanın.");
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
