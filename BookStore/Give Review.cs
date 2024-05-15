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
    public partial class Give_Review : Form
    {
        public Give_Review()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //  @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=""Book_Store"";Integrated Security=True";


            
                // Get the values from the textboxes
                string userID = textboxuid.Text;
                string name = textboxname.Text;
                string comments = Textboxcomments.Text;

            // Connection string to connect to your SQL Server
            string connectionString = @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";

            // SQL query to insert data into the table
            string query = "INSERT INTO BuyerReview (UserID, Name, Comments) VALUES (@UserID, @Name, @Comments)";

                try
                {
                    // Create a SqlConnection using the connection string
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SqlCommand with the query and connection
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the command
                            command.Parameters.AddWithValue("@UserID", userID);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Comments", comments);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if rows were affected
                            if (rowsAffected > 0)
                            {
                                // Show a message
                                MessageBox.Show("Thanks For Review! We will strive to improve our service.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the textboxes
                                textboxuid.Text = "";
                                textboxname.Text = "";
                                Textboxcomments.Text = "";
                            }
                            else
                            {
                                // Show an error message if no rows were affected
                                MessageBox.Show("Failed to submit review. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if an exception occurs
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            BuyerBill b= new BuyerBill();
            b.Show();
            this.Close();
        }

        private void labelUID_Click(object sender, EventArgs e)
        {

        }
    }
}
