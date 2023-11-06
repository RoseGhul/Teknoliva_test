using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknoliva_test.models
{
    internal class siparis
    {
        public string Sira { get; set; }
        public string StokAdi { get; set; }
        public string StokKodu { get; set; }
        public string BirimFiyat { get; set; }
        public string Miktar { get; set; }
        public string AraToplam { get; set; }

    }

    internal class evrak_kayit
    {
        public List<siparis> siparis { get; set; }
        public string EvrakNo { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string ToplamFiyat { get; set; }
    }
}
