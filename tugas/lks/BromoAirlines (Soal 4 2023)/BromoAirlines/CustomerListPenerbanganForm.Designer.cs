namespace BromoAirlines
{
    partial class CustomerListPenerbanganForm
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.btnBeli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Penerbangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari Penerbangan";
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.Location = new System.Drawing.Point(19, 74);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(400, 27);
            this.txtCari.TabIndex = 2;
            this.txtCari.TextChanged += new System.EventHandler(this.btnCari_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(425, 74);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 27);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwal.Location = new System.Drawing.Point(19, 115);
            this.dgvJadwal.MultiSelect = false;
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.RowHeadersWidth = 51;
            this.dgvJadwal.RowTemplate.Height = 24;
            this.dgvJadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJadwal.Size = new System.Drawing.Size(550, 280);
            this.dgvJadwal.TabIndex = 4;
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(19, 405);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(180, 40);
            this.btnBeli.TabIndex = 5;
            this.btnBeli.Text = "Beli Tiket";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // CustomerListPenerbanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 455);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.dgvJadwal);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerListPenerbanganForm";
            this.Text = "CustomerListPenerbanganForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Button btnBeli;
    }
}
