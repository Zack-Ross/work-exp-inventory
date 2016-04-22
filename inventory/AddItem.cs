using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sanatizers sanatizer = new Sanatizers();
            string manufacturer = sanatizer.Sanatize(txtManufacturer.Text);
            string modelnumber = sanatizer.Sanatize(txtModelNumber.Text);
            string serialnumber = sanatizer.Sanatize(txtSerialNumber.Text);
            string barcode = sanatizer.Sanatize(txtBarcode.Text);
            string description = sanatizer.Sanatize(txtDescription.Text);
            decimal cost = Parsers.ParseDecimal(sanatizer.Sanatize(txtCost.Text));
            decimal price = Parsers.ParseDecimal(sanatizer.Sanatize(txtPrice.Text));

            InventoryItem newItem = new InventoryItem()
            {
                Manufacturer = manufacturer,
                ModelNumber = modelnumber,
                SerialNumber = serialnumber,
                Barcode = barcode,
                Description = description,
                Cost = cost,
                Price = price

            };
            ((Form1)this.Owner).AddInventoryItem(newItem);
            ((Form1)this.Owner).UpdateListBox();
            this.Close();
        }
    }
}
