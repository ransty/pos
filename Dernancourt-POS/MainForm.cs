using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernancourt_POS
{
    public partial class mainForm : Form
    {
        public Order myOrder;

        List<string> simplyCheese = new List<string>();
        List<string> hamCheese = new List<string>();
        List<string> aussie = new List<string>();
        List<string> hamPineapple = new List<string>();
        List<string> american = new List<string>();
        List<string> margherita = new List<string>();
        List<string> vegetarian = new List<string>();
        List<string> seafood = new List<string>();
        List<string> dernancourt = new List<string>();
        List<string> special = new List<string>();
        List<string> mushroom = new List<string>();
        List<string> capricciosa = new List<string>();
        List<string> chickenDeluxe = new List<string>();
        List<string> pepperoni = new List<string>();
        List<string> calabrese = new List<string>();
        List<string> bbqChicken = new List<string>();
        List<string> meatlovers = new List<string>();
        List<string> houseSpecial = new List<string>();
        List<string> mexican = new List<string>();
        List<string> yiros = new List<string>();
        List<string> chickenHawaiian = new List<string>();
        List<string> baconDeluxe = new List<string>();
        List<string> outback = new List<string>();
        List<string> supreme = new List<string>();
        List<string> theLot = new List<string>();
        List<string> fourCheese = new List<string>();
        List<string> tandooriChicken = new List<string>();
        List<string> mangoChicken = new List<string>();
        List<string> chickenSupreme = new List<string>();
        List<string> hotSpicy = new List<string>();
        List<string> marinara = new List<string>();
        List<string> periChicken = new List<string>();
        List<string> gVegetarian = new List<string>();
        List<string> gMediterranean = new List<string>();
        List<string> gLamb = new List<string>();
        List<string> gChicken = new List<string>();
        List<string> gThaiChicken = new List<string>();
        List<string> gSpecial = new List<string>();
        List<string> gMexicana = new List<string>();
        List<string> gGarlicPrawn = new List<string>();
        List<string> satayChicken = new List<string>();
        List<string> elPaso = new List<string>();

        public mainForm()
        {
            this.InitializeComponent();
            //Order order = new Order();
            this.simplyCheese.Add("Tomato Sauce");
            this.simplyCheese.Add("Cheese");
            this.hamCheese.Add("Tomato Sauce");
            this.hamCheese.Add("Cheese");
            this.hamCheese.Add("Ham");
            this.aussie.Add("Tomato");
            this.aussie.Add("Cheese");
            this.aussie.Add("Ham");
            this.aussie.Add("Bacon");
            this.aussie.Add("Egg");
            this.hamPineapple.Add("Tomato");
            this.hamPineapple.Add("Cheese");
            this.hamPineapple.Add("Ham");
            this.hamPineapple.Add("Pineapple");
            this.american.Add("Tomato");
            this.american.Add("Cheese");
            this.american.Add("Salami");
            this.margherita.Add("Tomato");
            this.margherita.Add("Cheese");
            this.margherita.Add("Fresh Tomato");
            this.margherita.Add("Garlic and Herbs");
            this.vegetarian.Add("Tomato");
            this.vegetarian.Add("Cheese");
            this.vegetarian.Add("Onion");
            this.vegetarian.Add("Diced Tomato");
            this.vegetarian.Add("Pineapple");
            this.vegetarian.Add("Mushroom");
            this.vegetarian.Add("Capsicum");
            this.vegetarian.Add("Olives");
            this.vegetarian.Add("Garlic and Herbs");
            this.seafood.Add("Tomato");
            this.seafood.Add("Cheese");
            this.seafood.Add("Calamari");
            this.seafood.Add("Smoked Mussles");
            this.seafood.Add("Prawns");
            this.seafood.Add("Anchovies");
            this.seafood.Add("Garlic");
            this.dernancourt.Add("Tomato");
            this.dernancourt.Add("Cheese");
            this.dernancourt.Add("Ham");
            this.dernancourt.Add("Pineapple");
            this.dernancourt.Add("Mushrooms");
            this.dernancourt.Add("Capsicum");
            this.dernancourt.Add("Bacon");
            this.dernancourt.Add("Onion");
            this.special.Add("Tomato");
            this.special.Add("Cheese");
            this.special.Add("Ham");
            this.special.Add("Salami");
            this.special.Add("Olives");
            this.special.Add("Mushroom");
            this.special.Add("Capsicum");
            this.mushroom.Add("Tomato");
            this.mushroom.Add("Cheese");
            this.mushroom.Add("Ham");
            this.mushroom.Add("Mushroom");
            this.capricciosa.Add("Tomato");
            this.capricciosa.Add("Cheese");
            this.capricciosa.Add("Bacon");
            this.capricciosa.Add("Olives");
            this.capricciosa.Add("Onion");
            this.capricciosa.Add("Mushroom");
            this.capricciosa.Add("Capsicum");
            this.chickenDeluxe.Add("Tomato");
            this.chickenDeluxe.Add("Cheese");
            this.chickenDeluxe.Add("Mushroom");
            this.chickenDeluxe.Add("Ham");
            this.chickenDeluxe.Add("Chicken");
            this.chickenDeluxe.Add("Pineapple");
            this.pepperoni.Add("Tomato");
            this.pepperoni.Add("Cheese");
            this.pepperoni.Add("Pepperoni");
            this.calabrese.Add("Tomato");
            this.calabrese.Add("Cheese");
            this.calabrese.Add("Spicy Salami");
            this.calabrese.Add("Olives");
            this.calabrese.Add("Mushroom");
            this.calabrese.Add("Capsicum");
            this.calabrese.Add("Bacon");
            this.bbqChicken.Add("BBQ Sauce");
            this.bbqChicken.Add("Cheese");
            this.bbqChicken.Add("Chicken");
            this.bbqChicken.
                Add("Capsicum");
            this.bbqChicken.Add("Pineapple");
            this.bbqChicken.Add("Bacon");
            this.meatlovers.Add("Tomato");
            this.meatlovers.Add("Cheese");
            this.meatlovers.Add("Salami");
            this.meatlovers.Add("Ham");
            this.meatlovers.Add("Bacon");
            this.meatlovers.Add("Beef");
            this.houseSpecial.Add("Tomato");
            this.houseSpecial.Add("Cheese");
            this.houseSpecial.Add("Bacon");
            this.houseSpecial.Add("Egg");
            this.houseSpecial.Add("Onion");
            this.mexican.Add("Tomato");
            this.mexican.Add("Cheese");
            this.mexican.Add("Onion");
            this.mexican.Add("Capsicum");
            this.mexican.Add("Hot Salami");
            this.mexican.Add("Beef");
            this.mexican.Add("Oregano");
            this.yiros.Add("Tomato");
            this.yiros.Add("Cheese");
            this.yiros.Add("Onion");
            this.yiros.Add("Capsicum");
            this.yiros.Add("Lamb pieces");
            this.chickenHawaiian.Add("Tomato");
            this.chickenHawaiian.Add("Cheese");
            this.chickenHawaiian.Add("Chicken");
            this.chickenHawaiian.Add("Pineapple");
            this.baconDeluxe.Add("Tomato");
            this.baconDeluxe.Add("Cheese");
            this.baconDeluxe.Add("Bacon");
            this.baconDeluxe.Add("Onion");
            this.baconDeluxe.Add("Capsicum");
            this.baconDeluxe.Add("Pineapple");
            this.outback.Add("Tomato");
            this.outback.Add("Cheese");
            this.outback.Add("Salami");
            this.outback.Add("Onion");
            this.outback.Add("Garlic");
            this.outback.Add("BBQ Sauce");
            this.supreme.Add("Tomato");
            this.supreme.Add("Cheese");
            this.supreme.
                Add("Ham");
            this.supreme.Add("Salami");
            this.supreme.Add("Olives");
            this.supreme.Add("Mushroom");
            this.supreme.
                Add("Capsicum");
            this.supreme.Add("Pineapple");
            this.supreme.Add("Anchovies");
            this.theLot.Add("Tomato");
            this.theLot.Add("Cheese");
            this.theLot.Add("Ham");
            this.theLot.Add("Salami");
            this.theLot.Add("Mushroom");
            this.theLot.Add("Capsicum");
            this.theLot.Add("Onion");
            this.theLot.Add("Pineapple");
            this.theLot.Add("Olives");
            this.theLot.Add("Bacon");
            this.theLot.Add("Anchovies");
            this.fourCheese.Add("Bocconcini");
            this.fourCheese.Add("Parmesan");
            this.fourCheese.Add("Feta");
            this.fourCheese.Add("Mozzarella");
            this.tandooriChicken.Add("Tomato");
            this.tandooriChicken.Add("Cheese");
            this.tandooriChicken.Add("Capsicum");
            this.tandooriChicken.Add("Onion");
            this.tandooriChicken.Add("Diced tomato");
            this.tandooriChicken.Add("Tandoori Chicken");
            this.tandooriChicken.Add("Garlic");
            this.tandooriChicken.Add("Parsley");
            this.tandooriChicken.
                Add("Chilli Flakes");
            this.mangoChicken.Add("Tomato");
            this.mangoChicken.Add("Cheese");
            this.mangoChicken.
                Add("Onion");
            this.mangoChicken.Add("Marinated Chicken");
            this.mangoChicken.Add("Mango");
            this.chickenSupreme.Add("Tomato");
            this.chickenSupreme.Add("Cheese");
            this.chickenSupreme.Add("Onion");
            this.chickenSupreme.Add("Chicken");
            this.chickenSupreme.Add("Mushroom");
            this.chickenSupreme.Add("Capsicum");
            this.chickenSupreme.Add("Oregano");
            this.chickenSupreme.Add("Fresh Garlic");
            this.hotSpicy.Add("Tomato");
            this.hotSpicy.Add("Cheese");
            this.hotSpicy.Add("Onion");
            this.hotSpicy.Add("Beef");
            this.hotSpicy.Add("Hot Salami");
            this.hotSpicy.Add("Olives");
            this.hotSpicy.Add("Jalapeno");
            this.hotSpicy.Add("Chilli Flakes");
            this.marinara.Add("Tomato");
            this.marinara.Add("Cheese");
            this.marinara.Add("Marinara Mix");
            this.marinara.Add("Garlic and Herbs");
            this.periChicken.Add("Tomato");
            this.periChicken.Add("Cheese");
            this.periChicken.Add("Spanish onion");
            this.periChicken.Add("Marinated Chicken");
            this.periChicken.Add("Capsicum");
            this.periChicken.Add("Peri Peri Drizzle");
            this.gVegetarian.Add("Tomato");
            this.gVegetarian.Add("Cheese");
            this.gVegetarian.Add("Eggplant");
            this.gVegetarian.Add("Roasted Capsicum");
            this.gVegetarian.Add("Olives");
            this.gVegetarian.Add("Spanish Onion");
            this.gVegetarian.Add("ARtichokes");
            this.gVegetarian.Add("Oregano");
            this.gVegetarian.Add("Bocconcini");
            this.gMediterranean.Add("Tomato");
            this.gMediterranean.Add("Cheese");
            this.gMediterranean.Add("Salami");
            this.gMediterranean.Add("Pepperoni");
            this.gMediterranean.Add("Grilled Eggplant");
            this.gMediterranean.Add("Mushroom");
            this.gMediterranean.Add("Roasted Capsicum");
            this.gMediterranean.Add("Olives");
            this.gMediterranean.Add("Sundried Tomato");
            this.gMediterranean.Add("Bocconcini");
            this.gMediterranean.Add("Fresh basil");
            this.gLamb.Add("Tomato");
            this.gLamb.Add("Cheese");
            this.gLamb.Add("Lamb");
            this.gLamb.Add("Spanish Onion");
            this.gLamb.Add("Diced Tomato");
            this.gLamb.Add("Basil");
            this.gLamb.Add("Garlic sauce");
            this.gChicken.Add("Tomato");
            this.gChicken.Add("Cheese");
            this.gChicken.Add("Chicken");
            this.gChicken.Add("Mushrooms");
            this.gChicken.Add("Sundried Tomato");
            this.gChicken.Add("Roasted Capsicum");
            this.gChicken.Add("Spanish Onion");
            this.gChicken.Add("Oregano");
            this.gThaiChicken.Add("Sweet Chilli Sauce");
            this.gThaiChicken.Add("Cheese");
            this.gThaiChicken.Add("Chicken");
            this.gThaiChicken.Add("Capsicum");
            this.gThaiChicken.Add("Garlic");
            this.gSpecial.Add("Tomato");
            this.gSpecial.Add("Cheese");
            this.gSpecial.Add("Leg Ham");
            this.gSpecial.Add("Salami");
            this.gSpecial.Add("Mushrooms");
            this.gSpecial.Add("Roasted Capsicum");
            this.gSpecial.Add("Olives");
            this.gMexicana.Add("Tomato");
            this.gMexicana.Add("Mozzarella");
            this.gMexicana.Add("Spicy Italian Salami");
            this.gMexicana.Add("Spanish Onion");
            this.gMexicana.Add("Roasted Capsicum");
            this.gMexicana.Add("Olives");
            this.gGarlicPrawn.Add("Tomato");
            this.gGarlicPrawn.Add("Cheese");
            this.gGarlicPrawn.Add("Prawn");
            this.gGarlicPrawn.Add("Garlic");
            this.satayChicken.Add("Satay Sauce");
            this.satayChicken.Add("Cheese");
            this.satayChicken.Add("Mushrooms");
            this.satayChicken.Add("Roasted Capsicum");
            this.satayChicken.Add("Roasted onion");
            this.satayChicken.Add("Chicken");
            this.elPaso.Add("Tomato");
            this.elPaso.Add("Cheese");
            this.elPaso.Add("Chicken");
            this.elPaso.Add("Roasted capsicum");
            this.elPaso.Add("Jalapenos");
            this.elPaso.Add("Beef");
            this.elPaso.Add("Chilli Flakes");
            this.elPaso.Add("Garlic Sauce");

        }

        public void displayMessage(string Message)
        {
            MessageBox.Show(Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.halfhalfPanel.Visible = false;
            this.startersPanel.Visible = false;
            this.starters2Panel.Visible = false;
            this.starters3Panel.Visible = false;
            this.starters4Panel.Visible = false;
            this.mainsPanel.Visible = false;
            this.mains2Panel.Visible = false;
            this.mealDealPanel.Visible = false;
            this.mealDealPanel2.Visible = false;
            this.traditionalPanel.Visible = false;
            this.traditional2Panel.Visible = false;
            this.traditional3Panel.Visible = false;
            this.traditional4Panel.Visible = false;
            this.gourmetPanel.Visible = false;
            this.gourmet2Panel.Visible = false;
            this.seafoodPanel.Visible = false;
            this.abPanel.Visible = false;
            this.ab2Panel.Visible = false;
            this.pastaPanel.Visible = false;
            this.pastaBakePanel.Visible = false;
            this.ribsnwingsPanel.Visible = false;
            this.risottoPanel.Visible = false;
            this.kebabWrapPanel.Visible = false;
            this.saladsPanel.Visible = false;
            this.desertsPanel.Visible = false;
            this.desert2Panel.Visible = false;
            this.beveragesPanel.Visible = false;
            this.summaryPanel.Visible = false;
            this.editItemsPanel.Visible = false;
            this.commentPanel.Visible = false;
            // on load make all panels fill
            this.orderPanel.Dock = DockStyle.Fill;
            this.mealDealPanel.Dock = DockStyle.Fill;
            this.mealDealPanel2.Dock = DockStyle.Fill;
            this.halfhalfPanel.Dock = DockStyle.Fill;
            this.startersPanel.Dock = DockStyle.Fill;
            this.starters2Panel.Dock = DockStyle.Fill;
            this.starters3Panel.Dock = DockStyle.Fill;
            this.starters4Panel.Dock = DockStyle.Fill;
            this.mainsPanel.Dock = DockStyle.Fill;
            this.mains2Panel.Dock = DockStyle.Fill;
            this.traditionalPanel.Dock = DockStyle.Fill;
            this.traditional2Panel.Dock = DockStyle.Fill;
            this.traditional3Panel.Dock = DockStyle.Fill;
            this.traditional4Panel.Dock = DockStyle.Fill;
            this.gourmetPanel.Dock = DockStyle.Fill;
            this.gourmet2Panel.Dock = DockStyle.Fill;
            this.seafoodPanel.Dock = DockStyle.Fill;
            this.abPanel.Dock = DockStyle.Fill;
            this.ab2Panel.Dock = DockStyle.Fill;
            this.pastaPanel.Dock = DockStyle.Fill;
            this.pastaBakePanel.Dock = DockStyle.Fill;
            this.ribsnwingsPanel.Dock = DockStyle.Fill;
            this.risottoPanel.Dock = DockStyle.Fill;
            this.kebabWrapPanel.Dock = DockStyle.Fill;
            this.saladsPanel.Dock = DockStyle.Fill;
            this.desert2Panel.Dock = DockStyle.Fill;
            this.desertsPanel.Dock = DockStyle.Fill;
            this.beveragesPanel.Dock = DockStyle.Fill;
            this.summaryPanel.Dock = DockStyle.Fill;
            this.editItemsPanel.Dock = DockStyle.Fill;
            this.commentPanel.Dock = DockStyle.Fill;

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void addressLbl_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberLbl_Click(object sender, EventArgs e)
        {
            //???????????????
        }

        private void suburbLbl_Click(object sender, EventArgs e)
        {

        }

        private void customerSuburbTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerAddressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerPhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || e.KeyChar > 122)
            {
                e.Handled = true;
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {

            // now lets check if they want a delivery or takeaway (If there is an address or not)
            if (string.IsNullOrEmpty(this.customerPhoneNumberTxt.Text))
            {
                const string message =
                     "At least a phone number is required, please enter a phone number";
                const string caption = "Form Validation";
                MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }

            if (this.customerAddressTxt.Text.Length > 0 && (!string.IsNullOrEmpty(this.customerPhoneNumberTxt.Text)))
            {
                // delivery
                this.myOrder = new Order(this.customerNameTxt.Text, this.customerPhoneNumberTxt.Text, this.customerAddressTxt.Text, this.customerSuburbTxt.Text);
                Console.WriteLine(this.myOrder.ToString());

                // move to orderPanel
                this.orderPanel.Visible = true;
            }
            else if (!string.IsNullOrEmpty(this.customerPhoneNumberTxt.Text))
            {
                // takeaway
                this.myOrder = new Order(this.customerNameTxt.Text, this.customerPhoneNumberTxt.Text);
                Console.WriteLine("TAKEAWAY:");
                Console.WriteLine(this.myOrder.ToString());

                // move to orderPanel
                this.orderPanel.Visible = true;
            }


        }

        private void pnl2BackBtn_Click(object sender, EventArgs e)
        {
            // make orderPanel invisible
            this.orderPanel.Visible = false;
        }

        private void mealDealPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2MealDealsBtn_Click(object sender, EventArgs e)
        {
            // make mealDealPanel vis
            //orderPanel.Visible = false;
            this.mealDealPanel.Visible = true;
        }

        private void mealDealNxtBtn_Click(object sender, EventArgs e)
        {
            this.mealDealPanel2.Visible = true;
        }

        private void mealDealSecondBackBtn_Click(object sender, EventArgs e)
        {
            this.mealDealPanel2.Visible = false;
        }

        private void mealDealBackBtn_Click(object sender, EventArgs e)
        {
            this.mealDealPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.halfhalfPanel.Visible = false;
        }

        private void pnl2HalfBtn_Click(object sender, EventArgs e)
        {
            this.halfhalfPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.startersPanel.Visible = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.starters4Panel.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.starters3Panel.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.starters4Panel.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.starters3Panel.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.starters2Panel.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.starters2Panel.Visible = true;
        }

        private void pnl2StartersBtn_Click(object sender, EventArgs e)
        {
            this.startersPanel.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.startersPanel.Visible = false;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.starters2Panel.Visible = true;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            this.starters2Panel.Visible = false;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            this.starters3Panel.Visible = true;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            this.starters3Panel.Visible = false;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            this.starters4Panel.Visible = true;
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            this.starters4Panel.Visible = false;
        }

        private void label145_Click(object sender, EventArgs e)
        {

        }

        private void button104_Click(object sender, EventArgs e)
        {
            this.mainsPanel.Visible = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            this.mains2Panel.Visible = false;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            this.mains2Panel.Visible = true;
        }

        private void pnl2MainsBtn_Click(object sender, EventArgs e)
        {
            this.mainsPanel.Visible = true;
        }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.halfhalfPanel.Visible = false;
        }

        private void traditionalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button353_Click(object sender, EventArgs e)
        {
            this.traditional4Panel.Visible = false;
        }

        private void button282_Click(object sender, EventArgs e)
        {
            this.traditional4Panel.Visible = true;
        }

        private void button281_Click(object sender, EventArgs e)
        {
            this.traditional3Panel.Visible = false;
        }

        private void button210_Click(object sender, EventArgs e)
        {
            this.traditional3Panel.Visible = true;
        }

        private void button209_Click(object sender, EventArgs e)
        {
            this.traditional2Panel.Visible = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            this.traditional2Panel.Visible = true;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.traditionalPanel.Visible = false;
        }

        private void pnl2TraditionalBtn_Click(object sender, EventArgs e)
        {
            this.traditionalPanel.Visible = true;
        }

        private void button440_Click(object sender, EventArgs e)
        {
            this.gourmet2Panel.Visible = false;
        }

        private void button369_Click(object sender, EventArgs e)
        {
            this.gourmet2Panel.Visible = true;
        }

        private void button368_Click(object sender, EventArgs e)
        {
            this.gourmetPanel.Visible = false;
        }

        private void pnl2GourmetBtn_Click(object sender, EventArgs e)
        {
            this.gourmetPanel.Visible = true;
        }

        private void button369_Click_1(object sender, EventArgs e)
        {
            this.gourmet2Panel.Visible = true;
        }

        private void button368_Click_1(object sender, EventArgs e)
        {
            this.gourmetPanel.Visible = false;
        }

        private void button440_Click_1(object sender, EventArgs e)
        {
            this.gourmet2Panel.Visible = false;
        }

        private void button370_Click(object sender, EventArgs e)
        {
            this.seafoodPanel.Visible = false;
        }

        private void pnl2SeafoodBtn_Click(object sender, EventArgs e)
        {
            this.seafoodPanel.Visible = true;
        }

        private void abPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button394_Click(object sender, EventArgs e)
        {
            this.ab2Panel.Visible = false;
        }

        private void button385_Click(object sender, EventArgs e)
        {
            this.ab2Panel.Visible = true;
        }

        private void button384_Click(object sender, EventArgs e)
        {
            this.abPanel.Visible = false;

        }

        private void pnl2TheABBtn_Click(object sender, EventArgs e)
        {
            this.abPanel.Visible = true;
        }

        private void button395_Click(object sender, EventArgs e)
        {
            this.pastaPanel.Visible = false;

        }

        private void pnl2PastaBtn_Click(object sender, EventArgs e)
        {
            this.pastaPanel.Visible = true;
        }

        private void button396_Click(object sender, EventArgs e)
        {
            this.pastaBakePanel.Visible = false;

        }

        private void pnl2PastaBakeBtn_Click(object sender, EventArgs e)
        {
            this.pastaBakePanel.Visible = true;
        }

        private void button408_Click(object sender, EventArgs e)
        {
            this.ribsnwingsPanel.Visible = false;

        }

        private void pnl2RibsWingsBtn_Click(object sender, EventArgs e)
        {
            this.ribsnwingsPanel.Visible = true;
        }

        private void button407_Click(object sender, EventArgs e)
        {
            this.risottoPanel.Visible = false;

        }

        private void pnl2RisottoBtn_Click(object sender, EventArgs e)
        {
            this.risottoPanel.Visible = true;
        }

        private void button446_Click(object sender, EventArgs e)
        {
            this.kebabWrapPanel.Visible = false;

        }

        private void pnl2KebabWrapBtn_Click(object sender, EventArgs e)
        {
            this.kebabWrapPanel.Visible = true;
        }

        private void button461_Click(object sender, EventArgs e)
        {
            this.saladsPanel.Visible = false;

        }

        private void pnl2SaladsBtn_Click(object sender, EventArgs e)
        {
            this.saladsPanel.Visible = true;
        }

        private void button462_Click(object sender, EventArgs e)
        {
            this.desert2Panel.Visible = false;

        }

        private void button462_Click_1(object sender, EventArgs e)
        {
            this.desert2Panel.Visible = false;
        }

        private void button478_Click(object sender, EventArgs e)
        {
            this.desert2Panel.Visible = true;
        }

        private void button477_Click(object sender, EventArgs e)
        {
            this.desertsPanel.Visible = false;
        }

        private void pnl2DesertsBtn_Click(object sender, EventArgs e)
        {
            this.desertsPanel.Visible = true;
        }

        private void button474_Click(object sender, EventArgs e)
        {
            this.beveragesPanel.Visible = false;
        }

        private void pnl2BeveragesBtn_Click(object sender, EventArgs e)
        {
            this.beveragesPanel.Visible = true;
        }

        private void pastaDealBtn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 1, ItemName = "Pasta Deal", ItemPrice = 19.90f });
        }

        private void mealDealPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2NextBtn_Click(object sender, EventArgs e)
        {
            this.commentPanel.Visible = true;
            this.commentPanel.BringToFront();
        }

        private void footyDealBtn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 2, ItemName = "Footy Deal", ItemPrice = 36.90f });
        }

        private void deal1Btn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 3, ItemName = "Deal 1", ItemPrice = 19.90f });
        }

        private void deal2Btn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 4, ItemName = "Deal 2", ItemPrice = 25.90f });
        }

        private void deal3Btn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 5, ItemName = "Deal 3", ItemPrice = 29.90f });
        }

        private void deal4Btn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 6, ItemName = "Deal 4", ItemPrice = 31.90f });
        }

        private void deal5Btn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 7, ItemName = "Deal 5", ItemPrice = 44.90f });
        }

        private void deal6Btn_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 8, ItemName = "Deal 6", ItemPrice = 55.90f });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 9, ItemName = "Deal 7", ItemPrice = 23.50f });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 10, ItemName = "Deal 8", ItemPrice = 36.50f });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 11, ItemName = "Deal 9", ItemPrice = 43.50f });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 12, ItemName = "Deal 10", ItemPrice = 6.00f });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 13, ItemName = "Deal 11", ItemPrice = 8.00f });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 14, ItemName = "Family Feast", ItemPrice = 43.00f });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 15, ItemName = "Half n Half - Large", ItemPrice = 1.0f });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 16, ItemName = "Half n Half -  Family", ItemPrice = 1.0f });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 17, ItemName = "Half n Half -  Party", ItemPrice = 1.0f });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 18, ItemName = "Half n Half -  Jumbo", ItemPrice = 1.0f });

        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 19, ItemName = "Herb Bread", ItemPrice = 4.5f });
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 20, ItemName = "Potato Bites", ItemPrice = 4.5f });

        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 21, ItemName = "Garlic Bread", ItemPrice = 3.9f });

        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 22, ItemName = "Cheesy Garlic Bread", ItemPrice = 5.5f });

        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 23, ItemName = "Salt and Pepper Fish Bites", ItemPrice = 5f });

        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 24, ItemName = "Diamond Cut Chips", ItemPrice = 6.5f });

        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 25, ItemName = "Chips and Gravy", ItemPrice = 8.5f });

        }

        private void button53_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 26, ItemName = "Chicken nuggets 6", ItemPrice = 6.0f });

        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 27, ItemName = "Chicken nuggets 12", ItemPrice = 10f });

        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 28, ItemName = "Cheesy GB with Ham and Pineapple", ItemPrice = 6.5f });

        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 29, ItemName = "Cheesy GB with Mushroom", ItemPrice = 6.5f });

        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 30, ItemName = "Curly Fries", ItemPrice = 7.5f });

        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 31, ItemName = "Onion Rings (Medium)", ItemPrice = 4.5f });

        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 32, ItemName = "Onion Rings (Large)", ItemPrice = 7.5f });

        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 33, ItemName = "Potato Wedges", ItemPrice = 8f });

        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 34, ItemName = "Calamari Rings", ItemPrice = 8f });

        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 35, ItemName = "Crispy Fried Chicken", ItemPrice = 6f });

        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 36, ItemName = "Spicy Crispy Fried Chicken", ItemPrice = 6f });
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 37, ItemName = "Garlic Cheese Pizza (Small)", ItemPrice = 8f });

        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 38, ItemName = "Garlic Cheese Pizza (Large)", ItemPrice = 10f });

        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 39, ItemName = "Feta Cheese Triangles", ItemPrice = 3.90f });

        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 40, ItemName = "Ham and Cheese Gems", ItemPrice = 4.9f });

        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 41, ItemName = "Mozzarella Sticks", ItemPrice = 5.9f });

        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 42, ItemName = "Homemade GB", ItemPrice = 4.5f });

        }

        private void button51_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 43, ItemName = "Cheesy GB w/ Jalapeno", ItemPrice = 6.5f });

        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 44, ItemName = "Cheesy GB w/ Salami", ItemPrice = 6.5f });

        }

        private void button49_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 45, ItemName = "Oven Baked Chips", ItemPrice = 6.5f });

        }

        private void button113_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 46, ItemName = "Chicken Schnitzel", ItemPrice = 15f });

        }

        private void button112_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 47, ItemName = "Veal Schnitzel", ItemPrice = 15f });

        }

        private void button111_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 48, ItemName = "Pollo Parmigiana", ItemPrice = 18f });

        }

        private void button110_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 49, ItemName = "Veal Parmigiana", ItemPrice = 18f });

        }

        private void button109_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 50, ItemName = "Mexican Pollo Parmigiana", ItemPrice = 19f });

        }

        private void button108_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 51, ItemName = "Sicilian Pollo Parmigiana", ItemPrice = 19f });

        }

        private void button107_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 52, ItemName = "Hawaiian Veal Parmigiana", ItemPrice = 19f });

        }

        private void button106_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 53, ItemName = "Mexican Veal Parmigiana", ItemPrice = 19f });

        }

        private void button89_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 54, ItemName = "Sicilian Veal Parmigiana", ItemPrice = 19f });

        }

        private void button379_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 55, ItemName = "Fried Fish Pack", ItemPrice = 14.9f });

        }

        private void button378_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 56, ItemName = "Fried Prawns Pack", ItemPrice = 15.9f });

        }

        private void button377_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 57, ItemName = "Fried Calamari Pack", ItemPrice = 14.9f });

        }

        private void button376_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 58, ItemName = "Salt and Pepper Squid", ItemPrice = 16.9f });

        }

        private void button375_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 59, ItemName = "Fritto Misto Del Mare", ItemPrice = 17.9f });

        }

        private void button393_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 60, ItemName = "AB Chicken", ItemPrice = 15.5f });

        }

        private void button392_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 61, ItemName = "Cheesy AB Chicken", ItemPrice = 16.5f });

        }

        private void button391_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 62, ItemName = "Peri Peri Chicken AB", ItemPrice = 16.5f });

        }

        private void button390_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 63, ItemName = "Sicilian Chicken AB", ItemPrice = 16.5f });

        }

        private void button389_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 64, ItemName = "AB Lamb", ItemPrice = 15.5f });

        }

        private void button388_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 65, ItemName = "Cheesy AB Lamb", ItemPrice = 15.5f });

        }

        private void button387_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 66, ItemName = "Mediterranean AB", ItemPrice = 16.5f });

        }

        private void button386_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 67, ItemName = "AB Combination", ItemPrice = 17.0f });

        }

        private void button403_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 68, ItemName = "Cheesy AB Combination", ItemPrice = 18f });

        }

        private void button405_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 69, ItemName = "Napoletana", ItemPrice = 13.9f });

        }

        private void button404_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 70, ItemName = "Alla Pana", ItemPrice = 13.9f });

        }

        private void button402_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 71, ItemName = "Al Pollo", ItemPrice = 13.9f });

        }

        private void button401_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 72, ItemName = "Carbonara", ItemPrice = 13.9f });

        }

        private void button400_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 73, ItemName = "Bolognese", ItemPrice = 13.9f });

        }

        private void button399_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 74, ItemName = "Creamy Lamb and Tomato", ItemPrice = 13.9f });

        }

        private void button398_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 75, ItemName = "Marinara", ItemPrice = 14.9f });

        }

        private void button397_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 76, ItemName = "Seafood Pasta", ItemPrice = 13.9f });

        }

        private void button442_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 77, ItemName = "Eggplant Pasta Bake", ItemPrice = 16.5f });

        }

        private void button441_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 78, ItemName = "Chicken and Cheese Pasta Bake", ItemPrice = 16.5f });
        }

        private void button411_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 79, ItemName = "Salami Pasta Bake", ItemPrice = 16.5f });

        }

        private void button410_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 80, ItemName = "Lamb and Feta Pasta Bake", ItemPrice = 15.5f });

        }

        private void button406_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 81, ItemName = "Lasagne", ItemPrice = 15.5f });

        }

        private void button445_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 82, ItemName = "Chicken Wings (6 pack)", ItemPrice = 7.9f });

        }

        private void button444_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 83, ItemName = "BBQ Chicken Wings", ItemPrice = 7.9f });

        }

        private void button443_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 84, ItemName = "Ribs", ItemPrice = 17.9f });

        }

        private void button409_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 85, ItemName = "BBQ Ribs and Wings Combo", ItemPrice = 16.9f });

        }

        private void button453_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 86, ItemName = "Seafood Risotto", ItemPrice = 15.5f });

        }

        private void button452_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 87, ItemName = "Mushroom and Spinach Risotto", ItemPrice = 14.5f });

        }

        private void button451_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 88, ItemName = "Mushroom and Bacon Risotto", ItemPrice = 14.5f });

        }

        private void button450_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 89, ItemName = "Chicken Risotto", ItemPrice = 14.5f });

        }

        private void button454_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 90, ItemName = "Chicken Kebab", ItemPrice = 10.5f });

        }

        private void button449_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 91, ItemName = "Lamb Kebab", ItemPrice = 10.5f });

        }

        private void button448_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 92, ItemName = "Combination Kebab", ItemPrice = 11.5f });

        }

        private void button470_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 93, ItemName = "Prawn Salad", ItemPrice = 13.5f });

        }

        private void button469_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 94, ItemName = "Grilled Vegetarian Salad", ItemPrice = 9.9f });

        }

        private void button468_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 95, ItemName = "Garden Salad", ItemPrice = 8.5f });

        }

        private void button467_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 96, ItemName = "Side Salad", ItemPrice = 4.5f });

        }

        private void button466_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 97, ItemName = "Mediterranean Salad", ItemPrice = 13.5f });

        }

        private void button465_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 98, ItemName = "Caesar Salad", ItemPrice = 13.5f });

        }

        private void button464_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 99, ItemName = "Chicken Salad", ItemPrice = 13.5f });

        }

        private void button463_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 100, ItemName = "Chicken Potato Salad", ItemPrice = 13.5f });

        }

        private void button486_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 101, ItemName = "Apple Pie", ItemPrice = 3.9f });

        }

        private void button485_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 102, ItemName = "Chocolate Pudding", ItemPrice = 4.9f });

        }

        private void button484_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 103, ItemName = "Cheesecake", ItemPrice = 4.9f });

        }

        private void button483_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 104, ItemName = "Chocolate Mousse", ItemPrice = 4.9f });


        }

        private void button482_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 105, ItemName = "Death by Chocolate", ItemPrice = 7.9f });

        }

        private void button481_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 106, ItemName = "Mars Bar Cheesecake", ItemPrice = 7.9f });

        }

        private void button480_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 107, ItemName = "Gelato (300 ml)", ItemPrice = 4.9f });

        }

        private void button479_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 108, ItemName = "Gelato (500 ml)", ItemPrice = 7.9f });

        }

        private void button489_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 109, ItemName = "Apple and Blackberry Pie", ItemPrice = 3.9f });

        }

        private void button488_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 110, ItemName = "Chocolate Brownie", ItemPrice = 4.9f });

        }

        private void button495_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 111, ItemName = "Soft Drink (Can)", ItemPrice = 3f });

        }

        private void button494_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 112, ItemName = "Water 500ml", ItemPrice = 3.5f });

        }

        private void button493_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 113, ItemName = "Soft Drink (1.25L)", ItemPrice = 4.5f });

        }

        private void button492_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Item() { ItemID = 114, ItemName = "Mother Energy Drink (500ml)", ItemPrice = 4f });

        }

        private void button371_Click(object sender, EventArgs e)
        {
            this.summaryPanel.Visible = false;
            this.orderPanel.Visible = true;
        }

        private void button372_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPRint = new PrintDocument();
            printDialog.Document = documentToPRint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(this.orderSummary.Text);
                documentToPRint.PrintPage += new PrintPageEventHandler(this.DocumentToPrint_PrintPage);
                documentToPRint.Print();

            }
        }

        private void DocumentToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(this.orderSummary.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string line = null;
            Font PrintFont = this.orderSummary.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count <= LinesPerPage && ((line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, PrintFont, PrintBrush, 0,
                    YPosition, new StringFormat());
                Count++;
            }

            if (line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Simply Cheese", 10f, this.simplyCheese, this));
        }

        private void button65_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Simply Cheese", 14f, this.simplyCheese, this));
        }

        private void button66_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Simply Cheese", 20f, this.simplyCheese, this));
        }

        private void button67_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Simply Cheese", 25f, this.simplyCheese, this));
        }

        private void button68_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Simply Cheese", 44f, this.simplyCheese, this));
        }

        private void button69_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Simply Cheese", 16f, this.simplyCheese, this));
        }

        private void button70_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Simply Cheese", 16f, this.simplyCheese, this));
        }

        private void button63_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Ham and Cheese", 10f, this.hamCheese, this));
        }

        private void button62_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Ham and Cheese", 14f, this.simplyCheese, this));
        }

        private void button61_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Ham and Cheese", 20f, this.simplyCheese, this));
        }

        private void button60_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Ham and Cheese", 25f, this.simplyCheese, this));
        }

        private void button59_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Ham and Cheese", 44f, this.simplyCheese, this));
        }

        private void button58_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Ham and Cheese", 16f, this.simplyCheese, this));
        }

        private void button57_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Ham and Cheese", 16f, this.simplyCheese, this));
        }

        private void button77_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Aussie", 10f, this.aussie, this));
        }

        private void button76_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Aussie", 14f, this.aussie, this));
        }

        private void button75_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Aussie", 20f, this.aussie, this));
        }

        private void button74_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Aussie", 25f, this.aussie, this));
        }

        private void button73_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Aussie", 44f, this.aussie, this));
        }

        private void button72_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Aussie", 16f, this.aussie, this));
        }

        private void button71_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Aussie", 16f, this.aussie, this));
        }

        private void button85_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Ham and Pineapple", 10f, this.hamPineapple, this));

        }

        private void button84_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Ham and Pineapple", 14f, this.hamPineapple, this));
        }

        private void button83_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Ham and Pineapple", 20f, this.hamPineapple, this));
        }

        private void button82_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Ham and Pineapple", 25f, this.hamPineapple, this));
        }

        private void button81_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Ham and Pineapple", 44f, this.hamPineapple, this));
        }

        private void button79_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Ham and Pineapple", 16f, this.hamPineapple, this));
        }

        private void button78_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Ham and Pineapple", 16f, this.hamPineapple, this));
        }

        private void button93_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) American", 10f, this.american, this));
        }

        private void button92_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) American", 14f, this.american, this));
        }

        private void button91_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) American", 20f, this.american, this));
        }

        private void button90_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) American", 25f, this.american, this));
        }

        private void button88_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) American", 44f, this.american, this));
        }

        private void button87_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) American", 16f, this.american, this));
        }

        private void button86_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) American", 16f, this.american, this));
        }

        private void button100_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Margherita", 10f, this.margherita, this));
        }

        private void button99_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Margherita", 14f, this.margherita, this));
        }

        private void button98_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Margherita", 20f, this.margherita, this));
        }

        private void button97_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Margherita", 25f, this.margherita, this));
        }

        private void button96_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Margherita", 44f, this.margherita, this));
        }

        private void button95_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Margherita", 16f, this.margherita, this));
        }

        private void button94_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Margherita", 16f, this.margherita, this));
        }

        private void button117_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Vegetarian", 10f, this.vegetarian, this));
        }

        private void button116_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Vegetarian", 14f, this.vegetarian, this));
        }

        private void button115_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Vegetarian", 20f, this.vegetarian, this));
        }

        private void button114_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Vegetarian", 25f, this.vegetarian, this));
        }

        private void button103_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Vegetarian", 44f, this.vegetarian, this));
        }

        private void button102_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Vegetarian", 16f, this.vegetarian, this));
        }

        private void button101_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Vegetarian", 16f, this.vegetarian, this));
        }

        private void button124_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Seafood", 10f, this.seafood, this));
        }

        private void button123_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Seafood", 14f, this.seafood, this));
        }

        private void button122_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Seafood", 20f, this.seafood, this));
        }

        private void button121_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Seafood", 25f, this.seafood, this));
        }

        private void button120_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Seafood", 44f, this.seafood, this));
        }

        private void button119_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Seafood", 16f, this.seafood, this));
        }

        private void button118_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Seafood", 16f, this.seafood, this));
        }

        private void button131_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Dernancourt", 10f, this.dernancourt, this));
        }

        private void button130_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Dernancourt", 14f, this.dernancourt, this));
        }

        private void button129_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Dernancourt", 20f, this.dernancourt, this));
        }

        private void button128_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Dernancourt", 25f, this.dernancourt, this));
        }

        private void button127_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Dernancourt", 44f, this.dernancourt, this));
        }

        private void button126_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Dernancourt", 16f, this.dernancourt, this));
        }

        private void button125_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Dernancourt", 16f, this.dernancourt, this));
        }

        private void button138_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Special", 10f, this.special, this));
        }

        private void button137_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Special", 14f, this.special, this));
        }

        private void button136_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Special", 20f, this.special, this));
        }

        private void button135_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Special", 25f, this.special, this));
        }

        private void button134_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Special", 44f, this.special, this));
        }

        private void button133_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Special", 16f, this.special, this));
        }

        private void button132_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Special", 16f, this.special, this));
        }

        private void button208_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Mushroom", 10f, this.mushroom, this));
        }

        private void button207_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Mushroom", 14f, this.mushroom, this));
        }

        private void button206_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Mushroom", 20f, this.mushroom, this));
        }

        private void button205_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Mushroom", 25f, this.mushroom, this));
        }

        private void button204_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Mushroom", 44f, this.mushroom, this));
        }

        private void button203_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Mushroom", 16f, this.mushroom, this));
        }

        private void button202_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Mushroom", 16f, this.mushroom, this));
        }

        private void button201_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Capricciosa", 10f, this.capricciosa, this));
        }

        private void button200_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Capricciosa", 14f, this.capricciosa, this));
        }

        private void button199_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Capricciosa", 20f, this.capricciosa, this));
        }

        private void button198_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Capricciosa", 25f, this.capricciosa, this));
        }

        private void button197_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Capricciosa", 44f, this.capricciosa, this));
        }

        private void button196_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Capricciosa", 16f, this.capricciosa, this));
        }

        private void button195_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Capricciosa", 16f, this.capricciosa, this));
        }

        private void button194_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Chicken Deluxe", 10f, this.chickenDeluxe, this));
        }

        private void button193_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Chicken Deluxe", 14f, this.chickenDeluxe, this));
        }

        private void button192_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Chicken Deluxe", 20f, this.chickenDeluxe, this));
        }

        private void button191_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Chicken Deluxe", 25f, this.chickenDeluxe, this));
        }

        private void button190_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Chicken Deluxe", 44f, this.chickenDeluxe, this));
        }

        private void button189_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Chicken Deluxe", 16f, this.chickenDeluxe, this));
        }

        private void button188_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Chicken Deluxe", 16f, this.chickenDeluxe, this));
        }

        private void button187_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Pepperoni", 10f, this.pepperoni, this));
        }

        private void button186_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Pepperoni", 14f, this.pepperoni, this));
        }

        private void button185_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Pepperoni", 20f, this.pepperoni, this));
        }

        private void button184_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Pepperoni", 25f, this.pepperoni, this));
        }

        private void button183_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Pepperoni", 44f, this.pepperoni, this));
        }

        private void button182_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Pepperoni", 16f, this.pepperoni, this));
        }

        private void button181_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Pepperoni", 16f, this.pepperoni, this));
        }

        private void button180_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Calabrese", 10f, this.calabrese, this));
        }

        private void button179_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Calabrese", 14f, this.calabrese, this));
        }

        private void button178_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Calabrese", 20f, this.calabrese, this));
        }

        private void button177_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Calabrese", 25f, this.calabrese, this));
        }

        private void button176_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Calabrese", 44f, this.calabrese, this));
        }

        private void button175_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Calabrese", 16f, this.calabrese, this));
        }

        private void button174_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Calabrese", 16f, this.calabrese, this));
        }

        private void button173_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) BBQ Chicken", 10f, this.bbqChicken, this));
        }

        private void button172_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) BBQ Chicken", 14f, this.bbqChicken, this));
        }

        private void button171_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) BBQ Chicken", 20f, this.bbqChicken, this));
        }

        private void button170_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) BBQ Chicken", 25f, this.bbqChicken, this));
        }

        private void button169_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) BBQ Chicken", 44f, this.bbqChicken, this));
        }

        private void button168_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) BBQ Chicken", 16f, this.bbqChicken, this));
        }

        private void button167_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) BBQ Chicken", 16f, this.bbqChicken, this));
        }

        private void button166_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Meatlovers", 10f, this.meatlovers, this));
        }

        private void button165_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Meatlovers", 14f, this.meatlovers, this));
        }

        private void button164_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Meatlovers", 20f, this.meatlovers, this));
        }

        private void button163_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Meatlovers", 25f, this.meatlovers, this));
        }

        private void button162_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Meatlovers", 44f, this.meatlovers, this));
        }

        private void button161_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Meatlovers", 16f, this.meatlovers, this));
        }

        private void button160_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Meatlovers", 16f, this.meatlovers, this));
        }

        private void button159_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) House Special", 10f, this.houseSpecial, this));
        }

        private void button158_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) House Special", 14f, this.houseSpecial, this));
        }

        private void button157_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) House Special", 20f, this.houseSpecial, this));
        }

        private void button156_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) House Special", 25f, this.houseSpecial, this));
        }

        private void button155_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) House Special", 44f, this.houseSpecial, this));
        }

        private void button154_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) House Special", 16f, this.houseSpecial, this));
        }

        private void button153_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) House Special", 16f, this.houseSpecial, this));
        }

        private void button152_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Mexican", 10f, this.mexican, this));
        }

        private void button151_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Mexican", 14f, this.mexican, this));
        }

        private void button150_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Mexican", 20f, this.mexican, this));
        }

        private void button149_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Mexican", 25f, this.mexican, this));
        }

        private void button148_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Mexican", 44f, this.mexican, this));
        }

        private void button147_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Mexican", 16f, this.mexican, this));
        }

        private void button146_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Mexican", 16f, this.mexican, this));
        }

        private void button145_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Yiros", 10f, this.yiros, this));
        }

        private void button144_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Yiros", 14f, this.yiros, this));
        }

        private void button143_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Yiros", 20f, this.yiros, this));
        }

        private void button142_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Yiros", 25f, this.yiros, this));
        }

        private void button141_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Yiros", 44f, this.yiros, this));
        }

        private void button140_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Yiros", 16f, this.yiros, this));
        }

        private void button139_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Yiros", 16f, this.yiros, this));
        }

        private void button280_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Chicken Hawaiian", 10f, this.chickenHawaiian, this));
        }

        private void button279_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Chicken Hawaiian", 14f, this.chickenHawaiian, this));
        }

        private void button278_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Chicken Hawaiian", 20f, this.chickenHawaiian, this));
        }

        private void button277_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Chicken Hawaiian", 25f, this.chickenHawaiian, this));
        }

        private void button276_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Chicken Hawaiian", 44f, this.chickenHawaiian, this));
        }

        private void button275_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Chicken Hawaiian", 16f, this.chickenHawaiian, this));
        }

        private void button274_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Chicken Hawaiian", 16f, this.chickenHawaiian, this));
        }

        private void button273_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Bacon Deluxe", 10f, this.baconDeluxe, this));
        }

        private void button272_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Bacon Deluxe", 14f, this.baconDeluxe, this));
        }

        private void button271_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Bacon Deluxe", 20f, this.baconDeluxe, this));
        }

        private void button270_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Bacon Deluxe", 25f, this.baconDeluxe, this));
        }

        private void button269_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Bacon Deluxe", 44f, this.baconDeluxe, this));
        }

        private void button268_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Bacon Deluxe", 16f, this.baconDeluxe, this));
        }

        private void button267_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Bacon Deluxe", 16f, this.baconDeluxe, this));
        }

        private void button266_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Outback", 10f, this.outback, this));
        }

        private void button265_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Outback", 14f, this.outback, this));
        }

        private void button264_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Outback", 20f, this.outback, this));
        }

        private void button263_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Outback", 25f, this.outback, this));
        }

        private void button262_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Outback", 44f, this.outback, this));
        }

        private void button261_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Outback", 16f, this.outback, this));
        }

        private void button260_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Outback", 16f, this.outback, this));
        }

        private void button259_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Supreme", 10f, this.supreme, this));
        }

        private void button258_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Supreme", 14f, this.supreme, this));
        }

        private void button257_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Supreme", 20f, this.supreme, this));
        }

        private void button256_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Supreme", 25f, this.supreme, this));
        }

        private void button255_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Supreme", 44f, this.supreme, this));
        }

        private void button254_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Supreme", 16f, this.supreme, this));
        }

        private void button253_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Supreme", 16f, this.supreme, this));
        }

        private void button252_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) The Lot", 10f, this.theLot, this));
        }

        private void button251_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) The Lot", 14f, this.theLot, this));
        }

        private void button250_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) The Lot", 20f, this.theLot, this));
        }

        private void button249_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) The Lot", 25f, this.theLot, this));
        }

        private void button248_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) The Lot", 44f, this.theLot, this));
        }

        private void button247_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) The Lot", 16f, this.theLot, this));
        }

        private void button246_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) The Lot", 16f, this.theLot, this));
        }

        private void button245_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Four Cheese", 10f, this.fourCheese, this));
        }

        private void button244_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Four Cheese", 14f, this.fourCheese, this));
        }

        private void button243_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Four Cheese", 20f, this.fourCheese, this));
        }

        private void button242_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Four Cheese", 25f, this.fourCheese, this));
        }

        private void button241_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Four Cheese", 44f, this.fourCheese, this));
        }

        private void button240_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Four Cheese", 16f, this.fourCheese, this));
        }

        private void button239_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Four Cheese", 16f, this.fourCheese, this));
        }

        private void button238_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Tandoori Chicken", 10f, this.tandooriChicken, this));
        }

        private void button237_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Tandoori Chicken", 14f, this.tandooriChicken, this));
        }

        private void button236_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Tandoori Chicken", 20f, this.tandooriChicken, this));
        }

        private void button235_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Tandoori Chicken", 25f, this.tandooriChicken, this));
        }

        private void button234_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Tandoori Chicken", 44f, this.tandooriChicken, this));
        }

        private void button233_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Tandoori Chicken", 16f, this.tandooriChicken, this));
        }

        private void button232_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Tandoori Chicken", 16f, this.tandooriChicken, this));
        }

        private void button231_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Mango Chicken", 10f, this.mangoChicken, this));
        }

        private void button230_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Mango Chicken", 14f, this.mangoChicken, this));
        }

        private void button229_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Mango Chicken", 20f, this.mangoChicken, this));
        }

        private void button228_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Mango Chicken", 25f, this.mangoChicken, this));
        }

        private void button227_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Mango Chicken", 44f, this.mangoChicken, this));
        }

        private void button226_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Mango Chicken", 16f, this.mangoChicken, this));

        }

        private void button225_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Mango Chicken", 16f, this.mangoChicken, this));

        }

        private void button224_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Chicken Supreme", 10f, this.chickenSupreme, this));
        }

        private void button223_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Chicken Supreme", 14f, this.chickenSupreme, this));
        }

        private void button222_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Chicken Supreme", 20f, this.chickenSupreme, this));
        }

        private void button221_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Chicken Supreme", 25f, this.chickenSupreme, this));
        }

        private void button220_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Chicken Supreme", 44f, this.chickenSupreme, this));
        }

        private void button219_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Chicken Supreme", 16f, this.chickenSupreme, this));
        }

        private void button218_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Chicken Supreme", 16f, this.chickenSupreme, this));
        }

        private void button217_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Hot and Spicy", 10f, this.hotSpicy, this));
        }

        private void button216_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Hot and Spicy", 14f, this.hotSpicy, this));
        }

        private void button215_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Hot and Spicy", 20f, this.hotSpicy, this));
        }

        private void button214_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Hot and Spicy", 25f, this.hotSpicy, this));
        }

        private void button213_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Hot and Spicy", 44f, this.hotSpicy, this));
        }

        private void button212_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Hot and Spicy", 16f, this.hotSpicy, this));
        }

        private void button211_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Hot and Spicy", 16f, this.hotSpicy, this));
        }

        private void button352_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Marinara", 10f, this.marinara, this));
        }

        private void button351_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Marinara", 14f, this.marinara, this));
        }

        private void button350_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Marinara", 20f, this.marinara, this));
        }

        private void button349_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Marinara", 25f, this.marinara, this));
        }

        private void button348_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Marinara", 44f, this.marinara, this));
        }

        private void button347_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Marinara", 16f, this.marinara, this));
        }

        private void button346_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Marinara", 16f, this.marinara, this));
        }

        private void button345_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Peri Peri Chicken", 10f, this.periChicken, this));
        }

        private void button344_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Peri Peri Chicken", 14f, this.periChicken, this));
        }

        private void button343_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Peri Peri Chicken", 20f, this.periChicken, this));
        }

        private void button342_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Peri Peri Chicken", 25f, this.periChicken, this));
        }

        private void button341_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Peri Peri Chicken", 44f, this.periChicken, this));
        }

        private void button340_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Peri Peri Chicken", 16f, this.periChicken, this));
        }

        private void button339_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Peri Peri Chicken", 16f, this.periChicken, this));
        }

        private void pastaDealLbl_Click(object sender, EventArgs e)
        {

        }

        private void button373_Click(object sender, EventArgs e)
        {
            //summaryPanel.Visible = false;
            //orderPanel.Visible = false;
            this.editItemsBox.Items.Clear();
            this.editItemsPanel.Visible = true;
            // panel

            // populate the listbox with the order summary (items only)
            foreach (Item item in this.myOrder.Items)
            {
                this.editItemsBox.Items.Add(item);
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int index = this.editItemsBox.SelectedIndex;
            if (this.editItemsBox.SelectedIndex >= 0)
            {
                this.editItemsBox.Items.RemoveAt(this.editItemsBox.SelectedIndex);
                // delete from myOrder
                this.myOrder.RemoveItemAtIndex(index);
                this.updateItems();
            }
            else
            {
                MessageBox.Show("Please select an item before deleting");
            }
        }

        private void button374_Click(object sender, EventArgs e)
        {
            this.editItemsPanel.Visible = false;
        }

        private void updateItems()
        {
            this.orderSummary.Text = "";
            this.summaryPanel.Visible = true;
            // add order deets
            this.orderSummary.Text += this.myOrder.ToString();
            // add all the items from myOrder to the orderSummary
            foreach (Item item in this.myOrder.Items)
            {
                this.orderSummary.Text += item.ToString() + Environment.NewLine;
            }
            // add a space before total price
            this.orderSummary.Text += Environment.NewLine;
            if (this.myOrder.Price % 1 != 0)
            {
                this.orderSummary.Text += "Total price: $" + this.myOrder.GetTotalPrice() + "0";
            }
            else
            {
                this.orderSummary.Text += "Total price: $" + this.myOrder.GetTotalPrice();
            }
        }

        private void button367_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Vegetarian", 13f, this.gVegetarian, this));
        }

        private void button366_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Vegetarian", 17f, this.gVegetarian, this));
        }

        private void button365_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Vegetarian", 23f, this.gVegetarian, this));
        }

        private void button364_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Vegetarian", 27f, this.gVegetarian, this));
        }

        private void button363_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Vegetarian", 52f, this.gVegetarian, this));
        }

        private void button362_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Vegetarian", 18f, this.gVegetarian, this));
        }

        private void button361_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Vegetarian", 18f, this.gVegetarian, this));
        }

        private void button360_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Mediterranean", 13f, this.gMediterranean, this));
        }

        private void button359_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Mediterranean", 17f, this.gMediterranean, this));
        }

        private void button358_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Mediterranean", 23f, this.gMediterranean, this));
        }

        private void button357_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Mediterranean", 27f, this.gMediterranean, this));
        }

        private void button356_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Mediterranean", 52f, this.gMediterranean, this));
        }

        private void button355_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Mediterranean", 18f, this.gMediterranean, this));
        }

        private void button354_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Mediterranean", 18f, this.gMediterranean, this));
        }

        private void button338_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Lamb", 13f, this.gLamb, this));
        }

        private void button337_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Lamb", 17f, this.gLamb, this));
        }

        private void button336_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Lamb", 23f, this.gLamb, this));
        }

        private void button335_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Lamb", 27f, this.gLamb, this));
        }

        private void button334_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Lamb", 52f, this.gLamb, this));
        }

        private void button333_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Lamb", 18f, this.gLamb, this));
        }

        private void button332_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Lamb", 18f, this.gLamb, this));
        }

        private void button331_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Chicken", 13f, this.gChicken, this));
        }

        private void button330_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Chicken", 17f, this.gChicken, this));
        }

        private void button329_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Chicken", 23f, this.gChicken, this));
        }

        private void button328_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Chicken", 27f, this.gChicken, this));
        }

        private void button327_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Chicken", 52f, this.gChicken, this));
        }

        private void button326_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Chicken", 18f, this.gChicken, this));
        }

        private void button325_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Chicken", 18f, this.gChicken, this));
        }

        private void button324_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Thai Chicken", 13f, this.gThaiChicken, this));
        }

        private void button323_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Thai Chicken", 17f, this.gThaiChicken, this));
        }

        private void button322_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Thai Chicken", 23f, this.gThaiChicken, this));
        }

        private void button321_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Thai Chicken", 27f, this.gThaiChicken, this));
        }

        private void button320_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Thai Chicken", 52f, this.gThaiChicken, this));
        }

        private void button319_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Thai Chicken", 18f, this.gThaiChicken, this));
        }

        private void button318_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Thai Chicken", 18f, this.gThaiChicken, this));
        }

        private void button317_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Special", 13f, this.gSpecial, this));
        }

        private void button316_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Special", 17f, this.gSpecial, this));
        }

        private void button315_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Special", 23f, this.gSpecial, this));
        }

        private void button314_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Special", 27f, this.gSpecial, this));
        }

        private void button313_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Special", 52f, this.gSpecial, this));
        }

        private void button312_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Special", 18f, this.gSpecial, this));
        }

        private void button311_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Special", 18f, this.gSpecial, this));
        }

        private void button310_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Mexicana", 13f, this.gMexicana, this));
        }

        private void button309_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Mexicana", 17f, this.gMexicana, this));
        }

        private void button308_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Mexicana", 23f, this.gMexicana, this));
        }

        private void button307_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Mexicana", 27f, this.gMexicana, this));
        }

        private void button306_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Mexicana", 52f, this.gMexicana, this));
        }

        private void button305_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Mexicana", 18f, this.gMexicana, this));
        }

        private void button304_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Mexicana", 18f, this.gMexicana, this));
        }

        private void button303_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Gourmet Garlic Prawn", 13f, this.gGarlicPrawn, this));
        }

        private void button302_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Gourmet Garlic Prawn", 17f, this.gGarlicPrawn, this));
        }

        private void button301_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Gourmet Garlic Prawn", 23f, this.gGarlicPrawn, this));
        }

        private void button300_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Gourmet Garlic Prawn", 27f, this.gGarlicPrawn, this));
        }

        private void button299_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Gourmet Garlic Prawn", 52f, this.gGarlicPrawn, this));
        }

        private void button298_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Gourmet Garlic Prawn", 18f, this.gGarlicPrawn, this));
        }

        private void button297_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Gourmet Garlic Prawn", 18f, this.gGarlicPrawn, this));
        }

        private void button296_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) Satay Chicken", 13f, this.satayChicken, this));
        }

        private void button295_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) Satay Chicken", 17f, this.satayChicken, this));
        }

        private void button294_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) Satay Chicken", 23f, this.satayChicken, this));
        }

        private void button293_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) Satay Chicken", 27f, this.satayChicken, this));
        }

        private void button292_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) Satay Chicken", 52f, this.satayChicken, this));
        }

        private void button291_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) Satay Chicken", 18f, this.satayChicken, this));
        }

        private void button290_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) Satay Chicken", 18f, this.satayChicken, this));
        }

        private void button289_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Small) El Paso", 13f, this.elPaso, this));
        }

        private void button288_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large) El Paso", 17f, this.elPaso, this));
        }

        private void button287_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Family) El Paso", 23f, this.elPaso, this));
        }

        private void button286_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Party) El Paso", 27f, this.elPaso, this));
        }

        private void button285_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Jumbo) El Paso", 52f, this.elPaso, this));
        }

        private void button284_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Calzone) El Paso", 18f, this.elPaso, this));
        }

        private void button283_Click(object sender, EventArgs e)
        {
            this.myOrder.AddItem(new Pizza("(Large G Free) El Paso", 18f, this.elPaso, this));
        }

        private void button381_Click(object sender, EventArgs e)
        {
            this.orderSummary.Text = "";
            this.commentPanel.Visible = false;
            this.summaryPanel.Visible = true;
            // add order deets
            this.orderSummary.Text += this.myOrder.ToString();
            // add all the items from myOrder to the orderSummary
            foreach (Item item in this.myOrder.Items.Where(x => !string.IsNullOrWhiteSpace(x.ItemName)))
            {
                var sb = new StringBuilder(this.orderSummary.Text);
                sb.Append(item.ToString());

                if (item.IsModified)
                {
                    for (int i = 0; i < item.removed.Count; i++)
                    {
                        sb.AppendLine("REMOVE -- " + item.removed[i]);
                    }
                    for (int i = 0; i < item.added.Count; i++)
                    {
                        sb.AppendLine("ADD -- " + item.added[i]);
                    }

                }

                this.orderSummary.Text = sb.ToString();
            }
            // add a space before total price
            this.orderSummary.Text += Environment.NewLine;
            if (this.myOrder.Price % 1 != 0)
            {
                if (this.myOrder.IsDelivery)
                {
                    this.orderSummary.Text += "Delivery Charge: $5" + Environment.NewLine;
                }
                this.orderSummary.Text += "Total price: $" + this.myOrder.GetTotalPrice() + "0";
            }
            else
            {
                if (this.myOrder.IsDelivery)
                {
                    this.orderSummary.Text += "Delivery Charge: $5" + Environment.NewLine;
                }
                this.orderSummary.Text += "Total price: $" + this.myOrder.GetTotalPrice();
            }

            this.orderSummary.Text += Environment.NewLine + Environment.NewLine + "Customer Comments: ";

            this.orderSummary.Text += Environment.NewLine + this.txComments.Text;

            this.orderSummary.Text += Environment.NewLine;


        }

        private void button380_Click(object sender, EventArgs e)
        {
            this.commentPanel.Visible = false;
        }

        private void gourmetPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button382_Click(object sender, EventArgs e)
        {
            this.RaisePrice(5.0f);//add $5 delivery charge to order
        }

        private void button383_Click(object sender, EventArgs e)
        {
            this.RaisePrice(7.0f);//add $7 delivery charge to order
        }

        private void button471_Click(object sender, EventArgs e)
        {
            this.RaisePrice(10.0f); //add $10 delivery charge to order
        }

        private void RaisePrice(float amountToAdd)
        {
            this.myOrder.Price += amountToAdd;
        }
    }
}
