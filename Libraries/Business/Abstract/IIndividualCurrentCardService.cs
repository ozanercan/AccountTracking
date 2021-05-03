using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIndividualCurrentCardService
    {
        /// <summary>
        /// Bireyselleri listeler.
        /// </summary>
        public Task<IDataResult<List<IndividualCurrentCard>>> GetAllAsync();

        /// <summary>
        /// İstenilen id değerine göre ilgili bireyseli verir.
        /// </summary>
        public Task<IDataResult<IndividualCurrentCard>> GetByIdAsync(Guid id);

        /// <summary>
        /// Bireysel oluşturur.
        /// </summary>
        public Task<IResult> AddAsync(IndividualCurrentCardAddDto individualCurrentCardAddDto);

        /// <summary>
        /// Bireyseli siler.
        /// </summary>
        public Task<IResult> DeleteAsync(IndividualCurrentCardDeleteDto individualCurrentCardDeleteDto);

        /// <summary>
        /// Bireyseli günceller.
        /// </summary>
        public Task<IResult> UpdateAsync(IndividualCurrentCardUpdateDto individualCurrentCardUpdateDto);
    }
}
