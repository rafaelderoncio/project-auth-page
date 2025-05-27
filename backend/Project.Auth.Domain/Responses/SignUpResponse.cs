using System.Text.Json.Serialization;

namespace Project.Auth.Domain.Responses;

public class SignUpResponse
{
    [JsonPropertyName("status")]
    public string status { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
