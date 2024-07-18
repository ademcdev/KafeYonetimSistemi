using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS.Data
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        [Required]
        public string KategoriAd { get; set; }

        public string CategoryDesc { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
