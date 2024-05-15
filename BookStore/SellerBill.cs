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
using System.Windows.Input;

namespace BookStore
{
    public partial class SellerBill : Form
    {
        public SellerBill()
        {
            InitializeComponent();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            SellerHome home = new SellerHome();
            home.Show();
            this.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void Reset()

        {

            textBox3.Text = "Enter Book Title ";

            textBox4.Text = "Enter Client Name";

            textBox2.Text = "Enter Book Quantity";

            textBox1.Text = "Enter Book Prize";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || Convert.ToInt32(textBox2.Text) > Stock)

            {

                MessageBox.Show("No Enough Stock Available");

            }
            else

            {

                int total = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text);

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(guna2DataGridView1);

                newRow.Cells[0].Value = n + 1;

                newRow.Cells[1].Value = textBox3.Text;

                newRow.Cells[3].Value = textBox2.Text;

                newRow.Cells[2].Value = textBox1.Text;

                newRow.Cells[4].Value = total;



                guna2DataGridView1.Rows.Add(newRow);

                n++;

                UpdateBooks();
                GrandTotal = GrandTotal + total;
                label2.Text = "TK= " + GrandTotal;
            }

            // int Prodid, ProdQty, ProdPrice, Total, Pos = 60;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int n = 0, GrandTotal = 0;

        private void UpdateBooks()
        {
            int NewQuantity = Stock - Convert.ToInt32(textBox2.Text);
            try
            {
                // Update the connection string with your SQL Server details
                string connectionString = (@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Use parameterized query to prevent SQL injection
                    string query = "UPDATE BookInfo SET Quantity = @NewQuantity WHERE Book_ID = @Key;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NewQuantity", NewQuantity);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                }

                // Refresh the DataGridView
                DisplayBooks();
                // Reset input fields
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int Key = 0, Stock = 0;
        int Prodid, ProdQty, ProdPrice, Total, Pos = 60;

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DisplayBooks()
        {
            string connectionString = @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM BookInfo"; // Assuming the table name is BooksTbl
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                    var ds = new DataSet();
                    sda.Fill(ds);

                    guna2DataGridView2.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = guna2DataGridView2.SelectedRows[0].Cells[1].Value.ToString();

            textBox1.Text = guna2DataGridView2.SelectedRows[0].Cells[5].Value.ToString(); if (textBox3.Text == "")

            {

                Key = 0;

                Stock = 0;

            }

            else

            {

                Key = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value.ToString()); Stock = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[4].Value.ToString());

            }
        }

        private void SellerBill_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            guna2DataGridView2.ScrollBars = ScrollBars.Both;
        }





    }
  }

