using LogViewer.DataAccess.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
namespace LogViewer.DataAccess.EntityFramework.DBContexts
{
   public  class LogDBContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public LogDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }




    }
}
