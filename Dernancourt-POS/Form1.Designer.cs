namespace Dernancourt_POS
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.customerAddressTxt = new System.Windows.Forms.TextBox();
            this.customerSuburbTxt = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.suburbLbl = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTxt.Location = new System.Drawing.Point(229, 38);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(230, 29);
            this.customerNameTxt.TabIndex = 0;
            this.customerNameTxt.TextChanged += new System.EventHandler(this.customerNameTxt_TextChanged);
            // 
            // customerPhoneNumberTxt
            // 
            this.customerPhoneNumberTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumberTxt.Location = new System.Drawing.Point(229, 104);
            this.customerPhoneNumberTxt.Name = "customerPhoneNumberTxt";
            this.customerPhoneNumberTxt.Size = new System.Drawing.Size(230, 29);
            this.customerPhoneNumberTxt.TabIndex = 1;
            this.customerPhoneNumberTxt.TextChanged += new System.EventHandler(this.customerPhoneNumberTxt_TextChanged);
            // 
            // customerAddressTxt
            // 
            this.customerAddressTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTxt.Location = new System.Drawing.Point(229, 158);
            this.customerAddressTxt.Name = "customerAddressTxt";
            this.customerAddressTxt.Size = new System.Drawing.Size(230, 29);
            this.customerAddressTxt.TabIndex = 2;
            this.customerAddressTxt.TextChanged += new System.EventHandler(this.customerAddressTxt_TextChanged);
            // 
            // customerSuburbTxt
            // 
            this.customerSuburbTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerSuburbTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSuburbTxt.Location = new System.Drawing.Point(229, 238);
            this.customerSuburbTxt.Name = "customerSuburbTxt";
            this.customerSuburbTxt.Size = new System.Drawing.Size(230, 29);
            this.customerSuburbTxt.TabIndex = 3;
            this.customerSuburbTxt.TextChanged += new System.EventHandler(this.customerSuburbTxt_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(510, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackSalesToolStripMenuItem,
            this.reviewOrdersToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // trackSalesToolStripMenuItem
            // 
            this.trackSalesToolStripMenuItem.Name = "trackSalesToolStripMenuItem";
            this.trackSalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trackSalesToolStripMenuItem.Text = "Track Sales";
            // 
            // reviewOrdersToolStripMenuItem
            // 
            this.reviewOrdersToolStripMenuItem.Name = "reviewOrdersToolStripMenuItem";
            this.reviewOrdersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reviewOrdersToolStripMenuItem.Text = "Review Orders";
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(28, 41);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(65, 24);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Name";
            this.nameLbl.Click += new System.EventHandler(this.nameLbl_Click);
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(28, 107);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(152, 24);
            this.phoneNumberLbl.TabIndex = 6;
            this.phoneNumberLbl.Text = "Phone Number";
            this.phoneNumberLbl.Click += new System.EventHandler(this.phoneNumberLbl_Click);
            // 
            // addressLbl
            // 
            this.addressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(28, 161);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(87, 24);
            this.addressLbl.TabIndex = 7;
            this.addressLbl.Text = "Address";
            this.addressLbl.Click += new System.EventHandler(this.addressLbl_Click);
            // 
            // suburbLbl
            // 
            this.suburbLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.suburbLbl.AutoSize = true;
            this.suburbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbLbl.Location = new System.Drawing.Point(28, 241);
            this.suburbLbl.Name = "suburbLbl";
            this.suburbLbl.Size = new System.Drawing.Size(78, 24);
            this.suburbLbl.TabIndex = 8;
            this.suburbLbl.Text = "Suburb";
            this.suburbLbl.Click += new System.EventHandler(this.suburbLbl_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 551);
            this.Controls.Add(this.suburbLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.customerSuburbTxt);
            this.Controls.Add(this.customerAddressTxt);
            this.Controls.Add(this.customerPhoneNumberTxt);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dernancourt POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.TextBox customerPhoneNumberTxt;
        private System.Windows.Forms.TextBox customerAddressTxt;
        private System.Windows.Forms.TextBox customerSuburbTxt;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewOrdersToolStripMenuItem;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label suburbLbl;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

