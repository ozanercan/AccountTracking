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
        IIndividualCurrentCardService _individualCurrentCardService;
        ILocalIndividualCurrentCardService _localIndividualCurrentCardService;
        IForeignIndividualCurrentCardService _foreignIndividualCurrentCardService;
        public CurrentCardManagementManager(ICurrentCardService currentCardService, ICorporateCurrentCardService corporateCurrentCardService, ILocalIndividualCurrentCardService localIndividualCurrentCardService, IForeignIndividualCurrentCardService foreignIndividualCurrentCardService, IIndividualCurrentCardService individualCurrentCardService)
        {
            _currentCardService = currentCardService;
            _corporateCurrentCardService = corporateCurrentCardService;
            _localIndividualCurrentCardService = localIndividualCurrentCardService;
            _foreignIndividualCurrentCardService = foreignIndividualCurrentCardService;
            _individualCurrentCardService = individualCurrentCardService;
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

        [TransactionScopeByResultAspect]
        [ValidationAspect(typeof(CurrentCardAndLocalIndividualAddDtoValidator))]
        public async Task<IResult> AddLocalIndividualAsync(CurrentCardAndLocalIndividualAddDto currentCardAndLocalIndividualAddDto)
        {
            var currentCardAddResult = await this.AddCurrentCardAsync(currentCardAndLocalIndividualAddDto.CurrentCardAddDto);
            if (!currentCardAddResult.Success)
                return currentCardAddResult;

            currentCardAndLocalIndividualAddDto.IndividualCurrentCardAddDto.CurrentCardId = currentCardAddResult.Data.Id;

            var individualCurrentCardAddResult = await this.AddIndividualCurrentCardAsync(currentCardAndLocalIndividualAddDto.IndividualCurrentCardAddDto);
            if (!individualCurrentCardAddResult.Success)
                return individualCurrentCardAddResult;

            currentCardAndLocalIndividualAddDto.LocalIndividualCurrentCardAddDto.IndividualCurrentCardId = individualCurrentCardAddResult.Data.Id;

            var localIndividualAddResult = await _localIndividualCurrentCardService.AddAsync(currentCardAndLocalIndividualAddDto.LocalIndividualCurrentCardAddDto);
            if (!localIndividualAddResult.Success)
                return localIndividualAddResult;

            return new SuccessResult(Messages.IndividualCurrentCardAdded);
        }

        [TransactionScopeByResultAspect]
        [ValidationAspect(typeof(CurrentCardAndForeignIndividualAddDtoValidator))]
        public async Task<IResult> AddForeignIndividualAsync(CurrentCardAndForeignIndividualAddDto currentCardAndForeignIndividualAddDto)
        {
            var currentCardAddResult = await this.AddCurrentCardAsync(currentCardAndForeignIndividualAddDto.CurrentCardAddDto);
            if (!currentCardAddResult.Success)
                return currentCardAddResult;

            currentCardAndForeignIndividualAddDto.IndividualCurrentCardAddDto.CurrentCardId = currentCardAddResult.Data.Id;

            var individualCurrentCardAddResult = await this.AddIndividualCurrentCardAsync(currentCardAndForeignIndividualAddDto.IndividualCurrentCardAddDto);
            if (!individualCurrentCardAddResult.Success)
                return individualCurrentCardAddResult;

            currentCardAndForeignIndividualAddDto.ForeignIndividualCurrentCardAddDto.IndividualCurrentCardId = individualCurrentCardAddResult.Data.Id;

            var foreignIndividualAddResult = await _foreignIndividualCurrentCardService.AddAsync(currentCardAndForeignIndividualAddDto.ForeignIndividualCurrentCardAddDto);
            if (!foreignIndividualAddResult.Success)
                return foreignIndividualAddResult;

            return new SuccessResult(Messages.ForeignIndividualCurrentCardAdded);
        }

        private async Task<IDataResult<CurrentCard>> AddCurrentCardAsync(CurrentCardAddDto currentCardAddDto)
        {
            return await _currentCardService.AddAsync(currentCardAddDto);
        }
        private async Task<IDataResult<IndividualCurrentCard>> AddIndividualCurrentCardAsync(IndividualCurrentCardAddDto individualCurrentCardAddDto)
        {
            return await _individualCurrentCardService.AddAsync(individualCurrentCardAddDto);
        }
        private async Task<IDataResult<CorporateCurrentCard>> AddCorporateCardAsync(CorporateCurrentCardAddDto corporateCurrentCardAddDto)
        {
            return await _corporateCurrentCardService.AddAsync(corporateCurrentCardAddDto);
        }
    }
}
