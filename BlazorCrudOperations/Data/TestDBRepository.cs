using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudOperations.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorCrudOperations.Data
{
    public class TestDBRepository
    {
        private TestDBContext _dbcontext;
        private Employee emp = null;
        public TestDBRepository(TestDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void CreateEmployee(Employee employee)
        {
            try
            {
                emp = employee;
                _dbcontext.Employees.Add(emp);
                _dbcontext.SaveChanges();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (emp != null)
                {
                    emp = null;
                }
            }
        }
        public void EditEmployee(Employee employee)
        {
            var d = _dbcontext.Employees.Where(e => e.EmpId==employee.EmpId).FirstOrDefault();
            d.EmpName = employee.EmpName;
            d.Age = employee.Age;
            d.EmailId = employee.EmailId;
            _dbcontext.Entry(d).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
