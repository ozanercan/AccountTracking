using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Validators;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CurrencyUnitManager : ICurrencyUnitService
    {
        ICurrencyUnitDal _currencyUnitDal;
        IMapper _mapper;

        public CurrencyUnitManager(ICurrencyUnitDal currencyUnitDal, IMapper mapper)
        {
            _currencyUnitDal = currencyUnitDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CurrencyUnitAddDtoValidator))]
        public async Task<IResult> AddAsync(CurrencyUnitAddDto currencyAddDto)
        {
            var rulesResult = BusinessRules.Run(await CheckCurrencyUnitNameAsync(currencyAddDto.Name));
            if (!rulesResult.Success)
                return rulesResult;

            var mappedEntity = _mapper.Map<CurrencyUnit>(currencyAddDto);

            var addStatu = await _currencyUnitDal.AddAsync(mappedEntity);
            if (!addStatu)
                return new ErrorResult(Messages.CurrencyUnitNotAdded);

            return new SuccessResult(Messages.CurrencyUnitAdded);
        }

        [ValidationAspect(typeof(CurrencyUnitDeleteDtoValidator))]
        public async Task<IResult> HardDeleteAsync(CurrencyUnitDeleteDto currencyDeleteDto)
        {
            var findedEntityResult = await this.GetByIdAsync(currencyDeleteDto.Id);
            if (!findedEntityResult.Success)
                return findedEntityResult;

            var deleteStatu = await _currencyUnitDal.HardDeleteAsync(findedEntityResult.Data);
            if (!deleteStatu)
                return new ErrorResult(Messages.CurrencyUnitNotDeleted);

            return new SuccessResult(Messages.CurrencyUnitDeleted);
        }

        [ValidationAspect(typeof(CurrencyUnitUpdateDtoValidator))]
        public async Task<IResult> UpdateAsync(CurrencyUnitUpdateDto currencyUpdateDto)
        {
            var findedEntityResult = await this.GetByIdAsync(currencyUpdateDto.Id);
            if (!findedEntityResult.Success)
                return findedEntityResult;

            var mappedEntity = _mapper.Map(currencyUpdateDto, findedEntityResult.Data);

            var updateStatu = await _currencyUnitDal.UpdateAsync(mappedEntity);
            if (!updateStatu)
                return new ErrorResult(Messages.CurrencyUnitNotUpdate);

            return new SuccessResult(Messages.CurrencyUnitUpdated);
        }

        public async Task<IDataResult<List<CurrencyUnit>>> GetAllAsync()
        {
            var currencyUnits = await _currencyUnitDal.GetAllNoTrackingAsync();
            if (currencyUnits.Count == 0)
                return new ErrorDataResult<List<CurrencyUnit>>(null, Messages.CurrenciesUnitNotFoundInDatabase);

            return new SuccessDataResult<List<CurrencyUnit>>(currencyUnits, Messages.CurrenciesListed);
        }

        public async Task<IDataResult<CurrencyUnit>> GetByIdAsync(Guid id)
        {
            var findedEntity = await _currencyUnitDal.GetAsync(p => p.Id == id);
            if (findedEntity == null)
                return new ErrorDataResult<CurrencyUnit>(null, Messages.CurrencyUnitNotFoundById);

            return new SuccessDataResult<CurrencyUnit>(findedEntity, Messages.CurrencyUnitFoundById);
        }

        /// <summary>
        /// Para Birimi Adının veritabanında kayıtlı olup olmadığını kontrol eder.
        /// </summary>
        /// <returns>Kayıt yoksa TRUE, Kayıt varsa FALSE döner.</returns>
        private async Task<IResult> CheckCurrencyUnitNameAsync(string name)
        {
            var result = await _currencyUnitDal.IsExistsAsync(p => p.Name.Equals(name));
            if (!result)
                return new SuccessResult(Messages.CurrencyNameCanUsed);

            return new ErrorResult(Messages.CurrencyNameAlreadyRegistered);
        }
    }
}
