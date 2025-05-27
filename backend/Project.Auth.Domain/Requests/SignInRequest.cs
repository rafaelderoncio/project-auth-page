using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Auth.Domain.Requests;

public class SignInRequest
{
    [JsonPropertyName("username")]
    [FromForm(Name = "username")]
    public string Username { get; set; }

    [JsonPropertyName("password")]
    [FromForm(Name = "password")]
    public string Password { get; set; }

    [JsonPropertyName("remember_me")]
    [FromForm(Name = "remember_me")]
    public bool RememberMe { get; set; }

    [JsonPropertyName("grant_type")]
    [FromForm(Name = "grant_type")]
    public string GrantTypes { get; set; }
};