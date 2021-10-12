using System;

namespace MoodAnalyzer
{
    public class Program
    {
        const string HAPPY_MOOD = "I am in Happy mood";
        const string SAD_MOOD = "I am in Sad mood";
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
                        MoodAnalyser moodAnalyser = new MoodAnalyser(SAD_MOOD);
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