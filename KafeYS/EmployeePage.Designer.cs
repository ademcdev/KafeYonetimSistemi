namespace KafeYS
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.panelPersonel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAccessLevel = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPersonelEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPersonelAd = new System.Windows.Forms.TextBox();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.PersonelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YetkiSeviyesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelTelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersenolİseGirisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeriDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPersonel
            // 
            this.panelPersonel.Controls.Add(this.label5);
            this.panelPersonel.Controls.Add(this.comboBoxAccessLevel);
            this.panelPersonel.Controls.Add(this.maskedTextBoxTelNo);
            this.panelPersonel.Controls.Add(this.label6);
            this.panelPersonel.Controls.Add(this.textBoxPassword);
            this.panelPersonel.Controls.Add(this.label4);
            this.panelPersonel.Controls.Add(this.label2);
            this.panelPersonel.Controls.Add(this.textBoxPersonelEmail);
            this.panelPersonel.Controls.Add(this.label1);
            this.panelPersonel.Controls.Add(this.textBoxPersonelSoyad);
            this.panelPersonel.Controls.Add(this.label3);
            this.panelPersonel.Controls.Add(this.textBoxPersonelAd);
            this.panelPersonel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPersonel.Location = new System.Drawing.Point(632, 0);
            this.panelPersonel.Name = "panelPersonel";
            this.panelPersonel.Size = new System.Drawing.Size(253, 585);
            this.panelPersonel.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Yetki Seviyesi:";
            // 
            // comboBoxAccessLevel
            // 
            this.comboBoxAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAccessLevel.FormattingEnabled = true;
            this.comboBoxAccessLevel.Location = new System.Drawing.Point(19, 511);
            this.comboBoxAccessLevel.Name = "comboBoxAccessLevel";
            this.comboBoxAccessLevel.Size = new System.Drawing.Size(217, 37);
            this.comboBoxAccessLevel.TabIndex = 26;
            this.comboBoxAccessLevel.Text = "Yetki Seçiniz...";
            // 
            // maskedTextBoxTelNo
            // 
            this.maskedTextBoxTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTelNo.Location = new System.Drawing.Point(19, 322);
            this.maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            this.maskedTextBoxTelNo.Size = new System.Drawing.Size(217, 35);
            this.maskedTextBoxTelNo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Personel Şifre:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassword.Location = new System.Drawing.Point(19, 406);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(217, 35);
            this.textBoxPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Personel Emaili:";
            // 
            // textBoxPersonelEmail
            // 
            this.textBoxPersonelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPersonelEmail.Location = new System.Drawing.Point(19, 232);
            this.textBoxPersonelEmail.Name = "textBoxPersonelEmail";
            this.textBoxPersonelEmail.Size = new System.Drawing.Size(217, 35);
            this.textBoxPersonelEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Personel Soyadı:";
            // 
            // textBoxPersonelSoyad
            // 
            this.textBoxPersonelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPersonelSoyad.Location = new System.Drawing.Point(19, 142);
            this.textBoxPersonelSoyad.Name = "textBoxPersonelSoyad";
            this.textBoxPersonelSoyad.Size = new System.Drawing.Size(217, 35);
            this.textBoxPersonelSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Personel Adı:";
            // 
            // textBoxPersonelAd
            // 
            this.textBoxPersonelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPersonelAd.Location = new System.Drawing.Point(19, 55);
            this.textBoxPersonelAd.Name = "textBoxPersonelAd";
            this.textBoxPersonelAd.Size = new System.Drawing.Size(217, 35);
            this.textBoxPersonelAd.TabIndex = 1;
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelId,
            this.IsActive,
            this.YetkiSeviyesi,
            this.PersonelAd,
            this.PersonelSoyad,
            this.PersonelEmail,
            this.PersonelTelNo,
            this.PersenolİseGirisTarih,
            this.PersonelSifre});
            this.dataGridViewPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersonel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.Size = new System.Drawing.Size(885, 585);
            this.dataGridViewPersonel.TabIndex = 100;
            this.dataGridViewPersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellContentClick);
            this.dataGridViewPersonel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellEndEdit);
            this.dataGridViewPersonel.SelectionChanged += new System.EventHandler(this.dataGridViewPersonel_SelectionChanged);
            // 
            // PersonelId
            // 
            this.PersonelId.DataPropertyName = "PersonelId";
            this.PersonelId.HeaderText = "PersonelId";
            this.PersonelId.Name = "PersonelId";
            this.PersonelId.Visible = false;
            this.PersonelId.Width = 82;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Aktiflik";
            this.IsActive.Name = "IsActive";
            this.IsActive.Width = 44;
            // 
            // YetkiSeviyesi
            // 
            this.YetkiSeviyesi.DataPropertyName = "AccessLevel";
            this.YetkiSeviyesi.HeaderText = "Yetki Seviyesi";
            this.YetkiSeviyesi.Name = "YetkiSeviyesi";
            this.YetkiSeviyesi.Width = 90;
            // 
            // PersonelAd
            // 
            this.PersonelAd.DataPropertyName = "PersonelAd";
            this.PersonelAd.HeaderText = "Personel Adı";
            this.PersonelAd.Name = "PersonelAd";
            this.PersonelAd.Width = 84;
            // 
            // PersonelSoyad
            // 
            this.PersonelSoyad.DataPropertyName = "PersonelSoyad";
            this.PersonelSoyad.HeaderText = "Personel Soyadı";
            this.PersonelSoyad.Name = "PersonelSoyad";
            this.PersonelSoyad.Width = 99;
            // 
            // PersonelEmail
            // 
            this.PersonelEmail.DataPropertyName = "PersonelEmail";
            this.PersonelEmail.HeaderText = "Personel Email";
            this.PersonelEmail.Name = "PersonelEmail";
            this.PersonelEmail.Width = 93;
            // 
            // PersonelTelNo
            // 
            this.PersonelTelNo.DataPropertyName = "PersonelTelNo";
            this.PersonelTelNo.HeaderText = "Personel Telefon Numarası";
            this.PersonelTelNo.Name = "PersonelTelNo";
            this.PersonelTelNo.Width = 145;
            // 
            // PersenolİseGirisTarih
            // 
            this.PersenolİseGirisTarih.DataPropertyName = "PersonelİseGirisTarih";
            this.PersenolİseGirisTarih.HeaderText = "Persenol İşe Giriş Tarihi";
            this.PersenolİseGirisTarih.Name = "PersenolİseGirisTarih";
            this.PersenolİseGirisTarih.Width = 106;
            // 
            // PersonelSifre
            // 
            this.PersonelSifre.DataPropertyName = "PersonelSifre";
            this.PersonelSifre.HeaderText = "Personel Şifre";
            this.PersonelSifre.Name = "PersonelSifre";
            this.PersonelSifre.Width = 89;
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
            this.menuStrip2.TabIndex = 102;
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
            this.GeriDonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriDonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GeriDonToolStripMenuItem.Image")));
            this.GeriDonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GeriDonToolStripMenuItem.Name = "GeriDonToolStripMenuItem";
            this.GeriDonToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.GeriDonToolStripMenuItem.Text = "Geri Dön";
            this.GeriDonToolStripMenuItem.Click += new System.EventHandler(this.GeriDonToolStripMenuItem_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 585);
            this.ControlBox = false;
            this.Controls.Add(this.panelPersonel);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Controls.Add(this.menuStrip2);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPersonel.ResumeLayout(false);
            this.panelPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPersonelAd;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GeriDonToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPersonelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPersonelSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelNo;
        private System.Windows.Forms.ComboBox comboBoxAccessLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiSeviyesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelTelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersenolİseGirisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSifre;
    }
}