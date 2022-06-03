using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ReDocExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// ������ѯ�ӿ�
        /// </summary>
        /// <remarks>��������ӿ���ϸ��������������</remarks>
        /// <returns></returns>
        [HttpGet(Name = "������ѯ�ӿ�")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<WeatherForecast>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized,Type = typeof(Error))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(Error))]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}