using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernancourt_POS
{
    public class Pizza : Item
    {

        string PizzaName;
        private List<String> toppings;
        mainForm mainForm;
        string type;

        // form stuff
        Form form;
        Panel panel;
        Button dButton;
        Button aButton;
        ListBox box;
        ListBox box2;
        Button accept;
        Button decline;

        public Pizza(string PizzaName, float Price, List<String> toppings, mainForm form)
        {
            this.ItemPrice = Price;
            this.ItemName = PizzaName;
            this.PizzaName = PizzaName;
            this.toppings = toppings;
            this.mainForm = form;
            this.added = new List<string>();
            this.removed = new List<string>();
            this.type = Regex.Match(PizzaName, @"\(([^)]*)\)").Groups[1].Value;

            Console.WriteLine(type);

            PickToppings();
        }

        private void PickToppings()
        {
            DialogResult halfResult = MessageBox.Show("Would you like half toppings?", "Dernancourt POS", MessageBoxButtons.YesNo);
            if (halfResult == DialogResult.Yes)
            {
                form = new Form();
                Label firstHalf = new Label();
                Label secondHalf = new Label();
                accept = new Button();
                decline = new Button();
                accept.Click += new EventHandler(AcceptToppings);
                decline.Click += new EventHandler(Decline);
                accept.Text = "Accept";
                decline.Text = "Decline";
                accept.Font = new System.Drawing.Font(accept.Font, System.Drawing.FontStyle.Bold);
                decline.Font = new System.Drawing.Font(decline.Font, System.Drawing.FontStyle.Bold);
                accept.Location = new System.Drawing.Point(300, 250);
                decline.Location = new System.Drawing.Point(300, 280);
                firstHalf.Text = "First Half";
                secondHalf.Text = "Second Half";
                firstHalf.Font = new System.Drawing.Font(firstHalf.Font, System.Drawing.FontStyle.Bold);
                secondHalf.Font = new System.Drawing.Font(secondHalf.Font, System.Drawing.FontStyle.Bold);
                firstHalf.AutoSize = false;
                secondHalf.AutoSize = false;
                firstHalf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                secondHalf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                secondHalf.Location = new System.Drawing.Point(150, 0);
                form.Size = new System.Drawing.Size(500, 700);
                form.StartPosition = FormStartPosition.CenterScreen;
                panel = new Panel();
                box = new ListBox();
                box2 = new ListBox();
                panel.Dock = DockStyle.Fill;
                form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                form.Controls.
                    Add(firstHalf);
                form.Controls.
                    Add(secondHalf);
                form.Controls.Add(panel);
                // 32 tradiationals
                // 14 gourmet = 46 total
                box.IntegralHeight = false;
                box2.IntegralHeight = false;

                LinkedList<string> list = new LinkedList<string>();
                list.AddLast("Simply Cheese");
                list.AddLast("Ham and Cheese");
                list.AddLast("Aussie");
                list.AddLast("Ham and Pineapple");
                list.AddLast("American");
                list.AddLast("Margherita");
                list.AddLast("Vegetarian");
                list.AddLast("Seafood");
                list.AddLast("Dernancourt Special");
                list.AddLast("Special");
                list.AddLast("Mushroom");
                list.AddLast("Capricciosa");
                list.AddLast("Chicken Deluxe");
                list.AddLast("Pepperoni");
                list.AddLast("Calabrese");
                list.AddLast("BBQ Chicken");
                list.AddLast("Meat Lovers");
                list.AddLast("House Special");
                list.AddLast("Mexican");
                list.AddLast("Yiros Pizza");
                list.AddLast("Chicken Hawaiian");
                list.AddLast("Bacon Deluxe");
                list.AddLast("Outback");
                list.AddLast("Supreme");
                list.AddLast("The Lot");
                list.AddLast("Tandoori Chicken");
                list.AddLast("Mango Chicken");
                list.AddLast("Chicken Supreme");
                list.AddLast("Hot and Spicy");
                list.AddLast("Marinara");
                list.AddLast("Peri Peri Chicken");
                list.AddLast("Gourmet Vegetarian");
                list.AddLast("Gourmet Mediterranean");
                list.AddLast("Gourmet Lamb");
                list.AddLast("Gourmet Chicken");
                list.AddLast("Gourmet Thai Chicken");
                list.AddLast("Gourmet Special");
                list.AddLast("Gourmet Mexicana");
                list.AddLast("Garlic Prawns");
                list.AddLast("Satay Chicken");
                list.AddLast("El Paso");
                list.AddLast("Original Gourmet");
                list.AddLast("Garlic Chicken");
                list.AddLast("Spinacho");
                list.AddLast("Seafood Gourmet");

                foreach (string name in list)
                {
                    box.Items.Add(name);
                    box2.Items.Add(name);
                }

                box.Height = box.PreferredHeight;
                box2.Height = box2.PreferredHeight;

                box.Location = new System.Drawing.Point(0, 25);
                box2.Location = new System.Drawing.Point(150, 25);

                panel.Controls.Add(box);
                panel.Controls.Add(box2);
                panel.Controls.Add(accept);
                panel.Controls.Add(decline);
                form.ShowDialog();

                return;
            }
            // ask if they want to pick toppings
            DialogResult dialogResult = MessageBox.Show("Would you like to add/remove toppings?", "Dernancourt POS", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                form = new Form();
                panel = new Panel();
                dButton = new Button();
                aButton = new Button();
                form.Size = new System.Drawing.Size(500, 500);
                form.StartPosition = FormStartPosition.CenterScreen;
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

        private void Decline(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AcceptToppings(object sender, EventArgs e)
        {
            if (box.SelectedIndex != -1 && box2.SelectedIndex != -1)
            {
                for (int i = box.SelectedItems.Count - 1; i >= 0; i--)
                {
                    this.ItemName = "(" + this.type + ")" + Environment.NewLine + "Half: " + box.SelectedItems[i].ToString() + Environment.NewLine + "Half " + box2.SelectedItems[i].ToString() + Environment.NewLine;
                    this.PizzaName = "(" + this.type + ")" + Environment.NewLine +  "Half: " + box.SelectedItems[i].ToString() + Environment.NewLine + "Half " + box2.SelectedItems[i].ToString() + Environment.NewLine;
                    this.ItemPrice += 1;
                }
                this.isModified = true;
                form.Dispose();
            }
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
            if (type.Equals("Small"))
            {
                this.ItemPrice += 0.5f;
            } else if (type.Equals("Large"))
            {
                this.ItemPrice += 1.0f;
            } else if (type.Equals("Family"))
            {
                this.ItemPrice += 1.5f;
            } else if (type.Equals("Jumbo"))
            {
                this.ItemPrice += 2.5f;
            } else
            {
                this.ItemPrice += 1.0f;
            }

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
            return Environment.NewLine + "x1 " + this.PizzaName +  " - $" + this.ItemPrice + Environment.NewLine;
        }
    }
}
