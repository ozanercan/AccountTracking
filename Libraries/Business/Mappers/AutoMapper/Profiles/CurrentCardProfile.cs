using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class CurrentCardProfile : Profile
    {
        public CurrentCardProfile()
        {
            CreateMap<CurrentCardAddDto, CurrentCard>();
            CreateMap<CurrentCardUpdateDto, CurrentCard>();
        }
    }
}
