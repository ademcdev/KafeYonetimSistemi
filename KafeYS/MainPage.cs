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
    public partial class MainPage : Form
    {
        private KafeYS db;
        private Kafe kafe;

        public MainPage()
        {
            InitializeComponent();
            db = new KafeYS();
            ReadData();
            LoadTables();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void masaTaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aktifSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporHazırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(db);
            productPage.ShowDialog();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(db);
            employeePage.ShowDialog();
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

                imageList.Images.Add("Empty", Resources.EmptyTable128);
                imageList.Images.Add("Occupied", Resources.OccupiedTable);
                imageList.ImageSize = new Size(128, 128);

                listViewTables.LargeImageList = imageList;
            }

            var AktifSiparisler = kafe.AktifSiparisler.ToList();

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

        
    }
}