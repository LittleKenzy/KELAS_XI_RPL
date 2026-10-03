namespace BromoAirlines
{
    partial class CustomerBeliTiketForm
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
            this.cboJadwal = new System.Windows.Forms.ComboBox();
            this.lblJadwalInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPenumpang = new System.Windows.Forms.DataGridView();
            this.btnTambahPenumpang = new System.Windows.Forms.Button();
            this.btnHapusPenumpang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKodePromo = new System.Windows.Forms.ComboBox();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beli Tiket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pilih Penerbangan";
            // 
            // cboJadwal
            // 
            this.cboJadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJadwal.FormattingEnabled = true;
            this.cboJadwal.Location = new System.Drawing.Point(19, 74);
            this.cboJadwal.Name = "cboJadwal";
            this.cboJadwal.Size = new System.Drawing.Size(540, 24);
            this.cboJadwal.TabIndex = 2;
            this.cboJadwal.SelectedIndexChanged += new System.EventHandler(this.cboJadwal_SelectedIndexChanged);
            // 
            // lblJadwalInfo
            // 
            this.lblJadwalInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJadwalInfo.Location = new System.Drawing.Point(19, 108);
            this.lblJadwalInfo.Name = "lblJadwalInfo";
            this.lblJadwalInfo.Size = new System.Drawing.Size(540, 110);
            this.lblJadwalInfo.TabIndex = 3;
            this.lblJadwalInfo.Text = "Pilih jadwal penerbangan untuk melihat detailnya.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Daftar Penumpang";
            // 
            // dgvPenumpang
            // 
            this.dgvPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenumpang.Location = new System.Drawing.Point(19, 247);
            this.dgvPenumpang.Name = "dgvPenumpang";
            this.dgvPenumpang.RowHeadersWidth = 51;
            this.dgvPenumpang.RowTemplate.Height = 24;
            this.dgvPenumpang.Size = new System.Drawing.Size(350, 140);
            this.dgvPenumpang.TabIndex = 5;
            // 
            // btnTambahPenumpang
            // 
            this.btnTambahPenumpang.Location = new System.Drawing.Point(380, 247);
            this.btnTambahPenumpang.Name = "btnTambahPenumpang";
            this.btnTambahPenumpang.Size = new System.Drawing.Size(180, 40);
            this.btnTambahPenumpang.TabIndex = 6;
            this.btnTambahPenumpang.Text = "+ Tambah Penumpang";
            this.btnTambahPenumpang.UseVisualStyleBackColor = true;
            this.btnTambahPenumpang.Click += new System.EventHandler(this.btnTambahPenumpang_Click);
            // 
            // btnHapusPenumpang
            // 
            this.btnHapusPenumpang.Location = new System.Drawing.Point(380, 295);
            this.btnHapusPenumpang.Name = "btnHapusPenumpang";
            this.btnHapusPenumpang.Size = new System.Drawing.Size(180, 40);
            this.btnHapusPenumpang.TabIndex = 7;
            this.btnHapusPenumpang.Text = "Hapus Penumpang";
            this.btnHapusPenumpang.UseVisualStyleBackColor = true;
            this.btnHapusPenumpang.Click += new System.EventHandler(this.btnHapusPenumpang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kode Promo (Opsional)";
            // 
            // cboKodePromo
            // 
            this.cboKodePromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKodePromo.FormattingEnabled = true;
            this.cboKodePromo.Location = new System.Drawing.Point(19, 417);
            this.cboKodePromo.Name = "cboKodePromo";
            this.cboKodePromo.Size = new System.Drawing.Size(350, 24);
            this.cboKodePromo.TabIndex = 9;
            this.cboKodePromo.SelectedIndexChanged += new System.EventHandler(this.cboKodePromo_SelectedIndexChanged);
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalHarga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalHarga.Location = new System.Drawing.Point(380, 417);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(180, 70);
            this.lblTotalHarga.TabIndex = 10;
            this.lblTotalHarga.Text = "Total Harga : Rp 0";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(380, 495);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(180, 40);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Booking Tiket";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(19, 495);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(180, 40);
            this.btnTutup.TabIndex = 12;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // CustomerBeliTiketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 555);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.cboKodePromo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHapusPenumpang);
            this.Controls.Add(this.btnTambahPenumpang);
            this.Controls.Add(this.dgvPenumpang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblJadwalInfo);
            this.Controls.Add(this.cboJadwal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerBeliTiketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerBeliTiketForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenumpang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboJadwal;
        private System.Windows.Forms.Label lblJadwalInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPenumpang;
        private System.Windows.Forms.Button btnTambahPenumpang;
        private System.Windows.Forms.Button btnHapusPenumpang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKodePromo;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTutup;
    }
}
