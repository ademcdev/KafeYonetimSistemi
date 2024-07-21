namespace KafeYS
{
    partial class PastOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastOrders));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GeriDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerSiparis = new System.Windows.Forms.SplitContainer();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.SiparisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAcilisZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKapanisZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSiparisDetay = new System.Windows.Forms.DataGridView();
            this.SiparisDetayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSiparis)).BeginInit();
            this.splitContainerSiparis.Panel1.SuspendLayout();
            this.splitContainerSiparis.Panel2.SuspendLayout();
            this.splitContainerSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeriDonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(658, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(142, 450);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GeriDonToolStripMenuItem
            // 
            this.GeriDonToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GeriDonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriDonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GeriDonToolStripMenuItem.Image")));
            this.GeriDonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GeriDonToolStripMenuItem.Name = "GeriDonToolStripMenuItem";
            this.GeriDonToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.GeriDonToolStripMenuItem.Text = "Geri Dön";
            this.GeriDonToolStripMenuItem.Click += new System.EventHandler(this.GeriDonToolStripMenuItem_Click);
            // 
            // splitContainerSiparis
            // 
            this.splitContainerSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSiparis.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSiparis.Name = "splitContainerSiparis";
            this.splitContainerSiparis.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSiparis.Panel1
            // 
            this.splitContainerSiparis.Panel1.Controls.Add(this.dataGridViewSiparis);
            // 
            // splitContainerSiparis.Panel2
            // 
            this.splitContainerSiparis.Panel2.Controls.Add(this.dataGridViewSiparisDetay);
            this.splitContainerSiparis.Size = new System.Drawing.Size(658, 450);
            this.splitContainerSiparis.SplitterDistance = 213;
            this.splitContainerSiparis.TabIndex = 3;
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSiparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiparisId,
            this.MasaNo,
            this.Durum,
            this.SAcilisZamani,
            this.SKapanisZamani,
            this.PersonelId});
            this.dataGridViewSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.Size = new System.Drawing.Size(658, 213);
            this.dataGridViewSiparis.TabIndex = 0;
            this.dataGridViewSiparis.SelectionChanged += new System.EventHandler(this.dataGridViewSiparis_SelectionChanged);
            // 
            // SiparisId
            // 
            this.SiparisId.DataPropertyName = "SiparisId";
            this.SiparisId.HeaderText = "Siparis Numarası";
            this.SiparisId.Name = "SiparisId";
            // 
            // MasaNo
            // 
            this.MasaNo.DataPropertyName = "MasaNo";
            this.MasaNo.HeaderText = "Masa Numarası";
            this.MasaNo.Name = "MasaNo";
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Sipariş Durumu";
            this.Durum.Name = "Durum";
            // 
            // SAcilisZamani
            // 
            this.SAcilisZamani.DataPropertyName = "SAcilisZamani";
            this.SAcilisZamani.HeaderText = "Sipariş Açılış Zamanı";
            this.SAcilisZamani.Name = "SAcilisZamani";
            // 
            // SKapanisZamani
            // 
            this.SKapanisZamani.DataPropertyName = "SKapanisZamani";
            this.SKapanisZamani.HeaderText = "Sipariş Kapanış Zamanı";
            this.SKapanisZamani.Name = "SKapanisZamani";
            // 
            // PersonelId
            // 
            this.PersonelId.DataPropertyName = "PersonelId";
            this.PersonelId.HeaderText = "Personel Numarası";
            this.PersonelId.Name = "PersonelId";
            // 
            // dataGridViewSiparisDetay
            // 
            this.dataGridViewSiparisDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSiparisDetay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisDetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiparisDetayId,
            this.UrunId,
            this.UrunAd,
            this.UrunAdet,
            this.UrunFiyat});
            this.dataGridViewSiparisDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSiparisDetay.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSiparisDetay.Name = "dataGridViewSiparisDetay";
            this.dataGridViewSiparisDetay.Size = new System.Drawing.Size(658, 233);
            this.dataGridViewSiparisDetay.TabIndex = 1;
            // 
            // SiparisDetayId
            // 
            this.SiparisDetayId.DataPropertyName = "SiparisDetayId";
            this.SiparisDetayId.HeaderText = "SiparisDetayId";
            this.SiparisDetayId.Name = "SiparisDetayId";
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "Ürün Numarası";
            this.UrunId.Name = "UrunId";
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            // 
            // UrunAdet
            // 
            this.UrunAdet.DataPropertyName = "UrunAdet";
            this.UrunAdet.HeaderText = "Ürün Adeti";
            this.UrunAdet.Name = "UrunAdet";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.DataPropertyName = "UrunFiyat";
            this.UrunFiyat.HeaderText = "Birim Fiyatı";
            this.UrunFiyat.Name = "UrunFiyat";
            // 
            // PastOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerSiparis);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PastOrders";
            this.Text = "PastOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerSiparis.Panel1.ResumeLayout(false);
            this.splitContainerSiparis.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSiparis)).EndInit();
            this.splitContainerSiparis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GeriDonToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerSiparis;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
        private System.Windows.Forms.DataGridView dataGridViewSiparisDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAcilisZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKapanisZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisDetayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunFiyat;
    }
}