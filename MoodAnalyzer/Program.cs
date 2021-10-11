using System;

namespace MoodAnalyzer
{
    class Program
    {
        public const string HAPPY_MOOD = "Happy";
        public const string SAD_MOOD = "Sad";
        class MoodAnalyser
        {
            public void MoodAnalyze(string mood)
            {
                if (mood.Contains(HAPPY_MOOD))
                {
                    Console.WriteLine("I am in Happy mood");

                    return;
                }
                if (mood.Contains(SAD_MOOD))
                {
                    Console.WriteLine("I am in Sad mood");
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
                        moodAnalyser.MoodAnalyze(HAPPY_MOOD);
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }

        }
    }
}