using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpDir_Testing
{
    public partial class AddEmpForm : Form
    {
        public AddEmpForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the form you want to open
            EmpLstForm form2 = new EmpLstForm();

            // Create a new instance of the Employee class
            string firstName = firstNameTb.Text;
            string lastName = lastNameTb.Text;
            string department = departmentLst.Text;
            bool salary = salaryCb.Checked;
            decimal yearlySalary = yrSalaryTrackBar.Value;
            Employee newEmployee = new Employee(firstName, lastName, department, salary, yearlySalary);

            // Access the EmployeeList property of the EmployeeManager singleton instance
            List<Employee> employeeList = EmployeeManager.Instance.EmployeeList;

            // Add the new employee to the EmployeeList
            employeeList.Add(newEmployee);

            this.Close();

        }
    }
}
