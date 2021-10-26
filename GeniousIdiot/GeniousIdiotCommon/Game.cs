using System;
using System.Collections.Generic;

namespace GeniousIdiotCommon
{
    public class Game
    {
        private List<Questions> questions;
        private Questions currentQuestion;
        private int allQuestionsCount;
        private User user;

        public Game(User newUser)
        {
            user = newUser;
            questions = QuestionsStorage.GetQuestions();
            allQuestionsCount = questions.Count;
        }
        public Questions PopRandomQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            questions.RemoveAt(randomQuestionIndex);
            return currentQuestion;
        }
        
        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (rightAnswer == userAnswer)
            {
                user.AcceptRightAnswers();
            }

        }

        public string CalculateDiagnose()
        {
            DiagnoseCalculator.Calculate(allQuestionsCount, user);
            return user.Name + ", " + "ваш диагноз: " + user.Diagnose;
        }
        public bool End()
        {
            return questions.Count == 0;
        }

        public int GetQuestionsCount()
        {
            return allQuestionsCount;
        }
    }

   
}
