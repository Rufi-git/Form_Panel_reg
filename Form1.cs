using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_Form_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        User[] users = new User[5];
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] != null)
                {
                    User u = users[i];
                    if(u.Email == txbx_email.Text)
                    {
                        MessageBox.Show("This Email has already been used");
                        return;
                    }
                }
            }

            if (count == users.Length)
            {
                MessageBox.Show("User is full!");
                return;
            }

            lbl_name_error.Text = "";
            lbl_surname_error.Text = "";
            lbl_age_error.Text = "";
            lbl_email_error.Text = "";
            lbl_password_error.Text = "";

            bool hasError = false;
            if (string.IsNullOrEmpty(txbx_name.Text))
            {
                lbl_name_error.Text = "*Name can not be empty";
                hasError = true;
            }

            if (string.IsNullOrEmpty(txbx_surname.Text))
            {
                lbl_surname_error.Text = "*Surname can not be empty";
                hasError = true;
            }

            if (string.IsNullOrEmpty(txbx_age.Text))
            {
                lbl_age_error.Text = "*Age can not be empty";
                hasError = true;
            }

            if (string.IsNullOrEmpty(txbx_email.Text))
            {
                lbl_email_error.Text = "*Email can not be empty";
                hasError = true;
            }

            if (string.IsNullOrEmpty(txbx_password.Text))
            {
                lbl_password_error.Text = "*Password can not be empty";
                hasError = true;
            }
            if(hasError == false)
            {
                User user = new User();

                user.Name = txbx_name.Text;
                user.Surname = txbx_surname.Text;
                if (txbx_email.Text.EndsWith("@gmail.com"))
                {
                    user.Email = txbx_email.Text;
                }
                else
                {
                    lbl_email_error.Text = "This is not an email";
                    return;
                }
                user.Password = txbx_password.Text;
                //if (Convert.ToBoolean(txbx_age.Text) == )
                //{
                    user.Age = Convert.ToByte(txbx_age.Text);
                //}
                //else
                //{
                    //MessageBox.Show("This is not age");
                //}

                users[count] = user;
                count++;

                MessageBox.Show("Qeydiyyat ugurlu oldu!");
            }
            else
            {
                MessageBox.Show("Qeydiyyat ugursuz oldu");
            }
            
        }
    }
}
