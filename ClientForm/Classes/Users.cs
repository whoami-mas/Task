using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm.Classes
{
    public class Users
    {
        public string name { get; set; }
        public int age { get; set; }
        public string date { get; set; }

        public Users (string name, int age)
            {
            this.name = name;
            this.age = age;
            this.date = DateTime.Now.ToString("yyyy:MM:dd");
        }
        public Users (string name, int age, string date)
        {
            this.name = name;
            this.age = age;
            this.date = date;
        }
    }
}
