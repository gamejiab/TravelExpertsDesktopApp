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

namespace Travel
{
    public partial class SuppliersFrm : Form
    {
        private TravelExpertsContext context { get; set; }
        private Supplier supplier { get; set; }
        public SuppliersFrm(TravelExpertsContext ctx)
        {
            InitializeComponent();
            context = ctx;
        }

        //Return selected supplier
        private Supplier getSelected()
        {
            int selection = Convert.ToInt32(supplierGrid.CurrentRow.Cells[0].FormattedValue);
            return context.Suppliers.Find(selection);
        }


        private void Suppliers_Load(object sender, EventArgs e)
        {
            supplierGridView();
        }

        //Initialize suppliers for view
        private void supplierGridView()
        {
            supplierGrid.AutoGenerateColumns = false;
            supplierGrid.DataSource = context.Suppliers.ToList();
            supplierGrid.Rows[0].Selected = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            formAddSupplier newForm = new formAddSupplier(true, null, context) ;
            newForm.ShowDialog();
            supplierGridView();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            Supplier current = getSelected();
            formAddSupplier newForm = new formAddSupplier(false, current, context);
            newForm.ShowDialog();
            supplierGridView();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
