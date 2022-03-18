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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.orderrTableAdapter information = new bim312DataSetTableAdapters.orderrTableAdapter();
        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.orderr' table. You can move, or remove it, as needed.
            this.orderrTableAdapter.Fill(this.bim312DataSet.orderr);

        }

        private void returnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                DateTime orderdate = DateTime.Parse(txt_orderdate.Text);
                information.InsertQuery(txt_order_id.Text, txt_cl_id.Text, orderdate);
                new Order().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been added.");
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
                information.DeleteQuery(txt_order_id.Text, txt_cl_id.Text);
                new Order().Show();
                this.Hide();
                MessageBox.Show("Data has been deleted.");
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
                DateTime orderdate = DateTime.Parse(txt_orderdate.Text);
                information.UpdateQuery(txt_order_id.Text, txt_cl_id.Text, orderdate, txt_order_id.Text, txt_cl_id.Text);
                new Order().Show();
                this.Hide();
                MessageBox.Show("Data has been updated.");
            }
            else
            {
                MessageBox.Show(" You do not have permission to update data. ");
                clear_Click(e, e);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_orderdate.Clear();
            txt_cl_id.Clear();
            txt_order_id.Clear();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            orderrDataGridView.DataSource = information.GetDataSearch(search.Text);

        }
    }
}
