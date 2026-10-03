namespace BromoAirlines
{
    partial class CustomerMainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnListPenerbangan = new System.Windows.Forms.Button();
            this.btnBeliTiket = new System.Windows.Forms.Button();
            this.btnTiketSaya = new System.Windows.Forms.Button();
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
            this.btnToggleSidebar.Click += new System.EventHandler(this.btnToggleSidebar_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.btnLogout);
            this.panelMainContent.Controls.Add(this.btnTiketSaya);
            this.panelMainContent.Controls.Add(this.btnBeliTiket);
            this.panelMainContent.Controls.Add(this.btnListPenerbangan);
            this.panelMainContent.Controls.Add(this.lblWelcome);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(228, 450);
            this.panelMainContent.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(180, 45);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Selamat Datang";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListPenerbangan
            // 
            this.btnListPenerbangan.Location = new System.Drawing.Point(67, 110);
            this.btnListPenerbangan.Name = "btnListPenerbangan";
            this.btnListPenerbangan.Size = new System.Drawing.Size(119, 33);
            this.btnListPenerbangan.TabIndex = 1;
            this.btnListPenerbangan.Text = "List Penerbangan";
            this.btnListPenerbangan.UseVisualStyleBackColor = true;
            this.btnListPenerbangan.Click += new System.EventHandler(this.btnListPenerbangan_Click);
            // 
            // btnBeliTiket
            // 
            this.btnBeliTiket.Location = new System.Drawing.Point(67, 149);
            this.btnBeliTiket.Name = "btnBeliTiket";
            this.btnBeliTiket.Size = new System.Drawing.Size(119, 33);
            this.btnBeliTiket.TabIndex = 2;
            this.btnBeliTiket.Text = "Beli Tiket";
            this.btnBeliTiket.UseVisualStyleBackColor = true;
            this.btnBeliTiket.Click += new System.EventHandler(this.btnBeliTiket_Click);
            // 
            // btnTiketSaya
            // 
            this.btnTiketSaya.Location = new System.Drawing.Point(67, 188);
            this.btnTiketSaya.Name = "btnTiketSaya";
            this.btnTiketSaya.Size = new System.Drawing.Size(119, 33);
            this.btnTiketSaya.TabIndex = 3;
            this.btnTiketSaya.Text = "Tiket Saya";
            this.btnTiketSaya.UseVisualStyleBackColor = true;
            this.btnTiketSaya.Click += new System.EventHandler(this.btnTiketSaya_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(67, 227);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 33);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "CustomerMainForm";
            this.Text = "CustomerMainForm";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMainForm_FormClosing);
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
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnListPenerbangan;
        private System.Windows.Forms.Button btnBeliTiket;
        private System.Windows.Forms.Button btnTiketSaya;
        private System.Windows.Forms.Button btnLogout;
    }
}
