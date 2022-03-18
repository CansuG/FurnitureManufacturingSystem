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
    public partial class FurnitureColor : Form
    {
        public FurnitureColor()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.furniturecolorTableAdapter information = new bim312DataSetTableAdapters.furniturecolorTableAdapter();
        private void FurnitureColor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet.furniturecolor' table. You can move, or remove it, as needed.
            this.furniturecolorTableAdapter.Fill(this.bim312DataSet.furniturecolor);

        }

        private void returnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_f_id.Clear();
            txt_color.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Login.user == "manager")
            {
                information.InsertQuery(txt_f_id.Text, txt_color.Text);
                new FurnitureColor().Show();
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
                information.DeleteQuery(txt_f_id.Text, txt_color.Text);
                new FurnitureColor().Show();
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
                information.UpdateQuery(txt_f_id.Text, txt_color.Text, txt_f_id.Text, old_color.Text);
                new FurnitureColor().Show();
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
            furniturecolorDataGridView.DataSource = information.GetDataSearch(search.Text);
              
                
        }
    }
}
