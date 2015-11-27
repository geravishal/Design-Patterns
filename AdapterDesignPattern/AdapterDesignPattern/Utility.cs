using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Utility
    {
        public DataTable GetAllEmployees()
        {
            DataTable employees = new DataTable();
            employees.Columns.Add("Name", System.Type.GetType("System.String"));
            employees.Columns.Add("Age", System.Type.GetType("System.Int32"));
            employees.Columns.Add("Id", System.Type.GetType("System.Int32"));
            employees.Rows.Add("Hrithik", 35, 123);
            employees.Rows.Add("Kareena", 29, 456);
            employees.Rows.Add("Aranb", 32, 789);

            return employees;
        }
    }
}
