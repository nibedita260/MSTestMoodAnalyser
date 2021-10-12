using System;

namespace MoodAnalyzer
{
    public class Program
    {
        public const string HAPPY_MOOD = "I am in Happy Mood";
        public const string SAD_MOOD = "I am in Sad Mood";
        static void Main(string[] args)
        {
            bool isExit = false;
            int options;
            while (!isExit)
            {
                Console.WriteLine("choose 1.CreateAndRespondMoodAnalyser 2.CustomExceptionHandlingInMoodAnalyser");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Any Mood");
                        moodAnalyser.MoodAnalyze();
                        break;
                    case 2:
                        MoodAnalyser analyseForNullMood = new MoodAnalyser(null);
                        analyseForNullMood.MoodAnalyze();
                        break;
                    case 3:
                        MoodAnalyser analyseMood = new MoodAnalyser("");
                        analyseMood.MoodAnalyze();
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }

        }
    }
}