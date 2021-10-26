using Newtonsoft.Json;
using System.Collections.Generic;


namespace GeniousIdiotCommon
{
    public class ResultsStorage
    {
        private static string path = "userResults.json";
        public static void Save(User user)
        {
            var usersList = GetAll();
            usersList.Add(user);
            SaveTotalInfo(usersList);
        }

        public static void SaveTotalInfo(List<User> users)
        {
            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }
        public static List<User> GetAll()
        {
            List<User> users = new List<User>();
            if (FileProvider.Exist(path) == false)
            {
                return users;
            }
            var jsonOut = FileProvider.Get(path);
            users = JsonConvert.DeserializeObject<List<User>>(jsonOut);
            return users;
        }
       
    }
}
