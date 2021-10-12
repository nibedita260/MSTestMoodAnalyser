using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        const string HAPPY_MOOD = "Happy";
        const string SAD_MOOD = "Sad";
        const string NULL = "Mood can't be Null";
        public string mood;
        public MoodAnalyser(string mood)
        {
            this.mood = mood;
        }
        public string MoodAnalyze()
        {
            try//this block will test for exception
            {
                if (this.mood.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not Empty");
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
            catch (NullReferenceException e)//this block will catch the exception if there
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, NULL);
            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
