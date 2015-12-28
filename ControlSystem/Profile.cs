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

namespace ControlSystem
{
    class Profile
    {
        private string name, surname, fathername, born, position, about, id, number, photo;

      public  Profile() { }
      public  Profile(string id, string name, string surname, string fathername, string born, string position, string about, string number)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.born = born;
            this.position = position;
            this.about = about;
            this.number = number;
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string About
        {
            get { return about; }
            set { about = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Born
        {
            get { return born; }
            set { born = value; }
        }

        public string Fathername
        {
            get { return fathername; }
            set { fathername = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       public Image GetImage()
        {
            try
            {
                Bitmap bmp = new Bitmap(this.photo);
                Image img;
                img = (Image)bmp;
                return img;
            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}
