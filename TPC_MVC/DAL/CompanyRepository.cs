using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPC_MVC.Models;

namespace TPC_MVC.DAL
{
    public class CompanyRepository
    {
        private CompanyContext _dbcontext;
        public CompanyRepository(CompanyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void CreateCompany(Company company)
        {
            try
            {
                _dbcontext.Companies.Add(company);
                _dbcontext.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                
            }
        }

        public void EditCompany(Company company)
        {
            try
            {
                _dbcontext.Companies.Update(company);
                _dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
        }

        public void DeleteCompany(int Cid)
        {
            try
            {
                var selectedCompany = _dbcontext.Companies.Where(i => i.Cid == Cid).FirstOrDefault();
                if (selectedCompany != null)
                {
                    _dbcontext.Companies.Remove(selectedCompany);
                    _dbcontext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
        }
        //User
        public void ValidateUser(Login login)
        {
            try
            {
                var validate = (from user in _dbcontext.Users
                                  where user.UserName == login.UserName && user.Password == login.Password
                                  select user).FirstOrDefault();
                if (validate == null)
                {
                    Console.WriteLine("Enter Valid Password");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
        }
        public List<Company> GetCompanies()
        {
            return _dbcontext.Companies.ToList();
        }
        public List<Login> GetUsers()
        {
            return _dbcontext.Users.ToList();
        }
    }
}
