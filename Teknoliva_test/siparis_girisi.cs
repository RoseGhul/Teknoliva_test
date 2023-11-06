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
    public partial class siparis_girisi : Form
    {
        public string dosyaYolu = @"D:\Users\sugar\source\repos\Teknoliva_test\Teknoliva_test\Json\JsonFile.json";
        double sonuctoplam = 0;
        double eskievraktoplamfiyat = 0;
       
        public siparis_girisi()
        {
            InitializeComponent();
            if (dataGridView_siparis_girisi.Rows.Count > 0)
            {
                dataGridView_siparis_girisi.Rows.RemoveAt(0); // İlk satırı sil
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void siparis_girisi_Load(object sender, EventArgs e)
        {
           
        }

        private void yeni_satir_ekle_Click(object sender, EventArgs e)
        {
            YeniSatirEkle();
        }

        private void YeniSatirEkle()
        {
           
            // Yeni bir satır oluştur
            DataGridViewRow row = new DataGridViewRow();

            // Satır numarasını otomatik olarak artır
            int satirNo = dataGridView_siparis_girisi.Rows.Count + 1;
            // Hücreleri oluştur
            DataGridViewCell cellSira = new DataGridViewTextBoxCell();
            cellSira.Value = satirNo;

            // Diğer hücreler için varsayılan değerler
            DataGridViewCell cellStokAdi = new DataGridViewTextBoxCell();
            DataGridViewCell cellStokKodu = new DataGridViewTextBoxCell();
            DataGridViewCell cellBirimFiyat = new DataGridViewTextBoxCell();
            DataGridViewCell cellMiktar = new DataGridViewTextBoxCell();
            DataGridViewCell cellAraToplam = new DataGridViewTextBoxCell();

            // Hücreleri satıra ekle
            row.Cells.Add(cellSira);
            row.Cells.Add(cellStokAdi);
            row.Cells.Add(cellStokKodu);
            row.Cells.Add(cellBirimFiyat);
            row.Cells.Add(cellMiktar);
            row.Cells.Add(cellAraToplam);

            // DataGridView'a yeni satırı ekle
            dataGridView_siparis_girisi.Rows.Add(row);
        }

        private void DataGridView_siparis_girisi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Stok kodu hücresi
            {
                dataGridView_siparis_girisi.BeginEdit(true);
            }
        }

        private void DataGridView_siparis_girisi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            stok_getir(sender, e);
            toplam_miktar(sender, e);
        }

        private void toplam_miktar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // Miktar hücresi
            {
                double toplamAraToplam = 0;
                int rowIndex = e.RowIndex;
                var birimFiyatCell = dataGridView_siparis_girisi.Rows[rowIndex].Cells[3]; // Birim fiyat hücresi
                var miktarCell = dataGridView_siparis_girisi.Rows[rowIndex].Cells[4]; // Miktar hücresi
                var araToplamCell = dataGridView_siparis_girisi.Rows[rowIndex].Cells[5]; // AraToplam hücresi

                // Miktar hücresinin boş olup olmadığını kontrol et
                if (miktarCell.Value != null && !string.IsNullOrWhiteSpace(miktarCell.Value.ToString()))
                {
                    // Birim fiyat ve miktar değerlerini al
                    double birimFiyat = Convert.ToDouble(birimFiyatCell.Value);
                    int miktar = Convert.ToInt32(miktarCell.Value);

                    // AraToplam hücresine (Birim Fiyat * Miktar) sonucunu yaz
                    araToplamCell.Value = (birimFiyat * miktar).ToString();
                    toplamAraToplam = birimFiyat * miktar;
                }
                toplam_fiyat_text(toplamAraToplam);
            }
        }
        private void toplam_fiyat_text(double toplamAraToplam)
        {
            if(toplam_fiyat_label.Text!=null)
            {
                eskievraktoplamfiyat = Convert.ToDouble(toplam_fiyat_label.Text);
                sonuctoplam = eskievraktoplamfiyat + toplamAraToplam;
                toplam_fiyat_label.Text = sonuctoplam.ToString();
            }

            else
            {
            double AraToplam = toplamAraToplam + eskievraktoplamfiyat;
            sonuctoplam = sonuctoplam + AraToplam;
            toplam_fiyat_label.Text = sonuctoplam.ToString();
            }
           

            eskievraktoplamfiyat = 0;
        }


        private void stok_getir(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // Stok kodu hücresi
            {
                var cell = dataGridView_siparis_girisi.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string enteredCode = cell.Value.ToString();
                string lastTwoDigits = enteredCode.Substring(enteredCode.Length - 2);

                if (System.IO.File.Exists(dosyaYolu))
                {
                    string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);
                    var dataList = JsonConvert.DeserializeObject<List<dynamic>>(jsonVeri);

                    foreach (var item in dataList)
                    {
                        if (item["StokKodu"].ToString().EndsWith(lastTwoDigits))
                        {
                            dataGridView_siparis_girisi.Rows[e.RowIndex].Cells[1].Value = item["StokAdi"].ToString();
                            dataGridView_siparis_girisi.Rows[e.RowIndex].Cells[2].Value = item["StokKodu"].ToString();
                            dataGridView_siparis_girisi.Rows[e.RowIndex].Cells[3].Value = item["BirimFiyat"].ToString();
                            break;
                        }
                    }
                }
            }
        }

        private void toplam_fiyat_label_Click(object sender, EventArgs e)
        {

        }

        private void siparis_bilgilerini_kaydet_Click(object sender, EventArgs e)
        {
            string evrakNo = textBox_evrakNo.Text;

            // Verileri oku
            string dosyaYolu = @"D:\Users\sugar\source\repos\Teknoliva_test\Teknoliva_test\Json\siparis_bilgileri.json";
            string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);
            List<evrak_kayit> evrakKayitListesi = JsonConvert.DeserializeObject<List<evrak_kayit>>(jsonVeri);

            bool evrakNoVarMi = false;

            // Evrak numarası mevcut değilse veya liste boşsa veri ekle
            if (evrakKayitListesi== null)
            { // Evrak numarası yoksa veri kaydet
                veri_kaydet();
            }
            else
            {
                // Evrak numarasının mevcut olup olmadığını kontrol et
                foreach (evrak_kayit kayit in evrakKayitListesi)
                {
                    if (kayit.EvrakNo == evrakNo)
                    {
                        evrakNoVarMi = true;
                        break;
                    }
                }

                if (evrakNoVarMi)
                {
                    // Evrak numarası mevcutsa veri güncelle
                    veri_guncelle();
                }
                else
                {
                    // Evrak numarası yoksa veri kaydet
                    veri_kaydet();
                }
            }
        }

        private void veri_guncelle()
        {
            string dosyaYolu = @"D:\Users\sugar\source\repos\Teknoliva_test\Teknoliva_test\Json\siparis_bilgileri.json";

            // Önce dosyadan tüm kayıtları oku
            string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);
            List<evrak_kayit> evrakKayitListesi = JsonConvert.DeserializeObject<List<evrak_kayit>>(jsonVeri);

            // Eski evrak numarasına ait kaydı bul
            evrak_kayit eskiKayit = evrakKayitListesi.FirstOrDefault(kayit => kayit.EvrakNo == textBox_evrakNo.Text);

            if (eskiKayit != null)
            {
                // Eğer evrak numarasına ait kayıt varsa, yeni güncel verileri ekleyebilirsin
                eskiKayit.SiparisTarihi = dateTimePicker_siparis.Value;
                eskiKayit.ToplamFiyat = toplam_fiyat_label.Text;

                // Yeni sipariş verileri oluştur
                List<Teknoliva_test.models.siparis> yeniSiparisListesi = new List<Teknoliva_test.models.siparis>();
                foreach (DataGridViewRow row in dataGridView_siparis_girisi.Rows)
                {
                    Teknoliva_test.models.siparis siparis = new Teknoliva_test.models.siparis
                    {
                        Sira = row.Cells[0].Value?.ToString(),
                        StokAdi = row.Cells[1].Value?.ToString(),
                        StokKodu = row.Cells[2].Value?.ToString(),
                        BirimFiyat = row.Cells[3].Value?.ToString(),
                        Miktar = row.Cells[4].Value?.ToString(),
                        AraToplam = row.Cells[5].Value?.ToString(),
                    };
                    yeniSiparisListesi.Add(siparis);
                }

                // Güncellenmiş sipariş verilerini eski kayıtta sakla
                eskiKayit.siparis = yeniSiparisListesi;

                // Eski verileri yeni güncellenmiş verilerle değiştir
                evrakKayitListesi = evrakKayitListesi.Where(kayit => kayit.EvrakNo != textBox_evrakNo.Text).ToList();
                evrakKayitListesi.Add(eskiKayit);

                // Dosyaya güncellenmiş verileri kaydet
                string json = JsonConvert.SerializeObject(evrakKayitListesi);
                System.IO.File.WriteAllText(dosyaYolu, json);

                // SiparisKayitlari formunu bul
                siparis_kayitlari form = (siparis_kayitlari)Application.OpenForms["siparis_kayitlari"];
                DataGridView dataGrid = form.Controls.Find("dataGridView_siparis_kayitlari", true).FirstOrDefault() as DataGridView;

                // Eğer form bulunursa DataGridView'e güncellenmiş verileri ekle
                if (dataGrid != null)
                {
                    dataGrid.Rows.Clear(); // Mevcut verileri temizle
                    foreach (evrak_kayit kayit in evrakKayitListesi)
                    {
                        dataGrid.Rows.Add(kayit.EvrakNo, kayit.SiparisTarihi, kayit.ToplamFiyat);
                    }
                }
            }

            // İşlem tamamlandıktan sonra bu formu kapatabilirsiniz
            this.Close();
        }



        private void veri_kaydet()
        {
           
            List<evrak_kayit> eskiEvrakKayitListesi = new List<evrak_kayit>();

            // Eğer dosya mevcutsa, eski verileri al
            if (System.IO.File.Exists(dosyaYolu))
            {
                string eskiJson = System.IO.File.ReadAllText(dosyaYolu);
                eskiEvrakKayitListesi = JsonConvert.DeserializeObject<List<evrak_kayit>>(eskiJson);
            }

            // Yeni verileri al
            string evrakNo = textBox_evrakNo.Text;
            DateTime siparisTarihi = dateTimePicker_siparis.Value;
            string toplamFiyat = toplam_fiyat_label.Text;

            List<Teknoliva_test.models.siparis> yeniSiparisListesi = new List<Teknoliva_test.models.siparis>();
            foreach (DataGridViewRow row in dataGridView_siparis_girisi.Rows)
            {
                Teknoliva_test.models.siparis siparis = new Teknoliva_test.models.siparis
                {
                    Sira = row.Cells[0].Value?.ToString(),
                    StokAdi = row.Cells[1].Value?.ToString(),
                    StokKodu = row.Cells[2].Value?.ToString(),
                    BirimFiyat = row.Cells[3].Value?.ToString(),
                    Miktar = row.Cells[4].Value?.ToString(),
                    AraToplam = row.Cells[5].Value?.ToString(),
                };
                yeniSiparisListesi.Add(siparis);
            }

            // Elde edilen Evrak No, Tarih ve Toplam Fiyat'ı kullanarak yeni evrak kaydı oluştur
            evrak_kayit yeniEvrakKayit = new evrak_kayit
            {
                EvrakNo = evrakNo,
                SiparisTarihi = siparisTarihi,
                ToplamFiyat = toplamFiyat,
                siparis = yeniSiparisListesi
            };

            // Eğer eski veri yoksa veya null ise, yeni verileri doğrudan ekle
            if (eskiEvrakKayitListesi == null)
            {
                eskiEvrakKayitListesi = new List<evrak_kayit>();
            }

            eskiEvrakKayitListesi.Add(yeniEvrakKayit);

            // Yeni veya güncellenmiş verileri JSON formatına dönüştür ve dosyaya yaz
            string json = JsonConvert.SerializeObject(eskiEvrakKayitListesi);
            System.IO.File.WriteAllText(dosyaYolu, json);

            // SiparisKayitlari formunu oluştur
            // Yeni veriyi siparis kayitlari formuna ekleyerek göster
            siparis_kayitlari form = (siparis_kayitlari)Application.OpenForms["siparis_kayitlari"];
            DataGridView dataGrid = form.Controls.Find("dataGridView_siparis_kayitlari", true).FirstOrDefault() as DataGridView;

            dataGrid.Rows.Add(yeniEvrakKayit.EvrakNo, yeniEvrakKayit.SiparisTarihi, yeniEvrakKayit.ToplamFiyat);
            dataGrid.ColumnHeadersVisible = true;
            // Formu kapat
            this.Close();

        }

        public void textBox_evrakNo_TextChanged(object sender, EventArgs e)
        {

        }

        public void dateTimePicker_siparis_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

