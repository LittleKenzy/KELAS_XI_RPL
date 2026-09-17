using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSedhep06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTableSeating.PerformClick();
        }

        private void ShowUserControl(UserControl uc)
        {
            //bersihkan tampilan lama yang ada di panel kanan
            panelContent.Controls.Clear();

            //atur agar tampilan baru memenuhi seluruh area panelcontent
            uc.Dock = DockStyle.Fill;

            panelContent.Controls.Add(uc);
        }

        private void btnTableSeating_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_TableSeating());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Menu());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_History());
        }
    }
}
