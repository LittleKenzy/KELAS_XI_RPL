using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HovSedhep06
{
    public class AssignTableForm : Form
    {
        private readonly int tableID;
        private readonly string tableName;
        private readonly int capacity;
        private readonly TextBox txtCustomer = new TextBox();
        private readonly NumericUpDown numPax = new NumericUpDown();
        private readonly ComboBox cboWaitress = new ComboBox();
        private readonly Button btnSave = new Button();
        private readonly Button btnCancel = new Button();

        public AssignTableForm(int tableID, string tableName, int capacity)
        {
            this.tableID = tableID;
            this.tableName = tableName;
            this.capacity = capacity;
            BuildUi();
            LoadWaitresses();
        }

        private void BuildUi()
        {
            Text = "Assign Table " + tableName;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(380, 220);

            Label lblTable = new Label
            {
                Text = string.Format("Table {0}  |  Capacity {1}", tableName, capacity),
                Location = new Point(20, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            Label lblCustomer = new Label { Text = "Customer Name", Location = new Point(20, 55), AutoSize = true };
            Label lblPax = new Label { Text = "Number of Pax", Location = new Point(20, 90), AutoSize = true };
            Label lblWaitress = new Label { Text = "Waitress", Location = new Point(20, 125), AutoSize = true };

            txtCustomer.Location = new Point(150, 52);
            txtCustomer.Width = 200;

            numPax.Location = new Point(150, 88);
            numPax.Width = 80;
            numPax.Minimum = 1;
            numPax.Maximum = 6;
            numPax.Value = 1;

            cboWaitress.Location = new Point(150, 122);
            cboWaitress.Width = 200;
            cboWaitress.DropDownStyle = ComboBoxStyle.DropDownList;

            btnSave.Text = "Assign";
            btnSave.Location = new Point(150, 165);
            btnSave.Size = new Size(95, 30);
            btnSave.Click += BtnSave_Click;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(255, 165);
            btnCancel.Size = new Size(95, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            Controls.Add(lblTable);
            Controls.Add(lblCustomer);
            Controls.Add(txtCustomer);
            Controls.Add(lblPax);
            Controls.Add(numPax);
            Controls.Add(lblWaitress);
            Controls.Add(cboWaitress);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            AcceptButton = btnSave;
            CancelButton = btnCancel;
        }

        private void LoadWaitresses()
        {
            DataTable dt = DbHelper.GetDataTable("SELECT EmployeeID, Name FROM Employees WHERE Role = 'Waitress' ORDER BY Name");
            cboWaitress.DataSource = dt;
            cboWaitress.DisplayMember = "Name";
            cboWaitress.ValueMember = "EmployeeID";
            cboWaitress.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomer.Text.Trim();
            if (customerName.Length == 0)
            {
                MessageBox.Show("Customer name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboWaitress.SelectedValue == null)
            {
                MessageBox.Show("Please select a waitress.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pax = (int)numPax.Value;
            if (pax > capacity)
            {
                MessageBox.Show(string.Format("Table {0} only has capacity for {1} pax.", tableName, capacity), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object minFree = DbHelper.GetDataTable(
                "SELECT MIN(Capacity) AS MinCap FROM RestaurantTables t WHERE t.Capacity >= @Pax AND NOT EXISTS (SELECT 1 FROM Transactions tr WHERE tr.TableID = t.TableID AND tr.Status = 'Ongoing')",
                new SqlParameter[] { new SqlParameter("@Pax", pax) }).Rows[0]["MinCap"];

            if (minFree != DBNull.Value && Convert.ToInt32(minFree) < capacity)
            {
                MessageBox.Show(string.Format("For efficiency, seat {0} pax at a table with capacity {1}.", pax, Convert.ToInt32(minFree)), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DbHelper.ExecuteNonQuery(
                "INSERT INTO Transactions (TableID, CustomerName, Status) VALUES (@TableID, @CustomerName, 'Ongoing')",
                new SqlParameter[] {
                    new SqlParameter("@TableID", tableID),
                    new SqlParameter("@CustomerName", customerName)
                });

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}