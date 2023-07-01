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
            searchEmpTb.TextChanged += searchTextBox_TextChanged;
            salaryFilter.CheckedChanged += SalaryFilter_CheckedChanged;

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
            dataGridView1.Columns.Add("isSalary", "Salary");

            // Clear the DataGridView rows
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with employee data
            foreach (Employee employee in employeeList)
            {
                dataGridView1.Rows.Add(employee.FirstName, employee.LastName, employee.Department, employee.IsSalary);
                // Add more columns and data as needed
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchEmpTb.Text.ToLower();

            DataGridView dataGridView1 = empDGV;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string firstName = row.Cells["FirstName"].Value?.ToString()?.ToLower() ?? string.Empty;
                string lastName = row.Cells["LastName"].Value?.ToString()?.ToLower() ?? string.Empty;
                string department = row.Cells["Department"].Value?.ToString()?.ToLower() ?? string.Empty;

                bool match = firstName.Contains(searchText) || lastName.Contains(searchText) || department.Contains(searchText);

                row.Visible = match;
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            AddEmpForm addEmpForm = new AddEmpForm();
            addEmpForm.FormClosed += AddEmpForm_FormClosed; // Subscribe to FormClosed event

            addEmpForm.ShowDialog();
        }

        private void SalaryFilter_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = salaryFilter.Checked;

            if (isChecked)
            {
                // Perform filtering to show only salary employees
                DataGridView dataGridView1 = empDGV;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Skip the new row if it exists
                    if (!row.IsNewRow)
                    {
                        // Get the value of the "isSalary" column (assuming it's a boolean column)
                        bool isSalaryEmployee = Convert.ToBoolean(row.Cells["isSalary"].Value);

                        // Hide the row if it's not a salary employee
                        row.Visible = isSalaryEmployee;
                    }
                }
            }
            else
            {
                // Reset the filter and show all employees
                RefreshDataGridView();
            }
        }

        private void AddEmpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataGridView(); // Refresh the DataGridView when AddEmpForm is closed
        }

        private void viewEmpBtn_Click(object sender, EventArgs e)
        {
            EmpInfoForm empInfoForm = new EmpInfoForm();
            empInfoForm.ShowDialog();
        }
    }
}