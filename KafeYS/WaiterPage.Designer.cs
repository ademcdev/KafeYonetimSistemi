namespace KafeYS
{
    partial class WaiterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masaTaşıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewTables = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaTaşıToolStripMenuItem,
            this.aktifSiparişlerToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1025, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(148, 718);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masaTaşıToolStripMenuItem
            // 
            this.masaTaşıToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaTaşıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masaTaşıToolStripMenuItem.Image")));
            this.masaTaşıToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.masaTaşıToolStripMenuItem.Name = "masaTaşıToolStripMenuItem";
            this.masaTaşıToolStripMenuItem.Size = new System.Drawing.Size(135, 68);
            this.masaTaşıToolStripMenuItem.Text = "Masa Taşı";
            this.masaTaşıToolStripMenuItem.Click += new System.EventHandler(this.masaTaşıToolStripMenuItem_Click);
            // 
            // aktifSiparişlerToolStripMenuItem
            // 
            this.aktifSiparişlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aktifSiparişlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aktifSiparişlerToolStripMenuItem.Image")));
            this.aktifSiparişlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktifSiparişlerToolStripMenuItem.Name = "aktifSiparişlerToolStripMenuItem";
            this.aktifSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(160, 68);
            this.aktifSiparişlerToolStripMenuItem.Text = "Aktif Siparişler";
            this.aktifSiparişlerToolStripMenuItem.Visible = false;
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışYapToolStripMenuItem.Image")));
            this.çıkışYapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(135, 68);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // listViewTables
            // 
            this.listViewTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTables.HideSelection = false;
            this.listViewTables.Location = new System.Drawing.Point(0, 0);
            this.listViewTables.Name = "listViewTables";
            this.listViewTables.Size = new System.Drawing.Size(1025, 718);
            this.listViewTables.TabIndex = 1;
            this.listViewTables.UseCompatibleStateImageBehavior = false;
            this.listViewTables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTables_MouseDoubleClick);
            // 
            // WaiterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 718);
            this.ControlBox = false;
            this.Controls.Add(this.listViewTables);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WaiterPage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aktifSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaTaşıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ListView listViewTables;
    }
}

