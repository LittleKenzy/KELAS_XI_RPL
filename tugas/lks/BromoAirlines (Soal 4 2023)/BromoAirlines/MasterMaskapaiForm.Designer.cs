namespace BromoAirlines
{
    partial class MasterMaskapaiForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dgvMaskapai = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numKru = new System.Windows.Forms.NumericUpDown();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKru)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Master Maskapai";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(4, 37);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(310, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // dgvMaskapai
            // 
            this.dgvMaskapai.AllowUserToAddRows = false;
            this.dgvMaskapai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaskapai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.btnHapus});
            this.dgvMaskapai.Location = new System.Drawing.Point(7, 72);
            this.dgvMaskapai.MultiSelect = false;
            this.dgvMaskapai.Name = "dgvMaskapai";
            this.dgvMaskapai.ReadOnly = true;
            this.dgvMaskapai.RowHeadersWidth = 51;
            this.dgvMaskapai.RowTemplate.Height = 24;
            this.dgvMaskapai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaskapai.Size = new System.Drawing.Size(781, 171);
            this.dgvMaskapai.TabIndex = 2;
            this.dgvMaskapai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaskapai_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Aksi";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // btnHapus
            // 
            this.btnHapus.HeaderText = "Hapus";
            this.btnHapus.MinimumWidth = 6;
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ReadOnly = true;
            this.btnHapus.UseColumnTextForButtonValue = true;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(4, 260);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(7, 279);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(213, 27);
            this.txtNama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perusahaan";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerusahaan.Location = new System.Drawing.Point(7, 328);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(213, 27);
            this.txtPerusahaan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Kru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deskripsi";
            // 
            // numKru
            // 
            this.numKru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numKru.Location = new System.Drawing.Point(268, 279);
            this.numKru.Name = "numKru";
            this.numKru.Size = new System.Drawing.Size(218, 27);
            this.numKru.TabIndex = 4;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskripsi.Location = new System.Drawing.Point(268, 328);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.Size = new System.Drawing.Size(213, 94);
            this.txtDeskripsi.TabIndex = 3;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(507, 376);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(93, 46);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(507, 319);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 46);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // MasterMaskapaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.numKru);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtPerusahaan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMaskapai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MasterMaskapaiForm";
            this.Text = "Master Maskapai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DataGridView dgvMaskapai;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerusahaan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKru;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btnHapus;
        private System.Windows.Forms.Button btnSimpan;
    }
}