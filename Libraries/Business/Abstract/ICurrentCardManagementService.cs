using Core.Utilities.Results.Abstract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICurrentCardManagementService
    {
        public Task<IResult> AddCorporateAsync(CurrentCardAndCorporateAddDto currentCardAndCorporateAddDto);
        public Task<IResult> AddLocalIndividualAsync(CurrentCardAndLocalIndividualAddDto currentCardAndLocalIndividualAddDto);
        public Task<IResult> AddForeignIndividualAsync(CurrentCardAndForeignIndividualAddDto currentCardAndForeignIndividualAddDto);
    }
}
