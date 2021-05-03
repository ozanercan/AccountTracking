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
    public class IndividualCurrentCardsController : ControllerBase
    {
        IIndividualCurrentCardService _individualCurrentCardService;
        public IndividualCurrentCardsController(IIndividualCurrentCardService individualCurrentCardService)
        {
            _individualCurrentCardService = individualCurrentCardService;
        }

        /// <summary>
        /// Bütün bireyselleri listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _individualCurrentCardService.GetAllAsync();

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Id değeri verilen bireyseli getirir.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _individualCurrentCardService.GetByIdAsync(id);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel cari kart oluşturur.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(IndividualCurrentCardAddDto individualCurrentCardAddDto)
        {
            var result = await _individualCurrentCardService.AddAsync(individualCurrentCardAddDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel cari kartı düzenler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(IndividualCurrentCardUpdateDto individualCurrentCardUpdateDto)
        {
            var result = await _individualCurrentCardService.UpdateAsync(individualCurrentCardUpdateDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Bireysel cari kartı siler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDeleteAsync(IndividualCurrentCardDeleteDto individualCurrentCardDeleteDto)
        {
            var result = await _individualCurrentCardService.DeleteAsync(individualCurrentCardDeleteDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }
    }
}
