using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranLKS
{
    public partial class ChefNavForm : Form
    {
        public ChefNavForm()
        {
            InitializeComponent();

            if (UserSession.Position == null ||
                !UserSession.Position.Equals("Chef", StringComparison.OrdinalIgnoreCase)
                )
            {
                MessageBox.Show("Anda tidak memiliki akses ke chef navigation. Silakan login sebagai Chef.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lblWelcome.Text = "Welcome, " + UserSession.Name;
        }

        private void ChefNavForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu view order belum dibuat", "View Order");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu change password belum dibuat", "Change Password");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.EmployeeID = null;
            UserSession.Name = null;
            UserSession.Position = null;

            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
