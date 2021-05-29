using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DBModels.Models;

namespace Travel
{
    public partial class EditProductSupplier : Form
    {

        private TravelExpertsContext context;
        private bool add;
        ProductsSupplier currProdSupp;
        //Construct with context, selected item, and check if it's adding/editing
        public EditProductSupplier(bool added, ProductsSupplier current, TravelExpertsContext ctx)
        {
            InitializeComponent();
            context = ctx;
            add = added;
            currProdSupp = current;
            if (add)
            {
                this.Text = "Add New Product and Supplier Link";
            }
        }

        //Initialize views
        private void EditProductSupplier_Load(object sender, EventArgs e)
        {
            comboProduct.DisplayMember = "ProdName";
            comboProduct.ValueMember = "ProductID";
            comboProduct.DataSource = context.Products.ToList();
            comboSupplier.DisplayMember = "SupName";
            comboSupplier.ValueMember = "SupplierID";
            comboSupplier.DataSource = context.Suppliers.ToList();
            //If adding, comboboxes should be default
            //If editing, combo boxes should be the edited item
            if (add)
            {
                comboProduct.SelectedIndex = 0;
                comboSupplier.SelectedIndex = 0;
            }
            else
            {
                comboProduct.SelectedValue = currProdSupp.ProductId;
                comboSupplier.SelectedValue = currProdSupp.SupplierId;
                comboProduct.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var prodID = Int32.Parse(comboProduct.SelectedValue.ToString());
            var suppID = Int32.Parse(comboSupplier.SelectedValue.ToString());
            try
            {
                if (add)
                {
                    ProductsSupplier item = new ProductsSupplier();
                    item.ProductId = prodID;
                    item.SupplierId = suppID;
                    //Check if item already exists
                    if (context.ProductsSuppliers.Contains(item))
                    {
                        MessageBox.Show("This product already exists with this supplier");
                        return;
                    }
                    context.ProductsSuppliers.Add(item);
                }
                else
                {
                    currProdSupp.ProductId = prodID;
                    currProdSupp.SupplierId = suppID;
                    //Check if item already exists
                    if (context.ProductsSuppliers.Contains(currProdSupp))
                    {
                        MessageBox.Show("This product already exists with this supplier");
                        return;
                    }
                    context.ProductsSuppliers.Update(currProdSupp);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message,
                   ex.GetType().ToString());
                return;
            }
            this.Close();
        }
    }
}
