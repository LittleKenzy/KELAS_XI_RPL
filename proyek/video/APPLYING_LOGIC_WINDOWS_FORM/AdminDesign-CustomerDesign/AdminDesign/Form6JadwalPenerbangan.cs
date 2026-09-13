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
    public partial class Form6JadwalPenerbangan : Form
    {

        BandaraEntities db = new BandaraEntities();
        private int idJadwal = -1; //Mode tambah

        public Form6JadwalPenerbangan()
        {
            InitializeComponent();
        }

        // Navigasi ke Master Bandara
        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new iataTxt());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new iataTxt());
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

        // Navigasi ke Master Jadwal Penerbangan (Form ini sendiri)
        private void label4_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah karena sudah ada di Form6JadwalPenerbangan
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Helper Method untuk perpindahan form
        private void OpenForm(Form targetForm)
        {
            this.Close();
            targetForm.Show();
        }

        private void Form6JadwalPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridJadwal.AutoGenerateColumns = false;
            dataGridJadwal.AllowUserToAddRows = false;
            dataGridJadwal.ReadOnly = true;


            loadBandara();
            loadMaskapai();
            loadJadwal();
        }

        private void loadBandara()
        {
            //keberangkatan
            departureBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            departureBox.DisplayMember = "Nama";
            departureBox.ValueMember = "ID";
            departureBox.SelectedIndex = -1;

            //Tujuan
            destinationBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            destinationBox.DisplayMember = "Nama";
            destinationBox.ValueMember = "ID";
            destinationBox.SelectedIndex = -1;
        }

        private void loadMaskapai()
        {
            maskapaiBox.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList();
            maskapaiBox.DisplayMember = "Nama";
            maskapaiBox.ValueMember = "ID";
            maskapaiBox.SelectedIndex = -1;

        }

        private void loadJadwal()
        {
            //Menampilkan semua jadwal ke dalam data grid view
            dataGridJadwal.DataSource = db.JadwalPenerbangans
                                        .OrderBy(j => j.TanggalKeberangkatan)
                                        .ThenByDescending(j => j.TanggalKeberangkatan)
                                        .Select(j => new
                                        {
                                            j.ID,
                                            j.KodePenerbangan,
                                            BandaraAsal = j.Bandara.Nama,
                                            BandaraTujuan = j.Bandara1.Nama,
                                            Maskapai = j.Maskapai.Nama,
                                            j.WaktuKeberangkatan,
                                            j.DurasiPenerbangan,
                                            j.HargaPerTiket
                                        }).ToList();
        }
    }
}
