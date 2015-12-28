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
using System.Media;
/*Main Log in form
 *Find device on com-port. Connect to it and read data.
 *Log in only if card id in data base has "Position" = Security or Admin
 */
namespace ControlSystem
{
    public partial class ControlSystem : Form
    {
        List<string> users_position;//indicate position on work place
        List<string> users_id;//users id's that has access to system
        string current_id;//id that we get from serial_port
        bool device_found = false;//indicate that we found our device(rfid reader)

        public ControlSystem()
        {
            InitializeComponent();
        }
        /*When form load
         * execute query that return all id and position rows with selected conditions
         * read data from database
         * loking through port to find our device
         */
        private void ControlSystem_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT id, position From general WHERE position='Admin' OR position='Security'";

                //create MySqlReader and MySqlCommand obj, execute query 
                MySqlCommand command = new MySqlCommand(query, Program.connection);
                MySqlDataReader read  = command.ExecuteReader();
                
                //initialize our List
                users_position = new List<string>();
                users_id = new List<string>();

                //read data from db and fill id and position lists
                while (read.Read())
                {
                    users_id.Add(read.GetString(0));
                    users_position.Add(read.GetString(1));
                }

                read.Close();//close read thread
            }
            catch (MySqlException)
            {
                MessageBox.Show("Problems with MySQL data base connection. Please call engeneer!","Data base ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            string serial_port_answer = "";

            //start lookig for our device
            for (int i = 0,ports=SerialPort.GetPortNames().Length; i < ports; i++)
            {
                //open every port and send data to it(our device catch command-"1" and answers like "Device")
                serialPort1.PortName = SerialPort.GetPortNames()[i];
                serialPort1.Open();
                serialPort1.WriteLine("1");

                Thread.Sleep(100);//Need to wait. Serial write/read is a litle bit slow

                //if port is open - read data from it
                if (serialPort1.IsOpen)
                    serial_port_answer = serialPort1.ReadExisting();

                //If it's serial port with our device
                if (serial_port_answer.Contains("Device"))
                {
                    //our devise found
                    device_found = true;
                    //assign global seril port name when found right port
                    serialPort1.WriteLine("2");
                    Program.serialname = serialPort1.PortName;   
                    break;
                }
                else
                {
                    serialPort1.Close();
                }
            }

    }

        /*when received data from serialPort
        *read our rfid marks and start need form
        */
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            if (device_found)//if we found our device
            {
                SystemSounds.Asterisk.Play();//indicate reading with sound

                if (serialPort1.IsOpen)
                {
                    current_id = serialPort1.ReadLine();//read card id(user id)
                    //if we have id then we search for it and run right form
                    if (users_id.Contains(current_id))
                    {
                        serialPort1.Close();
                        LoginAs(users_position[users_id.IndexOf(current_id)]);//Log in(open right form and give right functions for users)
                    }
                    else
                    {
                        current_id = "";
                    }
                }
            }
        }

        //open right form and give control to user that logined
        void LoginAs(string who)
        {
            //
            Action OpenForm = new Action(() =>
            {
                //only may be admin or security ! cause we selected only these positions from data base
                if (who == "Security")
                {
                 
                    SecurityPanel panel = new SecurityPanel();
                    panel.Show();
                }
                else//admin panel
                {
               
                    AdminPanel panel1 = new AdminPanel();
                    panel1.Show();
                }
              
                this.Hide();
            });
            //open form from current thread(serial port listener thread)
            if (InvokeRequired)
                this.BeginInvoke(OpenForm);
            else OpenForm();
        }
        //on form activated open port if it isn't open
        private void ControlSystem_Activated(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
                serialPort1.Open();
        }
        //Close port on deactivated form
        private void ControlSystem_Deactivate(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
                serialPort1.Close();
        }
        //on form closed close data and connection
        //close serialport connection, dispose form and close application
        private void ControlSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.connection.Close();
            if (serialPort1.IsOpen) 
                serialPort1.Close();
            this.Dispose();
            Application.Exit();
        }
    }

}
