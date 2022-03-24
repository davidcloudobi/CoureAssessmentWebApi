using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using Repository.Response;

namespace CoureAssessmentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryInformationController : ControllerBase
    {
        public CountryInformationController(ICountryInformation countryInformationService)
        {
            _countryInformationService = countryInformationService;
        }

        private readonly ICountryInformation _countryInformationService;
        [HttpGet]
        public async Task<ActionResult<GlobalResponse<List<Country>>>> GetCountryInformation([FromQuery]string phoneNumber)
        {
            var result = await _countryInformationService.GetCountriesDetails(phoneNumber);
            if (!result.Status) return BadRequest(result);
            return result.Data.Any() ? (ActionResult<GlobalResponse<List<Country>>>) Ok(result) : NoContent();
        }
    }
}
