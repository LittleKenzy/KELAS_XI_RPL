using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HovSalad
{
    public partial class FormAddIngredient : Form
    {
        // Property untuk mengembalikan data pilihan ke FormOrder
        public IngredientItem SelectedIngredient { get; private set; }

        private string connectionString = ConfigurationManager.ConnectionStrings["HovSaladConnection"].ConnectionString;

        public FormAddIngredient()
        {
            InitializeComponent();
            SetupFormUI();
            LoadCategories();
        }

        private void SetupFormUI()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            try { this.Icon = new Icon("Logo_HovSalad.ico"); } catch { }
        }

        // 1. Fetch data Category dari Database SQL
        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT categoryID, categoryName FROM Category";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "categoryName";
                    cmbCategory.ValueMember = "categoryID";
                    cmbCategory.SelectedIndex = -1; // Kosongkan pilihan awal
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. Fetch Ingredient secara dinamis saat Kategori dipilih
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset ComboBox Ingredient jika kategori belum/tidak terpilih
            if (cmbCategory.SelectedValue == null || !(cmbCategory.SelectedValue is int))
            {
                cmbIngredientName.DataSource = null;
                return;
            }

            int categoryID = Convert.ToInt32(cmbCategory.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ingredientID, ingredientName, price FROM Ingredient WHERE categoryID = @categoryID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Lepas event handler sebentar agar tidak memicu cmbIngredientName_SelectedIndexChanged saat bind data
                    cmbIngredientName.SelectedIndexChanged -= cmbIngredientName_SelectedIndexChanged;

                    cmbIngredientName.DataSource = dt;
                    cmbIngredientName.DisplayMember = "ingredientName";
                    cmbIngredientName.ValueMember = "ingredientID";
                    cmbIngredientName.SelectedIndex = -1; // Kosongkan pilihan awal agar user memilih

                    // Pasang kembali event handler
                    cmbIngredientName.SelectedIndexChanged += cmbIngredientName_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ingredients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. Menampilkan Harga saat Ingredient Dipilih oleh User
        private void cmbIngredientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil harga langsung dari DataRowView yang sedang dipilih tanpa query ulang ke SQL
            if (cmbIngredientName.SelectedItem is DataRowView drv)
            {
                decimal price = Convert.ToDecimal(drv["price"]);
                // Tampilkan ke label harga (jika Anda memiliki control lblPrice)
                // lblPrice.Text = $"Rp {price:N0}";
            }
        }

        // 4. Validasi & Submit Bahan
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbIngredientName.SelectedIndex == -1 || cmbIngredientName.SelectedItem == null)
            {
                MessageBox.Show("Please select an Ingredient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drvIng = (DataRowView)cmbIngredientName.SelectedItem;
            DataRowView drvCat = (DataRowView)cmbCategory.SelectedItem;

            SelectedIngredient = new IngredientItem
            {
                IngredientID = Convert.ToInt32(drvIng["ingredientID"]),
                CategoryID = Convert.ToInt32(drvCat["categoryID"]),
                CategoryName = drvCat["categoryName"].ToString(),
                IngredientName = drvIng["ingredientName"].ToString(),
                Price = Convert.ToDecimal(drvIng["price"]),
                Quantity = Convert.ToInt32(numQuantity.Value)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}