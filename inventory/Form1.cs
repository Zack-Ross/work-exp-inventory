using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Form1 : Form
    {
        private string Filename;
        private const string FileExtention = ".inventory";
        private Dictionary<int, InventoryItem> DisplayedItemsWithIndex;
        private List<InventoryItem> AllInventoryItems;
        public Form1()
        {
            InitializeComponent();
            DisplayedItemsWithIndex = new Dictionary<int, InventoryItem>();
            AllInventoryItems = new List<InventoryItem>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lstInventory.Items.Clear();
            DisplayedItemsWithIndex.Clear();

            int index = 0;
            foreach (InventoryItem item in AllInventoryItems)
            {
                lstInventory.Items.Add(InventoryItemToListViewItem(item));
                DisplayedItemsWithIndex.Add(index, item);
                index++;
            }
        }
        private ListViewItem InventoryItemToListViewItem(InventoryItem item)
        {
            ListViewItem lvi = new ListViewItem(item.ID.ToString());
            lvi.SubItems.Add(item.Manufacturer);
            lvi.SubItems.Add(item.ModelNumber);
            lvi.SubItems.Add(item.SerialNumber);
            lvi.SubItems.Add(item.Barcode);
            return lvi;
        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndices.Count > 0)
            {
                int SelectedIndex = 0;
                foreach(int se in lstInventory.SelectedIndices)
                {
                    SelectedIndex = se;
                }
                if (DisplayedItemsWithIndex.ContainsKey(SelectedIndex))
                {

                    InventoryItem FoundItem = DisplayedItemsWithIndex[SelectedIndex];


                    UpdateItemFields(FoundItem);
                }
            }
        }
        private void UpdateItemFields(InventoryItem item)
        {
            txtID.Text = item.ID.ToString();
            txtBarcode.Text = item.Barcode;
            txtModelNumber.Text = item.ModelNumber;
            txtSerialNumber.Text = item.SerialNumber;
            txtManufacturer.Text = item.Manufacturer;
            txtDescription.Text = item.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int SelectedItem = 0;
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                SelectedItem = int.Parse(txtID.Text);
                foreach (InventoryItem item in AllInventoryItems)
                {
                    if(item.ID == SelectedItem)
                    {
                        item.Barcode = txtBarcode.Text;
                        item.ModelNumber = txtModelNumber.Text;
                        item.SerialNumber = txtSerialNumber.Text;
                        item.Manufacturer = txtManufacturer.Text;
                        item.Description = txtDescription.Text;
                        UpdateListBox();
                        
                    }
                }
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            Filename = "File" + FileHelper.TimeStamp() + FileExtention;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Filename;
            saveFileDialog1.Filter = "inventory files (*" + FileExtention + ")|*.inventory|All files (*.*)|*.*";

            DialogResult saveDialogResult = saveFileDialog1.ShowDialog();

            if (saveDialogResult == DialogResult.OK)
            {
                Filename = saveFileDialog1.FileName;

                if (!Filename.EndsWith(FileExtention))
                {
                    Filename += FileExtention;
                }
                try
                {
                    FileStream fs = new FileStream(Filename, FileMode.Create);
                    FileHelper.Save(fs, AllInventoryItems);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (saveDialogResult == DialogResult.Cancel)
            {
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Inventory File|*" + FileExtention;

            DialogResult loadDialogResult = openFileDialog1.ShowDialog();

            if (loadDialogResult == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    Filename = openFileDialog1.FileName;

                    try
                    {
                        FileStream fs = new FileStream(Filename, FileMode.Open);
                        List<InventoryItem> tempItems = new List<InventoryItem>();
                        tempItems = FileHelper.Load(fs);
                        fs.Close();
                        if (tempItems != null)
                        {
                            if (tempItems.Count > 0)
                            {
                                AllInventoryItems = tempItems;
                                UpdateListBox();
                            }
                        }                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message, "Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
