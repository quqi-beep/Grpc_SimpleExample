using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NerCoreGrpcService.Protos;

namespace NetCoreGrpcClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ProjectService.ProjectServiceClient(channel);
            var res = await client.AddProjectAsyncAsync(new AddProjectRequest
            {
                ProjectName = "Test添加新项目"
            });

            return $"[{res.No}-{res.ProjectName}]";
        }
    }
}
