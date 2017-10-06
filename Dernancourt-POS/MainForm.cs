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
            
            InitializeComponent();
            //Order order = new Order();
            simplyCheese.Add("Tomato Sauce");
            simplyCheese.Add("Cheese");
            hamCheese.Add("Tomato Sauce");
            hamCheese.Add("Cheese");
            hamCheese.Add("Ham");
            aussie.Add("Tomato");
            aussie.Add("Cheese");
            aussie.Add("Ham");
            aussie.Add("Bacon");
            aussie.Add("Egg");
            hamPineapple.Add("Tomato");
            hamPineapple.Add("Cheese");
            hamPineapple.Add("Ham");
            hamPineapple.Add("Pineapple");
            american.Add("Tomato");
            american.Add("Cheese");
            american.Add("Salami");
            margherita.Add("Tomato");
            margherita.Add("Cheese");
            margherita.Add("Fresh Tomato");
            margherita.Add("Garlic and Herbs");
            vegetarian.Add("Tomato");
            vegetarian.Add("Cheese");
            vegetarian.Add("Onion");
            vegetarian.Add("Diced Tomato");
            vegetarian.Add("Pineapple");
            vegetarian.Add("Mushroom");
            vegetarian.Add("Capsicum");
            vegetarian.Add("Olives");
            vegetarian.Add("Garlic and Herbs");
            seafood.Add("Tomato");
            seafood.Add("Cheese");
            seafood.Add("Calamari");
            seafood.Add("Smoked Mussles");
            seafood.Add("Prawns");
            seafood.Add("Anchovies");
            seafood.Add("Garlic");
            dernancourt.Add("Tomato");
            dernancourt.Add("Cheese");
            dernancourt.Add("Ham");
            dernancourt.Add("Pineapple");
            dernancourt.Add("Mushrooms");
            dernancourt.Add("Capsicum");
            dernancourt.Add("Bacon");
            dernancourt.Add("Onion");
            special.Add("Tomato");
            special.Add("Cheese");
            special.Add("Ham");
            special.Add("Salami");
            special.Add("Olives");
            special.Add("Mushroom");
            special.Add("Capsicum");
            mushroom.Add("Tomato");
            mushroom.Add("Cheese");
            mushroom.Add("Ham");
            mushroom.Add("Mushroom");
            capricciosa.Add("Tomato");
            capricciosa.Add("Cheese");
            capricciosa.Add("Bacon");
            capricciosa.Add("Olives");
            capricciosa.Add("Onion");
            capricciosa.Add("Mushroom");
            capricciosa.Add("Capsicum");
            chickenDeluxe.Add("Tomato");
            chickenDeluxe.Add("Cheese");
            chickenDeluxe.Add("Mushroom");
            chickenDeluxe.Add("Ham");
            chickenDeluxe.Add("Chicken");
            chickenDeluxe.Add("Pineapple");
            pepperoni.Add("Tomato");
            pepperoni.Add("Cheese");
            pepperoni.Add("Pepperoni");
            calabrese.Add("Tomato");
            calabrese.Add("Cheese");
            calabrese.Add("Spicy Salami");
            calabrese.Add("Olives");
            calabrese.Add("Mushroom");
            calabrese.Add("Capsicum");
            calabrese.Add("Bacon");
            bbqChicken.Add("BBQ Sauce");
            bbqChicken.Add("Cheese");
            bbqChicken.Add("Chicken");
            bbqChicken.
                Add("Capsicum");
            bbqChicken.Add("Pineapple");
            bbqChicken.Add("Bacon");
            meatlovers.Add("Tomato");
            meatlovers.Add("Cheese");
            meatlovers.Add("Salami");
            meatlovers.Add("Ham");
            meatlovers.Add("Bacon");
            meatlovers.Add("Beef");
            houseSpecial.Add("Tomato");
            houseSpecial.Add("Cheese");
            houseSpecial.Add("Bacon");
            houseSpecial.Add("Egg");
            houseSpecial.Add("Onion");
            mexican.Add("Tomato");
            mexican.Add("Cheese");
            mexican.Add("Onion");
            mexican.Add("Capsicum");
            mexican.Add("Hot Salami");
            mexican.Add("Beef");
            mexican.Add("Oregano");
            yiros.Add("Tomato");
            yiros.Add("Cheese");
            yiros.Add("Onion");
            yiros.Add("Capsicum");
            yiros.Add("Lamb pieces");
            chickenHawaiian.Add("Tomato");
            chickenHawaiian.Add("Cheese");
            chickenHawaiian.Add("Chicken");
            chickenHawaiian.Add("Pineapple");
            baconDeluxe.Add("Tomato");
            baconDeluxe.Add("Cheese");
            baconDeluxe.Add("Bacon");
            baconDeluxe.Add("Onion");
            baconDeluxe.Add("Capsicum");
            baconDeluxe.Add("Pineapple");
            outback.Add("Tomato");
            outback.Add("Cheese");
            outback.Add("Salami");
            outback.Add("Onion");
            outback.Add("Garlic");
            outback.Add("BBQ Sauce");
            supreme.Add("Tomato");
            supreme.Add("Cheese");
            supreme.
                Add("Ham");
            supreme.Add("Salami");
            supreme.Add("Olives");
            supreme.Add("Mushroom");
            supreme.
                Add("Capsicum");
            supreme.Add("Pineapple");
            supreme.Add("Anchovies");
            theLot.Add("Tomato");
            theLot.Add("Cheese");
            theLot.Add("Ham");
            theLot.Add("Salami");
            theLot.Add("Mushroom");
            theLot.Add("Capsicum");
            theLot.Add("Onion");
            theLot.Add("Pineapple");
            theLot.Add("Olives");
            theLot.Add("Bacon");
            theLot.Add("Anchovies");
            fourCheese.Add("Bocconcini");
            fourCheese.Add("Parmesan");
            fourCheese.Add("Feta");
            fourCheese.Add("Mozzarella");
            tandooriChicken.Add("Tomato");
            tandooriChicken.Add("Cheese");
            tandooriChicken.Add("Capsicum");
            tandooriChicken.Add("Onion");
            tandooriChicken.Add("Diced tomato");
            tandooriChicken.Add("Tandoori Chicken");
            tandooriChicken.Add("Garlic");
            tandooriChicken.Add("Parsley");
            tandooriChicken.
                Add("Chilli Flakes");
            mangoChicken.Add("Tomato");
            mangoChicken.Add("Cheese");
            mangoChicken.
                Add("Onion");
            mangoChicken.Add("Marinated Chicken");
            mangoChicken.Add("Mango");
            chickenSupreme.Add("Tomato");
            chickenSupreme.Add("Cheese");
            chickenSupreme.Add("Onion");
            chickenSupreme.Add("Chicken");
            chickenSupreme.Add("Mushroom");
            chickenSupreme.Add("Capsicum");
            chickenSupreme.Add("Oregano");
            chickenSupreme.Add("Fresh Garlic");
            hotSpicy.Add("Tomato");
            hotSpicy.Add("Cheese");
            hotSpicy.Add("Onion");
            hotSpicy.Add("Beef");
            hotSpicy.Add("Hot Salami");
            hotSpicy.Add("Olives");
            hotSpicy.Add("Jalapeno");
            hotSpicy.Add("Chilli Flakes");
            marinara.Add("Tomato");
            marinara.Add("Cheese");
            marinara.Add("Marinara Mix");
            marinara.Add("Garlic and Herbs");
            periChicken.Add("Tomato");
            periChicken.Add("Cheese");
            periChicken.Add("Spanish onion");
            periChicken.Add("Marinated Chicken");
            periChicken.Add("Capsicum");
            periChicken.Add("Peri Peri Drizzle");
            gVegetarian.Add("Tomato");
            gVegetarian.Add("Cheese");
            gVegetarian.Add("Eggplant");
            gVegetarian.Add("Roasted Capsicum");
            gVegetarian.Add("Olives");
            gVegetarian.Add("Spanish Onion");
            gVegetarian.Add("ARtichokes");
            gVegetarian.Add("Oregano");
            gVegetarian.Add("Bocconcini");
            gMediterranean.Add("Tomato");
            gMediterranean.Add("Cheese");
            gMediterranean.Add("Salami");
            gMediterranean.Add("Pepperoni");
            gMediterranean.Add("Grilled Eggplant");
            gMediterranean.Add("Mushroom");
            gMediterranean.Add("Roasted Capsicum");
            gMediterranean.Add("Olives");
            gMediterranean.Add("Sundried Tomato");
            gMediterranean.Add("Bocconcini");
            gMediterranean.Add("Fresh basil");
            gLamb.Add("Tomato");
            gLamb.Add("Cheese");
            gLamb.Add("Lamb");
            gLamb.Add("Spanish Onion");
            gLamb.Add("Diced Tomato");
            gLamb.Add("Basil");
            gLamb.Add("Garlic sauce");
            gChicken.Add("Tomato");
            gChicken.Add("Cheese");
            gChicken.Add("Chicken");
            gChicken.Add("Mushrooms");
            gChicken.Add("Sundried Tomato");
            gChicken.Add("Roasted Capsicum");
            gChicken.Add("Spanish Onion");
            gChicken.Add("Oregano");
            gThaiChicken.Add("Sweet Chilli Sauce");
            gThaiChicken.Add("Cheese");
            gThaiChicken.Add("Chicken");
            gThaiChicken.Add("Capsicum");
            gThaiChicken.Add("Garlic");
            gSpecial.Add("Tomato");
            gSpecial.Add("Cheese");
            gSpecial.Add("Leg Ham");
            gSpecial.Add("Salami");
            gSpecial.Add("Mushrooms");
            gSpecial.Add("Roasted Capsicum");
            gSpecial.Add("Olives");
            gMexicana.Add("Tomato");
            gMexicana.Add("Mozzarella");
            gMexicana.Add("Spicy Italian Salami");
            gMexicana.Add("Spanish Onion");
            gMexicana.Add("Roasted Capsicum");
            gMexicana.Add("Olives");
            gGarlicPrawn.Add("Tomato");
            gGarlicPrawn.Add("Cheese");
            gGarlicPrawn.Add("Prawn");
            gGarlicPrawn.Add("Garlic");
            satayChicken.Add("Satay Sauce");
            satayChicken.Add("Cheese");
            satayChicken.Add("Mushrooms");
            satayChicken.Add("Roasted Capsicum");
            satayChicken.Add("Roasted onion");
            satayChicken.Add("Chicken");
            elPaso.Add("Tomato");
            elPaso.Add("Cheese");
            elPaso.Add("Chicken");
            elPaso.Add("Roasted capsicum");
            elPaso.Add("Jalapenos");
            elPaso.Add("Beef");
            elPaso.Add("Chilli Flakes");
            elPaso.Add("Garlic Sauce");

        }

        public void displayMessage(string Message)
        {
            MessageBox.Show(Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            halfhalfPanel.Visible = false;
            startersPanel.Visible = false;
            starters2Panel.Visible = false;
            starters3Panel.Visible = false;
            starters4Panel.Visible = false;
            mainsPanel.Visible = false;
            mains2Panel.Visible = false;
            mealDealPanel.Visible = false;
            mealDealPanel2.Visible = false;
            traditionalPanel.Visible = false;
            traditional2Panel.Visible = false;
            traditional3Panel.Visible = false;
            traditional4Panel.Visible = false;
            gourmetPanel.Visible = false;
            gourmet2Panel.Visible = false;
            seafoodPanel.Visible = false;
            abPanel.Visible = false;
            ab2Panel.Visible = false;
            pastaPanel.Visible = false;
            pastaBakePanel.Visible = false;
            ribsnwingsPanel.Visible = false;
            risottoPanel.Visible = false;
            kebabWrapPanel.Visible = false;
            saladsPanel.Visible = false;
            desertsPanel.Visible = false;
            desert2Panel.Visible = false;
            beveragesPanel.Visible = false;
            summaryPanel.Visible = false;
            editItemsPanel.Visible = false;
            commentPanel.Visible = false;
            // on load make all panels fill
            orderPanel.Dock = DockStyle.Fill;
            mealDealPanel.Dock = DockStyle.Fill;
            mealDealPanel2.Dock = DockStyle.Fill;
            halfhalfPanel.Dock = DockStyle.Fill;
            startersPanel.Dock = DockStyle.Fill;
            starters2Panel.Dock = DockStyle.Fill;
            starters3Panel.Dock = DockStyle.Fill;
            starters4Panel.Dock = DockStyle.Fill;
            mainsPanel.Dock = DockStyle.Fill;
            mains2Panel.Dock = DockStyle.Fill;
            traditionalPanel.Dock = DockStyle.Fill;
            traditional2Panel.Dock = DockStyle.Fill;
            traditional3Panel.Dock = DockStyle.Fill;
            traditional4Panel.Dock = DockStyle.Fill;
            gourmetPanel.Dock = DockStyle.Fill;
            gourmet2Panel.Dock = DockStyle.Fill;
            seafoodPanel.Dock = DockStyle.Fill;
            abPanel.Dock = DockStyle.Fill;
            ab2Panel.Dock = DockStyle.Fill;
            pastaPanel.Dock = DockStyle.Fill;
            pastaBakePanel.Dock = DockStyle.Fill;
            ribsnwingsPanel.Dock = DockStyle.Fill;
            risottoPanel.Dock = DockStyle.Fill;
            kebabWrapPanel.Dock = DockStyle.Fill;
            saladsPanel.Dock = DockStyle.Fill;
            desert2Panel.Dock = DockStyle.Fill;
            desertsPanel.Dock = DockStyle.Fill;
            beveragesPanel.Dock = DockStyle.Fill;
            summaryPanel.Dock = DockStyle.Fill;
            editItemsPanel.Dock = DockStyle.Fill;
            commentPanel.Dock = DockStyle.Fill;

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
            if (string.IsNullOrEmpty(customerPhoneNumberTxt.Text))
            {
                const string message =
                     "At least a phone number is required, please enter a phone number";
                const string caption = "Form Validation";
                MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }

            if (customerAddressTxt.Text.Length > 0 && (!string.IsNullOrEmpty(customerPhoneNumberTxt.Text)))
            {
                // delivery
                myOrder = new Order(customerNameTxt.Text, customerPhoneNumberTxt.Text, customerAddressTxt.Text, customerSuburbTxt.Text);
                Console.WriteLine(myOrder.ToString());

                // move to orderPanel
                orderPanel.Visible = true;
            }
            else if (!string.IsNullOrEmpty(customerPhoneNumberTxt.Text))
            {
                // takeaway
                myOrder = new Order(customerNameTxt.Text, customerPhoneNumberTxt.Text);
                Console.WriteLine("TAKEAWAY:");
                Console.WriteLine(myOrder.ToString());

                // move to orderPanel
                orderPanel.Visible = true;
            }


        }

        private void pnl2BackBtn_Click(object sender, EventArgs e)
        {
            // make orderPanel invisible
            orderPanel.Visible = false;
        }

        private void mealDealPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2MealDealsBtn_Click(object sender, EventArgs e)
        {
            // make mealDealPanel vis
            //orderPanel.Visible = false;
            mealDealPanel.Visible = true;
        }

        private void mealDealNxtBtn_Click(object sender, EventArgs e)
        {
            mealDealPanel2.Visible = true;
        }

        private void mealDealSecondBackBtn_Click(object sender, EventArgs e)
        {
            mealDealPanel2.Visible = false;
        }

        private void mealDealBackBtn_Click(object sender, EventArgs e)
        {
            mealDealPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            halfhalfPanel.Visible = false;
        }

        private void pnl2HalfBtn_Click(object sender, EventArgs e)
        {
            halfhalfPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startersPanel.Visible = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            starters4Panel.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            starters3Panel.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            starters4Panel.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            starters3Panel.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            starters2Panel.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            starters2Panel.Visible = true;
        }

        private void pnl2StartersBtn_Click(object sender, EventArgs e)
        {
            startersPanel.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            startersPanel.Visible = false;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            starters2Panel.Visible = true;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            starters2Panel.Visible = false;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            starters3Panel.Visible = true;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            starters3Panel.Visible = false;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            starters4Panel.Visible = true;
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            starters4Panel.Visible = false;
        }

        private void label145_Click(object sender, EventArgs e)
        {

        }

        private void button104_Click(object sender, EventArgs e)
        {
            mainsPanel.Visible = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            mains2Panel.Visible = false;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            mains2Panel.Visible = true;
        }

        private void pnl2MainsBtn_Click(object sender, EventArgs e)
        {
            mainsPanel.Visible = true;
        }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            halfhalfPanel.Visible = false;
        }

        private void traditionalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button353_Click(object sender, EventArgs e)
        {
            traditional4Panel.Visible = false;
        }

        private void button282_Click(object sender, EventArgs e)
        {
            traditional4Panel.Visible = true;
        }

        private void button281_Click(object sender, EventArgs e)
        {
            traditional3Panel.Visible = false;
        }

        private void button210_Click(object sender, EventArgs e)
        {
            traditional3Panel.Visible = true;
        }

        private void button209_Click(object sender, EventArgs e)
        {
            traditional2Panel.Visible = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            traditional2Panel.Visible = true;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            traditionalPanel.Visible = false;
        }

        private void pnl2TraditionalBtn_Click(object sender, EventArgs e)
        {
            traditionalPanel.Visible = true;
        }

        private void button440_Click(object sender, EventArgs e)
        {
            gourmet2Panel.Visible = false;
        }

        private void button369_Click(object sender, EventArgs e)
        {
            gourmet2Panel.Visible = true;
        }

        private void button368_Click(object sender, EventArgs e)
        {
            gourmetPanel.Visible = false;
        }

        private void pnl2GourmetBtn_Click(object sender, EventArgs e)
        {
            gourmetPanel.Visible = true;
        }

        private void button369_Click_1(object sender, EventArgs e)
        {
            gourmet2Panel.Visible = true;
        }

        private void button368_Click_1(object sender, EventArgs e)
        {
            gourmetPanel.Visible = false;
        }

        private void button440_Click_1(object sender, EventArgs e)
        {
            gourmet2Panel.Visible = false;
        }

        private void button370_Click(object sender, EventArgs e)
        {
            seafoodPanel.Visible = false;
        }

        private void pnl2SeafoodBtn_Click(object sender, EventArgs e)
        {
            seafoodPanel.Visible = true;
        }

        private void abPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button394_Click(object sender, EventArgs e)
        {
            ab2Panel.Visible = false;
        }

        private void button385_Click(object sender, EventArgs e)
        {
            ab2Panel.Visible = true;
        }

        private void button384_Click(object sender, EventArgs e)
        {
            abPanel.Visible = false;

        }

        private void pnl2TheABBtn_Click(object sender, EventArgs e)
        {
            abPanel.Visible = true;
        }

        private void button395_Click(object sender, EventArgs e)
        {
            pastaPanel.Visible = false;

        }

        private void pnl2PastaBtn_Click(object sender, EventArgs e)
        {
            pastaPanel.Visible = true;
        }

        private void button396_Click(object sender, EventArgs e)
        {
            pastaBakePanel.Visible = false;

        }

        private void pnl2PastaBakeBtn_Click(object sender, EventArgs e)
        {
            pastaBakePanel.Visible = true;
        }

        private void button408_Click(object sender, EventArgs e)
        {
            ribsnwingsPanel.Visible = false;

        }

        private void pnl2RibsWingsBtn_Click(object sender, EventArgs e)
        {
            ribsnwingsPanel.Visible = true;
        }

        private void button407_Click(object sender, EventArgs e)
        {
            risottoPanel.Visible = false;

        }

        private void pnl2RisottoBtn_Click(object sender, EventArgs e)
        {
            risottoPanel.Visible = true;
        }

        private void button446_Click(object sender, EventArgs e)
        {
            kebabWrapPanel.Visible = false;

        }

        private void pnl2KebabWrapBtn_Click(object sender, EventArgs e)
        {
            kebabWrapPanel.Visible = true;
        }

        private void button461_Click(object sender, EventArgs e)
        {
            saladsPanel.Visible = false;

        }

        private void pnl2SaladsBtn_Click(object sender, EventArgs e)
        {
            saladsPanel.Visible = true;
        }

        private void button462_Click(object sender, EventArgs e)
        {
            desert2Panel.Visible = false;

        }

        private void button462_Click_1(object sender, EventArgs e)
        {
            desert2Panel.Visible = false;
        }

        private void button478_Click(object sender, EventArgs e)
        {
            desert2Panel.Visible = true;
        }

        private void button477_Click(object sender, EventArgs e)
        {
            desertsPanel.Visible = false;
        }

        private void pnl2DesertsBtn_Click(object sender, EventArgs e)
        {
            desertsPanel.Visible = true;
        }

        private void button474_Click(object sender, EventArgs e)
        {
            beveragesPanel.Visible = false;
        }

        private void pnl2BeveragesBtn_Click(object sender, EventArgs e)
        {
            beveragesPanel.Visible = true;
        }

        private void pastaDealBtn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 1, ItemName = "Pasta Deal", ItemPrice = 19.90f });
        }

        private void mealDealPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2NextBtn_Click(object sender, EventArgs e)
        {
            commentPanel.Visible = true;
        }

        private void footyDealBtn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 2, ItemName = "Footy Deal", ItemPrice = 36.90f });
        }

        private void deal1Btn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 3, ItemName = "Deal 1", ItemPrice = 19.90f });
        }

        private void deal2Btn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 4, ItemName = "Deal 2", ItemPrice = 25.90f });
        }

        private void deal3Btn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 5, ItemName = "Deal 3", ItemPrice = 29.90f });
        }

        private void deal4Btn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 6, ItemName = "Deal 4", ItemPrice = 31.90f });
        }

        private void deal5Btn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 7, ItemName = "Deal 5", ItemPrice = 44.90f });
        }

        private void deal6Btn_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 8, ItemName = "Deal 6", ItemPrice = 55.90f });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 9, ItemName = "Deal 7", ItemPrice = 23.50f });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 10, ItemName = "Deal 8", ItemPrice = 36.50f });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 11, ItemName = "Deal 9", ItemPrice = 43.50f });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 12, ItemName = "Deal 10", ItemPrice = 6.00f });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 13, ItemName = "Deal 11", ItemPrice = 8.00f });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 14, ItemName = "Family Feast", ItemPrice = 43.00f });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 15, ItemName = "Half n Half - Large", ItemPrice = 1.0f });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 16, ItemName = "Half n Half -  Family", ItemPrice = 1.0f });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 17, ItemName = "Half n Half -  Party", ItemPrice = 1.0f });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 18, ItemName = "Half n Half -  Jumbo", ItemPrice = 1.0f });

        }

        private void button43_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 19, ItemName = "Herb Bread", ItemPrice = 4.5f });
        }

        private void button44_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 20, ItemName = "Potato Bites", ItemPrice = 4.5f });

        }

        private void button45_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 21, ItemName = "Garlic Bread", ItemPrice = 3.9f });

        }

        private void button46_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 22, ItemName = "Cheesy Garlic Bread", ItemPrice = 5.5f });

        }

        private void button47_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 23, ItemName = "Salt and Pepper Fish Bites", ItemPrice = 5f });

        }

        private void button48_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 24, ItemName = "Diamond Cut Chips", ItemPrice = 6.5f });

        }

        private void button52_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 25, ItemName = "Chips and Gravy", ItemPrice = 8.5f });

        }

        private void button53_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 26, ItemName = "Chicken nuggets 6", ItemPrice = 6.0f });

        }

        private void button31_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 27, ItemName = "Chicken nuggets 12", ItemPrice = 10f });

        }

        private void button30_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 28, ItemName = "Cheesy GB with Ham and Pineapple", ItemPrice = 6.5f });

        }

        private void button29_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 29, ItemName = "Cheesy GB with Mushroom", ItemPrice = 6.5f });

        }

        private void button28_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 30, ItemName = "Curly Fries", ItemPrice = 7.5f });

        }

        private void button27_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 31, ItemName = "Onion Rings (Medium)", ItemPrice = 4.5f });

        }

        private void button26_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 32, ItemName = "Onion Rings (Large)", ItemPrice = 7.5f });

        }

        private void button25_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 33, ItemName = "Potato Wedges", ItemPrice = 8f });

        }

        private void button24_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 34, ItemName = "Calamari Rings", ItemPrice = 8f });

        }

        private void button41_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 35, ItemName = "Crispy Fried Chicken", ItemPrice = 6f });

        }

        private void button40_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 36, ItemName = "Spicy Crispy Fried Chicken", ItemPrice = 6f });
        }

        private void button39_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 37, ItemName = "Garlic Cheese Pizza (Small)", ItemPrice = 8f });

        }

        private void button38_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 38, ItemName = "Garlic Cheese Pizza (Large)", ItemPrice = 10f });

        }

        private void button37_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 39, ItemName = "Feta Cheese Triangles", ItemPrice = 3.90f });

        }

        private void button36_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 40, ItemName = "Ham and Cheese Gems", ItemPrice = 4.9f });

        }

        private void button35_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 41, ItemName = "Mozzarella Sticks", ItemPrice = 5.9f });

        }

        private void button34_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 42, ItemName = "Homemade GB", ItemPrice = 4.5f });

        }

        private void button51_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 43, ItemName = "Cheesy GB w/ Jalapeno", ItemPrice = 6.5f });

        }

        private void button50_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 44, ItemName = "Cheesy GB w/ Salami", ItemPrice = 6.5f });

        }

        private void button49_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 45, ItemName = "Oven Baked Chips", ItemPrice = 6.5f });

        }

        private void button113_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 46, ItemName = "Chicken Schnitzel", ItemPrice = 15f });

        }

        private void button112_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 47, ItemName = "Veal Schnitzel", ItemPrice = 15f });

        }

        private void button111_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 48, ItemName = "Pollo Parmigiana", ItemPrice = 18f });

        }

        private void button110_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 49, ItemName = "Veal Parmigiana", ItemPrice = 18f });

        }

        private void button109_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 50, ItemName = "Mexican Pollo Parmigiana", ItemPrice = 19f });

        }

        private void button108_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 51, ItemName = "Sicilian Pollo Parmigiana", ItemPrice = 19f });

        }

        private void button107_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 52, ItemName = "Hawaiian Veal Parmigiana", ItemPrice = 19f });

        }

        private void button106_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 53, ItemName = "Mexican Veal Parmigiana", ItemPrice = 19f });

        }

        private void button89_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 54, ItemName = "Sicilian Veal Parmigiana", ItemPrice = 19f });

        }

        private void button379_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 55, ItemName = "Fried Fish Pack", ItemPrice = 14.9f });

        }

        private void button378_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 56, ItemName = "Fried Prawns Pack", ItemPrice = 15.9f });

        }

        private void button377_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 57, ItemName = "Fried Calamari Pack", ItemPrice = 14.9f });

        }

        private void button376_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 58, ItemName = "Salt and Pepper Squid", ItemPrice = 16.9f });

        }

        private void button375_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 59, ItemName = "Fritto Misto Del Mare", ItemPrice = 17.9f });

        }

        private void button393_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 60, ItemName = "AB Chicken", ItemPrice = 15.5f });

        }

        private void button392_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 61, ItemName = "Cheesy AB Chicken", ItemPrice = 16.5f });

        }

        private void button391_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 62, ItemName = "Peri Peri Chicken AB", ItemPrice = 16.5f });

        }

        private void button390_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 63, ItemName = "Sicilian Chicken AB", ItemPrice = 16.5f });

        }

        private void button389_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 64, ItemName = "AB Lamb", ItemPrice = 15.5f });

        }

        private void button388_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 65, ItemName = "Cheesy AB Lamb", ItemPrice = 15.5f });

        }

        private void button387_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 66, ItemName = "Mediterranean AB", ItemPrice = 16.5f });

        }

        private void button386_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 67, ItemName = "AB Combination", ItemPrice = 17.0f });

        }

        private void button403_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 68, ItemName = "Cheesy AB Combination", ItemPrice = 18f });

        }

        private void button405_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 69, ItemName = "Napoletana", ItemPrice = 13.9f });

        }

        private void button404_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 70, ItemName = "Alla Pana", ItemPrice = 13.9f });

        }

        private void button402_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 71, ItemName = "Al Pollo", ItemPrice = 13.9f });

        }

        private void button401_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 72, ItemName = "Carbonara", ItemPrice = 13.9f });

        }

        private void button400_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 73, ItemName = "Bolognese", ItemPrice = 13.9f });

        }

        private void button399_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 74, ItemName = "Creamy Lamb and Tomato", ItemPrice = 13.9f });

        }

        private void button398_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 75, ItemName = "Marinara", ItemPrice = 14.9f });

        }

        private void button397_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 76, ItemName = "Seafood Pasta", ItemPrice = 13.9f });

        }

        private void button442_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 77, ItemName = "Eggplant Pasta Bake", ItemPrice = 16.5f });

        }

        private void button441_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 78, ItemName = "Chicken and Cheese Pasta Bake", ItemPrice = 16.5f });
        }

        private void button411_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 79, ItemName = "Salami Pasta Bake", ItemPrice = 16.5f });

        }

        private void button410_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 80, ItemName = "Lamb and Feta Pasta Bake", ItemPrice = 15.5f });

        }

        private void button406_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 81, ItemName = "Lasagne", ItemPrice = 15.5f });

        }

        private void button445_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 82, ItemName = "Chicken Wings (6 pack)", ItemPrice = 7.9f });

        }

        private void button444_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 83, ItemName = "BBQ Chicken Wings", ItemPrice = 7.9f });

        }

        private void button443_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 84, ItemName = "Ribs", ItemPrice = 17.9f });

        }

        private void button409_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 85, ItemName = "BBQ Ribs and Wings Combo", ItemPrice = 16.9f });

        }

        private void button453_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 86, ItemName = "Seafood Risotto", ItemPrice = 15.5f });

        }

        private void button452_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 87, ItemName = "Mushroom and Spinach Risotto", ItemPrice = 14.5f });

        }

        private void button451_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 88, ItemName = "Mushroom and Bacon Risotto", ItemPrice = 14.5f });

        }

        private void button450_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 89, ItemName = "Chicken Risotto", ItemPrice = 14.5f });

        }

        private void button454_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 90, ItemName = "Chicken Kebab", ItemPrice = 10.5f });

        }

        private void button449_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 91, ItemName = "Lamb Kebab", ItemPrice = 10.5f });

        }

        private void button448_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 92, ItemName = "Combination Kebab", ItemPrice = 11.5f });

        }

        private void button470_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 93, ItemName = "Prawn Salad", ItemPrice = 13.5f });

        }

        private void button469_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 94, ItemName = "Grilled Vegetarian Salad", ItemPrice = 9.9f });

        }

        private void button468_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 95, ItemName = "Garden Salad", ItemPrice = 8.5f });

        }

        private void button467_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 96, ItemName = "Side Salad", ItemPrice = 4.5f });

        }

        private void button466_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 97, ItemName = "Mediterranean Salad", ItemPrice = 13.5f });

        }

        private void button465_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 98, ItemName = "Caesar Salad", ItemPrice = 13.5f });

        }

        private void button464_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 99, ItemName = "Chicken Salad", ItemPrice = 13.5f });

        }

        private void button463_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 100, ItemName = "Chicken Potato Salad", ItemPrice = 13.5f });

        }

        private void button486_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 101, ItemName = "Apple Pie", ItemPrice = 3.9f });

        }

        private void button485_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 102, ItemName = "Chocolate Pudding", ItemPrice = 4.9f });

        }

        private void button484_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 103, ItemName = "Cheesecake", ItemPrice = 4.9f });

        }

        private void button483_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 104, ItemName = "Chocolate Mousse", ItemPrice = 4.9f });


        }

        private void button482_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 105, ItemName = "Death by Chocolate", ItemPrice = 7.9f });

        }

        private void button481_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 106, ItemName = "Mars Bar Cheesecake", ItemPrice = 7.9f });

        }

        private void button480_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 107, ItemName = "Gelato (300 ml)", ItemPrice = 4.9f });

        }

        private void button479_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 108, ItemName = "Gelato (500 ml)", ItemPrice = 7.9f });

        }

        private void button489_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 109, ItemName = "Apple and Blackberry Pie", ItemPrice = 3.9f });

        }

        private void button488_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 110, ItemName = "Chocolate Brownie", ItemPrice = 4.9f });

        }

        private void button495_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 111, ItemName = "Soft Drink (Can)", ItemPrice = 3f });

        }

        private void button494_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 112, ItemName = "Water 500ml", ItemPrice = 3.5f });

        }

        private void button493_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 113, ItemName = "Soft Drink (1.25L)", ItemPrice = 4.5f });

        }

        private void button492_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Item() { ItemID = 114, ItemName = "Mother Energy Drink (500ml)", ItemPrice = 4f });

        }

        private void button371_Click(object sender, EventArgs e)
        {
            summaryPanel.Visible = false;
            orderPanel.Visible = true;
        }

        private void button372_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPRint = new PrintDocument();
            printDialog.Document = documentToPRint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(orderSummary.Text);
                documentToPRint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPRint.Print();

            }
        }

        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(orderSummary.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string line = null;
            Font PrintFont = this.orderSummary.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((line = reader.ReadLine()) != null))
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
            myOrder.AddItem(new Pizza("(Small) Simply Cheese", 10f, simplyCheese, this));
        }

        private void button65_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Simply Cheese", 14f, simplyCheese, this));
        }

        private void button66_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Simply Cheese", 20f, simplyCheese, this));
        }

        private void button67_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Simply Cheese", 25f, simplyCheese, this));
        }

        private void button68_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Simply Cheese", 44f, simplyCheese, this));
        }

        private void button69_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Simply Cheese", 16f, simplyCheese, this));
        }

        private void button70_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Simply Cheese", 16f, simplyCheese, this));
        }

        private void button63_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Ham and Cheese", 10f, hamCheese, this));
        }

        private void button62_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Ham and Cheese", 14f, simplyCheese, this));
        }

        private void button61_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Ham and Cheese", 20f, simplyCheese, this));
        }

        private void button60_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Ham and Cheese", 25f, simplyCheese, this));
        }

        private void button59_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Ham and Cheese", 44f, simplyCheese, this));
        }

        private void button58_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Ham and Cheese", 16f, simplyCheese, this));
        }

        private void button57_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Ham and Cheese", 16f, simplyCheese, this));
        }

        private void button77_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Aussie", 10f, aussie, this));
        }

        private void button76_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Aussie", 14f, aussie, this));
        }

        private void button75_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Aussie", 20f, aussie, this));
        }

        private void button74_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Aussie", 25f, aussie, this));
        }

        private void button73_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Aussie", 44f, aussie, this));
        }

        private void button72_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Aussie", 16f, aussie, this));
        }

        private void button71_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Aussie", 16f, aussie, this));
        }

        private void button85_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Ham and Pineapple", 10f, hamPineapple, this));

        }

        private void button84_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Ham and Pineapple", 14f, hamPineapple, this));
        }

        private void button83_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Ham and Pineapple", 20f, hamPineapple, this));
        }

        private void button82_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Ham and Pineapple", 25f, hamPineapple, this));
        }

        private void button81_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Ham and Pineapple", 44f, hamPineapple, this));
        }

        private void button79_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Ham and Pineapple", 16f, hamPineapple, this));
        }

        private void button78_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Ham and Pineapple", 16f, hamPineapple, this));
        }

        private void button93_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) American", 10f, american, this));
        }

        private void button92_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) American", 14f, american, this));
        }

        private void button91_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) American", 20f, american, this));
        }

        private void button90_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) American", 25f, american, this));
        }

        private void button88_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) American", 44f, american, this));
        }

        private void button87_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) American", 16f, american, this));
        }

        private void button86_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) American", 16f, american, this));
        }

        private void button100_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Margherita", 10f, margherita, this));
        }

        private void button99_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Margherita", 14f, margherita, this));
        }

        private void button98_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Margherita", 20f, margherita, this));
        }

        private void button97_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Margherita", 25f, margherita, this));
        }

        private void button96_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Margherita", 44f, margherita, this));
        }

        private void button95_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Margherita", 16f, margherita, this));
        }

        private void button94_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Margherita", 16f, margherita, this));
        }

        private void button117_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Vegetarian", 10f, vegetarian, this));
        }

        private void button116_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Vegetarian", 14f, vegetarian, this));
        }

        private void button115_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Vegetarian", 20f, vegetarian, this));
        }

        private void button114_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Vegetarian", 25f, vegetarian, this));
        }

        private void button103_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Vegetarian", 44f, vegetarian, this));
        }

        private void button102_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Vegetarian", 16f, vegetarian, this));
        }

        private void button101_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Vegetarian", 16f, vegetarian, this));
        }

        private void button124_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Seafood", 10f, seafood, this));
        }

        private void button123_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Seafood", 14f, seafood, this));
        }

        private void button122_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Seafood", 20f, seafood, this));
        }

        private void button121_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Seafood", 25f, seafood, this));
        }

        private void button120_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Seafood", 44f, seafood, this));
        }

        private void button119_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Seafood", 16f, seafood, this));
        }

        private void button118_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Seafood", 16f, seafood, this));
        }

        private void button131_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Dernancourt", 10f, dernancourt, this));
        }

        private void button130_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Dernancourt", 14f, dernancourt, this));
        }

        private void button129_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Dernancourt", 20f, dernancourt, this));
        }

        private void button128_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Dernancourt", 25f, dernancourt, this));
        }

        private void button127_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Dernancourt", 44f, dernancourt, this));
        }

        private void button126_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Dernancourt", 16f, dernancourt, this));
        }

        private void button125_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Dernancourt", 16f, dernancourt, this));
        }

        private void button138_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Special", 10f, special, this));
        }

        private void button137_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Special", 14f, special, this));
        }

        private void button136_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Special", 20f, special, this));
        }

        private void button135_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Special", 25f, special, this));
        }

        private void button134_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Special", 44f, special, this));
        }

        private void button133_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Special", 16f, special, this));
        }

        private void button132_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Special", 16f, special, this));
        }

        private void button208_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Mushroom", 10f, mushroom, this));
        }

        private void button207_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Mushroom", 14f, mushroom, this));
        }

        private void button206_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Mushroom", 20f, mushroom, this));
        }

        private void button205_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Mushroom", 25f, mushroom, this));
        }

        private void button204_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Mushroom", 44f, mushroom, this));
        }

        private void button203_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Mushroom", 16f, mushroom, this));
        }

        private void button202_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Mushroom", 16f, mushroom, this));
        }

        private void button201_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Capricciosa", 10f, capricciosa, this));
        }

        private void button200_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Capricciosa", 14f, capricciosa, this));
        }

        private void button199_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Capricciosa", 20f, capricciosa, this));
        }

        private void button198_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Capricciosa", 25f, capricciosa, this));
        }

        private void button197_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Capricciosa", 44f, capricciosa, this));
        }

        private void button196_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Capricciosa", 16f, capricciosa, this));
        }

        private void button195_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Capricciosa", 16f, capricciosa, this));
        }

        private void button194_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Chicken Deluxe", 10f, chickenDeluxe, this));
        }

        private void button193_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Chicken Deluxe", 14f, chickenDeluxe, this));
        }

        private void button192_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Chicken Deluxe", 20f, chickenDeluxe, this));
        }

        private void button191_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Chicken Deluxe", 25f, chickenDeluxe, this));
        }

        private void button190_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Chicken Deluxe", 44f, chickenDeluxe, this));
        }

        private void button189_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Chicken Deluxe", 16f, chickenDeluxe, this));
        }

        private void button188_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Chicken Deluxe", 16f, chickenDeluxe, this));
        }

        private void button187_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Pepperoni", 10f, pepperoni, this));
        }

        private void button186_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Pepperoni", 14f, pepperoni, this));
        }

        private void button185_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Pepperoni", 20f, pepperoni, this));
        }

        private void button184_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Pepperoni", 25f, pepperoni, this));
        }

        private void button183_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Pepperoni", 44f, pepperoni, this));
        }

        private void button182_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Pepperoni", 16f, pepperoni, this));
        }

        private void button181_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Pepperoni", 16f, pepperoni, this));
        }

        private void button180_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Calabrese", 10f, calabrese, this));
        }

        private void button179_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Calabrese", 14f, calabrese, this));
        }

        private void button178_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Calabrese", 20f, calabrese, this));
        }

        private void button177_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Calabrese", 25f, calabrese, this));
        }

        private void button176_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Calabrese", 44f, calabrese, this));
        }

        private void button175_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Calabrese", 16f, calabrese, this));
        }

        private void button174_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Calabrese", 16f, calabrese, this));
        }

        private void button173_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) BBQ Chicken", 10f, bbqChicken, this));
        }

        private void button172_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) BBQ Chicken", 14f, bbqChicken, this));
        }

        private void button171_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) BBQ Chicken", 20f, bbqChicken, this));
        }

        private void button170_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) BBQ Chicken", 25f, bbqChicken, this));
        }

        private void button169_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) BBQ Chicken", 44f, bbqChicken, this));
        }

        private void button168_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) BBQ Chicken", 16f, bbqChicken, this));
        }

        private void button167_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) BBQ Chicken", 16f, bbqChicken, this));
        }

        private void button166_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Meatlovers", 10f, meatlovers, this));
        }

        private void button165_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Meatlovers", 14f, meatlovers, this));
        }

        private void button164_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Meatlovers", 20f, meatlovers, this));
        }

        private void button163_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Meatlovers", 25f, meatlovers, this));
        }

        private void button162_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Meatlovers", 44f, meatlovers, this));
        }

        private void button161_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Meatlovers", 16f, meatlovers, this));
        }

        private void button160_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Meatlovers", 16f, meatlovers, this));
        }

        private void button159_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) House Special", 10f, houseSpecial, this));
        }

        private void button158_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) House Special", 14f, houseSpecial, this));
        }

        private void button157_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) House Special", 20f, houseSpecial, this));
        }

        private void button156_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) House Special", 25f, houseSpecial, this));
        }

        private void button155_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) House Special", 44f, houseSpecial, this));
        }

        private void button154_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) House Special", 16f, houseSpecial, this));
        }

        private void button153_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) House Special", 16f, houseSpecial, this));
        }

        private void button152_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Mexican", 10f, mexican, this));
        }

        private void button151_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Mexican", 14f, mexican, this));
        }

        private void button150_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Mexican", 20f, mexican, this));
        }

        private void button149_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Mexican", 25f, mexican, this));
        }

        private void button148_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Mexican", 44f, mexican, this));
        }

        private void button147_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Mexican", 16f, mexican, this));
        }

        private void button146_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Mexican", 16f, mexican, this));
        }

        private void button145_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Yiros", 10f, yiros, this));
        }

        private void button144_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Yiros", 14f, yiros, this));
        }

        private void button143_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Yiros", 20f, yiros, this));
        }

        private void button142_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Yiros", 25f, yiros, this));
        }

        private void button141_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Yiros", 44f, yiros, this));
        }

        private void button140_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Yiros", 16f, yiros, this));
        }

        private void button139_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Yiros", 16f, yiros, this));
        }

        private void button280_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Chicken Hawaiian", 10f, chickenHawaiian, this));
        }

        private void button279_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Chicken Hawaiian", 14f, chickenHawaiian, this));
        }

        private void button278_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Chicken Hawaiian", 20f, chickenHawaiian, this));
        }

        private void button277_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Chicken Hawaiian", 25f, chickenHawaiian, this));
        }

        private void button276_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Chicken Hawaiian", 44f, chickenHawaiian, this));
        }

        private void button275_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Chicken Hawaiian", 16f, chickenHawaiian, this));
        }

        private void button274_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Chicken Hawaiian", 16f, chickenHawaiian, this));
        }

        private void button273_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Bacon Deluxe", 10f, baconDeluxe, this));
        }

        private void button272_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Bacon Deluxe", 14f, baconDeluxe, this));
        }

        private void button271_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Bacon Deluxe", 20f, baconDeluxe, this));
        }

        private void button270_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Bacon Deluxe", 25f, baconDeluxe, this));
        }

        private void button269_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Bacon Deluxe", 44f, baconDeluxe, this));
        }

        private void button268_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Bacon Deluxe", 16f, baconDeluxe, this));
        }

        private void button267_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Bacon Deluxe", 16f, baconDeluxe, this));
        }

        private void button266_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Outback", 10f, outback, this));
        }

        private void button265_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Outback", 14f, outback, this));
        }

        private void button264_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Outback", 20f, outback, this));
        }

        private void button263_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Outback", 25f, outback, this));
        }

        private void button262_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Outback", 44f, outback, this));
        }

        private void button261_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Outback", 16f, outback, this));
        }

        private void button260_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Outback", 16f, outback, this));
        }

        private void button259_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Supreme", 10f, supreme, this));
        }

        private void button258_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Supreme", 14f, supreme, this));
        }

        private void button257_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Supreme", 20f, supreme, this));
        }

        private void button256_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Supreme", 25f, supreme, this));
        }

        private void button255_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Supreme", 44f, supreme, this));
        }

        private void button254_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Supreme", 16f, supreme, this));
        }

        private void button253_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Supreme", 16f, supreme, this));
        }

        private void button252_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) The Lot", 10f, theLot, this));
        }

        private void button251_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) The Lot", 14f, theLot, this));
        }

        private void button250_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) The Lot", 20f, theLot, this));
        }

        private void button249_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) The Lot", 25f, theLot, this));
        }

        private void button248_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) The Lot", 44f, theLot, this));
        }

        private void button247_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) The Lot", 16f, theLot, this));
        }

        private void button246_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) The Lot", 16f, theLot, this));
        }

        private void button245_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Four Cheese", 10f, fourCheese, this));
        }

        private void button244_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Four Cheese", 14f, fourCheese, this));
        }

        private void button243_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Four Cheese", 20f, fourCheese, this));
        }

        private void button242_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Four Cheese", 25f, fourCheese, this));
        }

        private void button241_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Four Cheese", 44f, fourCheese, this));
        }

        private void button240_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Four Cheese", 16f, fourCheese, this));
        }

        private void button239_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Four Cheese", 16f, fourCheese, this));
        }

        private void button238_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Tandoori Chicken", 10f, tandooriChicken, this));
        }

        private void button237_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Tandoori Chicken", 14f, tandooriChicken, this));
        }

        private void button236_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Tandoori Chicken", 20f, tandooriChicken, this));
        }

        private void button235_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Tandoori Chicken", 25f, tandooriChicken, this));
        }

        private void button234_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Tandoori Chicken", 44f, tandooriChicken, this));
        }

        private void button233_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Tandoori Chicken", 16f, tandooriChicken, this));
        }

        private void button232_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Tandoori Chicken", 16f, tandooriChicken, this));
        }

        private void button231_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Mango Chicken", 10f, mangoChicken, this));
        }

        private void button230_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Mango Chicken", 14f, mangoChicken, this));
        }

        private void button229_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Mango Chicken", 20f, mangoChicken, this));
        }

        private void button228_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Mango Chicken", 25f, mangoChicken, this));
        }

        private void button227_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Mango Chicken", 44f, mangoChicken, this));
        }

        private void button226_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Mango Chicken", 16f, mangoChicken, this));

        }

        private void button225_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Mango Chicken", 16f, mangoChicken, this));

        }

        private void button224_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Chicken Supreme", 10f, chickenSupreme, this));
        }

        private void button223_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Chicken Supreme", 14f, chickenSupreme, this));
        }

        private void button222_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Chicken Supreme", 20f, chickenSupreme, this));
        }

        private void button221_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Chicken Supreme", 25f, chickenSupreme, this));
        }

        private void button220_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Chicken Supreme", 44f, chickenSupreme, this));
        }

        private void button219_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Chicken Supreme", 16f, chickenSupreme, this));
        }

        private void button218_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Chicken Supreme", 16f, chickenSupreme, this));
        }

        private void button217_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Hot and Spicy", 10f, hotSpicy, this));
        }

        private void button216_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Hot and Spicy", 14f, hotSpicy, this));
        }

        private void button215_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Hot and Spicy", 20f, hotSpicy, this));
        }

        private void button214_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Hot and Spicy", 25f, hotSpicy, this));
        }

        private void button213_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Hot and Spicy", 44f, hotSpicy, this));
        }

        private void button212_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Hot and Spicy", 16f, hotSpicy, this));
        }

        private void button211_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Hot and Spicy", 16f, hotSpicy, this));
        }

        private void button352_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Marinara", 10f, marinara, this));
        }

        private void button351_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Marinara", 14f, marinara, this));
        }

        private void button350_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Marinara", 20f, marinara, this));
        }

        private void button349_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Marinara", 25f, marinara, this));
        }

        private void button348_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Marinara", 44f, marinara, this));
        }

        private void button347_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Marinara", 16f, marinara, this));
        }

        private void button346_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Marinara", 16f, marinara, this));
        }

        private void button345_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Peri Peri Chicken", 10f, periChicken, this));
        }

        private void button344_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Peri Peri Chicken", 14f, periChicken, this));
        }

        private void button343_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Peri Peri Chicken", 20f, periChicken, this));
        }

        private void button342_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Peri Peri Chicken", 25f, periChicken, this));
        }

        private void button341_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Peri Peri Chicken", 44f, periChicken, this));
        }

        private void button340_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Peri Peri Chicken", 16f, periChicken, this));
        }

        private void button339_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Peri Peri Chicken", 16f, periChicken, this));
        }

        private void pastaDealLbl_Click(object sender, EventArgs e)
        {

        }

        private void button373_Click(object sender, EventArgs e)
        {
            //summaryPanel.Visible = false;
            //orderPanel.Visible = false;
            editItemsBox.Items.Clear();
            editItemsPanel.Visible = true;
           // panel

            // populate the listbox with the order summary (items only)
            foreach (Item item in myOrder.Items)
            {
                editItemsBox.Items.Add(item);
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int index = this.editItemsBox.SelectedIndex;
            if (this.editItemsBox.SelectedIndex >= 0) { 
                this.editItemsBox.Items.RemoveAt(this.editItemsBox.SelectedIndex);
                // delete from myOrder
                myOrder.RemoveItemAtIndex(index);
                updateItems();
            } else {
                MessageBox.Show("Please select an item before deleting");
            }
        }

        private void button374_Click(object sender, EventArgs e)
        {
            editItemsPanel.Visible = false;
        }

        private void updateItems()
        {
            orderSummary.Text = "";
            summaryPanel.Visible = true;
            // add order deets
            orderSummary.Text += myOrder.ToString();
            // add all the items from myOrder to the orderSummary
            foreach (Item item in myOrder.Items)
            {
                orderSummary.Text += item.ToString() + Environment.NewLine;
            }
            // add a space before total price
            orderSummary.Text += Environment.NewLine;
            if (myOrder.getPrice() % 1 != 0)
            {
                orderSummary.Text += "Total price: $" + myOrder.getTotalPrice() + "0";
            }
            else
            {
                orderSummary.Text += "Total price: $" + myOrder.getTotalPrice();
            }
        }

        private void button367_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Vegetarian", 13f, gVegetarian, this));
        }

        private void button366_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Vegetarian", 17f, gVegetarian, this));
        }

        private void button365_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Vegetarian", 23f, gVegetarian, this));
        }

        private void button364_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Vegetarian", 27f, gVegetarian, this));
        }

        private void button363_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Vegetarian", 52f, gVegetarian, this));
        }

        private void button362_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Vegetarian", 18f, gVegetarian, this));
        }

        private void button361_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Vegetarian", 18f, gVegetarian, this));
        }

        private void button360_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Mediterranean", 13f, gMediterranean, this));
        }

        private void button359_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Mediterranean", 17f, gMediterranean, this));
        }

        private void button358_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Mediterranean", 23f, gMediterranean, this));
        }

        private void button357_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Mediterranean", 27f, gMediterranean, this));
        }

        private void button356_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Mediterranean", 52f, gMediterranean, this));
        }

        private void button355_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Mediterranean", 18f, gMediterranean, this));
        }

        private void button354_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Mediterranean", 18f, gMediterranean, this));
        }

        private void button338_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Lamb", 13f, gLamb, this));
        }

        private void button337_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Lamb", 17f, gLamb, this));
        }

        private void button336_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Lamb", 23f, gLamb, this));
        }

        private void button335_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Lamb", 27f, gLamb, this));
        }

        private void button334_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Lamb", 52f, gLamb, this));
        }

        private void button333_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Lamb", 18f, gLamb, this));
        }

        private void button332_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Lamb", 18f, gLamb, this));
        }

        private void button331_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Chicken", 13f, gChicken, this));
        }

        private void button330_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Chicken", 17f, gChicken, this));
        }

        private void button329_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Chicken", 23f, gChicken, this));
        }

        private void button328_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Chicken", 27f, gChicken, this));
        }

        private void button327_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Chicken", 52f, gChicken, this));
        }

        private void button326_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Chicken", 18f, gChicken, this));
        }

        private void button325_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Chicken", 18f, gChicken, this));
        }

        private void button324_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Thai Chicken", 13f, gThaiChicken, this));
        }

        private void button323_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Thai Chicken", 17f, gThaiChicken, this));
        }

        private void button322_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Thai Chicken", 23f, gThaiChicken, this));
        }

        private void button321_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Thai Chicken", 27f, gThaiChicken, this));
        }

        private void button320_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Thai Chicken", 52f, gThaiChicken, this));
        }

        private void button319_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Thai Chicken", 18f, gThaiChicken, this));
        }

        private void button318_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Thai Chicken", 18f, gThaiChicken, this));
        }

        private void button317_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Special", 13f, gSpecial, this));
        }

        private void button316_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Special", 17f, gSpecial, this));
        }

        private void button315_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Special", 23f, gSpecial, this));
        }

        private void button314_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Special", 27f, gSpecial, this));
        }

        private void button313_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Special", 52f, gSpecial, this));
        }

        private void button312_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Special", 18f, gSpecial, this));
        }

        private void button311_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Special", 18f, gSpecial, this));
        }

        private void button310_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Mexicana", 13f, gMexicana, this));
        }

        private void button309_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Mexicana", 17f, gMexicana, this));
        }

        private void button308_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Mexicana", 23f, gMexicana, this));
        }

        private void button307_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Mexicana", 27f, gMexicana, this));
        }

        private void button306_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Mexicana", 52f, gMexicana, this));
        }

        private void button305_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Mexicana", 18f, gMexicana, this));
        }

        private void button304_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Mexicana", 18f, gMexicana, this));
        }

        private void button303_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Gourmet Garlic Prawn", 13f, gGarlicPrawn, this));
        }

        private void button302_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Gourmet Garlic Prawn", 17f, gGarlicPrawn, this));
        }

        private void button301_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Gourmet Garlic Prawn", 23f, gGarlicPrawn, this));
        }

        private void button300_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Gourmet Garlic Prawn", 27f, gGarlicPrawn, this));
        }

        private void button299_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Gourmet Garlic Prawn", 52f, gGarlicPrawn, this));
        }

        private void button298_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Gourmet Garlic Prawn", 18f, gGarlicPrawn, this));
        }

        private void button297_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Gourmet Garlic Prawn", 18f, gGarlicPrawn, this));
        }

        private void button296_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) Satay Chicken", 13f, satayChicken, this));
        }

        private void button295_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) Satay Chicken", 17f, satayChicken, this));
        }

        private void button294_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) Satay Chicken", 23f, satayChicken, this));
        }

        private void button293_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) Satay Chicken", 27f, satayChicken, this));
        }

        private void button292_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) Satay Chicken", 52f, satayChicken, this));
        }

        private void button291_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) Satay Chicken", 18f, satayChicken, this));
        }

        private void button290_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) Satay Chicken", 18f, satayChicken, this));
        }

        private void button289_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Small) El Paso", 13f, elPaso, this));
        }

        private void button288_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large) El Paso", 17f, elPaso, this));
        }

        private void button287_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Family) El Paso", 23f, elPaso, this));
        }

        private void button286_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Party) El Paso", 27f, elPaso, this));
        }

        private void button285_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Jumbo) El Paso", 52f, elPaso, this));
        }

        private void button284_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Calzone) El Paso", 18f, elPaso, this));
        }

        private void button283_Click(object sender, EventArgs e)
        {
            myOrder.AddItem(new Pizza("(Large G Free) El Paso", 18f, elPaso, this));
        }

        private void button381_Click(object sender, EventArgs e)
        {
            orderSummary.Text = "";
            commentPanel.Visible = false;
            summaryPanel.Visible = true;
            // add order deets
            orderSummary.Text += myOrder.ToString();
            // add all the items from myOrder to the orderSummary
            foreach (Item item in myOrder.Items)
            {
                if (item.ItemName == null)
                {
                    continue;
                } else
                {
                    if (item.isModified && item.added.Count > 0 && item.removed.Count > 0)
                    {
                        orderSummary.Text += item.ToString();
                        for (int i = 0; i < item.removed.Count; i++)
                        {
                            orderSummary.Text += "REMOVE -- " + item.removed[i] + Environment.NewLine;
                        }
                        for (int i = 0; i < item.added.Count; i++)
                        {
                            orderSummary.Text += "ADD -- " + item.added[i] + Environment.NewLine;
                        }
                    } else if (item.isModified && item.removed.Count > 0)
                    {
                        orderSummary.Text += item.ToString();
                        for (int i = 0; i < item.removed.Count; i++)
                        {
                            orderSummary.Text += "REMOVE -- " + item.removed[i] + Environment.NewLine;
                        }
                    } else if (item.isModified && item.added.Count > 0)
                    {
                        orderSummary.Text += item.ToString();
                        for (int i = 0; i < item.added.Count; i++)
                        {
                            orderSummary.Text += "ADD -- " + item.added[i] + Environment.NewLine;
                        }
                        
                    }  else
                    {
                        orderSummary.Text += item.ToString();
                    }
                }
            }
            // add a space before total price
            orderSummary.Text += Environment.NewLine;
            if (myOrder.getPrice() % 1 != 0)
            {
                if (myOrder.isDelivery())
                {
                    orderSummary.Text += "Delivery Charge: $5" + Environment.NewLine;
                }
                orderSummary.Text += "Total price: $" + myOrder.getTotalPrice() + "0";
            }
            else
            {
                if (myOrder.isDelivery())
                {
                    orderSummary.Text += "Delivery Charge: $5" + Environment.NewLine;
                }
                orderSummary.Text += "Total price: $" + myOrder.getTotalPrice();
            }

            orderSummary.Text += Environment.NewLine + Environment.NewLine + "Customer Comments: ";

            orderSummary.Text += Environment.NewLine + txComments.Text;

            orderSummary.Text += Environment.NewLine;


        }

        private void button380_Click(object sender, EventArgs e)
        {
            commentPanel.Visible = false;            
        }

        private void gourmetPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
