using SMKNusantaraApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMKNusantaraApp
{
    public partial class MasterStudentForm : Form
    {
        private SmknusantaraDbContext db = Database.DB;
        private int selectedStudentId = 0;
        public MasterStudentForm()
        {
            InitializeComponent();
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            dgvStudent.DataSource = db.Students.Select(s => new
            {
                s.StudentId,
                s.Name,
                s.Address,
                s.Gender,
                s.DateofBirth,
                s.NoHp
            }).ToList();
        }

        private void ClearForm()
        {
            txtStudentID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            cmbGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Now;
            txtNoHp.Text = "";
            selectedStudentId = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || cmbGender.SelectedIndex == -1 || string.IsNullOrEmpty(txtNoHp.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Semua Field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Gender = cmbGender.SelectedItem?.ToString(),
                DateofBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value),
                NoHp = txtNoHp.Text
            };

            db.Students.Add(student);
            db.SaveChanges();

            MessageBox.Show("Data siswa berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearForm();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                txtStudentID.Text = selectedStudentId.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
                if (row.Cells["DateofBirth"].Value != null)
                {
                    var dateValue = row.Cells["DateofBirth"].Value;
                    DateTime tempDate = DateTime.Now;

                    if (dateValue is DateOnly dateOnly)
                    {
                        tempDate = dateOnly.ToDateTime(TimeOnly.MinValue);
                    }
                    else if (dateValue is DateTime dateTime)
                    {
                        tempDate = dateTime;
                    }
                    else if (DateTime.TryParse(dateValue?.ToString(), out DateTime parsedDate))
                    {
                        tempDate = parsedDate;
                    }

                    // Pastikan tanggal berada di atas MinDate bawaan DateTimePicker (1/1/1753)
                    if (tempDate >= dtpDateOfBirth.MinDate && tempDate <= dtpDateOfBirth.MaxDate)
                    {
                        dtpDateOfBirth.Value = tempDate;
                    }
                    else
                    {
                        dtpDateOfBirth.Value = DateTime.Now; // Fallback jika data tanggal 0001-01-01
                    }
                }
                else
                {
                    dtpDateOfBirth.Value = DateTime.Now;
                }
            txtNoHp.Text = row.Cells["NoHp"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = db.Students.FirstOrDefault(s => s.StudentId == selectedStudentId);
            if (student != null)
            {
                student.Name = txtName.Text;
                student.Address = txtAddress.Text;
                student.Gender = cmbGender.SelectedItem?.ToString();
                student.DateofBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
                student.NoHp = txtNoHp.Text.Trim();

                db.SaveChanges();
                MessageBox.Show("Data siswa berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus siswa ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var student = db.Students.FirstOrDefault(s => s.StudentId == selectedStudentId);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();

                    MessageBox.Show("Data siswa berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
