using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernancourt_POS
{
    public class Item : IEquatable<Item>
    {
        public bool IsModified { get; protected set; }
        public List<string> Removed { get; private set; }
        public List<string> Added { get; private set; }

        public string ItemName { get; set; }

        public int ItemID { get; set; }

        public float ItemPrice { get; set; }

        public Item()
        {
            this.Added = new List<string>();
            this.Removed = new List<string>();
        }

        public override string ToString()
        {
            return $"{Environment.NewLine}x1 {this.ItemName} - ${this.ItemPrice}{Environment.NewLine}";
        }
        public override bool Equals(object obj)
        {
            return obj != null && this.Equals(obj as Item);
        }
        public override int GetHashCode()
        {
            return this.ItemID;
        }
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return (this.ItemID.Equals(other.ItemID));
        }
    }
}
