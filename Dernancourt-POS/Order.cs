using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Dernancourt_POS
{

    /**
     * This class tracks the order and price
     **/
    public class Order
    {
        private readonly List<Item> items;  // items of the order
        private readonly string name;
        private readonly string phoneNumber;
        private readonly string address;
        private readonly string suburb;
        public bool IsDelivery { get; set; }

        public float Price { get; set; }// total price of order
        public IReadOnlyList<Item> Items => this.items;

        public Order() : this(null, null) { }

        public Order(string name, string phoneNumber) : this(name, phoneNumber, null, null)
        {
            // takeaway order
            this.IsDelivery = false;
        }

        public Order(string name, string phoneNumber, string address, string suburb)
        {
            // delivery order
            this.items = new List<Item>();
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.suburb = suburb;
            this.IsDelivery = true;
            // add $5 to delivery
            this.Price += 5;
        }

        public void AddItem(Item item)
        {
            this.items.Add(item);
            Console.WriteLine("SUCCESSFULLY ADDED: " + item.ItemName);
            this.Price += item.ItemPrice;
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public void RemoveItem(Item item)
        {
            this.items.Remove(item);
            Console.WriteLine("SUCCESSFULLY REMOVED: " + item.ItemName);
            this.Price -= item.ItemPrice;
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public void RemoveItemAtIndex(int index)
        {
            Item temp = this.items[index];
            this.items.RemoveAt(index);
            Console.WriteLine("SUCCESSFULLY REMOVED ITEM AT INDEX: " + index);
            this.Price -= temp.ItemPrice;
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public int GetIndex(Item item)
        {
            return this.items.IndexOf(item);
        }

        // DEPRECIATED: This metod is no longer supported, i.e it actually just doubles the Price every time it is called
        public void CalculatePrice()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                this.Price += this.items[i].ItemPrice;
            }
        }

        public string GetTotalPrice()
        {
            return this.Price.ToString("##.###");
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder("Name: ");
            stringBuilder.Append(this.name);
            stringBuilder.AppendLine("Phone Number: ");
            stringBuilder.Append(this.phoneNumber);

            if (this.IsDelivery)
            {
                stringBuilder.AppendLine("Address: ");
                stringBuilder.Append(this.address);
                stringBuilder.AppendLine("Suburb: ");
                stringBuilder.Append(this.suburb);
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }

    }
}