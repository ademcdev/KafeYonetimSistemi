using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS
{
    public class SiparisDetayViewModel
    {
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int UrunAdet { get; set; }
        public decimal UrunFiyat { get; set; }
        public decimal Tutar { get { return UrunAdet * UrunFiyat; } }
    }
}
