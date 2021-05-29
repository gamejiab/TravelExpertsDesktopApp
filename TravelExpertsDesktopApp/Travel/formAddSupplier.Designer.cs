
namespace Travel
{
    partial class formAddSupplier
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.SupplierNameLbl = new System.Windows.Forms.Label();
            this.SupplierIdLbl = new System.Windows.Forms.Label();
            this.SupplierNametxt = new System.Windows.Forms.TextBox();
            this.SupplierIdtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(230, 199);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 43);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.Location = new System.Drawing.Point(84, 199);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 43);
            this.acceptBtn.TabIndex = 10;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // SupplierNameLbl
            // 
            this.SupplierNameLbl.AutoSize = true;
            this.SupplierNameLbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupplierNameLbl.Location = new System.Drawing.Point(16, 123);
            this.SupplierNameLbl.Name = "SupplierNameLbl";
            this.SupplierNameLbl.Size = new System.Drawing.Size(97, 21);
            this.SupplierNameLbl.TabIndex = 9;
            this.SupplierNameLbl.Text = "Supplier Name";
            // 
            // SupplierIdLbl
            // 
            this.SupplierIdLbl.AutoSize = true;
            this.SupplierIdLbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupplierIdLbl.Location = new System.Drawing.Point(16, 59);
            this.SupplierIdLbl.Name = "SupplierIdLbl";
            this.SupplierIdLbl.Size = new System.Drawing.Size(76, 21);
            this.SupplierIdLbl.TabIndex = 8;
            this.SupplierIdLbl.Text = "Supplier ID";
            // 
            // SupplierNametxt
            // 
            this.SupplierNametxt.Location = new System.Drawing.Point(130, 120);
            this.SupplierNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupplierNametxt.MaxLength = 255;
            this.SupplierNametxt.Name = "SupplierNametxt";
            this.SupplierNametxt.Size = new System.Drawing.Size(221, 25);
            this.SupplierNametxt.TabIndex = 7;
            this.SupplierNametxt.Tag = "Product Name";
            // 
            // SupplierIdtxt
            // 
            this.SupplierIdtxt.Location = new System.Drawing.Point(130, 56);
            this.SupplierIdtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupplierIdtxt.Name = "SupplierIdtxt";
            this.SupplierIdtxt.ReadOnly = true;
            this.SupplierIdtxt.Size = new System.Drawing.Size(78, 25);
            this.SupplierIdtxt.TabIndex = 6;
            this.SupplierIdtxt.Tag = "Product ID";
            // 
            // formAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(390, 297);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.SupplierNameLbl);
            this.Controls.Add(this.SupplierIdLbl);
            this.Controls.Add(this.SupplierNametxt);
            this.Controls.Add(this.SupplierIdtxt);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formAddSupplier";
            this.Text = "Add/Edit Supplier";
            this.Load += new System.EventHandler(this.formAddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label SupplierNameLbl;
        private System.Windows.Forms.Label SupplierIdLbl;
        private System.Windows.Forms.TextBox SupplierNametxt;
        private System.Windows.Forms.TextBox SupplierIdtxt;
    }
}