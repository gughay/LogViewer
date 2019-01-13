using AutoMapper;
using BusinessLogic.DTOs;
using LogViewer.BusinessLogic.Interfaces;
using LogViewer.DataAccess.EntityFramework.Entities;
using LogViewer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using LogViewer.BusinessLogic;
namespace LogViewer.BusinessLogic.Services
{
    public class LogService : ILog
    {
        private LogRepo _logRepo;
        private IMapper _mapper;

        public LogService() {
                this._logRepo = new LogRepo();
                this._mapper = AutoMapperConfig.MapperInstance;
        }
        public List<LogDTO> GetAll()
        {
            List<LogDTO> results = new List<LogDTO>();
            var logs= _logRepo.GetAll();
            foreach (var log in logs)
            {
                results.Add(_mapper.Map<Log, LogDTO>(log));
            }
            return results;
        }

        public LogDTO Get(int id)
        {
            var log = _logRepo.Get(id);
            return _mapper.Map<Log, LogDTO>(log);
        }
    }
}
