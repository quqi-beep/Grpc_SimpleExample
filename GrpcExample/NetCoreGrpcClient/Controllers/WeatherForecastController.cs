using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
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

            //简单 rpc
            var res = await client.AddProjectAsyncAsync(new AddProjectRequest
            {
                ProjectName = "Test添加新项目"
            });

            //双向流rpc
            var projectName = "";
            var projects = client.QueryProjectDetailAsync();

            for (int i = 0; i < 2; i++)
            {
                await projects.RequestStream.WriteAsync(new QueryProjectDetailRequest
                {
                    ProjectId = i+1
                });
            }
            await projects.RequestStream.CompleteAsync();

            await Task.Run(async () =>
            {
                var res = projects.ResponseStream;

                while (await res.MoveNext())
                {
                    projectName = res.Current.ProjectName;
                }
            });

            return $"[{res.No}-{res.ProjectName}]_{projectName}";
        }
    }
}
