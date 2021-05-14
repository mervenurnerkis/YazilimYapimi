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
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici newSign = new Kullanici(txtKullanici.Text, tbSifre.Text, mskTC.Text, tbAd.Text, tbSoyad.Text, mskTel.Text, txtEmail.Text, rchAdres.Text);
            if (GirilenVeriler.SignUp(newSign))
            {
                MessageBox.Show("Kaydınız başarılı bir şekilde gerçekleşmiştir.");
            }
            else
            {
                MessageBox.Show("Kaydınız başarısız sonuçlanmıştır. Lütfen tekrar deneyiniz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text=="admin"&&txtSifre.Text=="1234")
            {
                new YoneticiPaneli().ShowDialog();
            }
            else
            {
                Kullanici giris = GirilenVeriler.Login(txtKullaniciAdi.Text, txtSifre.Text);
                if (giris != null)
                {
                    new KullaniciEkrani(giris).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı. Lütfen tekrar deneyiniz!");
                }
            }
        }

       

        private void txtSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txtSifre.Text = "";
        }

        private void txtKullaniciAdi_MouseClick(object sender, MouseEventArgs e)
        {
            txtKullaniciAdi.Text = "";
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
