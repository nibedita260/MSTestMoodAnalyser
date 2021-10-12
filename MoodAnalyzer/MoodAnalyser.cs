using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public const string HAPPY_MOOD = "Happy";
        public const string SAD_MOOD = "Sad";
        public string MoodAnalyze(string mood)
        {
            if (mood.ToLower().Contains("happy"))
            {
                Console.WriteLine(HAPPY_MOOD);
                return HAPPY_MOOD;
            }
            if (mood.ToLower().Contains("sad"))
            {
                Console.WriteLine(SAD_MOOD);
                return SAD_MOOD;
            }
            else
            {
                return null;
            }
        }
    }
}
