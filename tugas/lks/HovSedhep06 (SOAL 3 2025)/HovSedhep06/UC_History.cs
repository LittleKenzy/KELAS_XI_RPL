using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HovSedhep06
{
    public class UC_History : UserControl
    {
        private readonly DateTimePicker dtpDate = new DateTimePicker();
        private readonly ComboBox cboTable = new ComboBox();
        private readonly DataGridView gridTrans = new DataGridView();
        private readonly DataGridView gridOrders = new DataGridView();
        private readonly DataGridView gridDetails = new DataGridView();
        private bool loading;

        public UC_History()
        {
            Dock = DockStyle.Fill;
            BuildUi();
            LoadTables();
            SetDefaultDate();
            LoadTransactions();
        }

        private void BuildUi()
        {
            Panel top = new Panel { Dock = DockStyle.Top, Height = 50, Padding = new Padding(10, 12, 10, 0) };

            Label lblDate = new Label { Text = "Date", Location = new Point(12, 17), AutoSize = true };
            dtpDate.Location = new Point(55, 13);
            dtpDate.Width = 140;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd MMMM yyyy";
            dtpDate.ValueChanged += (s, e) => LoadTransactions();

            Label lblTable = new Label { Text = "Table", Location = new Point(215, 17), AutoSize = true };
            cboTable.Location = new Point(262, 13);
            cboTable.Width = 140;
            cboTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTable.SelectedIndexChanged += (s, e) => LoadTransactions();

            top.Controls.Add(lblDate);
            top.Controls.Add(dtpDate);
            top.Controls.Add(lblTable);
            top.Controls.Add(cboTable);

            ConfigureGrid(gridTrans);
            ConfigureGrid(gridOrders);
            ConfigureGrid(gridDetails);
            gridTrans.SelectionChanged += GridTrans_SelectionChanged;
            gridOrders.SelectionChanged += GridOrders_SelectionChanged;

            TableLayoutPanel layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 3 };
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            layout.Controls.Add(MakeGroup("Transactions", gridTrans), 0, 0);
            layout.Controls.Add(MakeGroup("Orders", gridOrders), 0, 1);
            layout.Controls.Add(MakeGroup("Order Details", gridDetails), 0, 2);

            Controls.Add(layout);
            Controls.Add(top);
        }

        private static GroupBox MakeGroup(string title, DataGridView grid)
        {
            GroupBox box = new GroupBox { Text = title, Dock = DockStyle.Fill, Padding = new Padding(6) };
            box.Controls.Add(grid);
            return box;
        }

        private static void ConfigureGrid(DataGridView g)
        {
            g.Dock = DockStyle.Fill;
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowHeadersVisible = false;
        }

        private void LoadTables()
        {
            DataTable source = DbHelper.GetDataTable("SELECT Name FROM RestaurantTables ORDER BY Name");
            DataTable items = new DataTable();
            items.Columns.Add("Name", typeof(string));
            items.Rows.Add("All");
            foreach (DataRow row in source.Rows)
            {
                items.Rows.Add(row["Name"]);
            }

            loading = true;
            cboTable.DataSource = items;
            cboTable.DisplayMember = "Name";
            cboTable.SelectedIndex = 0;
            loading = false;
        }

        private void SetDefaultDate()
        {
            DataTable dt = DbHelper.GetDataTable("SELECT MAX(TransactionDate) AS MaxDate FROM Transactions");
            loading = true;
            if (dt.Rows.Count > 0 && dt.Rows[0]["MaxDate"] != DBNull.Value)
            {
                dtpDate.Value = Convert.ToDateTime(dt.Rows[0]["MaxDate"]).Date;
            }
            else
            {
                dtpDate.Value = DateTime.Today;
            }
            loading = false;
        }

        private void LoadTransactions()
        {
            if (loading)
            {
                return;
            }

            string sql = @"SELECT tr.TransactionID, t.Name AS TableName, tr.CustomerName, tr.TransactionDate, ISNULL(SUM(od.Price * od.Quantity), 0) AS TotalPrice
FROM Transactions tr
JOIN RestaurantTables t ON tr.TableID = t.TableID
LEFT JOIN Orders o ON o.TransactionID = tr.TransactionID
LEFT JOIN OrderDetails od ON od.OrderID = o.OrderID
WHERE CAST(tr.TransactionDate AS DATE) = @Date";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Date", dtpDate.Value.Date));

            string table = cboTable.SelectedItem == null ? "All" : cboTable.Text;
            if (table != "All" && table != "")
            {
                sql += " AND t.Name = @TableName";
                parameters.Add(new SqlParameter("@TableName", table));
            }

            sql += " GROUP BY tr.TransactionID, t.Name, tr.CustomerName, tr.TransactionDate ORDER BY tr.TransactionDate";

            DataTable dt = DbHelper.GetDataTable(sql, parameters.ToArray());

            loading = true;
            gridTrans.DataSource = dt;
            if (gridTrans.Columns.Contains("TransactionDate"))
            {
                gridTrans.Columns["TransactionDate"].DefaultCellStyle.Format = "dd MMMM yyyy";
            }
            if (dt.Rows.Count > 0)
            {
                gridTrans.CurrentCell = gridTrans.Rows[0].Cells[0];
                gridTrans.Rows[0].Selected = true;
            }
            loading = false;

            if (dt.Rows.Count > 0)
            {
                LoadOrders(Convert.ToInt32(dt.Rows[0]["TransactionID"]));
            }
            else
            {
                gridOrders.DataSource = null;
                gridDetails.DataSource = null;
            }
        }

        private void LoadOrders(int transactionID)
        {
            DataTable dt = DbHelper.GetDataTable(
                @"SELECT o.OrderID, o.TransactionID, o.OrderTime, e.Name AS Waitress, COUNT(od.OrderDetailID) AS Items
FROM Orders o
JOIN Employees e ON o.EmployeeID = e.EmployeeID
LEFT JOIN OrderDetails od ON od.OrderID = o.OrderID
WHERE o.TransactionID = @TransactionID
GROUP BY o.OrderID, o.TransactionID, o.OrderTime, e.Name
ORDER BY o.OrderID",
                new SqlParameter[] { new SqlParameter("@TransactionID", transactionID) });

            loading = true;
            gridOrders.DataSource = dt;
            if (gridOrders.Columns.Contains("OrderTime"))
            {
                gridOrders.Columns["OrderTime"].DefaultCellStyle.Format = "HH:mm:ss";
            }
            if (dt.Rows.Count > 0)
            {
                gridOrders.CurrentCell = gridOrders.Rows[0].Cells[0];
                gridOrders.Rows[0].Selected = true;
            }
            loading = false;

            if (dt.Rows.Count > 0)
            {
                LoadOrderDetails(Convert.ToInt32(dt.Rows[0]["OrderID"]));
            }
            else
            {
                gridDetails.DataSource = null;
            }
        }

        private void LoadOrderDetails(int orderID)
        {
            DataTable dt = DbHelper.GetDataTable(
                @"SELECT od.OrderID, od.OrderDetailID, m.Name AS MenuName, od.Quantity, od.Price
FROM OrderDetails od
JOIN MenuItems m ON od.MenuItemID = m.MenuItemID
WHERE od.OrderID = @OrderID
ORDER BY od.OrderDetailID",
                new SqlParameter[] { new SqlParameter("@OrderID", orderID) });

            loading = true;
            gridDetails.DataSource = dt;
            loading = false;
        }

        private void GridTrans_SelectionChanged(object sender, EventArgs e)
        {
            if (loading || gridTrans.CurrentRow == null)
            {
                return;
            }
            LoadOrders(Convert.ToInt32(gridTrans.CurrentRow.Cells["TransactionID"].Value));
        }

        private void GridOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (loading || gridOrders.CurrentRow == null)
            {
                return;
            }
            LoadOrderDetails(Convert.ToInt32(gridOrders.CurrentRow.Cells["OrderID"].Value));
        }
    }
}