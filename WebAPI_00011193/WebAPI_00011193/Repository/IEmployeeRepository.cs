using System.Collections.Generic;
using WebAPI_00011193.Models;

namespace WebAPI_00011193.Repository
{
    public interface IEmployeeRepository
    {
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetEmployees();
    }
}
