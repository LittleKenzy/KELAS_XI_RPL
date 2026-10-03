namespace BromoAirlines
{
    partial class UbahStatusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPerubahan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboJadwal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpWaktuPerubahan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerubahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubah Status Penerbangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Riwayat Perubahan Status Penerbangan";
            // 
            // dgvPerubahan
            // 
            this.dgvPerubahan.AllowUserToAddRows = false;
            this.dgvPerubahan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerubahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerubahan.Location = new System.Drawing.Point(19, 91);
            this.dgvPerubahan.MultiSelect = false;
            this.dgvPerubahan.Name = "dgvPerubahan";
            this.dgvPerubahan.ReadOnly = true;
            this.dgvPerubahan.RowHeadersWidth = 51;
            this.dgvPerubahan.RowTemplate.Height = 24;
            this.dgvPerubahan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerubahan.Size = new System.Drawing.Size(693, 200);
            this.dgvPerubahan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jadwal Penerbangan";
            // 
            // cboJadwal
            // 
            this.cboJadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJadwal.FormattingEnabled = true;
            this.cboJadwal.Location = new System.Drawing.Point(19, 325);
            this.cboJadwal.Name = "cboJadwal";
            this.cboJadwal.Size = new System.Drawing.Size(330, 24);
            this.cboJadwal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status Penerbangan";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(19, 379);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(330, 24);
            this.cboStatus.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Waktu Perubahan Terjadi";
            // 
            // dtpWaktuPerubahan
            // 
            this.dtpWaktuPerubahan.Location = new System.Drawing.Point(369, 325);
            this.dtpWaktuPerubahan.Name = "dtpWaktuPerubahan";
            this.dtpWaktuPerubahan.Size = new System.Drawing.Size(200, 22);
            this.dtpWaktuPerubahan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Perkiraan Waktu Delay (menit)";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(369, 379);
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(200, 22);
            this.numDelay.TabIndex = 10;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(560, 432);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(150, 40);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(560, 385);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(150, 40);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // UbahStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 500);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpWaktuPerubahan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboJadwal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPerubahan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UbahStatusForm";
            this.Text = "Ubah Status Penerbangan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerubahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPerubahan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboJadwal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpWaktuPerubahan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
