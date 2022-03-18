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
    public partial class SoldAs : Form
    {
        public SoldAs()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.soldasTableAdapter information = new bim312DataSetTableAdapters.soldasTableAdapter();
        private void SoldAs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.soldas' table. You can move, or remove it, as needed.
            this.soldasTableAdapter.Fill(this.bim312DataSet.soldas);

        }

        private void returnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                int quantity = int.Parse(txt_quantity.Text);
                information.InsertQuery(txt_f_id.Text, txt_order_id.Text, quantity);
                new SoldAs().Show();
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
                information.DeleteQuery(txt_f_id.Text, txt_order_id.Text);
                new SoldAs().Show();
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
                int quantity = int.Parse(txt_quantity.Text);
                information.UpdateQuery(txt_f_id.Text, txt_order_id.Text, quantity, txt_f_id.Text, txt_order_id.Text);
                new SoldAs().Show();
                this.Hide();
                System.Windows.Forms.MessageBox.Show("Data has been updated.");
            } 
            else
            {
                MessageBox.Show(" You do not have permission to update data. ");
                clear_Click(e, e);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_quantity.Clear();
            txt_order_id.Clear();
            txt_f_id.Clear();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            soldasDataGridView.DataSource = information.GetDataSearch(search.Text);

        }
    }
}
