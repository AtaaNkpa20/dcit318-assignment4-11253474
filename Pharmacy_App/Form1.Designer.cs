namespace Pharmacy_App
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
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.txtNewQuantity = new System.Windows.Forms.TextBox();
            this.txtSaleQuantity = new System.Windows.Forms.TextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnRecordSale = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.lblNewQuantity = new System.Windows.Forms.Label();
            this.lblSaleQuantity = new System.Windows.Forms.Label();
            this.groupBoxAddMedicine = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxUpdateStock = new System.Windows.Forms.GroupBox();
            this.groupBoxRecordSale = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).BeginInit();
            this.groupBoxAddMedicine.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxUpdateStock.SuspendLayout();
            this.groupBoxRecordSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(350, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pharmacy Management System";
            // 
            // groupBoxAddMedicine
            // 
            this.groupBoxAddMedicine.Controls.Add(this.lblMedicineName);
            this.groupBoxAddMedicine.Controls.Add(this.txtMedicineName);
            this.groupBoxAddMedicine.Controls.Add(this.lblCategory);
            this.groupBoxAddMedicine.Controls.Add(this.txtCategory);
            this.groupBoxAddMedicine.Controls.Add(this.lblPrice);
            this.groupBoxAddMedicine.Controls.Add(this.txtPrice);
            this.groupBoxAddMedicine.Controls.Add(this.lblQuantity);
            this.groupBoxAddMedicine.Controls.Add(this.txtQuantity);
            this.groupBoxAddMedicine.Controls.Add(this.btnAddMedicine);
            this.groupBoxAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxAddMedicine.Location = new System.Drawing.Point(20, 60);
            this.groupBoxAddMedicine.Name = "groupBoxAddMedicine";
            this.groupBoxAddMedicine.Size = new System.Drawing.Size(250, 200);
            this.groupBoxAddMedicine.TabIndex = 1;
            this.groupBoxAddMedicine.TabStop = false;
            this.groupBoxAddMedicine.Text = "Add Medicine";
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMedicineName.Location = new System.Drawing.Point(10, 25);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(81, 13);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "Medicine Name:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(10, 42);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(220, 21);
            this.txtMedicineName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCategory.Location = new System.Drawing.Point(10, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(10, 87);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(220, 21);
            this.txtCategory.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPrice.Location = new System.Drawing.Point(10, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(10, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblQuantity.Location = new System.Drawing.Point(130, 115);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(130, 132);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity.TabIndex = 7;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddMedicine.Location = new System.Drawing.Point(10, 165);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(220, 25);
            this.btnAddMedicine.TabIndex = 8;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.lblSearch);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxSearch.Location = new System.Drawing.Point(290, 60);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(250, 100);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Medicine";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSearch.Location = new System.Drawing.Point(10, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(128, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search by Name/Category:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 21);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Location = new System.Drawing.Point(180, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxUpdateStock
            // 
            this.groupBoxUpdateStock.Controls.Add(this.lblMedicineID);
            this.groupBoxUpdateStock.Controls.Add(this.txtMedicineID);
            this.groupBoxUpdateStock.Controls.Add(this.lblNewQuantity);
            this.groupBoxUpdateStock.Controls.Add(this.txtNewQuantity);
            this.groupBoxUpdateStock.Controls.Add(this.btnUpdateStock);
            this.groupBoxUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxUpdateStock.Location = new System.Drawing.Point(560, 60);
            this.groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            this.groupBoxUpdateStock.Size = new System.Drawing.Size(250, 130);
            this.groupBoxUpdateStock.TabIndex = 3;
            this.groupBoxUpdateStock.TabStop = false;
            this.groupBoxUpdateStock.Text = "Update Stock";
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMedicineID.Location = new System.Drawing.Point(10, 25);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(68, 13);
            this.lblMedicineID.TabIndex = 0;
            this.lblMedicineID.Text = "Medicine ID:";
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Location = new System.Drawing.Point(10, 42);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.Size = new System.Drawing.Size(100, 21);
            this.txtMedicineID.TabIndex = 1;
            // 
            // lblNewQuantity
            // 
            this.lblNewQuantity.AutoSize = true;
            this.lblNewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNewQuantity.Location = new System.Drawing.Point(10, 70);
            this.lblNewQuantity.Name = "lblNewQuantity";
            this.lblNewQuantity.Size = new System.Drawing.Size(74, 13);
            this.lblNewQuantity.TabIndex = 2;
            this.lblNewQuantity.Text = "New Quantity:";
            // 
            // txtNewQuantity
            // 
            this.txtNewQuantity.Location = new System.Drawing.Point(10, 87);
            this.txtNewQuantity.Name = "txtNewQuantity";
            this.txtNewQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtNewQuantity.TabIndex = 3;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateStock.Location = new System.Drawing.Point(130, 60);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateStock.TabIndex = 4;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // groupBoxRecordSale
            // 
            this.groupBoxRecordSale.Controls.Add(this.lblSaleQuantity);
            this.groupBoxRecordSale.Controls.Add(this.txtSaleQuantity);
            this.groupBoxRecordSale.Controls.Add(this.btnRecordSale);
            this.groupBoxRecordSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxRecordSale.Location = new System.Drawing.Point(830, 60);
            this.groupBoxRecordSale.Name = "groupBoxRecordSale";
            this.groupBoxRecordSale.Size = new System.Drawing.Size(200, 130);
            this.groupBoxRecordSale.TabIndex = 4;
            this.groupBoxRecordSale.TabStop = false;
            this.groupBoxRecordSale.Text = "Record Sale";
            // 
            // lblSaleQuantity
            // 
            this.lblSaleQuantity.AutoSize = true;
            this.lblSaleQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSaleQuantity.Location = new System.Drawing.Point(10, 25);
            this.lblSaleQuantity.Name = "lblSaleQuantity";
            this.lblSaleQuantity.Size = new System.Drawing.Size(76, 13);
            this.lblSaleQuantity.TabIndex = 0;
            this.lblSaleQuantity.Text = "Sale Quantity:";
            // 
            // txtSaleQuantity
            // 
            this.txtSaleQuantity.Location = new System.Drawing.Point(10, 42);
            this.txtSaleQuantity.Name = "txtSaleQuantity";
            this.txtSaleQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtSaleQuantity.TabIndex = 1;
            // 
            // btnRecordSale
            // 
            this.btnRecordSale.BackColor = System.Drawing.Color.Pink;
            this.btnRecordSale.Location = new System.Drawing.Point(10, 75);
            this.btnRecordSale.Name = "btnRecordSale";
            this.btnRecordSale.Size = new System.Drawing.Size(170, 40);
            this.btnRecordSale.TabIndex = 2;
            this.btnRecordSale.Text = "Record Sale";
            this.btnRecordSale.UseVisualStyleBackColor = false;
            this.btnRecordSale.Click += new System.EventHandler(this.btnRecordSale_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.LightCyan;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.Location = new System.Drawing.Point(290, 170);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(100, 35);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(410, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridViewMedicines
            // 
            this.dataGridViewMedicines.AllowUserToAddRows = false;
            this.dataGridViewMedicines.AllowUserToDeleteRows = false;
            this.dataGridViewMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMedicines.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicines.Location = new System.Drawing.Point(20, 280);
            this.dataGridViewMedicines.Name = "dataGridViewMedicines";
            this.dataGridViewMedicines.ReadOnly = true;
            this.dataGridViewMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicines.Size = new System.Drawing.Size(1010, 300);
            this.dataGridViewMedicines.TabIndex = 7;
            this.dataGridViewMedicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicines_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dataGridViewMedicines);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.groupBoxRecordSale);
            this.Controls.Add(this.groupBoxUpdateStock);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAddMedicine);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).EndInit();
            this.groupBoxAddMedicine.ResumeLayout(false);
            this.groupBoxAddMedicine.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxUpdateStock.ResumeLayout(false);
            this.groupBoxUpdateStock.PerformLayout();
            this.groupBoxRecordSale.ResumeLayout(false);
            this.groupBoxRecordSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.TextBox txtNewQuantity;
        private System.Windows.Forms.TextBox txtSaleQuantity;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnRecordSale;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.Label lblNewQuantity;
        private System.Windows.Forms.Label lblSaleQuantity;
        private System.Windows.Forms.GroupBox groupBoxAddMedicine;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxUpdateStock;
        private System.Windows.Forms.GroupBox groupBoxRecordSale;
        private System.Windows.Forms.Label lblTitle;
    }
}

