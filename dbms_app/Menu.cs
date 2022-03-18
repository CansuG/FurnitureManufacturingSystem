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
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
            
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                see.Visible = false;
            }
            else
            {

                change.Visible = false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Company().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Furniture().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Client().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FurnitureColor().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new SoldAs().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Statistics().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
