using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class LogIn : Form
    {
        public bool pass_see = false;
        public bool cursor_on_pass_Box = false;
        string userType;

        private const string conn = @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";
        public LogIn()
        {
            InitializeComponent();
            textBoxUserId.Focus();
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void iconButtonClear_Click(object sender, EventArgs e)
        {
            textBoxUserId.Text = "Enter your user ID";
            textBoxUserId.ForeColor = Color.Silver;


            textBoxPassword.Text = "Enter your Password";
            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.ForeColor = Color.Silver;

            if (pass_see == true)
            {
                Icn_PicBox_Eye.IconChar = IconChar.Eye;
                labelShowPassword.Text = "Show password";
                pass_see = false;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            labelLogin.BackColor = Color.Transparent;
            labelID.BackColor = Color.Transparent;
            labelPassword.BackColor = Color.Transparent;
            linkLabelForgetPassword.BackColor = Color.Transparent;
        }

        private void Icn_PicBox_Eye_Click(object sender, EventArgs e)
        {
            if (pass_see == false && cursor_on_pass_Box == false)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                Icn_PicBox_Eye.IconChar = IconChar.Eye;
                labelShowPassword.Text = "Show password";
                pass_see = false;
            }
            else if (pass_see == false && cursor_on_pass_Box == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                Icn_PicBox_Eye.IconChar = IconChar.EyeSlash;
                labelShowPassword.Text = "Hide password";
                pass_see = true;
            }
            else if (pass_see == true)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                Icn_PicBox_Eye.IconChar = IconChar.Eye;
                labelShowPassword.Text = "Show password";
                pass_see = false;
            }
        }

        private void labelShowPassword_Click(object sender, EventArgs e)
        {
            if (pass_see == false && cursor_on_pass_Box == false)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                Icn_PicBox_Eye.IconChar = IconChar.Eye;
                labelShowPassword.Text = "Show password";
                pass_see = false;
            }
            else if (pass_see == false && cursor_on_pass_Box == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                Icn_PicBox_Eye.IconChar = IconChar.EyeSlash;
                labelShowPassword.Text = "Hide password";
                pass_see = true;
            }
            else if (pass_see == true)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                Icn_PicBox_Eye.IconChar = IconChar.Eye;
                labelShowPassword.Text = "Show password";
                pass_see = false;
            }
        }

        private void textBoxUserId_Enter(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "Enter your user ID")
            {
                textBoxUserId.Text = "";

                textBoxUserId.ForeColor = Color.Black;
            }
        }

        private void textBoxUserId_Leave(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "")
            {
                textBoxUserId.Text = "Enter your user ID";

                textBoxUserId.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter your Password")
            {
                textBoxPassword.Text = "";

                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
                cursor_on_pass_Box = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Enter your Password";

                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Silver;
                cursor_on_pass_Box = false;
            }
        }


        private void linkLabelForgetPassword_Click(object sender, EventArgs e)
        {
            
            if (textBoxUserId.Text == "Enter your user ID" || textBoxUserId.Text == "")
            {
                MessageBox.Show("Please enter your ID");
            }
            else
            {
                string userID = textBoxUserId.Text;
                string password = textBoxPassword.Text;

                if (CheckIfUserIDExists(userID))
                {
                    ForgetPassword forgetPassword=new ForgetPassword (userID,userType);
                    this.Hide();
                    forgetPassword.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The entered USer ID is not available, please enter a registered User ID");
                }
            }
            

        }


        private bool CheckIfUserIDExists(string userID)
        {
            bool userIDExists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    // Query for Seller
                    string sellerQuery = "SELECT * FROM [Seller] WHERE UPPER(User_Id) = UPPER(@UserID)";
                    SqlDataAdapter sellerAdapter = new SqlDataAdapter(sellerQuery, connection);
                    sellerAdapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataTable sellerTable = new DataTable();
                    sellerAdapter.Fill(sellerTable);

                    // Query for Buyer
                    string buyerQuery = "SELECT * FROM [Buyer] WHERE UPPER(User_Id) = UPPER(@UserID)";
                    SqlDataAdapter buyerAdapter = new SqlDataAdapter(buyerQuery, connection);
                    buyerAdapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataTable buyerTable = new DataTable();
                    buyerAdapter.Fill(buyerTable);

                    // Query for  Admin
                    string adminQuery = "SELECT * FROM [Admin] WHERE UPPER(User_Id) = UPPER(@UserID)";
                    SqlDataAdapter adminAdapter = new SqlDataAdapter(adminQuery, connection);
                    adminAdapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataTable adminTable = new DataTable();
                    adminAdapter.Fill(buyerTable);

                    // Check if any table has rows (indicating user exists)
                    userIDExists = (sellerTable.Rows.Count > 0) || (buyerTable.Rows.Count > 0) || (adminTable.Rows.Count > 0);

                    // If no rows found in any table, display error message
                    if (!userIDExists)
                    {
                        MessageBox.Show("Invalid user ID. Please reenter ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, or throw it further up the call stack.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userIDExists;
        }



        private void iconButtonLogIn_Click(object sender, EventArgs e)
        {
            string userID = textBoxUserId.Text;
            string password = textBoxPassword.Text;

            if (CheckIfUserIDExists(userID))
            {
                if (IsBuyer(userID,password))
                {
                    OpenBuyerBill(userID,password);
                }
                else if (IsSeller(userID,password))
                {
                    OpenSellerPanel(userID, password);
                }
                else if (IsAdmin(userID, password))
                {
                    OpenAdminPanel(userID, password);
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid. Please try again.");
            }
        }

        private bool IsSeller(string userID,string password)
        {
            bool isSeller = false;

            string query = "SELECT * FROM [Seller] WHERE User_Id = @UserID AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        isSeller = true;
                    }
                }
            }
            return isSeller;

        }

        private void OpenSellerPanel(string userID, string password)
        {
            SellerHome sellerHome = new SellerHome();
            this.Hide();
            sellerHome.ShowDialog();
        }



        private bool IsBuyer(string userID,string password)
        {
            bool isBuyer = false;

            string query = "SELECT * FROM [Buyer] WHERE User_Id = @UserID AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        isBuyer = true;
                    }
                }
            }

            return isBuyer;
        }

        private void OpenBuyerBill(string userID, string password)
        {
            BuyerBill buyerBill = new BuyerBill();
            this.Hide();
            buyerBill.ShowDialog();
        }

        private bool IsAdmin(string userID, string password)
        {
            bool isAdmin = false;

            string query = "SELECT * FROM [Admin] WHERE User_Id = @UserID AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        isAdmin = true;
                    }
                }
            }

            return isAdmin;
        }

        private void OpenAdminPanel(string userID, string password)
        {
           AdminBook adminHome = new AdminBook();
            adminHome.Show();
            this.Hide();
        }
      
    }
}
