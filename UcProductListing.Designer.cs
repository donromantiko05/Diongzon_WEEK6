namespace DiongzonWeek6
{
    partial class UcProductListing
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.GroupBox grpItemDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.grpItemDetails = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            //
            // Item details group
            //
            this.grpItemDetails.Text = "Item Details";
            this.grpItemDetails.Location = new System.Drawing.Point(18, 14);
            this.grpItemDetails.Size = new System.Drawing.Size(740, 150);
            this.grpItemDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 35);
            this.lblDescription.Text = "Description";
            this.txtDescription.Location = new System.Drawing.Point(105, 32);
            this.txtDescription.Size = new System.Drawing.Size(390, 20);
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(24, 68);
            this.lblAmount.Text = "Amount";
            this.txtAmount.Location = new System.Drawing.Point(105, 65);
            this.txtAmount.Size = new System.Drawing.Size(160, 20);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(24, 101);
            this.lblUnit.Text = "Unit";
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Location = new System.Drawing.Point(105, 98);
            this.cmbUnit.Size = new System.Drawing.Size(160, 21);
            this.cmbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            this.btnAdd.Location = new System.Drawing.Point(535, 45);
            this.btnAdd.Size = new System.Drawing.Size(85, 27);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            this.btnDelete.Location = new System.Drawing.Point(535, 84);
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            //
            // Items list
            //
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.HorizontalScrollbar = true;
            this.lstProducts.Location = new System.Drawing.Point(18, 174);
            this.lstProducts.Size = new System.Drawing.Size(740, 225);
            this.lstProducts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            this.lstProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            //
            // UcProductListing
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.grpItemDetails.Controls.Add(this.lblDescription);
            this.grpItemDetails.Controls.Add(this.txtDescription);
            this.grpItemDetails.Controls.Add(this.lblAmount);
            this.grpItemDetails.Controls.Add(this.txtAmount);
            this.grpItemDetails.Controls.Add(this.lblUnit);
            this.grpItemDetails.Controls.Add(this.cmbUnit);
            this.grpItemDetails.Controls.Add(this.btnAdd);
            this.grpItemDetails.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpItemDetails);
            this.Controls.Add(this.lstProducts);
            this.Name = "UcProductListing";
            this.Size = new System.Drawing.Size(780, 420);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
