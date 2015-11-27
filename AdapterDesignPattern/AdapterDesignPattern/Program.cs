using AdapterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDataTableAdapter employeeDataTableAdapter = new EmployeeDataTableAdapter();
            Employee employee = new Employee(employeeDataTableAdapter);
            var listOfEmployees =   employee.ListEmployees();

            foreach (var item in listOfEmployees)
            {
                Console.WriteLine("Name: {0} Age: {1} Id: {2}", item.Name,item.Age,item.Id);
                
            }
        }
    }
}
