﻿
namespace KaingaRealEstate
{
    partial class AddSuburbForm
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
            this.btnAddSuburb = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtSuburbName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddSuburb
            // 
            this.btnAddSuburb.Location = new System.Drawing.Point(184, 521);
            this.btnAddSuburb.Name = "btnAddSuburb";
            this.btnAddSuburb.Size = new System.Drawing.Size(125, 45);
            this.btnAddSuburb.TabIndex = 0;
            this.btnAddSuburb.Text = "Add Suburb";
            this.btnAddSuburb.UseVisualStyleBackColor = true;
            this.btnAddSuburb.Click += new System.EventHandler(this.btnAddSuburb_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(647, 521);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 45);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD SUBURB";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(152, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Suburb Name:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPostCode.Location = new System.Drawing.Point(162, 224);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(99, 24);
            this.lblPostCode.TabIndex = 4;
            this.lblPostCode.Text = "Post Code:";
            // 
            // txtSuburbName
            // 
            this.txtSuburbName.Location = new System.Drawing.Point(296, 123);
            this.txtSuburbName.MaxLength = 20;
            this.txtSuburbName.Multiline = true;
            this.txtSuburbName.Name = "txtSuburbName";
            this.txtSuburbName.Size = new System.Drawing.Size(343, 66);
            this.txtSuburbName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(296, 216);
            this.txtCode.MaxLength = 4;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 32);
            this.txtCode.TabIndex = 6;
            // 
            // AddSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtSuburbName);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddSuburb);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSuburbForm";
            this.Text = "Add Suburbs";
            this.Load += new System.EventHandler(this.AddSuburbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSuburb;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtSuburbName;
        private System.Windows.Forms.TextBox txtCode;
    }
}
