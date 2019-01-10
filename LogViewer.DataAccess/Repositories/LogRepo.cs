using LogViewer.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogViewer.DataAccess.EntityFramework.Entities;
using LogViewer.DataAccess.EntityFramework.DBContexts;

namespace LogViewer.DataAccess.Repositories
{
    public class LogRepo : ILog
    {
        private LogDBContext _db;
        public LogRepo() { _db = new LogDBContext(); _db.Database.EnsureCreated(); }
        public IEnumerable<Log> GetAll()
        {
            return _db.Logs.ToList(); ;
        }
    }
}
