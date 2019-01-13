using LogViewer.DataAccess.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;

namespace LogViewer.BusinessLogic.Interfaces
{
    public interface ILog
    {
        List<LogDTO> GetAll();

        LogDTO Get(int id);
    }
}
