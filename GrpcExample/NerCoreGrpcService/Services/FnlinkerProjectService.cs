using Grpc.Core;
using NerCoreGrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerCoreGrpcService.Services
{
    public class FnlinkerProjectService : ProjectService.ProjectServiceBase
    {
        /// <summary>
        /// 简单RPC模式
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<AddProjectReponse> AddProjectAsync(AddProjectRequest request, ServerCallContext context)
        {

            return Task.FromResult(new AddProjectReponse
            {
                No = "1",
                ProjectName = $"{request.ProjectName}_服务端"
            });
        }

        /// <summary>
        /// 双向流RPC模式
        /// </summary>
        /// <param name="requestStream"></param>
        /// <param name="responseStream"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task QueryProjectDetailAsync(IAsyncStreamReader<QueryProjectDetailRequest> requestStream, IServerStreamWriter<QueryProjectDetailReponse> responseStream, ServerCallContext context)
        {

            var list = new List<int>();
            while (await requestStream.MoveNext())
            {
                list.Add(requestStream.Current.ProjectId);
            }

            for (int i = 0; i < list.Count; i++)
            {
                await responseStream.WriteAsync(new QueryProjectDetailReponse { ProjectName = $"TEST双向流_项目名称{i + 1}" });
            }

            //return base.QueryProjectDetailAsync(requestStream, responseStream, context);
        }
    }
}
