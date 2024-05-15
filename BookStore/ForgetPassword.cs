using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookStore
{
    public partial class ForgetPassword : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");
        private string verificationCode;
        private string userType;


        public ForgetPassword(string userID, string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void button_sendCode_Click(object sender, EventArgs e)
        {
            string email = textBox_gmail.Text;


            if (!EmailExists(email))
            {
                MessageBox.Show("Email not found in the database.");
                return;
            }


            verificationCode = GenerateVerificationCode();


            SendVerificationCodeByEmail(email, verificationCode);
        }

        private void SendVerificationCodeByEmail(string email, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("badhonk998@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Verification Code for Book Store Login: ";
                mail.Body = "Your verification code is: " + code;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("badhonk998@gmail.com", "vcyabeepbulyzvez");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Debug.WriteLine("Email sent successfully.");
                MessageBox.Show("Verification code sent to your email.");
            }
            catch (SmtpException ex)
            {
                Debug.WriteLine("Failed to send email: " + ex.StatusCode + " - " + ex.Message);
                MessageBox.Show("Failed to send email: " + ex.StatusCode + " - " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error sending email: " + ex.Message);
                MessageBox.Show("Error sending email: " + ex.Message);
            }

        }




        private string GenerateVerificationCode()
        {

            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private bool EmailExists(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True"))
                {
                    connection.Open();

                    // Query for Buyer
                    string buyerQuery = "SELECT COUNT(*) FROM [Buyer] WHERE Gmail = @Email";
                    using (SqlCommand buyerCommand = new SqlCommand(buyerQuery, connection))
                    {
                        buyerCommand.Parameters.AddWithValue("@Email", email);
                        int buyerCount = (int)buyerCommand.ExecuteScalar();
                        if (buyerCount > 0)
                        {
                            return true;
                        }
                    }

                    // Query for Seller
                    string sellerQuery = "SELECT COUNT(*) FROM [Seller] WHERE Gmail = @Email";
                    using (SqlCommand sellerCommand = new SqlCommand(sellerQuery, connection))
                    {
                        sellerCommand.Parameters.AddWithValue("@Email", email);
                        int sellerCount = (int)sellerCommand.ExecuteScalar();
                        if (sellerCount > 0)
                        {
                            return true;
                        }
                    }

                    // Query for Admin
                    string adminQuery = "SELECT COUNT(*) FROM [Admin] WHERE Gmail = @Email";
                    using (SqlCommand adminCommand = new SqlCommand(adminQuery, connection))
                    {
                        adminCommand.Parameters.AddWithValue("@Email", email);
                        int adminCount = (int)adminCommand.ExecuteScalar();
                        if (adminCount > 0)
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string enteredCode = textBox_vrificationCode.Text;
            string newPassword = textBox_newPass.Text;
            string confirmPassword = textBox_confirmPass.Text;

            if (enteredCode != verificationCode)
            {
                MessageBox.Show("Invalid verification code.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (UpdatePassword(userType,textBox_gmail.Text, newPassword))
            {
                MessageBox.Show("Password updated successfully.");
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update password.");
            }
        }

        private bool UpdatePassword(string userType, string email, string newPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True"))
                {
                    connection.Open();

                    string buyerQuery = "UPDATE [Buyer] SET Password = @NewPassword WHERE Gmail = @Email";
                    using (SqlCommand buyerCommand = new SqlCommand(buyerQuery, connection))
                    {
                        buyerCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        buyerCommand.Parameters.AddWithValue("@Email", email);
                        int buyerCount = buyerCommand.ExecuteNonQuery();
                        if (buyerCount > 0)
                        {
                            return true;
                        }
                    }

                    // Update password for Seller
                    string sellerQuery = "UPDATE [Seller] SET Password = @NewPassword WHERE Gmail = @Email";
                    using (SqlCommand sellerCommand = new SqlCommand(sellerQuery, connection))
                    {
                        sellerCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        sellerCommand.Parameters.AddWithValue("@Email", email);
                        int sellerCount = sellerCommand.ExecuteNonQuery();
                        if (sellerCount > 0)
                        {
                            return true;
                        }
                    }

                    // Update password for Admin
                    string adminQuery = "UPDATE [Admin] SET Password = @NewPassword WHERE Gmail = @Email";
                    using (SqlCommand adminCommand = new SqlCommand(adminQuery, connection))
                    {
                        adminCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        adminCommand.Parameters.AddWithValue("@Email", email);
                        int adminCount = adminCommand.ExecuteNonQuery();
                        if (adminCount > 0)
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

