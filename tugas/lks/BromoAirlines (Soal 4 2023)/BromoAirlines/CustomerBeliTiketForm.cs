using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class CustomerBeliTiketForm : Form
    {
        private int fixedJadwalId = 0;
        private decimal currentHarga = 0;

        public CustomerBeliTiketForm()
        {
            InitializeComponent();
            ApplyStyles();
            SetupControls();
            LoadJadwal();
            LoadPromo();
        }

        public CustomerBeliTiketForm(int jadwalId)
            : this()
        {
            fixedJadwalId = jadwalId;
        }

        private void ApplyStyles()
        {
            this.Text = "Beli Tiket";
            btnSimpan.BackColor = BromoColors.BromoMidBlue;
            btnSimpan.ForeColor = BromoColors.BromoWhite;
            btnSimpan.FlatStyle = FlatStyle.Flat;
        }

        private void SetupControls()
        {
            dgvPenumpang.Columns.Add("cboTitel", "Titel");
            dgvPenumpang.Columns["cboTitel"].Width = 80;
            var colTitel = (DataGridViewComboBoxColumn)dgvPenumpang.Columns["cboTitel"];
            colTitel.Items.AddRange(new object[] { "Mr.", "Mrs.", "Ms.", "Bc." });
            colTitel.FlatStyle = FlatStyle.Flat;

            var colNama = new DataGridViewTextBoxColumn
            {
                Name = "txtNama",
                HeaderText = "Nama Lengkap",
                Width = 280
            };
            dgvPenumpang.Columns.Add(colNama);

            dgvPenumpang.AllowUserToAddRows = false;
            dgvPenumpang.MultiSelect = false;
        }

        private void LoadJadwal()
        {
            try
            {
                using (var db = new BromoAirlinesEntities())
                {
                    var list = db.JadwalPenerbangans
                        .Include(j => j.Bandara)
                        .Include(j => j.Bandara1)
                        .Include(j => j.Maskapai)
                        .Where(j => j.TanggalWaktuKeberangkatan >= DateTime.Today)
                        .OrderBy(j => j.TanggalWaktuKeberangkatan)
                        .ToList();

                    if (fixedJadwalId != 0)
                    {
                        list = list.Where(j => j.ID == fixedJadwalId).ToList();
                    }

                    var rows = list.Select(j => new
                    {
                        j.ID,
                        j.HargaPerTiket,
                        Display = j.KodePenerbangan + " | " +
                                  (j.Bandara != null ? j.Bandara.KodeIATA : "-") + " → " +
                                  (j.Bandara1 != null ? j.Bandara1.KodeIATA : "-") + " | " +
                                  (j.Maskapai != null ? j.Maskapai.Nama : "-") + " | " +
                                  (j.TanggalWaktuKeberangkatan != null ? j.TanggalWaktuKeberangkatan.Value.ToString("dd-MM-yyyy HH:mm") : "-")
                    }).ToList();

                    cboJadwal.DataSource = rows;
                    cboJadwal.DisplayMember = "Display";
                    cboJadwal.ValueMember = "ID";

                    if (rows.Count > 0)
                    {
                        cboJadwal.SelectedIndex = 0;
                        UpdateJadwalInfo();
                    }
                    else
                    {
                        lblJadwalInfo.Text = "Belum ada jadwal penerbangan tersedia.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPromo()
        {
            try
            {
                using (var db = new BromoAirlinesEntities())
                {
                    var rows = db.KodePromoes
                        .Where(p => p.BerlakuSampai >= DateTime.Today)
                        .OrderBy(p => p.Kode)
                        .Select(p => new
                        {
                            p.ID,
                            p.PresentaseDiskon,
                            Display = p.Kode + " (" + (p.PresentaseDiskon ?? 0).ToString("0.#") + "%)"
                        }).ToList();

                    cboKodePromo.DataSource = rows;
                    cboKodePromo.DisplayMember = "Display";
                    cboKodePromo.ValueMember = "ID";
                    cboKodePromo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat promo: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateJadwalInfo()
        {
            if (cboJadwal.SelectedValue == null) return;

            int jadwalId = Convert.ToInt32(cboJadwal.SelectedValue);
            using (var db = new BromoAirlinesEntities())
            {
                var j = db.JadwalPenerbangans
                    .Include(x => x.Bandara)
                    .Include(x => x.Bandara1)
                    .Include(x => x.Maskapai)
                    .FirstOrDefault(x => x.ID == jadwalId);

                if (j != null)
                {
                    currentHarga = j.HargaPerTiket ?? 0;
                    lblJadwalInfo.Text =
                        "Kode Penerbangan : " + j.KodePenerbangan + "\n" +
                        "Rute             : " + (j.Bandara != null ? j.Bandara.Nama : "-") + " → " + (j.Bandara1 != null ? j.Bandara1.Nama : "-") + "\n" +
                        "Maskapai         : " + (j.Maskapai != null ? j.Maskapai.Nama : "-") + "\n" +
                        "Berangkat        : " + (j.TanggalWaktuKeberangkatan != null ? j.TanggalWaktuKeberangkatan.Value.ToString("dd-MM-yyyy HH:mm") : "-") + "\n" +
                        "Harga per Tiket  : Rp " + currentHarga.ToString("N0");
                }
            }

            HitungTotal();
        }

        private decimal GetDiscountPercent()
        {
            if (cboKodePromo.SelectedValue == null) return 0;
            using (var db = new BromoAirlinesEntities())
            {
                var promo = db.KodePromoes.FirstOrDefault(p => p.ID == (int)cboKodePromo.SelectedValue);
                if (promo != null && promo.BerlakuSampai >= DateTime.Today)
                {
                    return promo.PresentaseDiskon ?? 0;
                }
            }
            return 0;
        }

        private void HitungTotal()
        {
            int jumlah = dgvPenumpang.Rows.Count;
            decimal subtotal = currentHarga * jumlah;
            decimal persenDiskon = GetDiscountPercent();
            decimal diskon = subtotal * persenDiskon / 100;

            lblTotalHarga.Text = "Subtotal      : Rp " + subtotal.ToString("N0") +
                                 "\nDiskon (" + persenDiskon.ToString("0.#") + "%) : -Rp " + diskon.ToString("N0") +
                                 "\nTOTAL HARGA : Rp " + (subtotal - diskon).ToString("N0");
        }

        private void btnTambahPenumpang_Click(object sender, EventArgs e)
        {
            dgvPenumpang.Rows.Add("Mr.", "");
            HitungTotal();
        }

        private void btnHapusPenumpang_Click(object sender, EventArgs e)
        {
            if (dgvPenumpang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih penumpang yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvPenumpang.Rows.RemoveAt(dgvPenumpang.SelectedRows[0].Index);
            HitungTotal();
        }

        private void cboJadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJadwalInfo();
        }

        private void cboKodePromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cboJadwal.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih jadwal penerbangan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jumlahPenumpang = dgvPenumpang.Rows.Count;
            if (jumlahPenumpang == 0)
            {
                MessageBox.Show("Tambahkan minimal satu penumpang terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvPenumpang.Rows)
            {
                string nama = row.Cells["txtNama"].Value != null ? row.Cells["txtNama"].Value.ToString().Trim() : "";
                if (string.IsNullOrEmpty(nama))
                {
                    MessageBox.Show("Nama lengkap penumpang belum diisikan semua!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                int jadwalId = Convert.ToInt32(cboJadwal.SelectedValue);
                decimal totalHarga;
                decimal persenDiskon = GetDiscountPercent();
                decimal subtotal = currentHarga * jumlahPenumpang;
                totalHarga = subtotal - (subtotal * persenDiskon / 100);

                using (var db = new BromoAirlinesEntities())
                {
                    TransaksiHeader header = new TransaksiHeader
                    {
                        AkunID = CurrentUser.ID,
                        TanggalTransaksi = DateTime.Now,
                        JadwalPenerbanganID = jadwalId,
                        JumlahPenumpang = jumlahPenumpang,
                        TotalHarga = totalHarga,
                        KodePromoID = cboKodePromo.SelectedValue != null ? Convert.ToInt32(cboKodePromo.SelectedValue) : (int?)null
                    };

                    db.TransaksiHeaders.Add(header);
                    db.SaveChanges();

                    foreach (DataGridViewRow row in dgvPenumpang.Rows)
                    {
                        string titel = row.Cells["cboTitel"].Value != null ? row.Cells["cboTitel"].Value.ToString() : "Mr.";
                        string nama = row.Cells["txtNama"].Value != null ? row.Cells["txtNama"].Value.ToString().Trim() : "";

                        db.TransaksiDetails.Add(new TransaksiDetail
                        {
                            TransaksiHeaderID = header.ID,
                            TitelPenumpang = titel,
                            NamaLengkapPenumpang = nama
                        });
                    }

                    db.SaveChanges();

                    MessageBox.Show("Pemesanan tiket berhasil!\nNomor Transaksi : " + header.ID +
                                    "\nTotal Harga : Rp " + totalHarga.ToString("N0"),
                                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memesan tiket: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetForm()
        {
            while (dgvPenumpang.Rows.Count > 0)
            {
                dgvPenumpang.Rows.RemoveAt(0);
            }
            cboKodePromo.SelectedIndex = -1;
            currentHarga = 0;
            HitungTotal();
        }
    }
}
