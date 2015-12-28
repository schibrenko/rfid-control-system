using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControlSystem
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// Control system by reading rfid cards 
        /// </summary>
        //Data base global connection
        public static string database_connection_file = System.IO.File.ReadAllText(@"config.cfg");
        public static readonly MySqlConnection connection = connection = new MySqlConnection(database_connection_file);
        //Global value of port number
        public static string serialname = "";
        [STAThread]
        static void Main()
        { 
            try
            {
                connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Problems with MySQL data base connection. Please call engeneer!", "Data base ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlSystem());
        }
    }
}
