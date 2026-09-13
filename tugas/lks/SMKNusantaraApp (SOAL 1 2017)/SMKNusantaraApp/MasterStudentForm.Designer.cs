namespace SMKNusantaraApp
{
    partial class MasterStudentForm
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
            dgvStudent = new DataGridView();
            txtStudentID = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNoHp = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            btnInsert = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(-3, 0);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.Size = new Size(810, 170);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(12, 214);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 196);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Student ID";
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 214);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 196);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(266, 214);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 149);
            txtAddress.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 196);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 254);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 322);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 2;
            label5.Text = "Tanggal Lahir";
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(142, 340);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(100, 23);
            txtNoHp.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 322);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 2;
            label6.Text = "No HP";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(12, 272);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(230, 23);
            cmbGender.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(12, 340);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(100, 23);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(14, 379);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Tambah";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Batalkan";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(95, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(95, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(176, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(176, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MasterStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbGender);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtNoHp);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(txtStudentID);
            Controls.Add(dgvStudent);
            Name = "MasterStudentForm";
            Text = "MasterStudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private TextBox txtStudentID;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox txtNoHp;
        private Label label6;
        private ComboBox cmbGender;
        private DateTimePicker dtpDateOfBirth;
        private Button btnInsert;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnSave;
        private Button btnDelete;
    }
}