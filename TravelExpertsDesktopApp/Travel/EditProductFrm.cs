using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBModels.Models;

namespace Travel
{
    public partial class editProductFrm : Form
    {

        public Product p { get; set; }
        public bool AddProduct { get; set;  }


        public editProductFrm()
        {
            InitializeComponent();
        }

        private void editProductFrm_Load(object sender, EventArgs e)
        {
            if (AddProduct)
            {
                this.Text = "Add product";
                productIdtxt.ReadOnly = true; // allow entry of new product code
             
            }
            else
            {
                this.Text = " Edit Product";
                productIdtxt.ReadOnly = true; // do not aloow to change  new product code
                this.DisplayProduct();
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddProduct)
                {
                    this.p = new Product(); // New product object
                }
                LoadProductData();
                DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            
            errorMessage += Validator.IsPresent(productNametxt.Text, productNametxt.Tag.ToString());
           

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void DisplayProduct()
        {
            productIdtxt.Text = p.ProductId.ToString();
            productNametxt.Text = p.ProdName;
        }

        private void LoadProductData()
        {
            
            p.ProdName = productNametxt.Text;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
