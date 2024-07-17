using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS.Data
{
    public class Kafe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MasaNo { get; set; } = 1;

        [Required]
        public int MasaAdet { get; set; } = 10;

        public List<Siparis> AktifSiparisler { get; set; } = new List<Siparis>();

        public List<Siparis> GecmisSiparisler { get; set; } = new List<Siparis>();
    }
}
