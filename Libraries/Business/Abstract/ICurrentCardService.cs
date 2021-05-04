using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICurrentCardService
    {
        /// <summary>
        /// Cari kartları listeler.
        /// </summary>
        public Task<IDataResult<List<CurrentCard>>> GetAllAsync();

        /// <summary>
        /// İstenilen id değerine göre ilgili cariyi verir.
        /// </summary>
        public Task<IDataResult<CurrentCard>> GetByIdAsync(Guid id);

        /// <summary>
        /// Cari kart oluşturur.
        /// </summary>
        public Task<IDataResult<CurrentCard>> AddAsync(CurrentCardAddDto currentCardAddDto);

        /// <summary>
        /// Cari kart siler.
        /// </summary>
        public Task<IResult> DeleteAsync(CurrentCardDeleteDto currentCardAddDto);

        /// <summary>
        /// Cariyi günceller.
        /// </summary>
        public Task<IResult> UpdateAsync(CurrentCardUpdateDto currentCardAddDto);
    }
}
