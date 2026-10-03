using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class CustomerTiketSayaForm : Form
    {
        public CustomerTiketSayaForm()
        {
            InitializeComponent();
            ApplyStyles();
            SetupControls();
            LoadDataGrid();
        }

        private void ApplyStyles()
        {
            this.Text = "Tiket Saya";
        }

        private void SetupControls()
        {
            dgvTiket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiket.MultiSelect = false;
            dgvTiket.ReadOnly = true;
        }

        private void LoadDataGrid()
        {
            try
            {
                using (var db = new BromoAirlinesEntities())
                {
                    var list = db.TransaksiHeaders
                        .Include(t => t.JadwalPenerbangan)
                        .Include(t => t.JadwalPenerbangan.Bandara)
                        .Include(t => t.JadwalPenerbangan.Bandara1)
                        .Include(t => t.JadwalPenerbangan.Maskapai)
                        .Include(t => t.KodePromo)
                        .Include(t => t.TransaksiDetails)
                        .Where(t => t.AkunID == CurrentUser.ID)
                        .OrderByDescending(t => t.TanggalTransaksi)
                        .ToList();

                    var rows = list.Select(t => new
                    {
                        t.ID,
                        t.TanggalTransaksi,
                        Penerbangan = t.JadwalPenerbangan != null ? t.JadwalPenerbangan.KodePenerbangan : "-",
                        Rute = (t.JadwalPenerbangan != null && t.JadwalPenerbangan.Bandara != null ? t.JadwalPenerbangan.Bandara.KodeIATA : "-") +
                               " → " +
                               (t.JadwalPenerbangan != null && t.JadwalPenerbangan.Bandara1 != null ? t.JadwalPenerbangan.Bandara1.KodeIATA : "-"),
                        Maskapai = t.JadwalPenerbangan != null && t.JadwalPenerbangan.Maskapai != null ? t.JadwalPenerbangan.Maskapai.Nama : "-",
                        JadwalKeberangkatan = t.JadwalPenerbangan != null ? t.JadwalPenerbangan.TanggalWaktuKeberangkatan : (DateTime?)null,
                        t.JumlahPenumpang,
                        t.TotalHarga,
                        KodePromo = t.KodePromo != null ? t.KodePromo.Kode : "-",
                        Penumpang = string.Join(", ", t.TransaksiDetails.Select(d =>
                            (d.TitelPenumpang != null ? d.TitelPenumpang + " " : "") + d.NamaLengkapPenumpang))
                    }).ToList();

                    dgvTiket.DataSource = rows;
                    if (dgvTiket.Columns["ID"] != null) dgvTiket.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
    }
}
