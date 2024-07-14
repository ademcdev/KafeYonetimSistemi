using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS.Data
{
    public class Kafe
    {
        [Key]
        public int MasaAdet { get; set; } = 10;

        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public List<Siparis> AktifSiparisler { get; set; } = new List<Siparis>();

        public List<Siparis> GecmisSiparisler { get; set; } = new List<Siparis>();
    }
}
