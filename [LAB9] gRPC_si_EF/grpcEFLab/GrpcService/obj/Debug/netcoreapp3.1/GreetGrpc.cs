// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class PostComment
  {
    static readonly string __ServiceName = "PostComment";

    static readonly grpc::Marshaller<global::GrpcService.PostRequest> __Marshaller_PostRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostResponse> __Marshaller_PostResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Id> __Marshaller_Id = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Id.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.UniversalResponse> __Marshaller_UniversalResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.UniversalResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostRequestUpdate> __Marshaller_PostRequestUpdate = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostRequestUpdate.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostsRespose> __Marshaller_PostsRespose = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostsRespose.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.CommentRequest> __Marshaller_CommentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.CommentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.CommentResponse> __Marshaller_CommentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.CommentResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.CommentRequestUpdate> __Marshaller_CommentRequestUpdate = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.CommentRequestUpdate.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.PostRequest, global::GrpcService.PostResponse> __Method_AddPost = new grpc::Method<global::GrpcService.PostRequest, global::GrpcService.PostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_PostRequest,
        __Marshaller_PostResponse);

    static readonly grpc::Method<global::GrpcService.Id, global::GrpcService.UniversalResponse> __Method_DeletePostById = new grpc::Method<global::GrpcService.Id, global::GrpcService.UniversalResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePostById",
        __Marshaller_Id,
        __Marshaller_UniversalResponse);

    static readonly grpc::Method<global::GrpcService.Id, global::GrpcService.PostResponse> __Method_GetPostById = new grpc::Method<global::GrpcService.Id, global::GrpcService.PostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_Id,
        __Marshaller_PostResponse);

    static readonly grpc::Method<global::GrpcService.PostRequestUpdate, global::GrpcService.PostResponse> __Method_UpdatePost = new grpc::Method<global::GrpcService.PostRequestUpdate, global::GrpcService.PostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_PostRequestUpdate,
        __Marshaller_PostResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.PostsRespose> __Method_GetAllPosts = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.PostsRespose>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PostsRespose);

    static readonly grpc::Method<global::GrpcService.CommentRequest, global::GrpcService.CommentResponse> __Method_AddComment = new grpc::Method<global::GrpcService.CommentRequest, global::GrpcService.CommentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_CommentRequest,
        __Marshaller_CommentResponse);

    static readonly grpc::Method<global::GrpcService.Id, global::GrpcService.CommentResponse> __Method_GetCommentById = new grpc::Method<global::GrpcService.Id, global::GrpcService.CommentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentById",
        __Marshaller_Id,
        __Marshaller_CommentResponse);

    static readonly grpc::Method<global::GrpcService.CommentRequestUpdate, global::GrpcService.CommentResponse> __Method_UpdateComment = new grpc::Method<global::GrpcService.CommentRequestUpdate, global::GrpcService.CommentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_CommentRequestUpdate,
        __Marshaller_CommentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PostComment</summary>
    [grpc::BindServiceMethod(typeof(PostComment), "BindService")]
    public abstract partial class PostCommentBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostResponse> AddPost(global::GrpcService.PostRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.UniversalResponse> DeletePostById(global::GrpcService.Id request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostResponse> GetPostById(global::GrpcService.Id request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostResponse> UpdatePost(global::GrpcService.PostRequestUpdate request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostsRespose> GetAllPosts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.CommentResponse> AddComment(global::GrpcService.CommentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.CommentResponse> GetCommentById(global::GrpcService.Id request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.CommentResponse> UpdateComment(global::GrpcService.CommentRequestUpdate request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PostCommentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_DeletePostById, serviceImpl.DeletePostById)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_GetAllPosts, serviceImpl.GetAllPosts)
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_GetCommentById, serviceImpl.GetCommentById)
          .AddMethod(__Method_UpdateComment, serviceImpl.UpdateComment).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PostCommentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostRequest, global::GrpcService.PostResponse>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_DeletePostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Id, global::GrpcService.UniversalResponse>(serviceImpl.DeletePostById));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Id, global::GrpcService.PostResponse>(serviceImpl.GetPostById));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostRequestUpdate, global::GrpcService.PostResponse>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_GetAllPosts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.PostsRespose>(serviceImpl.GetAllPosts));
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.CommentRequest, global::GrpcService.CommentResponse>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_GetCommentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Id, global::GrpcService.CommentResponse>(serviceImpl.GetCommentById));
      serviceBinder.AddMethod(__Method_UpdateComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.CommentRequestUpdate, global::GrpcService.CommentResponse>(serviceImpl.UpdateComment));
    }

  }
}
#endregion
