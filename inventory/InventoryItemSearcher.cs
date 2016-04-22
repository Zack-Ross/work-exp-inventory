using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class InventoryItemSearcher
    {
        public List<InventoryItem> Search(List<InventoryItem> Haystack, string Needle)
        {
            List<InventoryItem> returnMe = new List<InventoryItem>();
            Dictionary<InventoryItem, int> ItemsWithScore = new Dictionary<InventoryItem, int>();

            List<string> SearchedTerms = Needle.Trim().Split(' ').ToList();
            foreach (InventoryItem item in Haystack)
            {
                ItemsWithScore.Add(item, 0);
                foreach (string term in SearchedTerms)
                {
                    if (item.Barcode == term)
                    {
                        ItemsWithScore[item] += 100;
                    }
                    else if (item.Barcode.Contains(term))
                    {
                        ItemsWithScore[item] += 10;
                    }
                    if (item.Manufacturer == term)
                    {
                        ItemsWithScore[item] += 100;
                    }
                    else if (item.Manufacturer.Contains(term))
                    {
                        ItemsWithScore[item] += 10;
                    }
                    if (item.ModelNumber == term)
                    {
                        ItemsWithScore[item] += 100;
                    }
                    else if (item.ModelNumber.Contains(term))
                    {
                        ItemsWithScore[item] += 10;
                    }
                    if (item.SerialNumber == term)
                    {
                        ItemsWithScore[item] += 100;
                    }
                    else if (item.SerialNumber.Contains(term))
                    {
                        ItemsWithScore[item] += 10;
                    }
                    
                }
            }
            foreach (KeyValuePair<InventoryItem, int> item in ItemsWithScore.Where(i => i.Value >1).OrderByDescending(i => i.Value))
            {
                returnMe.Add(item.Key);
            }
            return returnMe;
        }
    }
}
