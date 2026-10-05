namespace HovSalad
{
    partial class FormOrder
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnAddSalad = new System.Windows.Forms.Button();
            this.btnAddProteinBowl = new System.Windows.Forms.Button();
            this.gbOrderItem = new System.Windows.Forms.GroupBox();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.btnBackToHome = new System.Windows.Forms.Button();

            this.gbOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.gbIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();

            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(25, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(120, 19);
            this.lblCustomerName.Text = "Customer Name";

            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(25, 45);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 25);

            // 
            // btnAddSalad
            // 
            this.btnAddSalad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.btnAddSalad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSalad.Location = new System.Drawing.Point(340, 40);
            this.btnAddSalad.Name = "btnAddSalad";
            this.btnAddSalad.Size = new System.Drawing.Size(160, 35);
            this.btnAddSalad.Text = "Add Salad";
            this.btnAddSalad.UseVisualStyleBackColor = false;

            // 
            // btnAddProteinBowl
            // 
            this.btnAddProteinBowl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(178)))));
            this.btnAddProteinBowl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProteinBowl.Location = new System.Drawing.Point(520, 40);
            this.btnAddProteinBowl.Name = "btnAddProteinBowl";
            this.btnAddProteinBowl.Size = new System.Drawing.Size(160, 35);
            this.btnAddProteinBowl.Text = "Add Protein Bowl";
            this.btnAddProteinBowl.UseVisualStyleBackColor = false;

            // 
            // gbOrderItem
            // 
            this.gbOrderItem.Controls.Add(this.dgvOrderItems);
            this.gbOrderItem.Location = new System.Drawing.Point(25, 90);
            this.gbOrderItem.Name = "gbOrderItem";
            this.gbOrderItem.Size = new System.Drawing.Size(655, 150);
            this.gbOrderItem.Text = "Order Item";

            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItems.Location = new System.Drawing.Point(3, 16);
            this.dgvOrderItems.MultiSelect = false;
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(649, 131);

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Navy;
            this.lblTotal.Location = new System.Drawing.Point(25, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 21);
            this.lblTotal.Text = "Total: Rp0";

            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnAddIngredients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddIngredients.Location = new System.Drawing.Point(520, 250);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(160, 35);
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = false;

            // 
            // gbIngredients
            // 
            this.gbIngredients.Controls.Add(this.dgvIngredients);
            this.gbIngredients.Location = new System.Drawing.Point(25, 300);
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.Size = new System.Drawing.Size(655, 170);
            this.gbIngredients.Text = "Ingredients";

            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredients.Location = new System.Drawing.Point(3, 16);
            this.dgvIngredients.MultiSelect = false;
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredients.Size = new System.Drawing.Size(649, 151);

            // 
            // lblOrderCode
            // 
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrderCode.Location = new System.Drawing.Point(25, 490);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(120, 20);
            this.lblOrderCode.Text = "Order Code: -";
            this.lblOrderCode.Visible = false;

            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(550, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 35);
            this.btnSubmit.Text = "Submit";

            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToHome.Location = new System.Drawing.Point(550, 485);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(130, 35);
            this.btnBackToHome.Text = "Back to Home";
            this.btnBackToHome.Visible = false;

            // 
            // FormOrder
            // 
            this.ClientSize = new System.Drawing.Size(705, 540);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.lblOrderCode);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbIngredients);
            this.Controls.Add(this.btnAddIngredients);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbOrderItem);
            this.Controls.Add(this.btnAddProteinBowl);
            this.Controls.Add(this.btnAddSalad);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FormOrder";
            this.Text = "Hov Salad - Order Form";
            this.gbOrderItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.gbIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnAddSalad;
        private System.Windows.Forms.Button btnAddProteinBowl;
        private System.Windows.Forms.GroupBox gbOrderItem;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.Button btnBackToHome;
    }
}