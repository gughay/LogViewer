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
    public class LogRepo : ILog
    {
        private LogDBContext _db;
        public LogRepo() {
            _db = new LogDBContext();
        }
        public List<Log> GetAll()
        {
            List<Log> result = new List<Log>();
            //LOGS FROM DB
            //result = _db.Logs.OrderByDescending(l => l.Id).Take(100).ToList();
            // HARD CODED LOGS///
            result.Add(new Log
            {
                Id = 101, UserName ="User1",ClientIp="10.10.100",CreatedOn=DateTime.Now, ExceptionType="Type1",
                Logger="Logger1",Message="Message1", LogLevel="1",StackTrace="Stack Trace 1"
            });
            result.Add(new Log
            {
                Id = 102,UserName = "User2",ClientIp = "10.10.102", CreatedOn = DateTime.Now,ExceptionType = "Type2",
               Logger = "Logger2", Message = "Message2",LogLevel = "2", StackTrace="Stack Trace 2"
            });
            result.Add(new Log
            {
                Id = 103, UserName = "User3",ClientIp = "10.10.103", CreatedOn = DateTime.Now,ExceptionType = "Type3",
                Logger = "Logger3",Message = "Message3",LogLevel = "3", StackTrace = "Stack Trace 3"
            });
            result.Add(new Log
            {
                Id = 104,  UserName = "User4",ClientIp = "10.10.104",CreatedOn = DateTime.Now,ExceptionType = "Type4",
                Logger = "Logger4",Message = "Message4",LogLevel = "4",StackTrace = "Stack Trace 4" 
            });
            result.Add(new Log
            {
                Id = 105,UserName = "User5",ClientIp = "10.10.105",CreatedOn = DateTime.Now,ExceptionType = "Type5",
                Logger = "Logger5",Message = "Message5",LogLevel = "5",StackTrace = "Stack Trace 5" 
            });
            result.Add(new Log
            {
                Id = 106,UserName = "User6",ClientIp = "10.10.106",CreatedOn = DateTime.Now,
                ExceptionType = "Type6",Logger = "Logger6",Message = "Message6",LogLevel = "6",StackTrace = "Stack Trace 6" 
            });
            result.Add(new Log
            {
                Id = 107, UserName = "User7",ClientIp = "10.10.107",CreatedOn = DateTime.Now,ExceptionType = "Type7",
                Logger = "Logger7",Message = "Message7",LogLevel = "7",StackTrace = "Stack Trace 7" 
            });
            result.Add(new Log
            {
                Id = 108,   UserName = "User8",ClientIp = "10.10.108",CreatedOn = DateTime.Now,ExceptionType = "Type8",
                Logger = "Logger8",Message = "Message8",LogLevel = "8",StackTrace = "Stack Trace 8" 
            });
            result.Add(new Log
            {
                Id = 109,UserName = "User9",ClientIp = "10.10.109",CreatedOn = DateTime.Now,ExceptionType = "Type9",
                Logger = "Logger9",Message = "Message9",LogLevel = "9",StackTrace = "Stack Trace 9"
            });
            return result;
        }
        public Log Get(int id)
        {
            return new Log
            {
                Id = 100,
                UserName = "User0",
                ClientIp = "10.10.100",
                CreatedOn = DateTime.Now,
                ExceptionType = "Type0",
                Logger = "Logger0",
                Message = "Message0",
                LogLevel = "0",
                StackTrace = "Stack Trace 0"
            };
            //return _db.Logs.FirstOrDefault(l => l.Id == id);
        }
    }
}
