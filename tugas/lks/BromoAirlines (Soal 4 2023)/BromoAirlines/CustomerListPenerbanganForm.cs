using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class CustomerListPenerbanganForm : Form
    {
        public CustomerListPenerbanganForm()
        {
            InitializeComponent();
            ApplyStyles();
            SetupControls();
            LoadDataGrid();
        }

        private void ApplyStyles()
        {
            this.Text = "Daftar Penerbangan";
        }

        private void SetupControls()
        {
            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJadwal.MultiSelect = false;
            dgvJadwal.ReadOnly = true;
            btnBeli.BackColor = BromoColors.BromoMidBlue;
            btnBeli.ForeColor = BromoColors.BromoWhite;
            btnBeli.FlatStyle = FlatStyle.Flat;
        }

        private void LoadDataGrid()
        {
            try
            {
                using (var db = new BromoAirlinesEntities())
                {
                    var list = db.JadwalPenerbangans
                        .Include(j => j.Bandara)
                        .Include(j => j.Bandara1)
                        .Include(j => j.Maskapai)
                        .OrderBy(j => j.TanggalWaktuKeberangkatan)
                        .ToList();

                    string cari = txtCari.Text.Trim().ToLower();
                    if (!string.IsNullOrEmpty(cari))
                    {
                        list = list.Where(j =>
                            (j.KodePenerbangan != null && j.KodePenerbangan.ToLower().Contains(cari)) ||
                            (j.Bandara != null && j.Bandara.Nama.ToLower().Contains(cari)) ||
                            (j.Bandara1 != null && j.Bandara1.Nama.ToLower().Contains(cari)) ||
                            (j.Maskapai != null && j.Maskapai.Nama.ToLower().Contains(cari))
                        ).ToList();
                    }

                    var rows = list.Select(j => new
                    {
                        j.ID,
                        j.KodePenerbangan,
                        Asal = j.Bandara != null ? j.Bandara.KodeIATA + " - " + j.Bandara.Nama : "-",
                        Tujuan = j.Bandara1 != null ? j.Bandara1.KodeIATA + " - " + j.Bandara1.Nama : "-",
                        Maskapai = j.Maskapai != null ? j.Maskapai.Nama : "-",
                        j.TanggalWaktuKeberangkatan,
                        j.DurasiPenerbangan,
                        j.HargaPerTiket
                    }).ToList();

                    dgvJadwal.DataSource = rows;
                    if (dgvJadwal.Columns["ID"] != null) dgvJadwal.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih jadwal penerbangan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jadwalId = Convert.ToInt32(dgvJadwal.SelectedRows[0].Cells["ID"].Value);

            using (var form = new CustomerBeliTiketForm(jadwalId))
            {
                form.ShowDialog(this);
            }

            LoadDataGrid();
        }
    }
}
