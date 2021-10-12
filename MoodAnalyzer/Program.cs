using System;

namespace MoodAnalyzer
{
    class Program
    {
        public const string HAPPY_MOOD = "I am in Happy mood";
        public const string SAD_MOOD = "I am in Sad mood";
        class MoodAnalyser
        {
            public void MoodAnalyze(string mood)
            {
                if (mood.Contains(HAPPY_MOOD))
                {
                    Console.WriteLine("Happy");
                    return;
                }
                if (mood.Contains(SAD_MOOD))
                {
                    Console.WriteLine("Sad");
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            bool isExit = false;
            int options;
            while (!isExit)
            {
                Console.WriteLine("choose 1.CreateAndRespondMoodAnalyser");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        MoodAnalyser moodAnalyser = new MoodAnalyser();
                        moodAnalyser.MoodAnalyze(SAD_MOOD);
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }

        }
    }
}