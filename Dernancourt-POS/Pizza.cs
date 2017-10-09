using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            this.type = Regex.Match(PizzaName, @"\(([^)]*)\)").Groups[1].Value;

            Console.WriteLine(this.type);

            this.PickToppings();
        }

        private void PickToppings()
        {
            DialogResult halfResult = MessageBox.Show("Would you like half toppings?", "Dernancourt POS", MessageBoxButtons.YesNo);
            if (halfResult == DialogResult.Yes)
            {
                this.form = new Form();
                Label firstHalf = new Label();
                Label secondHalf = new Label();
                this.accept = new Button();
                this.decline = new Button();
                this.accept.Click += new EventHandler(this.AcceptToppings);
                this.decline.Click += new EventHandler(this.Decline);
                this.accept.Text = "Accept";
                this.decline.Text = "Decline";
                this.accept.Font = new System.Drawing.Font(this.accept.Font, System.Drawing.FontStyle.Bold);
                this.decline.Font = new System.Drawing.Font(this.decline.Font, System.Drawing.FontStyle.Bold);
                this.accept.Location = new System.Drawing.Point(300, 250);
                this.decline.Location = new System.Drawing.Point(300, 280);
                firstHalf.Text = "First Half";
                secondHalf.Text = "Second Half";
                firstHalf.Font = new System.Drawing.Font(firstHalf.Font, System.Drawing.FontStyle.Bold);
                secondHalf.Font = new System.Drawing.Font(secondHalf.Font, System.Drawing.FontStyle.Bold);
                firstHalf.AutoSize = false;
                secondHalf.AutoSize = false;
                firstHalf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                secondHalf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                secondHalf.Location = new System.Drawing.Point(150, 0);
                this.form.Size = new System.Drawing.Size(500, 700);
                this.form.StartPosition = FormStartPosition.CenterScreen;
                this.panel = new Panel();
                this.box = new ListBox();
                this.box2 = new ListBox();
                this.panel.Dock = DockStyle.Fill;
                this.form.FormClosed += new FormClosedEventHandler(this.Form_FormClosed);
                this.form.Controls.
                    Add(firstHalf);
                this.form.Controls.
                    Add(secondHalf);
                this.form.Controls.Add(this.panel);
                // 32 tradiationals
                // 14 gourmet = 46 total
                this.box.IntegralHeight = false;
                this.box2.IntegralHeight = false;

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
                    this.box.Items.Add(name);
                    this.box2.Items.Add(name);
                }

                this.box.Height = this.box.PreferredHeight;
                this.box2.Height = this.box2.PreferredHeight;

                this.box.Location = new System.Drawing.Point(0, 25);
                this.box2.Location = new System.Drawing.Point(150, 25);

                this.panel.Controls.Add(this.box);
                this.panel.Controls.Add(this.box2);
                this.panel.Controls.Add(this.accept);
                this.panel.Controls.Add(this.decline);
                this.form.ShowDialog();

                return;
            }
            // ask if they want to pick toppings
            DialogResult dialogResult = MessageBox.Show("Would you like to add/remove toppings?", "Dernancourt POS", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.form = new Form();
                this.panel = new Panel();
                this.dButton = new Button();
                this.aButton = new Button();
                this.form.Size = new System.Drawing.Size(500, 500);
                this.form.StartPosition = FormStartPosition.CenterScreen;
                Button okButton = new Button();
                this.panel.Dock = DockStyle.Fill;
                this.form.FormClosed += new FormClosedEventHandler(this.Form_FormClosed);
                this.form.Controls.Add(this.panel);

                this.dButton.Text = "Delete";
                this.aButton.Text = "Add";
                okButton.Text = "OK";
                this.dButton.Location = new System.Drawing.Point(5, this.panel.Size.Height - 30);
                this.aButton.Location = new System.Drawing.Point(85, this.panel.Size.Height - 30);
                okButton.Location = new System.Drawing.Point(165, this.panel.Size.Height - 30);


                this.box = new ListBox();
                this.panel.Controls.Add(this.box);
                this.box.IntegralHeight = false;

                // add items to box
                foreach (string topping in this.toppings)
                {
                    this.box.Items.Add(topping);
                }

                this.box.Height = this.box.PreferredHeight;
                this.box.ScrollAlwaysVisible = true;

                this.panel.Controls.Add(this.dButton);
                this.panel.Controls.Add(this.aButton);
                this.panel.Controls.
                    Add(okButton);

                this.dButton.Click += new EventHandler(this.deleteTopping);
                this.aButton.Click += new EventHandler(this.addTopping);
                okButton.Click += new EventHandler(this.okButton_Click);

                this.form.ShowDialog();

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
            if (this.box.SelectedIndex != -1 && this.box2.SelectedIndex != -1)
            {
                for (int i = this.box.SelectedItems.Count - 1; i >= 0; i--)
                {
                    this.ItemName = "(" + this.type + ")" + Environment.NewLine + "Half: " + this.box.SelectedItems[i].ToString() + Environment.NewLine + "Half " + this.box2.SelectedItems[i].ToString() + Environment.NewLine;
                    this.PizzaName = "(" + this.type + ")" + Environment.NewLine +  "Half: " + this.box.SelectedItems[i].ToString() + Environment.NewLine + "Half " + this.box2.SelectedItems[i].ToString() + Environment.NewLine;
                    this.ItemPrice += 1;
                }
                this.IsModified = true;
                this.form.Dispose();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.form.Dispose();
        }

        private void deleteTopping(object sender, EventArgs e)
        {
            this.IsModified = true;
            
            if (this.box.SelectedIndex != -1)
            {
                for (int i = this.box.SelectedItems.Count - 1; i >= 0; i--)
                {
                    this.Removed.Add(this.box.SelectedItems[i].ToString());
                    this.box.Items.Remove(this.box.SelectedItems[i]);
                    
                }
            }
        }

        private void addTopping(object sender, EventArgs e)
        {
            this.IsModified = true;
            
            string input = Microsoft.VisualBasic.Interaction.InputBox("Type the topping you would like to add and then click OK", "Dernancourt POS", "Topping...", -1, -1);
            this.Added.Add(input);
            this.box.Items.Add(input);

            if (this.type.Equals("Small"))
            {
                this.ItemPrice += 0.5f;
            } else if (this.type.Equals("Large"))
            {
                this.ItemPrice += 1.0f;
            } else if (this.type.Equals("Family"))
            {
                this.ItemPrice += 1.5f;
            } else if (this.type.Equals("Jumbo"))
            {
                this.ItemPrice += 2.5f;
            } else
            {
                this.ItemPrice += 1.0f;
            }

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.IsModified)
            {
                this.ItemPrice = 0;
                this.PizzaName = null;
                this.ItemName = null;
                this.toppings = null;
                //this.mainForm = null;
                this.mainForm.myOrder.RemoveItem(this);
            }

        }

        public void RemoveTopping(string ToppingName)
        {
            this.toppings.Remove(ToppingName);
        }

        public void AddTopping(string ToppingName)
        {
            this.toppings.Add(ToppingName);
        }

        public override string ToString()
        {
            return Environment.NewLine + "x1 " + this.PizzaName +  " - $" + this.ItemPrice + Environment.NewLine;
        }
    }
}
