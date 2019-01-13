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
using BusinessLogic.DTOs;

namespace LogViewer.Web.Controllers
{
    /// <summary>
    /// The purpose of this api is to comunicate with the clients via signalr,
    /// so with the help of this api developers can see errors at real time
    /// this part not completed yet.
    /// </summary>
    public class LogController : Controller
    {
        private ILog _logService;
        public LogController(ILog logService)
        {
            this._logService = logService;
        }
        [HttpGet]
        public IEnumerable<LogDTO> GetAll()
        {
            List<LogDTO> result;
            result=_logService.GetAll();
            return result;
        }

        [HttpGet]
        [ActionName("Get")]
        public LogDTO Get(int id)
        {
            var log = _logService.Get(id);
            return log;
        }
    }
}
