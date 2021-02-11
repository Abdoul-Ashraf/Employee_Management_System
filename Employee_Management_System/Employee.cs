using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Employee
    {
        public string ID { get;  set; }
        public string name { get; set; }
        public string address { get;  set; }
        public string email { get;  set; }
        public string phone { get;  set; }
        public string role { get; set; }

        public Employee(string ID, string name, string address, string email, string phone, string role)
        {
            this.ID = ID;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }
    }
}
