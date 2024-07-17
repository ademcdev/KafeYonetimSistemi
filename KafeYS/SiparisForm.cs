using KafeYS;
using KafeYS.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KafeYS
{
    public partial class SiparisForm : Form
    {
        KafeYS db;
        Siparis siparis;
        BindingList<SiparisDetay> BListSiparisDetay;

        public SiparisForm(KafeYS kafeYS, Siparis siparis)
        {
            db = kafeYS;
            this.siparis = siparis;
            InitializeComponent();
            LoadData();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProducts();
        }

        private void comboBoxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            labelProduct.Enabled = true;
            comboBoxProduct.Enabled = true;

            if (comboBoxCategory.SelectedIndex > 0)
            {
                var selectedCategory = (Kategori)comboBoxCategory.SelectedItem;
                var filteredProducts = db.Urunler.Where(u => u.KategoriId == selectedCategory.KategoriId).ToList();

                comboBoxProduct.Items.Clear();

                foreach (var urun in filteredProducts)
                {
                    comboBoxProduct.Items.Add(urun);
                }

                comboBoxProduct.DisplayMember = "UrunAd";
                comboBoxProduct.ValueMember = "UrunId";
            }
            else if (comboBoxCategory.SelectedIndex == 0)
            {
                GetProducts();
            }
        }

        private void buttonOdemeAl_Click(object sender, EventArgs e)
        {
            CloseOrder(SiparisDurum.Odendi);
        }

        private void EkletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kategori = (Kategori)comboBoxCategory.SelectedItem;
            Urun urun = (Urun)comboBoxProduct.SelectedItem;
            int adet = (int)numericUpDownAdet.Value;

            BListSiparisDetay.Add(new SiparisDetay()
            {
                UrunId = urun.UrunId,
                UrunFiyat = urun.BirimFiyat,
                UrunAdet = adet
            });

            UpdateTotalPayment();
        }

        private void GuncelletoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SiparisİptaltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOrder(SiparisDurum.Iptal);
        }

        private void GeriDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void LoadData()
        {
            var siparisdetay = db.SiparisDetaylari.ToList();
            BListSiparisDetay = new BindingList<SiparisDetay>(siparisdetay);
            dataGridViewOrderDetails.DataSource = BListSiparisDetay;
        }

        private void GetCategories()
        {
            var categories = db.Kategoriler.ToList();

            comboBoxCategory.Items.Clear();

            foreach (var category in categories)
            {
                comboBoxCategory.Items.Add(category);
                Console.WriteLine(category);
            }

            comboBoxCategory.DisplayMember = "KategoriAd";
            comboBoxCategory.ValueMember = "KategoriId";
        }

        private void GetProducts()
        {
            var urunler = db.Urunler.ToList();

            comboBoxProduct.Items.Clear();

            foreach (var urun in urunler)
            {
                comboBoxProduct.Items.Add(urun);
            }

            comboBoxProduct.DisplayMember = "UrunAd";
            comboBoxProduct.ValueMember = "UrunId";
        }

        private void UpdateTotalPayment()
        {
            labelOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void CloseOrder(SiparisDurum durum)
        {
            if (durum == SiparisDurum.Odendi)
                siparis.OdenenTutar = siparis.ToplamTutar();

            siparis.SKapanisZamani = DateTime.Now;
            siparis.Durum = durum;
            DialogResult = DialogResult.OK;
        }
    }
}