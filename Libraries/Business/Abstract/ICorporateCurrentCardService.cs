using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICorporateCurrentCardService
    {
        /// <summary>
        /// Kurumsal carileri listeler.
        /// </summary>
        public Task<IDataResult<List<CorporateCurrentCard>>> GetAllAsync();

        /// <summary>
        /// İstenilen id değerine göre ilgili kurumsal cariyi verir.
        /// </summary>
        public Task<IDataResult<CorporateCurrentCard>> GetByIdAsync(Guid id);

        /// <summary>
        /// Kurumsal cari oluşturur.
        /// </summary>
        public Task<IDataResult<CorporateCurrentCard>> AddAsync(CorporateCurrentCardAddDto corporateCurrentCardAddDto);

        /// <summary>
        /// Kurumsal cari siler.
        /// </summary>
        public Task<IResult> DeleteAsync(CorporateCurrentCardDeleteDto corporateCurrentCardAddDto);

        /// <summary>
        /// Kurumsal cariyi günceller.
        /// </summary>
        public Task<IResult> UpdateAsync(CorporateCurrentCardUpdateDto corporateCurrentCardAddDto);
    }
}
