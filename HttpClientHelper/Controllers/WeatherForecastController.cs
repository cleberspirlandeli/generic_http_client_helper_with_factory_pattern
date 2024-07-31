using Api.Test.Service.InvestimentGeneral;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IInvestimentGeneralService _investimentGeneralService;

        public WeatherForecastController(IInvestimentGeneralService investimentGeneralService)
        {
            _investimentGeneralService = investimentGeneralService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            var result = await _investimentGeneralService.ProcessAsync();
            return Ok(result);
        }
    }
}
