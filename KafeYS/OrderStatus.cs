using KafeYS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS
{
    internal class OrderStatus
    {
        public List<Siparis> GetActiveOrders()
        {
            using (var context = new KafeDbContext())
            {
                return context.Siparisler
                    .Where(s => s.Durum == SiparisDurum.Aktif)
                    .ToList();
            }
        }

        public List<Siparis> GetPastOrders()
        {
            using (var context = new KafeDbContext())
            {
                return context.Siparisler
                    .Where(s => s.Durum == SiparisDurum.Odendi || s.Durum == SiparisDurum.Iptal)
                    .ToList();
            }
        }
    }
}