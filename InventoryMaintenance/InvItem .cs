using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    internal class InvItem
    {
        public InvItem() { }

        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set }

       public string GetDisplayText(string sep) 
        {
            return $"{ItemNo.ToString()}{sep}{Description}{sep}{Price.ToString("c")}";
        }

        
    }
}
