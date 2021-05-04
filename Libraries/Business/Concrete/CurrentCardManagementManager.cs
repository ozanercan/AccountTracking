using Business.Abstract;
using Business.Constants;
using Business.Validators.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CurrentCardManagementManager : ICurrentCardManagementService
    {
        ICurrentCardService _currentCardService;
        ICorporateCurrentCardService _corporateCurrentCardService;

        public CurrentCardManagementManager(ICurrentCardService currentCardService, ICorporateCurrentCardService corporateCurrentCardService)
        {
            _currentCardService = currentCardService;
            _corporateCurrentCardService = corporateCurrentCardService;
        }


        [TransactionScopeByResultAspect]
        [ValidationAspect(typeof(CurrentCardAndCorporateAddDtoValidator))]
        public async Task<IResult> AddCorporateAsync(CurrentCardAndCorporateAddDto currentCardAndCorporateAddDto)
        {
            var currentCardAddResult = await this.AddCurrentCardAsync(currentCardAndCorporateAddDto.CurrentCardAddDto);
            if (!currentCardAddResult.Success)
                return currentCardAddResult;

            currentCardAndCorporateAddDto.CorporateCurrentCardAddDto.CurrentCardId = currentCardAddResult.Data.Id;

            var corporateCardAddResult = await this.AddCorporateCardAsync(currentCardAndCorporateAddDto.CorporateCurrentCardAddDto);
            if (!corporateCardAddResult.Success)
                return corporateCardAddResult;

            return new SuccessResult(Messages.CorporateCurrentCardAdded);
        }

        private async Task<IDataResult<CurrentCard>> AddCurrentCardAsync(CurrentCardAddDto currentCardAddDto)
        {
            return await _currentCardService.AddAsync(currentCardAddDto);
        }

        private async Task<IDataResult<CorporateCurrentCard>> AddCorporateCardAsync(CorporateCurrentCardAddDto corporateCurrentCardAddDto)
        {
            return await _corporateCurrentCardService.AddAsync(corporateCurrentCardAddDto);
        }
    }
}
