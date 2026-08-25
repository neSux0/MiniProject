using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityAppMiniProjectWinForms.Data
{
    internal class AppData
    {
        //List may be needed for database later.
        private static List<User> Users { get; } = new();
        private static Dictionary<string, User> usersByUsername = new();
        private static Dictionary<int, User> userById = new();


    }
}
