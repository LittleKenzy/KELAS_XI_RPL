namespace HovSedhep06
{
    partial class Form1
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTableSeating = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.btnHistory);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Controls.Add(this.btnTableSeating);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(215, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(35, 105);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(128, 41);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(35, 58);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(128, 41);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTableSeating
            // 
            this.btnTableSeating.Location = new System.Drawing.Point(35, 11);
            this.btnTableSeating.Name = "btnTableSeating";
            this.btnTableSeating.Size = new System.Drawing.Size(128, 41);
            this.btnTableSeating.TabIndex = 0;
            this.btnTableSeating.Text = "Table Seating";
            this.btnTableSeating.UseVisualStyleBackColor = true;
            this.btnTableSeating.Click += new System.EventHandler(this.btnTableSeating_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(215, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(585, 450);
            this.panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HovSedhep POS System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnTableSeating;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelContent;
    }
}

