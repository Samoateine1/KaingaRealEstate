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
    public partial class AssignBuyerSuburbForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aSuburbID, aBuyerID;
        private CurrencyManager cmBuyer;
        private CurrencyManager cmSuburbs;
        

        public AssignBuyerSuburbForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
          
        }
        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtCreditStatus.Text = "";
            cboBuyers.Text = "";
            cboBuyers.Items.Clear();
            lstSuburbsAssigned.Text = "";
            lstSuburbsAssigned.Items.Clear();
            cboSuburbs.Text = "";
            cboSuburbs.Items.Clear();
            cboImportance.Text = "";
            cboImportance.Items.Clear();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void AssignBuyerSuburbForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
            LoadSuburbs();
        }

        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                cboBuyers.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
            }
        }
        private void LoadSuburbs()
        {
            foreach (DataRow drSuburb in DC.dtSuburb.Rows)
            {
                cboSuburbs.Items.Add(drSuburb["suburbID"] + (" ") + drSuburb["suburbName"]);
            }
        }


        private void cboSuburbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboSuburbs.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aSuburbID = Convert.ToInt32(subs[0]);
           // cmSuburbs.Position = DC.suburbView.Find(aSuburbID);
            DataRow drSuburb = DC.dtSuburb.Rows[cmSuburbs.Position];
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtCreditStatus.Text = drBuyer["creditStatus"].ToString();


            MessageBox.Show("suburbID = " + aSuburbID);

            LoadBuyerAssigned();
            LoadBuyers();



        }
        private void LoadBuyerAssigned()
        {
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            DataRow[] drBuyerSuburbs = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERSUBURB"]);
            var space = new string(' ', 31);
            lstSuburbsAssigned.Items.Add("ID\r\tSuburb\r\tImportance\r\n");
            foreach (DataRow drBuyerSuburb in drBuyerSuburbs)
            {
                DataRow drSuburb = drBuyerSuburb.GetParentRow(DC.dtBuyerCategory.ParentRelations["SUBURB_BUYERSUBURB"]);
                lstSuburbsAssigned.Items.Add(drSuburb["suburbID"] + "\r\t" + drSuburb["suburbName"]+ "\r\t" + drBuyerSuburb["importance"] + "\r\n");
            }
        }
        private void cboImportance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAssignBuyerSuburb_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
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
            txtCreditStatus.Text = drBuyer["creditStatus"].ToString();
            LoadBuyerAssigned();
            LoadSuburbs();
        }

    }
}
