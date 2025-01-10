using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class Teacher : Employee
    {
		private string _subject; // instance fields opbevarer data så længe objektet eksisterer
        // auto property skaber en skjult instance field
		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}

        public Teacher(string subject, int baseSalary, int id, string name, string mobile):base(baseSalary, id, name, mobile)
        // base arver fra Employee's constructor, den sender informationer op
        {
            _subject = subject;
        }

        public override string ToString()
        {
            CalculateSalary();
            //CalculatePension();
            return base.ToString() + $"Subjekt: {_subject}\n"; // base arver fra Employee's ToString
        }

        public override double CalculateSalary()
        {
            if (_subject == "Teknologi")
            {
                return BaseSalary = _baseSalary * 2;
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
