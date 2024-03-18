namespace HR_Management.Application.Models.Identity;

public class AuthResponse
{
    public string Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;

}