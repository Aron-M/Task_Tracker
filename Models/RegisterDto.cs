namespace Task_tracker_API.Models
{
public class RegisterDto
{
    public RegisterDto(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }
}
}