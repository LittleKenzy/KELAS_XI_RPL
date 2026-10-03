using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines
{
    public partial class MasterMaskapaiForm : Form
    {
        private int selectedMaskapaiId = 0;
        public MasterMaskapaiForm()
        {
            InitializeComponent();
            SetupControls();
            LoadDataGrid();
        }

        private void SetupControls()
        {
            numKru.Minimum = 1;
            numKru.Value = 1;
            dgvMaskapai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaskapai.ReadOnly = true;
        }

        private void LoadDataGrid()
        {
            using (var db = new BromoAirlinesEntities())
            {
                var maskapaiList = db.Maskapais.OrderBy(m => m.Nama).Select(m => new
                {
                    m.ID,
                    m.Nama,
                    m.Perusahaan,
                    m.JumlahKru,
                    m.Deskripsi
                }).ToList();

                dgvMaskapai.DataSource = maskapaiList;
                if (dgvMaskapai.Columns["ID"] != null) dgvMaskapai.Columns["ID"].Visible = false;

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string perusahaan = txtPerusahaan.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();
            int jumlahKru = (int)numKru.Value;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(perusahaan) || string.IsNullOrEmpty(deskripsi))
            {
                MessageBox.Show("Semua bidang input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new BromoAirlinesEntities())
            {
                if(selectedMaskapaiId == 0)
                {
                    Maskapai m = new Maskapai
                    {
                        Nama = nama,
                        Perusahaan = perusahaan,
                        JumlahKru = jumlahKru,
                        Deskripsi = deskripsi
                    };
                    db.Maskapais.Add(m);
                }
                else
                {
                    Maskapai m = db.Maskapais.Find(selectedMaskapaiId);
                    if(m!= null)
                    {
                        m.Nama = nama; ;
                        m.Perusahaan = perusahaan;
                        m.JumlahKru = jumlahKru;
                        m.Deskripsi = deskripsi;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Data maskapai berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadDataGrid();
            }

        }

        private void dgvMaskapai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

            if (dgvMaskapai.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                selectedMaskapaiId = id;
                txtNama.Text = dgvMaskapai.Rows[e.RowIndex].Cells["Nama"].Value.ToString();
                txtPerusahaan.Text = dgvMaskapai.Rows[e.RowIndex].Cells["Deskripsi"].Value.ToString();
                numKru.Value = Convert.ToInt32(dgvMaskapai.Rows[e.RowIndex].Cells["JumlahKru"].Value);
                btnSimpan.Text = "Update";
            }
            else if (dgvMaskapai.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                if(MessageBox.Show("Apakah anda yakin ingin menghapus maskapai ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using(var db = new BromoAirlinesEntities())
                    {
                        var m = db.Maskapais.Find(id);
                        if (m != null)
                        {
                            db.Maskapais.Remove(m);
                            db.SaveChanges();
                            MessageBox.Show("Data maskapai berhasil di hapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectedMaskapaiId = 0;
            txtNama.Clear();
            txtPerusahaan.Clear();
            txtDeskripsi.Clear();
            numKru.Value = 1;
            btnSimpan.Text = "Simpan";
        }
    }
}
