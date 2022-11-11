
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(251, 426);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(139, 46);
            this.btnAddProperty.TabIndex = 0;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(551, 426);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(136, 46);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblADDPROPERTY
            // 
            this.lblADDPROPERTY.AutoSize = true;
            this.lblADDPROPERTY.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADDPROPERTY.Location = new System.Drawing.Point(397, 9);
            this.lblADDPROPERTY.Name = "lblADDPROPERTY";
            this.lblADDPROPERTY.Size = new System.Drawing.Size(212, 37);
            this.lblADDPROPERTY.TabIndex = 2;
            this.lblADDPROPERTY.Text = "ADD PROPERTY";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStreetAddress.Location = new System.Drawing.Point(126, 88);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(214, 24);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Property Street Address:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(154, 141);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(186, 24);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Property Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbs
            // 
            this.lblSuburbs.AutoSize = true;
            this.lblSuburbs.Location = new System.Drawing.Point(247, 232);
            this.lblSuburbs.Name = "lblSuburbs";
            this.lblSuburbs.Size = new System.Drawing.Size(83, 24);
            this.lblSuburbs.TabIndex = 5;
            this.lblSuburbs.Text = "Suburbs:";
            this.lblSuburbs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(237, 282);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(103, 24);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Categories:";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSellers
            // 
            this.lblSellers.AutoSize = true;
            this.lblSellers.Location = new System.Drawing.Point(271, 336);
            this.lblSellers.Name = "lblSellers";
            this.lblSellers.Size = new System.Drawing.Size(69, 24);
            this.lblSellers.TabIndex = 7;
            this.lblSellers.Text = "Sellers:";
            this.lblSellers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(274, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 24);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(362, 85);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(400, 32);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(359, 133);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(403, 32);
            this.txtDescription.TabIndex = 10;
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(359, 279);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(378, 32);
            this.cboCategories.TabIndex = 16;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // cboSellers
            // 
            this.cboSellers.FormattingEnabled = true;
            this.cboSellers.Location = new System.Drawing.Point(359, 328);
            this.cboSellers.Name = "cboSellers";
            this.cboSellers.Size = new System.Drawing.Size(378, 32);
            this.cboSellers.TabIndex = 17;
            this.cboSellers.SelectedIndexChanged += new System.EventHandler(this.cboSellers_SelectedIndexChanged);
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(359, 181);
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
            this.cboSuburb.Location = new System.Drawing.Point(359, 229);
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(285, 32);
            this.cboSuburb.TabIndex = 21;
            this.cboSuburb.SelectedIndexChanged += new System.EventHandler(this.cboSuburb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(401, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "* Field cannot be left blank.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(335, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(336, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(650, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(743, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(743, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(522, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Select";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(336, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(333, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(336, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(335, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "*";
            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 532);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
