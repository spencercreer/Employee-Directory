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
    public partial class EmpLstForm : Form
    {
        public EmpLstForm()
        {
            InitializeComponent();
        }

        private void EmpLstForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Access the DataGridView control
            DataGridView dataGridView1 = empDGV;

            // Get the EmployeeManager instance and retrieve the employee list
            EmployeeManager employeeManager = EmployeeManager.Instance;
            List<Employee> employeeList = employeeManager.EmployeeList;

            // Set the DataGridView properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Department", "Department");
            // Add more columns as needed

            // Clear the DataGridView rows
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with employee data
            foreach (Employee employee in employeeList)
            {
                dataGridView1.Rows.Add(employee.FirstName, employee.LastName, employee.Department);
                // Add more columns and data as needed
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            AddEmpForm addEmpForm = new AddEmpForm();
            addEmpForm.FormClosed += AddEmpForm_FormClosed; // Subscribe to FormClosed event

            addEmpForm.ShowDialog();
        }

        private void AddEmpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataGridView(); // Refresh the DataGridView when AddEmpForm is closed
        }
    }
}