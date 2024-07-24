namespace LeastAstonishment;
using System.Text.RegularExpressions;

public class User
{
  public string Username { get; set; }
  
  public string Email { get; set; }
  
  public string Password;
  
  public string Role { get; set; }

  public User(string username, string email, string password)
  {
    if (!IsValidEmail(email)) 
    {
      throw new ArgumentException("Invalid email address.");
    }

    Username = username;
    Email = email;
    Password = password;
  }

  public void UpdatePassword(string newPassword)
  {
    if (string.IsNullOrWhiteSpace(newPassword))
    {
      throw new ArgumentException("New password cannot be empty.");
    }

    Password = newPassword;
  }

  private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
}
