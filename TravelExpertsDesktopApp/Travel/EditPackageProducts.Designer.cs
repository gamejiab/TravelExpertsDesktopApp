
namespace Travel
{
    partial class formEditPackageProducts
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPackageNameVal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGVPackageSuppProdList = new System.Windows.Forms.DataGridView();
            this.pkgSupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.dataGVSuppliers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPackageSuppProdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(440, 81);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(55, 21);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product";
            // 
            // lblPackageNameVal
            // 
            this.lblPackageNameVal.AutoSize = true;
            this.lblPackageNameVal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackageNameVal.Location = new System.Drawing.Point(172, 32);
            this.lblPackageNameVal.Name = "lblPackageNameVal";
            this.lblPackageNameVal.Size = new System.Drawing.Size(0, 26);
            this.lblPackageNameVal.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(725, 535);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 65);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGVPackageSuppProdList
            // 
            this.dataGVPackageSuppProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPackageSuppProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkgSupID,
            this.colSupplier,
            this.colProduct});
            this.dataGVPackageSuppProdList.Location = new System.Drawing.Point(26, 83);
            this.dataGVPackageSuppProdList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGVPackageSuppProdList.MultiSelect = false;
            this.dataGVPackageSuppProdList.Name = "dataGVPackageSuppProdList";
            this.dataGVPackageSuppProdList.RowTemplate.Height = 25;
            this.dataGVPackageSuppProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVPackageSuppProdList.Size = new System.Drawing.Size(393, 517);
            this.dataGVPackageSuppProdList.TabIndex = 3;
            // 
            // pkgSupID
            // 
            this.pkgSupID.DataPropertyName = "psID";
            this.pkgSupID.HeaderText = "ID";
            this.pkgSupID.Name = "pkgSupID";
            this.pkgSupID.ReadOnly = true;
            this.pkgSupID.Width = 50;
            // 
            // colSupplier
            // 
            this.colSupplier.DataPropertyName = "sName";
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            this.colSupplier.Width = 150;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "pName";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 150;
            // 
            // comboProduct
            // 
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(440, 105);
            this.comboProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(400, 28);
            this.comboProduct.TabIndex = 4;
            this.comboProduct.SelectedIndexChanged += new System.EventHandler(this.comboProduct_SelectedIndexChanged);
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackageName.Location = new System.Drawing.Point(26, 32);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(128, 26);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package Name";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupplierName.Location = new System.Drawing.Point(440, 163);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(60, 21);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(460, 535);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(87, 65);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Package";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSelected.Location = new System.Drawing.Point(584, 535);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(99, 65);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete Package";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // dataGVSuppliers
            // 
            this.dataGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SupplierName});
            this.dataGVSuppliers.Location = new System.Drawing.Point(440, 188);
            this.dataGVSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGVSuppliers.Name = "dataGVSuppliers";
            this.dataGVSuppliers.RowTemplate.Height = 25;
            this.dataGVSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVSuppliers.Size = new System.Drawing.Size(400, 317);
            this.dataGVSuppliers.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "psID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 55;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "sName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 300;
            // 
            // formEditPackageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(872, 648);
            this.Controls.Add(this.dataGVSuppliers);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.dataGVPackageSuppProdList);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPackageNameVal);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formEditPackageProducts";
            this.Text = "Add Products to the selected package";
            this.Load += new System.EventHandler(this.formEditPackageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPackageSuppProdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPackageNameVal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGVPackageSuppProdList;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgSupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridView dataGVSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
    }
}