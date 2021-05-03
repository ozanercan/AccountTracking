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
    public class LocalIndividualCurrentCardsController : ControllerBase
    {
        ILocalIndividualCurrentCardService _localIndividualCurrentCardService;
        public LocalIndividualCurrentCardsController(ILocalIndividualCurrentCardService localIndividualCurrentCardService)
        {
            _localIndividualCurrentCardService = localIndividualCurrentCardService;
        }

        /// <summary>
        /// Bütün bireysel yerel  carileri listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _localIndividualCurrentCardService.GetAllAsync();

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Id değeri verilen bireysel yerel cariyi getirir.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _localIndividualCurrentCardService.GetByIdAsync(id);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel yerel cari kart oluşturur.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(LocalIndividualCurrentCardAddDto localIndividualCurrentCardAddDto)
        {
            var result = await _localIndividualCurrentCardService.AddAsync(localIndividualCurrentCardAddDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel yerel cari kartı düzenler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(LocalIndividualCurrentCardUpdateDto localIndividualCurrentCardUpdateDto)
        {
            var result = await _localIndividualCurrentCardService.UpdateAsync(localIndividualCurrentCardUpdateDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel yerel cari kartı siler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDeleteAsync(LocalIndividualCurrentCardDeleteDto localIndividualCurrentCardDeleteDto)
        {
            var result = await _localIndividualCurrentCardService.DeleteAsync(localIndividualCurrentCardDeleteDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }
    }
}
