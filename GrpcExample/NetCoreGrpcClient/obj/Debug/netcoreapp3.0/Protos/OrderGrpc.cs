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

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::OrderService.AddOrderRequest> __Marshaller_AddOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.AddOrderRequest.Parser));
    static readonly grpc::Marshaller<global::OrderService.AddOrderResponse> __Marshaller_AddOrderResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.AddOrderResponse.Parser));
    static readonly grpc::Marshaller<global::OrderService.UpdateOrderRequest> __Marshaller_UpdateOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.UpdateOrderRequest.Parser));
    static readonly grpc::Marshaller<global::OrderService.UpdateOrderReponse> __Marshaller_UpdateOrderReponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.UpdateOrderReponse.Parser));
    static readonly grpc::Marshaller<global::OrderService.RemoveOrderRequest> __Marshaller_RemoveOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.RemoveOrderRequest.Parser));
    static readonly grpc::Marshaller<global::OrderService.RemoveOrderReponse> __Marshaller_RemoveOrderReponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.RemoveOrderReponse.Parser));
    static readonly grpc::Marshaller<global::OrderService.QueryOrderRequest> __Marshaller_QueryOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.QueryOrderRequest.Parser));
    static readonly grpc::Marshaller<global::OrderService.QueryOrderReponse> __Marshaller_QueryOrderReponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderService.QueryOrderReponse.Parser));

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

    /// <summary>Client for OrderService</summary>
    public partial class OrderServiceClient : grpc::ClientBase<OrderServiceClient>
    {
      /// <summary>Creates a new client for OrderService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OrderServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OrderService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OrderServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OrderServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OrderServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///1:添加订单（简单rpc模式）
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::OrderService.AddOrderResponse AddOrderAsync(global::OrderService.AddOrderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddOrderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///1:添加订单（简单rpc模式）
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::OrderService.AddOrderResponse AddOrderAsync(global::OrderService.AddOrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddOrderAsync, null, options, request);
      }
      /// <summary>
      ///1:添加订单（简单rpc模式）
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::OrderService.AddOrderResponse> AddOrderAsyncAsync(global::OrderService.AddOrderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddOrderAsyncAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///1:添加订单（简单rpc模式）
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::OrderService.AddOrderResponse> AddOrderAsyncAsync(global::OrderService.AddOrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddOrderAsync, null, options, request);
      }
      /// <summary>
      ///2:修改订单 (客户端流模式)
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::OrderService.UpdateOrderRequest, global::OrderService.UpdateOrderReponse> UpdateOrderAsync(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateOrderAsync(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///2:修改订单 (客户端流模式)
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::OrderService.UpdateOrderRequest, global::OrderService.UpdateOrderReponse> UpdateOrderAsync(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UpdateOrderAsync, null, options);
      }
      /// <summary>
      ///3:删除订单 (服务器端流模式)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::OrderService.RemoveOrderReponse> RemoveOrderAsync(global::OrderService.RemoveOrderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveOrderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///3:删除订单 (服务器端流模式)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::OrderService.RemoveOrderReponse> RemoveOrderAsync(global::OrderService.RemoveOrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_RemoveOrderAsync, null, options, request);
      }
      /// <summary>
      ///4:查询订单 (双向流模式)
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::OrderService.QueryOrderRequest, global::OrderService.QueryOrderReponse> QueryOrderAsync(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryOrderAsync(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///4:查询订单 (双向流模式)
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::OrderService.QueryOrderRequest, global::OrderService.QueryOrderReponse> QueryOrderAsync(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_QueryOrderAsync, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OrderServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OrderServiceClient(configuration);
      }
    }

  }
}
#endregion
