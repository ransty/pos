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
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pls commit xx
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
            // move to orderPanel
            orderPanel.Visible = true;
        }

        private void pnl2BackBtn_Click(object sender, EventArgs e)
        {
            // make orderPanel invisible
            orderPanel.Visible = false;
        }

        private void mealDealPanel_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
