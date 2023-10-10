// Class Moderator inheriting from User
namespace MyMod
{
public class Moderator : User
{
    public List<string> GrantedModules { get; private set; }

    public Moderator(string login, string password, List<string> grantedModules)
        : base(login, password)
    {
        if (grantedModules == null || grantedModules.Count == 0)
        {
            throw new ArgumentException("Granted modules list must not be null or empty.");
        }

        this.GrantedModules = grantedModules;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Granted Modules: " + string.Join(", ", this.GrantedModules));
    }
}
}