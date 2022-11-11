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
    public partial class AddBuyerForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID, aAgentID;
        private CurrencyManager cmBuyer;
        private CurrencyManager cmAgent;
        public AddBuyerForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmAgent = (CurrencyManager)this.BindingContext[DC.dsKainga, "Agent"];
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "Buyer"];
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
            cboCreditStatus.Items.Clear();
            cboCreditStatus.Text = "";
            cboMortgageStatus.Items.Clear();
            cboMortgageStatus.Text = "";
        }
        private void LoadAgent()
        {
            foreach (DataRow drAgent in DC.dtAgent.Rows)
            {
                cboAgents.Items.Add(drAgent["agentID"] + (" ") + drAgent["lastName"] + (" ") + drAgent["firstName"]);

            }
        }

        private void AddBuyerForm_Load(object sender, EventArgs e)
        {
            LoadAgent();

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();

        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            DataRow newBuyerRow = DC.dtBuyer.NewRow();
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") ||
                (txtCity.Text == "") || (txtSuburb.Text == "") ||
                (txtStreetAddress.Text == "") ||
                (txtEmailAddress.Text == "") || (txtEmailAddress.Text == "") ||
                (cboCreditStatus.Text == "") || (cboMortgageStatus.Text == "") ||
                (cboAgents.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {

                try
                {

                    newBuyerRow["lastName"] = txtLastName.Text;
                    newBuyerRow["firstName"] = txtFirstName.Text;
                    newBuyerRow["streetAddress"] = txtStreetAddress.Text;
                    newBuyerRow["city"] = txtCity.Text;
                    newBuyerRow["suburb"] = txtSuburb.Text;
                    newBuyerRow["emailAddress"] = txtEmailAddress.Text;
                    newBuyerRow["phoneNumber"] = txtPhoneNumber.Text;

                    newBuyerRow["buyerID"] = aBuyerID.ToString();
                    newBuyerRow["agentID"] = aAgentID.ToString();



                    DC.dtBuyer.Rows.Add(newBuyerRow);
                    DC.UpdateBuyer();
                    MessageBox.Show("Buyer added successfully", "Acknowledgement", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Error");
                }

            }
            ClearFields();
        }

        private void cboAgents_SelectedIndexChanged(object sender, EventArgs e)
            {
            string aRow = cboAgents.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aAgentID = Convert.ToInt32(subs[0]);
            cmAgent.Position = DC.agentView.Find(aAgentID);
            DataRow drAgent = DC.dtAgent.Rows[cmAgent.Position];
            MessageBox.Show("agentID = + aAgentID");
            
           
            LoadAgent();
            }
        }
    }

