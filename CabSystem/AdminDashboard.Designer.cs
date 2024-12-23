namespace CabSystem
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridVehicles = new System.Windows.Forms.DataGridView();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerRemoveBtn = new System.Windows.Forms.Button();
            this.driverRemoveBtn = new System.Windows.Forms.Button();
            this.driverAddBtn = new System.Windows.Forms.Button();
            this.carRemoveBtn = new System.Windows.Forms.Button();
            this.carAddBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.dataGridDrivers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 573);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CabSystem.Properties.Resources.rentit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(45, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 126);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.LogOutBtn.Location = new System.Drawing.Point(17, 455);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(241, 39);
            this.LogOutBtn.TabIndex = 40;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Admin Dashboard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 39);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cab Rental";
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(292, 59);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.Size = new System.Drawing.Size(612, 155);
            this.dataGridCustomers.TabIndex = 1;
            // 
            // dataGridVehicles
            // 
            this.dataGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehicles.Location = new System.Drawing.Point(292, 344);
            this.dataGridVehicles.Name = "dataGridVehicles";
            this.dataGridVehicles.Size = new System.Drawing.Size(612, 155);
            this.dataGridVehicles.TabIndex = 3;
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(921, 344);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(612, 155);
            this.dataGridOrders.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(924, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Drivers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehicles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(924, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Orders";
            // 
            // CustomerRemoveBtn
            // 
            this.CustomerRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.CustomerRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerRemoveBtn.FlatAppearance.BorderSize = 0;
            this.CustomerRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerRemoveBtn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerRemoveBtn.ForeColor = System.Drawing.Color.White;
            this.CustomerRemoveBtn.Location = new System.Drawing.Point(530, 220);
            this.CustomerRemoveBtn.Name = "CustomerRemoveBtn";
            this.CustomerRemoveBtn.Size = new System.Drawing.Size(109, 32);
            this.CustomerRemoveBtn.TabIndex = 9;
            this.CustomerRemoveBtn.Text = "Remove";
            this.CustomerRemoveBtn.UseVisualStyleBackColor = false;
            this.CustomerRemoveBtn.Click += new System.EventHandler(this.CustomerRemoveBtn_Click);
            // 
            // driverRemoveBtn
            // 
            this.driverRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.driverRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driverRemoveBtn.FlatAppearance.BorderSize = 0;
            this.driverRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverRemoveBtn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRemoveBtn.ForeColor = System.Drawing.Color.White;
            this.driverRemoveBtn.Location = new System.Drawing.Point(1289, 220);
            this.driverRemoveBtn.Name = "driverRemoveBtn";
            this.driverRemoveBtn.Size = new System.Drawing.Size(115, 32);
            this.driverRemoveBtn.TabIndex = 27;
            this.driverRemoveBtn.Text = "Remove";
            this.driverRemoveBtn.UseVisualStyleBackColor = false;
            this.driverRemoveBtn.Click += new System.EventHandler(this.driverRemoveBtn_Click);
            // 
            // driverAddBtn
            // 
            this.driverAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.driverAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driverAddBtn.FlatAppearance.BorderSize = 0;
            this.driverAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverAddBtn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverAddBtn.ForeColor = System.Drawing.Color.White;
            this.driverAddBtn.Location = new System.Drawing.Point(1139, 220);
            this.driverAddBtn.Name = "driverAddBtn";
            this.driverAddBtn.Size = new System.Drawing.Size(115, 32);
            this.driverAddBtn.TabIndex = 26;
            this.driverAddBtn.Text = "Add";
            this.driverAddBtn.UseVisualStyleBackColor = false;
            this.driverAddBtn.Click += new System.EventHandler(this.driverAddBtn_Click);
            // 
            // carRemoveBtn
            // 
            this.carRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.carRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carRemoveBtn.FlatAppearance.BorderSize = 0;
            this.carRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carRemoveBtn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRemoveBtn.ForeColor = System.Drawing.Color.White;
            this.carRemoveBtn.Location = new System.Drawing.Point(616, 505);
            this.carRemoveBtn.Name = "carRemoveBtn";
            this.carRemoveBtn.Size = new System.Drawing.Size(109, 32);
            this.carRemoveBtn.TabIndex = 29;
            this.carRemoveBtn.Text = "Remove";
            this.carRemoveBtn.UseVisualStyleBackColor = false;
            this.carRemoveBtn.Click += new System.EventHandler(this.carRemoveBtn_Click);
            // 
            // carAddBtn
            // 
            this.carAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.carAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carAddBtn.FlatAppearance.BorderSize = 0;
            this.carAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carAddBtn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carAddBtn.ForeColor = System.Drawing.Color.White;
            this.carAddBtn.Location = new System.Drawing.Point(496, 505);
            this.carAddBtn.Name = "carAddBtn";
            this.carAddBtn.Size = new System.Drawing.Size(109, 32);
            this.carAddBtn.TabIndex = 28;
            this.carAddBtn.Text = "Add";
            this.carAddBtn.UseVisualStyleBackColor = false;
            this.carAddBtn.Click += new System.EventHandler(this.carAddBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.orderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBtn.FlatAppearance.BorderSize = 0;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Location = new System.Drawing.Point(1227, 505);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(115, 32);
            this.orderBtn.TabIndex = 31;
            this.orderBtn.Text = "Manage";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::CabSystem.Properties.Resources.icons8_minimize_window_24;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(1431, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(40, 40);
            this.MinimizeBtn.TabIndex = 25;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::CabSystem.Properties.Resources.icons8_exit_button_32;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(1485, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 24;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // dataGridDrivers
            // 
            this.dataGridDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrivers.Location = new System.Drawing.Point(921, 59);
            this.dataGridDrivers.Name = "dataGridDrivers";
            this.dataGridDrivers.Size = new System.Drawing.Size(612, 155);
            this.dataGridDrivers.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 568);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.carRemoveBtn);
            this.Controls.Add(this.carAddBtn);
            this.Controls.Add(this.driverRemoveBtn);
            this.Controls.Add(this.driverAddBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CustomerRemoveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.dataGridVehicles);
            this.Controls.Add(this.dataGridDrivers);
            this.Controls.Add(this.dataGridCustomers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridView dataGridVehicles;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CustomerRemoveBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button driverRemoveBtn;
        private System.Windows.Forms.Button driverAddBtn;
        private System.Windows.Forms.Button carRemoveBtn;
        private System.Windows.Forms.Button carAddBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridDrivers;
    }
}