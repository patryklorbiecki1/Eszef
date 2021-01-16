using AutoMapper;
using Eszef.API.DTO;
using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            =>  new MapperConfiguration(cfg =>
                {
                cfg.CreateMap<Item, ItemDTO>();
                cfg.CreateMap<Soldier, SoldierDTO>();
                }).CreateMapper();
    }
}
