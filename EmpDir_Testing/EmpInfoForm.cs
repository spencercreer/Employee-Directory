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
    public partial class EmpInfoForm : Form
    {
        public List<Message> messageList;
        public EmpInfoForm()
        {
            InitializeComponent();

            // Get the messageManager instance and retrieve the message list
            MessageManager messageManager = MessageManager.Instance;
            messageList = messageManager.MessageList;

            this.allDeptRb.CheckedChanged += new System.EventHandler(this.DepartmentRadioButton_CheckedChanged);
            this.salesDeptRb.CheckedChanged += new System.EventHandler(this.DepartmentRadioButton_CheckedChanged);
            this.marketingDeptRb.CheckedChanged += new System.EventHandler(this.DepartmentRadioButton_CheckedChanged);
            this.accountingDeptRb.CheckedChanged += new System.EventHandler(this.DepartmentRadioButton_CheckedChanged);
            this.EngDeptRb.CheckedChanged += new System.EventHandler(this.DepartmentRadioButton_CheckedChanged);

            // set All department to be checked by default
            allDeptRb.Checked = true;

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Access the DataGridView control
            DataGridView dataGridView1 = this.dataGridView1;

            // Set the DataGridView properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("Message", "Message");
            dataGridView1.Columns.Add("Department", "Department");

            // Clear the DataGridView rows
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with employee data
            foreach (Message message in messageList)
            {
                dataGridView1.Rows.Add(message.MsgText, message.Department);
                // Add more columns and data as needed
            }
        }

        private void DepartmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                string selectedDepartment = radioButton.Text;

                // Get the EmployeeManager instance and retrieve the employee list
                EmployeeManager employeeManager = EmployeeManager.Instance;
                List<Employee> employeeList = employeeManager.EmployeeList;

                // Calculate the total salary for the selected department
                decimal totalSalary = 0;
                foreach (Employee employee in employeeList)
                {
                    if (employee.Department == selectedDepartment || selectedDepartment == "All")
                    {
                        totalSalary += employee.YearlySalary;
                    }
                }

                // Display the total salary in the label
                totalSalaryLbl.Text = $"Total Salary: {totalSalary.ToString("C")}";
            }
        }

        private void empList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = textBox1.Text;
            string dpt;
            // Check which radio button is selected
            if (allDeptRb.Checked)
            {
                dpt = "All";
            }
            else if (salesDeptRb.Checked)
            {
                dpt = "Sales";
            }
            else if (marketingDeptRb.Checked)
            {
                dpt = "Marketing";
            }
            else if (accountingDeptRb.Checked)
            {
                dpt = "Accounting";
            }
            else
            {
                dpt = "Engineering";
            }

            Message m = new Message(msg, dpt);
            messageList.Add(m);
            RefreshDataGridView();
        }
    }
}
