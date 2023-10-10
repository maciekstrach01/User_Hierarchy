using System;
using System.Collections.Generic;
using MyAdmin;
using MyMod;
using MyRegUs;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Administrator admin = new Administrator("website administrator", "password website administrator", 2);
            Moderator mod = new Moderator("website moderator", "password website moderator", new List<string> { "1.User content","2.Reporting of violations",  "3.Rules of the community", "4.Reporting and moderation of reported content" });
            RegularUser user = new RegularUser("website user", "password website user");

            admin.GetInfo();
            mod.GetInfo();
            user.GetInfo();
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
