using System;
using System.Collections.Generic;
using System.IO;
namespace _2048WindowsFormsApp
{
    public class ResultsStorage
    {
        private static string pathResults = "results.txt";
        private static string path = "bestScore.txt";
        public static List<User> Get()
        {
            List<User> list = new List<User>();
            if (File.Exists(pathResults))
            {
                var reader = new StreamReader(pathResults);
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] lineResults = new string[2];
                    for (int i = 0; i < 2; i++)
                    {
                        lineResults[i] = line;
                        line = reader.ReadLine();
                    }
                    list.Add(new User(lineResults[0], Convert.ToInt32(lineResults[1])));
                }
                reader.Close();
            }
            return list;
        }
        public static void Save(User user)
        {
            var writer = new StreamWriter(pathResults, true);
            writer.WriteLine(user.name);
            writer.WriteLine(user.result);
            writer.Close();
        }
        public static User GetBestPlayer()
        {
            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                string bestResult = reader.ReadLine();
                string bestPlayerName = reader.ReadLine();
                var bestPlayer = new User(bestPlayerName, Convert.ToInt32(bestResult));
                reader.Close();
                return bestPlayer;
            }
            else
            {
                return new User("", 0);
            }
        }
        public static void SaveBest(User bestUser)
        {
            var writer = new StreamWriter(path, false);
            writer.WriteLine(bestUser.result);
            writer.WriteLine(bestUser.name);
            writer.Close();
        }
    }
}
