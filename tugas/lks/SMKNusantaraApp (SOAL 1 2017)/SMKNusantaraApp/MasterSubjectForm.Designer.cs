namespace SMKNusantaraApp
{
    partial class MasterSubjectForm
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
            dgvSubject = new DataGridView();
            txtSubjectID = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            txtAssignment = new Label();
            txtMidExam = new TextBox();
            label5 = new Label();
            txtFinalExam = new TextBox();
            label6 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(0, 0);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.Size = new Size(814, 172);
            dgvSubject.TabIndex = 0;
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(12, 220);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.ReadOnly = true;
            txtSubjectID.Size = new Size(100, 23);
            txtSubjectID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 202);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "SubjectID";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 220);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 202);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(266, 220);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(248, 151);
            txtDescription.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 202);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Deskripsi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 281);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 1;
            // 
            // txtAssignment
            // 
            txtAssignment.AutoSize = true;
            txtAssignment.Location = new Point(12, 263);
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Size = new Size(38, 15);
            txtAssignment.TabIndex = 2;
            txtAssignment.Text = "Tugas";
            // 
            // txtMidExam
            // 
            txtMidExam.Location = new Point(12, 348);
            txtMidExam.Name = "txtMidExam";
            txtMidExam.Size = new Size(100, 23);
            txtMidExam.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 330);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 2;
            label5.Text = "Ujian Tengah";
            // 
            // txtFinalExam
            // 
            txtFinalExam.Location = new Point(131, 348);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(100, 23);
            txtFinalExam.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 330);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 2;
            label6.Text = "Ujian Akhir";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 393);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Tambah";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 393);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(255, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(336, 393);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // MasterSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label6);
            Controls.Add(txtAssignment);
            Controls.Add(txtFinalExam);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(txtMidExam);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtSubjectID);
            Controls.Add(dgvSubject);
            Name = "MasterSubjectForm";
            Text = "MasterSubjectForm";
            Load += MasterSubjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSubject;
        private TextBox txtSubjectID;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox textBox3;
        private Label txtAssignment;
        private TextBox txtMidExam;
        private Label label5;
        private TextBox txtFinalExam;
        private Label label6;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnBack;
    }
}