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
    public class OrderRepo : IOrder
    {
        private OrderDBContext _db;
        public OrderRepo() { _db = new OrderDBContext(); }
        public IEnumerable<Order> GetAll()
        {
            return _db.Orders.ToList(); ;
        }
    }
   
}
