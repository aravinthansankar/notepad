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
    public partial class LoginPage : Form
    {

        LoginComponents logincomponents = new LoginComponents();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            logincomponents.UserInfoData();
            Console.WriteLine("this form is call ");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                logincomponents.Input_UserName = textBox1.Text;
                logincomponents.Input_userPassword = textBox2.Text;

                logincomponents.Usercheck();
                if (logincomponents.LoginStatus)
                {
                    Console.WriteLine("login works");
                    Main main = new Main(textBox1.Text);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    string message = "wrong username or password ";
                    string title = "Login erro";
                    DialogResult result = MessageBox.Show(message, title);
                    if (result == DialogResult.OK)
                    {
                       // this.Close();
                    }


                }

            }
            else {
                string message = "please enter your value to login field can be empty";
                string title = "input is Empty";
                MessageBox.Show(message, title);

            }
           
        }

        private void check_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autorholder_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUP_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }
    }
}
