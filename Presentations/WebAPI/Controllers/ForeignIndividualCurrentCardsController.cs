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
    public class ForeignIndividualCurrentCardsController : ControllerBase
    {
        IForeignIndividualCurrentCardService _foreignIndividualCurrentCardService;
        public ForeignIndividualCurrentCardsController(IForeignIndividualCurrentCardService foreignIndividualCurrentCardService)
        {
            _foreignIndividualCurrentCardService = foreignIndividualCurrentCardService;
        }

        /// <summary>
        /// Bütün bireysel yabancı carileri listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _foreignIndividualCurrentCardService.GetAllAsync();

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Id değeri verilen bireysel yabancı cari kartı getirir.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _foreignIndividualCurrentCardService.GetByIdAsync(id);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel yabancı cari kart oluşturur.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(ForeignIndividualCurrentCardAddDto foreignIndividualCurrentCardAddDto)
        {
            var result = await _foreignIndividualCurrentCardService.AddAsync(foreignIndividualCurrentCardAddDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel yabancı cari kartı düzenler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(ForeignIndividualCurrentCardUpdateDto foreignIndividualCurrentCardUpdateDto)
        {
            var result = await _foreignIndividualCurrentCardService.UpdateAsync(foreignIndividualCurrentCardUpdateDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel yabancı cari kartı siler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDeleteAsync(ForeignIndividualCurrentCardDeleteDto foreignIndividualCurrentCardDeleteDto)
        {
            var result = await _foreignIndividualCurrentCardService.DeleteAsync(foreignIndividualCurrentCardDeleteDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }
    }
}
