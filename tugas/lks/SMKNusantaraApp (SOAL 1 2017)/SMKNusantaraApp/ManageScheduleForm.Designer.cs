namespace SMKNusantaraApp
{
    partial class ManageScheduleForm
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
            cmbSubject = new ComboBox();
            dgvHeaderSchedule = new DataGridView();
            btnAddStudent = new Button();
            label1 = new Label();
            cmbClass = new ComboBox();
            label2 = new Label();
            cmbTeacher = new ComboBox();
            label3 = new Label();
            cmbStudent = new ComboBox();
            label4 = new Label();
            btnRemoveStudent = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            dgvDetailSchedule = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHeaderSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetailSchedule).BeginInit();
            SuspendLayout();
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(12, 216);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 0;
            // 
            // dgvHeaderSchedule
            // 
            dgvHeaderSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaderSchedule.Location = new Point(-3, -3);
            dgvHeaderSchedule.Name = "dgvHeaderSchedule";
            dgvHeaderSchedule.Size = new Size(347, 176);
            dgvHeaderSchedule.TabIndex = 1;
            dgvHeaderSchedule.CellContentClick += dgvHeaderSchedule_CellContentClick;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(182, 269);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(121, 23);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Tambah";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 198);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Subject";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(12, 270);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(121, 23);
            cmbClass.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 252);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Guru";
            // 
            // cmbTeacher
            // 
            cmbTeacher.FormattingEnabled = true;
            cmbTeacher.Location = new Point(182, 216);
            cmbTeacher.Name = "cmbTeacher";
            cmbTeacher.Size = new Size(121, 23);
            cmbTeacher.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 198);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Kelas";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(441, 216);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(156, 23);
            cmbStudent.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 198);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Siswa";
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(182, 298);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(121, 23);
            btnRemoveStudent.TabIndex = 2;
            btnRemoveStudent.Text = "Hapus";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(441, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(522, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(487, 311);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvDetailSchedule
            // 
            dgvDetailSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailSchedule.Location = new Point(379, -3);
            dgvDetailSchedule.Name = "dgvDetailSchedule";
            dgvDetailSchedule.Size = new Size(347, 176);
            dgvDetailSchedule.TabIndex = 1;
            // 
            // ManageScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStudent);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(cmbTeacher);
            Controls.Add(cmbClass);
            Controls.Add(dgvDetailSchedule);
            Controls.Add(dgvHeaderSchedule);
            Controls.Add(cmbSubject);
            Name = "ManageScheduleForm";
            Text = "ManageScheduleForm";
            ((System.ComponentModel.ISupportInitialize)dgvHeaderSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetailSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSubject;
        private DataGridView dgvHeaderSchedule;
        private Button btnAddStudent;
        private Label label1;
        private ComboBox cmbClass;
        private Label label2;
        private ComboBox cmbTeacher;
        private Label label3;
        private ComboBox cmbStudent;
        private Label label4;
        private Button btnRemoveStudent;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBack;
        private DataGridView dgvDetailSchedule;
    }
}