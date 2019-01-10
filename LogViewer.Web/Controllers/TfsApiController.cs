using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using LogViewer.Web.Models;
using LogViewer.Web.Models.ManageViewModels;
using LogViewer.Web.Services;
using LogViewer.BusinessLogic.Interfaces;

namespace LogViewer.Web.Controllers
{
    public class TfsApiController : Controller
    {
        private ITfsApi _tfsApiService;
        public TfsApiController(ITfsApi tfsApiService)
        {
            this._tfsApiService = tfsApiService;

        }
        [HttpGet]
        public string GetFileContent(string path)
        {
            this._tfsApiService.GetFileContent(path);
            return "File Content";
        }
    }
}
