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
    public partial class Form4Bandara : Form
    {
        public Form4Bandara()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Navigasi ke Master Bandara (Form ini sendiri)
        private void label3_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah karena sudah ada di Form4Bandara
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

        // Navigasi ke Ubah Status Penerbangan
        private void label6_Click(object sender, EventArgs e)
        {
            OpenForm(new Form8UbahStatusPenerbangan());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenForm(new Form8UbahStatusPenerbangan());
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

        // Helper Method untuk perpindahan form
        private void OpenForm(Form targetForm)
        {
            this.Close();
            targetForm.Show();
        }
    }
}
