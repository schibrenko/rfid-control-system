using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Drawing;
using System.Media;

namespace ControlSystem
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }
        //create object of Profile class
        Profile ShowProfile = new Profile();
        string id = "";

        // on form load send command "2" to clear device buffer with id
        private void SecurityPanel_Load(object sender, EventArgs e)
        {

            serialPort2.PortName = Program.serialname;
            serialPort2.Open();
            serialPort2.WriteLine("2");

        }

        //on form closed - close our serial port connection
        private void SecurityPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort2.Close();
            ControlSystem system = new ControlSystem();
            system.Show();
            
        }

        //show full information about member from data base
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
            });
            if (InvokeRequired)
                this.BeginInvoke(Insertion);
            else Insertion();
            
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //read id from serial port
            id = serialPort2.ReadLine();
            try
            {
                //query for select all members with read id
                string query = @"SELECT * From general WHERE id='"+id+"'";
                
                MySqlCommand command = new MySqlCommand(query, Program.connection);
                MySqlDataReader read = command.ExecuteReader();
                //write all information about member to object of our own class 'Profile'
                
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
            ShowProfileOnForm();
      }
    }

}
