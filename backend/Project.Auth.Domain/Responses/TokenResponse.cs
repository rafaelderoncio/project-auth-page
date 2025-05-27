using System.Text.Json.Serialization;

namespace Project.Auth.Domain.Responses;

public class TokenResponse
{
    [JsonPropertyName("accessToken")]
    public string AccessToken { get; set; }

    [JsonPropertyName("refreshToken")]
    public string RefreshToken { get; set; }
    
    [JsonPropertyName("expiresIn")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("tokeType")]
    public string TokenType { get; set; }
}
