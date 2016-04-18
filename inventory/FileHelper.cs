using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace inventory
{
    static class FileHelper
    {
        public static ObservableCollection<InventoryItem> Load(FileStream file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<InventoryItem>));
            ObservableCollection<InventoryItem> returnMe = (ObservableCollection<InventoryItem>)serializer.Deserialize(file);
            return returnMe;
        }
        public static void Save(FileStream file, ObservableCollection<InventoryItem> items)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<InventoryItem>));
            serializer.Serialize(file, items);
        }
        public static string TimeStamp()
        {
            return DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;

        }
    }
}
