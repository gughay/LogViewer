using LogViewer.BusinessLogic.Interfaces;
using LogViewer.DataAccess.EntityFramework.Entities;
using LogViewer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
namespace LogViewer.BusinessLogic.Services
{
    public class OrderService : IOrder
    {
        private OrderRepo _orderRepo;
        public OrderService() { this._orderRepo = new OrderRepo(); }
        public IEnumerable<Order> GetAll()
        {
            return _orderRepo.GetAll();
        }
    }
}
