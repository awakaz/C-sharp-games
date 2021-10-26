using System.Collections.Generic;


namespace GeniousIdiotCommon
{
    public class DiagnoseCalculator
    {
        static List<Diagnoses> Get()
        {
            var diagnoses = new List<Diagnoses>();
            diagnoses.Add(new Diagnoses("Идиот", 0));
            diagnoses.Add(new Diagnoses("Кретин", 20));
            diagnoses.Add(new Diagnoses("Дурак", 40));
            diagnoses.Add(new Diagnoses("Нормальный", 60));
            diagnoses.Add(new Diagnoses("Талант", 80));
            diagnoses.Add(new Diagnoses("Гений", 100));
            return diagnoses;
        }
        public static void Calculate(int countQuestions, User user)
        {
            var percentRightAnswers = (double)user.CountRightAnswers / countQuestions * 100;
            var diagnoses = Get();
            for (int i = 0; i < 6; i++)
            {
                if (percentRightAnswers <= diagnoses[i].Percent)
                {
                    user.Diagnose = diagnoses[i].Name;
                    return;
                }
            }
            return;
        }
    }
}
