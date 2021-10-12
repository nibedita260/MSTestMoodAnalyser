using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        const string HAPPY_MOOD = "Happy";
        const string SAD_MOOD = "Sad";
        const string NULL = "Mood Can't be Null";
        public string mood;
        public MoodAnalyser(string mood)
        {
            this.mood = mood;
        }
        public string MoodAnalyze()
        {
            try//this block will test for exception
            {
                if (this.mood.ToLower().Contains("happy"))
                {
                    Console.WriteLine(HAPPY_MOOD);
                    return HAPPY_MOOD;
                }
                if (this.mood.ToLower().Contains("sad"))
                {
                    Console.WriteLine(SAD_MOOD);
                    return SAD_MOOD;
                }
                else
                {
                    Console.WriteLine(NULL);
                    return NULL;
                }
            }
            catch (NullReferenceException)//this block will catch the exception if there
            {
                Console.WriteLine(NULL);
                return NULL;
            }
        }
    }
}
