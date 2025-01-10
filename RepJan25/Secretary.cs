using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class Secretary : Employee
    {
        public bool Certified { get; set; }

        public Secretary(bool certified, int baseSalary, int id, string name, string mobile):base(baseSalary, id, name, mobile)
        {
            Certified = certified;
        }

        public override string ToString()
        {
            CalculateSalary();
            //CalculatePension();
            return base.ToString() + $"{(Certified ? "Is certified" : "Not certified")}\n"; // ternary
        }

        public override double CalculateSalary()
        {
            if (Certified)
            {
                return BaseSalary = _baseSalary * 3;
            }
            else
            return BaseSalary;
        }
        /*
        public override double CalculatePension()
        {
            return 0.2 * BaseSalary;
        }
        */
    }
}
