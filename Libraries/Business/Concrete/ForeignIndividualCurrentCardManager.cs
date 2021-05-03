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
    public class ForeignIndividualCurrentCardManager : IForeignIndividualCurrentCardService
    {
        IForeignIndividualCurrentCardDal _foreignIndividualCurrentCardDal;
        IMapper _mapper;
        public ForeignIndividualCurrentCardManager(IForeignIndividualCurrentCardDal foreignIndividualCurrentCardDal, IMapper mapper)
        {
            _foreignIndividualCurrentCardDal = foreignIndividualCurrentCardDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(ForeignIndividualCurrentCardAddDtoValidator))]
        public async Task<IResult> AddAsync(ForeignIndividualCurrentCardAddDto foreignIndividualCurrentCardAddDto)
        {
            var mappedEntity = _mapper.Map<ForeignIndividualCurrentCard>(foreignIndividualCurrentCardAddDto);

            var result = await _foreignIndividualCurrentCardDal.AddAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.ForeignIndividualCurrentCardNotAdded);

            return new SuccessResult(Messages.ForeignIndividualCurrentCardAdded);
        }

        [ValidationAspect(typeof(ForeignIndividualCurrentCardDeleteDtoValidator))]
        public async Task<IResult> DeleteAsync(ForeignIndividualCurrentCardDeleteDto foreignIndividualCurrentCardDeleteDto)
        {
            var forDelete = await this.GetByIdAsync(foreignIndividualCurrentCardDeleteDto.Id);

            if (!forDelete.Success)
                return forDelete;

            var result = await _foreignIndividualCurrentCardDal.HardDeleteAsync(forDelete.Data);

            if (!result)
                return new ErrorResult(Messages.ForeignIndividualCurrentCardNotDeleted);

            return new SuccessResult(Messages.ForeignIndividualCurrentCardDeleted);
        }

        public async Task<IDataResult<List<ForeignIndividualCurrentCard>>> GetAllAsync()
        {
            var values = await _foreignIndividualCurrentCardDal.GetAllNoTrackingAsync();

            if (values.Count == 0)
                return new ErrorDataResult<List<ForeignIndividualCurrentCard>>(null, Messages.ForeignIndividualCurrentCardsNotListed);

            return new SuccessDataResult<List<ForeignIndividualCurrentCard>>(values, Messages.ForeignIndividualCurrentCardsListed);
        }

        public async Task<IDataResult<ForeignIndividualCurrentCard>> GetByIdAsync(Guid id)
        {
            var foreignIndividualCurrentCard = await _foreignIndividualCurrentCardDal.GetAsync(p => p.Id == id);

            if (foreignIndividualCurrentCard == null)
                return new ErrorDataResult<ForeignIndividualCurrentCard>(null, Messages.ForeignIndividualCurrentCardNotFoundById);

            return new SuccessDataResult<ForeignIndividualCurrentCard>(foreignIndividualCurrentCard, Messages.ForeignIndividualCurrentCardFoundById);
        }

        [ValidationAspect(typeof(ForeignIndividualCurrentCardUpdateDtoValidator))]
        public async Task<IResult> UpdateAsync(ForeignIndividualCurrentCardUpdateDto foreignIndividualCurrentCardUpdateDto)
        {
            var forUpdate = await this.GetByIdAsync(foreignIndividualCurrentCardUpdateDto.Id);

            if (!forUpdate.Success)
                return forUpdate;

            var mappedEntity = _mapper.Map(foreignIndividualCurrentCardUpdateDto, forUpdate.Data);

            var result = await _foreignIndividualCurrentCardDal.UpdateAsync(mappedEntity);

            if (!result)
                return new ErrorResult(Messages.ForeignIndividualCurrentCardNotUpdated);

            return new SuccessResult(Messages.ForeignIndividualCurrentCardUpdated);
        }
    }
}
