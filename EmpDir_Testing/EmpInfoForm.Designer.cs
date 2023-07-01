
namespace EmpDir_Testing
{
    partial class EmpInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalSalaryLbl = new System.Windows.Forms.Label();
            this.deptGb = new System.Windows.Forms.GroupBox();
            this.EngDeptRb = new System.Windows.Forms.RadioButton();
            this.accountingDeptRb = new System.Windows.Forms.RadioButton();
            this.marketingDeptRb = new System.Windows.Forms.RadioButton();
            this.salesDeptRb = new System.Windows.Forms.RadioButton();
            this.allDeptRb = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.deptGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empList
            // 
            this.empList.Location = new System.Drawing.Point(69, 403);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(155, 23);
            this.empList.TabIndex = 0;
            this.empList.Text = "Employee List";
            this.empList.UseVisualStyleBackColor = true;
            this.empList.Click += new System.EventHandler(this.empList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Budget:";
            // 
            // totalSalaryLbl
            // 
            this.totalSalaryLbl.AutoSize = true;
            this.totalSalaryLbl.Location = new System.Drawing.Point(208, 118);
            this.totalSalaryLbl.Name = "totalSalaryLbl";
            this.totalSalaryLbl.Size = new System.Drawing.Size(46, 17);
            this.totalSalaryLbl.TabIndex = 4;
            this.totalSalaryLbl.Text = "label2";
            // 
            // deptGb
            // 
            this.deptGb.Controls.Add(this.EngDeptRb);
            this.deptGb.Controls.Add(this.accountingDeptRb);
            this.deptGb.Controls.Add(this.marketingDeptRb);
            this.deptGb.Controls.Add(this.salesDeptRb);
            this.deptGb.Controls.Add(this.allDeptRb);
            this.deptGb.Location = new System.Drawing.Point(58, 13);
            this.deptGb.Name = "deptGb";
            this.deptGb.Size = new System.Drawing.Size(271, 102);
            this.deptGb.TabIndex = 5;
            this.deptGb.TabStop = false;
            this.deptGb.Text = "Departments";
            // 
            // EngDeptRb
            // 
            this.EngDeptRb.AutoSize = true;
            this.EngDeptRb.Location = new System.Drawing.Point(122, 48);
            this.EngDeptRb.Name = "EngDeptRb";
            this.EngDeptRb.Size = new System.Drawing.Size(105, 21);
            this.EngDeptRb.TabIndex = 4;
            this.EngDeptRb.TabStop = true;
            this.EngDeptRb.Text = "Engineering";
            this.EngDeptRb.UseVisualStyleBackColor = true;
            // 
            // accountingDeptRb
            // 
            this.accountingDeptRb.AutoSize = true;
            this.accountingDeptRb.Location = new System.Drawing.Point(122, 21);
            this.accountingDeptRb.Name = "accountingDeptRb";
            this.accountingDeptRb.Size = new System.Drawing.Size(99, 21);
            this.accountingDeptRb.TabIndex = 3;
            this.accountingDeptRb.TabStop = true;
            this.accountingDeptRb.Text = "Accounting";
            this.accountingDeptRb.UseVisualStyleBackColor = true;
            // 
            // marketingDeptRb
            // 
            this.marketingDeptRb.AutoSize = true;
            this.marketingDeptRb.Location = new System.Drawing.Point(11, 73);
            this.marketingDeptRb.Name = "marketingDeptRb";
            this.marketingDeptRb.Size = new System.Drawing.Size(91, 21);
            this.marketingDeptRb.TabIndex = 2;
            this.marketingDeptRb.TabStop = true;
            this.marketingDeptRb.Text = "Marketing";
            this.marketingDeptRb.UseVisualStyleBackColor = true;
            // 
            // salesDeptRb
            // 
            this.salesDeptRb.AutoSize = true;
            this.salesDeptRb.Location = new System.Drawing.Point(11, 48);
            this.salesDeptRb.Name = "salesDeptRb";
            this.salesDeptRb.Size = new System.Drawing.Size(64, 21);
            this.salesDeptRb.TabIndex = 1;
            this.salesDeptRb.TabStop = true;
            this.salesDeptRb.Text = "Sales";
            this.salesDeptRb.UseVisualStyleBackColor = true;
            // 
            // allDeptRb
            // 
            this.allDeptRb.AutoSize = true;
            this.allDeptRb.Location = new System.Drawing.Point(11, 21);
            this.allDeptRb.Name = "allDeptRb";
            this.allDeptRb.Size = new System.Drawing.Size(44, 21);
            this.allDeptRb.TabIndex = 0;
            this.allDeptRb.TabStop = true;
            this.allDeptRb.Text = "All";
            this.allDeptRb.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpDir_Testing.Properties.Resources.Tiger;
            this.pictureBox1.Location = new System.Drawing.Point(526, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Messages";
            // 
            // EmpInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deptGb);
            this.Controls.Add(this.totalSalaryLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empList);
            this.Name = "EmpInfoForm";
            this.Text = "Form1";
            this.deptGb.ResumeLayout(false);
            this.deptGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalSalaryLbl;
        private System.Windows.Forms.GroupBox deptGb;
        private System.Windows.Forms.RadioButton EngDeptRb;
        private System.Windows.Forms.RadioButton accountingDeptRb;
        private System.Windows.Forms.RadioButton marketingDeptRb;
        private System.Windows.Forms.RadioButton salesDeptRb;
        private System.Windows.Forms.RadioButton allDeptRb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}