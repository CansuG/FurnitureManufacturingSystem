
namespace dbms_app
{
    partial class FurnitureColor
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
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bim312DataSet = new dbms_app.bim312DataSet();
            this.furnitureTableAdapter = new dbms_app.bim312DataSetTableAdapters.furnitureTableAdapter();
            this.returnmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.txt_f_id = new System.Windows.Forms.TextBox();
            this.f_id = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clienttTableAdapter = new dbms_app.bim312DataSetTableAdapters.clienttTableAdapter();
            this.tableAdapterManager = new dbms_app.bim312DataSetTableAdapters.TableAdapterManager();
            this.update = new System.Windows.Forms.Button();
            this.clienttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furniturecolorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furniturecolorTableAdapter = new dbms_app.bim312DataSetTableAdapters.furniturecolorTableAdapter();
            this.furniturecolorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.old_color = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniturecolorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniturecolorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "furniture";
            this.furnitureBindingSource.DataSource = this.bim312DataSet;
            // 
            // bim312DataSet
            // 
            this.bim312DataSet.DataSetName = "bim312DataSet";
            this.bim312DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // returnmenu
            // 
            this.returnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmenu.Location = new System.Drawing.Point(10, 22);
            this.returnmenu.Name = "returnmenu";
            this.returnmenu.Size = new System.Drawing.Size(133, 37);
            this.returnmenu.TabIndex = 90;
            this.returnmenu.Text = "Return";
            this.returnmenu.UseVisualStyleBackColor = true;
            this.returnmenu.Click += new System.EventHandler(this.returnmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 44);
            this.label1.TabIndex = 89;
            this.label1.Text = "FURNITURE COLOR TABLE";
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(234, 232);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(207, 36);
            this.txt_color.TabIndex = 84;
            this.txt_color.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(52, 239);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(176, 29);
            this.color.TabIndex = 83;
            this.color.Text = "COLOR (new)";
            // 
            // txt_f_id
            // 
            this.txt_f_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_id.Location = new System.Drawing.Point(234, 152);
            this.txt_f_id.Name = "txt_f_id";
            this.txt_f_id.Size = new System.Drawing.Size(207, 36);
            this.txt_f_id.TabIndex = 78;
            // 
            // f_id
            // 
            this.f_id.AutoSize = true;
            this.f_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_id.Location = new System.Drawing.Point(90, 152);
            this.f_id.Name = "f_id";
            this.f_id.Size = new System.Drawing.Size(68, 29);
            this.f_id.TabIndex = 77;
            this.f_id.Text = "F_ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(692, 206);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 51);
            this.delete.TabIndex = 75;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(692, 118);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(140, 49);
            this.add.TabIndex = 74;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(692, 302);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(140, 52);
            this.update.TabIndex = 76;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // clienttBindingSource
            // 
            this.clienttBindingSource.DataMember = "clientt";
            this.clienttBindingSource.DataSource = this.bim312DataSet;
            // 
            // furniturecolorBindingSource
            // 
            this.furniturecolorBindingSource.DataMember = "furniturecolor";
            this.furniturecolorBindingSource.DataSource = this.bim312DataSet;
            // 
            // furniturecolorTableAdapter
            // 
            this.furniturecolorTableAdapter.ClearBeforeFill = true;
            // 
            // furniturecolorDataGridView
            // 
            this.furniturecolorDataGridView.AutoGenerateColumns = false;
            this.furniturecolorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furniturecolorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.furniturecolorDataGridView.DataSource = this.furniturecolorBindingSource;
            this.furniturecolorDataGridView.Location = new System.Drawing.Point(289, 568);
            this.furniturecolorDataGridView.Name = "furniturecolorDataGridView";
            this.furniturecolorDataGridView.RowHeadersWidth = 51;
            this.furniturecolorDataGridView.RowTemplate.Height = 24;
            this.furniturecolorDataGridView.Size = new System.Drawing.Size(423, 260);
            this.furniturecolorDataGridView.TabIndex = 90;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn2.HeaderText = "Color";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "You need to write  F_ID and Color (new) for deleting";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(721, 378);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 38);
            this.clear.TabIndex = 92;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // old_color
            // 
            this.old_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_color.Location = new System.Drawing.Point(234, 380);
            this.old_color.Name = "old_color";
            this.old_color.Size = new System.Drawing.Size(173, 36);
            this.old_color.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 95;
            this.label2.Text = "COLOR ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "The old color you would like to change for update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 100;
            this.label4.Text = "Search :";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(200, 507);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(207, 36);
            this.search.TabIndex = 99;
            this.search.Text = "F_ID";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // FurnitureColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(914, 870);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.old_color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.furniturecolorDataGridView);
            this.Controls.Add(this.returnmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.color);
            this.Controls.Add(this.txt_f_id);
            this.Controls.Add(this.f_id);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Name = "FurnitureColor";
            this.Text = "FurnitureColor";
            this.Load += new System.EventHandler(this.FurnitureColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bim312DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniturecolorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniturecolorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private bim312DataSet bim312DataSet;
        private bim312DataSetTableAdapters.furnitureTableAdapter furnitureTableAdapter;
        private System.Windows.Forms.Button returnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TextBox txt_f_id;
        private System.Windows.Forms.Label f_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private bim312DataSetTableAdapters.clienttTableAdapter clienttTableAdapter;
        private bim312DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.BindingSource clienttBindingSource;
        private System.Windows.Forms.BindingSource furniturecolorBindingSource;
        private bim312DataSetTableAdapters.furniturecolorTableAdapter furniturecolorTableAdapter;
        private System.Windows.Forms.DataGridView furniturecolorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox old_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search;
    }
}