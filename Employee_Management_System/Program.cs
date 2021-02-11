using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Payroll> payrolls = new List<Payroll>();
            List<Vacation> vacations = new List<Vacation>();

            int choice = 0;
            while(choice != 7) { 
            Console.WriteLine();
            Console.WriteLine("____________________EMPLOYEES MANAGEMENT SYSTEM____________________ ");
            Console.WriteLine("Press the number that correponds to the action you want to perdorm : ");
            Console.WriteLine("1- Add an employee");
            Console.WriteLine("2- Delete an employee");
            Console.WriteLine("3- Update an employee's informations");
            Console.WriteLine("4- All employees list");
            Console.WriteLine("5- All payroll list");
            Console.WriteLine("6- All vacation list");
            Console.WriteLine("7- To exit...!!!");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("What is your choice?");

            choice = Convert.ToInt32(Console.ReadLine());
            
                if(choice == 1) {
                    Employee e = addEmployee();
                    employees.Add(e);
                    vacations.Add(addVacation(e));
                    Console.WriteLine(" Add a new Payroll for this employee ?? ");
                    Console.WriteLine(" Press o for yes any key for no");
                    string read = Console.ReadLine();
                    if (read == "o") {
                        payrolls.Add(addPayroll(e));
                        foreach (Vacation vac in vacations)
                        {
                            vac.numberOfDays += 1;
                        }
                    }
                    foreach (Vacation vac in vacations)
                    {
                        vac.numberOfDays += 14;
                    }


                }
                else if(choice == 2) { deleteEmployee(employees); }
                else if(choice == 3) { updateEmployee(employees); }
                else if (choice == 4) {
                    if (employees.Count == 0) { Console.WriteLine("None!!!"); }
                    listOfEmployees(employees); }
                else if (choice == 5) { listOfPayroll(payrolls); }
                else if (choice == 6) { listOfVacation(vacations); }
                else { Console.WriteLine("Wrong choice !!! Choose Again"); }
 
            }

        }

        static Employee addEmployee()
        {
            Console.WriteLine("Give employee ID");
            string ID = Console.ReadLine();
            Console.WriteLine("Give the name of the employee");
            string name = Console.ReadLine();
            Console.WriteLine("Give the address of the employee");
            string address = Console.ReadLine();
            Console.WriteLine("Give email of the employee");
            string email = Console.ReadLine();
            Console.WriteLine("Give the phone of the employee");
            string phone= Console.ReadLine();
            Console.WriteLine("Give the role of the employee");
            string role = Console.ReadLine();

            return new Employee(ID, name, address, email, phone, role);
        }

        static Payroll addPayroll( Employee emp)
        {
            Console.WriteLine("Give payroll ID");
            string ID = Console.ReadLine();
            Console.WriteLine("hours Worked ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("hourly Rate");
            double hourlyRate = double.Parse(Console.ReadLine());
            
            DateTime date = new DateTime();

            return new Payroll(ID, emp.ID, hoursWorked, hourlyRate, date);
        }

        static Vacation addVacation(Employee emp)
        {
            Console.WriteLine("Give vacation ID");
            string ID = Console.ReadLine();
            Console.WriteLine("Give the number Of Days");
            int numberOfDays = Convert.ToInt32(Console.ReadLine());

            return new Vacation(ID, emp.ID, numberOfDays);
        }

        static void listOfEmployees(List<Employee> empList)
        {
            Console.WriteLine();
            Console.WriteLine("List of employees: ");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(string.Format("ID: {0}, Name: {1}, Address: {2}, email: {3}, phone: {4}, role: {5}", emp.ID, emp.name, emp.address, emp.email, emp.phone, emp.role));
            }
        }

        static void listOfPayroll(List<Payroll> payList)
        {
            Console.WriteLine();
            Console.WriteLine("List of Payroll: ");
            foreach (Payroll p in payList)
            {
                Console.WriteLine(string.Format("ID: {0}, Employee ID: {1}, hours worked: {2}, hourly rate: {3}, date: {4}", p.ID, p.employeeID, p.hoursWorked, p.hourlyRate, p.date));
            }
        }

        static void listOfVacation(List<Vacation> vacList)
        {
            Console.WriteLine();
            Console.WriteLine("List of Vacation: ");
            foreach (Vacation v in vacList)
            {
                Console.WriteLine(string.Format("ID: {0}, Employee ID: {1}, number of days: {2}", v.ID, v.employeeID, v.numberOfDays));
            }
        }

        static void deleteEmployee( List<Employee> empList)
        {
            Console.WriteLine("Write the ID of the employee, you want to remove");
            string ID = Console.ReadLine();
            IEnumerable<Employee> emp = from Employee in empList where Employee.ID == ID select Employee;
            foreach (Employee employee in empList)
            {
                if (emp.Contains(employee)) { empList.Remove(employee); }
            }
            Console.WriteLine("Deleted!!!");
        }

        static void updateEmployee (List<Employee> empList)
        {
           
            Console.WriteLine("Write the ID of the employee, you want to update");
            string ID = Console.ReadLine();
            IEnumerable<Employee> emp = from Employee in empList where Employee.ID == ID select Employee;

            Console.WriteLine("Enter the new name ,if there is no new name enter q ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new address,if there is no new address enter q ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the new email,if there is no new email enter q ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the new phone,if there is no new phone enter q ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the new role,if there is no new role enter q ");
            string role = Console.ReadLine();

            foreach (Employee empl in empList)
            {
                if (emp.Contains(empl)) { if (name != "q") { empl.name = name; }
                    if (address != "q") { empl.address = address; }
                    if (email!= "q") { empl.email = email; }
                    if (phone != "q") { empl.phone = phone; }
                    if (role != "q") { empl.role = role; }
                }

            }

            Console.WriteLine("Updated!!!");
        }

    }
}
