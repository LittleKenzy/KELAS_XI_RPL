using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class MasterJadwalForm : Form
    {
        private int selectedJadwalId = 0;

        public MasterJadwalForm()
        {
            InitializeComponent();
            SetupControls();
            LoadComboData();
            LoadDataGrid();
        }

        private void SetupControls()
        {
            numDurasi.Minimum = 1;
            numDurasi.Value = 60;
            numHarga.Minimum = 0;
            numHarga.Maximum = 100000000;
            numHarga.Increment = 1000;
            numHarga.DecimalPlaces = 0;

            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.CustomFormat = "dd-MM-yyyy";
            dtpWaktu.Format = DateTimePickerFormat.Time;

            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJadwal.MultiSelect = false;
            dgvJadwal.ReadOnly = true;
        }

        private void LoadComboData()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var bandaraListAsal = db.Bandaras.OrderBy(b => b.Kota).ToList();
                var bandaraListTujuan = db.Bandaras.OrderBy(b => b.Kota).ToList();

                cbKeberangkatan.DataSource = bandaraListAsal;
                cbKeberangkatan.DisplayMember = "KodeIATA";
                cbKeberangkatan.ValueMember = "ID";

                cbTujuan.DataSource = bandaraListTujuan;
                cbTujuan.DisplayMember = "KodeIATA";
                cbTujuan.ValueMember = "ID";

                cbMaskapai.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList();
                cbMaskapai.DisplayMember = "Nama";
                cbMaskapai.ValueMember = "ID";
            }
        }

        private void LoadDataGrid()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var jadwalList = db.JadwalPenerbangans
                    .Include(j => j.Bandara)
                    .Include(j => j.Bandara1)
                    .Include(j => j.Maskapai)
                    .OrderBy(j => j.KodePenerbangan)
                    .ToList()
                    .Select(j => new
                    {
                        j.ID,
                        j.KodePenerbangan,
                        Asal = j.Bandara != null ? j.Bandara.KodeIATA : "-",
                        Tujuan = j.Bandara1 != null ? j.Bandara1.KodeIATA : "-",
                        Maskapai = j.Maskapai != null ? j.Maskapai.Nama : "-",
                        j.TanggalWaktuKeberangkatan,
                        j.DurasiPenerbangan,
                        j.HargaPerTiket
                    }).ToList();

                dgvJadwal.DataSource = jadwalList;
                if (dgvJadwal.Columns["ID"] != null) dgvJadwal.Columns["ID"].Visible = false;
                if (dgvJadwal.Columns["btnUbah"] == null)
                {
                    var colUbah = new DataGridViewButtonColumn
                    {
                        Name = "btnUbah",
                        Text = "Ubah",
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvJadwal.Columns.Add(colUbah);
                }
                if (dgvJadwal.Columns["btnHapus"] == null)
                {
                    var colHapus = new DataGridViewButtonColumn
                    {
                        Name = "btnHapus",
                        Text = "Hapus",
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvJadwal.Columns.Add(colHapus);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string kode = txtKodePenerbangan.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(kode))
            {
                MessageBox.Show("Seluruh bidang input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbKeberangkatan.SelectedValue == null || cbTujuan.SelectedValue == null || cbMaskapai.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih bandara keberangkatan, tujuan, dan maskapai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bandaraAsalId = Convert.ToInt32(cbKeberangkatan.SelectedValue);
            int bandaraTujuanId = Convert.ToInt32(cbTujuan.SelectedValue);
            if (bandaraAsalId == bandaraTujuanId)
            {
                MessageBox.Show("Bandara keberangkatan dan tujuan tidak boleh sama!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new BromoAirlinesEntities())
            {
                bool isKodeExists = db.JadwalPenerbangans.Any(j => j.KodePenerbangan.ToLower() == kode.ToLower() && j.ID != selectedJadwalId);
                if (isKodeExists)
                {
                    MessageBox.Show("Kode penerbangan sudah digunakan!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime tglWaktuKeberangkatan = dtpTanggal.Value.Date + dtpWaktu.Value.TimeOfDay;

                if (selectedJadwalId == 0)
                {
                    JadwalPenerbangan newJadwal = new JadwalPenerbangan
                    {
                        KodePenerbangan = kode,
                        BandaraKeberangkatanID = bandaraAsalId,
                        BandaraTujuanID = bandaraTujuanId,
                        MaskapaiID = Convert.ToInt32(cbMaskapai.SelectedValue),
                        TanggalWaktuKeberangkatan = tglWaktuKeberangkatan,
                        DurasiPenerbangan = (int)numDurasi.Value,
                        HargaPerTiket = (decimal)numHarga.Value
                    };
                    db.JadwalPenerbangans.Add(newJadwal);
                }
                else
                {
                    JadwalPenerbangan existing = db.JadwalPenerbangans.Find(selectedJadwalId);
                    if (existing != null)
                    {
                        existing.KodePenerbangan = kode;
                        existing.BandaraKeberangkatanID = bandaraAsalId;
                        existing.BandaraTujuanID = bandaraTujuanId;
                        existing.MaskapaiID = Convert.ToInt32(cbMaskapai.SelectedValue);
                        existing.TanggalWaktuKeberangkatan = tglWaktuKeberangkatan;
                        existing.DurasiPenerbangan = (int)numDurasi.Value;
                        existing.HargaPerTiket = (decimal)numHarga.Value;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Data jadwal penerbangan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadDataGrid();
            }
        }

        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvJadwal.Rows[e.RowIndex].Cells["ID"].Value);

            if (dgvJadwal.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                selectedJadwalId = id;
                txtKodePenerbangan.Text = dgvJadwal.Rows[e.RowIndex].Cells["KodePenerbangan"].Value.ToString();

                using (var db = new BromoAirlinesEntities())
                {
                    var j = db.JadwalPenerbangans.Find(id);
                    if (j != null)
                    {
                        if (j.BandaraKeberangkatanID != null) cbKeberangkatan.SelectedValue = j.BandaraKeberangkatanID;
                        if (j.BandaraTujuanID != null) cbTujuan.SelectedValue = j.BandaraTujuanID;
                        if (j.MaskapaiID != null) cbMaskapai.SelectedValue = j.MaskapaiID;

                        if (j.TanggalWaktuKeberangkatan != null)
                        {
                            DateTime dt = j.TanggalWaktuKeberangkatan.Value;
                            dtpTanggal.Value = dt.Date;
                            dtpWaktu.Value = dt.Date + dt.TimeOfDay;
                        }

                        if (j.DurasiPenerbangan != null) numDurasi.Value = j.DurasiPenerbangan.Value;
                        if (j.HargaPerTiket != null) numHarga.Value = j.HargaPerTiket.Value;
                    }
                }
                btnSimpan.Text = "Update";
            }
            else if (dgvJadwal.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus jadwal penerbangan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new BromoAirlinesEntities())
                    {
                        var j = db.JadwalPenerbangans.Find(id);
                        if (j != null)
                        {
                            db.JadwalPenerbangans.Remove(j);
                            db.SaveChanges();
                            MessageBox.Show("Data jadwal penerbangan berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            LoadDataGrid();
                        }
                    }
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            selectedJadwalId = 0;
            txtKodePenerbangan.Clear();
            numDurasi.Value = 60;
            numHarga.Value = 0;
            dtpTanggal.Value = DateTime.Today;
            btnSimpan.Text = "Simpan";
            if (cbKeberangkatan.Items.Count > 0) cbKeberangkatan.SelectedIndex = 0;
            if (cbTujuan.Items.Count > 0) cbTujuan.SelectedIndex = 0;
            if (cbMaskapai.Items.Count > 0) cbMaskapai.SelectedIndex = 0;
        }
    }
}
