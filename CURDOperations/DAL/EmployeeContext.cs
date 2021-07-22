using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CURDOperations.Models;

namespace CURDOperations.DAL
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CURDOperations.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
    }
}
