// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Order.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace OrderService {
  public static partial class OrderService
  {
    static readonly string __ServiceName = "OrderService";

    static readonly grpc::Marshaller<global::OrderService.AddOrderRequest> __Marshaller_AddOrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.AddOrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.AddOrderResponse> __Marshaller_AddOrderResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.AddOrderResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.UpdateOrderRequest> __Marshaller_UpdateOrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.UpdateOrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.UpdateOrderReponse> __Marshaller_UpdateOrderReponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.UpdateOrderReponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.RemoveOrderRequest> __Marshaller_RemoveOrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.RemoveOrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.RemoveOrderReponse> __Marshaller_RemoveOrderReponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.RemoveOrderReponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.QueryOrderRequest> __Marshaller_QueryOrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.QueryOrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OrderService.QueryOrderReponse> __Marshaller_QueryOrderReponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OrderService.QueryOrderReponse.Parser.ParseFrom);

    static readonly grpc::Method<global::OrderService.AddOrderRequest, global::OrderService.AddOrderResponse> __Method_AddOrderAsync = new grpc::Method<global::OrderService.AddOrderRequest, global::OrderService.AddOrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddOrderAsync",
        __Marshaller_AddOrderRequest,
        __Marshaller_AddOrderResponse);

    static readonly grpc::Method<global::OrderService.UpdateOrderRequest, global::OrderService.UpdateOrderReponse> __Method_UpdateOrderAsync = new grpc::Method<global::OrderService.UpdateOrderRequest, global::OrderService.UpdateOrderReponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UpdateOrderAsync",
        __Marshaller_UpdateOrderRequest,
        __Marshaller_UpdateOrderReponse);

    static readonly grpc::Method<global::OrderService.RemoveOrderRequest, global::OrderService.RemoveOrderReponse> __Method_RemoveOrderAsync = new grpc::Method<global::OrderService.RemoveOrderRequest, global::OrderService.RemoveOrderReponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "RemoveOrderAsync",
        __Marshaller_RemoveOrderRequest,
        __Marshaller_RemoveOrderReponse);

    static readonly grpc::Method<global::OrderService.QueryOrderRequest, global::OrderService.QueryOrderReponse> __Method_QueryOrderAsync = new grpc::Method<global::OrderService.QueryOrderRequest, global::OrderService.QueryOrderReponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "QueryOrderAsync",
        __Marshaller_QueryOrderRequest,
        __Marshaller_QueryOrderReponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::OrderService.OrderReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OrderService</summary>
    [grpc::BindServiceMethod(typeof(OrderService), "BindService")]
    public abstract partial class OrderServiceBase
    {
      /// <summary>
      ///1:添加订单（简单rpc模式）
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::OrderService.AddOrderResponse> AddOrderAsync(global::OrderService.AddOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///2:修改订单 (客户端流模式)
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::OrderService.UpdateOrderReponse> UpdateOrderAsync(grpc::IAsyncStreamReader<global::OrderService.UpdateOrderRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///3:删除订单 (服务器端流模式)
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task RemoveOrderAsync(global::OrderService.RemoveOrderRequest request, grpc::IServerStreamWriter<global::OrderService.RemoveOrderReponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///4:查询订单 (双向流模式)
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task QueryOrderAsync(grpc::IAsyncStreamReader<global::OrderService.QueryOrderRequest> requestStream, grpc::IServerStreamWriter<global::OrderService.QueryOrderReponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OrderServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddOrderAsync, serviceImpl.AddOrderAsync)
          .AddMethod(__Method_UpdateOrderAsync, serviceImpl.UpdateOrderAsync)
          .AddMethod(__Method_RemoveOrderAsync, serviceImpl.RemoveOrderAsync)
          .AddMethod(__Method_QueryOrderAsync, serviceImpl.QueryOrderAsync).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OrderServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddOrderAsync, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrderService.AddOrderRequest, global::OrderService.AddOrderResponse>(serviceImpl.AddOrderAsync));
      serviceBinder.AddMethod(__Method_UpdateOrderAsync, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::OrderService.UpdateOrderRequest, global::OrderService.UpdateOrderReponse>(serviceImpl.UpdateOrderAsync));
      serviceBinder.AddMethod(__Method_RemoveOrderAsync, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::OrderService.RemoveOrderRequest, global::OrderService.RemoveOrderReponse>(serviceImpl.RemoveOrderAsync));
      serviceBinder.AddMethod(__Method_QueryOrderAsync, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::OrderService.QueryOrderRequest, global::OrderService.QueryOrderReponse>(serviceImpl.QueryOrderAsync));
    }

  }
}
#endregion
