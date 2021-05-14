namespace YazilimYapimiProject
{
    partial class YoneticiPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.lblTalep = new System.Windows.Forms.Label();
            this.lblBakiyeTalebi = new System.Windows.Forms.Label();
            this.btnBakiyeOnay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUrunTalepleri = new System.Windows.Forms.Label();
            this.btnTalep = new System.Windows.Forms.Button();
            this.btnİslemler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listUrunTalepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimYapimiDataSet = new BorsaProjesi.YazilimYapimiDataSet();
            this.listKullanicilar = new System.Windows.Forms.ListBox();
            this.listUrunTalepTableAdapter = new BorsaProjesi.YazilimYapimiDataSetTableAdapters.listUrunTalepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUrunTalepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1030, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblKullanicilar);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.AutoSize = true;
            this.lblKullanicilar.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanicilar.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanicilar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKullanicilar.Location = new System.Drawing.Point(112, 18);
            this.lblKullanicilar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(188, 45);
            this.lblKullanicilar.TabIndex = 6;
            this.lblKullanicilar.Text = "Kullanıcılar";
            // 
            // lblTalep
            // 
            this.lblTalep.AutoSize = true;
            this.lblTalep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTalep.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTalep.Location = new System.Drawing.Point(247, 326);
            this.lblTalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTalep.Name = "lblTalep";
            this.lblTalep.Size = new System.Drawing.Size(49, 28);
            this.lblTalep.TabIndex = 5;
            this.lblTalep.Text = "0TL";
            // 
            // lblBakiyeTalebi
            // 
            this.lblBakiyeTalebi.AutoSize = true;
            this.lblBakiyeTalebi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiyeTalebi.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBakiyeTalebi.Location = new System.Drawing.Point(27, 326);
            this.lblBakiyeTalebi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyeTalebi.Name = "lblBakiyeTalebi";
            this.lblBakiyeTalebi.Size = new System.Drawing.Size(149, 28);
            this.lblBakiyeTalebi.TabIndex = 7;
            this.lblBakiyeTalebi.Text = "Bakiye Talebi :";
            // 
            // btnBakiyeOnay
            // 
            this.btnBakiyeOnay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBakiyeOnay.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiyeOnay.Location = new System.Drawing.Point(99, 388);
            this.btnBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnBakiyeOnay.Name = "btnBakiyeOnay";
            this.btnBakiyeOnay.Size = new System.Drawing.Size(167, 42);
            this.btnBakiyeOnay.TabIndex = 4;
            this.btnBakiyeOnay.Text = "Bakiyeyi Onayla";
            this.btnBakiyeOnay.UseVisualStyleBackColor = false;
            this.btnBakiyeOnay.Click += new System.EventHandler(this.btnBakiyeOnay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblUrunTalepleri);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lblUrunTalepleri
            // 
            this.lblUrunTalepleri.AutoSize = true;
            this.lblUrunTalepleri.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTalepleri.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUrunTalepleri.Location = new System.Drawing.Point(144, 18);
            this.lblUrunTalepleri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunTalepleri.Name = "lblUrunTalepleri";
            this.lblUrunTalepleri.Size = new System.Drawing.Size(246, 45);
            this.lblUrunTalepleri.TabIndex = 6;
            this.lblUrunTalepleri.Text = "Ürün Talepleri";
            // 
            // btnTalep
            // 
            this.btnTalep.BackColor = System.Drawing.Color.Thistle;
            this.btnTalep.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalep.ForeColor = System.Drawing.Color.Black;
            this.btnTalep.Location = new System.Drawing.Point(460, 326);
            this.btnTalep.Margin = new System.Windows.Forms.Padding(4);
            this.btnTalep.Name = "btnTalep";
            this.btnTalep.Size = new System.Drawing.Size(324, 41);
            this.btnTalep.TabIndex = 4;
            this.btnTalep.Text = "Tüm Talepleri Onayla";
            this.btnTalep.UseVisualStyleBackColor = false;
            this.btnTalep.Click += new System.EventHandler(this.btnTalep_Click);
            // 
            // btnİslemler
            // 
            this.btnİslemler.BackColor = System.Drawing.Color.Thistle;
            this.btnİslemler.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİslemler.Location = new System.Drawing.Point(815, 326);
            this.btnİslemler.Margin = new System.Windows.Forms.Padding(4);
            this.btnİslemler.Name = "btnİslemler";
            this.btnİslemler.Size = new System.Drawing.Size(210, 41);
            this.btnİslemler.TabIndex = 5;
            this.btnİslemler.Text = "İşlemler";
            this.btnİslemler.UseVisualStyleBackColor = false;
            this.btnİslemler.Click += new System.EventHandler(this.btnİslemler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.kiloDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listUrunTalepBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(394, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 200);
            this.dataGridView1.TabIndex = 8;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiloDataGridViewTextBoxColumn
            // 
            this.kiloDataGridViewTextBoxColumn.DataPropertyName = "kilo";
            this.kiloDataGridViewTextBoxColumn.HeaderText = "kilo";
            this.kiloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiloDataGridViewTextBoxColumn.Name = "kiloDataGridViewTextBoxColumn";
            this.kiloDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // listUrunTalepBindingSource
            // 
            this.listUrunTalepBindingSource.DataMember = "listUrunTalep";
            this.listUrunTalepBindingSource.DataSource = this.yazilimYapimiDataSet;
            // 
            // yazilimYapimiDataSet
            // 
            this.yazilimYapimiDataSet.DataSetName = "YazilimYapimiDataSet";
            this.yazilimYapimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listKullanicilar
            // 
            this.listKullanicilar.BackColor = System.Drawing.Color.LightGray;
            this.listKullanicilar.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKullanicilar.FormattingEnabled = true;
            this.listKullanicilar.ItemHeight = 18;
            this.listKullanicilar.Location = new System.Drawing.Point(23, 79);
            this.listKullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.listKullanicilar.Name = "listKullanicilar";
            this.listKullanicilar.Size = new System.Drawing.Size(364, 202);
            this.listKullanicilar.TabIndex = 3;
            // 
            // listUrunTalepTableAdapter
            // 
            this.listUrunTalepTableAdapter.ClearBeforeFill = true;
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1071, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTalep);
            this.Controls.Add(this.listKullanicilar);
            this.Controls.Add(this.btnİslemler);
            this.Controls.Add(this.btnTalep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBakiyeTalebi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBakiyeOnay);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUrunTalepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTalep;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.Label lblBakiyeTalebi;
        private System.Windows.Forms.Button btnBakiyeOnay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUrunTalepleri;
        private System.Windows.Forms.Button btnTalep;
        private System.Windows.Forms.Button btnİslemler;
        private System.Windows.Forms.Button button1;
        private BorsaProjesi.YazilimYapimiDataSet yazilimYapimiDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listKullanicilar;
        private System.Windows.Forms.BindingSource listUrunTalepBindingSource;
        private BorsaProjesi.YazilimYapimiDataSetTableAdapters.listUrunTalepTableAdapter listUrunTalepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
    }
}