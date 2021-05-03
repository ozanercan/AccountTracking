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
    public class LocalIndividualCurrentCardManager : ILocalIndividualCurrentCardService
    {
        ILocalIndividualCurrentCardDal _localIndividualCurrentCardDal;
        IMapper _mapper;
        public LocalIndividualCurrentCardManager(ILocalIndividualCurrentCardDal localndividualCurrentCardDal, IMapper mapper)
        {
            _localIndividualCurrentCardDal = localndividualCurrentCardDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(LocalIndividualCurrentCardAddDtoValidator))]
        public async Task<IResult> AddAsync(LocalIndividualCurrentCardAddDto localIndividualCurrentCardAddDto)
        {
            var mappedEntity = _mapper.Map<LocalIndividualCurrentCard>(localIndividualCurrentCardAddDto);

            var result = await _localIndividualCurrentCardDal.AddAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.LocalIndividualCurrentCardNotAdded);

            return new SuccessResult(Messages.LocalIndividualCurrentCardAdded);
        }

        [ValidationAspect(typeof(LocalIndividualCurrentCardDeleteDtoValidator))]
        public async Task<IResult> DeleteAsync(LocalIndividualCurrentCardDeleteDto localIndividualCurrentCardDeleteDto)
        {
            var forDelete = await this.GetByIdAsync(localIndividualCurrentCardDeleteDto.Id);

            if (!forDelete.Success)
                return forDelete;

            var result = await _localIndividualCurrentCardDal.HardDeleteAsync(forDelete.Data);

            if (!result)
                return new ErrorResult(Messages.LocalIndividualCurrentCardNotDeleted);

            return new SuccessResult(Messages.LocalIndividualCurrentCardDeleted);
        }

        public async Task<IDataResult<List<LocalIndividualCurrentCard>>> GetAllAsync()
        {
            var values = await _localIndividualCurrentCardDal.GetAllNoTrackingAsync();

            if (values.Count == 0)
                return new ErrorDataResult<List<LocalIndividualCurrentCard>>(null, Messages.LocalIndividualCurrentCardsNotListed);

            return new SuccessDataResult<List<LocalIndividualCurrentCard>>(values, Messages.LocalIndividualCurrentCardsListed);
        }

        public async Task<IDataResult<LocalIndividualCurrentCard>> GetByIdAsync(Guid id)
        {
            var localIndividualCurrentCard = await _localIndividualCurrentCardDal.GetAsync(p => p.Id == id);

            if (localIndividualCurrentCard == null)
                return new ErrorDataResult<LocalIndividualCurrentCard>(null, Messages.LocalIndividualCurrentCardNotFoundById);

            return new SuccessDataResult<LocalIndividualCurrentCard>(localIndividualCurrentCard, Messages.LocalIndividualCurrentCardFoundById);
        }

        [ValidationAspect(typeof(LocalIndividualCurrentCardUpdateDtoValidator))]
        public async Task<IResult> UpdateAsync(LocalIndividualCurrentCardUpdateDto localIndividualCurrentCardUpdateDto)
        {
            var forUpdate = await this.GetByIdAsync(localIndividualCurrentCardUpdateDto.Id);

            if (!forUpdate.Success)
                return forUpdate;

            var mappedEntity = _mapper.Map(localIndividualCurrentCardUpdateDto, forUpdate.Data);

            var result = await _localIndividualCurrentCardDal.UpdateAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.LocalIndividualCurrentCardNotUpdated);

            return new SuccessResult(Messages.LocalIndividualCurrentCardUpdated);
        }
    }
}
