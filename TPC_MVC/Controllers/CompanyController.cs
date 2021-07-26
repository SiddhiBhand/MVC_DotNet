using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPC_MVC.DAL;
using TPC_MVC.Models;
namespace TPC_MVC.Controllers
{
    public class CompanyController : Controller
    {
        CompanyRepository comRepo;
        public CompanyController(CompanyContext _dbcontext)
        {
            comRepo = new CompanyRepository(_dbcontext);
        }
        public IActionResult CompanyDetails()
        {
            var test = comRepo.GetCompanies().ToList();
            var lstCompanies = comRepo.GetCompanies().Select(e => new CompanyViewModel
            {
                Cid = e.Cid,
                Name=e.Name,
                Location=e.Location,
                Criteria=e.Criteria,
                VisitingDate=e.VisitingDate,
                Package=e.Package,
                Role=e.Role
            }).ToList();
            return View(lstCompanies);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CompanyViewModel com = new CompanyViewModel();
            return View(com);
        }

        [HttpPost]
        public IActionResult Create(CompanyViewModel com)
        {
            if (ModelState.IsValid)
            {
                Company comEntity = new Company()
                {
                    Cid = com.Cid,
                    Name = com.Name,
                    Location = com.Location,
                    Criteria = com.Criteria,
                    VisitingDate = com.VisitingDate,
                    Package = com.Package,
                    Role = com.Role
                };
                comRepo.CreateCompany(comEntity);
            }
            return RedirectToAction("CompanyDetails");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            CompanyViewModel selectedCompany = comRepo.GetCompanies().Where(i => i.Cid == id).Select(e => new CompanyViewModel
            {
                Cid = e.Cid,
                Name = e.Name,
                Location = e.Location,
                Criteria = e.Criteria,
                VisitingDate = e.VisitingDate,
                Package = e.Package,
                Role = e.Role

            }).FirstOrDefault();
            return View(selectedCompany);
        }
        [HttpPost]
        public IActionResult Edit(CompanyViewModel com)
        {
            if (ModelState.IsValid)
            {
                Company comEntity = new Company()
                {
                    Cid = com.Cid,
                    Name = com.Name,
                    Location = com.Location,
                    Criteria = com.Criteria,
                    VisitingDate = com.VisitingDate,
                    Package = com.Package,
                    Role = com.Role
                };
                comRepo.EditCompany(comEntity);
            }
            return RedirectToAction("CompanyDetails");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            CompanyViewModel selectedCompany = comRepo.GetCompanies().Where(i => i.Cid == id).Select(e => new CompanyViewModel
            {
                Cid = e.Cid,
                Name = e.Name,
                Location = e.Location,
                Criteria = e.Criteria,
                VisitingDate = e.VisitingDate,
                Package = e.Package,
                Role = e.Role
            }).FirstOrDefault();
            return View(selectedCompany);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            CompanyViewModel selectedCompany = comRepo.GetCompanies().Where(i => i.Cid == id).Select(e => new CompanyViewModel
            {
                Cid = e.Cid,
                Name = e.Name,
                Location = e.Location,
                Criteria = e.Criteria,
                VisitingDate = e.VisitingDate,
                Package = e.Package,
                Role = e.Role
            }).FirstOrDefault();
            return View(selectedCompany);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            comRepo.DeleteCompany(id);
            return RedirectToAction("CompanyDetails");
        }

        [HttpGet]
        public IActionResult Autherize()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Autherize(string username,string password)
        {
            LoginViewModel validate = comRepo.GetUsers().Where(i => i.UserName == username && i.Password == password).Select(e => new LoginViewModel {
                UserName = e.UserName,
                Password = e.Password
            }).FirstOrDefault();
            if (validate == null)
            {
                ViewBag.errormessage = "Enter Invalid Username and Password";
                return RedirectToAction("Autherize");
            }
            return RedirectToAction("CompanyDetails");
        }
    }
}
