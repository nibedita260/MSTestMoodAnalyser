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
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not Empty");
                }
                if (this.mood.ToLower().Contains("sad"))
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
            catch (NullReferenceException)//this block will catch exception if there
            {
<<<<<<< HEAD
                Console.WriteLine(NULL);
                return NULL;
=======
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood can't be Null");
                //Console.WriteLine(NULL);
                //return NULL;
>>>>>>> UC4-CustomExceptionMoodAnalyser
            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
