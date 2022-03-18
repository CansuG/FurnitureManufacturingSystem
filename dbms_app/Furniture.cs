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
    public partial class Furniture : Form
    {
        public Furniture()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.furnitureTableAdapter information = new bim312DataSetTableAdapters.furnitureTableAdapter();
        private void Furniture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.furniture' table. You can move, or remove it, as needed.
            this.furnitureTableAdapter.Fill(this.bim312DataSet.furniture);

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
                int quantity = int.Parse(txt_quantity.Text);
                int price = int.Parse(txt_price.Text);
                DateTime date = DateTime.Parse(txt_date.Text);
                information.InsertQuery(txt_f_id.Text, quantity, price, txt_type.Text, date, txt_com_id.Text);
                new Furniture().Show();
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
                information.DeleteQuery(txt_f_id.Text, txt_com_id.Text);
                new Furniture().Show();
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
                int price = int.Parse(txt_price.Text);
                DateTime date = DateTime.Parse(txt_date.Text);
                information.UpdateQuery(txt_f_id.Text, quantity, price, txt_type.Text, date, txt_com_id.Text, txt_f_id.Text, txt_com_id.Text);
                new Furniture().Show();
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
            txt_f_id.Clear();
            txt_quantity.Clear();
            txt_price.Clear();
            txt_type.Clear();
            txt_date.Clear();
            txt_com_id.Clear();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            furnitureDataGridView.DataSource = information.GetDataSearch(search.Text);

        }
    }
}
