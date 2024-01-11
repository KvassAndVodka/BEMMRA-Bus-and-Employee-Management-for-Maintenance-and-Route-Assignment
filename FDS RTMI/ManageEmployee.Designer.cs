namespace FDS_RTMI
{
    partial class ManageEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_AddEmployee = new System.Windows.Forms.DataGridView();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.rTMIDataSet = new FDS_RTMI.RTMIDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new FDS_RTMI.RTMIDataSetTableAdapters.employeeTableAdapter();
            this.panel_ManageEmployee = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_employeeRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_employmentDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_employeeAddress = new System.Windows.Forms.TextBox();
            this.button_EmployeeAdd = new System.Windows.Forms.Button();
            this.button_EmployeeDelete = new System.Windows.Forms.Button();
            this.button_EmployeeUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_yearsEmployed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AddEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTMIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.panel_ManageEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_AddEmployee
            // 
            this.dataGrid_AddEmployee.AllowUserToAddRows = false;
            this.dataGrid_AddEmployee.AllowUserToDeleteRows = false;
            this.dataGrid_AddEmployee.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGrid_AddEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_AddEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_AddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_AddEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_AddEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_AddEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_AddEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_AddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_AddEmployee.EnableHeadersVisualStyles = false;
            this.dataGrid_AddEmployee.Location = new System.Drawing.Point(0, 70);
            this.dataGrid_AddEmployee.Name = "dataGrid_AddEmployee";
            this.dataGrid_AddEmployee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_AddEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_AddEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_AddEmployee.Size = new System.Drawing.Size(934, 352);
            this.dataGrid_AddEmployee.TabIndex = 0;
            this.dataGrid_AddEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_AddEmployee_CellClick);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstName.Location = new System.Drawing.Point(117, 17);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(181, 26);
            this.textBox_firstName.TabIndex = 1;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_FirstName.Location = new System.Drawing.Point(13, 19);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(93, 19);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "First Name:";
            // 
            // rTMIDataSet
            // 
            this.rTMIDataSet.DataSetName = "RTMIDataSet";
            this.rTMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.rTMIDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel_ManageEmployee
            // 
            this.panel_ManageEmployee.BackColor = System.Drawing.Color.DimGray;
            this.panel_ManageEmployee.Controls.Add(this.label2);
            this.panel_ManageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ManageEmployee.Location = new System.Drawing.Point(0, 0);
            this.panel_ManageEmployee.Name = "panel_ManageEmployee";
            this.panel_ManageEmployee.Size = new System.Drawing.Size(934, 70);
            this.panel_ManageEmployee.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Product Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(934, 70);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Employee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_LastName.Location = new System.Drawing.Point(14, 55);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(92, 19);
            this.label_LastName.TabIndex = 6;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastName.Location = new System.Drawing.Point(116, 53);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(181, 26);
            this.textBox_lastName.TabIndex = 5;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_Gender.Location = new System.Drawing.Point(39, 91);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(67, 19);
            this.label_Gender.TabIndex = 8;
            this.label_Gender.Text = "Gender:";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(116, 89);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(178, 27);
            this.comboBox_Gender.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(395, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Role:";
            // 
            // comboBox_employeeRole
            // 
            this.comboBox_employeeRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_employeeRole.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_employeeRole.FormattingEnabled = true;
            this.comboBox_employeeRole.Items.AddRange(new object[] {
            "Driver",
            "Conductor"});
            this.comboBox_employeeRole.Location = new System.Drawing.Point(453, 88);
            this.comboBox_employeeRole.Name = "comboBox_employeeRole";
            this.comboBox_employeeRole.Size = new System.Drawing.Size(302, 27);
            this.comboBox_employeeRole.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(320, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date Employed:";
            // 
            // dateTimePicker_employmentDate
            // 
            this.dateTimePicker_employmentDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_employmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_employmentDate.Location = new System.Drawing.Point(453, 52);
            this.dateTimePicker_employmentDate.Name = "dateTimePicker_employmentDate";
            this.dateTimePicker_employmentDate.Size = new System.Drawing.Size(302, 27);
            this.dateTimePicker_employmentDate.TabIndex = 14;
            // 
            // dateTimePicker_birthdate
            // 
            this.dateTimePicker_birthdate.CustomFormat = "";
            this.dateTimePicker_birthdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthdate.Location = new System.Drawing.Point(116, 125);
            this.dateTimePicker_birthdate.Name = "dateTimePicker_birthdate";
            this.dateTimePicker_birthdate.Size = new System.Drawing.Size(177, 27);
            this.dateTimePicker_birthdate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(367, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address:";
            // 
            // textBox_employeeAddress
            // 
            this.textBox_employeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_employeeAddress.Location = new System.Drawing.Point(453, 18);
            this.textBox_employeeAddress.Multiline = true;
            this.textBox_employeeAddress.Name = "textBox_employeeAddress";
            this.textBox_employeeAddress.Size = new System.Drawing.Size(302, 25);
            this.textBox_employeeAddress.TabIndex = 17;
            // 
            // button_EmployeeAdd
            // 
            this.button_EmployeeAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_EmployeeAdd.BackColor = System.Drawing.Color.Lime;
            this.button_EmployeeAdd.FlatAppearance.BorderSize = 0;
            this.button_EmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EmployeeAdd.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EmployeeAdd.Location = new System.Drawing.Point(786, 127);
            this.button_EmployeeAdd.Name = "button_EmployeeAdd";
            this.button_EmployeeAdd.Size = new System.Drawing.Size(136, 50);
            this.button_EmployeeAdd.TabIndex = 19;
            this.button_EmployeeAdd.Text = "ADD";
            this.button_EmployeeAdd.UseVisualStyleBackColor = false;
            this.button_EmployeeAdd.Click += new System.EventHandler(this.button_EmployeeAdd_Click);
            // 
            // button_EmployeeDelete
            // 
            this.button_EmployeeDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_EmployeeDelete.BackColor = System.Drawing.Color.Firebrick;
            this.button_EmployeeDelete.FlatAppearance.BorderSize = 0;
            this.button_EmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EmployeeDelete.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EmployeeDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_EmployeeDelete.Location = new System.Drawing.Point(786, 71);
            this.button_EmployeeDelete.Name = "button_EmployeeDelete";
            this.button_EmployeeDelete.Size = new System.Drawing.Size(136, 50);
            this.button_EmployeeDelete.TabIndex = 20;
            this.button_EmployeeDelete.Text = "DELETE";
            this.button_EmployeeDelete.UseVisualStyleBackColor = false;
            this.button_EmployeeDelete.Click += new System.EventHandler(this.button_EmployeeDelete_Click);
            // 
            // button_EmployeeUpdate
            // 
            this.button_EmployeeUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_EmployeeUpdate.BackColor = System.Drawing.Color.Gold;
            this.button_EmployeeUpdate.FlatAppearance.BorderSize = 0;
            this.button_EmployeeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EmployeeUpdate.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EmployeeUpdate.ForeColor = System.Drawing.Color.Black;
            this.button_EmployeeUpdate.Location = new System.Drawing.Point(786, 17);
            this.button_EmployeeUpdate.Name = "button_EmployeeUpdate";
            this.button_EmployeeUpdate.Size = new System.Drawing.Size(136, 50);
            this.button_EmployeeUpdate.TabIndex = 21;
            this.button_EmployeeUpdate.Text = "UPDATE";
            this.button_EmployeeUpdate.UseVisualStyleBackColor = false;
            this.button_EmployeeUpdate.Click += new System.EventHandler(this.button_EmployeeUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label_yearsEmployed);
            this.panel1.Controls.Add(this.button_EmployeeUpdate);
            this.panel1.Controls.Add(this.button_EmployeeDelete);
            this.panel1.Controls.Add(this.label_Gender);
            this.panel1.Controls.Add(this.button_EmployeeAdd);
            this.panel1.Controls.Add(this.label_FirstName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_LastName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_employeeRole);
            this.panel1.Controls.Add(this.dateTimePicker_employmentDate);
            this.panel1.Controls.Add(this.textBox_employeeAddress);
            this.panel1.Controls.Add(this.dateTimePicker_birthdate);
            this.panel1.Controls.Add(this.comboBox_Gender);
            this.panel1.Controls.Add(this.textBox_lastName);
            this.panel1.Controls.Add(this.textBox_firstName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 189);
            this.panel1.TabIndex = 22;
            // 
            // label_yearsEmployed
            // 
            this.label_yearsEmployed.AutoSize = true;
            this.label_yearsEmployed.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_yearsEmployed.Location = new System.Drawing.Point(311, 127);
            this.label_yearsEmployed.Name = "label_yearsEmployed";
            this.label_yearsEmployed.Size = new System.Drawing.Size(130, 19);
            this.label_yearsEmployed.TabIndex = 22;
            this.label_yearsEmployed.Text = "Years Employed:";
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dataGrid_AddEmployee);
            this.Controls.Add(this.panel_ManageEmployee);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ManageEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AddEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTMIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.panel_ManageEmployee.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_AddEmployee;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_FirstName;
        private RTMIDataSet rTMIDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RTMIDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Panel panel_ManageEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_employeeRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_employmentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_employeeAddress;
        private System.Windows.Forms.Button button_EmployeeAdd;
        private System.Windows.Forms.Button button_EmployeeDelete;
        private System.Windows.Forms.Button button_EmployeeUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_yearsEmployed;
    }
}