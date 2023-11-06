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

namespace Teknoliva_test
{
    public partial class frm_stok_kart : Form
    {
        public string dosyaYolu = @"D:\Users\sugar\source\repos\Teknoliva_test\Teknoliva_test\Json\JsonFile.json";

        public frm_stok_kart()
        {
            InitializeComponent();
            LoadStockItemsFromJson(); // Form açıldığında stok adlarını yükle
        }

        private void LoadStockItemsFromJson()
        {
           
            if (System.IO.File.Exists(dosyaYolu))
            {
                string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);

                if (!string.IsNullOrEmpty(jsonVeri))
                {
                    var dataListFromJson = JsonConvert.DeserializeObject<List<dynamic>>(jsonVeri);

                    foreach (var d in dataListFromJson)
                    {
                        string stokAdi = d["StokAdi"].ToString();
                        ListViewItem item = new ListViewItem(stokAdi);
                        listView_stok_kart.Items.Add(item);
                    }
                }
                else
                {
                    // JSON dosyası boş, burada gerekli işlemleri yapabilirsiniz
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bilgileri_kaydet_Click(object sender, EventArgs e)
        {
            BilgileriKaydet();
        }

        private void BilgileriKaydet()
        {
            var data = new
            {
                BirimFiyat = (double)numericUpDown_birim_fiyat.Value,
                StokAdi = textbox_stok_adi.Text,
                StokKodu = textbox_stok_kodu.Text
            };

            List<dynamic> dataList = new List<dynamic>();

            if (System.IO.File.Exists(dosyaYolu))
            {
                string mevcutJson = System.IO.File.ReadAllText(dosyaYolu);

                if (!string.IsNullOrEmpty(mevcutJson))
                {
                    dataList = JsonConvert.DeserializeObject<List<dynamic>>(mevcutJson);

                    // Stok kodu kontrolü yap
                    bool isUpdated = false;

                    for (int i = 0; i < dataList.Count; i++)
                    {
                        if (dataList[i]["StokKodu"].ToString() == data.StokKodu)
                        {
                            dataList[i] = data; // Eğer stok kodu eşleşirse, veriyi güncelle
                            isUpdated = true;
                            break;
                        }
                    }

                    if (!isUpdated)
                    {
                        dataList.Add(data); // Eğer stok kodu eşleşmezse, yeni stok olarak ekle
                    }
                }
                else
                {
                    dataList.Add(data); // Dosya yoksa yeni bir veri ekle
                }
            }

            string json = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            System.IO.File.WriteAllText(dosyaYolu, json);

            // ListView temizle
            listView_stok_kart.Items.Clear();

            // JSON dosyasından verileri oku ve ListView'e ekler
            string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);
            var dataListFromJson = JsonConvert.DeserializeObject<List<dynamic>>(jsonVeri);

            foreach (var d in dataListFromJson)
            {
                ListViewItem item = new ListViewItem(d["StokAdi"].ToString());
                item.SubItems.Add(d["StokKodu"].ToString());
                item.SubItems.Add(d["BirimFiyat"].ToString());
                listView_stok_kart.Items.Add(item);
            }

            MessageBox.Show("İşlem Tamamlanmıştır");

            // Label alanlarını temizleme
            numericUpDown_birim_fiyat.Value = 0;
            textbox_stok_adi.Text = string.Empty;
            textbox_stok_kodu.Text = string.Empty;
        }

        private void listView_stok_kart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_stok_kart.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_stok_kart.SelectedItems[0];
                string selectedStockName = selectedItem.Text; // Seçilen stok adı

               
                if (System.IO.File.Exists(dosyaYolu))
                {
                    string jsonVeri = System.IO.File.ReadAllText(dosyaYolu);
                    var dataListFromJson = JsonConvert.DeserializeObject<List<dynamic>>(jsonVeri);

                    foreach (var d in dataListFromJson)
                    {
                        if (d["StokAdi"].ToString() == selectedStockName)
                        {
                            numericUpDown_birim_fiyat.Value = Convert.ToDecimal(d["BirimFiyat"]);
                            textbox_stok_adi.Text = d["StokAdi"].ToString();
                            textbox_stok_kodu.Text = d["StokKodu"].ToString();
                            break; // Veriyi bulduktan sonra döngüyü durdur
                        }
                    }
                 
                }
            }
   
        }

        private void frm_stok_kart_Load(object sender, EventArgs e)
        {

        }

        
    }
}
