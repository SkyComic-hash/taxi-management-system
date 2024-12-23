namespace CabSystem
{
    partial class CustomerDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDrivers = new System.Windows.Forms.DataGridView();
            this.dataGridVehicles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Personal_Details = new System.Windows.Forms.Button();
            this.Rentbutton = new System.Windows.Forms.Button();
            this.ordersbutton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 542);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CabSystem.Properties.Resources.rentit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 126);
            this.pictureBox1.TabIndex = 42;
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
            this.LogOutBtn.Location = new System.Drawing.Point(39, 470);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(241, 39);
            this.LogOutBtn.TabIndex = 39;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Customer Dashboard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 39);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cab Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(325, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Welcome";
            // 
            // dataGridDrivers
            // 
            this.dataGridDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrivers.Location = new System.Drawing.Point(323, 345);
            this.dataGridDrivers.Name = "dataGridDrivers";
            this.dataGridDrivers.Size = new System.Drawing.Size(581, 176);
            this.dataGridDrivers.TabIndex = 32;
            // 
            // dataGridVehicles
            // 
            this.dataGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehicles.Location = new System.Drawing.Point(910, 345);
            this.dataGridVehicles.Name = "dataGridVehicles";
            this.dataGridVehicles.Size = new System.Drawing.Size(581, 176);
            this.dataGridVehicles.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Drivers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(913, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Vehicles";
            // 
            // Personal_Details
            // 
            this.Personal_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.Personal_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Personal_Details.FlatAppearance.BorderSize = 0;
            this.Personal_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal_Details.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personal_Details.ForeColor = System.Drawing.Color.White;
            this.Personal_Details.Location = new System.Drawing.Point(527, 173);
            this.Personal_Details.Name = "Personal_Details";
            this.Personal_Details.Size = new System.Drawing.Size(229, 60);
            this.Personal_Details.TabIndex = 36;
            this.Personal_Details.Text = "Personal Details";
            this.Personal_Details.UseVisualStyleBackColor = false;
            this.Personal_Details.Click += new System.EventHandler(this.Personal_Details_Click);
            // 
            // Rentbutton
            // 
            this.Rentbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.Rentbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rentbutton.FlatAppearance.BorderSize = 0;
            this.Rentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rentbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentbutton.ForeColor = System.Drawing.Color.White;
            this.Rentbutton.Location = new System.Drawing.Point(1036, 173);
            this.Rentbutton.Name = "Rentbutton";
            this.Rentbutton.Size = new System.Drawing.Size(229, 60);
            this.Rentbutton.TabIndex = 37;
            this.Rentbutton.Text = "Book a Vehicle";
            this.Rentbutton.UseVisualStyleBackColor = false;
            this.Rentbutton.Click += new System.EventHandler(this.Rentbutton_Click);
            // 
            // ordersbutton
            // 
            this.ordersbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.ordersbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersbutton.FlatAppearance.BorderSize = 0;
            this.ordersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersbutton.ForeColor = System.Drawing.Color.White;
            this.ordersbutton.Location = new System.Drawing.Point(781, 173);
            this.ordersbutton.Name = "ordersbutton";
            this.ordersbutton.Size = new System.Drawing.Size(229, 60);
            this.ordersbutton.TabIndex = 38;
            this.ordersbutton.Text = "Personal Orders";
            this.ordersbutton.UseVisualStyleBackColor = false;
            this.ordersbutton.Click += new System.EventHandler(this.ordersbutton_Click);
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(500, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(235, 36);
            this.nameBox.TabIndex = 40;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::CabSystem.Properties.Resources.icons8_minimize_window_24;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(1393, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(40, 40);
            this.MinimizeBtn.TabIndex = 27;
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
            this.CloseBtn.Location = new System.Drawing.Point(1448, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 533);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.ordersbutton);
            this.Controls.Add(this.Rentbutton);
            this.Controls.Add(this.Personal_Details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridVehicles);
            this.Controls.Add(this.dataGridDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDrivers;
        private System.Windows.Forms.DataGridView dataGridVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Personal_Details;
        private System.Windows.Forms.Button Rentbutton;
        private System.Windows.Forms.Button ordersbutton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}