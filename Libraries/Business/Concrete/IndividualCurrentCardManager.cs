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
    public class IndividualCurrentCardManager : IIndividualCurrentCardService
    {
        IIndividualCurrentCardDal _individualCurrentCardDal;
        IMapper _mapper;
        public IndividualCurrentCardManager(IIndividualCurrentCardDal individualCurrentCardDal, IMapper mapper)
        {
            _individualCurrentCardDal = individualCurrentCardDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(IndividualCurrentCardAddDtoValidator))]
        public async Task<IResult> AddAsync(IndividualCurrentCardAddDto individualCurrentCardAddDto)
        {
            var mappedEntity = _mapper.Map<IndividualCurrentCard>(individualCurrentCardAddDto);

            var result = await _individualCurrentCardDal.AddAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.IndividualCurrentCardNotAdded);

            return new SuccessResult(Messages.IndividualCurrentCardAdded);
        }

        [ValidationAspect(typeof(IndividualCurrentCardDeleteDtoValidator))]
        public async Task<IResult> DeleteAsync(IndividualCurrentCardDeleteDto individualCurrentCardDeleteDto)
        {
            var forDelete = await this.GetByIdAsync(individualCurrentCardDeleteDto.Id);

            if (!forDelete.Success)
                return forDelete;

            var result = await _individualCurrentCardDal.HardDeleteAsync(forDelete.Data);

            if (!result)
                return new ErrorResult(Messages.IndividualCurrentCardNotDeleted);

            return new SuccessResult(Messages.IndividualCurrentCardDeleted);
        }

        public async Task<IDataResult<List<IndividualCurrentCard>>> GetAllAsync()
        {
            var values = await _individualCurrentCardDal.GetAllNoTrackingAsync();

            if (values.Count == 0)
                return new ErrorDataResult<List<IndividualCurrentCard>>(null, Messages.IndividualCurrentCardsNotListed);

            return new SuccessDataResult<List<IndividualCurrentCard>>(values, Messages.IndividualCurrentCardsListed);
        }

        public async Task<IDataResult<IndividualCurrentCard>> GetByIdAsync(Guid id)
        {
            var individualCurrentCard = await _individualCurrentCardDal.GetAsync(p => p.Id == id);

            if (individualCurrentCard == null)
                return new ErrorDataResult<IndividualCurrentCard>(null, Messages.IndividualCurrentCardNotFoundById);

            return new SuccessDataResult<IndividualCurrentCard>(individualCurrentCard, Messages.IndividualCurrentCardFoundById);
        }

        [ValidationAspect(typeof(IndividualCurrentCardUpdateDtoValidator))]
        public async Task<IResult> UpdateAsync(IndividualCurrentCardUpdateDto individualCurrentCardUpdateDto)
        {
            var forUpdate = await this.GetByIdAsync(individualCurrentCardUpdateDto.Id);

            if (!forUpdate.Success)
                return forUpdate;

            var mappedEntity = _mapper.Map(individualCurrentCardUpdateDto, forUpdate.Data);

            var result = await _individualCurrentCardDal.UpdateAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.IndividualCurrentCardNotUpdated);

            return new SuccessResult(Messages.IndividualCurrentCardUpdated);
        }
    }
}
