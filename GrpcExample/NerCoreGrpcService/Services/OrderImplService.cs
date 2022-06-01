using Grpc.Core;
using NerCoreGrpcService.Models;
using OrderService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerCoreGrpcService.Services
{
    public class OrderImplService : OrderService.OrderService.OrderServiceBase
    {
        private static Dictionary<long, OrderModel> _orders = new Dictionary<long, OrderModel>();

        public override async Task<AddOrderResponse> AddOrderAsync(AddOrderRequest request, ServerCallContext context)
        {
            _orders.Add(request.No, new OrderModel
            {
                No = request.No,
                Name = request.Name,
                Desc = request.Des
            });
            return await Task.FromResult(new AddOrderResponse
            {
                No = request.No,
            });
        }

        public override async Task<UpdateOrderReponse> UpdateOrderAsync(IAsyncStreamReader<UpdateOrderRequest> requestStream, ServerCallContext context)
        {
            long no = 0;
            var name = "";
            while (await requestStream.MoveNext())
            {
                no = requestStream.Current.No;
                name = requestStream.Current.Name;
            }
            //long no = requestStream.Current.No;
            //var name = requestStream.Current.Name;

            if (no <= 0)
            {
                return await Task.FromResult(new UpdateOrderReponse());
            }

            if (_orders != null && _orders.Count > 0)
            {
                var order = _orders[no];
                _orders[no] = new OrderModel
                {
                    Name = name,
                    Desc = order.Desc
                };
            }
            return await Task.FromResult(new UpdateOrderReponse
            {
                IsUpdate = true,
            });
        }

        public override async Task RemoveOrderAsync(RemoveOrderRequest request, IServerStreamWriter<RemoveOrderReponse> responseStream, ServerCallContext context)
        {
            if (_orders != null)
            {
                _orders.Remove(request.No);
            }
            
            await responseStream.WriteAsync(new RemoveOrderReponse { IsRemove = true });
        }

        public override async Task QueryOrderAsync(IAsyncStreamReader<QueryOrderRequest> requestStream, IServerStreamWriter<QueryOrderReponse> responseStream, ServerCallContext context)
        {
            var orders = new List<Order>();

            long no = 0;
            while (await requestStream.MoveNext())
            {
                no = requestStream.Current.No;
            }
            if (no > 0)
            {
                orders.Add(new Order
                {
                    No = no,
                    Name = _orders[no].Name,
                    Des = _orders[no].Desc
                });
            }
            else
            {
                foreach (var order in _orders)
                {
                    orders.Add(new Order
                    {
                        No = order.Key,
                        Name = order.Value.Name,
                        Des = order.Value.Desc
                    });
                }
            }
            var response = new QueryOrderReponse();
            response.Orders.AddRange(orders);
            await responseStream.WriteAsync(response);
        }

        ///// <summary>
        ///// 简单RPC模式
        ///// </summary>
        ///// <param name="request"></param>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //public override Task<AddProjectReponse> AddProjectAsync(AddProjectRequest request, ServerCallContext context)
        //{

        //    return Task.FromResult(new AddProjectReponse
        //    {
        //        No = "1",
        //        ProjectName = $"{request.ProjectName}_服务端"
        //    });
        //}

        ///// <summary>
        ///// 双向流RPC模式
        ///// </summary>
        ///// <param name="requestStream"></param>
        ///// <param name="responseStream"></param>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //public override async Task QueryProjectDetailAsync(IAsyncStreamReader<QueryProjectDetailRequest> requestStream, IServerStreamWriter<QueryProjectDetailReponse> responseStream, ServerCallContext context)
        //{

        //    var list = new List<int>();
        //    while (await requestStream.MoveNext())
        //    {
        //        list.Add(requestStream.Current.ProjectId);
        //    }

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        await responseStream.WriteAsync(new QueryProjectDetailReponse { ProjectName = $"TEST双向流_项目名称{i + 1}" });
        //    }

        //    //return base.QueryProjectDetailAsync(requestStream, responseStream, context);
        //}
    }
}
