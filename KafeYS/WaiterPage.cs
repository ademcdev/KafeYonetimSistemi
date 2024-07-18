using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KafeYS.Data;
using KafeYS.Properties;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace KafeYS
{
    public partial class WaiterPage : Form
    {
        private KafeDbContext db;
        private Kafe kafe;
        private OrderStatus order;
        public event EventHandler<MasaTasindi> MasaTasindi;
        private int personelId;

        public WaiterPage(int personelId)
        {
            InitializeComponent();
            db = new KafeDbContext();
            order = new OrderStatus();
            ReadData();
            LoadTables();
            this.personelId = personelId;
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();

        }

        private void listViewTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvItem = listViewTables.SelectedItems[0];
            int MasaNo = (int)lvItem.Tag;

            Siparis siparis = order.GetActiveOrders().FirstOrDefault(x => x.MasaNo == MasaNo);

            if (siparis == null)
            {
                siparis = new Siparis()
                {
                    MasaNo = MasaNo,
                    Durum = SiparisDurum.Aktif,
                    SAcilisZamani = DateTime.Now,
                    PersonelId = personelId
                };

                db.Siparisler.Add(siparis);
                db.SaveChanges();
                lvItem.ImageKey = "occupied";
            }

            SiparisForm siparisForm = new SiparisForm(db, siparis, MasaNo);
            DialogResult dialogResult = siparisForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                lvItem.ImageKey = "empty";
            }
        }

        private void masaTaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewTables.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = listViewTables.SelectedItems[0];
                int eskiMasaNo = (int)lvItem.Tag;

                int yeniMasaNo = NewTable(eskiMasaNo);

                if (yeniMasaNo != 0)
                {
                    OnTableChange(new MasaTasindi(eskiMasaNo, yeniMasaNo));
                }
            }
        }

        private void aktifSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementPage management = new ManagementPage();
            management.ShowDialog();
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

        private void LoadTables()
        {
            if (listViewTables.LargeImageList == null)
            {
                ImageList imageList = new ImageList();

                imageList.Images.Add("empty", Resources.EmptyTable128);
                imageList.Images.Add("occupied", Resources.OccupiedTable);
                imageList.ImageSize = new Size(128, 128);

                listViewTables.LargeImageList = imageList;
            }

            var AktifSiparisler = order.GetActiveOrders().ToList();

            var AktifSiparisKontrol = AktifSiparisler.ToLookup(x => x.MasaNo);

            var items = new List<ListViewItem>();

            for (int i = 1; i <= kafe.MasaAdet; i++)
            {
                ListViewItem lvItem = new ListViewItem("Masa " + i);
                bool isOccupied = AktifSiparisKontrol.Contains(i);
                lvItem.ImageKey = isOccupied ? "occupied" : "empty";
                lvItem.Tag = i;

                items.Add(lvItem);
            }

            listViewTables.Items.AddRange(items.ToArray());
        }

        private void SaveData()
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            var urunler = db.Urunler.ToList();
            var kategoriler = db.Kategoriler.ToList();
            var siparisler = db.Siparisler.ToList();
            var personeller = db.Personeller.ToList();

            var dataToSerialize = new
            {
                Urunler = urunler,
                Kategoriler = kategoriler,
                Siparisler = siparisler,
                Personeller = personeller
            };

            var json = JsonConvert.SerializeObject(dataToSerialize, Formatting.Indented, settings);
            File.WriteAllText("data.json", json);
        }

        private void ReadData()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                kafe = JsonConvert.DeserializeObject<Kafe>(json);
            }
            catch (Exception)
            {
                kafe = new Kafe();
            }
        }

        private int NewTable(int eskiMasaNo)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox($"Masa {eskiMasaNo} için yeni masa numarasını girin:", "Masa Taşı", "");
            if (int.TryParse(input, out int yeniMasaNo))
            {
                return yeniMasaNo;
            }
            return 0;
        }

        protected virtual void OnTableChange(MasaTasindi e)
        {
            MasaTasindi?.Invoke(this, e);
        }
    }
}