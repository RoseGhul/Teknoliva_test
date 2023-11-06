namespace Teknoliva_test
{
    partial class frm_stok_kart
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
            this.bilgileri_kaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_birim_fiyat = new System.Windows.Forms.NumericUpDown();
            this.textbox_stok_adi = new System.Windows.Forms.TextBox();
            this.textbox_stok_kodu = new System.Windows.Forms.TextBox();
            this.listView_stok_kart = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_birim_fiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bilgileri_kaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_birim_fiyat);
            this.groupBox1.Controls.Add(this.textbox_stok_adi);
            this.groupBox1.Controls.Add(this.textbox_stok_kodu);
            this.groupBox1.Location = new System.Drawing.Point(269, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Kart Bilgileri";
            // 
            // bilgileri_kaydet
            // 
            this.bilgileri_kaydet.Location = new System.Drawing.Point(18, 258);
            this.bilgileri_kaydet.Name = "bilgileri_kaydet";
            this.bilgileri_kaydet.Size = new System.Drawing.Size(211, 56);
            this.bilgileri_kaydet.TabIndex = 6;
            this.bilgileri_kaydet.Text = "Bilgileri Kaydet";
            this.bilgileri_kaydet.UseVisualStyleBackColor = true;
            this.bilgileri_kaydet.Click += new System.EventHandler(this.bilgileri_kaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birim Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stok Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stok Kodu";
            // 
            // numericUpDown_birim_fiyat
            // 
            this.numericUpDown_birim_fiyat.Location = new System.Drawing.Point(18, 210);
            this.numericUpDown_birim_fiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_birim_fiyat.Name = "numericUpDown_birim_fiyat";
            this.numericUpDown_birim_fiyat.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown_birim_fiyat.TabIndex = 2;
            // 
            // textbox_stok_adi
            // 
            this.textbox_stok_adi.Location = new System.Drawing.Point(18, 141);
            this.textbox_stok_adi.Name = "textbox_stok_adi";
            this.textbox_stok_adi.Size = new System.Drawing.Size(211, 22);
            this.textbox_stok_adi.TabIndex = 1;
            // 
            // textbox_stok_kodu
            // 
            this.textbox_stok_kodu.Location = new System.Drawing.Point(18, 65);
            this.textbox_stok_kodu.Name = "textbox_stok_kodu";
            this.textbox_stok_kodu.Size = new System.Drawing.Size(211, 22);
            this.textbox_stok_kodu.TabIndex = 0;
            this.textbox_stok_kodu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView_stok_kart
            // 
            this.listView_stok_kart.HideSelection = false;
            this.listView_stok_kart.Location = new System.Drawing.Point(29, 53);
            this.listView_stok_kart.Name = "listView_stok_kart";
            this.listView_stok_kart.Size = new System.Drawing.Size(223, 451);
            this.listView_stok_kart.TabIndex = 2;
            this.listView_stok_kart.UseCompatibleStateImageBehavior = false;
            this.listView_stok_kart.View = System.Windows.Forms.View.List;
            this.listView_stok_kart.SelectedIndexChanged += new System.EventHandler(this.listView_stok_kart_SelectedIndexChanged);
            // 
            // frm_stok_kart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 538);
            this.Controls.Add(this.listView_stok_kart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_stok_kart";
            this.Text = "Frm Stok Kart";
            this.Load += new System.EventHandler(this.frm_stok_kart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_birim_fiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_birim_fiyat;
        private System.Windows.Forms.TextBox textbox_stok_adi;
        private System.Windows.Forms.TextBox textbox_stok_kodu;
        private System.Windows.Forms.Button bilgileri_kaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_stok_kart;
    }
}