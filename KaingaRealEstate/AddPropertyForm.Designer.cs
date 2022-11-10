
namespace KaingaRealEstate
{
    partial class AddPropertyForm
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
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblADDPROPERTY = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSuburbs = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblSellers = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.cboSellers = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblSuburbName = new System.Windows.Forms.Label();
            this.cboSuburb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(167, 508);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(139, 46);
            this.btnAddProperty.TabIndex = 0;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(625, 497);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 46);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblADDPROPERTY
            // 
            this.lblADDPROPERTY.AutoSize = true;
            this.lblADDPROPERTY.Location = new System.Drawing.Point(398, 49);
            this.lblADDPROPERTY.Name = "lblADDPROPERTY";
            this.lblADDPROPERTY.Size = new System.Drawing.Size(136, 24);
            this.lblADDPROPERTY.TabIndex = 2;
            this.lblADDPROPERTY.Text = "ADD PROPERTY";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(115, 127);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(214, 24);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Property Street Address:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(143, 197);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(186, 24);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Property Description:";
            // 
            // lblSuburbs
            // 
            this.lblSuburbs.AutoSize = true;
            this.lblSuburbs.Location = new System.Drawing.Point(220, 323);
            this.lblSuburbs.Name = "lblSuburbs";
            this.lblSuburbs.Size = new System.Drawing.Size(83, 24);
            this.lblSuburbs.TabIndex = 5;
            this.lblSuburbs.Text = "Suburbs:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(218, 369);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(103, 24);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Categories:";
            // 
            // lblSellers
            // 
            this.lblSellers.AutoSize = true;
            this.lblSellers.Location = new System.Drawing.Point(234, 430);
            this.lblSellers.Name = "lblSellers";
            this.lblSellers.Size = new System.Drawing.Size(69, 24);
            this.lblSellers.TabIndex = 7;
            this.lblSellers.Text = "Sellers:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(234, 282);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 24);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(362, 119);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(247, 54);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(359, 197);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 57);
            this.txtDescription.TabIndex = 10;
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(359, 369);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(391, 32);
            this.cboCategories.TabIndex = 16;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // cboSellers
            // 
            this.cboSellers.FormattingEnabled = true;
            this.cboSellers.Location = new System.Drawing.Point(359, 422);
            this.cboSellers.Name = "cboSellers";
            this.cboSellers.Size = new System.Drawing.Size(391, 32);
            this.cboSellers.TabIndex = 17;
            this.cboSellers.SelectedIndexChanged += new System.EventHandler(this.cboSellers_SelectedIndexChanged);
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(362, 274);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            131072});
            this.nudPrice.Minimum = new decimal(new int[] {
            50000000,
            0,
            0,
            131072});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(157, 32);
            this.nudPrice.TabIndex = 18;
            this.nudPrice.Value = new decimal(new int[] {
            50000000,
            0,
            0,
            131072});
            // 
            // lblSuburbName
            // 
            this.lblSuburbName.AutoSize = true;
            this.lblSuburbName.Location = new System.Drawing.Point(220, 380);
            this.lblSuburbName.Name = "lblSuburbName";
            this.lblSuburbName.Size = new System.Drawing.Size(0, 24);
            this.lblSuburbName.TabIndex = 20;
            // 
            // cboSuburb
            // 
            this.cboSuburb.FormattingEnabled = true;
            this.cboSuburb.Location = new System.Drawing.Point(359, 320);
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(285, 32);
            this.cboSuburb.TabIndex = 21;
            this.cboSuburb.SelectedIndexChanged += new System.EventHandler(this.cboSuburb_SelectedIndexChanged);
            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.cboSuburb);
            this.Controls.Add(this.lblSuburbName);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.cboSellers);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSellers);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblSuburbs);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblADDPROPERTY);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddProperty);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPropertyForm";
            this.Text = "Add Properties";
            this.Load += new System.EventHandler(this.AddPropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblADDPROPERTY;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSuburbs;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblSellers;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.ComboBox cboSellers;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblSuburbName;
        private System.Windows.Forms.ComboBox cboSuburb;
    }
}
