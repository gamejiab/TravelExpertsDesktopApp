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

namespace Suppliers
{
    public partial class SuppliersInfo : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();
        public SuppliersInfo()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            supplierGridView();
        }

        //private void supplierGrid
        private void supplierGridView()
        {
            context = new TravelExpertsContext();
            supplierGrid.AutoGenerateColumns = false;
            supplierGrid.DataSource = context.Suppliers.ToList();
        }
    }
}
