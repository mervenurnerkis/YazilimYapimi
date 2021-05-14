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
    public partial class KullaniciEkrani : Form
    {
        Kullanici kullanici;
        public KullaniciEkrani(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            Text = " Stock Market'e Hoşgeldiniz " + kullanici.Ad + " " + kullanici.Soyad+ " "+DateTime.Now.ToShortDateString();
            EkranGuncelle();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                kullanici.BakiyeOnay += double.Parse(textBox1.Text);
                EkranGuncelle();
                MessageBox.Show("Bakiye isteğiniz onaya gönderildi. Sizi biraz bekleteceğiz.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı değer girdiniz. Lütfen tekrar deneyiniz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbxUrun.SelectedIndex>=0)
            {
                Talepler talep = new Talepler(kullanici, cbxUrun.Text, int.Parse(tbMiktar.Value.ToString()));
                GirilenVeriler.UrunTalepleri.Add(talep);
                GirilenVeriler.TalepKontrol();
                EkranGuncelle();
                MessageBox.Show("Sipariş ettiğiniz ürün onaya gitti.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxUrun.SelectedIndex >= 0)
            {
                Nesne yeni = new Nesne(cbxUrun.Text, int.Parse(tbMiktar.Value.ToString()), double.Parse(tbBirimFiyat.Value.ToString()), kullanici);
                kullanici.NesneEkle(yeni);
                EkranGuncelle();
                MessageBox.Show("Ürün onaya gönderildi.");
            }
            else MessageBox.Show("Seçim yapınız.");
        }
        void EkranGuncelle()
        {
            listUrun.Items.Clear();
            foreach (Nesne nesne in kullanici.Mahsul)
            {
                listUrun.Items.Add("Ad :" + nesne.Ad + " Fiyat: " + nesne.Fiyat + " Miktar: " + nesne.Miktar);
            }
            listAlisTalep.Items.Clear();
            List<Talepler> talepler = GirilenVeriler.KullaniciTalepleri(kullanici);
            foreach (Talepler talep in talepler)
            {
                listAlisTalep.Items.Add("Ad: " + talep.Urun + " Miktar: " + talep.Miktar);
            }
            

            lblBakiyeOnay.Text = kullanici.BakiyeOnay.ToString() + "  TL";
            lblBakiye.Text = kullanici.Bakiye.ToString() + "  TL";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginEkrani loginEkrani = new LoginEkrani();
            loginEkrani.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
