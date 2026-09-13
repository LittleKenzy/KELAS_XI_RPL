namespace SMKNusantaraApp
{
    partial class MasterTeacherForm
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
            dgvTeacher = new DataGridView();
            txtTeacherID = new TextBox();
            cmbGender = new ComboBox();
            txtName = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            SuspendLayout();
            // 
            // dgvTeacher
            // 
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(0, 0);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.Size = new Size(798, 131);
            dgvTeacher.TabIndex = 0;
            dgvTeacher.CellContentClick += dgvTeacher_CellContentClick;
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(12, 172);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.ReadOnly = true;
            txtTeacherID.Size = new Size(100, 23);
            txtTeacherID.TabIndex = 1;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(12, 230);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(217, 23);
            cmbGender.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(46, 270);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Tambah";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(46, 311);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(127, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(127, 311);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(46, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(127, 351);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "ID Guru";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 154);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Nama Guru";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            label3.Click += label1_Click;
            // 
            // MasterTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(cmbGender);
            Controls.Add(txtName);
            Controls.Add(txtTeacherID);
            Controls.Add(dgvTeacher);
            Name = "MasterTeacherForm";
            Text = "MasterTeacherForm";
            Load += MasterTeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTeacher;
        private TextBox txtTeacherID;
        private ComboBox cmbGender;
        private TextBox txtName;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}