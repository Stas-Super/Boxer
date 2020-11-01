using AutoMapper;
using Boxer.BLL.DTO;
using Boxer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boxer.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Battle, BattleDTO>();
            CreateMap<BattleDTO, Battle>();
        }
    }
}