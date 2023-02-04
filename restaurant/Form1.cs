using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace restaurant
{
    public partial class Form1 : MaterialForm 
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void AddCategoryFoodOpenForm_Click(object sender, EventArgs e)
        {
            AddFoodCategoryFRM addFoodCategoryFRM = new AddFoodCategoryFRM();
            addFoodCategoryFRM.ShowDialog();
        }

        private void AddEmployeOpenForm_Click(object sender, EventArgs e)
        {
            EmployeeFRM employeFRM = new EmployeeFRM();
            employeFRM.ShowDialog();  
        }
    }
}
