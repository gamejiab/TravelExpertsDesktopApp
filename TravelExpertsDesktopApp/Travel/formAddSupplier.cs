using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using DBModels.Models;
using System.Windows.Forms;

namespace Travel
{
    public partial class formAddSupplier : Form
    {
        public Supplier supplier { get; set; }
        public bool AddSupplier { get; set; }
        private TravelExpertsContext context;

        public formAddSupplier(bool add, Supplier current, TravelExpertsContext context_passed)
        {
            InitializeComponent();
            AddSupplier = add;
            supplier = current;
            context = context_passed;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            //Ensure box is filled out
            if (SupplierNametxt.Text == "")
            {
                MessageBox.Show("The supplier name must not be empty");
                return;
            }

            //Add new supplier
            if (AddSupplier)
            {
                Supplier newSup = new Supplier();
                newSup.SupName = SupplierNametxt.Text;
                context.Suppliers.Add(newSup);
            }
            //Update existing
            else
            {
                supplier.SupName = SupplierNametxt.Text;
                context.Suppliers.Update(supplier);
            }
            try { context.SaveChanges(); }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message,
                     ex.GetType().ToString());
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void formAddSupplier_Load(object sender, EventArgs e)
        {
            SupplierIdtxt.ReadOnly = true;
            if (AddSupplier)
            {
                this.Text = "Add Supplier";
            }
            else
            {
                this.Text = " Edit Supplier";
                SupplierNametxt.Text = supplier.SupName;
                SupplierIdtxt.Text = supplier.SupplierId.ToString();
            }
        }
    }
}
