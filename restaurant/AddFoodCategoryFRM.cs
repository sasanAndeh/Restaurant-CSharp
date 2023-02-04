using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DomainModel;
using MaterialSkin;
using MaterialSkin.Controls;
namespace restaurant
{
    public partial class AddFoodCategoryFRM : MaterialForm
    {
        public AddFoodCategoryFRM() 
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            dgvCategoryFoodSave.DataSource = null;
            FoodCategoryRepository repo = new FoodCategoryRepository();
            dgvCategoryFoodSave.AutoGenerateColumns = false;
            dgvCategoryFoodSave.DataSource = repo.GetAll();
        }

        private void btnCategoryFoodSave_Click(object sender, EventArgs e)
        {
            FoodCategory foodCategory = new FoodCategory();
            foodCategory.CategoryName = txtCategoryFoodSave.Text;
            FoodCategoryRepository foodCategoryRepository = new FoodCategoryRepository();   
            foodCategoryRepository.AddNewFoodCategory(foodCategory);
            BindGrid();

        }

        private void dgvCategoryFoodSave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if(MessageBox.Show("Are you shue?","Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = Convert.ToInt32(dgvCategoryFoodSave.Rows[e.RowIndex].Cells[0].Value);
                    DataAccess.FoodCategoryRepository repo = new FoodCategoryRepository();
                    repo.RemoveFoodCAtegory(id);
                    BindGrid();
                }
            }
        }

        private void txtCategoryFoodSave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddFoodCategoryFRM_Load(object sender, EventArgs e)
        {
            BindGrid(); 
        }
    }
}
