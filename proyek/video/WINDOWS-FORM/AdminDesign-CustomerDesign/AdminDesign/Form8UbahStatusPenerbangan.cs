using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDesign
{
    public partial class Form8UbahStatusPenerbangan : Form
    {
        public Form8UbahStatusPenerbangan()
        {
            InitializeComponent();
        }

        // Navigasi ke Master Bandara
        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4Bandara());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4Bandara());
        }

        // Navigasi ke Master Maskapai
        private void label3_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Maskapai());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Maskapai());
        }

        // Navigasi ke Master Jadwal Penerbangan
        private void label4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form6JadwalPenerbangan());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form6JadwalPenerbangan());
        }

        // Navigasi ke Master Kode Promo
        private void label5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7KodePromo());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7KodePromo());
        }

        // Navigasi ke Ubah Status Penerbangan (Form ini sendiri)
        private void label6_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah karena sudah ada di Form8UbahStatusPenerbangan
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah
        }

        // Logout
        private void label7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void PanelBiru_Paint(object sender, PaintEventArgs e)
        {


        }

        // Helper Method untuk perpindahan form
        private void OpenForm(Form targetForm)
        {
            this.Close();
            targetForm.Show();
        }
    }
}
