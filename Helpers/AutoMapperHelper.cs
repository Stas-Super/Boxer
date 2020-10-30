using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boxer.Helpers
{
    public class AutoMapperHelper
    {
        public IMapper Mapper { get; }
        private static AutoMapperHelper instance;
        public static AutoMapperHelper Instance { get => instance ?? (instance = new AutoMapperHelper()); }
        private AutoMapperHelper()
        {
            var mapConfig = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile()));
            Mapper = mapConfig.CreateMapper();
        }
    }
}