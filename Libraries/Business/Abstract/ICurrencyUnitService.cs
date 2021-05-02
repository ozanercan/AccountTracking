using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICurrencyUnitService
    {
        /// <summary>
        /// Yeni bir Para Birimi oluşturur.
        /// </summary>
        public Task<IResult> AddAsync(CurrencyUnitAddDto currencyAddDto);

        /// <summary>
        /// Para Birimini düzenler.
        /// </summary>
        public Task<IResult> UpdateAsync(CurrencyUnitUpdateDto currencyUpdateDto);

        /// <summary>
        /// Para Birimini geri dönüşü olmayacak şekilde siler.
        /// </summary>
        public Task<IResult> HardDeleteAsync(CurrencyUnitDeleteDto currencyDeleteDto);

        /// <summary>
        /// Bütün Para Birimlerini listeler.
        /// </summary>
        public Task<IDataResult<List<CurrencyUnit>>> GetAllAsync();

        /// <summary>
        /// Id değeri verilen Para Birimini listeler.
        /// </summary>
        public Task<IDataResult<CurrencyUnit>> GetByIdAsync(Guid id);
    }
}
