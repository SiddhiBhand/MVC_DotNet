using System.Threading.Tasks;
using TPCBlazor.Models;
using Microsoft.EntityFrameworkCore;


namespace TPCBlazor.Data
{
    public class TestDBContext: DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}
