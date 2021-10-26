using GeniousIdiotCommon;
using System;
using System.Collections.Generic;

namespace GeniousIdiotConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ФИО:");

            User userData = new User(Console.ReadLine(), 0, "");

            var game = new Game(userData);

            var countQuestions = game.GetQuestionsCount();

            for (int i = 0; i < countQuestions; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));

                var currentQuestion = game.PopRandomQuestion();

                Console.WriteLine(currentQuestion.Text);

                game.AcceptAnswer(GetUserAnswer());  
            }

            Console.WriteLine("Количество правильных ответов: " + userData.CountRightAnswers);
            Console.WriteLine(game.CalculateDiagnose());

            ResultsStorage.Save(userData);
            Console.WriteLine("Хотите посмотреть результаты предыдущих игр? Нажмите Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
               Console.WriteLine();
               List<User> players = ResultsStorage.GetAll();
               ShowTableResults(players);
            }
            Console.WriteLine("Хотите добавить новый вопрос? Нажмите Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("Введите вопрос и ответ, ответ должен быть числом");
                Questions userQuestion = new Questions(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                QuestionsStorage.Save(userQuestion);
            }
        }
        private static void ShowTableResults(List<User> players)
        {
            Console.WriteLine(String.Format("{0,-30} {1,-25} {2,10}", "ФИО", "Кол-во правильных ответов", "Диагноз"));
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine(String.Format("{0,-30} {1,-25} {2,10}", players[i].Name, players[i].CountRightAnswers, players[i].Diagnose));
            }
        }

        public static int GetUserAnswer()
        {
            string answer = Console.ReadLine();
            while (true)
            {
                if (AnswerChecking.Test(answer,out int userAnswerInt, out string message) == true)
                {
                    return Convert.ToInt32(answer);
                }
                else
                {
                    Console.WriteLine(message);
                }
                answer = Console.ReadLine();
            }
        }
    }
}

