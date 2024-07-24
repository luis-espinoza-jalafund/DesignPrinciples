namespace LeastAstonishment;

public class UserManager
{
  private readonly List<User> _users = new List<User>();

  public void AddUser(string username, string email, string password)
  {
    _users.Add(new User(username, email, password));
    Console.WriteLine($"User {username} added.");
  }

  public void UpdateUserPassword(string username, string newPassword)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);

    if (user != null)
    {
      user.UpdatePassword(newPassword);
    }
    else
    {
      Console.WriteLine($"User with username {username} not found.");
    }
  }

  public void SetUserRole(string username, string role)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);
    
    if (user != null)
    {
      user.Role = role;
      Console.WriteLine($"Role set for {username}.");
    }
    else
    {
        Console.WriteLine($"User {username} not found.");
    }
  }

  public void DisplayUserDetails(string username)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);
    
    if (user != null)
    {
      Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Role: {user.Role}");
    }
    else
    {
        Console.WriteLine($"User {username} not found.");
    }
  }

  public void RemoveUser(string username)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);

    if (user != null)
    {
        _users.Remove(user);
        Console.WriteLine($"User {username} removed.");
    }
    else
    {
        Console.WriteLine($"User {username} not found.");
    }
  }
}
