namespace KafeYS
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.labelMasaNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.labelOdemeTutari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOdemeAl = new System.Windows.Forms.Button();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EkletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuncelletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisİptaltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeriDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisDetayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EkletoolStripMenuItem,
            this.GuncelletoolStripMenuItem,
            this.SiparisİptaltoolStripMenuItem,
            this.GeriDonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(989, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(149, 688);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(30, 53);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(217, 37);
            this.comboBoxCategory.TabIndex = 18;
            this.comboBoxCategory.Text = "Kategori Seçiniz";
            this.comboBoxCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategory_SelectionChangeCommitted);
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiparisDetayId,
            this.UrunId,
            this.UrunAd,
            this.UrunAdet,
            this.UrunFiyat});
            this.dataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(989, 688);
            this.dataGridViewOrderDetails.TabIndex = 19;
            // 
            // labelMasaNo
            // 
            this.labelMasaNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMasaNo.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMasaNo.ForeColor = System.Drawing.Color.White;
            this.labelMasaNo.Location = new System.Drawing.Point(4, 0);
            this.labelMasaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMasaNo.Name = "labelMasaNo";
            this.labelMasaNo.Size = new System.Drawing.Size(280, 97);
            this.labelMasaNo.TabIndex = 20;
            this.labelMasaNo.Text = "03";
            this.labelMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adet";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownAdet.Location = new System.Drawing.Point(30, 261);
            this.numericUpDownAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(217, 35);
            this.numericUpDownAdet.TabIndex = 21;
            // 
            // labelOdemeTutari
            // 
            this.labelOdemeTutari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOdemeTutari.AutoSize = true;
            this.labelOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdemeTutari.Location = new System.Drawing.Point(195, 352);
            this.labelOdemeTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOdemeTutari.Name = "labelOdemeTutari";
            this.labelOdemeTutari.Size = new System.Drawing.Size(66, 25);
            this.labelOdemeTutari.TabIndex = 24;
            this.labelOdemeTutari.Text = "0.00₺";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ödeme Tutarı:";
            // 
            // buttonOdemeAl
            // 
            this.buttonOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOdemeAl.Location = new System.Drawing.Point(30, 430);
            this.buttonOdemeAl.Name = "buttonOdemeAl";
            this.buttonOdemeAl.Size = new System.Drawing.Size(217, 84);
            this.buttonOdemeAl.TabIndex = 25;
            this.buttonOdemeAl.Text = "Ödeme";
            this.buttonOdemeAl.UseVisualStyleBackColor = true;
            this.buttonOdemeAl.Click += new System.EventHandler(this.buttonOdemeAl_Click);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Enabled = false;
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(30, 155);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(217, 37);
            this.comboBoxProduct.TabIndex = 26;
            this.comboBoxProduct.Text = "Ürün Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kategori";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Enabled = false;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProduct.Location = new System.Drawing.Point(25, 127);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(58, 25);
            this.labelProduct.TabIndex = 28;
            this.labelProduct.Text = "Ürün";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonOdemeAl);
            this.panel1.Controls.Add(this.labelProduct);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxProduct);
            this.panel1.Controls.Add(this.labelOdemeTutari);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.numericUpDownAdet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(701, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 688);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMasaNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 97);
            this.panel2.TabIndex = 29;
            // 
            // EkletoolStripMenuItem
            // 
            this.EkletoolStripMenuItem.Image = global::KafeYS.Properties.Resources.placeholder;
            this.EkletoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EkletoolStripMenuItem.Name = "EkletoolStripMenuItem";
            this.EkletoolStripMenuItem.Size = new System.Drawing.Size(136, 68);
            this.EkletoolStripMenuItem.Text = "Ekle";
            this.EkletoolStripMenuItem.Click += new System.EventHandler(this.EkletoolStripMenuItem_Click);
            // 
            // GuncelletoolStripMenuItem
            // 
            this.GuncelletoolStripMenuItem.Image = global::KafeYS.Properties.Resources.placeholder;
            this.GuncelletoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GuncelletoolStripMenuItem.Name = "GuncelletoolStripMenuItem";
            this.GuncelletoolStripMenuItem.Size = new System.Drawing.Size(136, 68);
            this.GuncelletoolStripMenuItem.Text = "Güncelle";
            this.GuncelletoolStripMenuItem.Click += new System.EventHandler(this.GuncelletoolStripMenuItem_Click);
            // 
            // SiparisİptaltoolStripMenuItem
            // 
            this.SiparisİptaltoolStripMenuItem.Image = global::KafeYS.Properties.Resources.placeholder;
            this.SiparisİptaltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SiparisİptaltoolStripMenuItem.Name = "SiparisİptaltoolStripMenuItem";
            this.SiparisİptaltoolStripMenuItem.Size = new System.Drawing.Size(136, 68);
            this.SiparisİptaltoolStripMenuItem.Text = "Sipariş İptal";
            this.SiparisİptaltoolStripMenuItem.Click += new System.EventHandler(this.SiparisİptaltoolStripMenuItem_Click);
            // 
            // GeriDonToolStripMenuItem
            // 
            this.GeriDonToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GeriDonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriDonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GeriDonToolStripMenuItem.Image")));
            this.GeriDonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GeriDonToolStripMenuItem.Name = "GeriDonToolStripMenuItem";
            this.GeriDonToolStripMenuItem.Size = new System.Drawing.Size(136, 68);
            this.GeriDonToolStripMenuItem.Text = "Geri Dön";
            this.GeriDonToolStripMenuItem.Click += new System.EventHandler(this.GeriDonToolStripMenuItem_Click);
            // 
            // SiparisDetayId
            // 
            this.SiparisDetayId.DataPropertyName = "SiparisDetayId";
            this.SiparisDetayId.HeaderText = "SiparisDetayId";
            this.SiparisDetayId.Name = "SiparisDetayId";
            this.SiparisDetayId.Visible = false;
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "UrunId";
            this.UrunId.Name = "UrunId";
            this.UrunId.Visible = false;
            this.UrunId.Width = 64;
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            this.UrunAd.Width = 73;
            // 
            // UrunAdet
            // 
            this.UrunAdet.DataPropertyName = "UrunAdet";
            this.UrunAdet.HeaderText = "Adet";
            this.UrunAdet.Name = "UrunAdet";
            this.UrunAdet.Width = 54;
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.DataPropertyName = "UrunFiyat";
            this.UrunFiyat.HeaderText = "Birim Fiyatı";
            this.UrunFiyat.Name = "UrunFiyat";
            this.UrunFiyat.Width = 81;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 688);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GeriDonToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ToolStripMenuItem EkletoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuncelletoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SiparisİptaltoolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelMasaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label labelOdemeTutari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOdemeAl;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisDetayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunFiyat;
    }
}