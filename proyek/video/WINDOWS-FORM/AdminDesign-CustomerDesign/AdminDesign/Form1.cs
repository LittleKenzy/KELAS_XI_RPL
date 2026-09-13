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
    public partial class Form1 : Form
    {
        BandaraEntities db = new BandaraEntities(); //Koneksi ke database menggunakan Entity Framework
        public Form1()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            Form2Register register = new Form2Register();
            this.Hide();
            register.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Username dan password harus diisi!"); //Jika textbox kosong
                return; //proses login dihentikan
            }

            //cari akun berdasarkan username dan password
            var user = db.Akuns.FirstOrDefault(a => a.Username == usernameTxt.Text && a.Password == passwordTxt.Text);

            //cek user
            if (user != null) //jika user ditemukan
            {
             MessageBox.Show("Login Berhasil!"); //message box tampil
                                                 //asuk ke dashboard
                Form3Dashboard dashboard = new Form3Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else //jika user tidak ditemukan
            {
                MessageBox.Show("Password atau username salah!");
            }
        }
    }
}
