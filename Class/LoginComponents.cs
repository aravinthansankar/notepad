using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class LoginComponents
    {

       

        List<string> Username = new List<string>();
        List<string> Password = new List<string>();
        List<string> UserType = new List<string>();
        List<string> First_Name = new List<string>();
        List<string> Last_Name = new List<string>();
        List<string> Date_of_birth = new List<string>();
      

        string path = (@"C:\Users\CRACKER\source\uts_ass2\WindowsFormsApp1\WindowsFormsApp1\Account\login.txt");
        string newLine = Environment.NewLine;

        //is login data

     
        
      

      

        //end 

        //Login
        public bool LoginStatus { get; set; }
        public  bool Permission { get; set; }
        public string Input_UserName { get; set; }
        public string Input_userPassword { get; set; }

       

        // SignUP
        public string Input_UserName_SignUP { get; set; }
        public string Input_userPassword_SignUP { get; set; }

        public string Input_User_Type_SignUP { get; set; }
        public string Input_First_Name_SignUP { get; set; }

        public string Input_Last_Name_SignUP { get; set; }
        public string Input_Dateofbirth_SignUP { get; set; }
        public bool status_SignUP { get; set; }




        public void isView(string view)
        {
            string InputUserName = view;
            int IndexType = Username.IndexOf(InputUserName);
            Console.WriteLine("name" + InputUserName);
            Console.WriteLine("how much i have" + UserType.Count);
            Console.WriteLine("the index number" + IndexType);

            if (UserType[IndexType].Contains("Edit"))
            {
                Permission = false;



            }
            else
            {
                Permission = true;


            }

        }

        public void UserInfoData()
        {



            if (File.Exists(path))
            {
                String[] lines = System.IO.File.ReadAllLines(path);

                // Create a file to write to.
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file and split then  using "|"in to list such as password and users.
                    String[] comp = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    //adding to list base on the split
                    Username.Add(comp[0]);
                    Password.Add(comp[1]);
                    UserType.Add(comp[2]);
                    First_Name.Add(comp[3]);
                    Last_Name.Add(comp[4]);
                    Date_of_birth.Add(comp[5]);





                }



            }
            else
            {
                // Errormessage("Pls check the txt file", "connection erro");
            }




        }

        
        public void Usercheck()
        {

            string InputUserName = Input_UserName;
            string InputPassword = Input_userPassword;

            int IndexUsername = Username.IndexOf(InputUserName);
            int Indexpass = Password.IndexOf(InputPassword);
          
          



            if (Username.Contains(InputUserName) && Password.Contains(InputPassword) && IndexUsername == Indexpass)
            {
                

                LoginStatus = true;
                /*Console.WriteLine("this is the index number :"+UserType[IndexUsername]);
                Console.WriteLine("this is the index number :" + UserType[IndexUsername]);*/

            
                
               

            }
            else
            {
                LoginStatus = false;
            }
        }


   
        public void CreateAccount()
        {


            // check if the file exists or not 
            Signup signup = new Signup();


            if (File.Exists(path))
            {
                if (!Username.Contains(Input_UserName_SignUP))
                {

                    Console.WriteLine("name all good used");
                    using (StreamWriter addUser = new StreamWriter(path, true))
                    {

                        // adding the transition history
                        addUser.Write(Input_UserName_SignUP + "," + Input_userPassword_SignUP + "," + Input_User_Type_SignUP + "," + Input_First_Name_SignUP + "," + Input_Last_Name_SignUP + "," + Input_Dateofbirth_SignUP + newLine);
                        addUser.Close();
                        status_SignUP = true;
                        Console.WriteLine("account as been created");


                    }
                }

                else
                {
                    Console.WriteLine("name is used");
                    // out saying that the username is used 
                    //   Errormessage("Error", "the user name is taken pls enter a new username");
                    string message = "the user name is taken pls enter a new username";
                    string title = "erro";
                    DialogResult result = MessageBox.Show(message, title);
                    if (result == DialogResult.OK)
                    {
                        signup.Close();

                    }

                }

            }
            else
            {
                status_SignUP = false;
            }

        }
    }
}
