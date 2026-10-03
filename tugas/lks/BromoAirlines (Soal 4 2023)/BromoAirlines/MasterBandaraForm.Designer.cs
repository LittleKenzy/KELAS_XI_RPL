namespace BromoAirlines
{
    partial class MasterBandaraForm
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
            this.dgvBandara = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodeIATA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNegara = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numTerminal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBandara
            // 
            this.dgvBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandara.Location = new System.Drawing.Point(0, 0);
            this.dgvBandara.Name = "dgvBandara";
            this.dgvBandara.ReadOnly = true;
            this.dgvBandara.RowHeadersWidth = 51;
            this.dgvBandara.RowTemplate.Height = 24;
            this.dgvBandara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBandara.Size = new System.Drawing.Size(803, 184);
            this.dgvBandara.TabIndex = 0;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.Location = new System.Drawing.Point(25, 226);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(194, 27);
            this.txtNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKodeIATA
            // 
            this.txtKodeIATA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKodeIATA.Location = new System.Drawing.Point(25, 275);
            this.txtKodeIATA.Name = "txtKodeIATA";
            this.txtKodeIATA.Size = new System.Drawing.Size(194, 27);
            this.txtKodeIATA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "KodeIATA";
            // 
            // txtKota
            // 
            this.txtKota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKota.Location = new System.Drawing.Point(25, 324);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(194, 27);
            this.txtKota.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kota";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlamat.Location = new System.Drawing.Point(25, 373);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(194, 27);
            this.txtAlamat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat";
            // 
            // cmbNegara
            // 
            this.cmbNegara.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNegara.FormattingEnabled = true;
            this.cmbNegara.Location = new System.Drawing.Point(286, 226);
            this.cmbNegara.Name = "cmbNegara";
            this.cmbNegara.Size = new System.Drawing.Size(203, 28);
            this.cmbNegara.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Negara";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // numTerminal
            // 
            this.numTerminal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTerminal.Location = new System.Drawing.Point(286, 280);
            this.numTerminal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTerminal.Name = "numTerminal";
            this.numTerminal.Size = new System.Drawing.Size(203, 27);
            this.numTerminal.TabIndex = 4;
            this.numTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Terminal";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(286, 313);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(203, 38);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(286, 362);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(203, 38);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // MasterBandaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.numTerminal);
            this.Controls.Add(this.cmbNegara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKodeIATA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dgvBandara);
            this.Name = "MasterBandaraForm";
            this.Text = "MasterBandaraForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBandara;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodeIATA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNegara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTerminal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}