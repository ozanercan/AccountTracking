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
    public class CurrentCardsController : ControllerBase
    {
        ICurrentCardService _currentCardService;
        public CurrentCardsController(ICurrentCardService currentCardService)
        {
            _currentCardService = currentCardService;
        }

        /// <summary>
        /// Bütün cari kartları listeler.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _currentCardService.GetAllAsync();

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Id değeri verilen cari kartı getirir.
        /// </summary>
        /// <returns>IDataResult</returns>
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _currentCardService.GetByIdAsync(id);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Cari kart oluşturur.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(CurrentCardAddDto currentCardAddDto)
        {
            var result = await _currentCardService.AddAsync(currentCardAddDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Cari kartı düzenler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(CurrentCardUpdateDto currentCardUpdateDto)
        {
            var result = await _currentCardService.UpdateAsync(currentCardUpdateDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }

        /// <summary>
        /// Cari kartı siler.
        /// </summary>
        /// <returns>IResult</returns>
        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDeleteAsync(CurrentCardDeleteDto currentCardDeleteDto)
        {
            var result = await _currentCardService.DeleteAsync(currentCardDeleteDto);

            return result.Success == false ? BadRequest(result) : Ok(result);
        }
    }
}
