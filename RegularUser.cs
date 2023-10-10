// Class RegularUser inheriting from User
namespace MyRegUs
{
public class RegularUser : User
{
    public RegularUser(string login, string password)
        : base(login, password)
    {
    }
}
}