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
        public List<string> removed;
        public List<string> added;

        public string ItemName { get; set; }

        public int ItemID { get; set; }

        public float ItemPrice { get; set; }

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
