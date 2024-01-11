namespace FDS_RTMI
{
    partial class Bus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_Buses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_busesYearsInFleet = new System.Windows.Forms.Label();
            this.button_busesUpdate = new System.Windows.Forms.Button();
            this.button_busesDelete = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.button_busesAdd = new System.Windows.Forms.Button();
            this.label_busID = new System.Windows.Forms.Label();
            this.label_busModel = new System.Windows.Forms.Label();
            this.label_busesRoute = new System.Windows.Forms.Label();
            this.label_dateInFleet = new System.Windows.Forms.Label();
            this.dateTimePicker_busesDateInFleet = new System.Windows.Forms.DateTimePicker();
            this.comboBox_busesBusStatus = new System.Windows.Forms.ComboBox();
            this.textBox_busesBusModel = new System.Windows.Forms.TextBox();
            this.textBox_busesBusID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Buses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Product Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(934, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Buses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGrid_Buses
            // 
            this.dataGrid_Buses.AllowUserToAddRows = false;
            this.dataGrid_Buses.AllowUserToDeleteRows = false;
            this.dataGrid_Buses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGrid_Buses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid_Buses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Buses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Buses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Buses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid_Buses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Buses.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid_Buses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Buses.EnableHeadersVisualStyles = false;
            this.dataGrid_Buses.Location = new System.Drawing.Point(0, 70);
            this.dataGrid_Buses.Name = "dataGrid_Buses";
            this.dataGrid_Buses.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Buses.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid_Buses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Buses.Size = new System.Drawing.Size(934, 352);
            this.dataGrid_Buses.TabIndex = 2;
            this.dataGrid_Buses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Buses_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_busesYearsInFleet);
            this.panel1.Controls.Add(this.button_busesUpdate);
            this.panel1.Controls.Add(this.button_busesDelete);
            this.panel1.Controls.Add(this.label_Status);
            this.panel1.Controls.Add(this.button_busesAdd);
            this.panel1.Controls.Add(this.label_busID);
            this.panel1.Controls.Add(this.label_busModel);
            this.panel1.Controls.Add(this.label_busesRoute);
            this.panel1.Controls.Add(this.label_dateInFleet);
            this.panel1.Controls.Add(this.dateTimePicker_busesDateInFleet);
            this.panel1.Controls.Add(this.comboBox_busesBusStatus);
            this.panel1.Controls.Add(this.textBox_busesBusModel);
            this.panel1.Controls.Add(this.textBox_busesBusID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 189);
            this.panel1.TabIndex = 23;
            // 
            // label_busesYearsInFleet
            // 
            this.label_busesYearsInFleet.AutoSize = true;
            this.label_busesYearsInFleet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_busesYearsInFleet.Location = new System.Drawing.Point(329, 55);
            this.label_busesYearsInFleet.Name = "label_busesYearsInFleet";
            this.label_busesYearsInFleet.Size = new System.Drawing.Size(112, 19);
            this.label_busesYearsInFleet.TabIndex = 22;
            this.label_busesYearsInFleet.Text = "Years in Fleet:";
            // 
            // button_busesUpdate
            // 
            this.button_busesUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_busesUpdate.BackColor = System.Drawing.Color.Gold;
            this.button_busesUpdate.FlatAppearance.BorderSize = 0;
            this.button_busesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_busesUpdate.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_busesUpdate.ForeColor = System.Drawing.Color.Black;
            this.button_busesUpdate.Location = new System.Drawing.Point(786, 17);
            this.button_busesUpdate.Name = "button_busesUpdate";
            this.button_busesUpdate.Size = new System.Drawing.Size(136, 50);
            this.button_busesUpdate.TabIndex = 21;
            this.button_busesUpdate.Text = "UPDATE";
            this.button_busesUpdate.UseVisualStyleBackColor = false;
            this.button_busesUpdate.Click += new System.EventHandler(this.button_busesUpdate_Click);
            // 
            // button_busesDelete
            // 
            this.button_busesDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_busesDelete.BackColor = System.Drawing.Color.Firebrick;
            this.button_busesDelete.FlatAppearance.BorderSize = 0;
            this.button_busesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_busesDelete.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_busesDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_busesDelete.Location = new System.Drawing.Point(786, 71);
            this.button_busesDelete.Name = "button_busesDelete";
            this.button_busesDelete.Size = new System.Drawing.Size(136, 50);
            this.button_busesDelete.TabIndex = 20;
            this.button_busesDelete.Text = "DELETE";
            this.button_busesDelete.UseVisualStyleBackColor = false;
            this.button_busesDelete.Click += new System.EventHandler(this.button_busesDelete_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_Status.Location = new System.Drawing.Point(44, 91);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(60, 19);
            this.label_Status.TabIndex = 8;
            this.label_Status.Text = "Status:";
            // 
            // button_busesAdd
            // 
            this.button_busesAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_busesAdd.BackColor = System.Drawing.Color.Lime;
            this.button_busesAdd.FlatAppearance.BorderSize = 0;
            this.button_busesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_busesAdd.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_busesAdd.Location = new System.Drawing.Point(786, 127);
            this.button_busesAdd.Name = "button_busesAdd";
            this.button_busesAdd.Size = new System.Drawing.Size(136, 50);
            this.button_busesAdd.TabIndex = 19;
            this.button_busesAdd.Text = "ADD";
            this.button_busesAdd.UseVisualStyleBackColor = false;
            this.button_busesAdd.Click += new System.EventHandler(this.button_busesAdd_Click);
            // 
            // label_busID
            // 
            this.label_busID.AutoSize = true;
            this.label_busID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_busID.Location = new System.Drawing.Point(46, 19);
            this.label_busID.Name = "label_busID";
            this.label_busID.Size = new System.Drawing.Size(60, 19);
            this.label_busID.TabIndex = 2;
            this.label_busID.Text = "Bus ID:";
            // 
            // label_busModel
            // 
            this.label_busModel.AutoSize = true;
            this.label_busModel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_busModel.Location = new System.Drawing.Point(15, 55);
            this.label_busModel.Name = "label_busModel";
            this.label_busModel.Size = new System.Drawing.Size(90, 19);
            this.label_busModel.TabIndex = 6;
            this.label_busModel.Text = "Bus Model:";
            // 
            // label_busesRoute
            // 
            this.label_busesRoute.AutoSize = true;
            this.label_busesRoute.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_busesRoute.Location = new System.Drawing.Point(385, 91);
            this.label_busesRoute.Name = "label_busesRoute";
            this.label_busesRoute.Size = new System.Drawing.Size(56, 19);
            this.label_busesRoute.TabIndex = 10;
            this.label_busesRoute.Text = "Route:";
            // 
            // label_dateInFleet
            // 
            this.label_dateInFleet.AutoSize = true;
            this.label_dateInFleet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_dateInFleet.Location = new System.Drawing.Point(337, 19);
            this.label_dateInFleet.Name = "label_dateInFleet";
            this.label_dateInFleet.Size = new System.Drawing.Size(104, 19);
            this.label_dateInFleet.TabIndex = 12;
            this.label_dateInFleet.Text = "Date in Fleet:";
            // 
            // dateTimePicker_busesDateInFleet
            // 
            this.dateTimePicker_busesDateInFleet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_busesDateInFleet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_busesDateInFleet.Location = new System.Drawing.Point(453, 16);
            this.dateTimePicker_busesDateInFleet.Name = "dateTimePicker_busesDateInFleet";
            this.dateTimePicker_busesDateInFleet.Size = new System.Drawing.Size(302, 27);
            this.dateTimePicker_busesDateInFleet.TabIndex = 14;
            // 
            // comboBox_busesBusStatus
            // 
            this.comboBox_busesBusStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busesBusStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_busesBusStatus.FormattingEnabled = true;
            this.comboBox_busesBusStatus.Items.AddRange(new object[] {
            "Operational",
            "Maintenance",
            "In Garage"});
            this.comboBox_busesBusStatus.Location = new System.Drawing.Point(116, 89);
            this.comboBox_busesBusStatus.Name = "comboBox_busesBusStatus";
            this.comboBox_busesBusStatus.Size = new System.Drawing.Size(178, 27);
            this.comboBox_busesBusStatus.TabIndex = 9;
            // 
            // textBox_busesBusModel
            // 
            this.textBox_busesBusModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_busesBusModel.Location = new System.Drawing.Point(116, 53);
            this.textBox_busesBusModel.Name = "textBox_busesBusModel";
            this.textBox_busesBusModel.Size = new System.Drawing.Size(181, 26);
            this.textBox_busesBusModel.TabIndex = 5;
            // 
            // textBox_busesBusID
            // 
            this.textBox_busesBusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_busesBusID.Location = new System.Drawing.Point(117, 17);
            this.textBox_busesBusID.Name = "textBox_busesBusID";
            this.textBox_busesBusID.Size = new System.Drawing.Size(181, 26);
            this.textBox_busesBusID.TabIndex = 1;
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dataGrid_Buses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Bus";
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.Bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Buses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid_Buses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_busesYearsInFleet;
        private System.Windows.Forms.Button button_busesUpdate;
        private System.Windows.Forms.Button button_busesDelete;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_busesAdd;
        private System.Windows.Forms.Label label_busID;
        private System.Windows.Forms.Label label_busModel;
        private System.Windows.Forms.Label label_busesRoute;
        private System.Windows.Forms.Label label_dateInFleet;
        private System.Windows.Forms.DateTimePicker dateTimePicker_busesDateInFleet;
        private System.Windows.Forms.ComboBox comboBox_busesBusStatus;
        private System.Windows.Forms.TextBox textBox_busesBusModel;
        private System.Windows.Forms.TextBox textBox_busesBusID;
    }
}