
namespace Travel
{
    partial class editProductFrm
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
            this.productIdtxt = new System.Windows.Forms.TextBox();
            this.productNametxt = new System.Windows.Forms.TextBox();
            this.productIdLbl = new System.Windows.Forms.Label();
            this.productnameLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productIdtxt
            // 
            this.productIdtxt.Location = new System.Drawing.Point(143, 47);
            this.productIdtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productIdtxt.Name = "productIdtxt";
            this.productIdtxt.ReadOnly = true;
            this.productIdtxt.Size = new System.Drawing.Size(78, 25);
            this.productIdtxt.TabIndex = 0;
            this.productIdtxt.Tag = "Product ID";
            // 
            // productNametxt
            // 
            this.productNametxt.Location = new System.Drawing.Point(143, 111);
            this.productNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productNametxt.Name = "productNametxt";
            this.productNametxt.Size = new System.Drawing.Size(221, 25);
            this.productNametxt.TabIndex = 1;
            this.productNametxt.Tag = "Product Name";
            // 
            // productIdLbl
            // 
            this.productIdLbl.AutoSize = true;
            this.productIdLbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdLbl.Location = new System.Drawing.Point(16, 48);
            this.productIdLbl.Name = "productIdLbl";
            this.productIdLbl.Size = new System.Drawing.Size(84, 24);
            this.productIdLbl.TabIndex = 2;
            this.productIdLbl.Text = "Product ID";
            // 
            // productnameLbl
            // 
            this.productnameLbl.AutoSize = true;
            this.productnameLbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productnameLbl.Location = new System.Drawing.Point(16, 112);
            this.productnameLbl.Name = "productnameLbl";
            this.productnameLbl.Size = new System.Drawing.Size(109, 24);
            this.productnameLbl.TabIndex = 3;
            this.productnameLbl.Text = "Product Name";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.Location = new System.Drawing.Point(66, 181);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 43);
            this.acceptBtn.TabIndex = 4;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(212, 181);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 43);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(385, 269);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.productnameLbl);
            this.Controls.Add(this.productIdLbl);
            this.Controls.Add(this.productNametxt);
            this.Controls.Add(this.productIdtxt);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "editProductFrm";
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.editProductFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productIdtxt;
        private System.Windows.Forms.TextBox productNametxt;
        private System.Windows.Forms.Label productIdLbl;
        private System.Windows.Forms.Label productnameLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}