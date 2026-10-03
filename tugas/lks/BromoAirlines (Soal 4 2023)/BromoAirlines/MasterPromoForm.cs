using System;
using System.Linq;
using System.Windows.Forms;
using BromoAirlines.Helpers;

namespace BromoAirlines
{
    public partial class MasterPromoForm : Form
    {
        private int selectedPromoId = 0;

        public MasterPromoForm()
        {
            InitializeComponent();
            SetupControls();
            LoadDataGrid();
        }

        private void SetupControls()
        {
            numPresentase.Minimum = 0;
            numPresentase.Maximum = 100;
            numPresentase.DecimalPlaces = 2;

            dtpBerlakuSampai.Format = DateTimePickerFormat.Custom;
            dtpBerlakuSampai.CustomFormat = "dd-MM-yyyy";

            dgvPromo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromo.MultiSelect = false;
            dgvPromo.ReadOnly = true;
        }

        private void LoadDataGrid()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var promoList = db.KodePromoes.OrderBy(p => p.Kode).Select(p => new
                {
                    p.ID,
                    p.Kode,
                    p.PresentaseDiskon,
                    p.BerlakuSampai,
                    p.Deskripsi
                }).ToList();

                dgvPromo.DataSource = promoList;
                if (dgvPromo.Columns["ID"] != null) dgvPromo.Columns["ID"].Visible = false;
                if (dgvPromo.Columns["btnUbah"] == null)
                {
                    var colUbah = new DataGridViewButtonColumn
                    {
                        Name = "btnUbah",
                        Text = "Ubah",
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvPromo.Columns.Add(colUbah);
                }
                if (dgvPromo.Columns["btnHapus"] == null)
                {
                    var colHapus = new DataGridViewButtonColumn
                    {
                        Name = "btnHapus",
                        Text = "Hapus",
                        Width = 60,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    dgvPromo.Columns.Add(colHapus);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string kode = txtKode.Text.Trim().ToUpper();
            string deskripsi = txtDeskripsi.Text.Trim();

            if (string.IsNullOrEmpty(kode) || string.IsNullOrEmpty(deskripsi))
            {
                MessageBox.Show("Seluruh bidang input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numPresentase.Value < 0 || numPresentase.Value > 100)
            {
                MessageBox.Show("Presentase diskon harus antara 0 hingga 100!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new BromoAirlinesEntities())
            {
                bool isKodeExists = db.KodePromoes.Any(p => p.Kode.ToLower() == kode.ToLower() && p.ID != selectedPromoId);
                if (isKodeExists)
                {
                    MessageBox.Show("Kode promo sudah digunakan!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedPromoId == 0)
                {
                    KodePromo newPromo = new KodePromo
                    {
                        Kode = kode,
                        PresentaseDiskon = numPresentase.Value,
                        BerlakuSampai = dtpBerlakuSampai.Value.Date,
                        Deskripsi = deskripsi
                    };
                    db.KodePromoes.Add(newPromo);
                }
                else
                {
                    KodePromo existing = db.KodePromoes.Find(selectedPromoId);
                    if (existing != null)
                    {
                        existing.Kode = kode;
                        existing.PresentaseDiskon = numPresentase.Value;
                        existing.BerlakuSampai = dtpBerlakuSampai.Value.Date;
                        existing.Deskripsi = deskripsi;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Data kode promo berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadDataGrid();
            }
        }

        private void dgvPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvPromo.Rows[e.RowIndex].Cells["ID"].Value);

            if (dgvPromo.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                selectedPromoId = id;
                txtKode.Text = dgvPromo.Rows[e.RowIndex].Cells["Kode"].Value.ToString();
                numPresentase.Value = Convert.ToDecimal(dgvPromo.Rows[e.RowIndex].Cells["PresentaseDiskon"].Value);
                txtDeskripsi.Text = dgvPromo.Rows[e.RowIndex].Cells["Deskripsi"].Value.ToString();

                using (var db = new BromoAirlinesEntities())
                {
                    var p = db.KodePromoes.Find(id);
                    if (p != null && p.BerlakuSampai != null)
                    {
                        dtpBerlakuSampai.Value = p.BerlakuSampai.Value.Date;
                    }
                }
                btnSimpan.Text = "Update";
            }
            else if (dgvPromo.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus kode promo ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new BromoAirlinesEntities())
                    {
                        var p = db.KodePromoes.Find(id);
                        if (p != null)
                        {
                            db.KodePromoes.Remove(p);
                            db.SaveChanges();
                            MessageBox.Show("Data kode promo berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectedPromoId = 0;
            txtKode.Clear();
            txtDeskripsi.Clear();
            numPresentase.Value = 0;
            dtpBerlakuSampai.Value = DateTime.Today;
            btnSimpan.Text = "Simpan";
        }
    }
}
