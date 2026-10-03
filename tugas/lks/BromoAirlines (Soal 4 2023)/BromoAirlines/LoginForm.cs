using System;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.Text = "Bromo Airlines - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            btnLogin.BackColor = BromoColors.BromoMidBlue;
            btnLogin.ForeColor = BromoColors.BromoWhite;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new BromoAirlinesEntities())
                {
                    var user = db.Akuns.FirstOrDefault(a => a.Username == username && a.Password == password);

                    if (user != null)
                    {
                        CurrentUser.ID = user.ID;
                        CurrentUser.Username = user.Username;
                        CurrentUser.Nama = user.Nama;
                        CurrentUser.MerupakanAdmin = user.MerupakanAdmin ?? false;

                        this.Hide();
                        if (CurrentUser.MerupakanAdmin)
                        {
                            AdminMainForm adminForm = new AdminMainForm();
                            adminForm.Show();
                        }
                        else
                        {
                            CustomerMainForm customerForm = new CustomerMainForm();
                            customerForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password yang Anda masukkan salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan koneksi database: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}