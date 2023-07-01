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
        public bool IsSalary { get; set;  }
        public decimal YearlySalary { get; set; }

        public Employee(string firstName, string lastName, string department, bool isSalary, decimal yearlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            IsSalary = isSalary; // false would be hourly
            YearlySalary = yearlySalary;
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
