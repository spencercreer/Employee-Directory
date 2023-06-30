using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDir_Testing
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public Employee(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
    }

    public class EmployeeManager
    {
        private static EmployeeManager instance;
        private List<Employee> employeeList;

        private EmployeeManager()
        {
            employeeList = new List<Employee>();
        }

        public static EmployeeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeManager();
                }
                return instance;
            }
        }

        public List<Employee> EmployeeList
        {
            get { return employeeList; }
        }
    }
}
