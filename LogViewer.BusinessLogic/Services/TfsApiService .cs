using LogViewer.BusinessLogic.Interfaces;
using LogViewer.DataAccess.EntityFramework.Entities;
using LogViewer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
namespace LogViewer.BusinessLogic.Services
{
    public class TfsApiService : ITfsApi
    {
        private TfsApiRepo _tfsApiRepo;
        public TfsApiService() { this._tfsApiRepo = new TfsApiRepo(); }

        public string GetFileContent(string path)
        {
            return _tfsApiRepo.GetFileContent(path);
        }
    }
}
