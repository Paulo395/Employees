using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolimorf.Entities
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHours { get; private set;}

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHours;
        }
    }
}
