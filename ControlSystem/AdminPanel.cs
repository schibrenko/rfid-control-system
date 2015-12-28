using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ControlSystem
{
    public partial class AdminPanel : Form
    {
        
        string image_path = "";
        string date_of_birth = "";
        string id = "";
        Profile ShowProfile=new Profile();
        public AdminPanel()
        {
            InitializeComponent();

            //Hide tab cintrol and his tabs
            tabControl1.TabPages.Remove(add_tab);
            tabControl1.TabPages.Remove(edit_tab);
            tabControl1.Visible = false;
        }
        //on close form back to loginandclose ports in current form
        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*back to main form*/
            serialPort1.Close();
            ControlSystem system = new ControlSystem();
            system.Show();
        }
        /*check every tick . All rows are fill or not
        *if all show add button and give a user aportunities to add new profile
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(add_tab))
            {
                if (image_path.Length > 0 && date_of_birth.Length > 0 && new_name.TextLength > 0 && new_surname.TextLength > 0
                    && new_byfather.TextLength > 0 && new_position.TextLength > 0 && new_phone.TextLength > 0)
                        add_button.Enabled = true;
                else
                    add_button.Enabled = false;
            }

            else if(tabControl1.TabPages.Contains(edit_tab))
            {
                if (image_path.Length > 0 && Worker_Age.Text.Length > 0 && Worker_Name.Text.Length > 0 && Worker_Surname.Text.Length > 0
                  && Worker_Fathername.Text.Length > 0 && Worker_Position.Text.Length > 0 && Worker_Number.Text.Length > 0 && Worker_ID.Text.Length > 0)
                    Edit_button.Enabled = true;
                else
                    Edit_button.Enabled = false;
            }
        }
        /*
         * Get data from serialport
         * make query to db and check our id from reader
         * 
         */
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if(!tabControl1.TabPages.Contains(add_tab))
                id= serialPort1.ReadLine();
           try
           {
               //query to data 
               string query = "SELECT COUNT(id) FROM general WHERE id ='"+id+"';";
               MySqlCommand command = new MySqlCommand(query, Program.connection);
               var exist = command.ExecuteScalar();
               //process Cuery return and if it's no selected id open add_mode
               if (exist.ToString() == "0")
               {
                   Action CloseTab = new Action(() =>
                   { tabControl1.TabPages.Remove(edit_tab); });
                   this.BeginInvoke(CloseTab);
                   ShowTabAdd();
               }
               //in other cases go to edit mode 
               else
               {

                   try
                   {
                       string quer = @"SELECT * From general WHERE id='" + id + "'";

                       MySqlCommand comman = new MySqlCommand(quer, Program.connection);
                       MySqlDataReader read = comman.ExecuteReader();


                       while (read.Read())
                       {
                           ShowProfile.Id = read.GetString(0);
                           ShowProfile.Name = read.GetString(2);
                           ShowProfile.Surname = read.GetString(1);
                           ShowProfile.Fathername = read.GetString(3);
                           ShowProfile.Position = read.GetString(4);
                           ShowProfile.About = read.GetString(5);
                           ShowProfile.Born = read.GetString(6);
                           ShowProfile.Photo = read.GetString(7);
                           ShowProfile.Number = read.GetString(8);

                       }
                       read.Close();
                   }
                   catch (MySqlException)
                   {
                       MessageBox.Show("Problems with MySQL data base connection. Please call engeneer");
                   }
                   ShowTabEdit();
                   ShowProfileOnForm();
               }

               
           }
           catch (MySqlException)
           {
               MessageBox.Show("Problems with MySQL data base connection. Please call engeneer");
           }
        }
        //when form load initialize port name
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = Program.serialname;
            serialPort1.Open();
            Thread.Sleep(1000);
            serialPort1.WriteLine("2");
        }
        private void ShowTabAdd()
        {
            Action Insertion = new Action(() =>
            { 
                tabControl1.Visible = true;
                if (!tabControl1.TabPages.Contains(add_tab)&&(!tabControl1.TabPages.Contains(edit_tab)))
                {
                    tabControl1.TabPages.Add(add_tab);
                    timer1.Enabled = true;
                }
            });
            if (InvokeRequired)
                this.BeginInvoke(Insertion);
            else Insertion();

        }

        private void ShowTabEdit()
        {
            Action Insertion = new Action(() =>
            {
                tabControl1.Visible = true;
                if (!tabControl1.TabPages.Contains(edit_tab)&&(!tabControl1.TabPages.Contains(add_tab)))
                {
                    tabControl1.TabPages.Add(edit_tab);
                    timer1.Enabled = true;
                }
            });
            if (InvokeRequired)
                this.BeginInvoke(Insertion);
            else Insertion();

        }

        private void ShowProfileOnForm()
        {
            Action Insertion = new Action(() =>
            {
                Worker_ID.Text = ShowProfile.Id;
                Worker_Name.Text = ShowProfile.Name;
                Worker_Surname.Text = ShowProfile.Surname;
                Worker_Fathername.Text = ShowProfile.Fathername;
                Worker_Position.Text = ShowProfile.Position;
                Worker_About.Text = ShowProfile.About;
                Worker_Number.Text = ShowProfile.Number;
                Worker_Age.Text = ShowProfile.Born;
                Worker_Number.Text = ShowProfile.Number;
                pictureBox1.Image = ShowProfile.GetImage();
                image_path = ShowProfile.Photo;
            });
            if (InvokeRequired)
                this.BeginInvoke(Insertion);
            else Insertion();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog image_picker = new OpenFileDialog();
            image_picker.Title = "Open Image";
            image_picker.Filter = "jpg files (*.jpg)|*.jpg";

            //uppload new file to profile imageBox and set a path val for data base
            if (image_picker.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(image_picker.FileName);
                image_path = image_picker.FileName;
            }
        }
        
       
        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                image_path = image_path.Replace(@"\", @"\\");
                string values = "surname='" + Worker_Surname.Text + "', name='" + Worker_Name.Text + "', fathername='" + Worker_Fathername.Text + "', position='" + Worker_Position.Text + "', about='" + Worker_About.Text + "',born='" + Worker_Age.Text
                    + "',photo='" + image_path + "', number='" + Worker_Number.Text + "'";
                string query = "UPDATE general SET " + values + " WHERE id='" + id + "';";
                MessageBox.Show(query);
                MySqlCommand command = new MySqlCommand(query, Program.connection);
                command.ExecuteNonQuery();
                tabControl1.TabPages.Remove(add_tab);
                tabControl1.Visible = false;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Problems with MySQL data base connection. Please call engeneer");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog image_picker = new OpenFileDialog();
            image_picker.Title = "Open Image";
            image_picker.Filter = "jpg files (*.jpg)|*.jpg";

            //uppload new file to profile imageBox and set a path val for data base
            if (image_picker.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = new Bitmap(image_picker.FileName);
                image_path = image_picker.FileName;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_of_birth = dateTimePicker1.Value.ToShortDateString();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                image_path = image_path.Replace(@"\", @"\\");
                string values = id + "','" + new_surname.Text + "','" + new_name.Text + "','" + new_byfather.Text + "','" + new_position.Text + "','" + new_about.Text + "','" + date_of_birth
                    + "','" + image_path + "','" + new_phone.Text;
                string query = "INSERT INTO general VALUES ('" + values + "');";
                MessageBox.Show(query);
                MySqlCommand command = new MySqlCommand(query, Program.connection);
                command.ExecuteNonQuery();
                tabControl1.TabPages.Remove(add_tab);
                tabControl1.Visible = false;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Problems with MySQL data base connection. Please call engeneer!", "Data base ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(this.add_tab);
            tabControl1.Visible = false;
        }
    }
}
