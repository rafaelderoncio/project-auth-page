using System.Text.Json.Serialization;

namespace Project.Auth.Domain.Responses;

public class ExceptionResponse
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}
