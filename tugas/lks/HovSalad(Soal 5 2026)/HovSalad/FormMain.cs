using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSalad
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetupFormProperties();
            InitTimer();
        }

        //1.Pengaturan properti form sesuai spesifikasi teknis
        private void SetupFormProperties()
        {
            this.Text = "HovSalad";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //set ikon aplikasi
            try
            {
                this.Icon = new Icon("icon.ico");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading icon: " + ex.Message);
            }
        }

        private void InitTimer()
        {
            //jalankan perbaruan waktu pertama kali saat form dimuat
            UpdateDateTimeLabel();

            ///set interval timer ke 1000 ms (1 detik)
            timerClock.Interval = 1000;
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void UpdateDateTimeLabel()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, d MMMM yyyy HH:mm:ss");
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            //matikan timer agar tidak berjalan di background saat form tersembunyi
            timerClock.Stop();

            //buka order form
            FormOrder formOrder = new FormOrder();
            //sembunyikan main form
            this.Hide();

            //tampikan order form secara modal/dialog atau tangani event formClosed
            formOrder.FormClosed += (s, args) =>
            {
                //hidupkan kembali timer dan tampilkan main form saat order form ditutup
                timerClock.Start();
                UpdateDateTimeLabel();
                this.Show();
            };
            formOrder.Show();
        }
    }
    }
