using System.Collections.Generic;
using WebAPI_00011193.Models;

namespace WebAPI_00011193.Repository
{
    public interface IDepartmentRepository
    {
        void InsertDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
        Department GetDepartmentById(int id);
        IEnumerable<Department> GetDepartments();
    }
}
