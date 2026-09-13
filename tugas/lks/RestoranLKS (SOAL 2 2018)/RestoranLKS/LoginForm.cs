using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestoranLKS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Email dan password wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT EmployeeID, Name, Position
                        FROM MsEmployee
                        WHERE Email = @email
                        AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Simpan data user yang login
                                UserSession.EmployeeID =
                                    reader["EmployeeID"].ToString();

                                UserSession.Name =
                                    reader["Name"].ToString();

                                UserSession.Position =
                                    reader["Position"].ToString();

                                MessageBox.Show(
                                    $"Login berhasil! Selamat datang, {UserSession.Name}.",
                                    "Informasi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                // Sembunyikan Login Form
                                this.Hide();

                                // =========================
                                // ADMIN
                                // =========================
                                if (UserSession.Position.Equals(
                                    "Admin",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    AdminNavForm adminForm =
                                        new AdminNavForm();

                                    adminForm.Show();
                                }

                                // =========================
                                // CHEF
                                // =========================
                                else if (UserSession.Position.Equals(
                                    "Chef",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    ChefNavForm chefForm =
                                        new ChefNavForm();

                                    chefForm.Show();
                                }

                                // =========================
                                // CASHIER
                                // =========================
                                else if (UserSession.Position.Equals(
                                    "Cashier",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    CashierNavForm cashierForm =
                                        new CashierNavForm();

                                    cashierForm.Show();
                                }

                                // =========================
                                // ROLE TIDAK DIKENAL
                                // =========================
                                else
                                {
                                    MessageBox.Show(
                                        "Role tidak dikenali.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );

                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Email atau password salah!",
                                    "Login Gagal",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mencoba login:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}