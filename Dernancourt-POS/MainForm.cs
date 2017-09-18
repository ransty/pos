using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernancourt_POS
{
    public partial class mainForm : Form
    {
        Order myOrder;

        /* INSTANCE ITEMS */
        Item pastaDeal = new Item() { ItemID = 1, ItemName = "Pasta Deal", ItemPrice = 19.90f };
        Item footyDeal = new Item() { ItemID = 2, ItemName = "Footy Special Deal", ItemPrice = 36.90f };
        Item largeDeal = new Item() { ItemID = 3, ItemName = "Large Deal", ItemPrice = 19.90f };
        Item familyDeal = new Item() { ItemID = 4, ItemName = "Family Deal", ItemPrice = 25.90f };
        Item partyDeal = new Item() { ItemID = 5, ItemName = "Party Deal", ItemPrice = 29.90f };
        Item largeTwoDeal = new Item() { ItemID = 6, ItemName = "2 Large Pizza Deal w/ GB and Drink", ItemPrice = 31.90f };
        Item familyTwoDeal = new Item() { ItemID = 7, ItemName = "2 Family Pizza Deal w/ GB and Drink", ItemPrice = 44.90f };
        Item partyTwoDeal = new Item() { ItemID = 8, ItemName = "2 Party Pizza Deal w/ GB and Drink", ItemPrice = 55.90f };
        Item largeTwo = new Item() { ItemID = 9, ItemName = "2 Large Pizzas", ItemPrice = 23.50f };
        Item familyTwo = new Item() { ItemID = 10, ItemName = "2 Family Pizzas", ItemPrice = 36.50f };
        Item partyTwo = new Item() { ItemID = 11, ItemName = "2 Party Pizzas", ItemPrice = 43.50f };
        Item gbTwo = new Item() { ItemID = 12, ItemName = "2 x Garlic Bread", ItemPrice = 6.00f };
        Item drinkTwo = new Item() { ItemID = 13, ItemName = "2 x 1.25L Soft Drink", ItemPrice = 8.00f }; 



        public mainForm()
        {
            InitializeComponent();
            //Order order = new Order();
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
            myOrder.AddItem(pastaDeal);
        }
    }
}
