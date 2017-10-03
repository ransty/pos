using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernancourt_POS
{
    public class Pizza : Item
    {

        string PizzaName;
        private List<String> toppings;
        mainForm mainForm;

        public Pizza(string PizzaName, float Price, List<String> toppings, mainForm form)
        {
            this.ItemPrice = Price;
            this.PizzaName = PizzaName;
            this.toppings = toppings;
            this.mainForm = form;

            PickToppings();
        }

        private void PickToppings()
        {

            // ask if they want to pick toppings
            DialogResult dialogResult = MessageBox.Show("Would you like to add/remove toppings?", "Dernancourt POS", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            } else if (dialogResult == DialogResult.No)
            {

            }
            // display all toppings that are on the current pizza to the user

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
