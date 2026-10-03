namespace BromoAirlines
{
    partial class MasterPromoForm
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
            this.dgvPromo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPresentase = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBerlakuSampai = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresentase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromo
            // 
            this.dgvPromo.AllowUserToAddRows = false;
            this.dgvPromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromo.Location = new System.Drawing.Point(19, 45);
            this.dgvPromo.MultiSelect = false;
            this.dgvPromo.Name = "dgvPromo";
            this.dgvPromo.ReadOnly = true;
            this.dgvPromo.RowHeadersWidth = 51;
            this.dgvPromo.RowTemplate.Height = 24;
            this.dgvPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromo.Size = new System.Drawing.Size(693, 180);
            this.dgvPromo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master Kode Promo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Promo";
            // 
            // txtKode
            // 
            this.txtKode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKode.Location = new System.Drawing.Point(19, 267);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(214, 27);
            this.txtKode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Presentase Diskon (%)";
            // 
            // numPresentase
            // 
            this.numPresentase.Location = new System.Drawing.Point(19, 325);
            this.numPresentase.Name = "numPresentase";
            this.numPresentase.Size = new System.Drawing.Size(214, 22);
            this.numPresentase.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Berlaku Sampai";
            // 
            // dtpBerlakuSampai
            // 
            this.dtpBerlakuSampai.Location = new System.Drawing.Point(19, 379);
            this.dtpBerlakuSampai.Name = "dtpBerlakuSampai";
            this.dtpBerlakuSampai.Size = new System.Drawing.Size(214, 22);
            this.dtpBerlakuSampai.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeskripsi.Location = new System.Drawing.Point(289, 267);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(214, 102);
            this.txtDeskripsi.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(560, 267);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(150, 40);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(560, 316);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(150, 40);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // MasterPromoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 440);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBerlakuSampai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPresentase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPromo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MasterPromoForm";
            this.Text = "Master Kode Promo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresentase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPresentase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBerlakuSampai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
