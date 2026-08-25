using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityAppMiniProjectWinForms.Data
{
    internal class AppData
    {
        //List may be needed for database later.(uses o(n) search)
        private static List<User> Users { get; } = new();
        //allows O(1) search for conosle app. Search by id and username.
        private static Dictionary<string, User> usersByUsername = new();
        private static Dictionary<int, User> usersById = new();

        public static void AddUser(User user)
        {
            Users.Add(user);
            usersByUsername.Add(user.Username, user);
            usersById.Add(user.UserId, user);
        }


    }
}
