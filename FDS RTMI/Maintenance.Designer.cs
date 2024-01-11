namespace FDS_RTMI
{
    partial class Maintenance
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
            this.button_MaintenanceUpdate = new System.Windows.Forms.Button();
            this.button_MaintenanceDelete = new System.Windows.Forms.Button();
            this.button_MaintenanceAdd = new System.Windows.Forms.Button();
            this.label_maintenanceBusID = new System.Windows.Forms.Label();
            this.label_maintenanceDamages = new System.Windows.Forms.Label();
            this.label_maintenanceDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_maintenanceBusID = new System.Windows.Forms.ComboBox();
            this.label_maintenanceStatus = new System.Windows.Forms.Label();
            this.textBox_Remarks = new System.Windows.Forms.TextBox();
            this.dateTimePicker_maintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_maintenanceStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ManageEmployee = new System.Windows.Forms.Panel();
            this.employeeTableAdapter = new FDS_RTMI.RTMIDataSetTableAdapters.employeeTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rTMIDataSet = new FDS_RTMI.RTMIDataSet();
            this.dataGrid_Maintenance = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_ManageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTMIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Maintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MaintenanceUpdate
            // 
            this.button_MaintenanceUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_MaintenanceUpdate.BackColor = System.Drawing.Color.Gold;
            this.button_MaintenanceUpdate.FlatAppearance.BorderSize = 0;
            this.button_MaintenanceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MaintenanceUpdate.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MaintenanceUpdate.ForeColor = System.Drawing.Color.Black;
            this.button_MaintenanceUpdate.Location = new System.Drawing.Point(786, 17);
            this.button_MaintenanceUpdate.Name = "button_MaintenanceUpdate";
            this.button_MaintenanceUpdate.Size = new System.Drawing.Size(136, 50);
            this.button_MaintenanceUpdate.TabIndex = 21;
            this.button_MaintenanceUpdate.Text = "UPDATE";
            this.button_MaintenanceUpdate.UseVisualStyleBackColor = false;
            this.button_MaintenanceUpdate.Click += new System.EventHandler(this.button_MaintenanceUpdate_Click);
            // 
            // button_MaintenanceDelete
            // 
            this.button_MaintenanceDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_MaintenanceDelete.BackColor = System.Drawing.Color.Firebrick;
            this.button_MaintenanceDelete.FlatAppearance.BorderSize = 0;
            this.button_MaintenanceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MaintenanceDelete.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MaintenanceDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_MaintenanceDelete.Location = new System.Drawing.Point(786, 71);
            this.button_MaintenanceDelete.Name = "button_MaintenanceDelete";
            this.button_MaintenanceDelete.Size = new System.Drawing.Size(136, 50);
            this.button_MaintenanceDelete.TabIndex = 20;
            this.button_MaintenanceDelete.Text = "DELETE";
            this.button_MaintenanceDelete.UseVisualStyleBackColor = false;
            this.button_MaintenanceDelete.Click += new System.EventHandler(this.button_MaintenanceDelete_Click);
            // 
            // button_MaintenanceAdd
            // 
            this.button_MaintenanceAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_MaintenanceAdd.BackColor = System.Drawing.Color.Lime;
            this.button_MaintenanceAdd.FlatAppearance.BorderSize = 0;
            this.button_MaintenanceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MaintenanceAdd.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MaintenanceAdd.Location = new System.Drawing.Point(786, 127);
            this.button_MaintenanceAdd.Name = "button_MaintenanceAdd";
            this.button_MaintenanceAdd.Size = new System.Drawing.Size(136, 50);
            this.button_MaintenanceAdd.TabIndex = 19;
            this.button_MaintenanceAdd.Text = "ADD";
            this.button_MaintenanceAdd.UseVisualStyleBackColor = false;
            this.button_MaintenanceAdd.Click += new System.EventHandler(this.button_MaintenanceAdd_Click);
            // 
            // label_maintenanceBusID
            // 
            this.label_maintenanceBusID.AutoSize = true;
            this.label_maintenanceBusID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_maintenanceBusID.Location = new System.Drawing.Point(46, 18);
            this.label_maintenanceBusID.Name = "label_maintenanceBusID";
            this.label_maintenanceBusID.Size = new System.Drawing.Size(60, 19);
            this.label_maintenanceBusID.TabIndex = 2;
            this.label_maintenanceBusID.Text = "Bus ID:";
            // 
            // label_maintenanceDamages
            // 
            this.label_maintenanceDamages.AutoSize = true;
            this.label_maintenanceDamages.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_maintenanceDamages.Location = new System.Drawing.Point(367, 24);
            this.label_maintenanceDamages.Name = "label_maintenanceDamages";
            this.label_maintenanceDamages.Size = new System.Drawing.Size(79, 19);
            this.label_maintenanceDamages.TabIndex = 18;
            this.label_maintenanceDamages.Text = "Remarks:";
            // 
            // label_maintenanceDate
            // 
            this.label_maintenanceDate.AutoSize = true;
            this.label_maintenanceDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_maintenanceDate.Location = new System.Drawing.Point(59, 91);
            this.label_maintenanceDate.Name = "label_maintenanceDate";
            this.label_maintenanceDate.Size = new System.Drawing.Size(47, 19);
            this.label_maintenanceDate.TabIndex = 15;
            this.label_maintenanceDate.Text = "Date:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.comboBox_maintenanceBusID);
            this.panel1.Controls.Add(this.button_MaintenanceUpdate);
            this.panel1.Controls.Add(this.button_MaintenanceDelete);
            this.panel1.Controls.Add(this.label_maintenanceStatus);
            this.panel1.Controls.Add(this.button_MaintenanceAdd);
            this.panel1.Controls.Add(this.label_maintenanceBusID);
            this.panel1.Controls.Add(this.label_maintenanceDamages);
            this.panel1.Controls.Add(this.label_maintenanceDate);
            this.panel1.Controls.Add(this.textBox_Remarks);
            this.panel1.Controls.Add(this.dateTimePicker_maintenanceDate);
            this.panel1.Controls.Add(this.comboBox_maintenanceStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 189);
            this.panel1.TabIndex = 25;
            // 
            // comboBox_maintenanceBusID
            // 
            this.comboBox_maintenanceBusID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maintenanceBusID.FormattingEnabled = true;
            this.comboBox_maintenanceBusID.Location = new System.Drawing.Point(116, 17);
            this.comboBox_maintenanceBusID.Name = "comboBox_maintenanceBusID";
            this.comboBox_maintenanceBusID.Size = new System.Drawing.Size(178, 27);
            this.comboBox_maintenanceBusID.TabIndex = 23;
            // 
            // label_maintenanceStatus
            // 
            this.label_maintenanceStatus.AutoSize = true;
            this.label_maintenanceStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_maintenanceStatus.Location = new System.Drawing.Point(46, 55);
            this.label_maintenanceStatus.Name = "label_maintenanceStatus";
            this.label_maintenanceStatus.Size = new System.Drawing.Size(60, 19);
            this.label_maintenanceStatus.TabIndex = 8;
            this.label_maintenanceStatus.Text = "Status:";
            // 
            // textBox_Remarks
            // 
            this.textBox_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Remarks.Location = new System.Drawing.Point(452, 17);
            this.textBox_Remarks.Multiline = true;
            this.textBox_Remarks.Name = "textBox_Remarks";
            this.textBox_Remarks.Size = new System.Drawing.Size(302, 99);
            this.textBox_Remarks.TabIndex = 17;
            // 
            // dateTimePicker_maintenanceDate
            // 
            this.dateTimePicker_maintenanceDate.CustomFormat = "";
            this.dateTimePicker_maintenanceDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_maintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_maintenanceDate.Location = new System.Drawing.Point(116, 89);
            this.dateTimePicker_maintenanceDate.Name = "dateTimePicker_maintenanceDate";
            this.dateTimePicker_maintenanceDate.Size = new System.Drawing.Size(177, 27);
            this.dateTimePicker_maintenanceDate.TabIndex = 16;
            // 
            // comboBox_maintenanceStatus
            // 
            this.comboBox_maintenanceStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maintenanceStatus.FormattingEnabled = true;
            this.comboBox_maintenanceStatus.Items.AddRange(new object[] {
            "Scheduled",
            "On Inspection",
            "Finished"});
            this.comboBox_maintenanceStatus.Location = new System.Drawing.Point(116, 53);
            this.comboBox_maintenanceStatus.Name = "comboBox_maintenanceStatus";
            this.comboBox_maintenanceStatus.Size = new System.Drawing.Size(178, 27);
            this.comboBox_maintenanceStatus.TabIndex = 9;
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
            this.label2.Text = "Maintenance Tracker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ManageEmployee
            // 
            this.panel_ManageEmployee.BackColor = System.Drawing.Color.DimGray;
            this.panel_ManageEmployee.Controls.Add(this.label2);
            this.panel_ManageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ManageEmployee.Location = new System.Drawing.Point(0, 0);
            this.panel_ManageEmployee.Name = "panel_ManageEmployee";
            this.panel_ManageEmployee.Size = new System.Drawing.Size(934, 70);
            this.panel_ManageEmployee.TabIndex = 24;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.rTMIDataSet;
            // 
            // rTMIDataSet
            // 
            this.rTMIDataSet.DataSetName = "RTMIDataSet";
            this.rTMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid_Maintenance
            // 
            this.dataGrid_Maintenance.AllowUserToAddRows = false;
            this.dataGrid_Maintenance.AllowUserToDeleteRows = false;
            this.dataGrid_Maintenance.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGrid_Maintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Maintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Maintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Maintenance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Maintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Maintenance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Maintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Maintenance.EnableHeadersVisualStyles = false;
            this.dataGrid_Maintenance.Location = new System.Drawing.Point(0, 70);
            this.dataGrid_Maintenance.Name = "dataGrid_Maintenance";
            this.dataGrid_Maintenance.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Maintenance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Maintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Maintenance.Size = new System.Drawing.Size(934, 541);
            this.dataGrid_Maintenance.TabIndex = 23;
            this.dataGrid_Maintenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Maintenance_CellClick);
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_Maintenance);
            this.Controls.Add(this.panel_ManageEmployee);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ManageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTMIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Maintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_MaintenanceUpdate;
        private System.Windows.Forms.Button button_MaintenanceDelete;
        private System.Windows.Forms.Button button_MaintenanceAdd;
        private System.Windows.Forms.Label label_maintenanceBusID;
        private System.Windows.Forms.Label label_maintenanceDamages;
        private System.Windows.Forms.Label label_maintenanceDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_maintenanceStatus;
        private System.Windows.Forms.TextBox textBox_Remarks;
        private System.Windows.Forms.DateTimePicker dateTimePicker_maintenanceDate;
        private System.Windows.Forms.ComboBox comboBox_maintenanceStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_ManageEmployee;
        private RTMIDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RTMIDataSet rTMIDataSet;
        private System.Windows.Forms.DataGridView dataGrid_Maintenance;
        private System.Windows.Forms.ComboBox comboBox_maintenanceBusID;
    }
}