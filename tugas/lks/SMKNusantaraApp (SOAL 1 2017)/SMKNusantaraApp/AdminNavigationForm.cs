using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMKNusantaraApp
{
    public partial class AdminNavigationForm : Form
    {
        public AdminNavigationForm()
        {
            InitializeComponent();
        }

        private void AdminNavigationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMasterTeacher_Click(object sender, EventArgs e)
        {
            MasterTeacherForm masterTeacherForm = new MasterTeacherForm();
            masterTeacherForm.Show();
            this.Hide();
        }

        private void btnMasterStudent_Click(object sender, EventArgs e)
        {
            MasterStudentForm masterStudentForm = new MasterStudentForm();
            masterStudentForm.Show();
            this.Hide();
        }

        private void btnMasterSubject_Click(object sender, EventArgs e)
        {
            MasterSubjectForm masterSubjectForm = new MasterSubjectForm();
            masterSubjectForm.Show();
            this.Hide();
        }

        private void btnMasterClass_Click(object sender, EventArgs e)
        {
            MasterClassForm masterClassForm = new MasterClassForm();
            masterClassForm.Show();
            this.Hide();
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            ManageScheduleForm manageScheduleForm = new ManageScheduleForm();
            manageScheduleForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form loginForm = new Form();
            loginForm.Show();
            this.Close();
        }
    }
}
