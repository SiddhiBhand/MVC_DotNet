using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudOperations.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudOperations.Data
{
    public class TestDBContext:DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public static implicit operator TestDBContext(TestDBRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
