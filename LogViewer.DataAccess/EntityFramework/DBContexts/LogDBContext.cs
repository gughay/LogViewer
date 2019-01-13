using LogViewer.DataAccess.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace LogViewer.DataAccess.EntityFramework.DBContexts
{
    public class LogDBContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public LogDBContext()
        {
            //Database.EnsureCreated();
        }        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           // options.UseSqlServer(@"Server=DSL1001;Database=AppLog;Integrated Security=true;connection timeout=100;MultipleActiveResultSets=true;");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    
        //}
    }
}
