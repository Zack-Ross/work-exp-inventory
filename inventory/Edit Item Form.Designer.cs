namespace inventory
{
    partial class Edit_Item_Form
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
            this.txtEditBarcode = new System.Windows.Forms.TextBox();
            this.txtEditModelNumber = new System.Windows.Forms.TextBox();
            this.txtEditSerialNumber = new System.Windows.Forms.TextBox();
            this.txtEditManufacturer = new System.Windows.Forms.TextBox();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.lblEditManufacturer = new System.Windows.Forms.Label();
            this.lblEditSerialNumber = new System.Windows.Forms.Label();
            this.lblEditModelNumber = new System.Windows.Forms.Label();
            this.lblEditBarcode = new System.Windows.Forms.Label();
            this.lblEditDescription = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEditCost = new System.Windows.Forms.TextBox();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.lblEditCost = new System.Windows.Forms.Label();
            this.lblEditPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEditBarcode
            // 
            this.txtEditBarcode.Location = new System.Drawing.Point(94, 9);
            this.txtEditBarcode.Name = "txtEditBarcode";
            this.txtEditBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtEditBarcode.TabIndex = 1;
            // 
            // txtEditModelNumber
            // 
            this.txtEditModelNumber.Location = new System.Drawing.Point(94, 35);
            this.txtEditModelNumber.Name = "txtEditModelNumber";
            this.txtEditModelNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEditModelNumber.TabIndex = 2;
            // 
            // txtEditSerialNumber
            // 
            this.txtEditSerialNumber.Location = new System.Drawing.Point(94, 61);
            this.txtEditSerialNumber.Name = "txtEditSerialNumber";
            this.txtEditSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEditSerialNumber.TabIndex = 3;
            // 
            // txtEditManufacturer
            // 
            this.txtEditManufacturer.Location = new System.Drawing.Point(94, 87);
            this.txtEditManufacturer.Name = "txtEditManufacturer";
            this.txtEditManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtEditManufacturer.TabIndex = 4;
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Location = new System.Drawing.Point(15, 184);
            this.txtEditDescription.Multiline = true;
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(179, 58);
            this.txtEditDescription.TabIndex = 5;
            // 
            // lblEditManufacturer
            // 
            this.lblEditManufacturer.AutoSize = true;
            this.lblEditManufacturer.Location = new System.Drawing.Point(12, 90);
            this.lblEditManufacturer.Name = "lblEditManufacturer";
            this.lblEditManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblEditManufacturer.TabIndex = 7;
            this.lblEditManufacturer.Text = "Manufacturer";
            // 
            // lblEditSerialNumber
            // 
            this.lblEditSerialNumber.AutoSize = true;
            this.lblEditSerialNumber.Location = new System.Drawing.Point(12, 64);
            this.lblEditSerialNumber.Name = "lblEditSerialNumber";
            this.lblEditSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.lblEditSerialNumber.TabIndex = 8;
            this.lblEditSerialNumber.Text = "Serial Number";
            // 
            // lblEditModelNumber
            // 
            this.lblEditModelNumber.AutoSize = true;
            this.lblEditModelNumber.Location = new System.Drawing.Point(12, 38);
            this.lblEditModelNumber.Name = "lblEditModelNumber";
            this.lblEditModelNumber.Size = new System.Drawing.Size(76, 13);
            this.lblEditModelNumber.TabIndex = 9;
            this.lblEditModelNumber.Text = "Model Number";
            // 
            // lblEditBarcode
            // 
            this.lblEditBarcode.AutoSize = true;
            this.lblEditBarcode.Location = new System.Drawing.Point(12, 12);
            this.lblEditBarcode.Name = "lblEditBarcode";
            this.lblEditBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblEditBarcode.TabIndex = 10;
            this.lblEditBarcode.Text = "Barcode";
            // 
            // lblEditDescription
            // 
            this.lblEditDescription.AutoSize = true;
            this.lblEditDescription.Location = new System.Drawing.Point(12, 168);
            this.lblEditDescription.Name = "lblEditDescription";
            this.lblEditDescription.Size = new System.Drawing.Size(60, 13);
            this.lblEditDescription.TabIndex = 11;
            this.lblEditDescription.Text = "Description";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEditCost
            // 
            this.txtEditCost.Location = new System.Drawing.Point(94, 113);
            this.txtEditCost.Name = "txtEditCost";
            this.txtEditCost.Size = new System.Drawing.Size(100, 20);
            this.txtEditCost.TabIndex = 13;
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(94, 139);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(100, 20);
            this.txtEditPrice.TabIndex = 14;
            // 
            // lblEditCost
            // 
            this.lblEditCost.AutoSize = true;
            this.lblEditCost.Location = new System.Drawing.Point(12, 116);
            this.lblEditCost.Name = "lblEditCost";
            this.lblEditCost.Size = new System.Drawing.Size(28, 13);
            this.lblEditCost.TabIndex = 15;
            this.lblEditCost.Text = "Cost";
            // 
            // lblEditPrice
            // 
            this.lblEditPrice.AutoSize = true;
            this.lblEditPrice.Location = new System.Drawing.Point(12, 142);
            this.lblEditPrice.Name = "lblEditPrice";
            this.lblEditPrice.Size = new System.Drawing.Size(31, 13);
            this.lblEditPrice.TabIndex = 16;
            this.lblEditPrice.Text = "Price";
            // 
            // Edit_Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 279);
            this.Controls.Add(this.lblEditPrice);
            this.Controls.Add(this.lblEditCost);
            this.Controls.Add(this.txtEditPrice);
            this.Controls.Add(this.txtEditCost);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEditDescription);
            this.Controls.Add(this.lblEditBarcode);
            this.Controls.Add(this.lblEditModelNumber);
            this.Controls.Add(this.lblEditSerialNumber);
            this.Controls.Add(this.lblEditManufacturer);
            this.Controls.Add(this.txtEditDescription);
            this.Controls.Add(this.txtEditManufacturer);
            this.Controls.Add(this.txtEditSerialNumber);
            this.Controls.Add(this.txtEditModelNumber);
            this.Controls.Add(this.txtEditBarcode);
            this.Name = "Edit_Item_Form";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.Edit_Item_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEditBarcode;
        private System.Windows.Forms.TextBox txtEditModelNumber;
        private System.Windows.Forms.TextBox txtEditSerialNumber;
        private System.Windows.Forms.TextBox txtEditManufacturer;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.Label lblEditManufacturer;
        private System.Windows.Forms.Label lblEditSerialNumber;
        private System.Windows.Forms.Label lblEditModelNumber;
        private System.Windows.Forms.Label lblEditBarcode;
        private System.Windows.Forms.Label lblEditDescription;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEditCost;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label lblEditCost;
        private System.Windows.Forms.Label lblEditPrice;
    }
}