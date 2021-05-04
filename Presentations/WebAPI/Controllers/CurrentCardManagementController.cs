using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
    public class CurrentCardManagementController : ControllerBase
    {
        ICurrentCardManagementService _currentCardManagementService;

        public CurrentCardManagementController(ICurrentCardManagementService currentCardManagementService)
        {
            _currentCardManagementService = currentCardManagementService;
        }

        [HttpPost("AddCorporate")]
        public async Task<IActionResult> AddCorporateAsync(CurrentCardAndCorporateAddDto currentCardAndCorporateAddDto)
        {
            var addResult = await _currentCardManagementService.AddCorporateAsync(currentCardAndCorporateAddDto);
            if (!addResult.Success)
                return BadRequest(addResult);

            return Ok(addResult);
        }
    }
}
