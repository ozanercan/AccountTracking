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
    public class CurrentCardManager : ICurrentCardService
    {
        ICurrentCardDal _currentCardDal;
        IMapper _mapper;
        public CurrentCardManager(ICurrentCardDal currentCardDal, IMapper mapper)
        {
            _currentCardDal = currentCardDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CurrentCardAddDtoValidator))]
        public async Task<IResult> AddAsync(CurrentCardAddDto currentCardAddDto)
        {
            var mappedEntity = _mapper.Map<CurrentCard>(currentCardAddDto);

            var result = await _currentCardDal.AddAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.CurrentCardNotAdded);

            return new SuccessResult(Messages.CurrentCardAdded);
        }

        [ValidationAspect(typeof(CurrentCardDeleteDtoValidator))]
        public async Task<IResult> DeleteAsync(CurrentCardDeleteDto currentCardDeleteDto)
        {
            var forDelete = await this.GetByIdAsync(currentCardDeleteDto.Id);

            if (!forDelete.Success)
                return forDelete;

            var result = await _currentCardDal.HardDeleteAsync(forDelete.Data);

            if (!result)
                return new ErrorResult(Messages.CurrentCardNotDeleted);

            return new SuccessResult(Messages.CurrentCardDeleted);
        }

        public async Task<IDataResult<List<CurrentCard>>> GetAllAsync()
        {
            var values = await _currentCardDal.GetAllNoTrackingAsync();

            if (values.Count == 0)
                return new ErrorDataResult<List<CurrentCard>>(null, Messages.CurrentCardsNotListed);

            return new SuccessDataResult<List<CurrentCard>>(values, Messages.CurrentCardsListed);
        }

        public async Task<IDataResult<CurrentCard>> GetByIdAsync(Guid id)
        {
            var currentCard = await _currentCardDal.GetAsync(p => p.Id == id);

            if (currentCard == null)
                return new ErrorDataResult<CurrentCard>(null, Messages.CurrentCardNotFoundById);

            return new SuccessDataResult<CurrentCard>(currentCard, Messages.CurrentCardFoundById);
        }

        [ValidationAspect(typeof(CurrentCardUpdateDtoValidator))]
        public async Task<IResult> UpdateAsync(CurrentCardUpdateDto currentCardUpdateDto)
        {
            var forUpdate = await this.GetByIdAsync(currentCardUpdateDto.Id);

            if (!forUpdate.Success)
                return forUpdate;

            var mappedEntity = _mapper.Map(currentCardUpdateDto, forUpdate.Data);

            var result = await _currentCardDal.UpdateAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.CurrentCardNotUpdated);

            return new SuccessResult(Messages.CurrentCardUpdated);
        }
    }
}
