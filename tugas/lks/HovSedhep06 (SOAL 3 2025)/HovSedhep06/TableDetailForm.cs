using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HovSedhep06
{
    public class TableDetailForm : Form
    {
        private readonly int tableID;
        private readonly string tableName;
        private DataRow current;
        private readonly Label lblCustomer = new Label();
        private readonly Label lblInfo = new Label();
        private readonly Button btnCancelSeat = new Button();
        private readonly Button btnFinish = new Button();
        private readonly Button btnClose = new Button();

        public TableDetailForm(int tableID, string tableName)
        {
            this.tableID = tableID;
            this.tableName = tableName;
            LoadCurrent();
            BuildUi();
        }

        private void LoadCurrent()
        {
            DataTable dt = DbHelper.GetDataTable(
                "SELECT TOP 1 tr.TransactionID, tr.CustomerName, tr.TransactionDate, t.Capacity FROM Transactions tr JOIN RestaurantTables t ON tr.TableID = t.TableID WHERE tr.TableID = @TableID AND tr.Status = 'Ongoing' ORDER BY tr.TransactionDate DESC",
                new SqlParameter[] { new SqlParameter("@TableID", tableID) });
            if (dt.Rows.Count > 0)
            {
                current = dt.Rows[0];
            }
        }

        private void BuildUi()
        {
            Text = "Table " + tableName + " Details";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(380, 230);

            Label lblTitle = new Label
            {
                Text = "Table " + tableName,
                Location = new Point(20, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            if (current == null)
            {
                lblCustomer.Text = "No active seating for this table.";
                lblCustomer.Location = new Point(20, 55);
                lblCustomer.AutoSize = true;
                Controls.Add(lblTitle);
                Controls.Add(lblCustomer);
                return;
            }

            lblCustomer.Text = "Customer: " + current["CustomerName"];
            lblCustomer.Location = new Point(20, 55);
            lblCustomer.AutoSize = true;

            lblInfo.Text = string.Format("Seated since: {0:dd MMMM yyyy HH:mm}  |  Capacity: {1}",
                Convert.ToDateTime(current["TransactionDate"]), current["Capacity"]);
            lblInfo.Location = new Point(20, 85);
            lblInfo.AutoSize = true;

            btnCancelSeat.Text = "Cancel Seating";
            btnCancelSeat.Location = new Point(20, 140);
            btnCancelSeat.Size = new Size(120, 34);
            btnCancelSeat.Click += (s, e) => UpdateStatus("Cancelled");

            btnFinish.Text = "Mark as Finished";
            btnFinish.Location = new Point(150, 140);
            btnFinish.Size = new Size(130, 34);
            btnFinish.Click += (s, e) => UpdateStatus("Completed");

            btnClose.Text = "Close";
            btnClose.Location = new Point(290, 140);
            btnClose.Size = new Size(75, 34);
            btnClose.DialogResult = DialogResult.Cancel;

            Controls.Add(lblTitle);
            Controls.Add(lblCustomer);
            Controls.Add(lblInfo);
            Controls.Add(btnCancelSeat);
            Controls.Add(btnFinish);
            Controls.Add(btnClose);
            CancelButton = btnClose;
        }

        private void UpdateStatus(string status)
        {
            if (current == null)
            {
                return;
            }

            DbHelper.ExecuteNonQuery(
                "UPDATE Transactions SET Status = @Status WHERE TransactionID = @TransactionID",
                new SqlParameter[] {
                    new SqlParameter("@Status", status),
                    new SqlParameter("@TransactionID", current["TransactionID"])
                });

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}