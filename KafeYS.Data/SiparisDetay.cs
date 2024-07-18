using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KafeYS.Data
{
    public class SiparisDetay
    {
        [Key]
        public int SiparisDetayId { get; set; }

        public int SiparisId { get; set; }

        [Required]
        public int UrunId { get; set; }

        [Required]
        public int UrunAdet { get; set; }

        [Required]
        public decimal UrunFiyat { get; set; }

        [Required]
        public string TutarTl { get { return Tutar().ToString("c2"); } }

        public decimal Tutar()
        {
            return UrunAdet * UrunFiyat;
        }

        public virtual Urun Urun { get; set; }

        public virtual Siparis Siparis { get; set; }
    }
}
