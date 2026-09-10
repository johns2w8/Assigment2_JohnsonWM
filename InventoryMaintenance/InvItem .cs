using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Wes Johnson

    //InvItem represents encapsulation by being a class that has it's inner working below board and the
    // other classes only interact with the data in the capsule via getters and setters.
    public class InvItem
    {
        public InvItem() { }

        //Builds the InvItem caspule for other classes to use
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

       public string GetDisplayText(string sep) 
        {
            return $"{ItemNo.ToString()}{sep}{Description}{sep}{Price.ToString("c")}";
        }

        
    }
}
