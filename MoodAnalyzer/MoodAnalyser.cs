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
            if (mood.ToLower().Contains("happy"))
            {
                Console.WriteLine(HAPPY_MOOD);
                return HAPPY_MOOD;
            }
            if(mood.ToLower().Contains("sad"))
            {
                Console.WriteLine(SAD_MOOD);
                return SAD_MOOD;
            }
            else
            {
                Console.WriteLine(HAPPY_MOOD);
                return HAPPY_MOOD;
            }
        }
    }
}
