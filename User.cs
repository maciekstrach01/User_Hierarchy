// Base class User
public class User
{
    public string Login { get; private set; }
    public string Password { get; private set; }

    public User(string login, string password)
    {
        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Login and password must be non-empty.");
        }

        this.Login = login;
        this.Password = password;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"User: {this.Login}");
    }
}