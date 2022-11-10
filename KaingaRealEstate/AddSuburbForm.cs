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
    public partial class AddSuburbForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        public AddSuburbForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void AddSuburbForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            txtSuburbName.Text = "";
            txtCode.Text = "";

        }

        private void btnAddSuburb_Click(object sender, EventArgs e)
        {
            DataRow newSuburbRow = DC.dtSuburb.NewRow();
            if ((txtSuburbName.Text == "") || (txtCode.Text == ""))
            {

                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    newSuburbRow["suburbName"] = txtSuburbName.Text;
                    newSuburbRow["postCode"] = txtCode.Text;
                    DC.dtSuburb.Rows.Add(newSuburbRow);
                    DC.UpdateSuburb();
                    MessageBox.Show("Suburb added successfully", "Success");
                    ClearFields();


                }
                catch (FormatException)
                {
                    MessageBox.Show( "Error");


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
