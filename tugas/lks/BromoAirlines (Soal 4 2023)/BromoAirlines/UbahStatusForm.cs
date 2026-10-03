using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class UbahStatusForm : Form
    {
        private int selectedStatusId = 0;

        public UbahStatusForm()
        {
            InitializeComponent();
            SetupControls();
            LoadComboData();
            LoadDataGrid();
        }

        private void SetupControls()
        {
            numDelay.Minimum = 0;
            numDelay.Maximum = 1440;

            dgvPerubahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerubahan.MultiSelect = false;
            dgvPerubahan.ReadOnly = true;
        }

        private void LoadComboData()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var jadwalList = db.JadwalPenerbangans
                    .Include(j => j.Bandara)
                    .Include(j => j.Bandara1)
                    .OrderBy(j => j.KodePenerbangan)
                    .ToList()
                    .Select(j => new
                    {
                        j.ID,
                        Display = j.KodePenerbangan + " (" +
                                  (j.Bandara != null ? j.Bandara.KodeIATA : "-") + " → " +
                                  (j.Bandara1 != null ? j.Bandara1.KodeIATA : "-") + ")"
                    }).ToList();

                cboJadwal.DataSource = jadwalList;
                cboJadwal.DisplayMember = "Display";
                cboJadwal.ValueMember = "ID";

                cboStatus.DataSource = db.StatusPenerbangans.OrderBy(s => s.Nama).ToList();
                cboStatus.DisplayMember = "Nama";
                cboStatus.ValueMember = "ID";
            }
        }

        private void LoadDataGrid()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var list = db.PerubahanStatusJadwalPenerbangans
                    .Include(p => p.JadwalPenerbangan)
                    .Include(p => p.StatusPenerbangan)
                    .OrderByDescending(p => p.WaktuPerubahanTerjadi)
                    .ToList();

                var rows = list.Select(p => new
                {
                    p.ID,
                    Penerbangan = p.JadwalPenerbangan != null ? p.JadwalPenerbangan.KodePenerbangan : "-",
                    Status = p.StatusPenerbangan != null ? p.StatusPenerbangan.Nama : "-",
                    p.WaktuPerubahanTerjadi,
                    p.PerkiraanWaktuDelay
                }).ToList();

                dgvPerubahan.DataSource = rows;
                if (dgvPerubahan.Columns["ID"] != null) dgvPerubahan.Columns["ID"].Visible = false;
                if (dgvPerubahan.Columns["btnUbah"] == null)
                {
                    var colUbah = new DataGridViewButtonColumn
                    {
                        Name = "btnUbah",
                        Text = "Ubah",
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvPerubahan.Columns.Add(colUbah);
                }
                if (dgvPerubahan.Columns["btnHapus"] == null)
                {
                    var colHapus = new DataGridViewButtonColumn
                    {
                        Name = "btnHapus",
                        Text = "Hapus",
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvPerubahan.Columns.Add(colHapus);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cboJadwal.SelectedValue == null || cboStatus.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih jadwal penerbangan dan status penerbangan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new BromoAirlinesEntities())
            {
                if (selectedStatusId == 0)
                {
                    PerubahanStatusJadwalPenerbangan newStatus = new PerubahanStatusJadwalPenerbangan
                    {
                        JadwalPenerbanganID = Convert.ToInt32(cboJadwal.SelectedValue),
                        StatusPenerbanganID = Convert.ToInt32(cboStatus.SelectedValue),
                        WaktuPerubahanTerjadi = dtpWaktuPerubahan.Value,
                        PerkiraanWaktuDelay = (int)numDelay.Value
                    };
                    db.PerubahanStatusJadwalPenerbangans.Add(newStatus);
                }
                else
                {
                    PerubahanStatusJadwalPenerbangan existing = db.PerubahanStatusJadwalPenerbangans.Find(selectedStatusId);
                    if (existing != null)
                    {
                        existing.JadwalPenerbanganID = Convert.ToInt32(cboJadwal.SelectedValue);
                        existing.StatusPenerbanganID = Convert.ToInt32(cboStatus.SelectedValue);
                        existing.WaktuPerubahanTerjadi = dtpWaktuPerubahan.Value;
                        existing.PerkiraanWaktuDelay = (int)numDelay.Value;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Status penerbangan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadDataGrid();
            }
        }

        private void dgvPerubahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvPerubahan.Rows[e.RowIndex].Cells["ID"].Value);

            if (dgvPerubahan.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                selectedStatusId = id;

                using (var db = new BromoAirlinesEntities())
                {
                    var p = db.PerubahanStatusJadwalPenerbangans.Find(id);
                    if (p != null)
                    {
                        if (p.JadwalPenerbanganID != null) cboJadwal.SelectedValue = p.JadwalPenerbanganID;
                        if (p.StatusPenerbanganID != null) cboStatus.SelectedValue = p.StatusPenerbanganID;
                        if (p.WaktuPerubahanTerjadi != null) dtpWaktuPerubahan.Value = p.WaktuPerubahanTerjadi.Value;
                        if (p.PerkiraanWaktuDelay != null) numDelay.Value = p.PerkiraanWaktuDelay.Value;
                    }
                }
                btnSimpan.Text = "Update";
            }
            else if (dgvPerubahan.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus perubahan status ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new BromoAirlinesEntities())
                    {
                        var p = db.PerubahanStatusJadwalPenerbangans.Find(id);
                        if (p != null)
                        {
                            db.PerubahanStatusJadwalPenerbangans.Remove(p);
                            db.SaveChanges();
                            MessageBox.Show("Perubahan status berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectedStatusId = 0;
            numDelay.Value = 0;
            dtpWaktuPerubahan.Value = DateTime.Now;
            btnSimpan.Text = "Simpan";
            if (cboJadwal.Items.Count > 0) cboJadwal.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
        }
    }
}
