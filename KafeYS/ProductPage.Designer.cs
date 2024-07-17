namespace KafeYS
{
    partial class ProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeriDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunId,
            this.UrunAd,
            this.BirimFiyat});
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(1027, 585);
            this.dataGridViewProduct.TabIndex = 2;
            this.dataGridViewProduct.SelectionChanged += new System.EventHandler(this.dataGridViewProduct_SelectionChanged);
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "UrunId";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            this.UrunId.Visible = false;
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "Birim Fiyatı";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.GeriDonToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(885, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(142, 585);
            this.menuStrip2.TabIndex = 99;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Image = global::KafeYS.Properties.Resources.placeholder;
            this.ürünEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.ürünEkleToolStripMenuItem.Text = "Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Image = global::KafeYS.Properties.Resources.placeholder;
            this.güncelleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::KafeYS.Properties.Resources.placeholder;
            this.silToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
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
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.comboBoxCategory);
            this.panelProduct.Controls.Add(this.label4);
            this.panelProduct.Controls.Add(this.label3);
            this.panelProduct.Controls.Add(this.label1);
            this.panelProduct.Controls.Add(this.numericUpDownPrice);
            this.panelProduct.Controls.Add(this.textBoxProductName);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelProduct.Location = new System.Drawing.Point(632, 0);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(253, 585);
            this.panelProduct.TabIndex = 5;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(19, 52);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(217, 37);
            this.comboBoxCategory.TabIndex = 17;
            this.comboBoxCategory.Text = "Kategori Seçiniz";
            this.comboBoxCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategory_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Birim Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Urun Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kategori:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(19, 243);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(217, 35);
            this.numericUpDownPrice.TabIndex = 13;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxProductName.Location = new System.Drawing.Point(19, 147);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(217, 35);
            this.textBoxProductName.TabIndex = 12;
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 585);
            this.ControlBox = false;
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "ProductPage";
            this.Text = "ProductPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GeriDonToolStripMenuItem;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
    }
}