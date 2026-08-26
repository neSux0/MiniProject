using System;
using System.Collections.Generic;
using System.Text;

using CommunityAppMiniProjectWinForms.Classes;

namespace CommunityAppMiniProjectWinForms.Data
{
    //make static so dont need to create an object of this class. use class directly for orgnaization.
    internal static class AppData
    {
        //List may be needed for database later.(uses o(n) search)
        private static List<User> Users { get; } = new();
        //allows O(1) search for conosle app. Search by id and username.
        private static Dictionary<string, User> usersByUsername = new();
        private static Dictionary<int, User> usersById = new();
        //contains all the issues in a list. 
        private static List<Issue> Issues { get; } = new(); 


        public static void AddIssue(Issue issue)
        {
            Issues.Add(issue);
        }
        public static void AddUser(User user)
        {
            Users.Add(user);
            usersByUsername.Add(user.Username, user);
            usersById.Add(user.UserId, user);
        }
        public static bool ContainsUser(string username)
        {
            if (usersByUsername.ContainsKey(username)) return true;
            return false;
        }


        //=======ACCESSORS================
        public static List<Issue> IssuesList
        {
            get { return Issues; }
        }
    }
}
