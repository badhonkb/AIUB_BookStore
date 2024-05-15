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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void iconButtonLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void iconButtonCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            labelWelcome.BackColor=Color.Transparent;
            labelDontHave.BackColor=Color.Transparent;
        }
    }
}
