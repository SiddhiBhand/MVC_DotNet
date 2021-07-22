using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CURDOperations.Models;

namespace CURDOperations.DAL
{
    public class EmployeeRepository
    {
        private EmployeeContext _dbcontext;
        public EmployeeRepository(EmployeeContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void CreateEmployee(Employee employee)
        {
            _dbcontext.Employees.Add(employee);
            _dbcontext.SaveChanges();
        }
        public void EditEmployee(Employee employee)
        {
            _dbcontext.Employees.Update(employee);
            _dbcontext.SaveChanges();
        }
        public void DeleteEmployee(int EmpId)
        {
            var selectedEmployee = _dbcontext.Employees.Where(i => i.EmpId == EmpId).FirstOrDefault();
            if (selectedEmployee != null)
            {
                _dbcontext.Employees.Remove(selectedEmployee);
                _dbcontext.SaveChanges();
            }
        }
        public List<Employee> GetEmployees()
        {
            return _dbcontext.Employees.ToList();
        }
    }
}
