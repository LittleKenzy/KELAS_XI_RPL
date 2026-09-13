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
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void Form3Dashboard_Load(object sender, EventArgs e)
        {
            // Tempat untuk memuat data awal saat Form dibuka
        }

        // 1. Master Bandara (label2 & pictureBox2)
        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4Bandara());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4Bandara());
        }

        // 2. Master Maskapai (label3 & pictureBox3)
        private void label3_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Maskapai());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Maskapai());
        }

        // 3. Master Jadwal Penerbangan (label4 & pictureBox4)
        private void label4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form6JadwalPenerbangan());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form6JadwalPenerbangan());
        }

        // 4. Master Kode Promo (label5 & pictureBox5)
        private void label5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7KodePromo());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7KodePromo());
        }

        // 5. Ubah Status Penerbangan (label6 & pictureBox6)
        private void label6_Click(object sender, EventArgs e)
        {
            // Hilangkan komentar jika Form8Status sudah dibuat
            // OpenForm(new Form8Status());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Hilangkan komentar jika Form8Status sudah dibuat
            // OpenForm(new Form8Status());
        }

        // 6. Logout (label7 & pictureBox7)
        private void label7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // Helper Method konsisten untuk perpindahan form
        private void OpenForm(Form targetForm)
        {
            this.Close();
            targetForm.Show();
        }
    }
}