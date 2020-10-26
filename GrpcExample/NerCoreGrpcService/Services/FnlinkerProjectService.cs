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
        public override Task<AddProjectReponse> AddProjectAsync(AddProjectRequest request, ServerCallContext context)
        {

            return Task.FromResult(new AddProjectReponse
            {
                No = "1", 
                ProjectName = $"{request.ProjectName}_服务端"
            });
        }
    }
}
