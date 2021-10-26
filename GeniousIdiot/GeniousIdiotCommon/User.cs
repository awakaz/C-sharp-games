namespace GeniousIdiotCommon
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;
        public User(string name, int count, string diagnose)
        {
            Name = name;
            CountRightAnswers = count;
            Diagnose = diagnose;
        }
        public void AcceptRightAnswers()
        {
            CountRightAnswers++;
        }
    }
}

