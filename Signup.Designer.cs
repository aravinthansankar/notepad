
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text;
namespace WindowsFormsApp1
{
    partial class Signup
    {
  
        private System.ComponentModel.IContainer components = null;
       

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.leftBackground_Holder = new System.Windows.Forms.Panel();
            this.autorholder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FieldHolder = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.LastName_Required = new System.Windows.Forms.TextBox();
            this.FristName_Required = new System.Windows.Forms.TextBox();
            this.Re_PasswordField_Required = new System.Windows.Forms.TextBox();
            this.PasswordField_Required = new System.Windows.Forms.TextBox();
            this.UserNameField_Required = new System.Windows.Forms.TextBox();
            this.UserType_Required = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.leftBackground_Holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FieldHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBackground_Holder
            // 
            this.leftBackground_Holder.BackColor = System.Drawing.Color.Black;
            this.leftBackground_Holder.Controls.Add(this.autorholder);
            this.leftBackground_Holder.Controls.Add(this.pictureBox1);
            this.leftBackground_Holder.Controls.Add(this.Exit);
            this.leftBackground_Holder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBackground_Holder.Location = new System.Drawing.Point(0, 0);
            this.leftBackground_Holder.Name = "leftBackground_Holder";
            this.leftBackground_Holder.Size = new System.Drawing.Size(278, 674);
            this.leftBackground_Holder.TabIndex = 0;
            this.leftBackground_Holder.Paint += new System.Windows.Forms.PaintEventHandler(this.leftBackground_Holder_Paint);
            // 
            // autorholder
            // 
            this.autorholder.AutoSize = true;
            this.autorholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorholder.ForeColor = System.Drawing.Color.White;
            this.autorholder.Location = new System.Drawing.Point(26, 282);
            this.autorholder.Name = "autorholder";
            this.autorholder.Size = new System.Drawing.Size(241, 20);
            this.autorholder.TabIndex = 3;
            this.autorholder.Text = "Developed By aravinthan sankar ";
            this.autorholder.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FieldHolder
            // 
            this.FieldHolder.BackColor = System.Drawing.Color.White;
            this.FieldHolder.Controls.Add(this.monthCalendar1);
            this.FieldHolder.Controls.Add(this.lblErrorMessage);
            this.FieldHolder.Controls.Add(this.LastName_Required);
            this.FieldHolder.Controls.Add(this.FristName_Required);
            this.FieldHolder.Controls.Add(this.Re_PasswordField_Required);
            this.FieldHolder.Controls.Add(this.PasswordField_Required);
            this.FieldHolder.Controls.Add(this.UserNameField_Required);
            this.FieldHolder.Controls.Add(this.UserType_Required);
            this.FieldHolder.Controls.Add(this.label8);
            this.FieldHolder.Controls.Add(this.label7);
            this.FieldHolder.Controls.Add(this.label6);
            this.FieldHolder.Controls.Add(this.label5);
            this.FieldHolder.Controls.Add(this.label4);
            this.FieldHolder.Controls.Add(this.label3);
            this.FieldHolder.Controls.Add(this.button1);
            this.FieldHolder.Controls.Add(this.label2);
            this.FieldHolder.Controls.Add(this.label1);
            this.FieldHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldHolder.Location = new System.Drawing.Point(278, 0);
            this.FieldHolder.Name = "FieldHolder";
            this.FieldHolder.Size = new System.Drawing.Size(511, 674);
            this.FieldHolder.TabIndex = 1;
            this.FieldHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.TextHolder_Paint);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(108, 503);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 25;
            // 
            // LastName_Required
            // 
            this.LastName_Required.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName_Required.Location = new System.Drawing.Point(194, 224);
            this.LastName_Required.Name = "LastName_Required";
            this.LastName_Required.Size = new System.Drawing.Size(263, 20);
            this.LastName_Required.TabIndex = 23;
            this.LastName_Required.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // FristName_Required
            // 
            this.FristName_Required.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FristName_Required.Location = new System.Drawing.Point(194, 186);
            this.FristName_Required.Name = "FristName_Required";
            this.FristName_Required.Size = new System.Drawing.Size(263, 20);
            this.FristName_Required.TabIndex = 22;
            // 
            // Re_PasswordField_Required
            // 
            this.Re_PasswordField_Required.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Re_PasswordField_Required.Location = new System.Drawing.Point(194, 151);
            this.Re_PasswordField_Required.Name = "Re_PasswordField_Required";
            this.Re_PasswordField_Required.Size = new System.Drawing.Size(263, 20);
            this.Re_PasswordField_Required.TabIndex = 21;
            this.Re_PasswordField_Required.UseSystemPasswordChar = true;
            // 
            // PasswordField_Required
            // 
            this.PasswordField_Required.BackColor = System.Drawing.Color.White;
            this.PasswordField_Required.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordField_Required.Location = new System.Drawing.Point(194, 117);
            this.PasswordField_Required.Name = "PasswordField_Required";
            this.PasswordField_Required.Size = new System.Drawing.Size(263, 20);
            this.PasswordField_Required.TabIndex = 20;
            this.PasswordField_Required.UseSystemPasswordChar = true;
            // 
            // UserNameField_Required
            // 
            this.UserNameField_Required.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameField_Required.Location = new System.Drawing.Point(194, 81);
            this.UserNameField_Required.Name = "UserNameField_Required";
            this.UserNameField_Required.Size = new System.Drawing.Size(263, 20);
            this.UserNameField_Required.TabIndex = 19;
            // 
            // UserType_Required
            // 
            this.UserType_Required.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserType_Required.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserType_Required.FormattingEnabled = true;
            this.UserType_Required.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.UserType_Required.Location = new System.Drawing.Point(194, 264);
            this.UserType_Required.Name = "UserType_Required";
            this.UserType_Required.Size = new System.Drawing.Size(263, 21);
            this.UserType_Required.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "UserType:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Re-Enter Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(30, 610);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(211, 38);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Cancel";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button_Exit);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Submit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(194, 309);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 674);
            this.Controls.Add(this.FieldHolder);
            this.Controls.Add(this.leftBackground_Holder);
            this.DoubleBuffered = true;
            this.Name = "Signup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftBackground_Holder.ResumeLayout(false);
            this.leftBackground_Holder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FieldHolder.ResumeLayout(false);
            this.FieldHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftBackground_Holder;
        private System.Windows.Forms.Panel FieldHolder;
        private System.Windows.Forms.Label autorholder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UserType_Required;
        private System.Windows.Forms.TextBox LastName_Required;
        private System.Windows.Forms.TextBox FristName_Required;
        private System.Windows.Forms.TextBox Re_PasswordField_Required;
        private System.Windows.Forms.TextBox PasswordField_Required;
        private System.Windows.Forms.TextBox UserNameField_Required;
        private Label lblErrorMessage;
        private MonthCalendar monthCalendar1;
    }
}

