using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Register
    {

        private List<Employee> employees = new List<Employee>();

        internal void PrintEmployees()
        {
            foreach(var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        internal void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
