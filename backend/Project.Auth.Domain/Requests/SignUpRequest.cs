using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Auth.Domain.Requests;

public class SignUpRequest
{
    [JsonPropertyName("firstName")]
    [FromForm(Name = "first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    [FromForm(Name = "last_name")]
    public string LasttName { get; set; }

    [JsonPropertyName("gender")]
    [FromForm(Name = "gender")]
    public string Gender { get; set; }

    [JsonPropertyName("birthdate")]
    [FromForm(Name = "birth_date")]
    public DateTime BirthDate { get; set; }

    [JsonPropertyName("email")]
    [FromForm(Name = "email")]
    public string Email { get; set; }

    [JsonPropertyName("password")]
    [FromForm(Name = "password")]
    public string Password { get; set; }

    [JsonPropertyName("confirmPassword")]
    [FromForm(Name = "confirm_password")]
    public string ConfirmPassword { get; set; }
}
