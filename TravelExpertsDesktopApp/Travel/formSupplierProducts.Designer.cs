
namespace Travel
{
    partial class formSupplierProducts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.dataGVProdSupp = new System.Windows.Forms.DataGridView();
            this.ProductSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditProdSupp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(645, 507);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 76);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProducts.Location = new System.Drawing.Point(307, 507);
            this.btnAddProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(136, 76);
            this.btnAddProducts.TabIndex = 9;
            this.btnAddProducts.Text = "Add Product Supplier";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuppliers.Location = new System.Drawing.Point(173, 507);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(114, 76);
            this.btnSuppliers.TabIndex = 10;
            this.btnSuppliers.Text = "View/Edit List of Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.Location = new System.Drawing.Point(28, 507);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(121, 76);
            this.btnProducts.TabIndex = 11;
            this.btnProducts.Text = "View/Edit List of Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // dataGVProdSupp
            // 
            this.dataGVProdSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProdSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSupplierID,
            this.ProductName,
            this.SupplierName});
            this.dataGVProdSupp.Location = new System.Drawing.Point(28, 35);
            this.dataGVProdSupp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGVProdSupp.MultiSelect = false;
            this.dataGVProdSupp.Name = "dataGVProdSupp";
            this.dataGVProdSupp.RowTemplate.Height = 25;
            this.dataGVProdSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVProdSupp.Size = new System.Drawing.Size(725, 423);
            this.dataGVProdSupp.TabIndex = 6;
            // 
            // ProductSupplierID
            // 
            this.ProductSupplierID.DataPropertyName = "ProductSupplierID";
            this.ProductSupplierID.HeaderText = "ID";
            this.ProductSupplierID.Name = "ProductSupplierID";
            this.ProductSupplierID.ReadOnly = true;
            this.ProductSupplierID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductSupplierID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProdName";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.Width = 275;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupName";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SupplierName.DefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierName.Width = 275;
            // 
            // btnEditProdSupp
            // 
            this.btnEditProdSupp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditProdSupp.Location = new System.Drawing.Point(468, 507);
            this.btnEditProdSupp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditProdSupp.Name = "btnEditProdSupp";
            this.btnEditProdSupp.Size = new System.Drawing.Size(147, 76);
            this.btnEditProdSupp.TabIndex = 10;
            this.btnEditProdSupp.Text = "Edit Product Suppliers";
            this.btnEditProdSupp.UseVisualStyleBackColor = true;
            this.btnEditProdSupp.Click += new System.EventHandler(this.btnEditProdSupp_Click);
            // 
            // formSupplierProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(799, 632);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnEditProdSupp);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.dataGVProdSupp);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "formSupplierProducts";
            this.Text = "Products and Suppliers";
            this.Load += new System.EventHandler(this.formSupplierProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdSupp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.DataGridView dataGVProdSupp;
        private System.Windows.Forms.Button btnEditProdSupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
    }
}

