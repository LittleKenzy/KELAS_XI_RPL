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
    public partial class Form5Maskapai : Form
    {

        BandaraEntities db = new BandaraEntities();
        private int idMaskapai = -1; // Menyimpan ID maskapai yang sedang diedit (-1 mode Tambah, jika > 0 Mode update)

        public Form5Maskapai()
        {
            InitializeComponent();
        }

        private void Form5Maskapai_Load(object sender, EventArgs e)
        {
            // Tempat untuk memuat data awal (misal: tampilkan data Maskapai di DataGridView)
        }

        // 1. Navigasi ke Master Bandara (label2 & pictureBox2)
        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new iataTxt());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new iataTxt());
        }

        // 2. Navigasi ke Master Maskapai (Halaman Ini Sendiri)
        private void label3_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah karena sudah ada di Form5Maskapai
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Tidak perlu berpindah karena sudah ada di Form5Maskapai
        }

        // 3. Navigasi ke Master Jadwal Penerbangan (label4 & pictureBox4)
        private void label4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form6JadwalPenerbangan());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form6JadwalPenerbangan());
        }

        // 4. Navigasi ke Master Kode Promo (label5 & pictureBox5)
        private void label5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7KodePromo());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7KodePromo());
        }

        // 5. Navigasi ke Ubah Status Penerbangan (label6 & pictureBox6)
        private void label6_Click(object sender, EventArgs e)
        {
            // OpenForm(new Form8Status());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // OpenForm(new Form8Status());
        }

        // 6. Tombol Logout (label7 & pictureBox7)
        private void label7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        // Helper Method konsisten untuk perpindahan form
        private void OpenForm(Form targetForm)
        {
            this.Close();
            targetForm.Show();
        }

        private void Form5Maskapai_Load_1(object sender, EventArgs e)
        {

            dataGridMaskapai.AutoGenerateColumns = false;
            dataGridMaskapai.AllowUserToAddRows = false;
            dataGridMaskapai.ReadOnly = true;

            loadMaskapai();
        }

        private void loadMaskapai()
        {
            dataGridMaskapai.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList(); //Bisa langsung to list jika ingin ditampilkan sesuai dengan kolom ada dalam database
        }

        private void clearForm()
        {
            nameText.Clear();
            companyText.Clear();
            descriptionText.Clear();

            crewCount.Value = 1;
            idMaskapai = -1; //Reset ID maskapai yang sedang diedit
            saveBtn.Text = "Simpan"; //Ubah teks tombol menjadi "Simpan"
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Validasi isi textbox
            if (nameText.Text == "" || companyText.Text == "" || descriptionText.Text == "")
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validasi jumlah kru
            if (crewCount.Value < 1)
            {
                MessageBox.Show("Jumlah kru minimal 1.");
                return;
            }

            //Percabangan add / update
            if (idMaskapai == -1) //Add
            {
                Maskapai maskapaiBaru = new Maskapai();

                maskapaiBaru.Nama = nameText.Text;
                maskapaiBaru.Perusahaan = companyText.Text;
                maskapaiBaru.Deskripsi = descriptionText.Text;
                maskapaiBaru.JumlahKru = (int)crewCount.Value;

                db.Maskapais.Add(maskapaiBaru);
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            else //Update
            {
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);

                editMaskapai.Nama = nameText.Text;
                editMaskapai.Perusahaan = companyText.Text;
                editMaskapai.Deskripsi = descriptionText.Text;
                editMaskapai.JumlahKru = (int)crewCount.Value;
                MessageBox.Show("Data berhasil diperbarui!");

            }

            db.SaveChanges();
            loadMaskapai();
            clearForm();
        }

        private void dataGridMaskapai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridMaskapai.Columns[e.RowIndex].Name == "edit")
            {
                idMaskapai = (int)dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value;
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);
                nameText.Text = editMaskapai.Nama;
                companyText.Text = editMaskapai.Perusahaan;
                descriptionText.Text = editMaskapai.Deskripsi;
                crewCount.Value = editMaskapai.JumlahKru;
                saveBtn.Text = "Update"; //Ubah teks tombol menjadi "Update"
            }
            else if (dataGridMaskapai.Columns[e.RowIndex].Name == "delete")
            {
                int id = (int)dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value;

                var hasil = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(hasil == DialogResult.Yes)
                {
                    Maskapai hapusMaskapai = db.Maskapais.Find(id);
                    db.Maskapais.Remove(hapusMaskapai);
                    db.SaveChanges();

                    MessageBox.Show("Maskapai berhasil dihapus!");
                    loadMaskapai();
                    clearForm();
                }
            }
        }
    }
}