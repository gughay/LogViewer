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
        public int Id { get; set; }
        public string DocId { get; set; }
    }
}
