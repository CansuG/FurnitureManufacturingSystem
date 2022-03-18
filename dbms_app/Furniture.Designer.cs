
namespace dbms_app
{
    partial class Furniture
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
            this.clienttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.clienttTableAdapter = new dbms_app.bim312DataSetTableAdapters.clienttTableAdapter();
            this.returnmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.com_id = new System.Windows.Forms.Label();
            this.ftype = new System.Windows.Forms.Label();
            this.mdate = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.txt_f_id = new System.Windows.Forms.TextBox();
            this.f_id = new System.Windows.Forms.Label();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureTableAdapter = new dbms_app.bim312DataSetTableAdapters.furnitureTableAdapter();
            this.furnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_com_id = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienttBindingSource
            // 
            this.clienttBindingSource.DataMember = "clientt";
            this.clienttBindingSource.DataSource = this.bim312DataSet;
            // 
            // bim312DataSet
            // 
            this.bim312DataSet.DataSetName = "bim312DataSet";
            this.bim312DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienttTableAdapter = this.clienttTableAdapter;
            this.tableAdapterManager.companyTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.furniturecolorTableAdapter = null;
            this.tableAdapterManager.furnitureTableAdapter = null;
            this.tableAdapterManager.orderrTableAdapter = null;
            this.tableAdapterManager.soldasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbms_app.bim312DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienttTableAdapter
            // 
            this.clienttTableAdapter.ClearBeforeFill = true;
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(25, 27);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 73;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.returnmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(486, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 44);
            this.label1.TabIndex = 72;
            this.label1.Text = "FURNITURE TABLE";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(60, 220);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(144, 29);
            this.quantity.TabIndex = 70;
            this.quantity.Text = "QUANTITY";
            // 
            // com_id
            // 
            this.com_id.AutoSize = true;
            this.com_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_id.Location = new System.Drawing.Point(598, 314);
            this.com_id.Name = "com_id";
            this.com_id.Size = new System.Drawing.Size(111, 29);
            this.com_id.TabIndex = 68;
            this.com_id.Text = "COM_ID";
            // 
            // ftype
            // 
            this.ftype.AutoSize = true;
            this.ftype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftype.Location = new System.Drawing.Point(596, 152);
            this.ftype.Name = "ftype";
            this.ftype.Size = new System.Drawing.Size(97, 29);
            this.ftype.TabIndex = 66;
            this.ftype.Text = "FTYPE";
            // 
            // mdate
            // 
            this.mdate.AutoSize = true;
            this.mdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdate.Location = new System.Drawing.Point(596, 232);
            this.mdate.Name = "mdate";
            this.mdate.Size = new System.Drawing.Size(102, 29);
            this.mdate.TabIndex = 64;
            this.mdate.Text = "MDATE";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(66, 313);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(90, 29);
            this.price.TabIndex = 62;
            this.price.Text = "PRICE";
            // 
            // txt_f_id
            // 
            this.txt_f_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_id.Location = new System.Drawing.Point(222, 136);
            this.txt_f_id.Name = "txt_f_id";
            this.txt_f_id.Size = new System.Drawing.Size(207, 36);
            this.txt_f_id.TabIndex = 61;
            // 
            // f_id
            // 
            this.f_id.AutoSize = true;
            this.f_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_id.Location = new System.Drawing.Point(60, 136);
            this.f_id.Name = "f_id";
            this.f_id.Size = new System.Drawing.Size(68, 29);
            this.f_id.TabIndex = 60;
            this.f_id.Text = "F_ID";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "furniture";
            this.furnitureBindingSource.DataSource = this.bim312DataSet;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // furnitureDataGridView
            // 
            this.furnitureDataGridView.AutoGenerateColumns = false;
            this.furnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.furnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.furnitureDataGridView.Location = new System.Drawing.Point(65, 552);
            this.furnitureDataGridView.Name = "furnitureDataGridView";
            this.furnitureDataGridView.RowHeadersWidth = 51;
            this.furnitureDataGridView.RowTemplate.Height = 24;
            this.furnitureDataGridView.Size = new System.Drawing.Size(1094, 211);
            this.furnitureDataGridView.TabIndex = 73;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FType";
            this.dataGridViewTextBoxColumn4.HeaderText = "FType";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mdate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mdate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Com_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Com_ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(222, 221);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(207, 36);
            this.txt_quantity.TabIndex = 74;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(222, 306);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(207, 36);
            this.txt_price.TabIndex = 75;
            // 
            // txt_com_id
            // 
            this.txt_com_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_com_id.Location = new System.Drawing.Point(752, 314);
            this.txt_com_id.Name = "txt_com_id";
            this.txt_com_id.Size = new System.Drawing.Size(207, 36);
            this.txt_com_id.TabIndex = 76;
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(752, 232);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(207, 36);
            this.txt_date.TabIndex = 77;
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type.Location = new System.Drawing.Point(752, 152);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(207, 36);
            this.txt_type.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1021, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "It is enough to write F_ID and COM_ID for deleting";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(1174, 397);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 38);
            this.clear.TabIndex = 82;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1127, 298);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 63);
            this.update.TabIndex = 81;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(1127, 197);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 57);
            this.delete.TabIndex = 80;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1127, 99);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 59);
            this.add.TabIndex = 79;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = "Search :";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(187, 473);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 84;
            this.search.Text = "F_ID";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Furniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1426, 775);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_com_id);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.furnitureDataGridView);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.com_id);
            this.Controls.Add(this.ftype);
            this.Controls.Add(this.mdate);
            this.Controls.Add(this.price);
            this.Controls.Add(this.txt_f_id);
            this.Controls.Add(this.f_id);
            this.Name = "Furniture";
            this.Text = "Furniture";
            this.Load += new System.EventHandler(this.Furniture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clienttBindingSource;
        private bim312DataSet bim312DataSet;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bim312DataSetTableAdapters.clienttTableAdapter clienttTableAdapter;
        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label com_id;
        private System.Windows.Forms.Label ftype;
        private System.Windows.Forms.Label mdate;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txt_f_id;
        private System.Windows.Forms.Label f_id;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private bim312DataSetTableAdapters.furnitureTableAdapter furnitureTableAdapter;
        private System.Windows.Forms.DataGridView furnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_com_id;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}