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
    public partial class Edit_Item_Form : Form
    {
        public Edit_Item_Form()
        {
            InitializeComponent();
        }

        private void Edit_Item_Form_Load(object sender, EventArgs e)
        {
            if(Form1.SelectedItem == null)
            {
                MessageBox.Show("Selected Item can't be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                InventoryItem SelectedItem = Form1.SelectedItem;
                txtEditBarcode.Text = SelectedItem.Barcode;
                txtEditModelNumber.Text = SelectedItem.ModelNumber;
                txtEditSerialNumber.Text = SelectedItem.SerialNumber;
                txtEditManufacturer.Text = SelectedItem.Manufacturer;
                txtEditDescription.Text = SelectedItem.Description;
                txtEditCost.Text = SelectedItem.Cost.ToString();
                txtEditPrice.Text = SelectedItem.Price.ToString();

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sanatizers sanatizer = new Sanatizers();
            InventoryItem SelectedItem = Form1.SelectedItem;
            SelectedItem.Barcode =sanatizer.Sanatize(txtEditBarcode.Text);
            SelectedItem.ModelNumber = sanatizer.Sanatize(txtEditModelNumber.Text);
            SelectedItem.SerialNumber = sanatizer.Sanatize(txtEditSerialNumber.Text);
            SelectedItem.Manufacturer = sanatizer.Sanatize(txtEditManufacturer.Text);
            SelectedItem.Description = sanatizer.Sanatize(txtEditDescription.Text);
            SelectedItem.Cost = Parsers.ParseDecimal(sanatizer.Sanatize(txtEditCost.Text));
            SelectedItem.Price = Parsers.ParseDecimal(sanatizer.Sanatize(txtEditPrice.Text));
            ((Form1)this.Owner).UpdateListBox();
            this.Close();
        }
    }
}
