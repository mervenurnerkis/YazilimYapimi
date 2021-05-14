namespace YazilimYapimiProject
{
    partial class YapilanIslemler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıslemDetaylariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimYapimiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimYapimiDataSet = new BorsaProjesi.YazilimYapimiDataSet();
            this.islemDetaylariTableAdapter = new BorsaProjesi.YazilimYapimiDataSetTableAdapters.IslemDetaylariTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ıslemDetaylariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gerceklesilenIsinZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDetayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciKalanTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urununBirimFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gerceklesilenIsinZamaniDataGridViewTextBoxColumn,
            this.ıslemDetayiDataGridViewTextBoxColumn,
            this.alinanTutarDataGridViewTextBoxColumn,
            this.aliciKalanTutarDataGridViewTextBoxColumn,
            this.urununBirimFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ıslemDetaylariBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıslemDetaylariBindingSource
            // 
            this.ıslemDetaylariBindingSource.DataMember = "IslemDetaylari";
            this.ıslemDetaylariBindingSource.DataSource = this.yazilimYapimiDataSetBindingSource;
            // 
            // yazilimYapimiDataSetBindingSource
            // 
            this.yazilimYapimiDataSetBindingSource.DataSource = this.yazilimYapimiDataSet;
            this.yazilimYapimiDataSetBindingSource.Position = 0;
            // 
            // yazilimYapimiDataSet
            // 
            this.yazilimYapimiDataSet.DataSetName = "YazilimYapimiDataSet";
            this.yazilimYapimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemDetaylariTableAdapter
            // 
            this.islemDetaylariTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ıslemDetaylariBindingSource1
            // 
            this.ıslemDetaylariBindingSource1.DataMember = "IslemDetaylari";
            this.ıslemDetaylariBindingSource1.DataSource = this.yazilimYapimiDataSetBindingSource;
            // 
            // gerceklesilenIsinZamaniDataGridViewTextBoxColumn
            // 
            this.gerceklesilenIsinZamaniDataGridViewTextBoxColumn.DataPropertyName = "GerceklesilenIsinZamani";
            this.gerceklesilenIsinZamaniDataGridViewTextBoxColumn.HeaderText = "GerceklesilenIsinZamani";
            this.gerceklesilenIsinZamaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gerceklesilenIsinZamaniDataGridViewTextBoxColumn.Name = "gerceklesilenIsinZamaniDataGridViewTextBoxColumn";
            // 
            // ıslemDetayiDataGridViewTextBoxColumn
            // 
            this.ıslemDetayiDataGridViewTextBoxColumn.DataPropertyName = "IslemDetayi";
            this.ıslemDetayiDataGridViewTextBoxColumn.HeaderText = "IslemDetayi";
            this.ıslemDetayiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemDetayiDataGridViewTextBoxColumn.Name = "ıslemDetayiDataGridViewTextBoxColumn";
            // 
            // alinanTutarDataGridViewTextBoxColumn
            // 
            this.alinanTutarDataGridViewTextBoxColumn.DataPropertyName = "AlinanTutar";
            this.alinanTutarDataGridViewTextBoxColumn.HeaderText = "AlinanTutar";
            this.alinanTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alinanTutarDataGridViewTextBoxColumn.Name = "alinanTutarDataGridViewTextBoxColumn";
            // 
            // aliciKalanTutarDataGridViewTextBoxColumn
            // 
            this.aliciKalanTutarDataGridViewTextBoxColumn.DataPropertyName = "AliciKalanTutar";
            this.aliciKalanTutarDataGridViewTextBoxColumn.HeaderText = "AliciKalanTutar";
            this.aliciKalanTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciKalanTutarDataGridViewTextBoxColumn.Name = "aliciKalanTutarDataGridViewTextBoxColumn";
            // 
            // urununBirimFiyatiDataGridViewTextBoxColumn
            // 
            this.urununBirimFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrununBirimFiyati";
            this.urununBirimFiyatiDataGridViewTextBoxColumn.HeaderText = "UrununBirimFiyati";
            this.urununBirimFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urununBirimFiyatiDataGridViewTextBoxColumn.Name = "urununBirimFiyatiDataGridViewTextBoxColumn";
            // 
            // YapilanIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1351, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YapilanIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.Islemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BorsaProjesi.YazilimYapimiDataSet yazilimYapimiDataSet;
        private System.Windows.Forms.BindingSource yazilimYapimiDataSetBindingSource;
        private System.Windows.Forms.BindingSource ıslemDetaylariBindingSource;
        private BorsaProjesi.YazilimYapimiDataSetTableAdapters.IslemDetaylariTableAdapter islemDetaylariTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ıslemDetaylariBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerceklesilenIsinZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDetayiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciKalanTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urununBirimFiyatiDataGridViewTextBoxColumn;
    }
}