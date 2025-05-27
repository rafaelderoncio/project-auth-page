using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Auth.Domain.Requests;

public class TokenRequest
{
    [JsonPropertyName("refreshToken")]
    [FromForm(Name = "refresh_token")]
    public string RefreshToken { get; set; }
}
