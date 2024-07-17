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
    public partial class ManagementPage : Form
    {
        private KafeYS db;

        public ManagementPage()
        {
            InitializeComponent();
            db = new KafeYS();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(db);
            productPage.ShowDialog();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(db);
            employeePage.ShowDialog();
        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporHazırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
