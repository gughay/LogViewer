using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LogViewer.BusinessLogic.Interfaces;

namespace LogViewer.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrder _orderService;
        public OrderController(IOrder orderService)
        {
            this._orderService = orderService;

        }
        [HttpGet]
        public string GetOrders()
        {
            this._orderService.GetAll();
            return "Orders";
        }
    }
}
