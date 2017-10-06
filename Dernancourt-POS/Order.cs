using System;
using System.Collections.Generic;

namespace Dernancourt_POS
{

    /**
     * This class tracks the order and price
     **/
    public class Order
    {
        private float Price; // total price of order
        public List<Item> Items; // items of the order
        private string Name;
        private string PhoneNumber;
        private string Address;
        private string Suburb;
        private bool Delivery;

        public Order()
        {
            Items = new List<Item>();
        }

        public Order(string Name, string PhoneNumber)
        {
            // takeaway order
            Items = new List<Item>();
            this.Name = Name;
            this.PhoneNumber = Name;
            this.Delivery = false;
        }

        public Order(string Name, string PhoneNumber, string Address, string Suburb)
        {
            // delivery order
            Items = new List<Item>();
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Suburb = Suburb;
            this.Delivery = true;
            // add $5 to delivery
            this.Price += 5;
        }

        public bool isDelivery()
        {
            return Delivery;
        }
        
        public void SetPrice(float price)
        {
            this.Price = price;
        }

        public float getPrice()
        {
            return this.Price;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            Console.WriteLine("SUCCESSFULLY ADDED: " + item.ItemName);
            this.Price += item.ItemPrice;
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
            Console.WriteLine("SUCCESSFULLY REMOVED: " + item.ItemName);
            this.Price -= item.ItemPrice;
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public void RemoveItemAtIndex(int index)
        {
            Item temp = Items[index];
            Items.RemoveAt(index);
            Console.WriteLine("SUCCESSFULLY REMOVED ITEM AT INDEX: " + index);
            this.Price -= temp.ItemPrice;
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public int GetIndex(Item item)
        {
            return Items.IndexOf(item);
        }

        // DEPRECIATED: This metod is no longer supported, i.e it actually just doubles the price every time it is called
        public void CalculatePrice()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Price += Items[i].ItemPrice;
            }
        }

        public string getTotalPrice()
        {
            return this.Price.ToString();
        }

        public override string ToString()
        {
            if (this.isDelivery())
            {
                return "Name: " + this.Name + Environment.NewLine + "Phone Number: " + this.PhoneNumber + Environment.NewLine + "Address: " + this.Address + Environment.NewLine + "Suburb: " + this.Suburb + Environment.NewLine + Environment.NewLine;
            }
            return "Name: " + this.Name + Environment.NewLine + "Phone Number: " + this.PhoneNumber + Environment.NewLine + Environment.NewLine;
        }

    }
}
