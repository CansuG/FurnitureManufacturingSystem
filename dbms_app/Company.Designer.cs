
namespace dbms_app
{
    partial class Company
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
            this.comname = new System.Windows.Forms.Label();
            this.comaddress = new System.Windows.Forms.Label();
            this.comptel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.com_id = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.companyTableAdapter = new dbms_app.bim312DataSetTableAdapters.companyTableAdapter();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(15, 27);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 72;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.returnmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 44);
            this.label1.TabIndex = 71;
            this.label1.Text = "COMPANY TABLE";
            // 
            // comname
            // 
            this.comname.AutoSize = true;
            this.comname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comname.Location = new System.Drawing.Point(73, 220);
            this.comname.Name = "comname";
            this.comname.Size = new System.Drawing.Size(145, 29);
            this.comname.TabIndex = 69;
            this.comname.Text = "COMNAME";
            // 
            // comaddress
            // 
            this.comaddress.AutoSize = true;
            this.comaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comaddress.Location = new System.Drawing.Point(553, 177);
            this.comaddress.Name = "comaddress";
            this.comaddress.Size = new System.Drawing.Size(193, 29);
            this.comaddress.TabIndex = 65;
            this.comaddress.Text = "COMADDRESS";
            // 
            // comptel
            // 
            this.comptel.AutoSize = true;
            this.comptel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comptel.Location = new System.Drawing.Point(553, 257);
            this.comptel.Name = "comptel";
            this.comptel.Size = new System.Drawing.Size(137, 29);
            this.comptel.TabIndex = 63;
            this.comptel.Text = "COMPTEL";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(73, 305);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(88, 29);
            this.email.TabIndex = 61;
            this.email.Text = "EMAIL";
            // 
            // com_id
            // 
            this.com_id.AutoSize = true;
            this.com_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_id.Location = new System.Drawing.Point(73, 136);
            this.com_id.Name = "com_id";
            this.com_id.Size = new System.Drawing.Size(111, 29);
            this.com_id.TabIndex = 59;
            this.com_id.Text = "COM_ID";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1132, 271);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 63);
            this.update.TabIndex = 58;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(1132, 170);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 57);
            this.delete.TabIndex = 57;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1132, 72);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 59);
            this.add.TabIndex = 56;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.AutoGenerateColumns = false;
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.companyDataGridView.DataSource = this.companyBindingSource;
            this.companyDataGridView.Location = new System.Drawing.Point(82, 481);
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.RowHeadersWidth = 51;
            this.companyDataGridView.RowTemplate.Height = 24;
            this.companyDataGridView.Size = new System.Drawing.Size(927, 220);
            this.companyDataGridView.TabIndex = 73;
            this.companyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyDataGridView_CellContentClick);
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(755, 250);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(207, 36);
            this.txt_tel.TabIndex = 74;
            this.txt_tel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(755, 170);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(207, 36);
            this.txt_address.TabIndex = 75;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(241, 305);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(207, 36);
            this.txt_mail.TabIndex = 76;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(241, 213);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 36);
            this.txt_name.TabIndex = 77;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(241, 136);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 36);
            this.txt_id.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "It is enough to write just COM_ID for deleting";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(1180, 366);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 38);
            this.clear.TabIndex = 80;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(201, 407);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 81;
            this.search.Text = "Com_ID";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Com_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Com_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompTel";
            this.dataGridViewTextBoxColumn3.HeaderText = "CompTel";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ComName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ComName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ComAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "ComAddress";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Search :";
            // 
            // Company
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1403, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comname);
            this.Controls.Add(this.comaddress);
            this.Controls.Add(this.comptel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.com_id);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label comname;
        private System.Windows.Forms.Label comaddress;
        private System.Windows.Forms.Label comptel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label com_id;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private bim312DataSet bim312DataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private bim312DataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
    }
}