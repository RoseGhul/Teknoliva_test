namespace Teknoliva_test
{
    partial class siparis_kayitlari
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.stk_krt_list = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_siparis_kayitlari = new System.Windows.Forms.DataGridView();
            this.evrak_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparis_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evrak_tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_siparis_kayitlari)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = " Yeni Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stk_krt_list
            // 
            this.stk_krt_list.BackColor = System.Drawing.Color.Yellow;
            this.stk_krt_list.Location = new System.Drawing.Point(218, 19);
            this.stk_krt_list.Name = "stk_krt_list";
            this.stk_krt_list.Size = new System.Drawing.Size(131, 31);
            this.stk_krt_list.TabIndex = 1;
            this.stk_krt_list.Text = "Stok Kart Liste";
            this.stk_krt_list.UseVisualStyleBackColor = false;
            this.stk_krt_list.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stk_krt_list);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_siparis_kayitlari);
            this.groupBox2.Location = new System.Drawing.Point(0, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 459);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_siparis_kayitlari
            // 
            this.dataGridView_siparis_kayitlari.AllowUserToAddRows = false;
            this.dataGridView_siparis_kayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_siparis_kayitlari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evrak_no,
            this.siparis_tarihi,
            this.evrak_tutar});
            this.dataGridView_siparis_kayitlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_siparis_kayitlari.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_siparis_kayitlari.Name = "dataGridView_siparis_kayitlari";
            this.dataGridView_siparis_kayitlari.RowHeadersWidth = 51;
            this.dataGridView_siparis_kayitlari.RowTemplate.Height = 24;
            this.dataGridView_siparis_kayitlari.Size = new System.Drawing.Size(357, 438);
            this.dataGridView_siparis_kayitlari.TabIndex = 0;
            this.dataGridView_siparis_kayitlari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_siparis_kayitlari_CellContentClick);
            this.dataGridView_siparis_kayitlari.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_siparis_kayitlari_CellContentDoubleClick);
            // 
            // evrak_no
            // 
            this.evrak_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evrak_no.HeaderText = "Evrak No";
            this.evrak_no.MinimumWidth = 6;
            this.evrak_no.Name = "evrak_no";
            // 
            // siparis_tarihi
            // 
            this.siparis_tarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siparis_tarihi.HeaderText = "Sipariş Tarihi";
            this.siparis_tarihi.MinimumWidth = 6;
            this.siparis_tarihi.Name = "siparis_tarihi";
            // 
            // evrak_tutar
            // 
            this.evrak_tutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evrak_tutar.HeaderText = "Evrak Tutar";
            this.evrak_tutar.MinimumWidth = 6;
            this.evrak_tutar.Name = "evrak_tutar";
            // 
            // siparis_kayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "siparis_kayitlari";
            this.Text = "Sipariş Kayıtları";
            this.Load += new System.EventHandler(this.siparis_kayitlari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_siparis_kayitlari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stk_krt_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_siparis_kayitlari;
        private System.Windows.Forms.DataGridViewTextBoxColumn evrak_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparis_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn evrak_tutar;
    }
}

