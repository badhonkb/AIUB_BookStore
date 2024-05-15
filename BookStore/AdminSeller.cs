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
    public partial class AdminSeller : Form
    {
        public bool pass_see = false;
        public bool cursor_on_pass_Box = false;
        public Point mouseLocation;


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");

        public AdminSeller()
        {
            InitializeComponent();
            DataGridViewShow();
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            AdminSeller seller = new AdminSeller();
            seller.Show();
            this.Close();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            AdminBook book = new AdminBook();
            book.Show();
            this.Close();
        }

        private void buttonUser_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SeeReview seereview = new SeeReview();
            seereview.Show();
            this.Close();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            AdminBills bills = new AdminBills();
            bills.Show();
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Enter your name")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;

            }

        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Enter your name";
                textBoxName.ForeColor = Color.Silver;
            }

        }

        private void comboBoxDivision_Enter(object sender, EventArgs e)
        {
            if (comboBoxDivision.Text == "Select Division")
            {
                comboBoxDivision.Text = "";
                comboBoxDivision.ForeColor = Color.Black;
            }
        }

        private void comboBoxDivision_Leave(object sender, EventArgs e)
        {
            if (comboBoxDivision.Text == "")
            {
                comboBoxDivision.Text = "Select Division";
                comboBoxDivision.ForeColor = Color.Silver;
            }
        }

        private void textBoxUserId_Enter(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "Enter your User Id")
            {
                textBoxUserId.Text = "";
                textBoxUserId.ForeColor = Color.Black;
            }
        }

        private void textBoxUserId_Leave(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "Enter your User Id")
            {
                textBoxUserId.Text = "";
                textBoxUserId.ForeColor = Color.Black;
            }
        }

        private void textBoxGmail_Enter(object sender, EventArgs e)
        {
            if (textBoxGmail.Text == "Enter your Gmail")
            {
                textBoxGmail.Text = "";
                textBoxGmail.ForeColor = Color.Black;
            }
        }

        private void textBoxMobileNo_Enter(object sender, EventArgs e)
        {
            if (textBoxMobileNo.Text == "Enter your Mobile No")
            {
                textBoxMobileNo.Text = "";
                textBoxMobileNo.ForeColor = Color.Black;
            }
        }

        private void textBoxMobileNo_Leave(object sender, EventArgs e)
        {
            if (textBoxMobileNo.Text == "")
            {
                textBoxMobileNo.Text = "Enter your Mobile No";
                textBoxMobileNo.ForeColor = Color.Silver;
            }
        }

        private void comboBoxDistrict_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBoxDistrict_Leave(object sender, EventArgs e)
        {
            if (comboBoxDistrict.Text == "" || comboBoxDistrict.Text == "Select Division first" || comboBoxDistrict.Text == "Select Division correctly")
            {
                comboBoxDistrict.Text = "Select District";
                comboBoxDistrict.ForeColor = Color.Silver;
            }
        }

        private void comboBoxDistrict_Enter(object sender, EventArgs e)
        {
            if (comboBoxDistrict.Text == "Select District")
            {
                comboBoxDistrict.Text = "";
                comboBoxDistrict.ForeColor = Color.Black;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxGmail.Text == "" || textBoxMobileNo.Text == "" || textBoxNid.Text == "" || comboBoxDistrict.Text == "" || comboBoxDivision.Text == "" || textBoxUserId.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == "Enter your name" || textBoxGmail.Text == "Enter your Gmail" || textBoxMobileNo.Text == "Enter your mobile no" || comboBoxDistrict.Text == "Select District" || comboBoxDivision.Text == "Select Division" || textBoxUserId.Text == "Enter your UserId" || textBoxPassword.Text == "Enter your Password")
            {
                MessageBox.Show(" Please enter all the datas");
            }
            else
            {
                string gender = radioButtonMale.Checked ? "Male" : "Female";
                SqlCommand cmd = new SqlCommand("insert into [Seller]  (Name,Gender,DOB ,Gmail ,Mobile_No, NID_Birth_Cirtificate_No, Division, District, User_Id, Password) " +
                        "values('" + textBoxName.Text + "','" + gender + "','" + dateTimePicker1.Text + "','" + textBoxGmail.Text + "','" + textBoxMobileNo.Text + "','" + textBoxNid.Text + "','" + comboBoxDivision.Text + "','" + comboBoxDistrict.Text + "','" + textBoxUserId.Text + "','" + textBoxPassword.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registered Succesfully");
                DataGridViewShow();


                textBoxName.Text = "Enter your Name";
                textBoxName.ForeColor = Color.Silver;

                textBoxGmail.Text = "Enter your Gmail";
                textBoxGmail.ForeColor = Color.Silver;


                textBoxMobileNo.Text = "Enter your Mobile No";
                textBoxMobileNo.ForeColor = Color.Silver;

                textBoxNid.Text = "Enter your NID no / Birth cirtificate no";
                textBoxNid.ForeColor = Color.Silver;

                comboBoxDivision.Text = "Select Division";
                comboBoxDivision.ForeColor = Color.Silver;

                comboBoxDistrict.Text = "Select District";
                comboBoxDistrict.ForeColor = Color.Silver;

                textBoxUserId.Text = "Enter your User Id";
                textBoxUserId.ForeColor = Color.Silver;

                textBoxPassword.Text = "Enter your Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Silver;

                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;

                if (pass_see == true)
                {
                    Icn_PicBox_Eye.IconChar = IconChar.Eye;
                    labelShowPassword.Text = "Show password";
                    pass_see = false;

                }
            }
            }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine gender based on radio button selection
                string gender = radioButtonMale.Checked ? "Male" : "Female";

                // Open the connection
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True"))
                {
                    conn.Open();

                    // Prepare the SQL command with parameters
                    string query = @"UPDATE [Seller] 
                             SET Name = @Name, 
                                 Gender = @Gender, 
                                 DOB = @DOB, 
                                 Gmail = @Gmail, 
                                 Mobile_No = @MobileNo, 
                                 NID_Birth_Cirtificate_No = @NID, 
                                 Division = @Division, 
                                 District = @District, 
                                 Password = @Password 
                             WHERE User_Id = @UserId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add the parameters with their respective values
                        cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.ToString("yyyy-MM-dd")); // Use date format for DOB
                        cmd.Parameters.AddWithValue("@Gmail", textBoxGmail.Text);
                        cmd.Parameters.AddWithValue("@MobileNo", textBoxMobileNo.Text);
                        cmd.Parameters.AddWithValue("@NID", textBoxNid.Text);
                        cmd.Parameters.AddWithValue("@Division", comboBoxDivision.Text);
                        cmd.Parameters.AddWithValue("@District", comboBoxDistrict.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@UserId", textBoxUserId.Text);

                        // Execute the query and get the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check the result and display a message
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data has been edited successfully");
                            DataGridViewShow(); // Refresh DataGridView after successful update
                        }
                        else
                        {
                            MessageBox.Show("No records were edited");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



            /* try
             {
                 string gender = radioButtonMale.Checked ? "Male" : "Female";
                 conn.Open();
                 SqlCommand cmd = new SqlCommand("UPDATE [Seller] SET Name='" + textBoxName.Text + "',Gender='" + gender + "', DOB='" + dateTimePicker1.Text + "', Gmail='" + textBoxGmail.Text + "',  Mobile_No='" + textBoxMobileNo.Text + "',  NID_Birth_Cirtificate_No='" + textBoxNid.Text +"' Division = '" + comboBoxDivision.Text + "' District = '" + comboBoxDistrict.Text + "' Password = '" + textBoxPassword.Text + "' WHERE User_Id = '" + textBoxUserId + "'", conn);

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
             }*/
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [Seller] WHERE User_Id = '" + textBoxUserId.Text + "'", conn);
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
            textBoxName.Text = "Enter your Name";

            textBoxGmail.Text = "Enter your Gmail";

            textBoxMobileNo.Text = "Enter your Mobile No";

            comboBoxDivision.Text = "Select Division";

            comboBoxDistrict.Text = "Select District";

            textBoxUserId.Text = "Enter your User Id";

            textBoxPassword.Text = "Enter your Password";
            textBoxNid.Text = "Enter your NID no";
            textBoxPassword.UseSystemPasswordChar = false;

            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;

            if (pass_see == true)
            {

                Icn_PicBox_Eye.IconChar = IconChar.Eye;
                labelShowPassword.Text = "Show password";
                pass_see = false;

            }
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void guna2DataGridViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();

            radioButtonMale.Checked = true;
            radioButtonFemale.Checked = false;
            if (guna2DataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString() == "Female")
            {
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = true;
            }

            if (DateTime.TryParse(guna2DataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString(), out DateTime date))
            {
                dateTimePicker1.Value = date;
            }
            else
            {

                dateTimePicker1.Value = DateTime.Today;
            }

            textBoxGmail.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();

            textBoxMobileNo.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();

            textBoxNid.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[5].Value.ToString();

            comboBoxDivision.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[6].Value.ToString();

            comboBoxDistrict.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[7].Value.ToString();

            textBoxUserId.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[8].Value.ToString();

            textBoxPassword.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[9].Value.ToString();

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
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

        private void textBoxNid_Enter(object sender, EventArgs e)
        {
            if (textBoxNid.Text == "Enter your NID no")
            {
                textBoxNid.Text = "";
                textBoxNid.ForeColor = Color.Black;
            }
        }

        private void textBoxNid_Leave(object sender, EventArgs e)
        {
            if (textBoxNid.Text == "")
            {
                textBoxNid.Text = "Enter your NID no";
                textBoxNid.ForeColor = Color.Silver;
            }
        }

        private void textBoxGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGmail_Leave(object sender, EventArgs e)
        {
            if (textBoxGmail.Text == "")
            {
                textBoxGmail.Text = "Enter your Gmail";
                textBoxGmail.ForeColor = Color.Silver;
            }
        }

        private void AdminSeller_Load(object sender, EventArgs e)
        {

        }
        private void DataGridViewShow()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Seller]", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridViewUser.DataSource = dataTable;
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

        private void guna2DataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();

            radioButtonMale.Checked = true;
            radioButtonFemale.Checked = false;
            if (guna2DataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString() == "Female")
            {
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = true;
            }

            if (DateTime.TryParse(guna2DataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString(), out DateTime date))
            {
                dateTimePicker1.Value = date;
            }
            else
            {

                dateTimePicker1.Value = DateTime.Today;
            }

            textBoxGmail.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();

            textBoxMobileNo.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();

            textBoxNid.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[5].Value.ToString();

            comboBoxDivision.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[6].Value.ToString();

            comboBoxDistrict.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[7].Value.ToString();

            textBoxUserId.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[8].Value.ToString();

            textBoxPassword.Text = guna2DataGridViewUser.Rows[e.RowIndex].Cells[9].Value.ToString();

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;

        }

        
    }
}
