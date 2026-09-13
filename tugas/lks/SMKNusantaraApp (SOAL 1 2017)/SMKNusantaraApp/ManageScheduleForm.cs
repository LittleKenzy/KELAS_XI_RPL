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
    public partial class ManageScheduleForm : Form
    {
        private SmknusantaraDbContext db = new SmknusantaraDbContext();
        private List<Student> selectedStudents = new List<Student>();
        private int currentScheduleId = 0;

        public ManageScheduleForm()
        {
            InitializeComponent();
            LoadDropdownData();
            LoadHeaderSchedule();
        }

        private void LoadDropdownData()
        {
            // Load data for dropdowns (comboboxes)
            cmbSubject.DataSource = db.Subjects.ToList();
            cmbSubject.DisplayMember = "Name";
            cmbSubject.ValueMember = "SubjectId";

            cmbTeacher.DataSource = db.Teachers.ToList();
            cmbTeacher.DisplayMember = "Name";
            cmbTeacher.ValueMember = "TeacherId";

            cmbClass.DataSource = db.Classes.ToList();
            cmbClass.DisplayMember = "Name";
            cmbClass.ValueMember = "ClassId";

            cmbStudent.DataSource = db.Students.ToList();
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "StudentId";
        }

        private void LoadHeaderSchedule()
        {
            dgvHeaderSchedule.DataSource = db.HeaderSchedules.Select(h => new
            {
                h.ScheduleId,
                SubjectName = h.Subject.Name,
                TeacherName = h.Teacher.Name,
                ClassName = h.Class.Name
            }).ToList();
        }

        private void dgvHeaderSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentScheduleId = Convert.ToInt32(dgvHeaderSchedule.Rows[e.RowIndex].Cells["ScheduleId"].Value);

                // Fetch detail student berdasarkan schedule id
                var details = db.DetailSchedules
                    .Where(d => d.ScheduleId == currentScheduleId)
                    .Select(d => d.StudentId)
                    .ToList();

                selectedStudents = details.Select(id => db.Students.Find(id)).ToList();
                RefreshStudentGrid();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedItem is Student student)
            {
                if (!selectedStudents.Any(s => s.StudentId == student.StudentId))
                {
                    selectedStudents.Add(student);
                    RefreshStudentGrid();
                }
                else
                {
                    MessageBox.Show("Siswa sudah ada di dalam daftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dgvDetailSchedule.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(dgvDetailSchedule.CurrentRow.Cells["StudentId"].Value);
                selectedStudents.RemoveAll(s => s.StudentId == studentId);
                RefreshStudentGrid();
            }
        }

        private void RefreshStudentGrid()
        {
            dgvDetailSchedule.DataSource = null;
            dgvDetailSchedule.DataSource = selectedStudents.Select(s => new
            {
                s.StudentId,
                s.Name,
                s.Gender
            }).ToList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue == null || cmbTeacher.SelectedValue == null || cmbClass.SelectedValue == null)
            {
                MessageBox.Show("Lengkapi semua pilihan combobox!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HeaderSchedule header = new HeaderSchedule
            {
                SubjectId = (int)cmbSubject.SelectedValue,
                TeacherId = (int)cmbTeacher.SelectedValue,
                ClassId = (int)cmbClass.SelectedValue
            };

            db.HeaderSchedules.Add(header);
            db.SaveChanges(); //save untuk mendapatkan scheduleId baru

            //simpan detail schedule
            foreach (var student in selectedStudents)
            {
                DetailSchedule detail = new DetailSchedule()
                {
                    ScheduleId = header.ScheduleId,
                    StudentId = student.StudentId
                };
                db.DetailSchedules.Add(detail);
            }
            db.SaveChanges();
            MessageBox.Show("Jadwal dan Detail siswa berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadHeaderSchedule();
            selectedStudents.Clear();
            RefreshStudentGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminNavigationForm adminNav = new AdminNavigationForm();
            adminNav.Show();
            this.Close();
        }
    }
}
