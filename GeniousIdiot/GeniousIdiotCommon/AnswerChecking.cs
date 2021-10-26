using System;

namespace GeniousIdiotCommon
{
    public class AnswerChecking
    {
        public static bool Test (string userAnswer, out int userAnswerInt, out string message)
        {
            userAnswerInt = 0;
            message = "";

            try
            {
                userAnswerInt = Convert.ToInt32(userAnswer);
                return true;
            }
            catch(FormatException)
            {
                message = "Введите число";
                return false;
            }
            catch(OverflowException)
            {
                message = "Введите число меньше 10^9";
                return false;
            }
        }
    }
}
