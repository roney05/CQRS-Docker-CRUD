using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC_Country.API.Domains.Commands;
using POC_Country.API.Domains.Queries;
using POC_Country.API.Models;

namespace POC_Country.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCountries")]
        public async Task<List<Country>> GetCountries()
        {
            var Countrys = (List<Country>)await _mediator.Send(new GetAllCountriesQuery());
            return Countrys;
        }

        [HttpGet("GetCountryById")]
        public async Task<Country> GetCountryById(short CountryId)
        {
            var Country = await _mediator.Send(new GetCountryByIdQuery() { CountryId = CountryId });
            return Country;
        }

        [HttpPost("AddCountry")]
        public async Task<Country> AddCountry(Country country)
        {
            var result = await _mediator.Send(new CreateCountryCommand(country));
            return result;
        }

        [HttpPut("UpdateCountry")]
        public async Task<int> UpdateCountry(Country country)
        {
            var result = await _mediator.Send(new UpdateCountryCommand(country));
            return result;
        }

        [HttpDelete("DeleteCountry")]
        public async Task<int> DeleteCountry(short countryId)
        {
            return await _mediator.Send(new DeleteCountryCommand() { CountryId = countryId });
        }
    }
}
