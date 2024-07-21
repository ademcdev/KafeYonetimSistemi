namespace KafeYS
{
    partial class ManagementPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporHazırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReport = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            this.labelTotalPersonels = new System.Windows.Forms.Label();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.geçmişSiparişlerToolStripMenuItem,
            this.raporHazırlaToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1613, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(190, 1038);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünlerToolStripMenuItem.Image")));
            this.ürünlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personellerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personellerToolStripMenuItem.Image")));
            this.personellerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            this.geçmişSiparişlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geçmişSiparişlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geçmişSiparişlerToolStripMenuItem.Image")));
            this.geçmişSiparişlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            this.geçmişSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.geçmişSiparişlerToolStripMenuItem.Text = "Geçmiş Siparişler";
            this.geçmişSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.geçmişSiparişlerToolStripMenuItem_Click);
            // 
            // raporHazırlaToolStripMenuItem
            // 
            this.raporHazırlaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporHazırlaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporHazırlaToolStripMenuItem.Image")));
            this.raporHazırlaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.raporHazırlaToolStripMenuItem.Name = "raporHazırlaToolStripMenuItem";
            this.raporHazırlaToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.raporHazırlaToolStripMenuItem.Text = "Rapor Hazırla";
            this.raporHazırlaToolStripMenuItem.Visible = false;
            this.raporHazırlaToolStripMenuItem.Click += new System.EventHandler(this.raporHazırlaToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışYapToolStripMenuItem.Image")));
            this.çıkışYapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotalOrders);
            this.panel1.Controls.Add(this.labelIncome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1360, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 1038);
            this.panel1.TabIndex = 3;
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReport.Location = new System.Drawing.Point(26, 321);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(217, 84);
            this.buttonReport.TabIndex = 26;
            this.buttonReport.Text = "Rapor";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(26, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Başlangıç Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bitiş Tarihi:";
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.Size = new System.Drawing.Size(1360, 1038);
            this.dataGridViewSiparis.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTotalPersonels);
            this.panel2.Controls.Add(this.labelTotalProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 758);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 280);
            this.panel2.TabIndex = 5;
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTotalProducts.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalProducts.ForeColor = System.Drawing.Color.White;
            this.labelTotalProducts.Location = new System.Drawing.Point(13, 18);
            this.labelTotalProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(232, 253);
            this.labelTotalProducts.TabIndex = 36;
            this.labelTotalProducts.Text = "-";
            this.labelTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalPersonels
            // 
            this.labelTotalPersonels.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTotalPersonels.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalPersonels.ForeColor = System.Drawing.Color.White;
            this.labelTotalPersonels.Location = new System.Drawing.Point(476, 18);
            this.labelTotalPersonels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPersonels.Name = "labelTotalPersonels";
            this.labelTotalPersonels.Size = new System.Drawing.Size(232, 253);
            this.labelTotalPersonels.TabIndex = 37;
            this.labelTotalPersonels.Text = "-";
            this.labelTotalPersonels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTotalOrders.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalOrders.ForeColor = System.Drawing.Color.White;
            this.labelTotalOrders.Location = new System.Drawing.Point(11, 740);
            this.labelTotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(232, 253);
            this.labelTotalOrders.TabIndex = 38;
            this.labelTotalOrders.Text = "-";
            this.labelTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncome
            // 
            this.labelIncome.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelIncome.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIncome.ForeColor = System.Drawing.Color.White;
            this.labelIncome.Location = new System.Drawing.Point(11, 472);
            this.labelIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(232, 253);
            this.labelIncome.TabIndex = 39;
            this.labelIncome.Text = "-";
            this.labelIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 1038);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewSiparis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManagementPage";
            this.Text = "CafeManagementPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporHazırlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotalProducts;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label labelTotalPersonels;
        private System.Windows.Forms.Label labelIncome;
    }
}