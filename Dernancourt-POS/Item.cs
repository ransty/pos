using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernancourt_POS
{
    public class Item
    {
        public string ItemName { get; set; }

        public int ItemID { get; set; }

        public float ItemPrice { get; set; }

        public override string ToString()
        {
            return "ID: " + ItemID + " Item Name: " + ItemName +  " Item Price: " + ItemPrice;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Item objAsItem = obj as Item;
            if (objAsItem == null) return false;
            else return Equals(objAsItem);
        }
        public override int GetHashCode()
        {
            return ItemID;
        }
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return (this.ItemID.Equals(other.ItemID));
        }
    }
}
