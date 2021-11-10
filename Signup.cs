using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        LoginComponents logincomponents = new LoginComponents();
        public Signup()
        {
            InitializeComponent();
        }



        // All button function 
        //Start
        bool check;
        private void button_Submit(object sender, EventArgs e)
        {
            Console.WriteLine("CHECK ON CLICK :" + check);
          


                foreach (Control mycontrol in FieldHolder.Controls)
                {

                    if (mycontrol is TextBox || mycontrol is ComboBox)
                    {

                        // it will give you the number if exist the complete text else retuern false or -1
                        int find = mycontrol.Name.ToString().IndexOf("_Required", 0);

                        if (find > 0 && mycontrol.Text == "")
                        {
                            mycontrol.BackColor = Color.Red;
                            lblErrorMessage.Text = "Mandatory field should be fill !";
                            lblErrorMessage.Visible = true;
                            lblErrorMessage.ForeColor = Color.Red;
                            check = false;
                        }
                        else
                        {
                            // call the functuin here 
                            mycontrol.BackColor = Color.White;
                            lblErrorMessage.Text = "Mandatory field should be fill !";
                            lblErrorMessage.Visible = true;
                            lblErrorMessage.ForeColor = Color.White;
                            check = true;
                        }
                    }
                }
/*            do
            {*/
                if (check == true)
                {

                //  Console.WriteLine("debug PROBLEM" + check);
                if (PasswordField_Required.Text == Re_PasswordField_Required.Text && PasswordField_Required.Text != "" && Re_PasswordField_Required.Text != "")
                {

                    if (UserNameField_Required.Text != "" && FristName_Required.Text != "" && LastName_Required.Text != ""
                         && monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd") != "" && UserType_Required.Text != "")
                    {
                        Console.WriteLine("all data sent");
                        logincomponents.Input_UserName_SignUP = UserNameField_Required.Text;
                        logincomponents.Input_userPassword_SignUP = PasswordField_Required.Text;
                        logincomponents.Input_First_Name_SignUP = FristName_Required.Text;
                        logincomponents.Input_Last_Name_SignUP = LastName_Required.Text;
                        logincomponents.Input_Dateofbirth_SignUP = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
                        logincomponents.Input_User_Type_SignUP = UserType_Required.Text;
                        logincomponents.CreateAccount();

                        if (logincomponents.status_SignUP == true)
                        {

                            LoginPage loginpage = new LoginPage();
                            this.Hide();
                            loginpage.Show();

                        }

                    }
                    else
                    {


                        string title = "erro";
                        string message = "some feild are eampty";
                        MessageBox.Show(message, title);


                        Console.WriteLine("eamtpy");



                    }

                }
                else {
                    string title = "erro";
                    string message = "password done not match!";
                    MessageBox.Show(message, title);

                }





            }
      






        }
   
        private void button_Exit(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }

     

        // end here 
        private void Form1_Load(object sender, EventArgs e)
        {
            logincomponents.UserInfoData();
            Console.WriteLine("this form is call ");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void TextHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftBackground_Holder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logincomponents.CreateAccount();
        }

    

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
            
        }
    }
}
