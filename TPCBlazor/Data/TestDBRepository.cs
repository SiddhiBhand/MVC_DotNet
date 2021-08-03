using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPCBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace TPCBlazor.Data
{
    public class TestDBRepository
    {
        private TestDBContext _dbcontext;
        private Company comObj = null;
        public TestDBRepository(TestDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void CreateCompany(Company company)
        {
            try
            {
                comObj = company;
                _dbcontext.Companies.Add(comObj);
                _dbcontext.SaveChanges();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (comObj != null)
                {
                    comObj = null;
                }
            }
        }
        public void EditCompany(Company company)
        {
            var d = _dbcontext.Companies.Where(e => e.Cid == company.Cid).FirstOrDefault();
            d.Name = company.Name;
            d.Location = company.Location;
            d.Criteria = company.Criteria;
            d.VisitingDate = company.VisitingDate;
            d.Package = company.Package;
            d.Role = company.Role;
            _dbcontext.Entry(d).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbcontext.SaveChanges();
        }
        public void DeleteCompany(int Cid)
        {
            var selectedCompany = _dbcontext.Companies.Where(i => i.Cid == Cid).FirstOrDefault();
            if (selectedCompany != null)
            {
                _dbcontext.Companies.Remove(selectedCompany);
                _dbcontext.SaveChanges();
            }
        }
        public List<Company> GetEmployees()
        {
            return _dbcontext.Companies.ToList();
        }
    }
}
