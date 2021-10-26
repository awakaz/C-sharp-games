using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GeniousIdiotCommon
{
    public class QuestionsStorage
    {
        static string pathQ = "userQuestions.json";

        public static void Save(Questions userQuestion)
        {
            var questions = Out();
            questions.Add(userQuestion);
            SaveTotalQuestions(questions);
        }
        
        public static void SaveTotalQuestions(List<Questions> questions)
        {
            var serializedData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(pathQ, serializedData);
        }
        public static List<Questions> Out()
        {
            List<Questions> listQuestions = new List<Questions>();
            if(FileProvider.Exist(pathQ) == false)
            {
                return listQuestions;
            }
            var line = FileProvider.Get(pathQ);
            listQuestions = JsonConvert.DeserializeObject<List<Questions>>(line);
            return listQuestions;
        }
        public static List<Questions> GetQuestions()
        {
            var questions = new List<Questions>();
            questions.Add(new Questions("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Questions("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
            questions.Add(new Questions("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Questions("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
            questions.Add(new Questions("Пять свячей горело, две потухли. Сколько свечей осталось?", 2));
            if (FileProvider.Exist(pathQ) == true)
            {
               List<Questions> userQuestions = Out();
               for(int i = 0; i <userQuestions.Count; i++)
                {
                    questions.Add(userQuestions[i]);
                }
            }
            return questions;
        }
    }
}
