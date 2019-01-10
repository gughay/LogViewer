using LogViewer.DataAccess.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.BusinessLogic.Interfaces
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();
    }
}
