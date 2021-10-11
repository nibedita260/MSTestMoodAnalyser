using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public const string HAPPY_MOOD = "Happy";
        public const string SAD_MOOD = "Sad";
        public string mood;
        public MoodAnalyser(string mood){
            this.mood = mood;
        }
        public string MoodAnalyze()
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
