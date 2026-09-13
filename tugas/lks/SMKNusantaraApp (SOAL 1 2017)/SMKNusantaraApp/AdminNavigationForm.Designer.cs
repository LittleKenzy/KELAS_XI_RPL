namespace SMKNusantaraApp
{
    partial class AdminNavigationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnMasterTeacher = new Button();
            btnMasterStudent = new Button();
            btnMasterSubject = new Button();
            btnMasterClass = new Button();
            btnManageSchedule = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 0;
            label1.Text = "Admin Navigation Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 41);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Welcome, admin";
            // 
            // btnMasterTeacher
            // 
            btnMasterTeacher.Location = new Point(22, 93);
            btnMasterTeacher.Name = "btnMasterTeacher";
            btnMasterTeacher.Size = new Size(114, 23);
            btnMasterTeacher.TabIndex = 1;
            btnMasterTeacher.Text = "Master Teacher";
            btnMasterTeacher.UseVisualStyleBackColor = true;
            btnMasterTeacher.Click += btnMasterTeacher_Click;
            // 
            // btnMasterStudent
            // 
            btnMasterStudent.Location = new Point(284, 93);
            btnMasterStudent.Name = "btnMasterStudent";
            btnMasterStudent.Size = new Size(114, 23);
            btnMasterStudent.TabIndex = 1;
            btnMasterStudent.Text = "Master Student";
            btnMasterStudent.UseVisualStyleBackColor = true;
            btnMasterStudent.Click += btnMasterStudent_Click;
            // 
            // btnMasterSubject
            // 
            btnMasterSubject.Location = new Point(22, 133);
            btnMasterSubject.Name = "btnMasterSubject";
            btnMasterSubject.Size = new Size(114, 23);
            btnMasterSubject.TabIndex = 1;
            btnMasterSubject.Text = "Master Subject";
            btnMasterSubject.UseVisualStyleBackColor = true;
            btnMasterSubject.Click += btnMasterSubject_Click;
            // 
            // btnMasterClass
            // 
            btnMasterClass.Location = new Point(284, 133);
            btnMasterClass.Name = "btnMasterClass";
            btnMasterClass.Size = new Size(114, 23);
            btnMasterClass.TabIndex = 1;
            btnMasterClass.Text = "Master Class";
            btnMasterClass.UseVisualStyleBackColor = true;
            btnMasterClass.Click += btnMasterClass_Click;
            // 
            // btnManageSchedule
            // 
            btnManageSchedule.Location = new Point(22, 179);
            btnManageSchedule.Name = "btnManageSchedule";
            btnManageSchedule.Size = new Size(114, 23);
            btnManageSchedule.TabIndex = 1;
            btnManageSchedule.Text = "Manage Schedule";
            btnManageSchedule.UseVisualStyleBackColor = true;
            btnManageSchedule.Click += btnManageSchedule_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(284, 179);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminNavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnMasterClass);
            Controls.Add(btnMasterStudent);
            Controls.Add(btnManageSchedule);
            Controls.Add(btnMasterSubject);
            Controls.Add(btnMasterTeacher);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminNavigationForm";
            Text = "AdminNavigationForm";
            Load += AdminNavigationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnMasterTeacher;
        private Button btnMasterStudent;
        private Button btnMasterSubject;
        private Button btnMasterClass;
        private Button btnManageSchedule;
        private Button btnLogout;
    }
}