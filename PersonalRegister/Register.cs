using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Register
    {

        private List<Employee> _employees = new List<Employee>();

        internal void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        internal List<Employee> GetEmployees()
        {
            //Shallow copy
            return new List<Employee>(_employees);
        }
    }
}
