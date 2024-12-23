namespace CabSystem
{
    partial class Booking
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridVehicles = new System.Windows.Forms.DataGridView();
            this.dataGridDrivers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carIdBox = new System.Windows.Forms.TextBox();
            this.driverIDBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bookBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 732);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CabSystem.Properties.Resources.rentit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 126);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::CabSystem.Properties.Resources.icons8_back_64;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(12, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 42);
            this.backBtn.TabIndex = 39;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 35);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cab Rental";
            // 
            // dataGridVehicles
            // 
            this.dataGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehicles.Location = new System.Drawing.Point(243, 55);
            this.dataGridVehicles.Name = "dataGridVehicles";
            this.dataGridVehicles.Size = new System.Drawing.Size(960, 176);
            this.dataGridVehicles.TabIndex = 34;
            this.dataGridVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVehicles_CellClick);
            this.dataGridVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVehicles_CellContentClick);
            // 
            // dataGridDrivers
            // 
            this.dataGridDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrivers.Location = new System.Drawing.Point(243, 308);
            this.dataGridDrivers.Name = "dataGridDrivers";
            this.dataGridDrivers.Size = new System.Drawing.Size(960, 176);
            this.dataGridDrivers.TabIndex = 35;
            this.dataGridDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDrivers_CellClick);
            this.dataGridDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDrivers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "CarID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "DriverID:";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(873, 549);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(104, 24);
            this.Location.TabIndex = 38;
            this.Location.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "End Date";
            // 
            // carIdBox
            // 
            this.carIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIdBox.Location = new System.Drawing.Point(425, 547);
            this.carIdBox.Name = "carIdBox";
            this.carIdBox.Size = new System.Drawing.Size(145, 29);
            this.carIdBox.TabIndex = 41;
            // 
            // driverIDBox
            // 
            this.driverIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverIDBox.Location = new System.Drawing.Point(696, 547);
            this.driverIDBox.Name = "driverIDBox";
            this.driverIDBox.Size = new System.Drawing.Size(145, 29);
            this.driverIDBox.TabIndex = 42;
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.Location = new System.Drawing.Point(983, 547);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(145, 29);
            this.locationBox.TabIndex = 43;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDatePicker.Location = new System.Drawing.Point(455, 620);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(186, 20);
            this.startDatePicker.TabIndex = 44;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDatePicker.Location = new System.Drawing.Point(802, 620);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(186, 20);
            this.endDatePicker.TabIndex = 45;
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(207)))));
            this.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBtn.FlatAppearance.BorderSize = 0;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bookBtn.Location = new System.Drawing.Point(587, 658);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(311, 41);
            this.bookBtn.TabIndex = 65;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 66;
            this.label5.Text = "Drivers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 67;
            this.label6.Text = "Vehicles";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::CabSystem.Properties.Resources.icons8_minimize_window_24;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(1106, 5);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(40, 40);
            this.MinimizeBtn.TabIndex = 33;
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
            this.CloseBtn.Location = new System.Drawing.Point(1163, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 32;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 730);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.driverIDBox);
            this.Controls.Add(this.carIdBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDrivers);
            this.Controls.Add(this.dataGridVehicles);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dataGridVehicles;
        private System.Windows.Forms.DataGridView dataGridDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carIdBox;
        private System.Windows.Forms.TextBox driverIDBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}