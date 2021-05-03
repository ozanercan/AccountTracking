using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocalIndividualCurrentCardService
    {
        /// <summary>
        /// Yerel bireysel carileri listeler.
        /// </summary>
        public Task<IDataResult<List<LocalIndividualCurrentCard>>> GetAllAsync();

        /// <summary>
        /// İstenilen id değerine göre ilgili yerel bireysel cariyi verir.
        /// </summary>
        public Task<IDataResult<LocalIndividualCurrentCard>> GetByIdAsync(Guid id);

        /// <summary>
        /// Yerel bireysel cari oluşturur.
        /// </summary>
        public Task<IResult> AddAsync(LocalIndividualCurrentCardAddDto localIndividualCurrentCardAddDto);

        /// <summary>
        /// Yerel bireysel cariyi siler.
        /// </summary>
        public Task<IResult> DeleteAsync(LocalIndividualCurrentCardDeleteDto localIndividualCurrentCardDeleteDto);

        /// <summary>
        /// Yerel bireysel cariyi günceller.
        /// </summary>
        public Task<IResult> UpdateAsync(LocalIndividualCurrentCardUpdateDto localIndividualCurrentCardUpdateDto);
    }
}
