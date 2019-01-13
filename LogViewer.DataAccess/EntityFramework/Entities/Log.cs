using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.DataAccess.EntityFramework.Entities
{
    [Table("Tbl_ACBASoftwareLog")]
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [Column("Logger")]
        public string Logger { get; set; }
        [Column("LogLevel")]
        public string LogLevel { get; set; }
        [Column("ExceptionType")]
        public string ExceptionType { get; set; }
        [Column("Message")]
        public string Message { get; set; }
        [Column("StackTrace")]
        public string StackTrace { get; set; }
        [Column("ClientIp")]
        public string ClientIp { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
    }
}
