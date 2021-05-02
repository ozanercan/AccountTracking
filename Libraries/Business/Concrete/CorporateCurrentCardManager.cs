using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Validators;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CorporateCurrentCardManager : ICorporateCurrentCardService
    {
        ICorporateCurrentCardDal _corporateCurrentCardDal;
        IMapper _mapper;
        public CorporateCurrentCardManager(ICorporateCurrentCardDal corporateCurrentCardDal, IMapper mapper)
        {
            _corporateCurrentCardDal = corporateCurrentCardDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CorporateCurrentCardAddDtoValidator))]
        public async Task<IResult> AddAsync(CorporateCurrentCardAddDto corporateCurrentCardAddDto)
        {
            var mappedEntity = _mapper.Map<CorporateCurrentCard>(corporateCurrentCardAddDto);

            var result = await _corporateCurrentCardDal.AddAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.CorporateCurrentCardNotAdded);

            return new SuccessResult(Messages.CorporateCurrentCardAdded);
        }

        [ValidationAspect(typeof(CorporateCurrentCardDeleteDtoValidator))]
        public async Task<IResult> DeleteAsync(CorporateCurrentCardDeleteDto corporateCurrentCardDeleteDto)
        {
            var forDelete = await this.GetByIdAsync(corporateCurrentCardDeleteDto.Id);

            if (!forDelete.Success)
                return forDelete;

            var result = await _corporateCurrentCardDal.HardDeleteAsync(forDelete.Data);

            if (!result)
                return new ErrorResult(Messages.CorporateCurrentCardNotDeleted);

            return new SuccessResult(Messages.CorporateCurrentCardDeleted);
        }

        public async Task<IDataResult<List<CorporateCurrentCard>>> GetAllAsync()
        {
            var values = await _corporateCurrentCardDal.GetAllNoTrackingAsync();

            if (values.Count == 0)
                return new ErrorDataResult<List<CorporateCurrentCard>>(null, Messages.CurrenciesUnitNotFoundInDatabase);

            return new SuccessDataResult<List<CorporateCurrentCard>>(values, Messages.CurrenciesListed);
        }

        public async Task<IDataResult<CorporateCurrentCard>> GetByIdAsync(Guid id)
        {
            var corporateCurrentCard = await _corporateCurrentCardDal.GetAsync(p => p.Id == id);

            if (corporateCurrentCard == null)
                return new ErrorDataResult<CorporateCurrentCard>(null, Messages.CorporateCurrentCardNotFoundById);

            return new SuccessDataResult<CorporateCurrentCard>(corporateCurrentCard, Messages.CorporateCurrentCardFoundById);
        }

        [ValidationAspect(typeof(CorporateCurrentCardUpdateDtoValidator))]
        public async Task<IResult> UpdateAsync(CorporateCurrentCardUpdateDto corporateCurrentCardUpdateDto)
        {
            var forUpdate = await this.GetByIdAsync(corporateCurrentCardUpdateDto.Id);

            if (!forUpdate.Success)
                return forUpdate;

            var mappedEntity = _mapper.Map(corporateCurrentCardUpdateDto, forUpdate.Data);

            var result = await _corporateCurrentCardDal.UpdateAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.CorporateCurrentCardNotUpdated);

            return new SuccessResult(Messages.CorporateCurrentCardUpdated);
        }
    }
}
