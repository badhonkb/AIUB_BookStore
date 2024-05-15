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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");
        private void buttonBook_Click(object sender, EventArgs e)
        {
            AdminBook book = new AdminBook();
            book.Show();
            this.Close();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AdminUsers adminUsers = new AdminUsers();
            adminUsers.Show();
            this.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            AdminBills bills = new AdminBills();
            bills.Show();
            this.Close();
        }
        private void TotalBooks()
        {
            Con.Open();
            SqlDataAdapter sda= new SqlDataAdapter("select sum(Quantity) from BookInfo", Con);

            DataTable dt =new DataTable();
            sda.Fill(dt);
            labelTotalStock.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void TotalUsers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(Name) from Seller", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelTotalUser.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void TotalAmount()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Amount) from Bill", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            labeltotalAmount.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void labelTotalStock_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeeReview seereview = new SeeReview();
            seereview.Show();
            this.Close();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            TotalBooks();
            TotalAmount();
            TotalUsers();
        }
    }
}
