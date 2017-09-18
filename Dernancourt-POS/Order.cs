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
        private List<Item> Items; // items of the order
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
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            Console.WriteLine("SUCCESSFULLY ADDED: " + item.ItemName);
            CalculatePrice();
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
            Console.WriteLine("SUCCESSFULLY REMOVED: " + item.ItemName);
            CalculatePrice();
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public void RemoveItemAtIndex(int index)
        {
            Items.RemoveAt(index);
            Console.WriteLine("SUCCESSFULLY REMOVED ITEM AT INDEX: " + index);
            CalculatePrice();
            Console.WriteLine("CURRENT PRICE OF ORDER: $" + this.Price);
        }

        public int GetIndex(Item item)
        {
            return Items.IndexOf(item);
        }

        public void CalculatePrice()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Price += Items[i].ItemPrice;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Phone Number: " + this.PhoneNumber + " Delivery?: " + this.Delivery
                 + " Address: " + this.Address + " Suburb: " + this.Suburb + "Total Price: $" + this.Price;
        }

    }
}
