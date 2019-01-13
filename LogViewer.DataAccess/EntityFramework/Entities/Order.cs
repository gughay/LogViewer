using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.DataAccess.EntityFramework.Entities
{
    public class Order
    {
        public int LogId { get; set; }
        public string Message { get; set; }
    }
}
