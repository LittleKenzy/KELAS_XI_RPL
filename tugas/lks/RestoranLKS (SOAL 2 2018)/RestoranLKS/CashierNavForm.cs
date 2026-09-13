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
    public partial class CashierNavForm : Form
    {
        public CashierNavForm()
        {
            InitializeComponent();

            if (UserSession.Position == null ||
              !UserSession.Position.Equals("Cashier", StringComparison.OrdinalIgnoreCase)
              )
            {
                MessageBox.Show("Anda tidak memiliki akses ke cashier navigation. Silakan login sebagai Cashier.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lblWelcome.Text = "Welcome, " + UserSession.Name;
        }

        private void CashierNavForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu payment belum dibuat", "Payment");
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
            loginForm.ShowDialog();
        }
    }
}
