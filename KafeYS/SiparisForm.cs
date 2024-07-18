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
        KafeDbContext db;
        Siparis siparis;
        BindingList<SiparisDetay> BListSiparisDetay;
        private int masaNo;

        public SiparisForm(KafeDbContext kafeYS, Siparis siparis, int MasaNo)
        {
            db = kafeYS;
            this.siparis = siparis;
            InitializeComponent();
            dataGridViewOrderDetails.AutoGenerateColumns = false;
            LoadData();
            masaNo = MasaNo;
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProducts();
            labelMasaNo.Text = masaNo.ToString();
            labelOdemeTutari.Text = "0";
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
                BListSiparisDetay.Add(siparisdetay);
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
            db.Entry(siparis).Collection(s => s.SiparisDetaylari).Load();
            BListSiparisDetay = new BindingList<SiparisDetay>(siparis.SiparisDetaylari.ToList());
            dataGridViewOrderDetails.DataSource = BListSiparisDetay;

            //using (var context = new KafeYS())
            //{
            //    var siparisdetay = db.SiparisDetaylari.Where(sd => sd.SiparisDetayId == siparis.SiparisDetayId).ToList();
            //    BListSiparisDetay = new BindingList<SiparisDetay>(siparisdetay);
            //    dataGridViewOrderDetails.DataSource = BListSiparisDetay;

            //    //siparis = context.Siparisler.Include("SiparisDetaylari").SingleOrDefault(s => s.SiparisId == siparis.SiparisId);

            //    //if (siparis != null)
            //    //{
            //    //    BListSiparisDetay = new BindingList<SiparisDetay>(siparis.SiparisDetaylari.ToList());
            //    //    dataGridViewOrderDetails.DataSource = BListSiparisDetay;
            //    //}
            //}

            //if (!db.Siparisler.Local.Any(s => s.SiparisId == siparis.SiparisId))
            //{
            //    db.Siparisler.Attach(siparis);
            //}

            //db.Entry(siparis).Collection(s => s.SiparisDetaylari).Query().Include(sd => sd.Urun).Load();

            //var siparisDetayVM = siparis.SiparisDetaylari.Select(sd => new SiparisDetay
            //{
            //    SiparisDetayId = sd.SiparisDetayId,
            //    UrunAd = sd.Urun.UrunAd,
            //    UrunFiyat = sd.UrunFiyat,
            //    UrunAdet = sd.UrunAdet,
            //}).ToList();

            //BListSiparisDetay = new BindingList<SiparisDetay>(siparisDetayVM);
            //dataGridViewOrderDetails.DataSource = BListSiparisDetay;

            //db.Entry(siparis).Collection(s => s.SiparisDetaylari).Load();
            //BListSiparisDetay = new BindingList<SiparisDetay>(siparis.SiparisDetaylari.ToList());
            //dataGridViewOrderDetails.DataSource = BListSiparisDetay;

            //var siparisdetay = siparis.SiparisDetaylari.ToList();
            //BListSiparisDetay = new BindingList<SiparisDetay>(siparisdetay);
            //dataGridViewOrderDetails.DataSource = BListSiparisDetay;



            //db.Entry(siparis).Collection(s => s.SiparisDetaylari).Load();
            //BListSiparisDetay = new BindingList<SiparisDetay>(siparis.SiparisDetaylari.ToList());
            //dataGridViewOrderDetails.DataSource = BListSiparisDetay;
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
            decimal totalPayment = 0;

            if (siparis != null && siparis.SiparisDetaylari != null)
            {
                totalPayment = siparis.SiparisDetaylari.Sum(sd => sd.UrunFiyat * sd.UrunAdet);
                labelOdemeTutari.Text = totalPayment.ToString("C");
            }
            else
            {
                labelOdemeTutari.Text = totalPayment.ToString("C");
            }

            //if (siparis != null)
            //{
            //    decimal ToplamTutar = siparis.SiparisDetaylari.Sum(sd => sd.UrunFiyat * sd.UrunAdet);

            //    labelOdemeTutari.Text = totalPayment.ToString("C");
            //}

            //Console.WriteLine(siparisDetay.TutarTl);
            //Console.WriteLine(siparis.ToplamTutarTL);
            //labelOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void CloseOrder(SiparisDurum durum)
        {
            if (durum == SiparisDurum.Odendi)
                siparis.OdenenTutar = siparis.ToplamTutar;

            siparis.SKapanisZamani = DateTime.Now;
            siparis.Durum = durum;
            db.SaveChanges();
            BListSiparisDetay.Clear();
            DialogResult = DialogResult.OK;
        }

        private void DeleteProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Seçili detay siparişten kaldırılacaktır. Onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewOrderDetails.SelectedRows[0];
                SiparisDetay siparisDetay = (SiparisDetay)row.DataBoundItem;
                BListSiparisDetay.Remove(siparisDetay);
                db.SiparisDetaylari.Remove(siparisDetay);
                db.SaveChanges();
                UpdateTotalPayment();
            }
        }
    }
}