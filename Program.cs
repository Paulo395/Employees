using System;
using EmployeePolimorf.Entities;

namespace EmployeePolimorf // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            byte numEmployees = Byte.Parse(Console.ReadLine());

            for(int i = 1; i <= numEmployees; i++)
            {
                Console.Write("Employee #" + i + " data:\nOutsorced (Y/N) ? ");
                string outsourced = Console.ReadLine().ToLower();

                employees.Add(Register(outsourced));

            }

            Console.WriteLine("\nPAYMENTS:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2"));
            }
        }
        public static Employee Register(string outsorced)
        {
            Employee employee;

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Value per hour: ");
            double valueperhour = double.Parse(Console.ReadLine());

            if (outsorced == "y")
            {
                Console.Write("Additional charge: ");
                double adCharge = double.Parse(Console.ReadLine());

                employee = new OutsourcedEmployee(name, hours, valueperhour, adCharge);
            }
            else
            {
                employee = new Employee(name, hours, valueperhour);
            }

            return employee;
        }
    }
}