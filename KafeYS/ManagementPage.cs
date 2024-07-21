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

namespace KafeYS
{
    public partial class ManagementPage : Form
    {
        private KafeDbContext db;

        public ManagementPage()
        {
            InitializeComponent();
            db = new KafeDbContext();
            LoadReportData();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(db);
            productPage.ShowDialog();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(db);
            employeePage.ShowDialog();
        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastOrders pastOrders = new PastOrders(db);
            pastOrders.ShowDialog();
        }

        private void raporHazırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Programı kapatmak istiyor musunuz?";
            string caption = "Emin misiniz?";
            MessageBoxButtons buttonExit = MessageBoxButtons.YesNo;
            MessageBoxIcon iconExit = MessageBoxIcon.Warning;

            DialogResult result = MessageBox.Show(msg, caption, buttonExit, iconExit, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoadReportData()
        {
            LoadTotal();
        }

        private void LoadTotal()
        {
            var totalProducts = db.Urunler.Count();
            var totalPersonels = db.Personeller.Count();
            var totalOrders = db.Siparisler.Count();
            //var totalIncome = db.Siparisler.Sum(s => s.ToplamTutar) + " TL";

            labelTotalProducts.Text = totalOrders.ToString();
            labelTotalPersonels.Text = totalPersonels.ToString();
            labelTotalOrders.Text = totalPersonels.ToString();
            //labelIncome.Text = totalIncome.ToString();
        }

        private void LoadTopProducts()
        {
            var topProducts = db.SiparisDetaylari
                .GroupBy(sd => sd.UrunId)
                .Select(g => new
                {
                    UrunAd = g.FirstOrDefault().Urun.UrunAd,
                    TotalSales = g.Sum(sd => sd.UrunFiyat * sd.UrunAdet)
                })
                .OrderByDescending(p => p.TotalSales)
                .Take(5)
                .ToList();

            dataGridViewSiparis.DataSource = topProducts;
        }

        private void LoadSalesByCategory()
        {
            var salesByCategory = db.SiparisDetaylari
                .GroupBy(sd => sd.Urun.Kategori.KategoriAd)
                .Select(g => new
                {
                    KategoriAd = g.Key,
                    TotalSales = g.Sum(sd => sd.UrunFiyat * sd.UrunAdet)
                })
                .ToList();

            dataGridViewSiparis.DataSource = salesByCategory;
        }
    }
}
