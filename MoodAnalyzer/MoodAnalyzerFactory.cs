using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public static Object createMoodAnalyse(string className,string constructorName)
        {
            string patteren = @"." + constructorName + "$";
            Match result = Regex.Match(className, patteren);
            if (result.Success)
            {
                try
                {
                    Assembly exceuting = Assembly.GetExecutingAssembly();
                    Type MoodAnalysetype = exceuting.GetType(className);
                    return Activator.CreateInstance(MoodAnalysetype);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
            }
        }
    }
}
