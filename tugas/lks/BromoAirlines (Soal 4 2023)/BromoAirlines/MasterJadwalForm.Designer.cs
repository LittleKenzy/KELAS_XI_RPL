namespace BromoAirlines
{
    partial class MasterJadwalForm
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
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKodePenerbangan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKeberangkatan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTujuan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpWaktu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaskapai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numDurasi = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Jadwal Penerbangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua Jadwal Penerbangan akan muncul disini";
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwal.Location = new System.Drawing.Point(19, 91);
            this.dgvJadwal.MultiSelect = false;
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.RowHeadersWidth = 51;
            this.dgvJadwal.RowTemplate.Height = 24;
            this.dgvJadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJadwal.Size = new System.Drawing.Size(693, 211);
            this.dgvJadwal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kode Penerbangan";
            // 
            // txtKodePenerbangan
            // 
            this.txtKodePenerbangan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKodePenerbangan.Location = new System.Drawing.Point(19, 337);
            this.txtKodePenerbangan.Name = "txtKodePenerbangan";
            this.txtKodePenerbangan.Size = new System.Drawing.Size(214, 27);
            this.txtKodePenerbangan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dari";
            // 
            // cbKeberangkatan
            // 
            this.cbKeberangkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeberangkatan.FormattingEnabled = true;
            this.cbKeberangkatan.Location = new System.Drawing.Point(19, 386);
            this.cbKeberangkatan.Name = "cbKeberangkatan";
            this.cbKeberangkatan.Size = new System.Drawing.Size(214, 24);
            this.cbKeberangkatan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ke";
            // 
            // cbTujuan
            // 
            this.cbTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTujuan.FormattingEnabled = true;
            this.cbTujuan.Location = new System.Drawing.Point(19, 432);
            this.cbTujuan.Name = "cbTujuan";
            this.cbTujuan.Size = new System.Drawing.Size(214, 24);
            this.cbTujuan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tanggal";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(19, 481);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(214, 22);
            this.dtpTanggal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Waktu";
            // 
            // dtpWaktu
            // 
            this.dtpWaktu.Location = new System.Drawing.Point(294, 338);
            this.dtpWaktu.Name = "dtpWaktu";
            this.dtpWaktu.Size = new System.Drawing.Size(214, 22);
            this.dtpWaktu.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Maskapai";
            // 
            // cbMaskapai
            // 
            this.cbMaskapai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaskapai.FormattingEnabled = true;
            this.cbMaskapai.Location = new System.Drawing.Point(294, 386);
            this.cbMaskapai.Name = "cbMaskapai";
            this.cbMaskapai.Size = new System.Drawing.Size(214, 24);
            this.cbMaskapai.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Durasi (menit)";
            // 
            // numDurasi
            // 
            this.numDurasi.Location = new System.Drawing.Point(294, 432);
            this.numDurasi.Name = "numDurasi";
            this.numDurasi.Size = new System.Drawing.Size(214, 22);
            this.numDurasi.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Harga per Tiket";
            // 
            // numHarga
            // 
            this.numHarga.Location = new System.Drawing.Point(294, 481);
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(214, 22);
            this.numHarga.TabIndex = 18;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(560, 481);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(150, 40);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(560, 432);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(150, 40);
            this.btnBatal.TabIndex = 20;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // MasterJadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 547);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numDurasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMaskapai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpWaktu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTujuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbKeberangkatan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKodePenerbangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvJadwal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MasterJadwalForm";
            this.Text = "Master Jadwal Penerbangan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKodePenerbangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKeberangkatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTujuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpWaktu;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaskapai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDurasi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
