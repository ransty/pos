using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernancourt_POS
{
    public class Pizza : Item
    {

        string PizzaName;
        private List<String> toppings;

        public Pizza(string PizzaName, float Price, List<String> toppings)
        {
            this.ItemPrice = Price;
            this.PizzaName = PizzaName;
            this.toppings = toppings;

            // as soon as item gets created, ask if they want to remove/add any toppings
        }

        public void RemoveTopping(string ToppingName)
        {
            toppings.Remove(ToppingName);
        }

        public void AddTopping(string ToppingName)
        {
            toppings.Add(ToppingName);
        }

        public override string ToString()
        {
            return "x1 " + this.PizzaName +  " - $" + this.ItemPrice;
        }
    }
}
