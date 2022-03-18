
namespace dbms_app
{
    partial class Employee
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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.ssn = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.etelnum = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.com_id = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.eaddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnmenu = new System.Windows.Forms.Button();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_com_id = new System.Windows.Forms.TextBox();
            this.txt_startdate = new System.Windows.Forms.TextBox();
            this.txt_bdate = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_ssn = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new dbms_app.bim312DataSetTableAdapters.employeeTableAdapter();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(70, 664);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(1428, 229);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SSN";
            this.dataGridViewTextBoxColumn1.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ETelNum";
            this.dataGridViewTextBoxColumn5.HeaderText = "ETelNum";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn6.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EAddress";
            this.dataGridViewTextBoxColumn7.HeaderText = "EAddress";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "BDate";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Com_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Com_ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.bim312DataSet;
            // 
            // bim312DataSet
            // 
            this.bim312DataSet.DataSetName = "bim312DataSet";
            this.bim312DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ssn
            // 
            this.ssn.AutoSize = true;
            this.ssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssn.Location = new System.Drawing.Point(123, 90);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(66, 29);
            this.ssn.TabIndex = 5;
            this.ssn.Text = "SSN";
            this.ssn.Click += new System.EventHandler(this.label1_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(123, 172);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(102, 29);
            this.fname.TabIndex = 7;
            this.fname.Text = "FNAME";
            this.fname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // mname
            // 
            this.mname.AutoSize = true;
            this.mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(123, 250);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(107, 29);
            this.mname.TabIndex = 9;
            this.mname.Text = "MNAME";
            this.mname.Click += new System.EventHandler(this.label2_Click);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(123, 504);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(111, 29);
            this.salary.TabIndex = 15;
            this.salary.Text = "SALARY";
            this.salary.Click += new System.EventHandler(this.label3_Click);
            // 
            // etelnum
            // 
            this.etelnum.AutoSize = true;
            this.etelnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etelnum.Location = new System.Drawing.Point(123, 415);
            this.etelnum.Name = "etelnum";
            this.etelnum.Size = new System.Drawing.Size(136, 29);
            this.etelnum.TabIndex = 13;
            this.etelnum.Text = "ETELNUM";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(123, 330);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 29);
            this.lname.TabIndex = 11;
            this.lname.Text = "LNAME";
            // 
            // com_id
            // 
            this.com_id.AutoSize = true;
            this.com_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_id.Location = new System.Drawing.Point(602, 456);
            this.com_id.Name = "com_id";
            this.com_id.Size = new System.Drawing.Size(111, 29);
            this.com_id.TabIndex = 25;
            this.com_id.Text = "COM_ID";
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Location = new System.Drawing.Point(602, 371);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(166, 29);
            this.startdate.TabIndex = 23;
            this.startdate.Text = "STARTDATE";
            // 
            // bdate
            // 
            this.bdate.AutoSize = true;
            this.bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Location = new System.Drawing.Point(602, 295);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(98, 29);
            this.bdate.TabIndex = 21;
            this.bdate.Text = "BDATE";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(602, 213);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 29);
            this.gender.TabIndex = 19;
            this.gender.Text = "GENDER";
            // 
            // eaddress
            // 
            this.eaddress.AutoSize = true;
            this.eaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eaddress.Location = new System.Drawing.Point(602, 131);
            this.eaddress.Name = "eaddress";
            this.eaddress.Size = new System.Drawing.Size(151, 29);
            this.eaddress.TabIndex = 17;
            this.eaddress.Text = "EADDRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(473, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "EMPLOYEE TABLE";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(12, 31);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 28;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(277, 504);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(207, 36);
            this.txt_salary.TabIndex = 62;
            // 
            // txt_com_id
            // 
            this.txt_com_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_com_id.Location = new System.Drawing.Point(785, 452);
            this.txt_com_id.Name = "txt_com_id";
            this.txt_com_id.Size = new System.Drawing.Size(207, 36);
            this.txt_com_id.TabIndex = 63;
            // 
            // txt_startdate
            // 
            this.txt_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_startdate.Location = new System.Drawing.Point(785, 371);
            this.txt_startdate.Name = "txt_startdate";
            this.txt_startdate.Size = new System.Drawing.Size(207, 36);
            this.txt_startdate.TabIndex = 64;
            // 
            // txt_bdate
            // 
            this.txt_bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bdate.Location = new System.Drawing.Point(785, 291);
            this.txt_bdate.Name = "txt_bdate";
            this.txt_bdate.Size = new System.Drawing.Size(207, 36);
            this.txt_bdate.TabIndex = 65;
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender.Location = new System.Drawing.Point(785, 209);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(207, 36);
            this.txt_gender.TabIndex = 66;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(785, 131);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(207, 36);
            this.txt_address.TabIndex = 67;
            // 
            // txt_ssn
            // 
            this.txt_ssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ssn.Location = new System.Drawing.Point(277, 90);
            this.txt_ssn.Name = "txt_ssn";
            this.txt_ssn.Size = new System.Drawing.Size(207, 36);
            this.txt_ssn.TabIndex = 72;
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(277, 168);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(207, 36);
            this.txt_fname.TabIndex = 71;
            // 
            // txt_mname
            // 
            this.txt_mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(277, 250);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(207, 36);
            this.txt_mname.TabIndex = 70;
            this.txt_mname.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(277, 330);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(207, 36);
            this.txt_lname.TabIndex = 69;
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(277, 411);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(207, 36);
            this.txt_tel.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1079, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "It is enough to write SSN and COM_ID for deleting";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(1232, 436);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 38);
            this.clear.TabIndex = 76;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1185, 337);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 63);
            this.update.TabIndex = 75;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(1185, 236);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 57);
            this.delete.TabIndex = 74;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1185, 138);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 59);
            this.add.TabIndex = 73;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienttTableAdapter = null;
            this.tableAdapterManager.companyTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
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
            this.label2.Location = new System.Drawing.Point(73, 605);
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
            this.search.Location = new System.Drawing.Point(197, 601);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 83;
            this.search.Text = "SSN";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1540, 920);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txt_ssn);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_bdate);
            this.Controls.Add(this.txt_startdate);
            this.Controls.Add(this.txt_com_id);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_id);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.eaddress);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.etelnum);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bim312DataSet bim312DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private bim312DataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label ssn;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label mname;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label etelnum;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label com_id;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label bdate;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label eaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_com_id;
        private System.Windows.Forms.TextBox txt_startdate;
        private System.Windows.Forms.TextBox txt_bdate;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_ssn;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}