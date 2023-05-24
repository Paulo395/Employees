using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeePolimorf.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name,hours,valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double newPayment = base.Payment() + ((110.0/100.0) * AdditionalCharge);
            return newPayment;

        }
    }
}
