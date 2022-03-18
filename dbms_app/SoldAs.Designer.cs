
namespace dbms_app
{
    partial class SoldAs
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
            this.orderrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.orderrTableAdapter = new dbms_app.bim312DataSetTableAdapters.orderrTableAdapter();
            this.returnmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.q_quantity = new System.Windows.Forms.Label();
            this.txt_f_id = new System.Windows.Forms.TextBox();
            this.companyTableAdapter = new dbms_app.bim312DataSetTableAdapters.companyTableAdapter();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.order_id = new System.Windows.Forms.Label();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldasTableAdapter = new dbms_app.bim312DataSetTableAdapters.soldasTableAdapter();
            this.soldasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderrBindingSource
            // 
            this.orderrBindingSource.DataMember = "orderr";
            this.orderrBindingSource.DataSource = this.bim312DataSet;
            // 
            // bim312DataSet
            // 
            this.bim312DataSet.DataSetName = "bim312DataSet";
            this.bim312DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderrTableAdapter
            // 
            this.orderrTableAdapter.ClearBeforeFill = true;
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(5, 18);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 99;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.returnmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 44);
            this.label1.TabIndex = 98;
            this.label1.Text = "SOLD AS TABLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_order_id
            // 
            this.txt_order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_id.Location = new System.Drawing.Point(258, 211);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.Size = new System.Drawing.Size(207, 36);
            this.txt_order_id.TabIndex = 97;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_quantity.Location = new System.Drawing.Point(258, 301);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(207, 36);
            this.txt_quantity.TabIndex = 95;
            // 
            // q_quantity
            // 
            this.q_quantity.AutoSize = true;
            this.q_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_quantity.Location = new System.Drawing.Point(78, 304);
            this.q_quantity.Name = "q_quantity";
            this.q_quantity.Size = new System.Drawing.Size(178, 29);
            this.q_quantity.TabIndex = 94;
            this.q_quantity.Text = "Q_QUANTITY";
            // 
            // txt_f_id
            // 
            this.txt_f_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_id.Location = new System.Drawing.Point(258, 127);
            this.txt_f_id.Name = "txt_f_id";
            this.txt_f_id.Size = new System.Drawing.Size(207, 36);
            this.txt_f_id.TabIndex = 93;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
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
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id.Location = new System.Drawing.Point(78, 218);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(143, 29);
            this.order_id.TabIndex = 92;
            this.order_id.Text = "ORDER_ID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.bim312DataSet;
            // 
            // soldasBindingSource
            // 
            this.soldasBindingSource.DataMember = "soldas";
            this.soldasBindingSource.DataSource = this.bim312DataSet;
            // 
            // soldasTableAdapter
            // 
            this.soldasTableAdapter.ClearBeforeFill = true;
            // 
            // soldasDataGridView
            // 
            this.soldasDataGridView.AutoGenerateColumns = false;
            this.soldasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.soldasDataGridView.DataSource = this.soldasBindingSource;
            this.soldasDataGridView.Location = new System.Drawing.Point(199, 490);
            this.soldasDataGridView.Name = "soldasDataGridView";
            this.soldasDataGridView.RowHeadersWidth = 51;
            this.soldasDataGridView.RowTemplate.Height = 24;
            this.soldasDataGridView.Size = new System.Drawing.Size(428, 220);
            this.soldasDataGridView.TabIndex = 99;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "F_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "F_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Q_Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Q_Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // f_id
            // 
            this.f_id.AutoSize = true;
            this.f_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_id.Location = new System.Drawing.Point(91, 129);
            this.f_id.Name = "f_id";
            this.f_id.Size = new System.Drawing.Size(68, 29);
            this.f_id.TabIndex = 96;
            this.f_id.Text = "F_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "It is enough to write F_ID and ORDER_ID for deleting";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(693, 372);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 32);
            this.clear.TabIndex = 103;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(660, 280);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(144, 46);
            this.update.TabIndex = 102;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(660, 181);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(144, 44);
            this.delete.TabIndex = 101;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(660, 100);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 46);
            this.add.TabIndex = 100;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 106;
            this.label2.Text = "Search :";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(199, 420);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 105;
            this.search.Text = "F_ID";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // SoldAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(899, 759);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.soldasDataGridView);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_order_id);
            this.Controls.Add(this.f_id);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.q_quantity);
            this.Controls.Add(this.txt_f_id);
            this.Controls.Add(this.order_id);
            this.Name = "SoldAs";
            this.Text = "SoldAs";
            this.Load += new System.EventHandler(this.SoldAs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource orderrBindingSource;
        private bim312DataSet bim312DataSet;
        private bim312DataSetTableAdapters.orderrTableAdapter orderrTableAdapter;
        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label q_quantity;
        private System.Windows.Forms.TextBox txt_f_id;
        private bim312DataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource soldasBindingSource;
        private bim312DataSetTableAdapters.soldasTableAdapter soldasTableAdapter;
        private System.Windows.Forms.DataGridView soldasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label f_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}