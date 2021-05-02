using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class IndividualCurrentCardProfile : Profile
    {
        public IndividualCurrentCardProfile()
        {
            CreateMap<IndividualCurrentCardAddDto, IndividualCurrentCard>();
            CreateMap<IndividualCurrentCardUpdateDto, IndividualCurrentCard>();

            CreateMap<LocalIndividualCurrentCardAddDto, LocalIndividualCurrentCard>();
            CreateMap<LocalIndividualCurrentCardUpdateDto, LocalIndividualCurrentCard>();

            CreateMap<ForeignIndividualCurrentCardAddDto, ForeignIndividualCurrentCard>();
            CreateMap<ForeignIndividualCurrentCardUpdateDto, ForeignIndividualCurrentCard>();
        }
    }
}
