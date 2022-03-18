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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.employeeTableAdapter information = new bim312DataSetTableAdapters.employeeTableAdapter();
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bim312DataSet);

        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bim312DataSet.employee);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_ssn.Clear();
            txt_fname.Clear();
            txt_mname.Clear();
            txt_lname.Clear();
            txt_tel.Clear();
            txt_salary.Clear();
            txt_address.Clear();
            txt_gender.Clear();
            txt_bdate.Clear();
            txt_startdate.Clear();
            txt_com_id.Clear();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                int salary = int.Parse(txt_salary.Text);
                DateTime bdate = DateTime.Parse(txt_bdate.Text);
                DateTime startdate = DateTime.Parse(txt_startdate.Text);
                information.InsertQuery(txt_ssn.Text, txt_fname.Text, txt_mname.Text, txt_lname.Text, txt_tel.Text, salary, txt_address.Text, txt_gender.Text, bdate, startdate, txt_com_id.Text);
                new Employee().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been added.");
            }
            else
            {
                MessageBox.Show(" You do not have permission to add data. ");
                clear_Click(e, e);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                information.DeleteQuery(txt_ssn.Text, txt_com_id.Text);
                new Employee().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been deleted.");
            }
            else
            {
                MessageBox.Show(" You do not have permission to delete data. ");
                clear_Click(e, e);
            }


        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                int salary = int.Parse(txt_salary.Text);
                DateTime bdate = DateTime.Parse(txt_bdate.Text);
                DateTime startdate = DateTime.Parse(txt_startdate.Text);
                information.UpdateQuery(txt_ssn.Text, txt_fname.Text, txt_mname.Text, txt_lname.Text, txt_tel.Text, salary, txt_address.Text, txt_gender.Text, bdate, startdate, txt_com_id.Text, txt_ssn.Text, txt_com_id.Text);
                new Employee().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been updated.");
            }
            else
            {
                MessageBox.Show(" You do not have permission to update data. ");
                clear_Click(e, e);
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            employeeDataGridView.DataSource = information.GetDataSearch(search.Text);
        }
    }
}
