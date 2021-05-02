using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyUnitsController : ControllerBase
    {
        ICurrencyUnitService _currencyUnitService;

        public CurrencyUnitsController(ICurrencyUnitService currencyUnitService)
        {
            _currencyUnitService = currencyUnitService;
        }

        /// <summary>
        /// Bütün Para Birimlerini listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var currenciesResult = await _currencyUnitService.GetAllAsync();
            if (!currenciesResult.Success)
                return BadRequest(currenciesResult);

            return Ok(currenciesResult);
        }

        /// <summary>
        /// Id değeri verilen Para Birimini listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var currenciesResult = await _currencyUnitService.GetByIdAsync(id);
            if (!currenciesResult.Success)
                return BadRequest(currenciesResult);

            return Ok(currenciesResult);
        }

        /// <summary>
        /// Id değeri verilen Para Birimini listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var currenciesResult = await _currencyUnitService.GetByIdAsync(Guid.Parse(id));
            if (!currenciesResult.Success)
                return BadRequest(currenciesResult);

            return Ok(currenciesResult);
        }

        /// <summary>
        /// Yeni bir Para Birimi oluşturur.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(CurrencyUnitAddDto currencyUnitAddDto)
        {
            var addResult = await _currencyUnitService.AddAsync(currencyUnitAddDto);
            if (!addResult.Success)
                return BadRequest(addResult);

            return Ok(addResult);
        }

        /// <summary>
        /// Para Birimini düzenler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(CurrencyUnitUpdateDto currencyUnitUpdateDto)
        {
            var updateResult = await _currencyUnitService.UpdateAsync(currencyUnitUpdateDto);
            if (!updateResult.Success)
                return BadRequest(updateResult);

            return Ok(updateResult);
        }

        /// <summary>
        /// Para Birimini geri dönüşü olmayacak şekilde siler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDeleteAsync(CurrencyUnitDeleteDto currencyUnitDeleteDto)
        {
            var deleteResult = await _currencyUnitService.HardDeleteAsync(currencyUnitDeleteDto);
            if (!deleteResult.Success)
                return BadRequest(deleteResult);

            return Ok(deleteResult);
        }
    }
}
