using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KafeYS.Data;

namespace KafeYS
{
    public partial class ProductPage : Form
    {
        KafeYS db;
        BindingList<Urun> BListUrunler;

        public ProductPage(KafeYS kafeYS)
        {
            db = kafeYS;
            InitializeComponent();
            dataGridViewProduct.AutoGenerateColumns = false;
            LoadData();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void GeriDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewProduct.SelectedRows[0].Index;
                int UrunId = (int)dataGridViewProduct.Rows[selectedRowIndex].Cells["UrunId"].Value;

                var SecilenUrun = BListUrunler.FirstOrDefault(p => p.UrunId == UrunId);

                if (SecilenUrun != null)
                {
                    var selectedCategory = comboBoxCategory.Items.OfType<Kategori>().FirstOrDefault(k => k.KategoriId == SecilenUrun.KategoriId);

                    if (selectedCategory != null)
                    {
                        comboBoxCategory.SelectedItem = selectedCategory;
                    }

                    textBoxProductName.Text = SecilenUrun.UrunAd;
                    numericUpDownPrice.Value = SecilenUrun.BirimFiyat;
                }
            }
        }

        private void comboBoxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterCategory();
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

        private void LoadData()
        {
            var urunler = db.Urunler.ToList();
            BListUrunler = new BindingList<Urun>(urunler);
            dataGridViewProduct.DataSource = BListUrunler;
        }

        private void FilterCategory()
        {
            if (comboBoxCategory.SelectedIndex > 0)
            {
                var selectedCategory = (Kategori)comboBoxCategory.SelectedItem;
                var filteredProducts = db.Urunler.Where(u => u.KategoriId == selectedCategory.KategoriId).ToList();
                BListUrunler.Clear();

                foreach (var product in filteredProducts)
                {
                    BListUrunler.Add(product);
                }
            }
            else if (comboBoxCategory.SelectedIndex == 0)
            {

                LoadData();
            }
        }

        private void AddProduct()
        {
            if (comboBoxCategory.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxProductName.Text) || numericUpDownPrice.Value == 0)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Urun yeniUrun = new Urun
                {
                    UrunAd = textBoxProductName.Text.Trim(),
                    BirimFiyat = (int)numericUpDownPrice.Value,
                    KategoriId = ((Kategori)comboBoxCategory.SelectedItem).KategoriId,
                };

                db.Urunler.Add(yeniUrun);
                db.SaveChanges();
                BListUrunler.Add(yeniUrun);
                MessageBox.Show("Ürün başarıyla eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
        }

        private void UpdateProducts()
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewProduct.SelectedRows[0].Index;
                int UrunId = (int)dataGridViewProduct.Rows[selectedRowIndex].Cells["UrunId"].Value;

                var SecilenUrun = BListUrunler.FirstOrDefault(p => p.UrunId == UrunId);

                if (SecilenUrun != null)
                {
                    var selectedCategory = comboBoxCategory.SelectedItem as Kategori;
                    if (selectedCategory != null)
                    {
                        SecilenUrun.KategoriId = selectedCategory.KategoriId;
                        SecilenUrun.Kategori = selectedCategory;
                    }

                    SecilenUrun.UrunAd = textBoxProductName.Text;
                    SecilenUrun.BirimFiyat = (int)numericUpDownPrice.Value;

                    dataGridViewProduct.Refresh();
                    db.SaveChanges();
                    MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce ürün seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveProduct()
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewProduct.SelectedRows[0].Index;
                int UrunId = (int)dataGridViewProduct.Rows[selectedRowIndex].Cells["UrunId"].Value;

                var SecilenUrun = BListUrunler.FirstOrDefault(p => p.UrunId == UrunId);

                if (SecilenUrun != null)
                {
                    DialogResult result = MessageBox.Show("Ürünü kaldırmak istediğinize emin misiniz?", "Ürün kaldır", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        BListUrunler.Remove(SecilenUrun);
                        db.Urunler.Remove(SecilenUrun);
                        db.SaveChanges();
                        dataGridViewProduct.Refresh();

                        MessageBox.Show("Ürün başarıyla kaldırıldı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce ürün seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            //comboBoxCategory.SelectedIndex = -1;
            textBoxProductName.Clear();
            numericUpDownPrice.Value = 0;
            textBoxProductName.Focus();
        }
    }
}
