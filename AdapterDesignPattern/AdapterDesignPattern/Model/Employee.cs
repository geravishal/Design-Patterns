using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }


        IEmployeeDataTableAdapter _employeeDataTableAdapter;

        public Employee(IEmployeeDataTableAdapter employeeDataTableAdapter)
        {
            _employeeDataTableAdapter = employeeDataTableAdapter;
        }

        public Employee() { }


        //Get the List of Employees working for me
        public List<Employee> ListEmployees()
        {
            List<Employee> listOfEmployees = _employeeDataTableAdapter.ListEmployees();
            return listOfEmployees;
        }

    }

}
