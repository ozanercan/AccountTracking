using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class CorporateCurrentCardProfile : Profile
    {
        public CorporateCurrentCardProfile()
        {
            CreateMap<CorporateCurrentCardAddDto, CorporateCurrentCard>();
            CreateMap<CorporateCurrentCardUpdateDto, CorporateCurrentCard>();
        }
    }
}
