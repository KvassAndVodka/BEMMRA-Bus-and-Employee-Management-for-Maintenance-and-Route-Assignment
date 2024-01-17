namespace FDS_RTMI
{
    partial class Routes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Routes));
            this.dataGrid_Routes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_routeBusID = new System.Windows.Forms.ComboBox();
            this.comboBox_routeStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_routeTime = new System.Windows.Forms.DateTimePicker();
            this.label_routeConductor = new System.Windows.Forms.Label();
            this.comboBox_routeConductor = new System.Windows.Forms.ComboBox();
            this.comboBox_routeBusModel = new System.Windows.Forms.ComboBox();
            this.comboBox_Route = new System.Windows.Forms.ComboBox();
            this.label_routeStatus = new System.Windows.Forms.Label();
            this.button_routesUpdate = new System.Windows.Forms.Button();
            this.button_routesDelete = new System.Windows.Forms.Button();
            this.label_routeDriver = new System.Windows.Forms.Label();
            this.button_routesAdd = new System.Windows.Forms.Button();
            this.label_routeRoute = new System.Windows.Forms.Label();
            this.label_routeBusModel = new System.Windows.Forms.Label();
            this.label_dateInFleet = new System.Windows.Forms.Label();
            this.dateTimePicker_routeDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_routeDriver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_lastMaintenance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Routes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_Routes
            // 
            this.dataGrid_Routes.AllowUserToAddRows = false;
            this.dataGrid_Routes.AllowUserToDeleteRows = false;
            this.dataGrid_Routes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGrid_Routes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Routes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Routes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Routes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Routes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Routes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Routes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Routes.EnableHeadersVisualStyles = false;
            this.dataGrid_Routes.Location = new System.Drawing.Point(0, 70);
            this.dataGrid_Routes.Name = "dataGrid_Routes";
            this.dataGrid_Routes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Routes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Routes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Routes.Size = new System.Drawing.Size(934, 352);
            this.dataGrid_Routes.TabIndex = 25;
            this.dataGrid_Routes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Routes_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_lastMaintenance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_routeBusID);
            this.panel1.Controls.Add(this.comboBox_routeStatus);
            this.panel1.Controls.Add(this.dateTimePicker_routeTime);
            this.panel1.Controls.Add(this.label_routeConductor);
            this.panel1.Controls.Add(this.comboBox_routeConductor);
            this.panel1.Controls.Add(this.comboBox_routeBusModel);
            this.panel1.Controls.Add(this.comboBox_Route);
            this.panel1.Controls.Add(this.label_routeStatus);
            this.panel1.Controls.Add(this.button_routesUpdate);
            this.panel1.Controls.Add(this.button_routesDelete);
            this.panel1.Controls.Add(this.label_routeDriver);
            this.panel1.Controls.Add(this.button_routesAdd);
            this.panel1.Controls.Add(this.label_routeRoute);
            this.panel1.Controls.Add(this.label_routeBusModel);
            this.panel1.Controls.Add(this.label_dateInFleet);
            this.panel1.Controls.Add(this.dateTimePicker_routeDate);
            this.panel1.Controls.Add(this.comboBox_routeDriver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 189);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Bus ID:";
            // 
            // comboBox_routeBusID
            // 
            this.comboBox_routeBusID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_routeBusID.FormattingEnabled = true;
            this.comboBox_routeBusID.Location = new System.Drawing.Point(116, 85);
            this.comboBox_routeBusID.Name = "comboBox_routeBusID";
            this.comboBox_routeBusID.Size = new System.Drawing.Size(213, 27);
            this.comboBox_routeBusID.TabIndex = 30;
            this.comboBox_routeBusID.SelectedIndexChanged += new System.EventHandler(this.comboBox_routeBusID_SelectedIndexChanged);
            // 
            // comboBox_routeStatus
            // 
            this.comboBox_routeStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_routeStatus.FormattingEnabled = true;
            this.comboBox_routeStatus.Items.AddRange(new object[] {
            "Active",
            "Stopped"});
            this.comboBox_routeStatus.Location = new System.Drawing.Point(489, 124);
            this.comboBox_routeStatus.Name = "comboBox_routeStatus";
            this.comboBox_routeStatus.Size = new System.Drawing.Size(213, 27);
            this.comboBox_routeStatus.TabIndex = 28;
            // 
            // dateTimePicker_routeTime
            // 
            this.dateTimePicker_routeTime.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_routeTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_routeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_routeTime.Location = new System.Drawing.Point(634, 17);
            this.dateTimePicker_routeTime.Name = "dateTimePicker_routeTime";
            this.dateTimePicker_routeTime.ShowUpDown = true;
            this.dateTimePicker_routeTime.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker_routeTime.TabIndex = 27;
            // 
            // label_routeConductor
            // 
            this.label_routeConductor.AutoSize = true;
            this.label_routeConductor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_routeConductor.Location = new System.Drawing.Point(387, 88);
            this.label_routeConductor.Name = "label_routeConductor";
            this.label_routeConductor.Size = new System.Drawing.Size(88, 19);
            this.label_routeConductor.TabIndex = 25;
            this.label_routeConductor.Text = "Conductor:";
            // 
            // comboBox_routeConductor
            // 
            this.comboBox_routeConductor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_routeConductor.FormattingEnabled = true;
            this.comboBox_routeConductor.Location = new System.Drawing.Point(487, 85);
            this.comboBox_routeConductor.Name = "comboBox_routeConductor";
            this.comboBox_routeConductor.Size = new System.Drawing.Size(279, 27);
            this.comboBox_routeConductor.TabIndex = 26;
            // 
            // comboBox_routeBusModel
            // 
            this.comboBox_routeBusModel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_routeBusModel.FormattingEnabled = true;
            this.comboBox_routeBusModel.Location = new System.Drawing.Point(116, 52);
            this.comboBox_routeBusModel.Name = "comboBox_routeBusModel";
            this.comboBox_routeBusModel.Size = new System.Drawing.Size(213, 27);
            this.comboBox_routeBusModel.TabIndex = 24;
            this.comboBox_routeBusModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_routeBusModel_SelectedIndexChanged);
            // 
            // comboBox_Route
            // 
            this.comboBox_Route.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Route.FormattingEnabled = true;
            this.comboBox_Route.Items.AddRange(new object[] {
            "Cagayan de Oro - Davao",
            "Cagayan de Oro - Maramag",
            "Cagayan de Oro - Kibawe",
            "Cagayan de Oro - Damulog",
            "Cagayan de Oro - Kadingilan",
            "Cagayan de Oro - Tacurong",
            "Cagayan de Oro - General Santos",
            "Cagayan de Oro - Balingasag",
            "Cagayan de Oro -Balingoan",
            "Valencia - Kibawe",
            "Valencia - Kadingilan",
            "Valencia - Wao",
            "Malabalay - Kibawe",
            "Malaybalay - Kalilangan"});
            this.comboBox_Route.Location = new System.Drawing.Point(116, 16);
            this.comboBox_Route.Name = "comboBox_Route";
            this.comboBox_Route.Size = new System.Drawing.Size(213, 27);
            this.comboBox_Route.TabIndex = 23;
            this.comboBox_Route.SelectedIndexChanged += new System.EventHandler(this.comboBox_Route_SelectedIndexChanged);
            // 
            // label_routeStatus
            // 
            this.label_routeStatus.AutoSize = true;
            this.label_routeStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_routeStatus.Location = new System.Drawing.Point(415, 127);
            this.label_routeStatus.Name = "label_routeStatus";
            this.label_routeStatus.Size = new System.Drawing.Size(60, 19);
            this.label_routeStatus.TabIndex = 22;
            this.label_routeStatus.Text = "Status:";
            // 
            // button_routesUpdate
            // 
            this.button_routesUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_routesUpdate.BackColor = System.Drawing.Color.Gold;
            this.button_routesUpdate.FlatAppearance.BorderSize = 0;
            this.button_routesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_routesUpdate.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_routesUpdate.ForeColor = System.Drawing.Color.Black;
            this.button_routesUpdate.Location = new System.Drawing.Point(786, 17);
            this.button_routesUpdate.Name = "button_routesUpdate";
            this.button_routesUpdate.Size = new System.Drawing.Size(136, 50);
            this.button_routesUpdate.TabIndex = 21;
            this.button_routesUpdate.Text = "UPDATE";
            this.button_routesUpdate.UseVisualStyleBackColor = false;
            this.button_routesUpdate.Click += new System.EventHandler(this.button_routesUpdate_Click);
            // 
            // button_routesDelete
            // 
            this.button_routesDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_routesDelete.BackColor = System.Drawing.Color.Firebrick;
            this.button_routesDelete.FlatAppearance.BorderSize = 0;
            this.button_routesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_routesDelete.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_routesDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_routesDelete.Location = new System.Drawing.Point(786, 71);
            this.button_routesDelete.Name = "button_routesDelete";
            this.button_routesDelete.Size = new System.Drawing.Size(136, 50);
            this.button_routesDelete.TabIndex = 20;
            this.button_routesDelete.Text = "DELETE";
            this.button_routesDelete.UseVisualStyleBackColor = false;
            this.button_routesDelete.Click += new System.EventHandler(this.button_routesDelete_Click);
            // 
            // label_routeDriver
            // 
            this.label_routeDriver.AutoSize = true;
            this.label_routeDriver.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_routeDriver.Location = new System.Drawing.Point(418, 55);
            this.label_routeDriver.Name = "label_routeDriver";
            this.label_routeDriver.Size = new System.Drawing.Size(57, 19);
            this.label_routeDriver.TabIndex = 8;
            this.label_routeDriver.Text = "Driver:";
            // 
            // button_routesAdd
            // 
            this.button_routesAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_routesAdd.BackColor = System.Drawing.Color.Lime;
            this.button_routesAdd.FlatAppearance.BorderSize = 0;
            this.button_routesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_routesAdd.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_routesAdd.Location = new System.Drawing.Point(786, 127);
            this.button_routesAdd.Name = "button_routesAdd";
            this.button_routesAdd.Size = new System.Drawing.Size(136, 50);
            this.button_routesAdd.TabIndex = 19;
            this.button_routesAdd.Text = "ADD";
            this.button_routesAdd.UseVisualStyleBackColor = false;
            this.button_routesAdd.Click += new System.EventHandler(this.button_routesAdd_Click);
            // 
            // label_routeRoute
            // 
            this.label_routeRoute.AutoSize = true;
            this.label_routeRoute.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_routeRoute.Location = new System.Drawing.Point(46, 19);
            this.label_routeRoute.Name = "label_routeRoute";
            this.label_routeRoute.Size = new System.Drawing.Size(56, 19);
            this.label_routeRoute.TabIndex = 2;
            this.label_routeRoute.Text = "Route:";
            // 
            // label_routeBusModel
            // 
            this.label_routeBusModel.AutoSize = true;
            this.label_routeBusModel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_routeBusModel.Location = new System.Drawing.Point(12, 55);
            this.label_routeBusModel.Name = "label_routeBusModel";
            this.label_routeBusModel.Size = new System.Drawing.Size(90, 19);
            this.label_routeBusModel.TabIndex = 6;
            this.label_routeBusModel.Text = "Bus Model:";
            // 
            // label_dateInFleet
            // 
            this.label_dateInFleet.AutoSize = true;
            this.label_dateInFleet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_dateInFleet.Location = new System.Drawing.Point(348, 19);
            this.label_dateInFleet.Name = "label_dateInFleet";
            this.label_dateInFleet.Size = new System.Drawing.Size(127, 19);
            this.label_dateInFleet.TabIndex = 12;
            this.label_dateInFleet.Text = "Route Schedule:";
            // 
            // dateTimePicker_routeDate
            // 
            this.dateTimePicker_routeDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_routeDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_routeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_routeDate.Location = new System.Drawing.Point(487, 16);
            this.dateTimePicker_routeDate.Name = "dateTimePicker_routeDate";
            this.dateTimePicker_routeDate.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker_routeDate.TabIndex = 14;
            // 
            // comboBox_routeDriver
            // 
            this.comboBox_routeDriver.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_routeDriver.FormattingEnabled = true;
            this.comboBox_routeDriver.Location = new System.Drawing.Point(487, 52);
            this.comboBox_routeDriver.Name = "comboBox_routeDriver";
            this.comboBox_routeDriver.Size = new System.Drawing.Size(279, 27);
            this.comboBox_routeDriver.TabIndex = 9;
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
            this.label2.TabIndex = 24;
            this.label2.Text = "Manage Routes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_lastMaintenance
            // 
            this.label_lastMaintenance.AutoSize = true;
            this.label_lastMaintenance.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label_lastMaintenance.Location = new System.Drawing.Point(42, 124);
            this.label_lastMaintenance.Name = "label_lastMaintenance";
            this.label_lastMaintenance.Size = new System.Drawing.Size(143, 19);
            this.label_lastMaintenance.TabIndex = 31;
            this.label_lastMaintenance.Text = "Last Maintenance:";
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dataGrid_Routes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Routes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Routes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_routeStatus;
        private System.Windows.Forms.Button button_routesUpdate;
        private System.Windows.Forms.Button button_routesDelete;
        private System.Windows.Forms.Label label_routeDriver;
        private System.Windows.Forms.Button button_routesAdd;
        private System.Windows.Forms.Label label_routeRoute;
        private System.Windows.Forms.Label label_routeBusModel;
        private System.Windows.Forms.Label label_dateInFleet;
        private System.Windows.Forms.DateTimePicker dateTimePicker_routeDate;
        private System.Windows.Forms.ComboBox comboBox_routeDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_routeBusModel;
        private System.Windows.Forms.ComboBox comboBox_Route;
        private System.Windows.Forms.Label label_routeConductor;
        private System.Windows.Forms.ComboBox comboBox_routeConductor;
        private System.Windows.Forms.DateTimePicker dateTimePicker_routeTime;
        private System.Windows.Forms.ComboBox comboBox_routeStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_routeBusID;
        private System.Windows.Forms.Label label_lastMaintenance;
    }
}