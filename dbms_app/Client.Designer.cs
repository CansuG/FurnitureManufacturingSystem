
namespace dbms_app
{
    partial class Client
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
            this.returnmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clname = new System.Windows.Forms.Label();
            this.cltelnum = new System.Windows.Forms.Label();
            this.clfulladdress = new System.Windows.Forms.Label();
            this.clcity = new System.Windows.Forms.Label();
            this.clemail = new System.Windows.Forms.Label();
            this.cl_id = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clienttDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.clienttTableAdapter = new dbms_app.bim312DataSetTableAdapters.clienttTableAdapter();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienttDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(11, 19);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 55;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.returnmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(466, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 44);
            this.label1.TabIndex = 54;
            this.label1.Text = "CLIENT TABLE";
            // 
            // clname
            // 
            this.clname.AutoSize = true;
            this.clname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clname.Location = new System.Drawing.Point(60, 230);
            this.clname.Name = "clname";
            this.clname.Size = new System.Drawing.Size(118, 29);
            this.clname.TabIndex = 48;
            this.clname.Text = "CLNAME";
            // 
            // cltelnum
            // 
            this.cltelnum.AutoSize = true;
            this.cltelnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cltelnum.Location = new System.Drawing.Point(540, 315);
            this.cltelnum.Name = "cltelnum";
            this.cltelnum.Size = new System.Drawing.Size(151, 29);
            this.cltelnum.TabIndex = 46;
            this.cltelnum.Text = "CLTELNUM";
            // 
            // clfulladdress
            // 
            this.clfulladdress.AutoSize = true;
            this.clfulladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clfulladdress.Location = new System.Drawing.Point(538, 153);
            this.clfulladdress.Name = "clfulladdress";
            this.clfulladdress.Size = new System.Drawing.Size(228, 29);
            this.clfulladdress.TabIndex = 44;
            this.clfulladdress.Text = "CLFULLADDRESS";
            // 
            // clcity
            // 
            this.clcity.AutoSize = true;
            this.clcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clcity.Location = new System.Drawing.Point(538, 233);
            this.clcity.Name = "clcity";
            this.clcity.Size = new System.Drawing.Size(104, 29);
            this.clcity.TabIndex = 36;
            this.clcity.Text = "CLCITY";
            // 
            // clemail
            // 
            this.clemail.AutoSize = true;
            this.clemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clemail.Location = new System.Drawing.Point(58, 323);
            this.clemail.Name = "clemail";
            this.clemail.Size = new System.Drawing.Size(120, 29);
            this.clemail.TabIndex = 34;
            this.clemail.Text = "CLEMAIL";
            // 
            // cl_id
            // 
            this.cl_id.AutoSize = true;
            this.cl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_id.Location = new System.Drawing.Point(60, 146);
            this.cl_id.Name = "cl_id";
            this.cl_id.Size = new System.Drawing.Size(84, 29);
            this.cl_id.TabIndex = 32;
            this.cl_id.Text = "CL_ID";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1153, 288);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 63);
            this.update.TabIndex = 31;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(1153, 187);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 57);
            this.delete.TabIndex = 30;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1153, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 59);
            this.add.TabIndex = 29;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clienttDataGridView
            // 
            this.clienttDataGridView.AutoGenerateColumns = false;
            this.clienttDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienttDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clienttDataGridView.DataSource = this.clienttBindingSource;
            this.clienttDataGridView.Location = new System.Drawing.Point(63, 512);
            this.clienttDataGridView.Name = "clienttDataGridView";
            this.clienttDataGridView.RowHeadersWidth = 51;
            this.clienttDataGridView.RowTemplate.Height = 24;
            this.clienttDataGridView.Size = new System.Drawing.Size(1090, 220);
            this.clienttDataGridView.TabIndex = 56;
            this.clienttDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienttDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cl_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cl_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClEmail";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClEmail";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClCity";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClCity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClFullAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "ClFullAddress";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClTelNum";
            this.dataGridViewTextBoxColumn5.HeaderText = "ClTelNum";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClName";
            this.dataGridViewTextBoxColumn6.HeaderText = "ClName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
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
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(783, 315);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(207, 36);
            this.txt_tel.TabIndex = 62;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(783, 229);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(207, 36);
            this.txt_city.TabIndex = 63;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(783, 142);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(207, 36);
            this.txt_address.TabIndex = 64;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(202, 319);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(207, 36);
            this.txt_mail.TabIndex = 65;
            this.txt_mail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(202, 226);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 36);
            this.txt_name.TabIndex = 66;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(202, 146);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 36);
            this.txt_id.TabIndex = 67;
            // 
            // clienttTableAdapter
            // 
            this.clienttTableAdapter.ClearBeforeFill = true;
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
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(1200, 387);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 38);
            this.clear.TabIndex = 68;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1038, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "It is enough to write just CL_ID for deleting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 84;
            this.label2.Text = "Search :";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(202, 456);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 83;
            this.search.Text = "Cl_ID";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1370, 754);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.clienttDataGridView);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clname);
            this.Controls.Add(this.cltelnum);
            this.Controls.Add(this.clfulladdress);
            this.Controls.Add(this.clcity);
            this.Controls.Add(this.clemail);
            this.Controls.Add(this.cl_id);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienttDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clname;
        private System.Windows.Forms.Label cltelnum;
        private System.Windows.Forms.Label clfulladdress;
        private System.Windows.Forms.Label clcity;
        private System.Windows.Forms.Label clemail;
        private System.Windows.Forms.Label cl_id;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private bim312DataSet bim312DataSet;
        private System.Windows.Forms.BindingSource clienttBindingSource;
        private bim312DataSetTableAdapters.clienttTableAdapter clienttTableAdapter;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clienttDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}