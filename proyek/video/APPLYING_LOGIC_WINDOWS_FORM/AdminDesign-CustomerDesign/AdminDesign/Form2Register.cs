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
    public partial class Form2Register : Form
    {
        BandaraEntities db = new BandaraEntities(); //Membuat koneksi ke database
        public Form2Register()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        private void daftarBtn_Click(object sender, EventArgs e) //tempat logic simpan user
        {
            //Cek semua TextBox sudah diisi
            if (usernameTxt.Text == "" || nameTxt.Text == "" || lahirDate.Value.Date ==  DateTime.Today || phoneTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Tolong lengkapi semua data yang diperlukan untuk membuat akun baru");
                return;
            }

            //Username harus unik
            bool usernameSudahAda = db.Akuns.Any(a => a.Username == usernameTxt.Text);

            if (usernameSudahAda)
            {
                MessageBox.Show("Username sudah digunakan,");
                return;
            }

            //Validasi nomor telepon
            if(!phoneTxt.Text.All(char.IsDigit)) //Jika nomor telepon terdapat huruf atau simbol lainnya
            {
                MessageBox.Show("Nomor telepon harus berupa angka.");
                return;
            }

            if (phoneTxt.Text.Length < 10 || phoneTxt.Text.Length > 15) //Nomor telepon harus lebih dari 10
              //dan tidak boleh lebih dari 15 karakter
            {
                MessageBox.Show("Nomor telepon harus terdiri dari 10 hingga 15 digit.");
                return;
            }

            //Validasi password
            if(passwordTxt.Text.Length < 0)
            {
                MessageBox.Show("Password minimal 8 karakter");
                return;
            }

            //validasi tanggal lahir (Fitur tambahan)
            int umur = DateTime.Now.Year - lahirDate.Value.Year;

            //Jika ulang tahun ini belum lewat (belum genap)
            if (lahirDate.Value.Date > DateTime.Today.AddYears(-umur)) ; //menyamakan tahun ini dengan tahun lahir agar bisa menghitung genap nya tanggal lahir
            {
                umur--; //Mengurangi 1 jika ulang tahun belum terlewat (belum genap)
            }

            if (umur < 17) //Validasi minimal 17 tahun untuk membuat akun
            {
                MessageBox.Show("Umur minimal 17 tahun!");
                return;
            }
        }
    }
}
