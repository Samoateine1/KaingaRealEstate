using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class AddSellerForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
       
        public AddSellerForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void ClearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            //cboStatus.ValueMember = "";
            cboStatus.Items.Clear();
            cboStatus.Text = "";
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            DataRow newSellerRow = DC.dtSeller.NewRow();
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
                (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                (txtCity.Text == "") || (txtPhoneNumber.Text == "") ||
                (txtEmailAddress.Text == "") || (cboStatus.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    newSellerRow["LastName"] = txtLastName.Text;
                    newSellerRow["FirstName"] = txtFirstName.Text;
                    newSellerRow["StreetAddress"] = txtStreetAddress.Text;
                    newSellerRow["Suburb"] = txtSuburb.Text;
                    newSellerRow["City"] = txtCity.Text;
                    newSellerRow["PhoneNumber"] = txtPhoneNumber.Text;
                    newSellerRow["EmailAddress"] = txtEmailAddress.Text;
                    newSellerRow["Status"] = cboStatus.SelectedItem;
                    DC.dtSeller.Rows.Add(newSellerRow);
                    DC.UpdateSeller();
                    MessageBox.Show("Seller added successfully", "Acknowledgement", MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                    ClearFields();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
