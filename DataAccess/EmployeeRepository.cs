using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
namespace DataAccess
{
    public class EmployeeRepository
    {
        private RestaurantContext DB = new RestaurantContext();
        public void AddNewEmployee(Employee emp)
        {
            DB.Employees.Add(emp);
            DB.SaveChanges();
        }
       public void RemoveEmployee (int id)
        {
            Employee emp = DB.Employees.FirstOrDefault(x => x.EmployeeID == id);
            DB.Employees.Remove(emp);
            DB.SaveChanges();

        }
        public List<Employee> GetAll()
        {
            return DB.Employees.ToList();
        }
    }
} 
