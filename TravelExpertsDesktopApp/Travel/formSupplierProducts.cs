using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBModels.Models;
using System.Configuration;


namespace Travel
{
    public partial class formSupplierProducts : Form
    {

        TravelExpertsContext context;

        public formSupplierProducts(TravelExpertsContext ctx)
        {
            InitializeComponent();
            context = ctx;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsFrm newForm = new ProductsFrm(context);
            newForm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersFrm newForm = new SuppliersFrm(context);
            newForm.ShowDialog();
        }

        private void formSupplierProducts_Load(object sender, EventArgs e)
        {
            display();
        }

        //Load all products and supplier pairings with their names
        private void display()
        {
            List<ProductsSupplier> productsSuppliers = context.ProductsSuppliers.ToList();

            var prodSuppList = (from prodSupp in context.ProductsSuppliers.ToList()
                                join product in context.Products
                                    on prodSupp.ProductId equals product.ProductId
                                join supplier in context.Suppliers
                                    on prodSupp.SupplierId equals supplier.SupplierId
                                select new
                                {
                                    ProductSupplierID = prodSupp.ProductSupplierId,
                                    ProdName = product.ProdName,
                                    SupName = supplier.SupName
                                }
                                ).OrderBy(item => item.SupName).OrderBy(item => item.ProdName).ToList();

            dataGVProdSupp.DataSource = prodSuppList;
            try
            {
                dataGVProdSupp.Rows[0].Selected = true;
            }
            catch
            {
                btnEditProdSupp.Enabled = false;
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            EditProductSupplier newForm = new EditProductSupplier(true, null, context);
            newForm.ShowDialog();
            display();
        }

        private void btnEditProdSupp_Click(object sender, EventArgs e)
        {
            ProductsSupplier current = getSelected();
            EditProductSupplier newForm = new EditProductSupplier(false, current, context);
            newForm.ShowDialog();
            display();
        }

        private ProductsSupplier getSelected()
        {
            int selection = Convert.ToInt32(dataGVProdSupp.CurrentRow.Cells[0].FormattedValue);
            return context.ProductsSuppliers.Find(selection);
        }
    }
}
