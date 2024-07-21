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

        public SiparisDurum Durum { get; set; }

        [Required]
        public decimal OdenenTutar { get; set; }

        [Required]
        public DateTime? SAcilisZamani { get; set; }

        public DateTime? SKapanisZamani { get; set; }

        //public List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();

        public int PersonelId { get; set; }

        public virtual Personel Personeller { get; set; }

        public virtual ICollection<SiparisDetay> SiparisDetaylari { get; set; }

        public Siparis()
        {
            SiparisDetaylari = new HashSet<SiparisDetay>();
        }

        [Required]
        public decimal ToplamTutar
        {
            get
            {
                return SiparisDetaylari.Sum(sd => sd.Tutar());
            }
        }
    }
}
