using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace inventory
{
    static class FileHelper
    {
        public static List<InventoryItem> Load(FileStream file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<InventoryItem>));
            List<InventoryItem> returnMe = (List<InventoryItem>)serializer.Deserialize(file);
            return returnMe;
        }
        public static void Save(FileStream file, List<InventoryItem> items)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<InventoryItem>));
            serializer.Serialize(file, items);
        }
        public static string TimeStamp()
        {
            return DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;

        }
    }
}
