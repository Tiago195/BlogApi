using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.Net;

public class IErrorHandler
{
  public string message { get; set; }
  public int statusCode { get; set; }
}

public class ErrorHandler : IMiddleware

{
  public async Task InvokeAsync(HttpContext context, RequestDelegate next)
  {
    try
    {
      await next(context);
    }
    catch (System.Exception e)
    {
      System.Console.WriteLine("batata");
      var error = JsonSerializer.Deserialize<IErrorHandler>(e.Message);
      if (error.statusCode != null)
      {

        var message = JsonSerializer.Serialize(new { message = error.message });
        context.Response.StatusCode = error.statusCode;
        await context.Response.WriteAsync(message);
      }
      else
      {
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync(e.Message);
      }
      // throw;
    }
  }
}