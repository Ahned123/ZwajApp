
using Microsoft.EntityFrameworkCore;
using zwajAPP.API.Models;

namespace zwajAPP.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set;}
    }
}