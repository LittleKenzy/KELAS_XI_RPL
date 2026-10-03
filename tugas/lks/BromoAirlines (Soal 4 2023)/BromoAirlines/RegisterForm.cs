using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.Text = "Bromo Airlines - Daftar Akun";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.CustomFormat = "dd-MM-yyyy";

            btnDaftar.BackColor = BromoColors.BromoMidBlue;
            btnDaftar.ForeColor = BromoColors.BromoWhite;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string nama = txtNama.Text.Trim();
            string noTelp = txtNoTelp.Text.Trim();
            string password = txtPassword.Text.Trim();
            DateTime tglLahir = dtpTanggalLahir.Value.Date;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(nama) ||
                string.IsNullOrEmpty(noTelp) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Seluruh bidang input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(noTelp, @"^\d{10,15}$"))
            {
                MessageBox.Show("Nomor telepon harus berupa angka murni dengan panjang 10 hingga 15 digit!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password akun minimal harus 8 karakter!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new BromoAirlinesEntities())
                {
                    bool isUsernameExist = db.Akuns.Any(a => a.Username.ToLower() == username.ToLower());
                    if (isUsernameExist)
                    {
                        MessageBox.Show("Username sudah terdaftar! Gunakan username lain.", "Error Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Akun newAccount = new Akun
                    {
                        Username = username,
                        Nama = nama,
                        TanggalLahir = tglLahir,
                        NomorTelepon = noTelp,
                        Password = password,
                        MerupakanAdmin = false
                    };

                    db.Akuns.Add(newAccount);
                    db.SaveChanges();

                    CurrentUser.ID = newAccount.ID;
                    CurrentUser.Username = newAccount.Username;
                    CurrentUser.Nama = newAccount.Nama;
                    CurrentUser.MerupakanAdmin = false;

                    MessageBox.Show("Pendaftaran akun berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    CustomerMainForm customerMain = new CustomerMainForm();
                    customerMain.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat pendaftaran: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RedirectToLogin();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                RedirectToLogin();
            }
        }

        private void RedirectToLogin()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}