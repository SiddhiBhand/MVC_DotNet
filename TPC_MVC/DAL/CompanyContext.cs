using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPC_MVC.Models;
namespace TPC_MVC.DAL
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Login> Users { get; set; }
        public DbSet<TPC_MVC.Models.CompanyViewModel> CompanyViewModel { get; set; }
        public DbSet<TPC_MVC.Models.LoginViewModel> LoginViewModel { get; set; }
    }
}
