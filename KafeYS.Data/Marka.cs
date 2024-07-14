using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS.Data
{
    public class Marka
    {
        [Key]
        public int MarkaId { get; set; }

        [Required]
        public string MarkaAd { get; set; }

        public string BrandDesc { get; set; }

        public string LogoUrl { get; set; }

        [Required]
        public string ContactEmail { get; set; }

        [Required]
        public string ContactPhone { get; set; }

        public string WebsiteUrl { get; set; }

        public virtual ICollection<Kategori> Kategoriler { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
