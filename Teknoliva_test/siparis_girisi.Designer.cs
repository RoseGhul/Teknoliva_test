namespace Teknoliva_test
{
    partial class siparis_girisi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_siparis = new System.Windows.Forms.DateTimePicker();
            this.textBox_evrakNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yeni_satir_ekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_siparis_girisi = new System.Windows.Forms.DataGridView();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ara_toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.siparis_bilgilerini_kaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toplam_fiyat_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_siparis_girisi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_siparis);
            this.groupBox1.Controls.Add(this.textBox_evrakNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yeni_satir_ekle);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Temel Bilgileri";
            // 
            // dateTimePicker_siparis
            // 
            this.dateTimePicker_siparis.Location = new System.Drawing.Point(101, 75);
            this.dateTimePicker_siparis.Name = "dateTimePicker_siparis";
            this.dateTimePicker_siparis.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker_siparis.TabIndex = 4;
            this.dateTimePicker_siparis.ValueChanged += new System.EventHandler(this.dateTimePicker_siparis_ValueChanged);
            // 
            // textBox_evrakNo
            // 
            this.textBox_evrakNo.Location = new System.Drawing.Point(101, 36);
            this.textBox_evrakNo.Name = "textBox_evrakNo";
            this.textBox_evrakNo.Size = new System.Drawing.Size(262, 22);
            this.textBox_evrakNo.TabIndex = 3;
            this.textBox_evrakNo.TextChanged += new System.EventHandler(this.textBox_evrakNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evrak No:";
            // 
            // yeni_satir_ekle
            // 
            this.yeni_satir_ekle.Location = new System.Drawing.Point(789, 81);
            this.yeni_satir_ekle.Name = "yeni_satir_ekle";
            this.yeni_satir_ekle.Size = new System.Drawing.Size(116, 25);
            this.yeni_satir_ekle.TabIndex = 0;
            this.yeni_satir_ekle.Text = "Yeni Satır Ekle";
            this.yeni_satir_ekle.UseVisualStyleBackColor = true;
            this.yeni_satir_ekle.Click += new System.EventHandler(this.yeni_satir_ekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_siparis_girisi);
            this.groupBox2.Location = new System.Drawing.Point(11, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_siparis_girisi
            // 
            this.dataGridView_siparis_girisi.AllowUserToAddRows = false;
            this.dataGridView_siparis_girisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_siparis_girisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sira,
            this.stok_adi,
            this.stok_kodu,
            this.birim_fiyat,
            this.miktar,
            this.ara_toplam});
            this.dataGridView_siparis_girisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_siparis_girisi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_siparis_girisi.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_siparis_girisi.Name = "dataGridView_siparis_girisi";
            this.dataGridView_siparis_girisi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_siparis_girisi.RowHeadersWidth = 51;
            this.dataGridView_siparis_girisi.RowTemplate.Height = 24;
            this.dataGridView_siparis_girisi.Size = new System.Drawing.Size(917, 264);
            this.dataGridView_siparis_girisi.TabIndex = 0;
            this.dataGridView_siparis_girisi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_siparis_girisi_CellClick);
            this.dataGridView_siparis_girisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_siparis_girisi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_siparis_girisi_CellEndEdit);
            // 
            // sira
            // 
            this.sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sira.HeaderText = "Sıra";
            this.sira.MinimumWidth = 6;
            this.sira.Name = "sira";
            // 
            // stok_adi
            // 
            this.stok_adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stok_adi.HeaderText = "Stok Adı";
            this.stok_adi.MinimumWidth = 6;
            this.stok_adi.Name = "stok_adi";
            // 
            // stok_kodu
            // 
            this.stok_kodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stok_kodu.HeaderText = "Stok Kodu";
            this.stok_kodu.MinimumWidth = 6;
            this.stok_kodu.Name = "stok_kodu";
            // 
            // birim_fiyat
            // 
            this.birim_fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birim_fiyat.HeaderText = "Birim Fiyat";
            this.birim_fiyat.MinimumWidth = 6;
            this.birim_fiyat.Name = "birim_fiyat";
            // 
            // miktar
            // 
            this.miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miktar.HeaderText = "Miktar";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            // 
            // ara_toplam
            // 
            this.ara_toplam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ara_toplam.HeaderText = "Ara Toplam";
            this.ara_toplam.MinimumWidth = 6;
            this.ara_toplam.Name = "ara_toplam";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(20, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(914, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş Toplam Bilgileri";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.siparis_bilgilerini_kaydet);
            this.groupBox5.Location = new System.Drawing.Point(302, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(594, 86);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // siparis_bilgilerini_kaydet
            // 
            this.siparis_bilgilerini_kaydet.Location = new System.Drawing.Point(6, 11);
            this.siparis_bilgilerini_kaydet.Name = "siparis_bilgilerini_kaydet";
            this.siparis_bilgilerini_kaydet.Size = new System.Drawing.Size(582, 69);
            this.siparis_bilgilerini_kaydet.TabIndex = 0;
            this.siparis_bilgilerini_kaydet.Text = "Sipariş Bilgilerini Kaydet";
            this.siparis_bilgilerini_kaydet.UseVisualStyleBackColor = true;
            this.siparis_bilgilerini_kaydet.Click += new System.EventHandler(this.siparis_bilgilerini_kaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toplam_fiyat_label);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 86);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // toplam_fiyat_label
            // 
            this.toplam_fiyat_label.AutoSize = true;
            this.toplam_fiyat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_fiyat_label.ForeColor = System.Drawing.Color.Red;
            this.toplam_fiyat_label.Location = new System.Drawing.Point(130, 22);
            this.toplam_fiyat_label.Name = "toplam_fiyat_label";
            this.toplam_fiyat_label.Size = new System.Drawing.Size(58, 26);
            this.toplam_fiyat_label.TabIndex = 1;
            this.toplam_fiyat_label.Text = "0,00";
            this.toplam_fiyat_label.Click += new System.EventHandler(this.toplam_fiyat_label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Fiyat:";
            // 
            // siparis_girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "siparis_girisi";
            this.Text = "Sipariş Girişi";
            this.Load += new System.EventHandler(this.siparis_girisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_siparis_girisi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yeni_satir_ekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button siparis_bilgilerini_kaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn birim_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ara_toplam;
        public System.Windows.Forms.TextBox textBox_evrakNo;
        public System.Windows.Forms.DateTimePicker dateTimePicker_siparis;
        public System.Windows.Forms.DataGridView dataGridView_siparis_girisi;
        public System.Windows.Forms.Label toplam_fiyat_label;
    }
}