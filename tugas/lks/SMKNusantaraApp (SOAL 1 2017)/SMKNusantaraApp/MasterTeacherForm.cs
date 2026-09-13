using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class MasterTeacherForm : Form
    {
        private SmknusantaraDbContext db = Database.DB;
        private int selectedTeacherId = -1;
        public MasterTeacherForm()
        {
            InitializeComponent();
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            dgvTeacher.DataSource = db.Teachers.Select(t => new
            {
                t.TeacherId,
                t.Name,
                t.Gender
            }).ToList();
        }

        private void ClearForm()
        {
            txtTeacherID.Text = "";
            txtName.Text = "";
            cmbGender.SelectedIndex = -1;
            selectedTeacherId = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeacher.Rows[e.RowIndex];
                selectedTeacherId = Convert.ToInt32(row.Cells["TeacherId"].Value);
                txtTeacherID.Text = selectedTeacherId.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Teacher teacher = new Teacher
            {
                Name = txtName.Text.Trim(),
                Gender = cmbGender.SelectedItem.ToString()
            };

            db.Teachers.Add(teacher);
            db.SaveChanges();

            MessageBox.Show("Data teacher berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diubah dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            var teacher = db.Teachers.FirstOrDefault(t => t.TeacherId == selectedTeacherId);
            if (teacher != null)
            {
                teacher.Name = txtName.Text.Trim();
                teacher.Gender = cmbGender.SelectedItem?.ToString();

                db.SaveChanges();
                MessageBox.Show("Data teacher berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var teacher = db.Teachers.FirstOrDefault(t => t.TeacherId == selectedTeacherId);
                if (teacher != null)
                {
                    db.Teachers.Remove(teacher);
                    db.SaveChanges();

                    MessageBox.Show("Data teacher berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
