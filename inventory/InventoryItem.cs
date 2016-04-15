using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    public class InventoryItem
    {
        public string Barcode;
        public string ModelNumber;
        public string SerialNumber;
        public string Manufacturer;
        public string Description;
        public float WeightInGrams;
        public int ID;

        public InventoryItem(int ID, string Barcode, string ModelNumber, string SerialNumber, string Manufacturer)
        {
            this.Barcode = Barcode;
            this.ModelNumber = ModelNumber;
            this.SerialNumber = SerialNumber;
            this.Manufacturer = Manufacturer;
            this.ID = ID;
        }

        public InventoryItem()
        {
        }

        public void SetSerialNumber(string NewSerialNumber)
        {
            this.SerialNumber = NewSerialNumber;
        }

        public override string ToString()
        {
            return this.ModelNumber + " SN: " + this.SerialNumber;
        }


    }
}
