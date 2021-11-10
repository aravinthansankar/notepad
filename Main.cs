using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public string myuserName;
        public bool isview;
        LoginComponents logincomponents = new LoginComponents();
        string path;

        public Main(String value)
        {
            InitializeComponent();
            userNameLabel.Text = "UserName: " + value;
            myuserName = value;


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "RTF Files|*.rtf", ValidateNames = true, Multiselect = false })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            path = ofd.FileName;
                            Task<string> text = sr.ReadToEndAsync();
                            richTextBox1.Text = text.Result;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = string.Empty;

            richTextBox1.Clear();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // string name;

            logincomponents.UserInfoData();
            logincomponents.isView(myuserName);
            Console.WriteLine("here is my reslut pls work " + logincomponents.Permission);
            richTextBox1.ReadOnly = logincomponents.Permission;
            if (logincomponents.Permission)
            {

                toolStripButton1.Visible = false;
                toolStripButton2.Visible = false;
                toolStripButton3.Visible = false;
                toolStripButton4.Visible = false;
                toolStripButton8.Visible = false;
                toolStripButton9.Visible = false;
                toolStripButton10.Visible = false;
                toolStripComboBox1.Visible = false;
                saveToolStripMenuItem.Visible = false;
                saveAsToolStripMenuItem.Visible = false;
                newToolStripMenuItem.Visible = false;
                cToolStripMenuItem.Visible = false;
                copyToolStripMenuItem.Visible = false;
                pastToolStripMenuItem.Visible = false;
                editToolStripMenuItem.Visible = false;
                toolStripButton5.Visible = false;
                toolStripButton6.Visible = false;
                toolStripButton7.Visible = false;

            }


            AddFontSize();





        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "RTF Files|*.rtf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(richTextBox1.Text);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "RTF Files|*.rtf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            path = sfd.FileName;
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                await sw.WriteLineAsync(richTextBox1.Text);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        await sw.WriteLineAsync(richTextBox1.Text);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            if (toolStripButton8.Checked)
            {
                 richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
              
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
               
            }




        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (toolStripButton9.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

            if (toolStripButton10.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginpage = new LoginPage();
            this.Close();
            loginpage.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {





            float fontsize = 10;
            string fontname = richTextBox1.SelectionFont.Name;
            if (toolStripComboBox1.Text != "") fontsize = float.Parse(toolStripComboBox1.Text);
            if (fontsize == 0) fontsize = 10;
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(fontname, fontsize);
            }
        }
        private void AddFontSize()
        {
            // throw new Not Implemented Exception();    
            toolStripComboBox1.Items.Add("8");
            toolStripComboBox1.Items.Add("9");
            toolStripComboBox1.Items.Add("10");
            toolStripComboBox1.Items.Add("11");
            toolStripComboBox1.Items.Add("12");
            toolStripComboBox1.Items.Add("13");
            toolStripComboBox1.Items.Add("14");
            toolStripComboBox1.Items.Add("15");
            toolStripComboBox1.Items.Add("16");
            toolStripComboBox1.Items.Add("17");
            toolStripComboBox1.Items.Add("18");
            toolStripComboBox1.Items.Add("19");
            toolStripComboBox1.Items.Add("20");
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
