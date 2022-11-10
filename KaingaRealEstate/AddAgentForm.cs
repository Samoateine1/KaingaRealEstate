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
    public partial class AddAgentForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        public AddAgentForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void AddAgentForm_Load(object sender, EventArgs e)
        {

        }
        private void CLearFields()
        {
           txtLastName.Text = "";
           txtFirstName.Text = "";
           txtStreetAddress.Text = "";
           txtSuburb.Text = "";
           txtEmailAddress.Text = "";
           txtPhoneNumber.Text = "";
           cboCertification.Text = "";
           nudSalary.Maximum = 0;

        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            DataRow newAgentRow = DC.dtAgent.NewRow(); 
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
                (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                (txtEmailAddress.Text == "") || (nudSalary.Text == "") ||
                (cboCertification.Text == ""))
                
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    newAgentRow["lastName"] = txtLastName.Text;
                    newAgentRow["firstName"] = txtFirstName.Text;
                    newAgentRow["streetAddress"] = txtStreetAddress.Text;
                    newAgentRow["suburb"] = txtSuburb.Text;
                    newAgentRow["emailAddress"] = txtEmailAddress.Text;
                    newAgentRow["certification"] = cboCertification.Text;
                    newAgentRow["salary"] = nudSalary.Value;
                    DC.dtAgent.Rows.Add(newAgentRow);
                    DC.UpdateAgent();
                    MessageBox.Show("Agent added successfully");

                    CLearFields();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Please select a number for Salary or yes / no for Certification", "Error");

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
