using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS.Data
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [Required]
        public string UrunAd { get; set; }
        [Required]
        public int BirimFiyat { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1:n2})", UrunAd, BirimFiyat);
        }

        //public int MarkaId { get; set; }
        public int KategoriId { get; set; }

        //public virtual Marka Marka { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
