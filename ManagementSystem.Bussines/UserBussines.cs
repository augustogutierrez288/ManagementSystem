using ManagementSystem.Data;
using ManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Bussines
{
    public class UserBussines
    {
        public static List<User> LoadUser()
        {
            return UserData.LoadUser();
        }

        public static void CreateUser(User user)
        {
            UserData.CreateUser(user);
        }

        public static void UpdateUser(User user)
        {
            UserData.UpdateUser(user);
        }

        public static void DeleteUser(User user)
        {
            UserData.DeleteUser(user);
        }
    }
}
