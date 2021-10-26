using System.IO;


namespace GeniousIdiotCommon
{
    public class FileProvider
    {
        public static void Append(string path, string info)
        {
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(info);
            }
            return;
        }

        public static void Replace(string path, string info)
        {
            using (StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                writer.WriteLine(info);
            }
            return;
        }

        public static string Get(string path)
        {
            string line = "";
            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.Default, true))
            {
                line = reader.ReadToEnd();
            }
            return line;
        }
        public static bool Exist(string path)
        {
            return File.Exists(path);
        }
    }
}
