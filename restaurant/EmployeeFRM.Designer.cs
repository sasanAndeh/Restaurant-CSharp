namespace restaurant
{
    partial class EmployeeFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNameEmployee = new System.Windows.Forms.TextBox();
            this.txtLastNameEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserNameEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordEmployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEmployeeSave = new System.Windows.Forms.DataGridView();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstNameEmployee
            // 
            this.txtFirstNameEmployee.Location = new System.Drawing.Point(130, 123);
            this.txtFirstNameEmployee.Name = "txtFirstNameEmployee";
            this.txtFirstNameEmployee.Size = new System.Drawing.Size(304, 26);
            this.txtFirstNameEmployee.TabIndex = 0;
            // 
            // txtLastNameEmployee
            // 
            this.txtLastNameEmployee.Location = new System.Drawing.Point(130, 167);
            this.txtLastNameEmployee.Name = "txtLastNameEmployee";
            this.txtLastNameEmployee.Size = new System.Drawing.Size(304, 26);
            this.txtLastNameEmployee.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Location = new System.Drawing.Point(130, 215);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(304, 26);
            this.txtPhoneEmployee.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // txtUserNameEmployee
            // 
            this.txtUserNameEmployee.Location = new System.Drawing.Point(130, 263);
            this.txtUserNameEmployee.Name = "txtUserNameEmployee";
            this.txtUserNameEmployee.Size = new System.Drawing.Size(304, 26);
            this.txtUserNameEmployee.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name";
            // 
            // txtPasswordEmployee
            // 
            this.txtPasswordEmployee.Location = new System.Drawing.Point(130, 309);
            this.txtPasswordEmployee.Name = "txtPasswordEmployee";
            this.txtPasswordEmployee.PasswordChar = '#';
            this.txtPasswordEmployee.Size = new System.Drawing.Size(304, 26);
            this.txtPasswordEmployee.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // dgvEmployeeSave
            // 
            this.dgvEmployeeSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeSave.Location = new System.Drawing.Point(464, 123);
            this.dgvEmployeeSave.Name = "dgvEmployeeSave";
            this.dgvEmployeeSave.RowHeadersWidth = 62;
            this.dgvEmployeeSave.RowTemplate.Height = 28;
            this.dgvEmployeeSave.Size = new System.Drawing.Size(374, 322);
            this.dgvEmployeeSave.TabIndex = 10;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(130, 409);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(304, 36);
            this.btnSaveEmployee.TabIndex = 5;
            this.btnSaveEmployee.Text = "Save Employee";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // EmployeeFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 473);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.dgvEmployeeSave);
            this.Controls.Add(this.txtPasswordEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserNameEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastNameEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstNameEmployee);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeFRM";
            this.Text = "EmployeeFRM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNameEmployee;
        private System.Windows.Forms.TextBox txtLastNameEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserNameEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEmployeeSave;
        private System.Windows.Forms.Button btnSaveEmployee;
    }
}