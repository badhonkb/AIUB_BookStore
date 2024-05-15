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
    public partial class BuyerRegistration : Form
    {
        public bool pass_see = false;
        public bool cursor_on_pass_Box = false;
        public Point mouseLocation;


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BEUOR2E\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True");
        public BuyerRegistration()
        {
            InitializeComponent();
            textBoxName.Focus();
        }


        private void iconButtonBack_Click_1(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show();
            this.Close();
        }

        private void iconButtonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "Enter your Name";
            textBoxName.ForeColor = Color.Silver;


            textBoxGmail.Text = "Enter your Gmail";
            textBoxGmail.ForeColor = Color.Silver;

            textBoxMobileNo.Text = "Enter your Mobile No";
            textBoxMobileNo.ForeColor = Color.Silver;

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

        private void Buyer_Load(object sender, EventArgs e)
        {
    
        }

        private void comboBoxDistrict_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxDistrict.Items.Clear();


            if (string.IsNullOrWhiteSpace(comboBoxDivision.Text))
            {
                comboBoxDistrict.Items.Add("Select Division first");
            }
            else
            {
                if (comboBoxDivision.Text == "Dhaka")
                {
                    string[] Dhaka_Districts =
                    {
                        "Dhaka", "Faridpur", "Gazipur", "Gopalganj", "Kishoreganj","Madaripur", "Manikganj","Munshiganj", "Narayanganj", "Narsingdi","Rajbari", "Shariatpur", "Tangail"
                    };

                    comboBoxDistrict.Items.AddRange(Dhaka_Districts);
                }
                else if (comboBoxDivision.Text == "Chattogram")
                {
                    string[] Chattogram_Districts =
                    {
                        "Brahmanbaria","Comilla","Chandpur","Lakshmipur","Noakhali","Feni","Khagrachhari","Rangamati","Bandarban","Chittagong","Cox's Bazar"
                    };
                    comboBoxDistrict.Items.AddRange(Chattogram_Districts);
                }
                else if (comboBoxDivision.Text == "Barishal")
                {
                    string[] Barishal_Districts =
                    {
                        "Barishal", "Patuakhali", "Bhola", "Pirojpur", "Barguna", "Jhalokati"
                    };
                    comboBoxDistrict.Items.AddRange(Barishal_Districts);
                }
                else if (comboBoxDivision.Text == "Khulna")
                {
                    string[] Khulna_Districts =
                    {
                        "Khulna", "Bagherhat", "Sathkhira", "Jessore", "Magura", "Jhenaidah", "Narail", "Kushtia", "Chuadanga", "Meherpur"
                    };
                    comboBoxDistrict.Items.AddRange(Khulna_Districts);
                }
                else if (comboBoxDivision.Text == "Rajshahi")
                {
                    string[] Rajshahi_Districts =
                    {
                        "Rajshahi", "Chapainawabganj", "Natore", "Naogaon", "Pabna", "Sirajganj", "Bogra", "Joypurhat"
                    };
                    comboBoxDistrict.Items.AddRange(Rajshahi_Districts);
                }
                else if (comboBoxDivision.Text == "Rangpur")
                {
                    string[] Rangpur_Districts =
                    {
                        "Rangpur", "Gaibandha", "Nilphamari", "Kurigram", "Lalmonirhat", "Dinajpur", "Thakurgaon", "Panchagarh"
                    };
                    comboBoxDistrict.Items.AddRange(Rangpur_Districts);
                }
                else if (comboBoxDivision.Text == "Mymensingh")
                {
                    string[] Mymensingh_Districts =
                    {
                        "Mymensingh", "Jamalpur", "Netrokona", "Sherpur"
                    };
                    comboBoxDistrict.Items.AddRange(Mymensingh_Districts);
                }
                else if (comboBoxDivision.Text == "Sylhet")
                {
                    string[] Sylhet_Districts =
                    {
                        "Habiganj", "Moulvibazar", "Sunamganj", "Sylhet"
                    };
                    comboBoxDistrict.Items.AddRange(Sylhet_Districts);
                }
                else
                {
                    comboBoxDistrict.Items.Add("Select Division correctly");
                }

            }
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
                textBoxName.ForeColor = Color.Black;
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

        private void textBoxGmail_Leave(object sender, EventArgs e)
        {
            if (textBoxGmail.Text == "")
            {
                textBoxGmail.Text = "Enter your Gmail";
                textBoxGmail.ForeColor = Color.Silver;
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
            if (textBoxUserId.Text == "")
            {
                textBoxUserId.Text = "Enter you User Id";
                textBoxUserId.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

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

        private void Icn_PicBox_Eye_Click_1(object sender, EventArgs e)
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

        private void comboBoxDistrict_Enter(object sender, EventArgs e)
        {
            if (comboBoxDistrict.Text == "Select District")
            {
                comboBoxDistrict.Text = "";
                comboBoxDistrict.ForeColor = Color.Black;
            }
        }

        private void comboBoxDistrict_Leave(object sender, EventArgs e)
        {
            if (comboBoxDistrict.Text == "" || comboBoxDistrict.Text == "Select Division first" || comboBoxDistrict.Text == "Select Division correctly")
            {
                comboBoxDistrict.Text = "Select District";
                comboBoxDistrict.ForeColor = Color.Silver;
            }
        }

        private void iconButtonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxGmail.Text == "" || textBoxMobileNo.Text == "" || comboBoxDistrict.Text == "" || comboBoxDivision.Text == "" || textBoxUserId.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == "Enter your name" || textBoxGmail.Text == "Enter your Gmail" || textBoxMobileNo.Text == "Enter your mobile no" || comboBoxDistrict.Text == "Select District" || comboBoxDivision.Text == "Select Division" || textBoxUserId.Text == "Enter your UserId" || textBoxPassword.Text == "Enter your Password")
            {
                MessageBox.Show(" Please enter all the datas");
            }
            else
            {
                string gender = radioButtonMale.Checked ? "Male" : "Female";
                SqlCommand cmd = new SqlCommand("insert into [Buyer]  (Name,Gender,DOB ,Gmail ,Mobile_Number, Division, District, User_Id, Password) " +
                        "values('" + textBoxName.Text + "','" + gender + "','" + dateTimePicker1.Text + "','" + textBoxGmail.Text + "','" + textBoxMobileNo.Text + "','" + comboBoxDivision.Text + "','" + comboBoxDistrict.Text + "','" + textBoxUserId.Text + "','" + textBoxPassword.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registered Succesfully");


                textBoxName.Text = "Enter your Name";
                textBoxName.ForeColor = Color.Silver;

                textBoxGmail.Text = "Enter your Gmail";
                textBoxGmail.ForeColor = Color.Silver;


                textBoxMobileNo.Text = "Enter your Mobile No";
                textBoxMobileNo.ForeColor = Color.Silver;

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
    }
}
