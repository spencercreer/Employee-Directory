
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
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // empDGV
            // 
            this.empDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDGV.Location = new System.Drawing.Point(136, 42);
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
            this.addEmpBtn.Location = new System.Drawing.Point(90, 415);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(127, 23);
            this.addEmpBtn.TabIndex = 2;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // EmpLstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empDGV);
            this.Name = "EmpLstForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EmpLstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmpBtn;
    }
}