using KafeYS;
using KafeYS.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
        private KafeDbContext db;
        private Siparis siparis;
        private BindingList<SiparisDetayViewModel> BListSiparisDetay;
        private int masaNo;

        public SiparisForm(KafeDbContext KafeDbContext, Siparis siparis, int MasaNo)
        {
            db = KafeDbContext;
            this.siparis = siparis;
            InitializeComponent();
            dataGridViewOrderDetails.AutoGenerateColumns = false;
            masaNo = MasaNo;
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadToplamTutar();
            GetCategories();
            GetProducts();
            labelMasaNo.Text = masaNo.ToString();
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
            if (comboBoxCategory.SelectedIndex == -1 || comboBoxCategory.SelectedIndex == -1 || numericUpDownAdet.Value == 0)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Urun urun = (Urun)comboBoxProduct.SelectedItem;
                int adet = (int)numericUpDownAdet.Value;

                SiparisDetay siparisdetay = new SiparisDetay
                {
                    UrunId = urun.UrunId,
                    UrunAdet = adet,
                    UrunFiyat = urun.BirimFiyat,
                    SiparisId = siparis.SiparisId
                };

                db.SiparisDetaylari.Add(siparisdetay);
                db.SaveChanges();

                SiparisDetayViewModel viewModel = new SiparisDetayViewModel
                {
                    SiparisDetayId = siparisdetay.SiparisDetayId,
                    SiparisId = siparisdetay.SiparisId,
                    UrunId = siparisdetay.UrunId,
                    UrunAd = urun.UrunAd,
                    UrunAdet = siparisdetay.UrunAdet,
                    UrunFiyat = siparisdetay.UrunFiyat
                };

                BListSiparisDetay.Add(viewModel);
                UpdateTotalPayment();
            }
        }

        private void GuncelletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderDetails.SelectedRows.Count > 0)
            {
                DeleteProduct();
            }
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
            var orderDetails = db.SiparisDetaylari
                             .Include(sd => sd.Urun)
                             .Where(sd => sd.SiparisId == siparis.SiparisId)
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

            BListSiparisDetay = new BindingList<SiparisDetayViewModel>(orderDetails);
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
            if (siparis != null)
            {
                labelOdemeTutari.Text = siparis.ToplamTutar.ToString("c2");
            }
            else
            {
                labelOdemeTutari.Text = "0.00";
            }
        }

        private void CloseOrder(SiparisDurum durum)
        {
            if (siparis == null)
            {
                MessageBox.Show("Sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingSiparis = db.Siparisler
                .Include(s => s.SiparisDetaylari)
                .FirstOrDefault(s => s.SiparisId == siparis.SiparisId);

            if (existingSiparis != null)
            {
                if (durum == SiparisDurum.Odendi)
                {
                    existingSiparis.OdenenTutar = existingSiparis.ToplamTutar;
                }

                existingSiparis.SKapanisZamani = DateTime.Now;
                existingSiparis.Durum = durum;

                db.Entry(existingSiparis).State = EntityState.Modified;
                db.SaveChanges();

                BListSiparisDetay.Clear();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Seçili detay siparişten kaldırılacaktır. Onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridViewOrderDetails.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridViewOrderDetails.SelectedRows[0];
                    SiparisDetayViewModel viewModel = (SiparisDetayViewModel)row.DataBoundItem;

                    using (var db = new KafeDbContext())
                    {
                        SiparisDetay siparisDetay = db.SiparisDetaylari.Find(viewModel.SiparisDetayId);

                        if (siparisDetay != null)
                        {
                            db.SiparisDetaylari.Remove(siparisDetay);
                            db.SaveChanges();

                            BListSiparisDetay.Remove(viewModel);
                            LoadToplamTutar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen önce silinecek bir satır seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToplamTutar()
        {
            decimal toplamTutar = 0;
            var siparisDetaylari = db.SiparisDetaylari.Where(sd => sd.SiparisId == siparis.SiparisId).ToList();

            foreach (var urun in siparisDetaylari)
            {
                toplamTutar += urun.UrunFiyat * urun.UrunAdet;
            }

            labelOdemeTutari.Text = toplamTutar.ToString("c2");
        }
    }
}