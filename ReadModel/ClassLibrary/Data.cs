using Microsoft.EntityFrameworkCore;
using Models;
using System.Diagnostics.Metrics;

namespace ClassLibrary.Data
{
    public class Context : DbContext
    {
        public DbSet<employee> employees { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
