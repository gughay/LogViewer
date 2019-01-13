using AutoMapper;
using BusinessLogic.DTOs;
using LogViewer.DataAccess.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogViewer.BusinessLogic
{
    /// <summary>
    /// Thread safe singletone for mapper
    /// </summary>
    public sealed class AutoMapperConfig
    {
        private static IMapper _mapperInstance = null;
        private static readonly object padlock = new object();
        AutoMapperConfig()
        {

        }
        public static IMapper MapperInstance
        {
            get
            {
                lock (padlock)
                {
                    if (_mapperInstance == null)
                    {
                        MapperConfiguration config = SetMaps();
                        _mapperInstance = config.CreateMapper();
                    }
                    return _mapperInstance;
                }
            }
        }

        /// <summary>
        /// All maps between objects
        /// </summary>
        /// <returns></returns>
        private static MapperConfiguration SetMaps()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Log, LogDTO>();
                cfg.CreateMap<LogDTO, Log>();
            });
            return config;
        }
    }
}
