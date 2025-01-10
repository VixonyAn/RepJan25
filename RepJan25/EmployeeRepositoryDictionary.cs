using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class EmployeeRepositoryDictionary : IEmployeeRepositoryDictionary
    {
        #region Instance Fields
        private Dictionary<int, Employee> _employees; //underscore denotes an instance field
        #endregion

        #region Properties
        public int Count { get { return _employees.Count; } }
        #endregion

        #region Constructors
        public EmployeeRepositoryDictionary()
        {
            _employees = new Dictionary<int, Employee>();
        }
        #endregion

        #region Methods
        public void AddEmployee(Employee emp)
        {
            if (!_employees.ContainsKey(emp.ID))
            {
                _employees.Add(emp.ID, emp);
            }
        }
        public void RemoveEmployee(int id)
        {
            _employees.Remove(id);
        }
        public Employee? GetEmployee(int id)
        {
            if (_employees.ContainsKey(id))
            { // if Dict contains the id, it is found
                return _employees[id];
            }
            return null; // else return nothing
        }
        public List<Employee> GetAllEmployee()
        {
            return _employees.Values.ToList();
        }
        /* overkill
        public void UpdateEmployee(int oldId, int newId, Employee newEmployee)
        {
            Employee oldEmp = _employees[oldId]; // temp Ref to Employee, gets oldEmp info
            _employees.Remove(oldId); // severs Ref to the Employee (oldId) in the Dict
            _employees[newId] = oldEmp; // oldEmp info placed in new spot using newId as key
            oldEmp.ID = newId; // overwrites oldId with newId in object (not key)
            oldEmp.Name = newEmployee.Name; // overwrites old Name with new Name
            oldEmp.BaseSalary = newEmployee.BaseSalary; // overwrites old BaseSalary with new BaseSalary
            oldEmp.Mobile = newEmployee.Mobile; // overwrites old Mobile with new Mobile
        }
        */

        public void UpdateEmployee(Employee newEmployee)
        {
            _employees[newEmployee.ID].Name = newEmployee.Name; // overwrites old Name with new Name
            _employees[newEmployee.ID].BaseSalary = newEmployee.BaseSalary; // overwrites old BaseSalary with new BaseSalary
            _employees[newEmployee.ID].Mobile = newEmployee.Mobile; // overwrites old Mobile with new Mobile
        }
        /*
        public void UpdateEmployee(Teacher newTeacher)
        {
            _employees[newTeacher.ID].Name = newTeacher.Name; // overwrites old Name with new Name
            _employees[newTeacher.ID].BaseSalary = newTeacher.BaseSalary; // overwrites old BaseSalary with new BaseSalary
            _employees[newTeacher.ID].Mobile = newTeacher.Mobile; // overwrites old Mobile with new Mobile
            _employees[newTeacher.ID].Subject = newTeacher.Subject;
        }
        */
        public double CalculateTotalSalarySum()
        {
            double SalarySum = 0;
            while ()

            for (int i = 0; i < _employees.Count; i++)
            {
                SalarySum = _employees[i].CalculateSalary();
            }
            /*
            foreach (Employee emp in _employees.Values)
            {
                SalarySum += emp.CalculateSalary();
            }
            */
            return SalarySum;
        }
        #endregion
    }
}
