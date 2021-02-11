using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Vacation
    {
        public string ID { get; set; }
        public string employeeID { get; set; }
        public int numberOfDays { get; set; }
        

        public Vacation(string ID, string employeeID, int numberOfDays)
        {
            this.ID = ID;
            this.employeeID = employeeID;
            this.numberOfDays = numberOfDays;
            
        }
    }
}
