using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
namespace DataAccess
{
    public class FoodCategoryRepository
    {
        private RestaurantContext DB = new RestaurantContext();
        
        public void AddNewFoodCategory(FoodCategory F)
        {
            DB.FoodCategories.Add(F);
            DB.SaveChanges();
        }
        public void RemoveFoodCAtegory(int id)
        {
            FoodCategory f = DB.FoodCategories.FirstOrDefault(x => x.FoodCategoryID == id);
            DB.FoodCategories.Remove(f);
            DB.SaveChanges ();  
        } 
        public List<FoodCategory> GetAll()
        {
            return DB.FoodCategories.ToList();
        }
    }
}
