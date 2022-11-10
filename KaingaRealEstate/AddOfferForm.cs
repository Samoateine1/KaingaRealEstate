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
    public partial class AddOfferForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID, aPropertyID;
        private CurrencyManager cmBuyer;
        private CurrencyManager cmProperty;
        public AddOfferForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();


        }
        public void BindControls()
        {
            txtBuyerID.DataBindings.Add("Text", DC.dsKainga, "BUYER.buyerID");
            txtLastName.DataBindings.Add("Text", DC.dsKainga, "BUYER.lastName");
            txtFirstName.DataBindings.Add("Text", DC.dsKainga, "BUYER.firstName");
            txtEmailAddress.DataBindings.Add("Text", DC.dsKainga, "BUYER.emailAddress");
            txtPhoneNumber.DataBindings.Add("Text", DC.dsKainga, "BUYER.phoneNumber");

            txtPropertyID.DataBindings.Add("Text", DC.dsKainga, "PROPERTY.propertyID");
            txtDescription.DataBindings.Add("Text", DC.dsKainga, "PROPERTY.propertyDescription");
            txtStreetAddress.DataBindings.Add("Text", DC.dsKainga, "PROPERTY.streetAddress");

            cboBuyers.DataSource = DC.dsKainga;
            cboBuyers.SelectedItem = "BUYER.buyerID";

            cboProperties.DataSource = DC.dsKainga;
            cboProperties.SelectedItem = "PROPERTY.propertyID";
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "buyerID"];
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsKainga, "propertyID"];
        }

        private void AddOfferForm_Load(object sender, EventArgs e)
        {
            LoadFields();
        }
        private void LoadFields()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                {
                    cboBuyers.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
                }
            }
            foreach (DataRow drProperty in DC.dtProperty.Rows)
            {
                {
                    cboProperties.Items.Add(drProperty["propertyID"] + (" ") + drProperty["lastName"] + (" ") + drProperty["firstName"]);
                }

            }
        }
        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            cboBuyers.Text = "";
            cboBuyers.Items.Clear();
            cboProperties.Items.Clear();
            txtPropertyID.Text = "";
            txtDescription.Text = "";
            txtStreetAddress.Text = "";
            nudPrice.Value = 0;
        }
        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cboBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboBuyers.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aBuyerID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtEmailAddress.Text = drBuyer["emailAddress"].ToString();
            txtPhoneNumber.Text = drBuyer["phoneNumber"].ToString();
            LoadFields();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();


        }

        private void cboProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboProperties.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aPropertyID = Convert.ToInt32(subs[0]);
            cmProperty.Position = DC.buyerView.Find(aPropertyID);
            DataRow drProperty = DC.dtBuyer.Rows[cmProperty.Position];
            txtPropertyID.Text = drProperty["propertyID"].ToString();
            txtDescription.Text = drProperty["propertyDescription"].ToString();
            txtStreetAddress.Text = drProperty["streetAddress"].ToString();
            LoadFields();
            
        }
    }
}
