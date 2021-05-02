using Business.Abstract;
using Entities.Concrete;
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
    public class CorporateCurrentCardsController : ControllerBase
    {
        ICorporateCurrentCardService _corporateCurrentCardService;
        public CorporateCurrentCardsController(ICorporateCurrentCardService corporateCurrentCardService)
        {
            _corporateCurrentCardService = corporateCurrentCardService;
        }

        /// <summary>
        /// Bütün kurumsal carileri listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _corporateCurrentCardService.GetAllAsync();

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Id değeri verilen kurumsal cariyi getirir.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _corporateCurrentCardService.GetByIdAsync(id);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Kurumsal cari kart oluşturur.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(CorporateCurrentCardAddDto corporateCurrentCardAddDto)
        {
            var result = await _corporateCurrentCardService.AddAsync(corporateCurrentCardAddDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Kurumsal cari kartı düzenler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(CorporateCurrentCardUpdateDto corporateCurrentCardUpdateDto)
        {
            var result = await _corporateCurrentCardService.UpdateAsync(corporateCurrentCardUpdateDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Kurumsal cari kartı siler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDeleteAsync(CorporateCurrentCardDeleteDto corporateCurrentCardDeleteDto)
        {
            var result = await _corporateCurrentCardService.DeleteAsync(corporateCurrentCardDeleteDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }
    }
}
