using System;

namespace MoodAnalyzer
{
    public class Program
    {
        public const string HAPPY_MOOD = "Happy";
        public const string SAD_MOOD = "Sad";
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
                        MoodAnalyser moodAnalyser = new MoodAnalyser(HAPPY_MOOD);
                        moodAnalyser.MoodAnalyze();
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }

        }
    }
}