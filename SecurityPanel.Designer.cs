namespace ControlSystem
{
    partial class SecurityPanel
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
            this.Worker_Surname = new System.Windows.Forms.TextBox();
            this.Worker_Name = new System.Windows.Forms.TextBox();
            this.Worker_Fathername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Worker_Position = new System.Windows.Forms.TextBox();
            this.Worker_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Worker_About = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Worker_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Worker_ID = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Worker_Surname
            // 
            this.Worker_Surname.Enabled = false;
            this.Worker_Surname.Location = new System.Drawing.Point(465, 37);
            this.Worker_Surname.Name = "Worker_Surname";
            this.Worker_Surname.Size = new System.Drawing.Size(158, 20);
            this.Worker_Surname.TabIndex = 0;
            // 
            // Worker_Name
            // 
            this.Worker_Name.Enabled = false;
            this.Worker_Name.Location = new System.Drawing.Point(465, 63);
            this.Worker_Name.Name = "Worker_Name";
            this.Worker_Name.Size = new System.Drawing.Size(158, 20);
            this.Worker_Name.TabIndex = 1;
            // 
            // Worker_Fathername
            // 
            this.Worker_Fathername.Enabled = false;
            this.Worker_Fathername.Location = new System.Drawing.Point(465, 89);
            this.Worker_Fathername.Name = "Worker_Fathername";
            this.Worker_Fathername.Size = new System.Drawing.Size(158, 20);
            this.Worker_Fathername.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Worker_Position
            // 
            this.Worker_Position.Enabled = false;
            this.Worker_Position.Location = new System.Drawing.Point(465, 167);
            this.Worker_Position.Name = "Worker_Position";
            this.Worker_Position.Size = new System.Drawing.Size(158, 20);
            this.Worker_Position.TabIndex = 6;
            // 
            // Worker_Number
            // 
            this.Worker_Number.Enabled = false;
            this.Worker_Number.Location = new System.Drawing.Point(465, 141);
            this.Worker_Number.Name = "Worker_Number";
            this.Worker_Number.Size = new System.Drawing.Size(158, 20);
            this.Worker_Number.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Surnamne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fathername";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Position";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Worker_About);
            this.groupBox1.Location = new System.Drawing.Point(319, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 195);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About";
            // 
            // Worker_About
            // 
            this.Worker_About.Enabled = false;
            this.Worker_About.Location = new System.Drawing.Point(6, 19);
            this.Worker_About.Multiline = true;
            this.Worker_About.Name = "Worker_About";
            this.Worker_About.Size = new System.Drawing.Size(292, 170);
            this.Worker_About.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Born date";
            // 
            // Worker_Age
            // 
            this.Worker_Age.Enabled = false;
            this.Worker_Age.Location = new System.Drawing.Point(465, 115);
            this.Worker_Age.Name = "Worker_Age";
            this.Worker_Age.Size = new System.Drawing.Size(158, 20);
            this.Worker_Age.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // Worker_ID
            // 
            this.Worker_ID.Enabled = false;
            this.Worker_ID.Location = new System.Drawing.Point(465, 11);
            this.Worker_ID.Name = "Worker_ID";
            this.Worker_ID.Size = new System.Drawing.Size(158, 20);
            this.Worker_ID.TabIndex = 16;
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // SecurityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Worker_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Worker_Age);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Worker_Position);
            this.Controls.Add(this.Worker_Number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Worker_Fathername);
            this.Controls.Add(this.Worker_Name);
            this.Controls.Add(this.Worker_Surname);
            this.Name = "SecurityPanel";
            this.Text = "SecurityPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityPanel_FormClosed);
            this.Load += new System.EventHandler(this.SecurityPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Worker_Surname;
        private System.Windows.Forms.TextBox Worker_Name;
        private System.Windows.Forms.TextBox Worker_Fathername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Worker_Position;
        private System.Windows.Forms.TextBox Worker_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Worker_About;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Worker_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Worker_ID;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
    }
}