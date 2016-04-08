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
            this.colManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModelNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(766, 73);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(61, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(702, 73);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtModelNumber
            // 
            this.txtModelNumber.Location = new System.Drawing.Point(766, 99);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(69, 20);
            this.txtModelNumber.TabIndex = 3;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(766, 125);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(72, 20);
            this.txtSerialNumber.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(766, 151);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(75, 20);
            this.txtManufacturer.TabIndex = 5;
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(684, 102);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(76, 13);
            this.lblModelNumber.TabIndex = 7;
            this.lblModelNumber.Text = "Model Number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(687, 132);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.lblSerialNumber.TabIndex = 8;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(690, 154);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 9;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(700, 200);
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
            this.colBarcode});
            this.lstInventory.Location = new System.Drawing.Point(12, 12);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(673, 327);
            this.lstInventory.TabIndex = 12;
            this.lstInventory.UseCompatibleStateImageBehavior = false;
            this.lstInventory.View = System.Windows.Forms.View.Details;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);
            // 
            // colManufacturer
            // 
            this.colManufacturer.Text = "Manufacturer";
            this.colManufacturer.Width = 135;
            // 
            // colModelNumber
            // 
            this.colModelNumber.Text = "Model Number";
            this.colModelNumber.Width = 159;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Text = "Serial Number";
            this.colSerialNumber.Width = 167;
            // 
            // colBarcode
            // 
            this.colBarcode.Text = "Barcode";
            this.colBarcode.Width = 171;
            // 
            // colID
            // 
            this.colID.Text = "I.D.";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(766, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(61, 20);
            this.txtID.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(725, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "I.D.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(833, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

