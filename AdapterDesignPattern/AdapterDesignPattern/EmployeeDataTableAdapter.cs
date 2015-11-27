using AdapterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class EmployeeDataTableAdapter : IEmployeeDataTableAdapter
    {
        Utility dataTableEmployees = new Utility();

        public List<Employee> ListEmployees()
        {
            DataTable employees = dataTableEmployees.GetAllEmployees();

            List<Employee> listOfEmployees = employees.AsEnumerable().Select(row => new Employee
            {
                Name = row.Field<string>("Name"),
                Age = row.Field<int>("Age"),
                Id = row.Field<int>("Id")
            }).ToList();

            return listOfEmployees;
        }
    }
}
