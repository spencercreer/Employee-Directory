
namespace EmpDir_Testing
{
    partial class AddEmpForm
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
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.departmentLst = new System.Windows.Forms.ListBox();
            this.salaryCb = new System.Windows.Forms.CheckBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.yrSalaryTrackBar = new System.Windows.Forms.TrackBar();
            this.yearlySalaryLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yrSalaryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(13, 13);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(76, 17);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "First Name";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(96, 13);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(100, 22);
            this.firstNameTb.TabIndex = 1;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(13, 42);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name";
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(96, 42);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(100, 22);
            this.lastNameTb.TabIndex = 3;
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(7, 80);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(82, 17);
            this.departmentLbl.TabIndex = 4;
            this.departmentLbl.Text = "Department";
            // 
            // departmentLst
            // 
            this.departmentLst.FormattingEnabled = true;
            this.departmentLst.ItemHeight = 16;
            this.departmentLst.Items.AddRange(new object[] {
            "Sales",
            "Marketing",
            "Accounting",
            "Engineering"});
            this.departmentLst.Location = new System.Drawing.Point(96, 80);
            this.departmentLst.Name = "departmentLst";
            this.departmentLst.Size = new System.Drawing.Size(120, 84);
            this.departmentLst.TabIndex = 5;
            // 
            // salaryCb
            // 
            this.salaryCb.AutoSize = true;
            this.salaryCb.Location = new System.Drawing.Point(96, 182);
            this.salaryCb.Name = "salaryCb";
            this.salaryCb.Size = new System.Drawing.Size(70, 21);
            this.salaryCb.TabIndex = 7;
            this.salaryCb.Text = "Salary";
            this.salaryCb.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(10, 323);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.DarkRed;
            this.titleLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLbl.Location = new System.Drawing.Point(265, 13);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(355, 30);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "Add Kitties-R-Us Employee";
            // 
            // yrSalaryTrackBar
            // 
            this.yrSalaryTrackBar.LargeChange = 200;
            this.yrSalaryTrackBar.Location = new System.Drawing.Point(112, 233);
            this.yrSalaryTrackBar.Maximum = 200000;
            this.yrSalaryTrackBar.Minimum = 10000;
            this.yrSalaryTrackBar.Name = "yrSalaryTrackBar";
            this.yrSalaryTrackBar.Size = new System.Drawing.Size(104, 56);
            this.yrSalaryTrackBar.TabIndex = 11;
            this.yrSalaryTrackBar.Value = 10000;
            // 
            // yearlySalaryLbl
            // 
            this.yearlySalaryLbl.AutoSize = true;
            this.yearlySalaryLbl.Location = new System.Drawing.Point(13, 233);
            this.yearlySalaryLbl.Name = "yearlySalaryLbl";
            this.yearlySalaryLbl.Size = new System.Drawing.Size(92, 17);
            this.yearlySalaryLbl.TabIndex = 12;
            this.yearlySalaryLbl.Text = "Yearly Salary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpDir_Testing.Properties.Resources.Cat;
            this.pictureBox1.Location = new System.Drawing.Point(255, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearlySalaryLbl);
            this.Controls.Add(this.yrSalaryTrackBar);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.salaryCb);
            this.Controls.Add(this.departmentLst);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "AddEmpForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yrSalaryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.ListBox departmentLst;
        private System.Windows.Forms.CheckBox salaryCb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TrackBar yrSalaryTrackBar;
        private System.Windows.Forms.Label yearlySalaryLbl;
    }
}

