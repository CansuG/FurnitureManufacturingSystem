using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms_app
{
	public partial class Login : Form
	{
        public static string user;
        public Login()
        {
            InitializeComponent();
        }    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            user = user_name.Text;
            if (user == "manager" && password.Text == "password1")
            {
                new Menu().Show();
                this.Hide();
                
            }
            else if(user == "engineer" && password.Text == "password2")
            {
                new Menu().Show();
                this.Hide();
            }
            else if(user == "accountant" && password.Text == "password3")
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, try again.");
                user_name.Clear();
                password.Clear();
                user_name.Focus();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            user_name.Clear();
            password.Clear();
            user_name.Focus();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
