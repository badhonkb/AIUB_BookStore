using Guna.UI2.WinForms;
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
    public partial class SeeReview : Form
    {
        string connectionStr = @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";
        public SeeReview()
        {
            InitializeComponent();
        }





        private void guna2DataGridViewBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming you have a connection to the database
            // Replace connectionStr with your actual connection string
            string connectionStr = @"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // Open the connection
                connection.Open();

                // SQL query to select all data from BuyerReview table
                string query = "SELECT UserID, Name, Comments FROM BuyerReview";

                // Create a new SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a new DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Create a new SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataTable with data from the SQL query
                        adapter.Fill(dataTable);
                    }

                    // Set the DataSource of the DataGridView to the DataTable
                    guna2DataGridViewBookDetails.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStr))
            {
                // Open the connection
                sqlcon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BuyerReview", sqlcon);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                guna2DataGridViewBookDetails.DataSource = dtbl;

            }

        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {

            AdminBook a = new AdminBook();
            a.Show();
            this.Close();
        }
    }
}
