namespace YazilimYapimiProject
{
    partial class KullaniciEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkrani));
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.lblUrunTipi = new System.Windows.Forms.Label();
            this.grpUrunEkle = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.tbMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.grpBakiyeEkle = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBakiyem = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblSahipUrun = new System.Windows.Forms.Label();
            this.listUrun = new System.Windows.Forms.ListBox();
            this.lblAlisTalep = new System.Windows.Forms.Label();
            this.listAlisTalep = new System.Windows.Forms.ListBox();
            this.lblOnay = new System.Windows.Forms.Label();
            this.lblBakiyeOnay = new System.Windows.Forms.Label();
            this.lblUrunEkle = new System.Windows.Forms.Label();
            this.lblBakiyeEkle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMiktar)).BeginInit();
            this.grpBakiyeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUrun
            // 
            this.cbxUrun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxUrun.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Items.AddRange(new object[] {
            "Buğday",
            "Arpa",
            "Yulaf",
            "Petrol",
            "Pamuk"});
            this.cbxUrun.Location = new System.Drawing.Point(124, 27);
            this.cbxUrun.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(226, 28);
            this.cbxUrun.TabIndex = 0;
            // 
            // lblUrunTipi
            // 
            this.lblUrunTipi.AutoSize = true;
            this.lblUrunTipi.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTipi.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUrunTipi.Location = new System.Drawing.Point(17, 27);
            this.lblUrunTipi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunTipi.Name = "lblUrunTipi";
            this.lblUrunTipi.Size = new System.Drawing.Size(98, 26);
            this.lblUrunTipi.TabIndex = 1;
            this.lblUrunTipi.Text = "Ürün Tipi:";
            // 
            // grpUrunEkle
            // 
            this.grpUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.grpUrunEkle.Controls.Add(this.button3);
            this.grpUrunEkle.Controls.Add(this.button1);
            this.grpUrunEkle.Controls.Add(this.tbBirimFiyat);
            this.grpUrunEkle.Controls.Add(this.lblBirimFiyat);
            this.grpUrunEkle.Controls.Add(this.tbMiktar);
            this.grpUrunEkle.Controls.Add(this.lblMiktar);
            this.grpUrunEkle.Controls.Add(this.lblUrunTipi);
            this.grpUrunEkle.Controls.Add(this.cbxUrun);
            this.grpUrunEkle.Location = new System.Drawing.Point(27, 65);
            this.grpUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.grpUrunEkle.Name = "grpUrunEkle";
            this.grpUrunEkle.Padding = new System.Windows.Forms.Padding(4);
            this.grpUrunEkle.Size = new System.Drawing.Size(431, 208);
            this.grpUrunEkle.TabIndex = 2;
            this.grpUrunEkle.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(40, 144);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Alış Talebi Gönder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(217, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Onaya Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBirimFiyat
            // 
            this.tbBirimFiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBirimFiyat.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBirimFiyat.Location = new System.Drawing.Point(343, 80);
            this.tbBirimFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tbBirimFiyat.Name = "tbBirimFiyat";
            this.tbBirimFiyat.Size = new System.Drawing.Size(71, 28);
            this.tbBirimFiyat.TabIndex = 2;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBirimFiyat.Location = new System.Drawing.Point(225, 79);
            this.lblBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(112, 26);
            this.lblBirimFiyat.TabIndex = 1;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // tbMiktar
            // 
            this.tbMiktar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbMiktar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMiktar.Location = new System.Drawing.Point(124, 77);
            this.tbMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(60, 28);
            this.tbMiktar.TabIndex = 2;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMiktar.Location = new System.Drawing.Point(16, 79);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(76, 26);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "Miktar:";
            // 
            // grpBakiyeEkle
            // 
            this.grpBakiyeEkle.BackColor = System.Drawing.Color.Transparent;
            this.grpBakiyeEkle.Controls.Add(this.button2);
            this.grpBakiyeEkle.Controls.Add(this.label4);
            this.grpBakiyeEkle.Controls.Add(this.textBox1);
            this.grpBakiyeEkle.Location = new System.Drawing.Point(27, 338);
            this.grpBakiyeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.grpBakiyeEkle.Name = "grpBakiyeEkle";
            this.grpBakiyeEkle.Padding = new System.Windows.Forms.Padding(4);
            this.grpBakiyeEkle.Size = new System.Drawing.Size(431, 138);
            this.grpBakiyeEkle.TabIndex = 4;
            this.grpBakiyeEkle.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Onaya Gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(130, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bakiye:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(217, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBakiyem
            // 
            this.lblBakiyem.AutoSize = true;
            this.lblBakiyem.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiyem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiyem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBakiyem.Location = new System.Drawing.Point(33, 508);
            this.lblBakiyem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyem.Name = "lblBakiyem";
            this.lblBakiyem.Size = new System.Drawing.Size(100, 28);
            this.lblBakiyem.TabIndex = 5;
            this.lblBakiyem.Text = "Bakiyem: ";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBakiye.Location = new System.Drawing.Point(128, 508);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(49, 28);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "0TL";
            // 
            // lblSahipUrun
            // 
            this.lblSahipUrun.AutoSize = true;
            this.lblSahipUrun.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSahipUrun.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSahipUrun.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSahipUrun.Location = new System.Drawing.Point(529, 26);
            this.lblSahipUrun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSahipUrun.Name = "lblSahipUrun";
            this.lblSahipUrun.Size = new System.Drawing.Size(350, 35);
            this.lblSahipUrun.TabIndex = 5;
            this.lblSahipUrun.Text = "SAHİP OLDUĞUM ÜRÜNLER";
            // 
            // listUrun
            // 
            this.listUrun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listUrun.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrun.FormattingEnabled = true;
            this.listUrun.ItemHeight = 24;
            this.listUrun.Location = new System.Drawing.Point(528, 75);
            this.listUrun.Margin = new System.Windows.Forms.Padding(4);
            this.listUrun.Name = "listUrun";
            this.listUrun.Size = new System.Drawing.Size(351, 196);
            this.listUrun.TabIndex = 6;
            // 
            // lblAlisTalep
            // 
            this.lblAlisTalep.AutoSize = true;
            this.lblAlisTalep.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlisTalep.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAlisTalep.Location = new System.Drawing.Point(529, 299);
            this.lblAlisTalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlisTalep.Name = "lblAlisTalep";
            this.lblAlisTalep.Size = new System.Drawing.Size(249, 35);
            this.lblAlisTalep.TabIndex = 5;
            this.lblAlisTalep.Text = "ALIŞ TALEPLERİM:";
            // 
            // listAlisTalep
            // 
            this.listAlisTalep.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listAlisTalep.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAlisTalep.FormattingEnabled = true;
            this.listAlisTalep.ItemHeight = 24;
            this.listAlisTalep.Location = new System.Drawing.Point(528, 348);
            this.listAlisTalep.Margin = new System.Windows.Forms.Padding(4);
            this.listAlisTalep.Name = "listAlisTalep";
            this.listAlisTalep.Size = new System.Drawing.Size(351, 196);
            this.listAlisTalep.TabIndex = 6;
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.BackColor = System.Drawing.Color.Transparent;
            this.lblOnay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnay.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOnay.Location = new System.Drawing.Point(252, 508);
            this.lblOnay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(152, 28);
            this.lblOnay.TabIndex = 5;
            this.lblOnay.Text = "Onay Bekleyen:";
            // 
            // lblBakiyeOnay
            // 
            this.lblBakiyeOnay.AutoSize = true;
            this.lblBakiyeOnay.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiyeOnay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiyeOnay.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBakiyeOnay.Location = new System.Drawing.Point(412, 508);
            this.lblBakiyeOnay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyeOnay.Name = "lblBakiyeOnay";
            this.lblBakiyeOnay.Size = new System.Drawing.Size(49, 28);
            this.lblBakiyeOnay.TabIndex = 5;
            this.lblBakiyeOnay.Text = "0TL";
            // 
            // lblUrunEkle
            // 
            this.lblUrunEkle.AutoSize = true;
            this.lblUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunEkle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunEkle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUrunEkle.Location = new System.Drawing.Point(162, 26);
            this.lblUrunEkle.Name = "lblUrunEkle";
            this.lblUrunEkle.Size = new System.Drawing.Size(154, 35);
            this.lblUrunEkle.TabIndex = 7;
            this.lblUrunEkle.Text = "ÜRÜN EKLE";
            // 
            // lblBakiyeEkle
            // 
            this.lblBakiyeEkle.AutoSize = true;
            this.lblBakiyeEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiyeEkle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiyeEkle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBakiyeEkle.Location = new System.Drawing.Point(164, 299);
            this.lblBakiyeEkle.Name = "lblBakiyeEkle";
            this.lblBakiyeEkle.Size = new System.Drawing.Size(174, 35);
            this.lblBakiyeEkle.TabIndex = 8;
            this.lblBakiyeEkle.Text = "BAKİYE EKLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(910, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "Geri Dön";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(938, 576);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBakiyeEkle);
            this.Controls.Add(this.lblUrunEkle);
            this.Controls.Add(this.listAlisTalep);
            this.Controls.Add(this.listUrun);
            this.Controls.Add(this.lblBakiyeOnay);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblAlisTalep);
            this.Controls.Add(this.lblSahipUrun);
            this.Controls.Add(this.lblOnay);
            this.Controls.Add(this.lblBakiyem);
            this.Controls.Add(this.grpBakiyeEkle);
            this.Controls.Add(this.grpUrunEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            this.grpUrunEkle.ResumeLayout(false);
            this.grpUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMiktar)).EndInit();
            this.grpBakiyeEkle.ResumeLayout(false);
            this.grpBakiyeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUrun;
        private System.Windows.Forms.Label lblUrunTipi;
        private System.Windows.Forms.GroupBox grpUrunEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tbMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown tbBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.GroupBox grpBakiyeEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblBakiyem;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblSahipUrun;
        private System.Windows.Forms.ListBox listUrun;
        private System.Windows.Forms.Label lblAlisTalep;
        private System.Windows.Forms.ListBox listAlisTalep;
        private System.Windows.Forms.Label lblOnay;
        private System.Windows.Forms.Label lblBakiyeOnay;
        private System.Windows.Forms.Label lblUrunEkle;
        private System.Windows.Forms.Label lblBakiyeEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
    }
}