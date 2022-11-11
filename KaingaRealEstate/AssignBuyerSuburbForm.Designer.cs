
namespace KaingaRealEstate
{
    partial class AssignBuyerSuburbForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuyers = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBuyerSuburbs = new System.Windows.Forms.Label();
            this.cboBuyers = new System.Windows.Forms.ComboBox();
            this.lstSuburbsAssigned = new System.Windows.Forms.ListBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblImportance = new System.Windows.Forms.Label();
            this.cboImportance = new System.Windows.Forms.ComboBox();
            this.btnAssignBuyerSuburb = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboSuburbs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSIGN BUYER SUBURBS";
            // 
            // lblBuyers
            // 
            this.lblBuyers.AutoSize = true;
            this.lblBuyers.Location = new System.Drawing.Point(189, 90);
            this.lblBuyers.Name = "lblBuyers";
            this.lblBuyers.Size = new System.Drawing.Size(71, 24);
            this.lblBuyers.TabIndex = 1;
            this.lblBuyers.Text = "Buyers:";
            this.lblBuyers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(175, 141);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 2;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(137, 275);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(123, 24);
            this.lblCreditStatus.TabIndex = 4;
            this.lblCreditStatus.Text = "Credit Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "First Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerSuburbs
            // 
            this.lblBuyerSuburbs.AutoSize = true;
            this.lblBuyerSuburbs.Location = new System.Drawing.Point(120, 325);
            this.lblBuyerSuburbs.Name = "lblBuyerSuburbs";
            this.lblBuyerSuburbs.Size = new System.Drawing.Size(136, 24);
            this.lblBuyerSuburbs.TabIndex = 7;
            this.lblBuyerSuburbs.Text = "Buyer Suburbs:";
            this.lblBuyerSuburbs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBuyers
            // 
            this.cboBuyers.FormattingEnabled = true;
            this.cboBuyers.Location = new System.Drawing.Point(285, 87);
            this.cboBuyers.Name = "cboBuyers";
            this.cboBuyers.Size = new System.Drawing.Size(336, 32);
            this.cboBuyers.TabIndex = 8;
            this.cboBuyers.SelectedIndexChanged += new System.EventHandler(this.cboBuyers_SelectedIndexChanged);
            // 
            // lstSuburbsAssigned
            // 
            this.lstSuburbsAssigned.AllowDrop = true;
            this.lstSuburbsAssigned.FormattingEnabled = true;
            this.lstSuburbsAssigned.ItemHeight = 24;
            this.lstSuburbsAssigned.Location = new System.Drawing.Point(285, 325);
            this.lstSuburbsAssigned.Name = "lstSuburbsAssigned";
            this.lstSuburbsAssigned.ScrollAlwaysVisible = true;
            this.lstSuburbsAssigned.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSuburbsAssigned.Size = new System.Drawing.Size(322, 76);
            this.lstSuburbsAssigned.TabIndex = 9;
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(285, 125);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(100, 32);
            this.txtBuyerID.TabIndex = 10;
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(285, 275);
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(70, 32);
            this.txtCreditStatus.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(285, 174);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(208, 32);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(285, 224);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(208, 32);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(178, 421);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 17;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblImportance
            // 
            this.lblImportance.AutoSize = true;
            this.lblImportance.Location = new System.Drawing.Point(149, 464);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(111, 24);
            this.lblImportance.TabIndex = 18;
            this.lblImportance.Text = "Importance:";
            // 
            // cboImportance
            // 
            this.cboImportance.FormattingEnabled = true;
            this.cboImportance.Items.AddRange(new object[] {
            "high",
            "medium",
            "low"});
            this.cboImportance.Location = new System.Drawing.Point(285, 456);
            this.cboImportance.Name = "cboImportance";
            this.cboImportance.Size = new System.Drawing.Size(222, 32);
            this.cboImportance.TabIndex = 19;
            this.cboImportance.SelectedIndexChanged += new System.EventHandler(this.cboImportance_SelectedIndexChanged);
            // 
            // btnAssignBuyerSuburb
            // 
            this.btnAssignBuyerSuburb.Location = new System.Drawing.Point(193, 550);
            this.btnAssignBuyerSuburb.Name = "btnAssignBuyerSuburb";
            this.btnAssignBuyerSuburb.Size = new System.Drawing.Size(198, 36);
            this.btnAssignBuyerSuburb.TabIndex = 20;
            this.btnAssignBuyerSuburb.Text = "Assign Buyer Suburb";
            this.btnAssignBuyerSuburb.UseVisualStyleBackColor = true;
            this.btnAssignBuyerSuburb.Click += new System.EventHandler(this.btnAssignBuyerSuburb_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(576, 550);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(165, 36);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboSuburbs
            // 
            this.cboSuburbs.FormattingEnabled = true;
            this.cboSuburbs.Location = new System.Drawing.Point(285, 413);
            this.cboSuburbs.Name = "cboSuburbs";
            this.cboSuburbs.Size = new System.Drawing.Size(336, 32);
            this.cboSuburbs.TabIndex = 22;
            this.cboSuburbs.SelectedIndexChanged += new System.EventHandler(this.cboSuburbs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(380, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "* Field must not be left blank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(257, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(257, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(259, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(259, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(259, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(259, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(259, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(257, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(627, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 23);
            this.label13.TabIndex = 32;
            this.label13.Text = "Select";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(513, 478);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Select";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(618, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "Select";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(609, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 23);
            this.label16.TabIndex = 35;
            this.label16.Text = "Select";
            // 
            // AssignBuyerSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 638);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSuburbs);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignBuyerSuburb);
            this.Controls.Add(this.cboImportance);
            this.Controls.Add(this.lblImportance);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.lstSuburbsAssigned);
            this.Controls.Add(this.cboBuyers);
            this.Controls.Add(this.lblBuyerSuburbs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignBuyerSuburbForm";
            this.Text = "Assign Buyer Suburbs";
            this.Load += new System.EventHandler(this.AssignBuyerSuburbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuyers;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBuyerSuburbs;
        private System.Windows.Forms.ComboBox cboBuyers;
        private System.Windows.Forms.ListBox lstSuburbsAssigned;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.ComboBox cboImportance;
        private System.Windows.Forms.Button btnAssignBuyerSuburb;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboSuburbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}