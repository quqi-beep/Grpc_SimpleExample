using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreGrpcClient.Models;
using OrderService;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NetCoreGrpcClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {


        private readonly ILogger<HomeController> _logger;
        private readonly OrderService.OrderService.OrderServiceClient _orderServiceClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            _orderServiceClient = new OrderService.OrderService.OrderServiceClient(channel);
        }

        /// <summary>
        /// 查询订单 (双向流模式)
        /// </summary>
        /// <returns></returns>
        [HttpGet("orders")]
        public async Task<List<OrderVm>> QueryOrderAsync()
        {
            //简单 rpc
            var ordes = _orderServiceClient.QueryOrderAsync();
            await ordes.RequestStream.WriteAsync(new OrderService.QueryOrderRequest
            {
                No = 0
            });
            await ordes.RequestStream.CompleteAsync();

            var cts = new CancellationTokenSource();
            var orders = new List<OrderVm>();
            var response = ordes.ResponseStream;
            while (await response.MoveNext(cts.Token))
            {
                var orderItems = response.Current.Orders.ToList();
                foreach (var order in orderItems)
                {
                    orders.Add(new OrderVm
                    {
                        No = order.No,
                        Name = order.Name,
                        Desc = order.Des
                    });
                }
            }




            return orders;
            ////双向流rpc
            //var projectName = "";
            //var projects = client.QueryProjectDetailAsync();

            //for (int i = 0; i < 2; i++)
            //{
            //    await projects.RequestStream.WriteAsync(new QueryProjectDetailRequest
            //    {
            //        ProjectId = i + 1
            //    });
            //}
            //await projects.RequestStream.CompleteAsync();

            //await Task.Run(async () =>
            //{
            //    var res = projects.ResponseStream;

            //    while (await res.MoveNext())
            //    {
            //        projectName = res.Current.ProjectName;
            //    }
            //});

            //return $"[{res.No}-{res.ProjectName}]_{projectName}";
        }

        /// <summary>
        /// 添加订单 (简单rpc模式)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public long AddOrderAsync([FromBody] AddOrderRequest request)
        {
            var response = _orderServiceClient.AddOrderAsync(request);
            return response.No;
        }

        /// <summary>
        /// 修改订单 (客户端流模式)
        /// </summary>
        /// <returns></returns>
        [HttpPost("update")]
        public async Task<bool> UpdateOrderAsync([FromBody] UpdateOrderRequest request)
        {
            var order = _orderServiceClient.UpdateOrderAsync();
            await order.RequestStream.WriteAsync(new UpdateOrderRequest
            {
                No = request.No,
                Name = request.Name,
            });
            await order.RequestStream.CompleteAsync();

            var reeponse = await order.ResponseAsync;
            return reeponse.IsUpdate;
        }

        /// <summary>
        /// 删除订单 (服务器端流模式)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("remove")]
        public async Task<bool> RemoveOrderAsync([FromBody] RemoveOrderRequest request)
        {
            var order = _orderServiceClient.RemoveOrderAsync(request);
            var response = order.ResponseStream;
            var cts = new CancellationTokenSource();
            bool isRemove = false;
            if (await response.MoveNext(cts.Token))
            {
                isRemove = response.Current.IsRemove;
            }
            return isRemove;
        }
    }
}
