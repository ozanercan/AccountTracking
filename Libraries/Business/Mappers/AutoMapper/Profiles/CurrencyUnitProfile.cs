using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class CurrencyUnitProfile : Profile
    {
        public CurrencyUnitProfile()
        {
            CreateMap<CurrencyUnitAddDto, CurrencyUnit>();
            CreateMap<CurrencyUnitUpdateDto, CurrencyUnit>();
        }
    }
}
