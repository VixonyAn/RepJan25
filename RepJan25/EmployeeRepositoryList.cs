using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class EmployeeRepositoryList : IEmployeeRepositoryList
    {
        #region Instance Fields
        private List<Employee> _employees; //underscore denotes an instance field
        #endregion

        #region Properties
        public int Count { get { return _employees.Count; } }
        #endregion

        #region Constructors
        public EmployeeRepositoryList()
        {
            _employees = new List<Employee>();
        }
        #endregion

        #region Methods
        public void AddEmployee(Employee emp)
        {
            if (GetEmployee(emp.ID) == null)
                _employees.Add(emp);
        }

        public void RemoveEmployee(int id)
        {
            _employees.Remove(GetEmployee(id));
        }

        public Employee? GetEmployee(int id) // the ? means it can return null
        {
            foreach(Employee emp in _employees)
            {
                if (emp.ID == id)
                { return emp; }
            }
            return null;
        }

        public List<Employee> GetAllEmployee()
        {
            return _employees;
        }

        public void UpdateEmployee(int oldId, Employee newEmployee)
        {
            /*
            //option 1
            Employee oldEmployee = GetEmployee(oldId);
            oldEmployee.Name = newEmployee.Name;
            oldEmployee.BaseSalary = newEmployee.BaseSalary;
            oldEmployee.Mobile = newEmployee.Mobile;
            */

            //option 2
            GetEmployee(oldId).Name = newEmployee.Name;
            GetEmployee(oldId).BaseSalary = newEmployee.BaseSalary;
            GetEmployee(oldId).Mobile = newEmployee.Mobile;
        }

        public double CalculateTotalSalarySum()
        {
            double SalarySum = 0;
            for (int i = 0; i < _employees.Count; i++)
            {
                SalarySum = _employees[1].CalculateSalary();
            }
            /*
            foreach (Employee emp in _employees)
            {
                SalarySum += emp.CalculateSalary();
            }
            */
            return SalarySum;
        }
        #endregion
    }
}
