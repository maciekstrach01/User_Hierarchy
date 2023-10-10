// Administrator class inheriting from User
namespace MyAdmin
{
public class Administrator : User
{
    public int AccessLevel { get; private set; }

    public Administrator(string login, string password, int accessLevel)
        : base(login, password)
    {
        if (accessLevel < 1)
        {
            throw new ArgumentException("Access level must be at least 1.");
        }

        this.AccessLevel = accessLevel;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Access Level: {this.AccessLevel}");
    }
}
}