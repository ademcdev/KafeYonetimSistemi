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
        public int SiparisId { get; set; }

        [Required]
        public string UrunId { get; set; }

        public virtual Urun Urun { get; set; }

        [Required]
        public int UrunAdet { get; set; }

        [Required]
        public decimal UrunFiyat { get; set; }

        public decimal Tutar()
        {
            return UrunAdet * UrunFiyat;
        }

        [Required]
        public string TutarTl { get { return Tutar().ToString("c2"); } }
    }
}
