using System.Net;
using System.Text.Json;
using ECommerce.Shared.Exceptions;
using ECommerce.Shared.Helpers;

namespace ECommerce.API.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(
        HttpContext context,
        Exception exception)
    {
        HttpStatusCode statusCode =
            HttpStatusCode.InternalServerError;

        string message = exception.Message;

        switch (exception)
        {
            case BadRequestException:
                statusCode = HttpStatusCode.BadRequest;
                break;

            case UnauthorizedException:
                statusCode = HttpStatusCode.Unauthorized;
                break;

            case NotFoundException:
                statusCode = HttpStatusCode.NotFound;
                break;
        }

        var response = new ApiResponse<string>
        {
            Success = false,
            Message = message
        };

        context.Response.ContentType =
            "application/json";

        context.Response.StatusCode =
            (int)statusCode;

        return context.Response.WriteAsync(
            JsonSerializer.Serialize(response));
    }
}