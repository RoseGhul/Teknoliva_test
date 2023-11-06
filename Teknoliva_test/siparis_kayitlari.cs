using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teknoliva_test.models;

namespace Teknoliva_test
{
    public partial class siparis_kayitlari : Form
    {
        public string dosyaYolu = @"D:\Users\sugar\source\repos\Teknoliva_test\Teknoliva_test\Json\siparis_bilgileri.json";

        public siparis_kayitlari()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            siparis_girisi siparis_Girisi = new siparis_girisi();
            siparis_Girisi.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_stok_kart frmStokKart = new frm_stok_kart(); // frm_stok_kart formunun adı FormStokKart olarak varsayılmıştır, sizin formunuzun adını kullanmalısınız
            frmStokKart.Show(); // frm_stok_kart formunu görüntüle
        }

        private void siparis_kayitlari_Load(object sender, EventArgs e)
        {
           
            string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);
            List<evrak_kayit> evrak_kayit_listesi = JsonConvert.DeserializeObject<List<evrak_kayit>>(jsonVeri);

            if (evrak_kayit_listesi != null)
            {
                // DataGridView'da var olan siparişlerin listesini göster
                foreach (evrak_kayit evrak_kayit in evrak_kayit_listesi)
                {
                    dataGridView_siparis_kayitlari.Rows.Add(evrak_kayit.EvrakNo, evrak_kayit.SiparisTarihi, evrak_kayit.ToplamFiyat);
                }
            }
            else
            {
                dataGridView_siparis_kayitlari.ColumnHeadersVisible = false;
            }
        }


        private void dataGridView_siparis_kayitlari_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string evrakNo = dataGridView_siparis_kayitlari.Rows[e.RowIndex].Cells["evrak_no"].Value.ToString();
            string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);

            // Sipariş girişi formunu aç
            siparis_girisi siparisGirisiForm = new siparis_girisi(); // Sipariş girişi formunuzun adını ve nesnesini buraya yazın
            siparisGirisiForm.Show();

            List<evrak_kayit> kayitListesi = JsonConvert.DeserializeObject<List<evrak_kayit>>(jsonVeri);

            // Evrak numarasına göre verileri doldur
            foreach (var kayit in kayitListesi)
            {
                if (kayit.EvrakNo == evrakNo)
                {
                    siparisGirisiForm.textBox_evrakNo.Text = kayit.EvrakNo;
                    siparisGirisiForm.dateTimePicker_siparis.Value = kayit.SiparisTarihi;
                    siparisGirisiForm.toplam_fiyat_label.Text = kayit.ToplamFiyat;

                    // DataGridView'e diğer verileri yükleme örneği
                    foreach (var siparis in kayit.siparis)
                    {
                        int index = siparisGirisiForm.dataGridView_siparis_girisi.Rows.Add(
                            siparis.Sira,
                            siparis.StokAdi,
                            siparis.StokKodu,
                            siparis.BirimFiyat,
                            siparis.Miktar,
                            siparis.AraToplam
                        );
                    }
                }
            }
        }

        private void dataGridView_siparis_kayitlari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
