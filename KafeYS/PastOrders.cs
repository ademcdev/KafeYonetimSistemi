using KafeYS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace KafeYS
{
    public partial class PastOrders : Form
    {
        private readonly KafeDbContext db;
        private readonly OrderStatus order;

        public PastOrders(KafeDbContext kafeDbContext)
        {
            InitializeComponent();
            db = kafeDbContext;
            order = new OrderStatus();
            dataGridViewSiparis.AutoGenerateColumns = false;
            dataGridViewSiparisDetay.AutoGenerateColumns = false;
            LoadPastOrders();
            dataGridViewSiparis.SelectionChanged += dataGridViewSiparis_SelectionChanged;
        }

        private void GeriDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewSiparis_SelectionChanged(object sender, EventArgs e)
        {
            LoadPastOrderDetails();
        }

        private void LoadPastOrders()
        {
            var pastOrders = order.GetPastOrders();
            dataGridViewSiparis.DataSource = pastOrders;
        }

        private void LoadPastOrderDetails()
        {
            if (dataGridViewSiparis.SelectedRows.Count == 0)
            {
                dataGridViewSiparisDetay.DataSource = null;
                return;
            }

            DataGridViewRow row = dataGridViewSiparis.SelectedRows[0];
            Siparis selectedOrder = (Siparis)row.DataBoundItem;

            var siparisDetaylari = db.SiparisDetaylari
                             .Include(sd => sd.Urun)
                             .Where(sd => sd.SiparisId == selectedOrder.SiparisId)
                             .Select(sd => new SiparisDetayViewModel
                             {
                                 SiparisDetayId = sd.SiparisDetayId,
                                 SiparisId = sd.SiparisId,
                                 UrunId = sd.UrunId,
                                 UrunAd = sd.Urun.UrunAd,
                                 UrunAdet = sd.UrunAdet,
                                 UrunFiyat = sd.UrunFiyat,
                             })
                             .ToList();

            dataGridViewSiparisDetay.DataSource = siparisDetaylari;
        }
    }
}
