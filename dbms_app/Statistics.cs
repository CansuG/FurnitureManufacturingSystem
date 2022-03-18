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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        bim312DataSetTableAdapters.furniturecolorTableAdapter information = new bim312DataSetTableAdapters.furniturecolorTableAdapter();

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bim312DataSet1.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bim312DataSet1.employee);
            // TODO: This line of code loads data into the 'bim312DataSet.clientt' table. You can move, or remove it, as needed.
            this.clienttTableAdapter.Fill(this.bim312DataSet.clientt);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void genderRatioToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.GenderRatio(this.bim312DataSet.employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
