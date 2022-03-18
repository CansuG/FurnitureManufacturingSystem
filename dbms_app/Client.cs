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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.clienttTableAdapter information = new bim312DataSetTableAdapters.clienttTableAdapter();
        private void clienttBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienttBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bim312DataSet);

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.clientt' table. You can move, or remove it, as needed.
            this.clienttTableAdapter.Fill(this.bim312DataSet.clientt);

        }

        private void returnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void clienttDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                information.InsertQuery(txt_id.Text, txt_mail.Text, txt_city.Text, txt_address.Text, txt_tel.Text, txt_name.Text);
                new Client().Show();
                this.Hide();
                MessageBox.Show("Data has been added");
            }
            else
            {
                MessageBox.Show(" You do not have permission to add data. ");
                clear_Click(e,e);
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                information.DeleteQuery(txt_id.Text);
                new Client().Show();
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
                information.UpdateQuery(txt_id.Text, txt_mail.Text, txt_city.Text, txt_address.Text, txt_tel.Text, txt_name.Text,txt_id.Text);
                new Client().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been updated");
            }
            else
            {
                MessageBox.Show(" You do not have permission to update data. ");
                clear_Click(e, e);
            }  
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_mail.Clear();
            txt_city.Clear();
            txt_address.Clear();
            txt_tel.Clear();
            txt_name.Clear();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            clienttDataGridView.DataSource = information.GetDataBy5(search.Text);
        }
    }
}
