using System;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class AdminMainForm : Form
    {
        private bool isSidebarCollapsed = false;

        public AdminMainForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.Text = "Bromo Airlines - Admin";
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

        private void btnMasterBandara_Click(object sender, EventArgs e) => LoadSubForm(new MasterBandaraForm());
        private void btnMasterMaskapai_Click(object sender, EventArgs e) => LoadSubForm(new MasterMaskapaiForm());
        private void btnMasterJadwal_Click(object sender, EventArgs e) => LoadSubForm(new MasterJadwalForm());
        private void btnMasterPromo_Click(object sender, EventArgs e) => LoadSubForm(new MasterPromoForm());
        private void btnUbahStatus_Click(object sender, EventArgs e) => LoadSubForm(new UbahStatusForm());

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            LoadSubForm(new MasterBandaraForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}