namespace ControlSystem
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.edit_tab = new System.Windows.Forms.TabPage();
            this.Edit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Worker_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Worker_Age = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Worker_About = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Worker_Position = new System.Windows.Forms.TextBox();
            this.Worker_Number = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Worker_Fathername = new System.Windows.Forms.TextBox();
            this.Worker_Name = new System.Windows.Forms.TextBox();
            this.Worker_Surname = new System.Windows.Forms.TextBox();
            this.add_tab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.add_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.new_about = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.new_position = new System.Windows.Forms.TextBox();
            this.new_phone = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.new_byfather = new System.Windows.Forms.TextBox();
            this.new_name = new System.Windows.Forms.TextBox();
            this.new_surname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.edit_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.add_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put card to reader to start work with profile";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(219, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.edit_tab);
            this.tabControl1.Controls.Add(this.add_tab);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 419);
            this.tabControl1.TabIndex = 3;
            // 
            // edit_tab
            // 
            this.edit_tab.Controls.Add(this.Edit_button);
            this.edit_tab.Controls.Add(this.label2);
            this.edit_tab.Controls.Add(this.Worker_ID);
            this.edit_tab.Controls.Add(this.label7);
            this.edit_tab.Controls.Add(this.Worker_Age);
            this.edit_tab.Controls.Add(this.groupBox1);
            this.edit_tab.Controls.Add(this.label6);
            this.edit_tab.Controls.Add(this.label5);
            this.edit_tab.Controls.Add(this.label3);
            this.edit_tab.Controls.Add(this.label4);
            this.edit_tab.Controls.Add(this.label13);
            this.edit_tab.Controls.Add(this.Worker_Position);
            this.edit_tab.Controls.Add(this.Worker_Number);
            this.edit_tab.Controls.Add(this.pictureBox1);
            this.edit_tab.Controls.Add(this.Worker_Fathername);
            this.edit_tab.Controls.Add(this.Worker_Name);
            this.edit_tab.Controls.Add(this.Worker_Surname);
            this.edit_tab.Location = new System.Drawing.Point(4, 22);
            this.edit_tab.Name = "edit_tab";
            this.edit_tab.Padding = new System.Windows.Forms.Padding(3);
            this.edit_tab.Size = new System.Drawing.Size(635, 393);
            this.edit_tab.TabIndex = 0;
            this.edit_tab.Text = "Edit";
            this.edit_tab.UseVisualStyleBackColor = true;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(8, 367);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(280, 23);
            this.Edit_button.TabIndex = 34;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID";
            // 
            // Worker_ID
            // 
            this.Worker_ID.Location = new System.Drawing.Point(461, 4);
            this.Worker_ID.Name = "Worker_ID";
            this.Worker_ID.Size = new System.Drawing.Size(158, 20);
            this.Worker_ID.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Born date";
            // 
            // Worker_Age
            // 
            this.Worker_Age.Location = new System.Drawing.Point(461, 108);
            this.Worker_Age.Name = "Worker_Age";
            this.Worker_Age.Size = new System.Drawing.Size(158, 20);
            this.Worker_Age.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Worker_About);
            this.groupBox1.Location = new System.Drawing.Point(315, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 195);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About";
            // 
            // Worker_About
            // 
            this.Worker_About.Location = new System.Drawing.Point(6, 19);
            this.Worker_About.Multiline = true;
            this.Worker_About.Name = "Worker_About";
            this.Worker_About.Size = new System.Drawing.Size(292, 170);
            this.Worker_About.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fathername";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Surnamne";
            // 
            // Worker_Position
            // 
            this.Worker_Position.Location = new System.Drawing.Point(461, 160);
            this.Worker_Position.Name = "Worker_Position";
            this.Worker_Position.Size = new System.Drawing.Size(158, 20);
            this.Worker_Position.TabIndex = 23;
            // 
            // Worker_Number
            // 
            this.Worker_Number.Location = new System.Drawing.Point(461, 134);
            this.Worker_Number.Name = "Worker_Number";
            this.Worker_Number.Size = new System.Drawing.Size(158, 20);
            this.Worker_Number.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Worker_Fathername
            // 
            this.Worker_Fathername.Location = new System.Drawing.Point(461, 82);
            this.Worker_Fathername.Name = "Worker_Fathername";
            this.Worker_Fathername.Size = new System.Drawing.Size(158, 20);
            this.Worker_Fathername.TabIndex = 20;
            // 
            // Worker_Name
            // 
            this.Worker_Name.Location = new System.Drawing.Point(461, 56);
            this.Worker_Name.Name = "Worker_Name";
            this.Worker_Name.Size = new System.Drawing.Size(158, 20);
            this.Worker_Name.TabIndex = 19;
            // 
            // Worker_Surname
            // 
            this.Worker_Surname.Location = new System.Drawing.Point(461, 30);
            this.Worker_Surname.Name = "Worker_Surname";
            this.Worker_Surname.Size = new System.Drawing.Size(158, 20);
            this.Worker_Surname.TabIndex = 18;
            // 
            // add_tab
            // 
            this.add_tab.Controls.Add(this.button1);
            this.add_tab.Controls.Add(this.dateTimePicker1);
            this.add_tab.Controls.Add(this.add_button);
            this.add_tab.Controls.Add(this.label8);
            this.add_tab.Controls.Add(this.groupBox2);
            this.add_tab.Controls.Add(this.label9);
            this.add_tab.Controls.Add(this.label10);
            this.add_tab.Controls.Add(this.label11);
            this.add_tab.Controls.Add(this.label12);
            this.add_tab.Controls.Add(this.label14);
            this.add_tab.Controls.Add(this.new_position);
            this.add_tab.Controls.Add(this.new_phone);
            this.add_tab.Controls.Add(this.pictureBox3);
            this.add_tab.Controls.Add(this.new_byfather);
            this.add_tab.Controls.Add(this.new_name);
            this.add_tab.Controls.Add(this.new_surname);
            this.add_tab.Location = new System.Drawing.Point(4, 22);
            this.add_tab.Name = "add_tab";
            this.add_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_tab.Size = new System.Drawing.Size(635, 393);
            this.add_tab.TabIndex = 1;
            this.add_tab.Text = "Add";
            this.add_tab.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 82);
            this.dateTimePicker1.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // add_button
            // 
            this.add_button.Enabled = false;
            this.add_button.Location = new System.Drawing.Point(8, 339);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(284, 23);
            this.add_button.TabIndex = 44;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Birthday";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.new_about);
            this.groupBox2.Location = new System.Drawing.Point(319, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 205);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // new_about
            // 
            this.new_about.Location = new System.Drawing.Point(6, 19);
            this.new_about.Multiline = true;
            this.new_about.Name = "new_about";
            this.new_about.Size = new System.Drawing.Size(292, 180);
            this.new_about.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Phone number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Fathername";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Surnamne";
            // 
            // new_position
            // 
            this.new_position.Location = new System.Drawing.Point(465, 134);
            this.new_position.Name = "new_position";
            this.new_position.Size = new System.Drawing.Size(158, 20);
            this.new_position.TabIndex = 35;
            // 
            // new_phone
            // 
            this.new_phone.Location = new System.Drawing.Point(465, 108);
            this.new_phone.Name = "new_phone";
            this.new_phone.Size = new System.Drawing.Size(158, 20);
            this.new_phone.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::ControlSystem.Properties.Resources.User_add_ico;
            this.pictureBox3.Location = new System.Drawing.Point(8, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 329);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // new_byfather
            // 
            this.new_byfather.Location = new System.Drawing.Point(465, 56);
            this.new_byfather.Name = "new_byfather";
            this.new_byfather.Size = new System.Drawing.Size(158, 20);
            this.new_byfather.TabIndex = 32;
            // 
            // new_name
            // 
            this.new_name.Location = new System.Drawing.Point(465, 30);
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(158, 20);
            this.new_name.TabIndex = 31;
            // 
            // new_surname
            // 
            this.new_surname.Location = new System.Drawing.Point(465, 4);
            this.new_surname.Name = "new_surname";
            this.new_surname.Size = new System.Drawing.Size(158, 20);
            this.new_surname.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 417);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.edit_tab.ResumeLayout(false);
            this.edit_tab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.add_tab.ResumeLayout(false);
            this.add_tab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage edit_tab;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Worker_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Worker_Age;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Worker_About;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Worker_Position;
        private System.Windows.Forms.TextBox Worker_Number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Worker_Fathername;
        private System.Windows.Forms.TextBox Worker_Name;
        private System.Windows.Forms.TextBox Worker_Surname;
        private System.Windows.Forms.TabPage add_tab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox new_about;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox new_position;
        private System.Windows.Forms.TextBox new_phone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox new_byfather;
        private System.Windows.Forms.TextBox new_name;
        private System.Windows.Forms.TextBox new_surname;
        private System.Windows.Forms.Button button1;
    }
}