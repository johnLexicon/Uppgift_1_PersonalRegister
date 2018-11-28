using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Program
    {

        public static void AddEmployee(Register register)
        {
            var employee = new Employee();
            Console.Write("Name: ");

            employee.Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(employee.Name))
            {
                employee.Name = "Nobody";
            }

            Console.Write("Salary: ");
            try
            {
                employee.Salary = float.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("No salary is given. Salary is set to 0.0");
            }
            
            register.AddEmployee(employee);
        }


        static void Main(string[] args)
        {

            Register register = new Register();
            int menu = 0;

            while(menu != 3)
            {
                Console.WriteLine("Choose a menu value between 1 and 3");
                Console.WriteLine("1. Add employee\n2. Print employees\n3. quit ");
                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("You must enter an integer!!!");
                    continue;
                }
                

                switch(menu)
                {    
                    case 1:
                        Console.WriteLine("Add Employee");
                        AddEmployee(register);
                        break;
                    case 2:
                        Console.WriteLine("-----------------Employees------------------");
                        List<Employee> list = register.GetEmployees();
                        IPrinter printer = new ConsolePrinter();
                        printer.PrintContent<Employee>(list);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Bye Bye");
                        break;
                    default:
                        Console.WriteLine("That option does not exist!!!");
                        break;
                }
                
             
            }

            Console.WriteLine("Program exit");
        }
    }
}
