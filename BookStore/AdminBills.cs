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
    public partial class AdminBills : Form
    {
        public AdminBills()
        {
            InitializeComponent();
        }

        private void textBoxBookTitle_Enter(object sender, EventArgs e)
        {
            if (textBoxBookTitle.Text == "Enter Book Title ")
            {
                textBoxBookTitle.Text = "";
            }
        }

        private void textBoxBookTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxBookTitle.Text == "")
            {
                textBoxBookTitle.Text = "Enter Book Title ";
            }
        }

        private void textBoxClientName_Enter(object sender, EventArgs e)
        {
            if (textBoxClientName.Text == "Enter Client Name")
            {
                textBoxClientName.Text = "";
            }
        }

        private void textBoxClientName_Leave(object sender, EventArgs e)
        {
            if (textBoxClientName.Text == "")
            {
                textBoxClientName.Text = "Enter Client Name";
            }
        }

        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "Enter Book Quantity")
            {
                textBoxQuantity.Text = "";
            }
        }

        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "")
            {
                textBoxQuantity.Text = "Enter Book Quantity";
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "Enter Book Prize")
            {
                textBoxPrice.Text = "";
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.Text = "Enter Book Prize";
            }
        }

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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeeReview seereview = new SeeReview();
            seereview.Show();
            this.Close();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {

        }

        private void labelUserDetails_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void Reset()

        {

            textBoxBookTitle.Text = "Enter Book Title ";

            textBoxClientName.Text = "Enter Client Name";

            textBoxQuantity.Text = "Enter Book Quantity";

            textBoxPrice.Text = "Enter Book Prize";
        }

        private void AdminBills_Load(object sender, EventArgs e)
        {
            //labelCurrentUser.Text = LogIn.User_Id;
            DisplayBooks();
            guna2DataGridViewBookDetails.ScrollBars = ScrollBars.Both;
        }
        int n = 0, GrandTotal = 0;

      private  void UpdateBooks()
        {
            int NewQuantity = Stock - Convert.ToInt32(textBoxQuantity.Text);
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

                    guna2DataGridViewBookDetails.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void guna2DataGridViewBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxBookTitle.Text = guna2DataGridViewBookDetails.SelectedRows[0].Cells[1].Value.ToString();

            textBoxPrice.Text = guna2DataGridViewBookDetails.SelectedRows[0].Cells[5].Value.ToString(); if (textBoxBookTitle.Text == "")

            {

                Key = 0;

                Stock = 0;

            }

            else

            {

                Key = Convert.ToInt32(guna2DataGridViewBookDetails.SelectedRows[0].Cells[0].Value.ToString()); Stock = Convert.ToInt32(guna2DataGridViewBookDetails.SelectedRows[0].Cells[4].Value.ToString());

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int Key = 0, Stock = 0;
        

        private void Btncash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2DataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string ProdName;
        int Prodid, ProdQty, ProdPrice, Total, Pos = 60;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int Pos = 60;  // Initialize Pos to set the starting vertical position

            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80, 10));
            e.Graphics.DrawString("ID Product Price Quantity Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in guna2DataGridViewBill.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                int Prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                string ProdName = "" + row.Cells["Column2"].Value;
                int ProdPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                int ProdQty = Convert.ToInt32(row.Cells["Column4"].Value);
                int Total = Convert.ToInt32(row.Cells["Column5"].Value);

                // Print each cell in the current row
                e.Graphics.DrawString("" + Prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, Pos));
                e.Graphics.DrawString("" + ProdName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, Pos));
                e.Graphics.DrawString("" + ProdPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, Pos));
                e.Graphics.DrawString("" + ProdQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, Pos));
                e.Graphics.DrawString("" + Total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, Pos));

                Pos += 20; // Increment Pos to move to the next line
            }

            // Print the grand total
            e.Graphics.DrawString("Grand Total: TK" + GrandTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, Pos + 30));
            e.Graphics.DrawString("*****Book Store*****", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, Pos + 65));

            guna2DataGridViewBill.Rows.Clear();
            guna2DataGridViewBill.Refresh();

            GrandTotal = 0; // Reset the grand total
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");

            if (textBoxBookTitle.Text == "" || textBoxQuantity.Text == "" || textBoxClientName.Text == "" || textBoxPrice.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    con.Open();
                    // string query = "INSERT INTO BillsTbl (Username, ClientName, Amount) VALUES (@Username, @ClientName, @Amount)";
                    string query = "INSERT INTO Bill values('" + labelCurrentUser.Text + "','" + textBoxClientName.Text + "'," + GrandTotal + " )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    //cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(textBoxQuantity.Text) * Convert.ToInt32(textBoxPrice.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprne", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void buttonAddToBill_Click(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "" || Convert.ToInt32(textBoxQuantity.Text) > Stock)

            {

                MessageBox.Show("No Enough Stock Available");

            }
            else

            {

                int total = Convert.ToInt32(textBoxQuantity.Text) * Convert.ToInt32(textBoxPrice.Text);

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(guna2DataGridViewBill);

                newRow.Cells[0].Value = n + 1;

                newRow.Cells[1].Value = textBoxBookTitle.Text;

                newRow.Cells[3].Value = textBoxQuantity.Text;

                newRow.Cells[2].Value = textBoxPrice.Text;

                newRow.Cells[4].Value = total;



                guna2DataGridViewBill.Rows.Add(newRow);

                n++;

                UpdateBooks();
                GrandTotal = GrandTotal + total;
                labelTotalAmount.Text = "TK= " + GrandTotal;
            }

            // int Prodid, ProdQty, ProdPrice, Total, Pos = 60;



        }
    }
}
