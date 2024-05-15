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
    public partial class BuyerHome : Form
    {
        SqlConnection conn = new SqlConnection (@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");
        int ID;
        public BuyerHome()
        {
            InitializeComponent();
            DataGridViewShow();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void BuyerHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            BuyerBill bill = new BuyerBill();
            bill.Show();
            this.Close();
        }

        private void BtnGiveReview_Click_1(object sender, EventArgs e)
        {
            Give_Review givereview = new Give_Review();
            givereview.Show();
            this.Close();
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

        private void textBoxAuthorName_Enter(object sender, EventArgs e)
        {
            if (textBoxAuthorName.Text == "Enter Author Name")
            {
                textBoxAuthorName.Text = "";
            }
        }

        private void textBoxAuthorName_Leave(object sender, EventArgs e)
        {
            if (textBoxAuthorName.Text == "")
            {
                textBoxAuthorName.Text = "Enter Author Name";
            }
        }

        private void comboBoxCategory_Enter(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "Category")
            {
                comboBoxCategory.Text = "";
            }
        }

        private void comboBoxCategory_Leave(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "")
            {
                comboBoxCategory.Text = "Category";
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "Enter Book Price")
            {
                textBoxPrice.Text = "";
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.Text = "Enter Book Price";
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBookTitle.Text == "" || textBoxAuthorName.Text == "" || comboBoxCategory.Text == "" || textBoxQuantity.Text == "" || textBoxPrice.Text == "" || textBoxBookTitle.Text == "Enter Book Title " || textBoxAuthorName.Text == "Enter Author Name" || comboBoxCategory.Text == "Category" || textBoxQuantity.Text == "Enter Book Quantity" || textBoxPrice.Text == "Enter Book Prize")
            {
                MessageBox.Show("Please enter all the data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into [BookInfo]  (Title, Author_Name, Category,  Quantity, Price ) " +
                        "values('" + textBoxBookTitle.Text + "','" + textBoxAuthorName.Text + "','" + comboBoxCategory.Text + "','" + textBoxQuantity.Text + "','" + textBoxPrice.Text + "')", conn);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Book Added Successfully");
                    DataGridViewShow();


                    textBoxBookTitle.Text = "Enter Book Title ";
                    textBoxAuthorName.Text = "Enter Author Name";
                    comboBoxCategory.Text = "Category";
                    textBoxQuantity.Text = "Enter Book Quantity";
                    textBoxPrice.Text = "Enter Book Prize";
                    //textBoxBookPicture.Text = "Enter Book Picture";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [BookInfo] SET Title='" + textBoxBookTitle.Text + "',Author_Name='" + textBoxAuthorName.Text + "', Category='" + comboBoxCategory.Text + "', Quantity='" + textBoxQuantity.Text + "',  Price='" + textBoxPrice.Text + "' WHERE Book_ID = '" + ID + "'", conn);

                int rowsAffected = cmd.ExecuteNonQuery(); // Execute the query and get the number of rows affected
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data has been Edited successfully");
                    DataGridViewShow(); // Refresh DataGridView after successful update
                }
                else
                {
                    MessageBox.Show("No records were Edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [BookInfo] WHERE Book_ID = '" + ID + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your Record has beem Deleted");
                DataGridViewShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxBookTitle.Text = "Enter your Name";

            textBoxAuthorName.Text = "Enter Author Name";

            comboBoxCategory.Text = "Category";

            textBoxQuantity.Text = "Enter Book Quantity";

            textBoxPrice.Text = "Enter Book Prize";

            // textBoxBookPicture.Text = "Enter Book Picture";
        }

        private void button3_Click_1(object sender, EventArgs e)//search button
        {
            // Get the search keyword from textBox1
            string searchKeyword = textBox1.Text.Trim();

            // Perform the database query
            string connectionString = @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";
            string query = @"SELECT * 
                     FROM [BookInfo] 
                     WHERE Book_ID LIKE @Keyword
                     OR Title LIKE @Keyword
                     OR Author_Name LIKE @Keyword
                     OR Category LIKE @Keyword
                     OR CAST(Quantity AS VARCHAR) LIKE @Keyword
                     OR CAST(Price AS VARCHAR) LIKE @Keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear any previous search results by setting the DataSource to null
                        guna2DataGridViewBookDetails.DataSource = null;

                        // Create a DataTable to hold the search results
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Bind the DataTable to the DataGridView
                        guna2DataGridViewBookDetails.DataSource = dataTable;
                    }
                }
            }
        }

        private void comboBoxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxFilterCategory.Text;

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [BookInfo] WHERE Category = @Category", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Category", selectedCategory);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    guna2DataGridViewBookDetails.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }

        private void DataGridViewShow()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [BookInfo]", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridViewBookDetails.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void guna2DataGridViewBookDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxBookTitle.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAuthorName.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxCategory.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxQuantity.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPrice.Text = guna2DataGridViewBookDetails.Rows[e.RowIndex].Cells[5].Value.ToString();

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }
    }
}
