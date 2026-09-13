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
    public partial class iataTxt : Form
    {
        BandaraEntities db = new BandaraEntities(); //Membuat koneksi ke database
        private int idBandara = -1; //Menyimpan ID bandara yang sedang diedit (-1 mode Tambahj, jika > 0 Mode update)
        public iataTxt()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNegara(); //Menampilkan daftar rnegara ke ComboBox
            LoadBandara(); //Menampilkana semua data badara ke dalam DataGridView

            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.AllowUserToAddRows = false;
            dataGridBandara.ReadOnly = true;
        }

        private void LoadNegara()
        {
            countryBox.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();

            countryBox.DisplayMember = "Nama";
            countryBox.ValueMember = "ID";
            countryBox.SelectedIndex = -1;
        }

        private void LoadBandara()
        {
            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.DataSource = db.Bandaras.Include("Negara")
                                         .OrderBy(b => b.Nama)// urutkan berdasarkan nama, dari a - z 

                                         .Select(b => new //select() memilih kolom yang akan ditampilkan
                                         {
                                             b.ID,
                                             b.Nama,
                                             b.KodeIATA,
                                             b.Kota,
                                             Negara = b.Negara.Nama,
                                             b.JumlahTerminal,
                                             b.Alamat,
                                         }).ToList();
        }

        private void resetForm()
        {
            nameTxt.Clear();
            iataaTxt.Clear();
            cityTxt.Clear();
            addressTxt.Clear();
            countryBox.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1; //Kembali ke mode tambah data
            saveBtn.Text = "Simpan";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Validasi isi data
            if (nameTxt.Text == "" || iataaTxt.Text == "" || cityTxt.Text == "" || addressTxt.Text == "" || countryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            } 
            //Validasi panjang kode IATA
            if(iataaTxt.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA harus terdiri dari 3 huruf.");
                return;
            }

            //Semua karakter IATA harus berupa huruf
            if(!iataaTxt.Text.All(char.IsLetter)) //All() mengecek semua karakter
            {
                MessageBox.Show("Kode IATA harus berupa huruf.");
                return;
            }

            //Validasi IATA tidak boleh sama
            bool adaIATA = db.Bandaras
                           .Any(b => b.KodeIATA == iataaTxt.Text && b.ID != idBandara);

            if(adaIATA)
            {
                MessageBox.Show("Kode IATA sudah dipakai!");
                return;
            }

            //Validasi jumlah terminal
            if(terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah terminal harus lebih dari 0.");
                return;
            }

            //Validasi nama bandara harus unik
            bool adaBandara = db.Bandaras
                .Any(b => b.Nama.ToLower() == nameTxt.Text.ToLower() && b.ID != idBandara);

            if(adaBandara)
            {
                MessageBox.Show("Nama bandara sudah dipakai!");
                return;
            }

            //Percabangan Edit atau Add data
            if(idBandara == -1) //Add data
            {
                //Membuat object bandara baru
                Bandara bandara = new Bandara();

                bandara.Nama = nameTxt.Text;
                bandara.KodeIATA = iataaTxt.Text;
                bandara.Kota = cityTxt.Text;
                bandara.NegaraID = (int)countryBox.SelectedValue;
                bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandara.Alamat = addressTxt.Text;

                db.Bandaras.Add(bandara);
                MessageBox.Show("Data berhasil ditambahkan!");
            } 
            else //Edit
            {
                //Membuat object bandara baru
                Bandara editBandara = db.Bandaras.Find(idBandara);

                editBandara.Nama = nameTxt.Text;
                editBandara.KodeIATA = iataaTxt.Text;
                editBandara.Kota = cityTxt.Text;
                editBandara.NegaraID = (int)countryBox.SelectedValue;
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil diedit!");
            }

            
            db.SaveChanges();

            LoadBandara();
            resetForm();
        }

        private void dataGridBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // Error handling agar bukan header yang diklik
            {
                return;
            }

            // Edit dan Delete
            if (dataGridBandara.Columns[e.ColumnIndex].Name == "edit")
            {
                idBandara = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value); //Mengambil ID pada data grid
                Bandara bandaraEdit = db.Bandaras.Find(idBandara); //Ambil object bandara sesuai dengan ID yang dipilih

                //Menampilkan data ke dalam textbox dan combobox
                nameTxt.Text = bandaraEdit.Nama;
                iataaTxt.Text = bandaraEdit.KodeIATA;
                cityTxt.Text = bandaraEdit.Kota;
                addressTxt.Text = bandaraEdit.Alamat;
                countryBox.SelectedValue = bandaraEdit.NegaraID;
                terminalCount.Value = bandaraEdit.JumlahTerminal;
                saveBtn.Text = "Update";
            } else if (dataGridBandara.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    LoadBandara();
                    resetForm();
                }
            }
        }
    }
}
