using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public interface IEmployeeRepositoryDictionary
    {
        int Count { get; }
        void AddEmployee(Employee emp);
        void RemoveEmployee(int id);
        Employee? GetEmployee(int id);
        List<Employee> GetAllEmployee();
        void UpdateEmployee(Employee newEmployee);
        double CalculateTotalSalarySum();
    }
}
