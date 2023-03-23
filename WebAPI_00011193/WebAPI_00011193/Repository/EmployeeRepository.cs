using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_00011193.DAL;
using WebAPI_00011193.Models;

namespace WebAPI_00011193.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _dbContext;

        public EmployeeRepository(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertEmployee(Employee employee)
        {
            employee.EmployeeDepartment = _dbContext.Departments.Find(employee.EmployeeDepartment.ID);
            _dbContext.Add(employee);
            Save();
        }

        public void UpdateEmployee(Employee employee)
        {
            employee.EmployeeDepartment = _dbContext.Departments.Find(employee.EmployeeDepartment.ID);
            _dbContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            _dbContext.Employees.Remove(employee);
            Save();
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = _dbContext.Employees.Include(d => d.EmployeeDepartment).ToList();
            //foreach(Employee employee in employees)
            //{
            //    Console.WriteLine(employee.EmployeeDepartment.ID + employee.EmployeeDepartment.Name);
            //}
            //employees.ForEach(x => x.EmployeeDepartment = _dbContext.Departments.Find(x.EmployeeDepartment.ID));
            return employees;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
