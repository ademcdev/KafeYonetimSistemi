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
using System.Security.Cryptography;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Contexts;

namespace KafeYS
{
    public partial class LoginForm : Form
    {
        public AccessLevel UserAccessLevel {  get; private set; }
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();

        public LoginForm()
        {
            InitializeComponent();
            InitializeTextBoxPlaceholders();
            AcceptButton = buttonLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        private new void Validate()
        {
            using (var db = new KafeYS())
            {
                string email = textBoxEmail.Text;
                string password = textBoxPassword.Text;

                string hashedPassword = HashPassword(password);

                var personel = db.Personeller.FirstOrDefault(p => p.PersonelEmail == email && p.PersonelSifre == hashedPassword);

                if (personel != null)
                {
                    UserAccessLevel = personel.AccessLevel;
                    Console.WriteLine(UserAccessLevel);
                    Form mainPage = null;

                    if (UserAccessLevel == AccessLevel.Admin)
                    {
                        mainPage = new ManagementPage();
                    }
                    else if (UserAccessLevel == AccessLevel.Manager)
                    {
                        mainPage = new ManagementPage();
                    }
                    else if (UserAccessLevel == AccessLevel.Waiter)
                    {
                        mainPage = new WaiterPage();
                    }
                    else
                    {
                        MessageBox.Show("Yetkisiz erişim!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (mainPage != null)
                    {
                        this.Hide();
                        mainPage.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış email veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InitializeTextBoxPlaceholders()
        {
            SetPlaceholder(textBoxEmail, "E-postanızı giriniz...");
            SetPlaceholder(textBoxPassword, "Şifreniz");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            placeholders[textBox] = placeholder;
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += RemovePlaceholder;
            textBox.LostFocus += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == placeholders[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
