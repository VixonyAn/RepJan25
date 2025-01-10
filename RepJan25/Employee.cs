using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{   // abstract betyder at klassen indeholder noget der ikke er implementeret
    // abstract gør også at man ikke kan lave objekter af klassen fordi den ikke er færdig
    //abstract class Employee // arver fra Object "Employee : Object"
    public class Employee // arver fra Object "Employee : Object"
    {
        #region Instance Fields
        protected int _baseSalary;
        private int _id;
        private string _name;
        #endregion

        #region Properties
        public int BaseSalary
		{
			get { return _baseSalary; }
			set {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("BaseSalary outside allowed range");
                }
                _baseSalary = value; }
		}
		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
        public string Mobile { get; set; }
        #endregion

        #region Constructor
        public Employee(int baseSalary, int id, string name, string mobile)
        {
            if (baseSalary < 0 || baseSalary > 10000)
            {
                throw new ArgumentException("BaseSalary outside allowed range");
            }
            _baseSalary = baseSalary;
            _id = id;
            _name = name;
            Mobile = mobile;
        }
        #endregion

        #region Methods
        //public abstract double CalculatePension();
        // alt der arver fra Employee skal implementere CalculatePension

        public virtual double CalculateSalary()
        {
            return _baseSalary;
        }

        // for at kunne overskrive ToString() fra Object klassen skal den defineres på en særling måde
        // "virtual ToString()" virtual
        public override string ToString() // override method from Object Class (Employee)
        {
            return $"ID #{_id}  Name: {_name}\n" +
                   $"Tlf: {Mobile}\n" +
                   $"Salary: {_baseSalary} dkk\n";
        }    
        #endregion
    }
}
