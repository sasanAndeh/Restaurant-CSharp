namespace restaurant
{
    partial class Form1
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
            this.AddCategoryFoodOpenForm = new System.Windows.Forms.Button();
            this.AddEmployeOpenForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCategoryFoodOpenForm
            // 
            this.AddCategoryFoodOpenForm.Location = new System.Drawing.Point(55, 106);
            this.AddCategoryFoodOpenForm.Name = "AddCategoryFoodOpenForm";
            this.AddCategoryFoodOpenForm.Size = new System.Drawing.Size(390, 41);
            this.AddCategoryFoodOpenForm.TabIndex = 0;
            this.AddCategoryFoodOpenForm.Text = "Add New Category Food";
            this.AddCategoryFoodOpenForm.UseVisualStyleBackColor = true;
            this.AddCategoryFoodOpenForm.Click += new System.EventHandler(this.AddCategoryFoodOpenForm_Click);
            // 
            // AddEmployeOpenForm
            // 
            this.AddEmployeOpenForm.Location = new System.Drawing.Point(55, 153);
            this.AddEmployeOpenForm.Name = "AddEmployeOpenForm";
            this.AddEmployeOpenForm.Size = new System.Drawing.Size(390, 41);
            this.AddEmployeOpenForm.TabIndex = 1;
            this.AddEmployeOpenForm.Text = "Add New Employee";
            this.AddEmployeOpenForm.UseVisualStyleBackColor = true;
            this.AddEmployeOpenForm.Click += new System.EventHandler(this.AddEmployeOpenForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(390, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 563);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddEmployeOpenForm);
            this.Controls.Add(this.AddCategoryFoodOpenForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCategoryFoodOpenForm;
        private System.Windows.Forms.Button AddEmployeOpenForm;
        private System.Windows.Forms.Button button3;
    }
}

