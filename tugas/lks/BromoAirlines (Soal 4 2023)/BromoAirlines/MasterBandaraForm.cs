using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class MasterBandaraForm : Form
    {
        private int selectedBandaraId = 0;

        public MasterBandaraForm()
        {
            InitializeComponent();
            SetupControls();
            LoadNegaraComboBox();
            LoadDataGrid();
        }

        private void SetupControls()
        {
            numTerminal.Minimum = 1;
            numTerminal.Value = 1;
            dgvBandara.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBandara.MultiSelect = false;
            dgvBandara.ReadOnly = true;
            dgvBandara.CellContentClick += dgvBandara_CellContentClick;
        }

        private void LoadNegaraComboBox()
        {
            using (var db = new BromoAirlinesEntities())
            {
                cmbNegara.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();
                cmbNegara.DisplayMember = "Nama";
                cmbNegara.ValueMember = "ID";
            }
        }

        private void LoadDataGrid()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var bandaraList = db.Bandaras.OrderBy(b => b.Nama).Select(b => new
                {
                    b.ID,
                    b.Nama,
                    b.KodeIATA,
                    b.Kota,
                    Negara = b.Negara.Nama,
                    b.JumlahTerminal,
                    b.Alamat
                }).ToList();

                dgvBandara.DataSource = bandaraList;
                if (dgvBandara.Columns["ID"] != null) dgvBandara.Columns["ID"].Visible = false;
                if (dgvBandara.Columns["btnUbah"] == null)
                {
                    var colUbah = new DataGridViewButtonColumn
                    {
                        Name = "btnUbah",
                        Text = "Ubah",
                        UseColumnTextForButtonValue = true,
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvBandara.Columns.Add(colUbah);
                }
                if (dgvBandara.Columns["btnHapus"] == null)
                {
                    var colHapus = new DataGridViewButtonColumn
                    {
                        Name = "btnHapus",
                        Text = "Hapus",
                        UseColumnTextForButtonValue = true,
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvBandara.Columns.Add(colHapus);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string iata = txtKodeIATA.Text.Trim().ToUpper();
            string kota = txtKota.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            int negaraId = (int)cmbNegara.SelectedValue;
            int terminal = (int)numTerminal.Value;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(iata) || string.IsNullOrEmpty(kota) || string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Seluruh bidang input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (iata.Length != 3 || !Regex.IsMatch(iata, @"^[A-Z]{3}$"))
            {
                MessageBox.Show("Kode IATA harus tepat 3 huruf kapital!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new BromoAirlinesEntities())
            {
                bool isNameExists = db.Bandaras.Any(b => b.Nama.ToLower() == nama.ToLower() && b.ID != selectedBandaraId);
                if (isNameExists)
                {
                    MessageBox.Show("Nama Bandaras sudah digunakan!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isIataExists = db.Bandaras.Any(b => b.KodeIATA == iata && b.ID != selectedBandaraId);
                if (isIataExists)
                {
                    MessageBox.Show("Kode IATA sudah terdaftar!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedBandaraId == 0)
                {
                    Bandara newBandara = new Bandara
                    {
                        Nama = nama,
                        KodeIATA = iata,
                        Kota = kota,
                        NegaraID = negaraId,
                        JumlahTerminal = terminal,
                        Alamat = alamat
                    };
                    db.Bandaras.Add(newBandara);
                }
                else
                {
                    Bandara existing = db.Bandaras.Find(selectedBandaraId);
                    if (existing != null)
                    {
                        existing.Nama = nama;
                        existing.KodeIATA = iata;
                        existing.Kota = kota;
                        existing.NegaraID = negaraId;
                        existing.JumlahTerminal = terminal;
                        existing.Alamat = alamat;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Data bandara berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadDataGrid();
            }
        }

        private void dgvBandara_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvBandara.Rows[e.RowIndex].Cells["ID"].Value);

            if (dgvBandara.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                selectedBandaraId = id;
                txtNama.Text = dgvBandara.Rows[e.RowIndex].Cells["Nama"].Value.ToString();
                txtKodeIATA.Text = dgvBandara.Rows[e.RowIndex].Cells["KodeIATA"].Value.ToString();
                txtKota.Text = dgvBandara.Rows[e.RowIndex].Cells["Kota"].Value.ToString();
                txtAlamat.Text = dgvBandara.Rows[e.RowIndex].Cells["Alamat"].Value.ToString();
                numTerminal.Value = Convert.ToInt32(dgvBandara.Rows[e.RowIndex].Cells["JumlahTerminal"].Value);

                using (var db = new BromoAirlinesEntities())
                {
                    var b = db.Bandaras.Find(id);
                    if (b != null) cmbNegara.SelectedValue = b.NegaraID;
                }
                btnSimpan.Text = "Update";
            }
            else if (dgvBandara.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus bandara ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new BromoAirlinesEntities())
                    {
                        var b = db.Bandaras.Find(id);
                        if (b != null)
                        {
                            db.Bandaras.Remove(b);
                            db.SaveChanges();
                            MessageBox.Show("Data bandara berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ResetForm()
        {
            selectedBandaraId = 0;
            txtNama.Clear();
            txtKodeIATA.Clear();
            txtKota.Clear();
            txtAlamat.Clear();
            numTerminal.Value = 1;
            btnSimpan.Text = "Simpan";
            if (cmbNegara.Items.Count > 0) cmbNegara.SelectedIndex = 0;
        }
    }
}