using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DomainModel;
using MaterialSkin;
using MaterialSkin.Controls;

namespace restaurant
{
    public partial class EmployeeFRM : MaterialForm
    {
        public EmployeeFRM()
        {
            InitializeComponent();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Employee emp  = new Employee {FirstName=txtFirstNameEmployee.Text,
            LastName = txtLastNameEmployee.Text,
            Phone = txtPhoneEmployee.Text,
            UserName = txtUserNameEmployee.Text,
            Password = txtPasswordEmployee.Text
            };
            EmployeeRepository repository = new EmployeeRepository();
            repository.AddNewEmployee(emp);

        }
    }
}
