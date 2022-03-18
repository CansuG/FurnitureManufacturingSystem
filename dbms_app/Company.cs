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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.companyTableAdapter information = new bim312DataSetTableAdapters.companyTableAdapter();
        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bim312DataSet);

        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.bim312DataSet.company);

        }

        private void returnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void companyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_address.Clear();
            txt_id.Clear();
            txt_mail.Clear();
            txt_name.Clear();
            txt_tel.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                information.InsertQuery(txt_id.Text, txt_mail.Text, txt_tel.Text, txt_name.Text, txt_address.Text);
                new Company().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been added");
            }
            else
            {
                MessageBox.Show(" You do not have permission to add data. ");
                clear_Click(e, e);
            }

                
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                information.DeleteQuery(txt_id.Text);
                new Company().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been deleted");
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
                information.UpdateQuery(txt_id.Text, txt_mail.Text, txt_tel.Text, txt_name.Text, txt_address.Text, txt_id.Text);
                new Company().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been updated");
            }
            else
            {
                MessageBox.Show(" You do not have permission to update data. ");
                clear_Click(e, e);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            companyDataGridView.DataSource = information.GetDataBy3(search.Text);
        }
    }
}
