namespace restaurant
{
    partial class AddFoodCategoryFRM
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
            this.txtCategoryFoodSave = new System.Windows.Forms.TextBox();
            this.btnCategoryFoodSave = new System.Windows.Forms.Button();
            this.dgvCategoryFoodSave = new System.Windows.Forms.DataGridView();
            this.clmFoodCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryFoodSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCategoryFoodSave
            // 
            this.txtCategoryFoodSave.Location = new System.Drawing.Point(155, 121);
            this.txtCategoryFoodSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoryFoodSave.Name = "txtCategoryFoodSave";
            this.txtCategoryFoodSave.Size = new System.Drawing.Size(234, 34);
            this.txtCategoryFoodSave.TabIndex = 1;
            this.txtCategoryFoodSave.TextChanged += new System.EventHandler(this.txtCategoryFoodSave_TextChanged);
            // 
            // btnCategoryFoodSave
            // 
            this.btnCategoryFoodSave.Location = new System.Drawing.Point(419, 117);
            this.btnCategoryFoodSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCategoryFoodSave.Name = "btnCategoryFoodSave";
            this.btnCategoryFoodSave.Size = new System.Drawing.Size(84, 32);
            this.btnCategoryFoodSave.TabIndex = 2;
            this.btnCategoryFoodSave.Text = "Save";
            this.btnCategoryFoodSave.UseVisualStyleBackColor = true;
            this.btnCategoryFoodSave.Click += new System.EventHandler(this.btnCategoryFoodSave_Click);
            // 
            // dgvCategoryFoodSave
            // 
            this.dgvCategoryFoodSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryFoodSave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFoodCategoryID,
            this.clmFoodCategoryName,
            this.clmDelete});
            this.dgvCategoryFoodSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategoryFoodSave.Location = new System.Drawing.Point(0, 186);
            this.dgvCategoryFoodSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCategoryFoodSave.Name = "dgvCategoryFoodSave";
            this.dgvCategoryFoodSave.RowHeadersWidth = 62;
            this.dgvCategoryFoodSave.RowTemplate.Height = 28;
            this.dgvCategoryFoodSave.Size = new System.Drawing.Size(534, 177);
            this.dgvCategoryFoodSave.TabIndex = 3;
            this.dgvCategoryFoodSave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryFoodSave_CellContentClick);
            // 
            // clmFoodCategoryID
            // 
            this.clmFoodCategoryID.DataPropertyName = "FoodCategoryID";
            this.clmFoodCategoryID.HeaderText = "ID";
            this.clmFoodCategoryID.MinimumWidth = 8;
            this.clmFoodCategoryID.Name = "clmFoodCategoryID";
            this.clmFoodCategoryID.Visible = false;
            this.clmFoodCategoryID.Width = 150;
            // 
            // clmFoodCategoryName
            // 
            this.clmFoodCategoryName.DataPropertyName = "CategoryName";
            this.clmFoodCategoryName.HeaderText = "Name Category";
            this.clmFoodCategoryName.MinimumWidth = 8;
            this.clmFoodCategoryName.Name = "clmFoodCategoryName";
            this.clmFoodCategoryName.Width = 150;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.MinimumWidth = 8;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Text = "❌";
            this.clmDelete.UseColumnTextForButtonValue = true;
            this.clmDelete.Width = 150;
            // 
            // AddFoodCategoryFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 363);
            this.Controls.Add(this.dgvCategoryFoodSave);
            this.Controls.Add(this.btnCategoryFoodSave);
            this.Controls.Add(this.txtCategoryFoodSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddFoodCategoryFRM";
            this.Text = "Food Categorys";
            this.Load += new System.EventHandler(this.AddFoodCategoryFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryFoodSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryFoodSave;
        private System.Windows.Forms.Button btnCategoryFoodSave;
        private System.Windows.Forms.DataGridView dgvCategoryFoodSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodCategoryName;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}