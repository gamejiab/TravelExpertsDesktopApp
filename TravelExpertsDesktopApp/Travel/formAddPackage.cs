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
    public partial class formAddPackage : Form
    {

        public formAddPackage(bool adding, Package curr, TravelExpertsContext con)
        {
            InitializeComponent();
            add = adding;
            current = curr;
            context = con;
        }

        private bool add;
        private Package current { get; set; }
        private TravelExpertsContext context;

        //If editing, initialize form data
        private void formAddPackage_Load(object sender, EventArgs e)
        {
            if (!add)
            {
                txtPkgID.Text = current.PackageId.ToString();
                txtBasePrice.Text = current.PkgBasePrice.ToString("0.00");
                txtCommission.Text = string.Format("{0:0.00}", current.PkgAgencyCommission);
                rtxtDesc.Text = current.PkgDesc;
                rtxtPkgName.Text = current.PkgName;
                mtxtStart.Text = current.PkgStartDate.ToString();
                mtxtEnd.Text = current.PkgEndDate.ToString();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //perform data validation on the form            
            decimal basePrice, commission;
            DateTime start, end;
            if (rtxtDesc.Text == "" ||
             rtxtPkgName.Text == "")
            {
                MessageBox.Show("The description and name must not be empty");
                return;
            }
            if (!Decimal.TryParse(txtBasePrice.Text, out basePrice))
            {
                MessageBox.Show("Please enter a valid base price");
                return;
            }
            if (!Decimal.TryParse(txtCommission.Text, out commission))
            {
                MessageBox.Show("Please enter a valid commission");
                return;
            }
            if (commission > basePrice)
            {
                MessageBox.Show("Commission must be lower than Base Price");
                return;
            }
            if (!DateTime.TryParse(mtxtStart.Text, out start))
            {
                MessageBox.Show("Please enter a valid start date");
                return;
            }
            if (!DateTime.TryParse(mtxtEnd.Text, out end))
            {
                MessageBox.Show("Please enter a valid end date");
                return;
            }
            if (DateTime.Compare(start, end) > 0)
            {
                MessageBox.Show("End date must be later than start date");
                return;
            }

            //Create a new package
            if (add)
            {
                Package newPkg = new Package();
                newPkg.PkgDesc = rtxtDesc.Text;
                newPkg.PkgName = rtxtPkgName.Text;
                newPkg.PkgBasePrice = basePrice;
                newPkg.PkgAgencyCommission = commission;
                newPkg.PkgStartDate = start;
                newPkg.PkgEndDate = end;
                context.Packages.Add(newPkg);
            }
            //Update selected package
            else
            {
                current.PkgDesc = rtxtDesc.Text;
                current.PkgName = rtxtPkgName.Text;
                current.PkgBasePrice = basePrice;
                current.PkgAgencyCommission = commission;
                current.PkgStartDate = start;
                current.PkgEndDate = end;
            }
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message,
                     ex.GetType().ToString());
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
