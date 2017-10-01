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
            summaryPanel.Visible = false;
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
            myOrder.AddItem(new Item() { ItemID = 1, ItemName = "Pasta Deal", ItemPrice = 19.90f });
        }

        private void mealDealPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2NextBtn_Click(object sender, EventArgs e)
        {
            summaryPanel.Visible = true;
            // add order deets
            orderSummary.Text += myOrder.ToString();
            // add all the items from myOrder to the orderSummary
            foreach (Item item in myOrder.Items) {
                orderSummary.Text += item.ToString() + Environment.NewLine;
            }
            // add a space before total price
            orderSummary.Text += Environment.NewLine;
            if (myOrder.getPrice() % 1 != 0)
            {
                orderSummary.Text += "Total price: $"  + myOrder.getTotalPrice() + "0";
            } else
            {
                orderSummary.Text += "Total price: $" + myOrder.getTotalPrice();
            }
            
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
    }
}
