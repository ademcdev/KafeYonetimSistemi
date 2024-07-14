using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace KafeYS.Data
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        [Required]
        public string PersonelAd { get; set; }

        [Required]
        public string PersonelSoyad { get; set; }

        [Required]
        public string PersonelEmail { get; set; }

        [Required]
        public string PersonelTelNo { get; set; }

        [Required]
        public DateTime PersonelİseGirisTarih { get; set; }

        [Required]
        public bool IsActive { get; set; }

        private string _PersonelSifre;

        [Required]
        public string PersonelSifre
        {
            get => _PersonelSifre;
            set => _PersonelSifre = HashPassword(value);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        public virtual ICollection<Siparis> Siparisler { get; set; }
    }
}
