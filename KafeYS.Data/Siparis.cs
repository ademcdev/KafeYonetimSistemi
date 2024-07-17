using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS.Data
{
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }

        [Required]
        public int MasaNo { get; set; }

        public virtual Kafe Kafe { get; set; }

        public SiparisDurum Durum { get; set; }

        [Required]
        public decimal OdenenTutar { get; set; }

        [Required]
        public DateTime? SAcilisZamani { get; set; }

        [Required]
        public DateTime? SKapanisZamani { get; set; }

        public List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();

        [Required]
        public string ToplamTutarTL => ToplamTutar().ToString();

        public decimal ToplamTutar()
        {
            return SiparisDetaylari.Sum(x => x.Tutar());
        }

        public int PersonelId { get; set; }

        public virtual Personel Personeller { get; set; }
    }
}
