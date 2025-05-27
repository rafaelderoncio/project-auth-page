using System.Text.Json.Serialization;

namespace Project.Auth.Domain.Responses;

public class SignOutResponse
{
    [JsonPropertyName("status")]
    public string status { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
