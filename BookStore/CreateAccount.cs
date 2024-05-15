using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void iconButtonBuyer_Click(object sender, EventArgs e)
        {
            BuyerRegistration buyer = new BuyerRegistration();
            buyer.Show();
            this.Close();
        }

        private void iconButtonSeller_Click(object sender, EventArgs e)
        {
            SellerRegistration seller = new SellerRegistration();
            seller.Show(); 
            this.Close();
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
