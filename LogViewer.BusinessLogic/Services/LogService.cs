using LogViewer.BusinessLogic.Interfaces;
using LogViewer.DataAccess.EntityFramework.Entities;
using LogViewer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
namespace LogViewer.BusinessLogic.Services
{
    public class LogService : ILog
    {
        private LogRepo _logRepo;
        public LogService() { this._logRepo = new LogRepo(); }
        public IEnumerable<Log> GetAll()
        {
            return _logRepo.GetAll();
        }
    }
}
