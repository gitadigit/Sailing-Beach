using AutoMapper;
using Sailing.Core.DTOs;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SailingTime, SailingTimeDto>().ReverseMap();

            CreateMap<BoatDriver, BoatDriverDto>().ReverseMap();

            CreateMap<Boat, BoatDto>().ReverseMap();

        }

    }
}
