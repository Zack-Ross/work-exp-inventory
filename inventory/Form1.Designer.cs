namespace inventory
{
    partial class Form1
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lstInventory = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModelNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(773, 32);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(75, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(690, 35);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtModelNumber
            // 
            this.txtModelNumber.Location = new System.Drawing.Point(773, 58);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(75, 20);
            this.txtModelNumber.TabIndex = 3;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(773, 84);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(75, 20);
            this.txtSerialNumber.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(773, 110);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(75, 20);
            this.txtManufacturer.TabIndex = 5;
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(691, 61);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(76, 13);
            this.lblModelNumber.TabIndex = 7;
            this.lblModelNumber.Text = "Model Number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(691, 87);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.lblSerialNumber.TabIndex = 8;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(691, 113);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 9;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(691, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(693, 216);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 128);
            this.txtDescription.TabIndex = 11;
            // 
            // lstInventory
            // 
            this.lstInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colManufacturer,
            this.colModelNumber,
            this.colSerialNumber,
            this.colBarcode,
            this.colCost,
            this.colPrice});
            this.lstInventory.FullRowSelect = true;
            this.lstInventory.Location = new System.Drawing.Point(12, 12);
            this.lstInventory.MultiSelect = false;
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(673, 331);
            this.lstInventory.TabIndex = 12;
            this.lstInventory.UseCompatibleStateImageBehavior = false;
            this.lstInventory.View = System.Windows.Forms.View.Details;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "I.D.";
            this.colID.Width = 55;
            // 
            // colManufacturer
            // 
            this.colManufacturer.Text = "Manufacturer";
            this.colManufacturer.Width = 123;
            // 
            // colModelNumber
            // 
            this.colModelNumber.Text = "Model Number";
            this.colModelNumber.Width = 118;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Text = "Serial Number";
            this.colSerialNumber.Width = 124;
            // 
            // colBarcode
            // 
            this.colBarcode.Text = "Barcode";
            this.colBarcode.Width = 109;
            // 
            // colCost
            // 
            this.colCost.Text = "Cost";
            this.colCost.Width = 70;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 69;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(773, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(691, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "I.D.";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(93, 349);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 16;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 349);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 17;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(833, 349);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 18;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Location = new System.Drawing.Point(529, 349);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(75, 23);
            this.btnEditItem.TabIndex = 19;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(610, 349);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 21;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(773, 136);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(75, 20);
            this.txtCost.TabIndex = 22;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(773, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 20);
            this.txtPrice.TabIndex = 23;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(690, 139);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 24;
            this.lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(690, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 380);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtModelNumber);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ListView lstInventory;
        private System.Windows.Forms.ColumnHeader colManufacturer;
        private System.Windows.Forms.ColumnHeader colModelNumber;
        private System.Windows.Forms.ColumnHeader colSerialNumber;
        private System.Windows.Forms.ColumnHeader colBarcode;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ColumnHeader colCost;
        private System.Windows.Forms.ColumnHeader colPrice;
    }
}

