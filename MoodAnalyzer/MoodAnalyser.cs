using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public const string HAPPY_MOOD = "I am in Happy Mood";
        public const string SAD_MOOD = "I am in Sad Mood";
        public string mood;
        public MoodAnalyser(string mood){
            this.mood = mood;
        }
        public string MoodAnalyze()
        {
            try//this block will test for exception
            {
                if(this.mood.ToLower().Contains("happy"))
                {
                    Console.WriteLine("I am in happy mood");
                    return "Happy";
                }
                if (this.mood.ToLower().Contains("sad"))
                {
                    Console.WriteLine("I am in sad mood");
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException e)//this block will catch the exception if there
            {
                return e.Message;
            }
        }
    }
}
