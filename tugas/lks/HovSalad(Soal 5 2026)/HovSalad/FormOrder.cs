using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HovSalad
{
    public partial class FormOrder : Form
    {
        // Penampung data item dan status transaksi di memori
        private List<OrderItemDetail> orderItems = new List<OrderItemDetail>();
        private OrderItemDetail selectedItem = null;
        private bool isSubmitted = false;

        // String koneksi ke SQL Server
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

        public FormOrder()
        {
            InitializeComponent();
            SetupFormUI();
            InitializeDataGridColumns();
            RegisterEvents();
        }

        // 1. Pengaturan Tampilan & Properti Dasar Form
        private void SetupFormUI()
        {
            this.Text = "Hov Salad - Order Form";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            try { this.Icon = new Icon("Logo_HovSalad.ico"); } catch { }
        }

        // 2. Registrasi Event Handling Kontrol Form
        private void RegisterEvents()
        {
            this.FormClosing += FormOrder_FormClosing;
            this.btnAddSalad.Click += btnAddSalad_Click;
            this.btnAddProteinBowl.Click += btnAddProteinBowl_Click;
            this.btnAddIngredients.Click += btnAddIngredients_Click;
            this.btnSubmit.Click += btnSubmit_Click;
            this.btnBackToHome.Click += btnBackToHome_Click;

            this.dgvOrderItems.SelectionChanged += dgvOrderItems_SelectionChanged;
            this.dgvOrderItems.CellContentClick += dgvOrderItems_CellContentClick;
            this.dgvOrderItems.CellEndEdit += dgvOrderItems_CellEndEdit;

            this.dgvIngredients.CellContentClick += dgvIngredients_CellContentClick;
            this.dgvIngredients.CellEndEdit += dgvIngredients_CellEndEdit;
        }

        // 3. Inisialisasi Kolom DataGridView (Order Items & Ingredients)
        private void InitializeDataGridColumns()
        {
            // --- Table Order Items ---
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.Columns.Clear();

            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "No", HeaderText = "No", ReadOnly = true });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "Type", HeaderText = "Type", ReadOnly = true });

            // Kolom Quantity dapat diedit (Background Kuning)
            var colItemQty = new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Quantity" };
            colItemQty.DefaultCellStyle.BackColor = Color.LightYellow;
            dgvOrderItems.Columns.Add(colItemQty);

            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Price", ReadOnly = true });

            var btnRemoveItem = new DataGridViewButtonColumn
            {
                Name = "Remove",
                HeaderText = "",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            };
            dgvOrderItems.Columns.Add(btnRemoveItem);

            // --- Table Ingredients ---
            dgvIngredients.AutoGenerateColumns = false;
            dgvIngredients.Columns.Clear();

            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn { Name = "Category", HeaderText = "Category", ReadOnly = true });
            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Name", ReadOnly = true });

            // Kolom Quantity Ingredient dapat diedit (Background Kuning)
            var colIngQty = new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Quantity" };
            colIngQty.DefaultCellStyle.BackColor = Color.LightYellow;
            dgvIngredients.Columns.Add(colIngQty);

            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Price", ReadOnly = true });
            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn { Name = "SubTotal", HeaderText = "Sub Total", ReadOnly = true });

            var btnRemoveIng = new DataGridViewButtonColumn
            {
                Name = "Remove",
                HeaderText = "",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            };
            dgvIngredients.Columns.Add(btnRemoveIng);
        }

        // 4. Tambah Item Baru (Salad / Protein Bowl)
        private void btnAddSalad_Click(object sender, EventArgs e) => AddNewItem("Salad");
        private void btnAddProteinBowl_Click(object sender, EventArgs e) => AddNewItem("Protein Bowl");

        private void AddNewItem(string itemType)
        {
            if (isSubmitted) return;

            var newItem = new OrderItemDetail
            {
                SequenceNo = orderItems.Count + 1,
                ItemType = itemType,
                Quantity = 1
            };

            // Tambahkan Base Otomatis sesuai Aturan Bisnis
            if (itemType == "Salad")
            {
                // Base: Lettuce (ID: 2, CategoryID: 1, Price: 8000)
                newItem.Ingredients.Add(new IngredientItem { IngredientID = 2, CategoryID = 1, CategoryName = "Base", IngredientName = "Lettuce", Quantity = 1, Price = 8000 });
            }
            else if (itemType == "Protein Bowl")
            {
                // Base: Rice (ID: 1, CategoryID: 1, Price: 10000)
                newItem.Ingredients.Add(new IngredientItem { IngredientID = 1, CategoryID = 1, CategoryName = "Base", IngredientName = "Rice", Quantity = 1, Price = 10000 });
            }

            orderItems.Add(newItem);
            RefreshOrderItemsGrid();

            // Otomatis pilih item baru yang ditambahkan
            selectedItem = newItem;
            SelectRowInOrderGrid(orderItems.Count - 1);
            RefreshIngredientsGrid();
            UpdateTotalOrderPrice();
        }

        // 5. Perbarui Tampilan Tabel Order Items
        private void RefreshOrderItemsGrid()
        {
            dgvOrderItems.Rows.Clear();
            for (int i = 0; i < orderItems.Count; i++)
            {
                var item = orderItems[i];
                item.SequenceNo = i + 1; // Re-sequence nomor urut
                dgvOrderItems.Rows.Add(item.SequenceNo, item.ItemType, item.Quantity, item.TotalPrice.ToString("N0"));
            }
        }

        // 6. Perbarui Tampilan Tabel Ingredients Berdasarkan Item Terpilih
        private void RefreshIngredientsGrid()
        {
            dgvIngredients.Rows.Clear();
            if (selectedItem == null) return;

            foreach (var ing in selectedItem.Ingredients)
            {
                dgvIngredients.Rows.Add(ing.CategoryName, ing.IngredientName, ing.Quantity, ing.Price.ToString("N0"), ing.SubTotal.ToString("N0"));
            }
        }

        // 7. Kalkulasi Total Harga Keseluruhan Transaksi
        private void UpdateTotalOrderPrice()
        {
            decimal total = orderItems.Sum(x => x.TotalPrice);
            lblTotal.Text = $"Total: Rp{total:N0}";
        }

        // Helper untuk menandai baris terpilih pada DataGridView
        private void SelectRowInOrderGrid(int index)
        {
            if (index >= 0 && index < dgvOrderItems.Rows.Count)
            {
                dgvOrderItems.ClearSelection();
                dgvOrderItems.Rows[index].Selected = true;
                dgvOrderItems.CurrentCell = dgvOrderItems.Rows[index].Cells[0];
            }
        }

        // 8. Event Pilihan Baris Berubah di Tabel Order Items
        private void dgvOrderItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderItems.CurrentRow != null && dgvOrderItems.CurrentRow.Index < orderItems.Count)
            {
                selectedItem = orderItems[dgvOrderItems.CurrentRow.Index];
                RefreshIngredientsGrid();
            }
        }

        // 9. Event Hapus Item (Tombol 'Remove' di Tabel Order Items)
        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isSubmitted || e.RowIndex < 0) return;

            if (dgvOrderItems.Columns[e.ColumnIndex].Name == "Remove")
            {
                orderItems.RemoveAt(e.RowIndex);
                if (orderItems.Count == 0) selectedItem = null;

                RefreshOrderItemsGrid();
                RefreshIngredientsGrid();
                UpdateTotalOrderPrice();
            }
        }

        // 10. Event Hapus Bahan (Tombol 'Remove' di Tabel Ingredients)
        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isSubmitted || e.RowIndex < 0 || selectedItem == null) return;

            if (dgvIngredients.Columns[e.ColumnIndex].Name == "Remove")
            {
                selectedItem.Ingredients.RemoveAt(e.RowIndex);

                RefreshIngredientsGrid();
                RefreshOrderItemsGrid();
                UpdateTotalOrderPrice();
            }
        }

        // 11. Validasi & Update Kuantitas Item saat Di-Edit pada Tabel Order Items
        private void dgvOrderItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isSubmitted || e.RowIndex < 0) return;

            if (dgvOrderItems.Columns[e.ColumnIndex].Name == "Quantity")
            {
                var cellValue = dgvOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue == null || !int.TryParse(cellValue.ToString(), out int newQty) || newQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive numeric value greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = orderItems[e.RowIndex].Quantity;
                    return;
                }

                orderItems[e.RowIndex].Quantity = newQty;
                RefreshOrderItemsGrid();
                UpdateTotalOrderPrice();
            }
        }

        // 12. Validasi & Update Kuantitas Bahan saat Di-Edit pada Tabel Ingredients
        private void dgvIngredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isSubmitted || e.RowIndex < 0 || selectedItem == null) return;

            if (dgvIngredients.Columns[e.ColumnIndex].Name == "Quantity")
            {
                var cellValue = dgvIngredients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue == null || !int.TryParse(cellValue.ToString(), out int newQty) || newQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive numeric value greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvIngredients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = selectedItem.Ingredients[e.RowIndex].Quantity;
                    return;
                }

                selectedItem.Ingredients[e.RowIndex].Quantity = newQty;
                RefreshIngredientsGrid();
                RefreshOrderItemsGrid();
                UpdateTotalOrderPrice();
            }
        }

        // 13. Membuka Form Add Ingredient Dialog
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            if (isSubmitted) return;

            if (selectedItem == null)
            {
                MessageBox.Show("Please select an order item first before adding ingredients.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormAddIngredient formAdd = new FormAddIngredient())
            {
                if (formAdd.ShowDialog(this) == DialogResult.OK)
                {
                    var newIng = formAdd.SelectedIngredient;

                    // Jika ingredient sudah ada di item terpilih, tambahkan kuantitasnya
                    var existingIng = selectedItem.Ingredients.FirstOrDefault(i => i.IngredientID == newIng.IngredientID);
                    if (existingIng != null)
                    {
                        existingIng.Quantity += newIng.Quantity;
                    }
                    else
                    {
                        selectedItem.Ingredients.Add(newIng);
                    }

                    RefreshIngredientsGrid();
                    RefreshOrderItemsGrid();
                    UpdateTotalOrderPrice();
                }
            }
        }

        // 14. Validasi Aturan Bisnis Komposisi Produk
        private bool ValidateOrderRules(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorMessage = "Customer Name cannot be empty.";
                return false;
            }

            if (orderItems.Count == 0)
            {
                errorMessage = "Order must contain at least one item.";
                return false;
            }

            foreach (var item in orderItems)
            {
                if (item.ItemType == "Salad")
                {
                    bool hasVeg = item.Ingredients.Any(i => i.CategoryName.Equals("Vegetable", StringComparison.OrdinalIgnoreCase));
                    bool hasDressing = item.Ingredients.Any(i => i.CategoryName.Equals("Dressing", StringComparison.OrdinalIgnoreCase));

                    if (!hasVeg || !hasDressing)
                    {
                        errorMessage = $"Item No {item.SequenceNo} (Salad) requires at least 1 Vegetable and 1 Dressing.";
                        return false;
                    }
                }
                else if (item.ItemType == "Protein Bowl")
                {
                    bool hasProtein = item.Ingredients.Any(i => i.CategoryName.Equals("Protein", StringComparison.OrdinalIgnoreCase));
                    bool hasTopping = item.Ingredients.Any(i => i.CategoryName.Equals("Topping", StringComparison.OrdinalIgnoreCase));

                    if (!hasProtein || !hasTopping)
                    {
                        errorMessage = $"Item No {item.SequenceNo} (Protein Bowl) requires at least 1 Protein and 1 Topping.";
                        return false;
                    }
                }
            }

            return true;
        }

        // 15. Submit Order Ke SQL Server Transaction
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderRules(out string errorMsg))
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderCode = GenerateOrderCode();
            decimal totalPrice = orderItems.Sum(x => x.TotalPrice);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // A. Insert CustomerOrder Header
                    string queryOrder = @"INSERT INTO CustomerOrder (customerOrderCode, customerName, totalPrice, orderDate)
                                          OUTPUT INSERTED.customerOrderID
                                          VALUES (@code, @name, @total, GETDATE())";

                    SqlCommand cmdOrder = new SqlCommand(queryOrder, conn, transaction);
                    cmdOrder.Parameters.AddWithValue("@code", orderCode);
                    cmdOrder.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim());
                    cmdOrder.Parameters.AddWithValue("@total", totalPrice);

                    int customerOrderID = (int)cmdOrder.ExecuteScalar();

                    // B. Insert OrderItems & ItemIngredients
                    foreach (var item in orderItems)
                    {
                        string queryItem = @"INSERT INTO OrderItems (customerOrderID, itemType, quantity)
                                             OUTPUT INSERTED.orderItemsID
                                             VALUES (@orderID, @itemType, @qty)";

                        SqlCommand cmdItem = new SqlCommand(queryItem, conn, transaction);
                        cmdItem.Parameters.AddWithValue("@orderID", customerOrderID);
                        cmdItem.Parameters.AddWithValue("@itemType", item.ItemType);
                        cmdItem.Parameters.AddWithValue("@qty", item.Quantity);

                        int orderItemsID = (int)cmdItem.ExecuteScalar();

                        foreach (var ing in item.Ingredients)
                        {
                            string queryIng = @"INSERT INTO ItemIngredients (orderItemsID, ingredientID, quantity)
                                                VALUES (@orderItemsID, @ingID, @qty)";

                            SqlCommand cmdIng = new SqlCommand(queryIng, conn, transaction);
                            cmdIng.Parameters.AddWithValue("@orderItemsID", orderItemsID);
                            cmdIng.Parameters.AddWithValue("@ingID", ing.IngredientID);
                            cmdIng.Parameters.AddWithValue("@qty", ing.Quantity);

                            cmdIng.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    // C. Ubah Tampilan Form ke Mode Read-Only
                    SetFormToReadOnlyState(orderCode);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction Failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 16. Generate Kode Unik: YYMMDD-HHMMSS-XXXXXX
        private string GenerateOrderCode()
        {
            string timePart = DateTime.Now.ToString("yyMMdd-HHmmss");
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] randomChars = new char[6];

            for (int i = 0; i < 6; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }

            return $"{timePart}-{new string(randomChars)}";
        }

        // 17. Transisi Form ke Mode Read-Only Setelah Submit
        private void SetFormToReadOnlyState(string orderCode)
        {
            isSubmitted = true;

            txtCustomerName.ReadOnly = true;
            btnAddSalad.Enabled = false;
            btnAddProteinBowl.Enabled = false;
            btnAddIngredients.Enabled = false;

            dgvOrderItems.ReadOnly = true;
            dgvIngredients.ReadOnly = true;

            btnSubmit.Visible = false;
            btnBackToHome.Visible = true;

            lblOrderCode.Text = $"Order Code: {orderCode}";
            lblOrderCode.Visible = true;

            MessageBox.Show("Order submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 18. Tombol Kembali ke Menu Utama
        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 19. Konfirmasi Peringatan Saat Menutup Form Jika Unsaved
        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSubmitted) return;

            var result = MessageBox.Show(
                "Any unsaved changes or progress will be lost. Are you sure you want to close?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Batalkan penutupan form
            }
        }
    }
}