
namespace dbms_app
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.companyTableAdapter = new dbms_app.bim312DataSetTableAdapters.companyTableAdapter();
            this.returnmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cl_id = new System.Windows.Forms.TextBox();
            this.cl_id = new System.Windows.Forms.Label();
            this.txt_orderdate = new System.Windows.Forms.TextBox();
            this.orderdate = new System.Windows.Forms.Label();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.order_id = new System.Windows.Forms.Label();
            this.orderrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderrTableAdapter = new dbms_app.bim312DataSetTableAdapters.orderrTableAdapter();
            this.orderrDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.bim312DataSet;
            // 
            // bim312DataSet
            // 
            this.bim312DataSet.DataSetName = "bim312DataSet";
            this.bim312DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienttTableAdapter = null;
            this.tableAdapterManager.companyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.furniturecolorTableAdapter = null;
            this.tableAdapterManager.furnitureTableAdapter = null;
            this.tableAdapterManager.orderrTableAdapter = null;
            this.tableAdapterManager.soldasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbms_app.bim312DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(8, 18);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 88;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.returnmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 44);
            this.label1.TabIndex = 87;
            this.label1.Text = "ORDER TABLE";
            // 
            // txt_cl_id
            // 
            this.txt_cl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cl_id.Location = new System.Drawing.Point(261, 211);
            this.txt_cl_id.Name = "txt_cl_id";
            this.txt_cl_id.Size = new System.Drawing.Size(207, 36);
            this.txt_cl_id.TabIndex = 86;
            // 
            // cl_id
            // 
            this.cl_id.AutoSize = true;
            this.cl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_id.Location = new System.Drawing.Point(81, 215);
            this.cl_id.Name = "cl_id";
            this.cl_id.Size = new System.Drawing.Size(84, 29);
            this.cl_id.TabIndex = 85;
            this.cl_id.Text = "CL_ID";
            // 
            // txt_orderdate
            // 
            this.txt_orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderdate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_orderdate.Location = new System.Drawing.Point(261, 301);
            this.txt_orderdate.Name = "txt_orderdate";
            this.txt_orderdate.Size = new System.Drawing.Size(207, 36);
            this.txt_orderdate.TabIndex = 80;
            // 
            // orderdate
            // 
            this.orderdate.AutoSize = true;
            this.orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate.Location = new System.Drawing.Point(81, 304);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(172, 29);
            this.orderdate.TabIndex = 79;
            this.orderdate.Text = "ORDERDATE";
            // 
            // txt_order_id
            // 
            this.txt_order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_id.Location = new System.Drawing.Point(261, 127);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.Size = new System.Drawing.Size(207, 36);
            this.txt_order_id.TabIndex = 78;
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id.Location = new System.Drawing.Point(81, 127);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(143, 29);
            this.order_id.TabIndex = 77;
            this.order_id.Text = "ORDER_ID";
            // 
            // orderrBindingSource
            // 
            this.orderrBindingSource.DataMember = "orderr";
            this.orderrBindingSource.DataSource = this.bim312DataSet;
            // 
            // orderrTableAdapter
            // 
            this.orderrTableAdapter.ClearBeforeFill = true;
            // 
            // orderrDataGridView
            // 
            this.orderrDataGridView.AutoGenerateColumns = false;
            this.orderrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.orderrDataGridView.DataSource = this.orderrBindingSource;
            this.orderrDataGridView.Location = new System.Drawing.Point(261, 518);
            this.orderrDataGridView.Name = "orderrDataGridView";
            this.orderrDataGridView.RowHeadersWidth = 51;
            this.orderrDataGridView.RowTemplate.Height = 24;
            this.orderrDataGridView.Size = new System.Drawing.Size(424, 248);
            this.orderrDataGridView.TabIndex = 88;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cl_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cl_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "It is enough to write ORDER_ID and CL_ID for deleting";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(740, 365);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 32);
            this.clear.TabIndex = 92;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(707, 273);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(144, 46);
            this.update.TabIndex = 91;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(707, 174);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(144, 44);
            this.delete.TabIndex = 90;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(707, 93);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 46);
            this.add.TabIndex = 89;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 95;
            this.label2.Text = "Search :";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(261, 449);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 94;
            this.search.Text = "Order_ID";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(939, 791);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.orderrDataGridView);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cl_id);
            this.Controls.Add(this.cl_id);
            this.Controls.Add(this.txt_orderdate);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.txt_order_id);
            this.Controls.Add(this.order_id);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource companyBindingSource;
        private bim312DataSet bim312DataSet;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bim312DataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cl_id;
        private System.Windows.Forms.Label cl_id;
        private System.Windows.Forms.TextBox txt_orderdate;
        private System.Windows.Forms.Label orderdate;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.BindingSource orderrBindingSource;
        private bim312DataSetTableAdapters.orderrTableAdapter orderrTableAdapter;
        private System.Windows.Forms.DataGridView orderrDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}