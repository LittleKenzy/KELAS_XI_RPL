using SMKNusantaraApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMKNusantaraApp
{
    public partial class MasterClassForm : Form
    {
        private SmknusantaraDbContext db = new SmknusantaraDbContext();
        private int selectedClassId = 0;
        public MasterClassForm()
        {
            InitializeComponent();
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            dgvClass.DataSource = db.Classes.Select(c => new
            {
                c.ClassId,
                c.Name
            }).ToList();

        }

        private void ClearForm()
        {
            txtClassID.Text = "";
            txtName.Text = "";
            selectedClassId = 0;
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClass.Rows[e.RowIndex];
                selectedClassId = Convert.ToInt32(row.Cells["ClassId"].Value);
                txtClassID.Text = selectedClassId.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Nama kelas wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Class cls = new Class { Name = txtName.Text };
            db.Classes.Add(cls);
            db.SaveChanges();

            MessageBox.Show("Data kelas berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedClassId == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cls = db.Classes.FirstOrDefault(c => c.ClassId == selectedClassId);
            if (cls != null)
            {
                cls.Name = txtName.Text.Trim();
                db.SaveChanges();

                MessageBox.Show("Data class berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedClassId == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menhapus kelas ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var cls = db.Classes.FirstOrDefault(c => c.ClassId == selectedClassId);
                if (cls != null)
                {
                    db.Classes.Remove(cls);
                    db.SaveChanges();

                    MessageBox.Show("Data kelas berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminNavigationForm adminNav = new AdminNavigationForm();
            adminNav.Show();
            this.Close();
        }
    }
}
