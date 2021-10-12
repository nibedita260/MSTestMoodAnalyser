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
                Console.WriteLine("choose 1.HappyMoodAnalyser 2.HappyMoodAnalyser 3.NullMoodAnalyser");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        MoodAnalyser moodAnalyser = new MoodAnalyser(HAPPY_MOOD);
                        moodAnalyser.MoodAnalyze();
                        break;
                    case 2:
                        MoodAnalyser moodAnalyse = new MoodAnalyser(SAD_MOOD);
                        moodAnalyse.MoodAnalyze();
                        break;
                    case 3:
                        MoodAnalyser moodAnalyze = new MoodAnalyser("null");
                        moodAnalyze.MoodAnalyze();
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }

        }
    }
}