using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Payroll
    {
        public string ID { get; set; }
        public string employeeID{ get; set; }
        public int hoursWorked { get; set; }
        public double hourlyRate { get; set; }
        public DateTime date { get; set; }

        public Payroll(string ID, string employeeID, int hoursWorked, double hourlyRate, DateTime date)
        {
            this.ID = ID;
            this.employeeID = employeeID;
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
            this.date = date;
        }

    }
}
