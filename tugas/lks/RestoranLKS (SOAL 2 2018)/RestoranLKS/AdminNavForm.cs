using Microsoft.Win32;
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
    public partial class AdminNavForm : Form
    {
        public AdminNavForm()
        {
            InitializeComponent();

            if(UserSession.Position == null || 
               !UserSession.Position.Equals("Admin", StringComparison.OrdinalIgnoreCase)
                )
            {
                MessageBox.Show("Anda tidak memiliki akses ke admin navigation. Silakan login sebagai Admin.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lblWelcome.Text = "Welcome, " + UserSession.Name;
        }

        private void AdminNavForm_Load(object sender, EventArgs e)
        {

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
