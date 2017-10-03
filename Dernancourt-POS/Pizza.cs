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

        // form stuff
        Form form;
        Panel panel;
        Button dButton;
        Button aButton;
        ListBox box;

        public Pizza(string PizzaName, float Price, List<String> toppings, mainForm form)
        {
            this.ItemPrice = Price;
            this.ItemName = PizzaName;
            this.PizzaName = PizzaName;
            this.toppings = toppings;
            this.mainForm = form;
            this.added = new List<string>();
            this.removed = new List<string>();

            PickToppings();
        }

        private void PickToppings()
        {

            // ask if they want to pick toppings
            DialogResult dialogResult = MessageBox.Show("Would you like to add/remove toppings?", "Dernancourt POS", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                form = new Form();
                panel = new Panel();
                dButton = new Button();
                aButton = new Button();
                Button okButton = new Button();
                panel.Dock = DockStyle.Fill;
                form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                form.Controls.Add(panel);

                dButton.Text = "Delete";
                aButton.Text = "Add";
                okButton.Text = "OK";
                dButton.Location = new System.Drawing.Point(5, panel.Size.Height - 30);
                aButton.Location = new System.Drawing.Point(85, panel.Size.Height - 30);
                okButton.Location = new System.Drawing.Point(165, panel.Size.Height - 30);
                

                box = new ListBox();
                panel.Controls.Add(box);
                box.IntegralHeight = false;

                // add items to box
                foreach (string topping in toppings)
                {
                    box.Items.Add(topping);
                }

                box.Height = box.PreferredHeight;
                box.ScrollAlwaysVisible = true;

                panel.Controls.Add(dButton);
                panel.Controls.Add(aButton);
                panel.Controls.
                    Add(okButton);

                dButton.Click += new EventHandler(deleteTopping);
                aButton.Click += new EventHandler(addTopping);
                okButton.Click += new EventHandler(okButton_Click);

                form.ShowDialog();

            } else if (dialogResult == DialogResult.No)
            {
                // all good in the hood, add the item
            }
            // display all toppings that are on the current pizza to the user

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            form.Dispose();
        }

        private void deleteTopping(object sender, EventArgs e)
        {
            this.isModified = true;
            
            if (box.SelectedIndex != -1)
            {
                for (int i = box.SelectedItems.Count - 1; i >= 0; i--)
                {
                    this.removed.Add(box.SelectedItems[i].ToString());
                    box.Items.Remove(box.SelectedItems[i]);
                    
                }
            }
        }

        private void addTopping(object sender, EventArgs e)
        {
            this.isModified = true;
            
            string input = Microsoft.VisualBasic.Interaction.InputBox("Type the topping you would like to add and then click OK", "Dernancourt POS", "Topping...", -1, -1);
            added.
                Add(input);
            box.Items.Add(input);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isModified)
            {
                this.ItemPrice = 0;
                this.PizzaName = null;
                this.ItemName = null;
                this.toppings = null;
                //this.mainForm = null;
                mainForm.myOrder.RemoveItem(this);
            }

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
