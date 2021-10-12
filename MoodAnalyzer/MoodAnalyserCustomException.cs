﻿using System;
using System.Runtime.Serialization;

namespace MoodAnalyzer
{
    [Serializable]
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

        public readonly ExceptionType type;
        /// <summary>
        /// creating a constructor and passing string message and exception type 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}