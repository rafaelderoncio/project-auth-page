using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Auth.Domain.Responses;

public class ProfileResponse
{
    [JsonPropertyName("firstame")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastname")]
    public string LasttName { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("birthdate")]
    public DateTime BirthDate { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }
}
