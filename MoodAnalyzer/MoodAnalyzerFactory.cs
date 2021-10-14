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
        public static object CreateMoodAnalyserObjectUsingParametzisedConstructor(string className, string constructorName,string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
        public static string InvokeAnalyseMood(string message,string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.MoodAnalyser");
                object moodAnalyseObject = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }
        public static string SetField(string message, string fieldName)
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_FIELD, "Message should not be null");
                }
                field.SetValue(moodAnalyser, message);
                return moodAnalyser.mood;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_FIELD, "Field is Not Found");
            }
        }
    }
}
