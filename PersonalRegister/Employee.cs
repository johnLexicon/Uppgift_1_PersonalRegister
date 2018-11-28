using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Employee
    {

        public string Name { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Salary: " + Salary;
        }

    }
}
