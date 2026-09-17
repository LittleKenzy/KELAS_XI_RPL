using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HovSedhep06
{
    public partial class UC_TableSeating : UserControl
    {
        public UC_TableSeating()
        {
            InitializeComponent();
        }

        private void UC_TableSeating_Load(object sender, EventArgs e)
        {
            RefreshTables();
        }

        public void RefreshTables()
        {
            // Ambil semua nama meja yang transaksinya berstatus 'Ongoing'
            string query = @"
                SELECT t.Name 
                FROM Transactions tr 
                JOIN RestaurantTables t ON tr.TableID = t.TableID 
                WHERE tr.Status = 'Ongoing'";

            DataTable dt = DbHelper.GetDataTable(query);

            HashSet<string> occupiedTables = new HashSet<string>();
            foreach (DataRow row in dt.Rows)
            {
                occupiedTables.Add(row["Name"].ToString());
            }

            // Kumpulkan tombol meja ke dalam array
            Button[] buttons = new Button[] { btnA1, btnA2, btnA3, btnA4, btnB1, btnB2, btnC1, btnC2 };

            foreach (Button btn in buttons)
            {
                string tableName = btn.Text; // Teks tombol (A1, A2, dst.)

                if (occupiedTables.Contains(tableName))
                {
                    btn.BackColor = Color.Yellow; // Berwarna kuning jika meja sedang terisi
                }
                else
                {
                    btn.BackColor = Color.LightGray; // Warna standar jika meja kosong
                }
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string tableName = clickedButton.Text;

            // Cari ID dan Kapasitas Meja dari database
            string qTable = "SELECT TableID, Capacity FROM RestaurantTables WHERE Name = @Name";
            DataTable dtTable = DbHelper.GetDataTable(qTable, new SqlParameter[] {
                new SqlParameter("@Name", tableName)
            });

            if (dtTable.Rows.Count == 0) return;

            int tableID = Convert.ToInt32(dtTable.Rows[0]["TableID"]);
            int capacity = Convert.ToInt32(dtTable.Rows[0]["Capacity"]);

            if (clickedButton.BackColor == Color.Yellow)
            {
                // Jika meja terisi (kuning), buka form detail meja
                TableDetailForm detailForm = new TableDetailForm(tableID, tableName);
                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshTables();
                }
            }
            else
            {
                // Jika meja kosong, buka form alokasi meja
                AssignTableForm assignForm = new AssignTableForm(tableID, tableName, capacity);
                if (assignForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshTables();
                }
            }
        }
    }
}