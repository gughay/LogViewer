using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using LogViewer.Web.Hubs;
using LogViewer.BusinessLogic.Interfaces;
using LogViewer.DataAccess.EntityFramework.Entities;

namespace LogViewer.Web.Controllers
{
    /// <summary>
    /// The purpose of this api is to comunicate with the clients via signalr,
    /// so with the help of this api developers can see errors at real time
    /// this part not completed yet.
    /// </summary>
    [Route("api/[controller]")]
    public class LogController : Controller
    {
        private ILog _logService;
        public LogController(ILog logService)
        {
            this._logService = logService;
        }
        [HttpGet("[action]")]
        public IEnumerable<Log> Getlogs()
        {
            var hardCodedLogs = new List<Log>();
            hardCodedLogs.Add(new Log
            {
                LogId = 100,
                Message = "Error Message 1",
                InnerException = "InnerException 1",
                StackTrace = "StackTrace 1"
            });
            hardCodedLogs.Add(new Log
            {
                LogId = 102,
                Message = "Error Message 2",
                InnerException = "InnerException 2",
                StackTrace = "StackTrace 2"
            });
            hardCodedLogs.Add(new Log
            {
                LogId = 103,
                Message = "Error Message 3",
                InnerException = "InnerException 3",
                StackTrace = "StackTrace 3"
            });
            hardCodedLogs.Add(new Log
            {
                LogId = 104,
                Message = "Error Message 4",
                InnerException = "InnerException 4",
                StackTrace = "StackTrace 4"
            });

            hardCodedLogs.Add(new Log
            {
                LogId = 105,
                Message = "Error Message 5",
                InnerException = "InnerException 5",
                StackTrace = "StackTrace 5"
            });

            hardCodedLogs.Add(new Log
            {
                LogId = 106,
                Message = "Error Message 6",
                InnerException = "InnerException 6",
                StackTrace = "StackTrace 6"
            });


            hardCodedLogs.Add(new Log
            {
                LogId = 107,
                Message = "Error Message 7",
                InnerException = "InnerException 7",
                StackTrace = "StackTrace 7"
            });
            //return  this._logService.GetAll();
            return hardCodedLogs;
        }
    }
}
