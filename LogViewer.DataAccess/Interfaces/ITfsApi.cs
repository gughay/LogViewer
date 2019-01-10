using LogViewer.DataAccess.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.DataAccess.Interfaces
{
    public interface ITfsApi
    {
        string  GetFileContent(string path);
    }
}
