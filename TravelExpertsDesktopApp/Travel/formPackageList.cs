using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using DBModels.Models;
using System.Windows.Forms;
using System.Configuration;

namespace Travel
{
    public partial class frmPackageList : Form
    {
        public TravelExpertsContext context { get; set; }

        //Initialize context
        public frmPackageList()
        {
            InitializeComponent();
            context = new TravelExpertsContext();
            TravelExpertsContext.connectString =
                ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;
        }

        //Return selected package
        private Package getSelected()
        {
            int selection = Convert.ToInt32(dataGVPackages.CurrentRow.Cells[0].FormattedValue);
            return context.Packages.Find(selection);
        }

        //Initialize data grid with list of packages
        private void display()
        {
            var products = context.Packages
                 .OrderBy(p => p.PackageId)
                 .Select(p => new
                 {
                     p.PackageId,
                     p.PkgName,
                     p.PkgStartDate,
                     p.PkgEndDate,
                     p.PkgDesc,
                     p.PkgBasePrice,
                     p.PkgAgencyCommission
                 }).ToList();
            dataGVPackages.DataSource = products;
            dataGVPackages.Rows[0].Selected = true;
        }

        //Open new forms based on selection
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            formAddPackage newForm = new formAddPackage(true, null, context);
            newForm.ShowDialog();
            display();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            Package current = getSelected();
            formAddPackage newForm = new formAddPackage(false, current, context);

            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                display();
            }
        }

        private void frmPackageList_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            Package current = getSelected();
            formEditPackageProducts newForm = new formEditPackageProducts(current, context);
            newForm.ShowDialog();
        }

        private void btnProdSuppliers_Click(object sender, EventArgs e)
        {
            formSupplierProducts newForm = new formSupplierProducts(context);
            newForm.ShowDialog();
        }
    }
}
