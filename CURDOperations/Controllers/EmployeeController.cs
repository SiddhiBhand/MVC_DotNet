using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURDOperations.DAL;
using CURDOperations.Models;

namespace CURDOperations.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository empRepo;
        public EmployeeController(EmployeeContext _dbcontext)
        {
            empRepo = new EmployeeRepository(_dbcontext);
        }
        public IActionResult EmpDetails()
        {
            var test = empRepo.GetEmployees().ToList();
            var lstEmployees = empRepo.GetEmployees().Select(e => new EmployeeViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).ToList();
            return View(lstEmployees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            EmployeeViewModel emp = new EmployeeViewModel();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel emp)
        {
            if (ModelState.IsValid)
            {
                Employee empEntity = new Employee()
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    Age = emp.Age,
                    EmailId = emp.EmailId
                };
                empRepo.CreateEmployee(empEntity);
            }
            return RedirectToAction("EmpDetails");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            EmployeeViewModel selectEmployee = empRepo.GetEmployees().Where(i => i.EmpId == id).Select(e => new EmployeeViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).FirstOrDefault();
            return View(selectEmployee);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeViewModel emp)
        {
            if (ModelState.IsValid)
            {
                Employee empEntity = new Employee()
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    Age = emp.Age,
                    EmailId = emp.EmailId
                };
                empRepo.EditEmployee(empEntity);
            }
            return RedirectToAction("EmpDetails");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            EmployeeViewModel selectEmployee = empRepo.GetEmployees().Where(i => i.EmpId == id).Select(e => new EmployeeViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).FirstOrDefault();
            return View(selectEmployee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            EmployeeViewModel selectEmployee = empRepo.GetEmployees().Where(i => i.EmpId == id).Select(e => new EmployeeViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).FirstOrDefault();
            return View(selectEmployee);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            empRepo.DeleteEmployee(id);
            return RedirectToAction("EmpDetails");
        }

    }
}
