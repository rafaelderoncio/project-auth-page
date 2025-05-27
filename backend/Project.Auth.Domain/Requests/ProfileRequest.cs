
namespace Project.Auth.Domain.Requests;

public class ProfileRequest
{
    public string FirstName { get; set; }
    public string LasttName { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
}
