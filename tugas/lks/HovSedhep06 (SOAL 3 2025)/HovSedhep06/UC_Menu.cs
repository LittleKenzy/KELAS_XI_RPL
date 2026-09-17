using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HovSedhep06
{
    public class UC_Menu : UserControl
    {
        private readonly ComboBox cboCategory = new ComboBox();
        private readonly TextBox txtSearch = new TextBox();
        private readonly DataGridView grid = new DataGridView();
        private bool loading;

        public UC_Menu()
        {
            Dock = DockStyle.Fill;
            BuildUi();
            LoadCategories();
            LoadMenu();
        }

        private void BuildUi()
        {
            Panel top = new Panel { Dock = DockStyle.Top, Height = 50, Padding = new Padding(10, 12, 10, 0) };

            Label lblCategory = new Label { Text = "Category", Location = new Point(12, 17), AutoSize = true };
            cboCategory.Location = new Point(75, 13);
            cboCategory.Width = 180;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.SelectedIndexChanged += (s, e) => LoadMenu();

            Label lblSearch = new Label { Text = "Search", Location = new Point(280, 17), AutoSize = true };
            txtSearch.Location = new Point(335, 13);
            txtSearch.Width = 220;
            txtSearch.TextChanged += (s, e) => LoadMenu();

            top.Controls.Add(lblCategory);
            top.Controls.Add(cboCategory);
            top.Controls.Add(lblSearch);
            top.Controls.Add(txtSearch);

            ConfigureGrid(grid);

            Controls.Add(grid);
            Controls.Add(top);
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
            g.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            g.RowHeadersVisible = false;
        }

        private void LoadCategories()
        {
            DataTable source = DbHelper.GetDataTable("SELECT Name FROM Categories ORDER BY Name");
            DataTable items = new DataTable();
            items.Columns.Add("Name", typeof(string));
            items.Rows.Add("All");
            foreach (DataRow row in source.Rows)
            {
                items.Rows.Add(row["Name"]);
            }

            loading = true;
            cboCategory.DataSource = items;
            cboCategory.DisplayMember = "Name";
            cboCategory.SelectedIndex = 0;
            loading = false;
        }

        private void LoadMenu()
        {
            if (loading)
            {
                return;
            }

            string sql = "SELECT m.MenuItemID AS ID, c.Name AS Category, m.Name AS [Menu Name], m.Price AS Price, m.Description AS Description FROM MenuItems m JOIN Categories c ON m.CategoryID = c.CategoryID WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            string category = cboCategory.SelectedItem == null ? "All" : cboCategory.Text;
            if (category != "All" && category != "")
            {
                sql += " AND c.Name = @Category";
                parameters.Add(new SqlParameter("@Category", category));
            }

            string search = txtSearch.Text.Trim();
            if (search.Length > 0)
            {
                sql += " AND m.Name LIKE @Search";
                parameters.Add(new SqlParameter("@Search", "%" + search + "%"));
            }

            sql += " ORDER BY m.MenuItemID";

            grid.DataSource = DbHelper.GetDataTable(sql, parameters.ToArray());
        }
    }
}