using System;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class CustomerMainForm : Form
    {
        private bool isSidebarCollapsed = false;

        public CustomerMainForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.Text = "Bromo Airlines - Customer";
            this.StartPosition = FormStartPosition.CenterScreen;
            panelSidebar.BackColor = BromoColors.BromoBlue;
            panelMainContent.BackColor = BromoColors.BromoMidBlue;
            panelContent.BackColor = BromoColors.BromoWhite;
        }

        private void LoadSubForm(Form subForm)
        {
            panelContent.Controls.Clear();
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(subForm);
            subForm.Show();
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            if (isSidebarCollapsed)
            {
                panelSidebar.Width = 200;
                isSidebarCollapsed = false;
            }
            else
            {
                panelSidebar.Width = 60;
                isSidebarCollapsed = true;
            }
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Selamat Datang," + Environment.NewLine + CurrentUser.Nama;
            LoadSubForm(new CustomerListPenerbanganForm());
        }

        private void btnListPenerbangan_Click(object sender, EventArgs e) => LoadSubForm(new CustomerListPenerbanganForm());
        private void btnBeliTiket_Click(object sender, EventArgs e) => LoadSubForm(new CustomerBeliTiketForm());
        private void btnTiketSaya_Click(object sender, EventArgs e) => LoadSubForm(new CustomerTiketSayaForm());

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CurrentUser.Clear();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void CustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
