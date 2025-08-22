using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_App
{
    public partial class Form1 : Form
    {
        // Connection string to your SQL Server instance
        private readonly string connectionString = @"Server=DESKTOP-DF0J081\SQLEXPRESS;Database=PharmacyDB;Integrated Security=true;";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllMedicines();
        }

        #region Database Operations

        /// <summary>
        /// Loads all medicines into the DataGridView
        /// </summary>
        private void LoadAllMedicines()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetAllMedicines", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridViewMedicines.DataSource = dataTable;
                        }
                    }
                }

                // Format the DataGridView columns
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicines: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Formats the DataGridView columns for better display
        /// </summary>
        private void FormatDataGridView()
        {
            if (dataGridViewMedicines.Columns.Count > 0)
            {
                dataGridViewMedicines.Columns["MedicineID"].HeaderText = "ID";
                dataGridViewMedicines.Columns["Name"].HeaderText = "Medicine Name";
                dataGridViewMedicines.Columns["Category"].HeaderText = "Category";
                dataGridViewMedicines.Columns["Price"].HeaderText = "Price ($)";
                dataGridViewMedicines.Columns["Quantity"].HeaderText = "Stock";

                // Set column widths
                dataGridViewMedicines.Columns["MedicineID"].Width = 60;
                dataGridViewMedicines.Columns["Name"].Width = 250;
                dataGridViewMedicines.Columns["Category"].Width = 150;
                dataGridViewMedicines.Columns["Price"].Width = 100;
                dataGridViewMedicines.Columns["Quantity"].Width = 100;

                // Format price column to show currency
                dataGridViewMedicines.Columns["Price"].DefaultCellStyle.Format = "C2";
            }
        }

        /// <summary>
        /// Adds a new medicine to the database
        /// </summary>
        private void AddMedicine(string name, string category, decimal price, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddMedicine", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        // Add parameters
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        MessageBox.Show("Medicine added successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Refresh the grid and clear form
                        LoadAllMedicines();
                        ClearAddMedicineForm();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches medicines by name or category
        /// </summary>
        private void SearchMedicines(string searchTerm)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SearchMedicine", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridViewMedicines.DataSource = dataTable;
                        }
                    }
                }

                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching medicines: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the stock quantity for a medicine
        /// </summary>
        private void UpdateStock(int medicineId, int newQuantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdateStock", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicineID", medicineId);
                        command.Parameters.AddWithValue("@Quantity", newQuantity);

                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        MessageBox.Show("Stock updated successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadAllMedicines();
                        ClearUpdateStockForm();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Records a sale transaction
        /// </summary>
        private void RecordSale(int medicineId, int quantitySold)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("RecordSale", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicineID", medicineId);
                        command.Parameters.AddWithValue("@QuantitySold", quantitySold);

                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        MessageBox.Show("Sale recorded successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadAllMedicines();
                        ClearRecordSaleForm();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event Handlers

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                MessageBox.Show("Please enter a medicine name.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Please enter a category.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity (0 or greater).", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Add the medicine
            AddMedicine(txtMedicineName.Text.Trim(), txtCategory.Text.Trim(), price, quantity);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            SearchMedicines(txtSearch.Text.Trim());
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMedicineID.Text, out int medicineId) || medicineId <= 0)
            {
                MessageBox.Show("Please enter a valid Medicine ID.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineID.Focus();
                return;
            }

            if (!int.TryParse(txtNewQuantity.Text, out int newQuantity) || newQuantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity (0 or greater).", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewQuantity.Focus();
                return;
            }

            UpdateStock(medicineId, newQuantity);
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMedicineID.Text, out int medicineId) || medicineId <= 0)
            {
                MessageBox.Show("Please select a medicine or enter a valid Medicine ID.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineID.Focus();
                return;
            }

            if (!int.TryParse(txtSaleQuantity.Text, out int saleQuantity) || saleQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid sale quantity greater than 0.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaleQuantity.Focus();
                return;
            }

            RecordSale(medicineId, saleQuantity);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadAllMedicines();
            txtSearch.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllForms();
        }

        private void dataGridViewMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewMedicines.Rows[e.RowIndex].Cells["MedicineID"].Value != null)
            {
                // Auto-populate Medicine ID when a row is clicked
                string medicineId = dataGridViewMedicines.Rows[e.RowIndex].Cells["MedicineID"].Value.ToString();
                txtMedicineID.Text = medicineId;

                // Also populate the medicine name in the search box for reference
                string medicineName = dataGridViewMedicines.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string currentStock = dataGridViewMedicines.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                
                // Show selected medicine info in status
                this.Text = $"Pharmacy Management System - Selected: {medicineName} (ID: {medicineId}, Stock: {currentStock})";
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Clears the Add Medicine form fields
        /// </summary>
        private void ClearAddMedicineForm()
        {
            txtMedicineName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        /// <summary>
        /// Clears the Update Stock form fields
        /// </summary>
        private void ClearUpdateStockForm()
        {
            txtMedicineID.Clear();
            txtNewQuantity.Clear();
        }

        /// <summary>
        /// Clears the Record Sale form fields
        /// </summary>
        private void ClearRecordSaleForm()
        {
            txtSaleQuantity.Clear();
        }

        /// <summary>
        /// Clears all form fields
        /// </summary>
        private void ClearAllForms()
        {
            ClearAddMedicineForm();
            ClearUpdateStockForm();
            ClearRecordSaleForm();
            txtSearch.Clear();
            this.Text = "Pharmacy Management System";
        }

        #endregion
    }
}
