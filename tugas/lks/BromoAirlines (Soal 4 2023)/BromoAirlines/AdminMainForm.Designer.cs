namespace BromoAirlines
{
    partial class AdminMainForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnToggleSidebar = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.btnMasterBandara = new System.Windows.Forms.Button();
            this.btnMasterMaskapai = new System.Windows.Forms.Button();
            this.btnMasterJadwal = new System.Windows.Forms.Button();
            this.btnMasterPromo = new System.Windows.Forms.Button();
            this.btnUbahStatus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(228, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(572, 450);
            this.panelContent.TabIndex = 1;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelSidebar.Controls.Add(this.btnToggleSidebar);
            this.panelSidebar.Controls.Add(this.panelMainContent);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(228, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnToggleSidebar
            // 
            this.btnToggleSidebar.Location = new System.Drawing.Point(67, 22);
            this.btnToggleSidebar.Name = "btnToggleSidebar";
            this.btnToggleSidebar.Size = new System.Drawing.Size(76, 33);
            this.btnToggleSidebar.TabIndex = 1;
            this.btnToggleSidebar.Text = "=";
            this.btnToggleSidebar.UseVisualStyleBackColor = true;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.btnLogout);
            this.panelMainContent.Controls.Add(this.btnUbahStatus);
            this.panelMainContent.Controls.Add(this.btnMasterPromo);
            this.panelMainContent.Controls.Add(this.btnMasterJadwal);
            this.panelMainContent.Controls.Add(this.btnMasterMaskapai);
            this.panelMainContent.Controls.Add(this.btnMasterBandara);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(228, 450);
            this.panelMainContent.TabIndex = 1;
            // 
            // btnMasterBandara
            // 
            this.btnMasterBandara.Location = new System.Drawing.Point(67, 61);
            this.btnMasterBandara.Name = "btnMasterBandara";
            this.btnMasterBandara.Size = new System.Drawing.Size(119, 33);
            this.btnMasterBandara.TabIndex = 1;
            this.btnMasterBandara.Text = "Master Bandara";
            this.btnMasterBandara.UseVisualStyleBackColor = true;
            this.btnMasterBandara.Click += new System.EventHandler(this.btnMasterBandara_Click);
            // 
            // btnMasterMaskapai
            // 
            this.btnMasterMaskapai.Location = new System.Drawing.Point(67, 100);
            this.btnMasterMaskapai.Name = "btnMasterMaskapai";
            this.btnMasterMaskapai.Size = new System.Drawing.Size(119, 33);
            this.btnMasterMaskapai.TabIndex = 1;
            this.btnMasterMaskapai.Text = "Master Maskapai";
            this.btnMasterMaskapai.UseVisualStyleBackColor = true;
            this.btnMasterMaskapai.Click += new System.EventHandler(this.btnMasterMaskapai_Click);
            // 
            // btnMasterJadwal
            // 
            this.btnMasterJadwal.Location = new System.Drawing.Point(67, 139);
            this.btnMasterJadwal.Name = "btnMasterJadwal";
            this.btnMasterJadwal.Size = new System.Drawing.Size(119, 33);
            this.btnMasterJadwal.TabIndex = 1;
            this.btnMasterJadwal.Text = "Master Jadwal";
            this.btnMasterJadwal.UseVisualStyleBackColor = true;
            this.btnMasterJadwal.Click += new System.EventHandler(this.btnMasterJadwal_Click);
            // 
            // btnMasterPromo
            // 
            this.btnMasterPromo.Location = new System.Drawing.Point(67, 178);
            this.btnMasterPromo.Name = "btnMasterPromo";
            this.btnMasterPromo.Size = new System.Drawing.Size(119, 33);
            this.btnMasterPromo.TabIndex = 1;
            this.btnMasterPromo.Text = "Master Promo";
            this.btnMasterPromo.UseVisualStyleBackColor = true;
            this.btnMasterPromo.Click += new System.EventHandler(this.btnMasterPromo_Click);
            // 
            // btnUbahStatus
            // 
            this.btnUbahStatus.Location = new System.Drawing.Point(67, 217);
            this.btnUbahStatus.Name = "btnUbahStatus";
            this.btnUbahStatus.Size = new System.Drawing.Size(119, 33);
            this.btnUbahStatus.TabIndex = 1;
            this.btnUbahStatus.Text = "Ubah Status";
            this.btnUbahStatus.UseVisualStyleBackColor = true;
            this.btnUbahStatus.Click += new System.EventHandler(this.btnUbahStatus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(67, 256);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panelContent.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnToggleSidebar;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUbahStatus;
        private System.Windows.Forms.Button btnMasterPromo;
        private System.Windows.Forms.Button btnMasterJadwal;
        private System.Windows.Forms.Button btnMasterMaskapai;
        private System.Windows.Forms.Button btnMasterBandara;
    }
}