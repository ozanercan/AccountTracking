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

            CreateMap<CorporateCurrentCardAddDto, CorporateCurrentCard>();
            CreateMap<CorporateCurrentCardUpdateDto, CorporateCurrentCard>();

            CreateMap<IndividualCurrentCardAddDto, IndividualCurrentCard>();
            CreateMap<IndividualCurrentCardUpdateDto, IndividualCurrentCard>();

            CreateMap<LocalIndividualCurrentCardAddDto, LocalIndividualCurrentCard>();
            CreateMap<LocalIndividualCurrentCardUpdateDto, LocalIndividualCurrentCard>();

            CreateMap<ForeignIndividualCurrentCardAddDto, ForeignIndividualCurrentCard>();
            CreateMap<ForeignIndividualCurrentCardUpdateDto, ForeignIndividualCurrentCard>();            
        }
    }
}