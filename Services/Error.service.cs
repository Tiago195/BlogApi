using System.Text.Json;
public static class ErrorService
{
  public static string Generate(string message, int statusCode)
  {
    return JsonSerializer.Serialize(new { message, statusCode });
  }
}