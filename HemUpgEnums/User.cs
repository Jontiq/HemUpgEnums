using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemUpgEnums
{
    internal class User
    {
        //enums
        public enum UserRole
        {
            Admin,
            Moderator,
            User,
            Guest,
        }
        //props
        public UserRole Role { get; set; }

        //constructor
        public User(UserRole role)
        {
            Role = role;
        }

        //methods
        public void PrintRoleMessage()
        {
            switch (Role)
            {
                case UserRole.Admin:
                {
                        Console.WriteLine($"Welcome, {Role}! You have full access.");
                        break;
                }
                case UserRole.Moderator:
                {
                        Console.WriteLine($"Welcome, {Role}! You can manage content.");
                        break;
                }
                case UserRole.User:
                {
                        Console.WriteLine($"Welcome, {Role}! You can view and comment.");
                        break;
                }
                case UserRole.Guest:
                {
                        Console.WriteLine($"Welcome, {Role}! You have limited access.");
                        break;
                }
            }
        }



    }
}
