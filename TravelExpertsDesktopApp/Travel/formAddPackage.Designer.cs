
namespace Travel
{
    partial class formAddPackage
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
            this.lblPkgID = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtPkgID = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.rtxtPkgName = new System.Windows.Forms.RichTextBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mtxtStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblPkgID
            // 
            this.lblPkgID.AutoSize = true;
            this.lblPkgID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPkgID.Location = new System.Drawing.Point(37, 44);
            this.lblPkgID.Name = "lblPkgID";
            this.lblPkgID.Size = new System.Drawing.Size(89, 24);
            this.lblPkgID.TabIndex = 0;
            this.lblPkgID.Text = "Package ID";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPkgName.Location = new System.Drawing.Point(37, 97);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(114, 24);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPkgStartDate.Location = new System.Drawing.Point(37, 201);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(179, 24);
            this.lblPkgStartDate.TabIndex = 0;
            this.lblPkgStartDate.Text = "Start Date (yyyy-mm-dd)";
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPkgEndDate.Location = new System.Drawing.Point(37, 256);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(172, 24);
            this.lblPkgEndDate.TabIndex = 0;
            this.lblPkgEndDate.Text = "End Date (yyyy-mm-dd)";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPkgDesc.Location = new System.Drawing.Point(37, 313);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(89, 24);
            this.lblPkgDesc.TabIndex = 0;
            this.lblPkgDesc.Text = "Description";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBasePrice.Location = new System.Drawing.Point(37, 425);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(82, 24);
            this.lblBasePrice.TabIndex = 0;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommission.Location = new System.Drawing.Point(37, 485);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(95, 24);
            this.lblCommission.TabIndex = 0;
            this.lblCommission.Text = "Commission";
            // 
            // txtPkgID
            // 
            this.txtPkgID.Location = new System.Drawing.Point(246, 43);
            this.txtPkgID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPkgID.Name = "txtPkgID";
            this.txtPkgID.ReadOnly = true;
            this.txtPkgID.Size = new System.Drawing.Size(186, 25);
            this.txtPkgID.TabIndex = 1;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(246, 424);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(186, 25);
            this.txtBasePrice.TabIndex = 1;
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(246, 484);
            this.txtCommission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(186, 25);
            this.txtCommission.TabIndex = 1;
            // 
            // rtxtPkgName
            // 
            this.rtxtPkgName.Location = new System.Drawing.Point(246, 100);
            this.rtxtPkgName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtPkgName.MaxLength = 50;
            this.rtxtPkgName.Name = "rtxtPkgName";
            this.rtxtPkgName.Size = new System.Drawing.Size(186, 77);
            this.rtxtPkgName.TabIndex = 2;
            this.rtxtPkgName.Text = "";
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(246, 312);
            this.rtxtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDesc.MaxLength = 50;
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(186, 77);
            this.rtxtDesc.TabIndex = 2;
            this.rtxtDesc.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 556);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 556);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtxtStart
            // 
            this.mtxtStart.Location = new System.Drawing.Point(246, 200);
            this.mtxtStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtStart.Mask = "0000/00/00";
            this.mtxtStart.Name = "mtxtStart";
            this.mtxtStart.Size = new System.Drawing.Size(186, 25);
            this.mtxtStart.TabIndex = 4;
            // 
            // mtxtEnd
            // 
            this.mtxtEnd.Location = new System.Drawing.Point(246, 255);
            this.mtxtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtEnd.Mask = "0000/00/00";
            this.mtxtEnd.Name = "mtxtEnd";
            this.mtxtEnd.Size = new System.Drawing.Size(186, 25);
            this.mtxtEnd.TabIndex = 4;
            // 
            // formAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(482, 625);
            this.Controls.Add(this.mtxtEnd);
            this.Controls.Add(this.mtxtStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.rtxtPkgName);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtPkgID);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblPkgDesc);
            this.Controls.Add(this.lblPkgEndDate);
            this.Controls.Add(this.lblPkgStartDate);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.lblPkgID);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formAddPackage";
            this.Text = "Add New Package";
            this.Load += new System.EventHandler(this.formAddPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPkgID;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtPkgID;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.RichTextBox rtxtPkgName;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox mtxtStart;
        private System.Windows.Forms.MaskedTextBox mtxtEnd;
    }
}