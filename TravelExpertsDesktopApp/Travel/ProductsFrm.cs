using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Configuration;




namespace Travel
{
    public partial class ProductsFrm : Form
    {
        public ProductsFrm(TravelExpertsContext ctx)
        {
            InitializeComponent();
            context = ctx;
        }

        public Product selectedProduct;
        private TravelExpertsContext context;

        private void ProductsFrm_Load(object sender, EventArgs e)
        {
            DisplayProducts();
            productDGrid.Rows[0].Selected = true;
            int productCode = Convert.ToInt32(productDGrid.Rows[0].Cells[0].Value);
            selectedProduct = context.Products.Find(productCode);
        }
        private void DisplayProducts()
        {
                        productDGrid.Columns.Clear();
            var products = context.Products.OrderBy(pr => pr.ProductId)
                .Select(pr => new { pr.ProductId, pr.ProdName }).ToList();

            productDGrid.DataSource = products;

            productDGrid.EnableHeadersVisualStyles = false;
            productDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            productDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            productDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            productDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            productDGrid.Columns[0].HeaderText = "Product ID";
            productDGrid.Columns[0].Width = 100;
            productDGrid.Columns[0].ReadOnly = true;


            productDGrid.Columns[1].HeaderText = "Product Name";
            productDGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productDGrid.Columns[1].Width = 150;
            productDGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void productDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productCode = Convert.ToInt32(productDGrid.Rows[e.RowIndex].Cells[0].Value);
            selectedProduct = context.Products.Find(productCode);     
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditProduct();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            var edit_Product_Frm = new editProductFrm()
            {
                AddProduct = true
            };
            DialogResult result = edit_Product_Frm.ShowDialog();
            if(result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = edit_Product_Frm.p;
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }


        private void EditProduct()
        {
            var edit_Product_Frm = new editProductFrm()
            {
                AddProduct = false,
                p = selectedProduct
            };

            DialogResult result = edit_Product_Frm.ShowDialog();
            if (result == DialogResult.OK)
                try
                {
                    selectedProduct = edit_Product_Frm.p;
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(selectedProduct).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that product.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            this.DisplayProducts();
        }
        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }
        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }








}
