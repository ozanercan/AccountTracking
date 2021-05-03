using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IForeignIndividualCurrentCardService
    {
        /// <summary>
        /// Yabancı bireysel carileri listeler.
        /// </summary>
        public Task<IDataResult<List<ForeignIndividualCurrentCard>>> GetAllAsync();

        /// <summary>
        /// İstenilen id değerine göre ilgili yabancı bireysel cariyi verir.
        /// </summary>
        public Task<IDataResult<ForeignIndividualCurrentCard>> GetByIdAsync(Guid id);

        /// <summary>
        /// Yabancı bireysel cari oluşturur.
        /// </summary>
        public Task<IResult> AddAsync(ForeignIndividualCurrentCardAddDto foreignIndividualCurrentCardAddDto);

        /// <summary>
        /// Yabancı bireysel cariyi siler.
        /// </summary>
        public Task<IResult> DeleteAsync(ForeignIndividualCurrentCardDeleteDto foreignIndividualCurrentCardDeleteDto);

        /// <summary>
        /// Yabancı bireysel cariyi günceller.
        /// </summary>
        public Task<IResult> UpdateAsync(ForeignIndividualCurrentCardUpdateDto foreignIndividualCurrentCardUpdateDto);
    }
}
