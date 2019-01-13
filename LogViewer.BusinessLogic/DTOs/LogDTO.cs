using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.DTOs
{
    public class LogDTO
    {
        public long Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Logger { get; set; }
        public string LogLevel { get; set; }
        public string ExceptionType { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string ClientIp { get; set; }
        public string UserName { get; set; }
    }
}
