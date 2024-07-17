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
    public partial class EmployeePage : Form
    {
        KafeYS db;
        BindingList<Personel> BListPersoneller;

        public EmployeePage(KafeYS kafeYS)
        {
            db = kafeYS;
            InitializeComponent();
            dataGridViewPersonel.AutoGenerateColumns = false;
            LoadData();
            TelNoMaskedTextBox();
            PasswordTextBox();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonel();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePersonel();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePersonel();
        }

        private void GeriDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewPersonel.SelectedRows[0].Index;
                int PersonelId = (int)dataGridViewPersonel.Rows[selectedRowIndex].Cells["PersonelId"].Value;

                var SecilenPersonel = BListPersoneller.FirstOrDefault(p => p.PersonelId == PersonelId);

                if (SecilenPersonel != null)
                {
                    textBoxPersonelAd.Text = SecilenPersonel.PersonelAd;
                    textBoxPersonelSoyad.Text = SecilenPersonel.PersonelSoyad;
                    textBoxPersonelEmail.Text = SecilenPersonel.PersonelEmail;
                    maskedTextBoxTelNo.Text = SecilenPersonel.PersonelTelNo;
                    textBoxPassword.Text = SecilenPersonel.PersonelSifre;
                }
            }
        }

        private void LoadData()
        {
            var personeller = db.Personeller.ToList();
            BListPersoneller = new BindingList<Personel>(personeller);
            dataGridViewPersonel.DataSource = BListPersoneller;

            comboBoxAccessLevel.DataSource = Enum.GetValues(typeof(AccessLevel));
        }

        private void AddPersonel()
        {
            if (IsTextBoxEmpty(this))
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Personel yeniPersonel = new Personel
                {
                    PersonelAd = textBoxPersonelAd.Text.Trim(),
                    PersonelSoyad = textBoxPersonelSoyad.Text.Trim(),
                    PersonelEmail = textBoxPersonelEmail.Text.Trim(),
                    PersonelTelNo = maskedTextBoxTelNo.Text.Trim(),
                    PersonelİseGirisTarih = DateTime.Now,
                    PersonelSifre = textBoxPassword.Text,
                    AccessLevel = (AccessLevel)comboBoxAccessLevel.SelectedItem
                };

                db.Personeller.Add(yeniPersonel);
                db.SaveChanges();
                BListPersoneller.Add(yeniPersonel);
                MessageBox.Show("Personel başarıyla eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm(this);
            }
        }

        private void UpdatePersonel()
        {
            if (dataGridViewPersonel.SelectedRows.Count > 0)
            {
                if (dataGridViewPersonel.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewPersonel.SelectedRows[0].Index;
                    int PersonelId = (int)dataGridViewPersonel.Rows[selectedRowIndex].Cells["PersonelId"].Value;

                    var SecilenPersonel = BListPersoneller.FirstOrDefault(p => p.PersonelId == PersonelId);

                    if (SecilenPersonel != null)
                    {
                        SecilenPersonel.PersonelAd = textBoxPersonelAd.Text;
                        SecilenPersonel.PersonelSoyad = textBoxPersonelSoyad.Text;
                        SecilenPersonel.PersonelEmail = textBoxPersonelEmail.Text;
                        SecilenPersonel.PersonelTelNo = maskedTextBoxTelNo.Text;
                        SecilenPersonel.PersonelSifre = textBoxPassword.Text;

                        dataGridViewPersonel.Refresh();
                        db.SaveChanges();
                        ResetForm(this);
                        MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce Personel seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemovePersonel()
        {
            if (dataGridViewPersonel.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewPersonel.SelectedRows[0].Index;
                int PersonelId = (int)dataGridViewPersonel.Rows[selectedRowIndex].Cells["PersonelId"].Value;

                var SecilenPersonel = BListPersoneller.FirstOrDefault(p => p.PersonelId == PersonelId);

                if (SecilenPersonel != null)
                {
                    DialogResult result = MessageBox.Show("Personeli kaldırmak istediğinize emin misiniz?", "Personel kaldır", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        BListPersoneller.Remove(SecilenPersonel);
                        db.Personeller.Remove(SecilenPersonel);
                        db.SaveChanges();
                        dataGridViewPersonel.Refresh();
                        ResetForm(this);
                        MessageBox.Show("Personel başarıyla kaldırıldı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce Personel seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsTextBoxEmpty(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox textBox)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                        return false;
                }
                else if (c.HasChildren)
                {
                    if (!IsTextBoxEmpty(c))
                        return false;
                }
            }
            return true;
        }

        private void TelNoMaskedTextBox()
        {
            MaskedTextBox maskedTextBoxTelNo = new MaskedTextBox
            {
                Mask = "(99) 000 000 0000",
                Name = "maskedTextBoxTelNo",
                Location = new Point(10, 10)
            };
            this.Controls.Add(maskedTextBoxTelNo);
        }

        private void PasswordTextBox()
        {
            TextBox textBoxPassword = new TextBox
            {
                Name = "textBoxPassword",
                Location = new Point(10, 40),
                PasswordChar = '*'
            };
            this.Controls.Add(textBoxPassword);
        }

        private void ResetForm(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (c.HasChildren)
                {
                    ResetForm(c);
                }
            }
        }
    }
}
