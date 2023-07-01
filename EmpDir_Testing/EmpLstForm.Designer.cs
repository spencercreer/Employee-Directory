
namespace EmpDir_Testing
{
    partial class EmpLstForm
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
            this.empDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.viewEmpBtn = new System.Windows.Forms.Button();
            this.searchEmpTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryFilter = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // empDGV
            // 
            this.empDGV.AllowUserToAddRows = false;
            this.empDGV.AllowUserToDeleteRows = false;
            this.empDGV.AllowUserToResizeColumns = false;
            this.empDGV.AllowUserToResizeRows = false;
            this.empDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDGV.Location = new System.Drawing.Point(12, 75);
            this.empDGV.Name = "empDGV";
            this.empDGV.RowHeadersWidth = 51;
            this.empDGV.RowTemplate.Height = 24;
            this.empDGV.Size = new System.Drawing.Size(580, 359);
            this.empDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitties-R-Us Employee Directory";
            this.label1.UseWaitCursor = true;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addEmpBtn.Location = new System.Drawing.Point(92, 440);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(127, 23);
            this.addEmpBtn.TabIndex = 2;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // viewEmpBtn
            // 
            this.viewEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewEmpBtn.Location = new System.Drawing.Point(225, 440);
            this.viewEmpBtn.Name = "viewEmpBtn";
            this.viewEmpBtn.Size = new System.Drawing.Size(155, 23);
            this.viewEmpBtn.TabIndex = 3;
            this.viewEmpBtn.Text = "View Department Info";
            this.viewEmpBtn.UseVisualStyleBackColor = false;
            this.viewEmpBtn.Click += new System.EventHandler(this.viewEmpBtn_Click);
            // 
            // searchEmpTb
            // 
            this.searchEmpTb.Location = new System.Drawing.Point(209, 47);
            this.searchEmpTb.Name = "searchEmpTb";
            this.searchEmpTb.Size = new System.Drawing.Size(100, 22);
            this.searchEmpTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Employee Directory";
            // 
            // salaryFilter
            // 
            this.salaryFilter.AutoSize = true;
            this.salaryFilter.Location = new System.Drawing.Point(316, 48);
            this.salaryFilter.Name = "salaryFilter";
            this.salaryFilter.Size = new System.Drawing.Size(103, 21);
            this.salaryFilter.TabIndex = 7;
            this.salaryFilter.Text = "Salary Only";
            this.salaryFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salaryFilter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpDir_Testing.Properties.Resources.Kitty;
            this.pictureBox1.Location = new System.Drawing.Point(611, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EmpLstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 475);
            this.Controls.Add(this.salaryFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchEmpTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewEmpBtn);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empDGV);
            this.Name = "EmpLstForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EmpLstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button viewEmpBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchEmpTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox salaryFilter;
    }
}