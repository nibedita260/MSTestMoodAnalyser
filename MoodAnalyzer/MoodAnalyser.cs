using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public const string HAPPY_MOOD = "Happy";
        public const string SAD_MOOD = "Sad";
        bool mood;
        public string MoodAnalyze(string mood)
        {
            if (mood==HAPPY_MOOD)
            {
                Console.WriteLine("I am in Happy mood");
                return HAPPY_MOOD;
            }
            else
            {
                Console.WriteLine("I am in Sad mood");
                return SAD_MOOD;
            }
        }
    }
}
