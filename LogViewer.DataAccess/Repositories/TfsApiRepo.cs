using LogViewer.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogViewer.DataAccess.EntityFramework.Entities;
using LogViewer.DataAccess.EntityFramework.DBContexts;
using LogViewer.DataAccess.FileSystem;

namespace LogViewer.DataAccess.Repositories
{
    public class TfsApiRepo : ITfsApi
    {
        private TfsApi _tfsApi;
        public TfsApiRepo()
        {
            _tfsApi = new TfsApi();
        }
        public string GetFileContent(string path)
        {
            return _tfsApi.GetFileContent(path);
        }
    }
}
